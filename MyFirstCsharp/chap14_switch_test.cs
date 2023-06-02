using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCsharp
{
    public partial class chap14_switch_test : Form
    {
        // 총 구매 금액관리 변수
        int iTP = 0;

        public chap14_switch_test()
        {
            InitializeComponent();
        }

        private void btnappleorder_Click(object sender, EventArgs e)
        {
            int iac = Convert.ToInt32(acount.Text);
            if(iac == 0)
            {
                MessageBox.Show("재고 소진");
                return; // 사과 주문 로직 종료
            }

            // 재고 수량 차감
            iac -= 1;
            acount.Text = iac.ToString();

            // 총 금액에 사과금액 누적
            iTP += 2000;
        }

        private void btnmelonorder_Click(object sender, EventArgs e)
        {
            int imc = Convert.ToInt32(mcount.Text);
            if(imc == 0)
            {
                MessageBox.Show("재고 소진");
                return; // 참외 주문 로직 종료
            }
            // 재고 수량 차감
            imc -= 1;
            mcount.Text = imc.ToString();

            // 총 금액에 사과금액 누적
            iTP += 2500;
        }

        private void btnwatermelonorder_Click(object sender, EventArgs e)
        {
            int iwmc = Convert.ToInt32(wmcount.Text);
            if (iwmc == 0)
            {
                MessageBox.Show("재고 소진");
                return; // 참외 주문 로직 종료
            }
            // 재고 수량 차감
            iwmc -= 1;
            wmcount.Text = iwmc.ToString();

            // 총 금액에 사과금액 누적
            iTP += 18000;
        }

        private void btntotalprice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {iTP} 입니다");
        }
    }
}
