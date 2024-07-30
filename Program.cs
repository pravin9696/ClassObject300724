namespace ClassObject300724
{
    class classXYZ
    {
        private int x;
        private int y;
        string name;

        public string _name
        {
            set { name = value; }
            get { return name;  }
        }

        public int _y //property
        {
            get { return y; }
            set { y = value; }
        }
        public int Xvariable //property
        {
             set { 
                   x = value;             
                 }
            get
            {
                return x;
            }
        }
    }
    class AA
    {
        private int x;
        protected int y;
        public int z;
        public void methodAA()
        {
            x = 111;
            y = 222;
            z = 333;
        }
        protected void method2AA()
        {
            methodAA();

        }
    }
    class BB:AA
    {
        public void show()
        {
            methodAA();//public 
            method2AA();//protected method
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //AA objA=new AA();
            // //objA.x = 111;//invalid
            // // objA.y = 222;//invalid
            // objA.z = 333;//valid

            // objA.methodAA();
            //// objA.method2AA();

            classXYZ objx = new classXYZ();
            objx.Xvariable = 123;//set

            int p = objx.Xvariable;//get


        }
    }
}
