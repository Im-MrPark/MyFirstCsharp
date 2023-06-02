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
    public partial class Chap16_Loop_For : Form
    {
        public Chap16_Loop_For()
        {
            InitializeComponent();
        }

        private void btnForsum_Click(object sender, EventArgs e)
        {
            // 반복문
            // 특정한 조건을 만족할 때 까지 반복하여 동일한 로직을 실행하는 문법

            // 1부터 100까지 합하는 로직

            // 1. 누접 값이 저장되는 변수
            int iSumValue = 0;

            // 1부터 100까지 반복
            // int i -> 반복하면서 조건을 만족 시킬 변수
            // 반복문을 종료할 수 있는 변수
            // int i = 0 : int 형 변수 i 가 0 이라는 값을 가지고 시작
            // ; i <= 100 : 참인 조건 인지 판단하는 구문
            // ; i++ : 후위 증가 연산자
            for (int i = 0; i <= 100; i++)
            {
                iSumValue += i;
            }
            MessageBox.Show(iSumValue.ToString());
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            // 배열의 데이터 수만큼 for 문으로 배열 값 더하기

            // 1. 임의의 배열의 값 등록(배열에 포함된 데이터의 갯수 및 값을 모른다고 가정)
            int[] iValues = {10,20,30,40,50,60,70,80,90,100};

            // 2. For 문을 통하여 iValues 배열에 있는 모든 값을 더하기
            int iSumValue = 0; // 배열의 모든 값을 더해서 누적시킬 변수

            // int i 배열의 주소 값으로 사용될 i
            for (int i = 0; i < iValues.Length; i++)
            {
                if (iValues[i] >= 40)
                {
                    continue;
                }
                iSumValue += iValues[i];
            }
            MessageBox.Show(iSumValue.ToString());
        }

        private void btn99D_Click(object sender, EventArgs e)
        {
            // 구구단 만들기
            string sResult = string.Empty;

            for (int i = 2; i < 10; i++)
              {
                for (int j = 1; j < 10; j++)
                {
                    sResult += $"{i}*{j} = {i * j}\r\n";
                }
              }
            txt99D.Text = sResult;
        }

        private void btnImut_Click(object sender, EventArgs e)
        {
            // 갑형식의 타입
            // lmmuatable type(string) 과 mutable type(int)
            // Immutable 타입은 지정되는 번지수만 늘어서 데이터가 증가하는방(누적되서 사라지지 않는다)
            //2 * 1 = 2   //2 * 1 = 2  //2 * 1 = 2
            //2 * 2 = 4  //2 * 2 = 4
            //2 * 3 = 6 

            // 불필요한 메모리 공간이 많이 소모 되므로 비효율적인 코딩이 된다
            // StringBuilder를 사용 권장(강추)
            StringBuilder sBuilder = new StringBuilder();
            // 123456789...100
            for(int i = 1; i <= 100; i++)
            {
                sBuilder.Append(i.ToString());
            }
            MessageBox.Show(sBuilder.ToString());
            sBuilder.Clear(); // 내용삭제

        }
    }
}
