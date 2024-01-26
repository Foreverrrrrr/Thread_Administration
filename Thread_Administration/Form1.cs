using System;
using System.ComponentModel;
using System.Windows.Forms;
using Thread_Administration.Base;

namespace Thread_Administration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Thread_Auto_Base.NewClass();
            InitializeComponent();
            //MyClass myClass = new MyClass();
            Thread_Auto_Base.NewClass();
        }
    }


    public class MyClass : Thread_Auto_Base
    {
        public override event Action<DateTime, string> Run_Log;


        public MyClass() : base()
        {

        }

        public override void Error(object thread)
        {

        }

        public override void Initialize(object thread)
        {

        }

        
        public override void Main(object thread)
        {

        }
    }

    class MyClass1 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {
        }
    }

    class MyClass2 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {
        }
    }

    class MyClass3 : Thread_Auto_Base
    {
        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {

        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass4 : Thread_Auto_Base
    {
        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {

        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass5 : Thread_Auto_Base
    {
        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {
        }
    }


    class MyClass6 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {
        }
    }
    class MyClass7 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass8 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }
    class MyClass9 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass10 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass11: Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass12 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }

    class MyClass13 : Thread_Auto_Base
    {

        public override event Action<DateTime, string> Run_Log;

        public override void Error(object thread)
        {
        }

        public override void Initialize(object thread)
        {
        }

        public override void Main(object thread)
        {

        }
    }
}
