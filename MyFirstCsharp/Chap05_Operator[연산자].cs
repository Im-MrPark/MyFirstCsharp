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
    public partial class Chap05_Operator : Form
    {
        // 연산자
        // 프로그램에서 변수나 값의 연산을 위해 사용되는 부호( =, +, -, /, %, ++, += ...)
        public Chap05_Operator()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 대입 연산자 = ( = 의 오른쪽에 있는 값 (리터럴)을 왼쪽 데이터 타입 변수 등에 대입한다)

            int iValue; // 첫번째 데이터 담는 변ㅅ
            iValue = 10; // = 을 통하여 10 이라는 리터럴을 iValue 변수에 대입

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnSumEqual_Click(object sender, EventArgs e)
        {
            // += : 리터럴 왼쪽 변수에 있는 값과 합한 후 결과를 다시 왼쪽 변수에 대입한다
            
            int iValue = 10;
            // 이렇게 계속 더할 수 있다 하지만
            iValue = iValue + 10;

            // 누적증가 연산자를 사용
            iValue += 10;

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnMinEqual_Click(object sender, EventArgs e)
        {
            // 누적 감소 연산자
            // 리터럴 값을 왼쪽 변수에 차감하여 자기자신(변수)에 담는다
            
            int iValue = 10;
            iValue -= 5;

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnMulEqual_Click(object sender, EventArgs e)
        {
            // 누적 곱 연산자
            int iValue = 10;
            iValue *= 10;
            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnDivEqual_Click(object sender, EventArgs e)
        {
            // 누적 나누기 연산자 -> '/=' 결과는 자기자신의 변수에 나누기의 몫을 대입한다
            int iValue = 10;
            iValue /= 3;
            MessageBox.Show(Convert.ToString(iValue)); // 3

        }

        private void btnPerEqual_Click(object sender, EventArgs e)
        {
            // '%' 연산자의 결과는 나머지가 나온다 -> '%='은 자기자신에게 나머지 값을 대입한다
            int iValue = 10;
            iValue %= 3;
            MessageBox.Show(Convert.ToString(iValue)); // 1
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            // 전위 증가 연산자, 후위 증가 연산자
            // 왼쫀 변수에 1씩 더한다

            int iValue = 10;
            iValue++; // 후위 증가 연산
            MessageBox.Show(Convert.ToString(iValue)); // 11

            ++iValue; // 전위 증가 연산
            MessageBox.Show(Convert.ToString(iValue)); // 12

            MessageBox.Show(Convert.ToString(iValue++)); // 12
            MessageBox.Show(Convert.ToString(++iValue)); // 14

            // 후위 증가 연산 : 코드가 실행되고 난 다음에 자기자신에게 1 증가 값을 대입
            // 전위 증가 연산 : 코드가 실행될때 자기자신에게 1 증가대입
            // 전위 사용 권장

        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            // 전위 감소 연산자, 후위 감소 연산자
            int iValue = 10;
            iValue--; // 후위 증가 연산
            MessageBox.Show(Convert.ToString(iValue)); // 9

            --iValue; // 전위 증가 연산
            MessageBox.Show(Convert.ToString(iValue)); // 8

            MessageBox.Show(Convert.ToString(iValue--)); // 8
            MessageBox.Show(Convert.ToString(--iValue)); // 6
        }
    }
}
