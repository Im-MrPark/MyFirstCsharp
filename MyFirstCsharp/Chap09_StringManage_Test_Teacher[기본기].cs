using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap09_StringManage_Test_t : Form
    {
        
        // 되돌리기 위한 뭔본 문자열을 담을 변수
        // 클래스의 전역변수, 클래스의 필드멤버
        string sTitle;

        // 클래스가 객체화 될 때 실행되는 멤버(생성자 멤버)
        public Chap09_StringManage_Test_t()
        {
            // 클래스가 최초 호출 될 때 디자인을 세팅하는 함수
            InitializeComponent();
            sTitle = lblTitle.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // 000 -> 자기 이름으로 표현
            lblTitle.Text = lblTitle.Text.Replace("OOO", "박준현");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // S/W index 표시
            MessageBox.Show($" S/W 글귀의 위치는 {lblTitle.Text.IndexOf("S/W")}입니다");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // 타이틀 문자열 변수 담기
            string sTitle = lblTitle.Text;
            MessageBox.Show($"시작문자 : {sTitle[0]} , 종료문자 : {sTitle[sTitle.Length-1]}");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            // 앞 뒤에 -DT- 넣기
            lblTitle.Text = $"-DT- {lblTitle.Text} -DT-";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // 특정 문자 소문자로 변경
            string sValue = "DIGITALTRANING";
            lblTitle.Text = lblTitle.Text.Replace(sValue, sValue.ToLower());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            // 라벨 타이틀 모든 공백 없애기
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblTitle.Text = sTitle;
        }
    }
}
