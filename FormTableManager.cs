using CoffeeShopManagement.DAO;
using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class formTableManager : Form
    {
        public formTableManager()
        {
            InitializeComponent();
            LoadTable();
        }

        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btt = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btt.Text = item.Name + Environment.NewLine + item.Status;
                btt.Click += btt_Click;
                btt.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btt.BackColor = Color.Wheat;
                        break;
                    default:
                        btt.BackColor = Color.SaddleBrown;
                        break;
                }

                flpViewtableTablemanager.Controls.Add(btt);
            }
        }
        void ShowBill(int id)
        {
            lvwdgvInfortableTablemanager.Items.Clear();
            List<CoffeeShopManagement.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            foreach (CoffeeShopManagement.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                lvwdgvInfortableTablemanager.Items.Add(lsvItem);
            }
        }
        #endregion

        #region Events
        //
        //    buttons
        //
        void btt_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            ShowBill(tableID);
        }

        private void bttAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void bttSwitchTable_Click(object sender, EventArgs e)
        {

        }

        private void bttDiscount_Click(object sender, EventArgs e)
        {

        }

        private void bttPay_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAdmin f = new formAdmin();
            f.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAccountProfile f = new formAccountProfile();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
