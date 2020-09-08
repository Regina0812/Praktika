using System;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Repair_shop
{
    public partial class ClientForm : Form
    {
        
        public string CString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\magazin\Desktop\Repair_shop\Repair_shop\RepairBase.mdf;Integrated Security=True";
        public SqlConnection SqlC;
        public ClientForm()
        {
            InitializeComponent();            
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {                      
            this.serviceTableTableAdapter.Fill(this.repairBaseDataSet.ServiceTable);
        }

        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm1 fmk = new MainForm1(); // Форма главного меню
            fmk.FormClosed += delegate { this.Show(); }; // Обработка закрытия
            Data.checker = false;
            fmk.Show(); // Показываем
            this.Hide(); // ЗАкрываем эту
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того чтобы отсортировать строки по возрастанию или убыванию, нажмите на заголовки столбцов."+
                "\nДля того чтобы вернуться на главное меню, нажмите кнопку назад","Справка",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }            
    }
}
