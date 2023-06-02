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
    public partial class Chap04_DataType_ConTest : Form
    {
        public Chap04_DataType_ConTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 덱스트 박스 두 수의 합을 구해서 메세지로 표현하기
            // 1.  텍스트 박스에 입력 된 값 들고오기

            // 왼쪽 테스트박스에 입력 한 값을 변수에 담기
            string sFirstValue;
            sFirstValue = txtFirstValue.Text;

            // 오른쪽~
            string sSecondValue;
            sSecondValue = txtSecondValue.Text;


            // 2. 입력 받은 값을 정수로 변환

            // 왼쪽 텍스트 박스의 값을 정수로 담은 int 변수 만들기
            int iFirstValue = 0;
            int.TryParse(sFirstValue, out iFirstValue);

            // 오른쪽~
            int iSecondValue = 0;
            int. TryParse(sSecondValue, out iSecondValue);


            // 3. 합치기
            int iResult = 0; // 합친 결과를 받아올 변수
            iResult = iFirstValue + iSecondValue;

            // 4. 결과 표현
            string sResult; // 합친 결과를 문자로 담을 변수
            sResult = Convert.ToString(iResult);
            MessageBox.Show(sResult);

            // 4-1. 한번에 표현
            // MessageBox.Show(Convert.ToString(iResult));


        }
    }
}
