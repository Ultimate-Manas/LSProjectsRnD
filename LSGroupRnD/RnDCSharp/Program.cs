using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnDCSharp
{
    class ProgramStatis
    {
        static void Main(string[] args)
        {
            CheckStatic chkObj = new CheckStatic();
            chkObj.Show();
            CheckStatic chk = new CheckStatic(5);
            chk.Show();
            CheckStatic chk2 = new CheckStatic(6);
            chk2.Show();
            chk.ShowStatic();
            chk2.ShowStatic();
            Console.ReadLine();
            Console.WriteLine("Demo");

        }
    }

    class CheckStatic
    {
        int xNonStatix = 1;
        static int xStatic = 7;
        public CheckStatic()
        {

        }

        public CheckStatic(int num)
        {
            this.xNonStatix = num;
        }
        public void Show()
        {
            Console.WriteLine("X nostatic value is:" + this.xNonStatix);
        }

        public void ShowStatic()
        {
            Console.WriteLine("Static value is:" + CheckStatic.xStatic);
        }
    }
}
