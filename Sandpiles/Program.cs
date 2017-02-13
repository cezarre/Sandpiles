using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sandpiles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /// My CODE BELOW
            /// 
            try
            {
                ZeroFinder zeroFinder = new ZeroFinder(3,4);
                //Form1 form1 = new Form1(zeroFinder.zeroSand);
                //Application.Run(form1);
            }
            catch
            {
                Console.Error.WriteLine("Identity not found");
            }
            
        }

        
    }
}
