using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace ConsoleApp1
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    public class Program
    {
        public static void Main()
        {
            TypeBuilder typeBuilder = CreateDynamicType();
            MethodInfo dynamicMethod = typeBuilder.GetMethod("Run");

            dynamicMethod.Invoke(null, null);
            Run();
        }

        public static TypeBuilder CreateDynamicType()
        {
            // 创建程序集和模块
            AssemblyName assemblyName = new AssemblyName("ConsoleApp1");
            AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("ConsoleApp1");

            // 创建类型
            TypeBuilder typeBuilder = moduleBuilder.DefineType("ConsoleApp1", TypeAttributes.Public);
            MethodBuilder methodBuilder = typeBuilder.DefineMethod("Run", MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[0]);

            // 获取ILGenerator
            ILGenerator ilGenerator = methodBuilder.GetILGenerator();

            // 在每行代码后注入指定方法
            //InjectMethodAfterEachLine(ilGenerator, typeof(Program).GetMethod("CustomMethod"));

            // 完成方法
            ilGenerator.Emit(OpCodes.Ret);

            // 创建类型
            Type dynamicType = typeBuilder.CreateType();

            return typeBuilder;
        }

        public static void CustomMethod()
        {
            Console.WriteLine("Custom method");
        }

        public static void Run()
        {
            Console.WriteLine("21");
            Console.WriteLine("21");
            Console.WriteLine("21");
            Console.WriteLine("21");
            Console.WriteLine("21");
            Console.ReadLine();
        }


        public static OpCode GetOpCode(byte opcodeValue)
        {
            FieldInfo[] opCodeFields = typeof(OpCodes).GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (var field in opCodeFields)
            {
                OpCode opCode = (OpCode)field.GetValue(null);

                if (opCode.Value == opcodeValue)
                {
                    return opCode;
                }
            }

            throw new ArgumentException("Invalid opcode value.");
        }
    }
}
