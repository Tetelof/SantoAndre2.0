using System;
using System.Windows.Forms;

namespace SantoAndre
{
    class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MDISigleton.GetMDIParent());
        }
    }
}