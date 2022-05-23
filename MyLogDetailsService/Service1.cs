using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyLogDetailsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        // Run this command in VS IDE cmd in below folder
        //installUtil MyLogDetailsService.exe
        // To unistall use below code
        //installUtil -u MyLogDetailsService.exe
        protected override void OnStart(string[] args)
         {
            if (!File.Exists(@"D:\Cognizant\Cognizant Internship Data\Stage 3\20May\LogDetailsFolder\Log.txt"))
            {
                File.Create(@"D:\Cognizant\Cognizant Internship Data\Stage 3\20May\LogDetailsFolder\Log.txt");
            }
            using (StreamWriter sw = new StreamWriter(@"D:\Cognizant\Cognizant Internship Data\Stage 3\20May\LogDetailsFolder\Log.txt", true))
            {
                sw.WriteLine($"Service starts at : {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}");

            }
        }

        protected override void OnStop()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\Cognizant\Cognizant Internship Data\Stage 3\20May\LogDetailsFolder\Log.txt", true))
            {
                sw.WriteLine($"Service stops at : {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}");

            }

        }
    }
}
