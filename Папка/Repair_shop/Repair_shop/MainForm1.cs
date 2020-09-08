using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Repair_shop
{
    public partial class MainForm1 : Form
    {
        public string CString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\magazin\Desktop\Repair_shop\Repair_shop\RepairBase.mdf;Integrated Security=True";
        public SqlConnection SqlC;
        public MainForm1()
        {
            InitializeComponent();    
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
         
        }
      

        private void ClientBtn_Click(object sender, EventArgs e)
        {
           
            ClientForm fmp = new ClientForm(); // Форма прайса
            fmp.FormClosed += delegate { this.Show(); }; // Обработка закрытия
            fmp.Show(); // Показываем
            this.Hide(); // ЗАкрываем эту
        }
        public void global_FormClosed(object sender,EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для ознакомления с прайс листом услуг "+
                "нажмите \"Прайс\"."+
                "\nДля добавления или списывания деталей нажмите \"Склад\".", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color. LightBlue;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            StorageFrom fmp = new StorageFrom(); // Форма склада
            fmp.FormClosed += delegate { this.Show(); }; // Обработка закрытия

            fmp.Show(); // Показываем
            this.Hide(); // ЗАкрываем эту
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
