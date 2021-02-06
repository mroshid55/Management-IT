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
        //private static SqlConnection conn;
        //private static SqlCommand cmd;
        //private static SqlDataAdapter adp;
        //private static DataTable dt;
        public Product_Info_Form()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            //insert();
        }
        //public void insert()
        //{
        //    try
        //    {
        //        conn = db_connection.Connection;
        //        String sql = "";
        //        cmd = new SqlCommand(sql, conn);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        db_connection.Connection = conn;
        //    }
        }
    }
