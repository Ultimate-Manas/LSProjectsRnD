using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RnDCSharp
{
    class ProgramReflection
    {
        static void Main(string[] args)
        {
            //var asm = System.Reflection.Assembly.LoadFile("J:\\GIT\\LSProjectsRnD\\LSProjectsRnD\\LSGroupRnD\\RnDCSharp\\bin\\Debug\\TestLibrary.dll"); //System.Reflection.Assembly.Load(System.Reflection.AssemblyName.GetAssemblyName("TestLibrary"));
            //var type = asm.GetTypes();
            var asm = AppDomain.CurrentDomain.GetAssemblies(); //System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies();
            //asm.GetTypes().ToList().ForEach(p =>
            //{
            //    Console.WriteLine(p.Name);
            //});
            Console.ReadLine();
        }
    }
}
