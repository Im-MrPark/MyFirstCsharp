using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCsharp
{
    public partial class Chap12_IF_Test : Form
    {
        public Chap12_IF_Test()
        {
            InitializeComponent();

        }
        // 버튼 클릭 누적 횟수를 담는 변수
        int ibtnCC = 0;
        private void btn25_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭한 총 횟수
            ++ibtnCC; // 버튼을 클릭 했을때 1씩증가(전위증가 연산)
            txtCC.Text = ibtnCC.ToString();



            string sValue = txt25C.Text; //입력 받을 값
            int    iValue = 0; // 입력받은 값이 정수로 변환될 변수
            bool   bCheck = false; // 입력받은 값이 정수로 변환
            
            // 입력한 문자가 숫자로 바뀌는지 검증(밸리데이션)
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck) 
            {
                MessageBox.Show("숫자만 입력하세요");
                return; // 체크 후 종료
            }

            string sMessage = string.Empty;
            if (iValue %2 == 0 || iValue %5 == 0)
            {
                sMessage = "2와 5의 공배수";
            }
            else
            {
                sMessage = "2와 5의 공배수가 아닙니다";
            }
            MessageBox.Show(sMessage);

            // 8배수 인지 확인
            if(iValue % 8 == 0)
            {
                // 입력한 값과 8을 곱하여 8의 배수 텍스트박스에 표현
                txt8B.Text = Convert.ToString(iValue * 8);
            }
            else
            {
                txt8B.Text = "";
            }
            

        
        
        }
    }
}
