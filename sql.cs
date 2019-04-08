using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_SQL_OP
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-ORCL;Initial Catalog=msc17pw29;User ID=msc17pw29;Password=msc17pw29");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //id variable to update,ins,del
        int id = 0;

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from res", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            id = 0;
        }

        private void btn_INS_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("insert into res(name,state) values (@name,@state)", con);
                con.Open();

                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@state", textBox2.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("SUCCESSFULL INSERTION");
                DisplayData();
                ClearData();
            }

            else
            {
                MessageBox.Show("NO INPUT");
            }
        }

        private void btn_UPD_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("update res set name=@name,state=@state where name = @name", con);
                con.Open();

                //cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@state", textBox2.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("UPDATE SUCCESSFULL");
                DisplayData();
                ClearData();
            }

            else
            {
                MessageBox.Show("No ID selected");
            }
        }

        private void btn_DEL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                cmd = new SqlCommand("delete from res where name=@name", con);
                con.Open();

                //cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("DELETED");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("NO ID INPUT");
            }
        }

        private void rowheadmousclk_evnt(object sender, DataGridViewCellMouseEventArgs e)
        {
           // id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

    }
}
