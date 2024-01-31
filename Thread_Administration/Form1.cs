using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Thread_Administration.Base;

namespace Thread_Administration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread_Auto_Base.NewClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread_Auto_Base.Thraead_Dispose();
        }
    }

    public class MyClass : Thread_Auto_Base
    {
        public static MyClass myClass;
        public MyClass() : base()
        {
            myClass = this;
        }

        public override event Action<DateTime, string> Run_LogEvent;

        public override void Error(object thread)
        {

        }

        public override void Initialize(object thread)
        {

        }

        [Description("diyds")]
        public override void Main(object thread)
        {

        }

        public override void ThreadRestartEvent(ThreadAbortException ex, string class_na)
        {

        }
    }

    public class MyClass1 : Thread_Auto_Base
    {
        public static MyClass1 myClass;
        public MyClass1() : base()
        {
            myClass = this;
        }

        public override event Action<DateTime, string> Run_LogEvent;

        public override void Error(object thread)
        {

        }

        public override void Initialize(object thread)
        {

        }

        public override void Main(object thread)
        {

        }

        public override void ThreadRestartEvent(ThreadAbortException ex, string class_na)
        {

        }
    }
}
