using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Repair_shop
{
    public partial class StorageFrom : Form
    {
        public string CString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\magazin\Desktop\Repair_shop\Repair_shop\RepairBase.mdf;Integrated Security=True";
        public SqlConnection SqlC;
        string sql = "SELECT * FROM DetailsTable";

        public StorageFrom()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;
            using (SqlConnection conn = new SqlConnection(CString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                // 1. set DisplayMember and ValueMember 
                listBox1.DisplayMember = dt.Columns[0].ColumnName;
                listBox1.ValueMember = dt.Columns[1].ColumnName;
                // 2. set DataSource 
                listBox1.DataSource = dt;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlC = new SqlConnection(CString);
            SqlC.Open();
            SqlDataReader SqlR = null;
            SqlCommand cmd = new SqlCommand("UPDATE DetailsTable SET DetailsTable.Quantity=(SELECT Quantity FROM DetailsTable WHERE Id_Art=" + int.Parse(listBox1.Text) + ")+" + trackBar1.Value.ToString() + "WHERE Id_Art=" + int.Parse(listBox1.Text), SqlC);
            cmd.Connection = SqlC;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            label2.Text = "Количество";

            // this.detailsTableTableAdapter.Fill(this.repairBaseDataSet.DetailsTable);
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void StorageFrom_Load(object sender, EventArgs e)
        {            
            this.detailsTableTableAdapter.Fill(this.repairBaseDataSet.DetailsTable);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format($"Количество {trackBar1.Value}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm1 fmk = new MainForm1(); // Форма главного меню
            fmk.FormClosed += delegate { this.Show(); }; // Обработка закрытия
            Data.checker = false;
            fmk.Show(); // Показываем
            this.Hide(); // ЗАкрываем эту
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            this.detailsTableTableAdapter.Fill(this.repairBaseDataSet.DetailsTable);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlC = new SqlConnection(CString);
            SqlC.Open();
            SqlDataReader SqlR = null;
            SqlCommand cmd = new SqlCommand("UPDATE DetailsTable SET DetailsTable.Quantity=(SELECT Quantity FROM DetailsTable WHERE Id_Art=" + int.Parse(listBox1.Text) + ")-" + trackBar1.Value.ToString() + "WHERE Id_Art=" + int.Parse(listBox1.Text), SqlC);
            cmd.Connection = SqlC;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            label2.Text = "Количество";
        }



        private void remove_Click(object sender, EventArgs e)
        {
            SqlC = new SqlConnection(CString);
            SqlC.Open();
            SqlDataReader SqlR = null;
            SqlCommand cmd = new SqlCommand("DELETE FROM DetailsTable WHERE Id_Art=" + int.Parse(listBox1.Text), SqlC);
            cmd.Connection = SqlC;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На первой вкладке можно ознакомиться со всеми деталями на складе. " +
                "На следующей вкладке можно изменить данные на складе. Изменить количество деталей: прибавить(добавить)," +
                "убавить(списать), удалить ее полностью и добавить новую модель на склад."
                , "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void rfrsh_Click(object sender, EventArgs e)
        {
            
            SqlC = new SqlConnection(CString);
            SqlC.Open();
            SqlDataReader SqlR = null;
            SqlCommand comand = new SqlCommand("SELECT MAX(Id_Art) FROM DetailsTable",SqlC);
            string x = comand.ExecuteScalar().ToString();
            int g = Convert.ToInt32(x)+1;
            x = g.ToString();
            SqlCommand cmd = new SqlCommand("INSERT INTO DetailsTable (Id_Art,DetailModel,DtailType,Quantity,DetailPrice,Factory) VALUES(@Id,@DM, @DT, @Q, @DP, @F)", SqlC);
            cmd.Parameters.AddWithValue("Id", x);
            cmd.Parameters.AddWithValue("DM", textBox1.Text);
            cmd.Parameters.AddWithValue("DT", textBox2.Text);
            cmd.Parameters.AddWithValue("Q", textBox3.Text);
            cmd.Parameters.AddWithValue("DP", textBox4.Text);
            cmd.Parameters.AddWithValue("F", textBox5.Text);
            cmd.Connection = SqlC;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
