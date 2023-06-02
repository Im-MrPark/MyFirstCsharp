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

namespace MyFirstCsharp
{
    public partial class Chap07_StringFind : Form
    {
        public Chap07_StringFind()
        {
            InitializeComponent();
        }

        private void Chap07_StringFind_Load(object sender, EventArgs e)
        {

        }

        private void btnIndexof_Click(object sender, EventArgs e)
        {
            // Index of : 문자열 내에서 찾고자 하는 지정 된 문자 또는 문자열의 위치 정보 찾기
            //            문자열의 위치 정보 찾기(index)

            // 타이틀 변수에 담기
            string sTitle = lblTite.Text;

            // 사용자가 입력한 문자열을 변수에 담는다
            string sValue = txtIndexof.Text;

            // 사용자가 지정한 문자 열의 위치를 찾아 담을 변수
            int iIndex = 0;
            iIndex = sTitle.IndexOf(sValue);

            MessageBox.Show(sValue + "가(이) 있는 위치는" + iIndex + "입니다");

            // 암시적 형변환
            // 데이터 타입을 명시하지 않아도 데이터 타입이 큰 유형을 자동변환
            // 컴파일러가 컴파일 시 자동을 변현 해주는 타입
        }

        private void btnLastIndex_Click(object sender, EventArgs e)
        {
            // Last Index of : 문자열의 뒤에서 찾아 몇번째 인덱스에 있는지 리턴
            string sTitle = lblTite.Text;
            string sValue = txtLastIndex.Text;  
            int iLastIndex = 0;

            //문자열 뒤에서 몇번째 Index에 있는지 확인
            iLastIndex = sTitle.LastIndexOf(sValue);
            
            MessageBox.Show(sValue + "가(이) 있는 위치는" + iLastIndex + "입니다");

            // LastIndexof 는 뒤쪽에서 가장 처음 찾은 문자의 위치 정보를 반환
        }

        private void btnSW_Click(object sender, EventArgs e)
        {
            // StartWith : 해당 문자열로 시작 하는지 판단

            string sTitle = lblTite.Text;
            string sValue = txtSW.Text;

            // 판단 결과 반환하기
            bool bFlag = sTitle.StartsWith(sValue);

            MessageBox.Show("판단결과" + bFlag + "입니다.");

        }

        private void btnEW_Click(object sender, EventArgs e)
        {
            //string sTitle = lblTite.Text;
            //string sValue = txtEW.Text;

            //// 판단 결과 반환하기
            //bool bFlag = sTitle.EndsWith(sValue);

            //MessageBox.Show("판단결과" + bFlag + "입니다.");
            //// 마지막 끝자리를 찾는다

            // 위 문장 줄이기
            bool bFlag = lblTite.Text.EndsWith(txtEW.Text);
            MessageBox.Show("판단결과" + lblTite.Text.EndsWith(txtEW.Text) + "입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Contains() : 지정한 문자열을 포함하고 있는지 결과를 반환

            //string sTitle = lblTite.Text;
            //string sValue = txtCt.Text;

            //// 문자열을 포함하는지 판단
            //bool bFlag = sTitle.Contains(sValue);
            //MessageBox.Show("판단결과" + bFlag + "입니다.");

            bool bFlag = lblTite.Text.Contains(txtCt.Text);
            MessageBox.Show("판단결과" + lblTite.Text.Contains(txtCt.Text) + "입니다.");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            // 문자열을 원하는 문자열로 치환
            string sTitle = lblTite.Text;

            // 변경 전 사용자가 입력한 문자열 가져오기
            string sBeforWord = txtBR.Text;

            // 변경 후 문자열 받아오기
            string sAfterWord = txtAR.Text;

            // 변경을 완료 후 문자열이 담길 변수
            string sResult = sTitle.Replace(sBeforWord, sAfterWord);
            MessageBox.Show(sResult);

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
