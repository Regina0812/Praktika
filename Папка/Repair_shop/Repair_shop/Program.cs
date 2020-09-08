using System;
using System.Windows.Forms;
/*UPDATE ConsDetailTable
SET ConsPrice=(SELECT DetailsTable.DetailPrice FROM DetailsTable WHERE 
ConsDetailTable.Id_Art=DetailsTable.Id_Art) *ConsDetailTable.Quantity*/
/*UPDATE RepairMainTable
SET RepairTotalPrice = (SELECT SUM(ConsDetailTable.ConsPrice) FROM ConsDetailTable WHERE
  RepairMainTable.Id_Repair=ConsDetailTable.Id_Repair)+(SELECT ServiceTable.ServicePrice FROM
  ServiceTable WHERE RepairMainTable.Id_Service= ServiceTable.Id_Service)*/

namespace Repair_shop
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm1());
        }
    }
    static class Data
    {
        public static bool checker = true;
    }
}
