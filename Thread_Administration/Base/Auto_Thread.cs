using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Thread_Administration.Base
{
    public abstract class Thread_Auto_Base
    {
        public abstract event Action<DateTime, string> Run_Log;

        public static event Action<DateTime> NewClass_Run;

        public static System.Collections.Generic.Queue<ProductionThreadBase> Auto_Th { get; set; }

        public Thread_Auto_Base()
        {
            Auto_Th = new System.Collections.Generic.Queue<ProductionThreadBase>();
        }

        public static void NewClass(int spintime = 50)
        {
            Type baseType = typeof(Thread_Auto_Base);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] derivedTypes = assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)).ToArray();
            foreach (Type derivedType in derivedTypes)
            {
                object instance = Activator.CreateInstance(derivedType);
                MethodInfo[] methods = derivedType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
                foreach (MethodInfo method in methods)
                {
                    var t = method.GetCustomAttributes(typeof(ProductionThreadBase), inherit: true);
                    if (t.Length > 0)
                        Thread_Configuration(derivedType.Name, method, instance, spintime);
                }
            }
            NewClass_Run?.Invoke(DateTime.Now);
        }

        private static void Thread_Configuration(string class_na, MethodInfo method, object class_new, int spintime)
        {
            Thread_Auto_Base instance = class_new as Thread_Auto_Base ?? throw new Exception("Automatic thread conversion exception");
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)method.GetCustomAttribute(typeof(DescriptionAttribute));
            ProductionThreadBase threadBase = new ProductionThreadBase()
            {
                Target = method.Name,
                Thread_Name = descriptionAttribute?.Description ?? method.Name,
                New_Thread = new Thread(() => { while (true) { Thread.Sleep(spintime); method.Invoke(instance, new object[] { instance }); } }),
            };
            threadBase.New_Thread.Name = class_na + "." + threadBase.Thread_Name;
            threadBase.New_Thread.IsBackground = true;
            threadBase.New_Thread.Start();
            Auto_Th?.Enqueue(threadBase);
        }

        [ProductionThreadBase]
        public abstract void Initialize(object thread);

        [ProductionThreadBase]
        public abstract void Main(object thread);

        [ProductionThreadBase]
        public abstract void Error(object thread);
    }
}
