using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Payment : Form
    {
        List<Model.Menu> firstMenu;
        int total = 0;
        private void SetMenu()
        {
            firstMenu = new List<Model.Menu>()
            {
                new Model.Menu { Id = 1, Name = "김밥", Price = 1000 },
                new Model.Menu { Id = 2, Name = "라면", Price = 3000 },
                new Model.Menu { Id = 3, Name = "떡볶이", Price = 2000 },
                new Model.Menu { Id = 4, Name = "순대", Price = 2500 },
                new Model.Menu { Id = 5, Name = "공기밥", Price = 500 }
            };
        }
        public Payment()
        {
            InitializeComponent();
            SetMenu();  // 메뉴 리스트 저장
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Menu selectedMenu = firstMenu.Find(m => m.Id == Convert.ToInt32(clickedButton.Tag));
            lBOrderStatus.Items.Add(selectedMenu.Name);
            total += selectedMenu.Price;
            CalculateTotal();
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            /*int total = 0;
            foreach(var item in listBox1.Items)
            {
                total += firstMenu.Find(m => m.Name == item.ToString()).Price;
            }
            lblPaymentInfo.Text = string.Format("총 결제 금액: {0}", total);*/
            if (total == 0) return;
            lblPaymentInfo.Text = string.Format("결제되었습니다.");

            // 초기화 제외한 버튼 막아줌
            btnPayment.Enabled = false;
            btnMenu01.Enabled = false;
            btnMenu02.Enabled = false;
            btnMenu03.Enabled = false;
            btnMenu04.Enabled = false;
            btnMenu05.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            total = 0;
            lBOrderStatus.Items.Clear();
            CalculateTotal();

            // 결제버튼 활성화
            btnPayment.Enabled = true;
            lblPaymentInfo.Text = string.Format("결제 전입니다.");

            // 메뉴버튼 활성화
            btnMenu01.Enabled = true;
            btnMenu02.Enabled = true;
            btnMenu03.Enabled = true;
            btnMenu04.Enabled = true;
            btnMenu05.Enabled = true;
        }

        private void CalculateTotal()
        {
            lblPayTotal.Text = string.Format("총 결제 금액: {0}", total);
        }

        private void BtnRemoveMenu_Click(object sender, EventArgs e)
        {
            try
            {
                int _selectedIndex = lBOrderStatus.SelectedIndex;

                // lB에 아무것도 없으면 pass
                if (lBOrderStatus.Items.Count < 1) return;

                // remove 버튼을 눌렀을 때 선택한 옵션 없으면 삭제할 메뉴를 선택해 주세요 팝업창
                if (_selectedIndex == -1)
                {
                    MessageBox.Show("삭제할 메뉴를 선택해 주세요.", "알림");
                }
                // 있으면 총 가격 - 선택한 옵션 가격 한 뒤 삭제
                else
                {
                    // 가격 빼줌
                    string selectedMenu = lBOrderStatus.SelectedItem.ToString();
                    total -= firstMenu.Find(m => m.Name == selectedMenu).Price;
                    CalculateTotal();
                    lBOrderStatus.Items.RemoveAt(_selectedIndex);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
