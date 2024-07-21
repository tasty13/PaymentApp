using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBId.Text == "admin")
                {
                    if (tBPw.Text == "1234")
                    {
                        MessageBox.Show("로그인에 성공하였습니다!");
                        new FormMenu().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("아이디가 일치하지 않습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("아이디가 일치하지 않습니다.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
