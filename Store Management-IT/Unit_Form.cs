using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Store_Management_IT
{
    public partial class Unit_Form : Form
    {
        private static SqlCommand cmd;
        private static SqlDataAdapter adp;
        private static DataTable dt;

        Dbconnection _Connect = new Dbconnection();
        public Unit_Form()
        {
            InitializeComponent();
            Data_Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Insert_Unit();
        }
        public void Insert_Unit()
        {
            _Connect.GetConnection();
            try
            {
                if(_Connect.conn.State==ConnectionState.Open)
                {
                    _Connect.conn.Close();
                }
                else
                {
                    _Connect.conn.Open();
                    String sql = "Insert into Unit_Table (Unit_Id,Unit_Name)values('"+Unit_Id_Txt.Text.Trim()+"','"+Unit_Name_Txt.Text.Trim()+"')";
                    cmd = new SqlCommand(sql, _Connect.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Data_Show();
                    _Connect.conn.Close();
                }

            }
            catch(Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                _Connect.conn.Close();
            }
        }
        public void Data_Show()
        {
            _Connect.GetConnection();
            try
            {
                if (_Connect.conn.State == ConnectionState.Open)
                {
                    _Connect.conn.Close();
                }
                else
                {
                    _Connect.conn.Open();
                    String sql = "Select * from Unit_Table";
                    cmd = new SqlCommand(sql, _Connect.conn);
                    adp = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    cmd.ExecuteNonQuery();
                    adp.Fill(dt);
                    DataGridView.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                _Connect.conn.Close();
            }
        }
    }
}
