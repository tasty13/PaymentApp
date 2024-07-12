using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        delegate void DelCalculate(string picked);

        List<Model.Menu> menus;
        int total = 0;
        List<Menu> pickedMenu = new List<Menu>();

        public FormMenu()
        {
            InitializeComponent();
            setMenuList();
        }

        private void setMenuList()
        {
            menus = new List<Model.Menu>()
            {
                new Model.Menu { Id = 1, Name = "김밥", Price = 1000 },
                new Model.Menu { Id = 2, Name = "라면", Price = 3000 },
                new Model.Menu { Id = 3, Name = "떡볶이", Price = 2000 },
                new Model.Menu { Id = 4, Name = "순대", Price = 2500 },
                new Model.Menu { Id = 5, Name = "공기밥", Price = 500 }
            };
            foreach(var menu in menus)
            {
                lBMenuList.Items.Add(menu.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int indexMenu = lBMenuList.SelectedIndex;
            try 
            {
                if (indexMenu != -1)
                {
                    // lBMenuPicked에 추가, total에 가격 add
                    string menuName = lBMenuList.SelectedItem.ToString();
                    lBPickedMenu.Items.Add(menuName);
                    CalculateTotal(menuName, AddTotal);
                }
                else
                {
                    MessageBox.Show("추가할 상품을 선택해 주세요.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int pickedIndex = lBPickedMenu.SelectedIndex;
            try
            {
                // 선택된거 없으면 아무일X
                if (lBPickedMenu.Items.Count < 1) return;

                // 선택되었으면 삭제
                if (pickedIndex != -1)
                {
                    string picked = lBPickedMenu.SelectedItem.ToString();
                    CalculateTotal(picked, SubTotal);
                    lBPickedMenu.Items.Remove(picked);
                }
                else
                {
                    MessageBox.Show("제거할 상품을 선택해 주세요.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (total == 0) return;
            btnPayInfo.Text = "결제되었습니다.";
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnPay.Enabled = false;
        }

        private void CalculateTotal(string picked = null, DelCalculate Calculate = null)
        {
            if (string.IsNullOrEmpty(picked) && Calculate == null)
            {
                total = 0;
            }
            else
            {
                Calculate(picked);
            }
            lblTotalPrice.Text = string.Format("총 결제 금액: {0}", total);
        }

        private void AddTotal(string picked)
        {
            total += menus.Find(m => m.Name == picked).Price;
        }

        private void SubTotal(string picked)
        {
            total -= menus.Find(m => m.Name == picked).Price;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            CalculateTotal();
            lBPickedMenu.Items.Clear();

            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
            btnPay.Enabled = true;
        }
    }
}
