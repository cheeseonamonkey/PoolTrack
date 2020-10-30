using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Newtonsoft.Json;

namespace Pol 
{
    static class Program
    {
        static public ListViewItem selectedListItem { get; set; }
        
        static public List<string> employeeList = new List<string>();

        static public List<Reservation> reservationList = new List<Reservation>();

        public static void SaveLists()
        {

            string dat = JsonConvert.SerializeObject(reservationList);
            System.IO.File.WriteAllText("res.dat", dat);

            string edat = JsonConvert.SerializeObject(employeeList);
            System.IO.File.WriteAllText("emp.dat", edat);
        }

        public static void LoadLists()
        {
            if (File.Exists("res.dat"))
            {
                string dat = System.IO.File.ReadAllText("res.dat");
                reservationList = JsonConvert.DeserializeObject<List<Reservation>>(dat);
            }
            if (File.Exists("emp.dat"))
            {
                string edat = System.IO.File.ReadAllText("emp.dat");
                employeeList = JsonConvert.DeserializeObject<List<string>>(edat);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            

    }
    }
}
