using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsRegistry_06
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Console");
            var val = registryKey.GetValue("ColorTable12");
            Console.WriteLine("Value is :-");
            Console.WriteLine(val);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            var val2 = registryKey.GetValueNames();
            Console.WriteLine("All Values Names :-");
            foreach(var v2 in val2)
            {
                Console.WriteLine(v2);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            var val3 = registryKey.SubKeyCount;
            Console.WriteLine("Sub Key Count No : " +val3);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            var val4 = registryKey.GetSubKeyNames();
            Console.WriteLine("All Sub Key or Folders Names :-");
            foreach (var v4 in val4)
            {
                Console.WriteLine(v4);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            var val5 = registryKey.Name;
            Console.WriteLine("Get Folder Location with Folder Name :- ");
            Console.WriteLine(val5);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Program End Here");
            Console.WriteLine("Good Bye");
            
            Console.ReadKey();
        }
    }
}
