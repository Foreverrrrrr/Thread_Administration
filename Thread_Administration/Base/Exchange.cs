namespace Thread_Administration.Base
{
    public class Exchange
    {
        public byte[] Input { get; set; }
        public byte[] Output { get; set; }
        public bool[] Error { get; set; }

        public enum Send_Input : ushort
        {
            a, b, c, d, e, f, g,
        }

        public enum Send_Output : ushort
        {

        }

        public enum Send_Error : ushort
        {

        }
    }
}
