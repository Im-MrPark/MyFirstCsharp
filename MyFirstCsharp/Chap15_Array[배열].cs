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
    public partial class Chap15_Array : Form
    {
        // 배열(참조형식, 배열의 이름은 stack에 해당되고 값은 heap 저장)
        // - 같은 데이터 타입의 다중 데이터가 하나의 배열 변수 이름으로 나열된 데이터 형식
        // - C#에서 배열은 반드시 방의 개수를 지정 하여 생성하거나, 배열에 나열 될 값들의 개수가 명시 되어야 한다


        public Chap15_Array()
        {
            InitializeComponent();
        }

        private void btnAF_Click(object sender, EventArgs e)
        {
            // 1. 여러가지 배열의 초기화(배열을 생성하고 값을 대입

            // 배열의 방의 개수를 지정하여 생성
            int[] iValues = new int[6]; // 방이름은 복수가 좋다~


            // 배열의 방의 개수와 값을 바로 등록
            int[] iValues2 = new int[3] {0,1,2};

            // 배열의 개수 지정 없이 값을 바로 등록
            int[] iValue3 = new int[] {10,20,30};

            // new int[]키워드 없이 값을 바로 등록
            int[] iValue4 = { 1, 2, 3, 4 };

            // 반환 형태가 배열인 기능(메서드)를 이용하여 배열을 등록
            string[] sValues = "abcde-fgdg".Split('-');

            // 기존에 생성되어 있는 배열의 방 갯수 만큼 빈 새로운 배열 만들기
            int[] iValue5 = new int[sValues.Length];


            // C#에서 배열을 관리할 때 사용되는 주요 기능

            int[] iExamArray = { 10,24,25,26,7 };
            // 배열의 정렬(오름차순)
            Array.Sort(iExamArray); // 배열을 오름차순으로 정리해준다

            // 내림차순
            Array.Reverse(iExamArray); // 배열을 내림차순으로 정리해준다

            // 배열의 값을 하나의 문자열로 표현
            string sExamValue = string.Empty; // 배열의 값을 하나로 담을 변수
            sExamValue = string.Join(" / ", iExamArray);
            MessageBox.Show(sExamValue);

            // 배열의 데이터를 모두 삭제
            Array.Clear(iExamArray,0,iExamArray.Length); // 배열의 모든 데이터 삭제

            
            
            //배열 복사
            // () : 캐스팅 - 강제로 형변환을 하는 기능 변환되어야 되는 대상이 명확할 경우에 사용
            // 깊은 복사 방법
            // - 참조 형식의 데이터를 복사 할 때 주소와 값의 정보를 그대로 복사하여 서로 다른 데이터 형식으로 복사하는 방법을 말한다

            object oValue = iExamArray.Clone(); // 오브젝트로 받아와야하고 밑 로직처럼 써야한다
            int[] iBackUps = (int[]) oValue; // 오브젝트 형식 -> 특정 데이터 형식 형변환 unBoxing
            
           
            //int[] iBackUps = (int[])iExamArray.Clone() ;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // 값 형식과 참조 형식의 복사


            #region < 값 형식의 복사 방법 >
            int iValue  = 10;
            int iValue2 = iValue; // iValue를 대입

            MessageBox.Show(iValue.ToString());
            iValue2 = 20;
            MessageBox.Show(iValue.ToString());

            // int 데이터타입은 값 형식으로 복사를 할 경우 해당 값으로 직접 전달하여 복사된다
            #endregion

            #region < 배열복사 > 
            int[] iValues1 = {1,2,3,4,5};
            int[] iValues2 = iValues1;

            MessageBox.Show(iValues1[0].ToString()); // "10"
            iValues2[0] = 333;
            MessageBox.Show(iValues1[0].ToString()); // "333"

            // 얕은복사
            // - 참조형식의 데이터를 복사할 때 값의 저장된 위치 정보만 전달해 주는 복사 방법
            #endregion


        }
    }
}
