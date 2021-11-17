using CoffeeShopManagement.DAO;
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

namespace CoffeeShopManagement
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }
        
        void LoadFoodList()
        {
            string query = "select * from food";
            dgvFoodAdmin.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            //string query = "SELECT DisplayName as [Tên hiển thị] FROM dbo.Account";
            //DataProvider provider = new DataProvider(); 
            dgvAccountAdmin.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });

        }
    }
}
//#longcoffee
