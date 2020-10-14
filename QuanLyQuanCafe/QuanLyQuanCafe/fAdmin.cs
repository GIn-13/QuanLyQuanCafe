using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

           
        }

        //void LoadFoodList()
        //{
        //    //cau lenh truy van
        //    string query = "select * from food";

        //    dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);

            
        //}
        ////void LoadAccountList()
        //{
        //    //cau lenh truy van
        //    string query = "EXECUTE dbo.USP_GetAccountByUserName @userName";

            

        //    dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "K9" });
        //}
    }

}
