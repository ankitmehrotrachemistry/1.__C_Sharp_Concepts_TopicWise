using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_Multiple_Interface
{
    public interface IInterface1
    {
        void Test();
        void Show();
    }
    public interface IInterface2
    {
        void Test();
        void Show();
    }
    class ImplementInterface : IInterface1, IInterface2
    {
        public void Test()
        {
            Console.WriteLine("Class Test Method");
        }
        public void Show()
        {
            Console.WriteLine("Class Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInterface ii = new ImplementInterface(); // Class Instance
            ii.Test();
            ii.Show();

            // Interface Reference created using Object of Class

            IInterface1 i1 = new ImplementInterface(); 
            i1.Test();
            i1.Show();

            IInterface2 i2 = new ImplementInterface();
            i2.Test();
            i2.Show();
        }
    }
}
