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
    public partial class Chap13_Switch : Form
    {

        // Switch, case, break, default (switch의 포멧)
        // IF 문과 함께 자주 사용되는 분기문
        // 많은 분기를 제어할 경우 IF문 보다 깔끔하게 로직을 표현가능
        public Chap13_Switch()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // IF 문으로 과일 이름, 가격 나타내기

            // 1. 변수 설정
            string sFruitName = txtFruit.Text; // 과일 이름
            int iFPrice       = 0; // 과일 가격

            if (sFruitName == "사과")
            {
                iFPrice = 2000;
            }
            else if (sFruitName == "복숭아")
            {
                iFPrice = 2000;
            }
            else if (sFruitName == "참외")
            {
                iFPrice = 2500;
            }
            else if (sFruitName == "딸기")
            {
                iFPrice = 18000;
            }
            else if (sFruitName == "수박")
            {
                iFPrice = 18000;
            }
            
            // 위 에서 0으로 지정했기에 위에서 끝나면 밑으로 내려올 때 자동적으로 0의 값을 가지므로 밑의 로직은 필요x
            //else
            //{
            //    // 취급하는 과일을 입력하지 않은 경우
            //    iFPrice = 0;
            //}

            if (iFPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다");
            }
            else 
            {
            MessageBox.Show($"{sFruitName}의 가격은 {iFPrice}입니다");    
            }
            
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // switch를 통한 과일 이름과 가격 찾기

            // 입력한 과일 이름 변수 등록
            string sFN = txtFruit.Text;
            int iFP = 0;

            switch (sFN) // 비교할 대상
            {
                case "사과":
                    iFP = 2000;
                break;
                case "복숭아":
                    iFP = 2000;
                break;
                case "참외":
                    iFP = 2500;
                break;
                case "딸기":
                    iFP = 18000;
                break;
                case "수박":
                    iFP = 18000;
                break;
            }
            if (iFP == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다");
            }
            else
            {
                MessageBox.Show($"{sFN}의 가격은 {iFP}입니다");
            }
        }
    }
}
