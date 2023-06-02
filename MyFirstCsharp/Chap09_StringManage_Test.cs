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
    public partial class Chap09_StringManage_Test : Form
    {
        public Chap09_StringManage_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sValue = lblTitle.Text;
            string sResult = sValue.Replace("OOO", "박준현");
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            // 사용자가 지정한 문자 열의 위치를 찾아 담을 변수
            int iIndex = 0;
            iIndex = sTitle.IndexOf("S/W");

            MessageBox.Show("S/W" + "가(이) 있는 위치는" + iIndex + "입니다");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string[] sValues = lblTitle.Text.Split(' ');
            MessageBox.Show($" 타이틀 첫 문단 은 {sValues[0]}입니다");
            MessageBox.Show($" 타이틀 마지막 문단 은 {sValues[sValues.Length - 1]}입니다");

        }
    }
}

