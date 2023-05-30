using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyTelePhone
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database2.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from Tabell1 where fname = '" + textBox1.Text + "'";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully removed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form2().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form1().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form2().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form3().ShowDialog();
        }
    }
}
