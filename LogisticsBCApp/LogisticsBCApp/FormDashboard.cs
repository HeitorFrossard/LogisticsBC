using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisticsBCApp.EF_Classes;
using System.Diagnostics;
using System.IO;

namespace LogisticsBCApp
{
    public partial class FormDashboard : Form
    {
        LogisticsBCEntities context;

        public FormDashboard()
        {
            InitializeComponent();
            context = new LogisticsBCEntities();

            // setting debug log
            context.Database.Log = (s => Debug.Write(s));
            context.SaveChanges();
        }

        private void buttonReseedData_Click(object sender, EventArgs e)
        {
            // reset ident for all tables
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Areas', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Drivers', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Packages', RESEED, 0)");
            context.Database.ExecuteSqlCommand($"DBCC CHECKIDENT('Trucks', RESEED, 0)");

            //clearing data in the tables
            context.Areas.RemoveRange(context.Areas);
            context.Drivers.RemoveRange(context.Drivers);
            context.Packages.RemoveRange(context.Packages);
            context.Trucks.RemoveRange(context.Trucks);

            //creating blank lists for data
            List<Area> areaList = new List<Area>();
            List<Driver> driverList = new List<Driver>();
            List<Package> packageList = new List<Package>();
            List<Truck> truckList = new List<Truck>();

            String tempLine;

            //opening 'Data_Areas.csv' to populate areaList
            StreamReader areaFile = File.OpenText("Data_Area.csv");
            while (!areaFile.EndOfStream)
            {
                tempLine = areaFile.ReadLine();
                areaList.Add(new Area
                {
                    AreaName = tempLine
                });
            }
            areaFile.Close();
             
        }
    }
}
