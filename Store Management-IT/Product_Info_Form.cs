using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Store_Management_IT
{
    public partial class Product_Info_Form : Form
    {
        private static SqlCommand cmd;
        private static SqlDataAdapter adp;
        private static DataTable dt;
        Dbconnection _Connect = new Dbconnection();
                
        public Product_Info_Form()
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
            insert_Product();
        }
        public void insert_Product()
        {
            _Connect.GetConnection();
            try
            {
                if (_Connect.conn.State==ConnectionState.Open)
                {
                    _Connect.conn.Close();
                }
                else
                {
                    _Connect.conn.Open();
                    String sql = "insert into Product_Info_Table (Project_Id,Product_Name,Product_Specification,Product_Quantity,Unit,Sources,Location,Purchased_Date) values('" + Product_Id_Txt.Text.Trim() + "','"
                        + Product_Name_Txt.Text.Trim() + "','"
                        + Product_Speci_Txt.Text.Trim() + "','"
                        + Product_Quantity_Txt.Text.Trim() + "','"
                        + Unit_ComboBox.Text.Trim() + "','"
                        + Sourecs_ComboBox.Text.Trim() + "','"
                        + Location_ComboBox.Text.Trim() + "','"
                        + Purchased_DateTimePicker.Text.Trim() + "')";
                    cmd = new SqlCommand(sql, _Connect.conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Data_Show();
                    _Connect.conn.Close();
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
                    String sql = "Select * from Product_Info_Table";
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