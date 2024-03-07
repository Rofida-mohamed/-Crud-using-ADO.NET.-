using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace dotDis2
{
    public partial class Form1 : Form
    {
        //SqlDataAdapter dAdapter;
        SqlConnection m_SqlConnection;
        SqlCommand m_SqlCommand;
        


        /*    SqlCommand SelectCmd;
            SqlCommand InsertCmd;
            SqlCommand DeleteCmd;*/


        public Form1()
        {
            InitializeComponent();
            /*           dAdapter = new SqlDataAdapter();
                       sqlConnection = new SqlConnection();
                       sqlConnection.ConnectionString = "Data Source=.; Initial Catalog = WindForm; Integrated Security= true";
                       Dset = new DataSet();


                       SelectCmd = new SqlCommand();
                       SelectCmd.Connection = sqlConnection;
                       SelectCmd.CommandText = "select id,name from Employee";
                       dAdapter.SelectCommand = SelectCmd;

                       InsertCmd = new SqlCommand();
                       InsertCmd.Connection = sqlConnection;
                       InsertCmd.CommandText = "insert into Employee (id,name) values (@id,@name)";
                       SqlParameter s_id = new SqlParameter("@id", SqlDbType.Int, 0, "id");
                       SqlParameter s_name = new SqlParameter("@name", SqlDbType.NVarChar, 0, "name");
                       InsertCmd.Parameters.Add(s_id);
                       InsertCmd.Parameters.Add(s_name);
                       dAdapter.InsertCommand = InsertCmd;


                       DeleteCmd = new SqlCommand();
                       DeleteCmd.Connection = sqlConnection;
                       DeleteCmd.CommandText = "delete from Employee where id= @id";
                       SqlParameter s_id_Del = new SqlParameter("@id", SqlDbType.Int, 0, "id");
                       DeleteCmd.Parameters.Add(s_id_Del);
                       dAdapter.DeleteCommand = DeleteCmd;*/

            m_SqlConnection = new SqlConnection();
            m_SqlConnection.ConnectionString = "Data Source=. ; Initial Catalog = WindForm; Integrated Security= true";

            m_SqlCommand = new SqlCommand();
            m_SqlCommand.Connection = m_SqlConnection;

            m_SqlCommand.CommandType = CommandType.Text;

            
            addbtn.Enabled = false;
            Changebtn.Enabled = false;
            delbtn.Enabled = false;
            delbtn2.Enabled = false;
            disconbtn.Enabled = false;
        }

        

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (IsIdExists(textBox1.Text))
            {
                MessageBox.Show("ID already exists. Please choose a different ID.");
                return;
            }
            string str = "insert into Employee values (" + textBox1.Text + ",'" + textBox2.Text + "');";

            executeStatment(str, "Inserted");

        }

        private bool IsIdExists(string id)
        {
            // Check if the ID already exists in the database
            string checkQuery = "SELECT COUNT(*) FROM Employee WHERE id = @id";

            using (SqlCommand checkCommand = new SqlCommand(checkQuery, m_SqlConnection))
            {
                checkCommand.Parameters.AddWithValue("@id", id);

                

                int count = (int)checkCommand.ExecuteScalar();

                

                return count > 0;
            }
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            string str = "update Employee set name = '" + textBox2.Text + "' where id =" + textBox1.Text;
            //MessageBox.Show(str);
            executeStatment(str, "Updated");

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            string str = "delete from Employee where id=" + textBox1.Text;
            executeStatment(str, "Deleted");
        }

        private void executeStatment(string str, string State)
        {
            m_SqlCommand.CommandText = str;

            int affectedRows = m_SqlCommand.ExecuteNonQuery();

            MessageBox.Show(affectedRows.ToString() + " row " + State);

            textBox1.Text = "";
            textBox2.Text = "";

            Dispaly();

        }



        private void conbtn_Click(object sender, EventArgs e)
        {
            m_SqlConnection.Open();
            MessageBox.Show("Connection is Open");
            Dispaly();
            addbtn.Enabled = true;
            Changebtn.Enabled = true;
            delbtn.Enabled = true;
            delbtn2.Enabled = true;
            disconbtn.Enabled = true;
            conbtn.Enabled = false;
        }

        private void Dispaly()
        {
            m_SqlCommand.CommandText = "select id,name from Employee";
            SqlDataReader dReader;
            if (displistbox.Items.Count > 0)
            {
                displistbox.Items.Clear();
            }

            dReader = m_SqlCommand.ExecuteReader();
            while (dReader.Read())
            {
                string str = ((int)dReader[0]).ToString() + "\t" + dReader[1].ToString();

                displistbox.Items.Add(str);
            }
            dReader.Close();
        }

        private void disconbtn_Click(object sender, EventArgs e)
        {
            m_SqlConnection.Close();
            MessageBox.Show("Connection is Close");
            
            displistbox.Items.Clear();
            addbtn.Enabled = false;
            Changebtn.Enabled = false;
            delbtn.Enabled = false;
            delbtn2.Enabled = false;
            disconbtn.Enabled = false;
            conbtn.Enabled = true;
        }

        private void delbtn2_Click(object sender, EventArgs e)
        {
            string str = "delete from Employee where name='" + textBox2.Text+"'";
            executeStatment(str, "Deleted");
        }
    }
}
