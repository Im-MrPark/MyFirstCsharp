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
    public partial class Chap03_DataTypeConversion : Form
    {
        public Chap03_DataTypeConversion()
        {
            InitializeComponent();

            // 데이터 타입의 형 변환 (숫자 -> 문자)
            // 문자열로 데이터타입을 변경 : .Tostring();

            // 데이터 타입의 형 변환 (문자 -> 숫자)
            // 숫자형으로 데이터타입을 변경 : .Parse(), Convert.ToInt32()

            // 명시적 형변환
            // 변경할 데이터 타입을 지정 후 변환
            // .Tostring();, Convert.Tostring();, .Parse();, Convert.ToInt32();



        }

        private void btnItoS_Click(object sender, EventArgs e)
        {
            
            // 디버깅
            // 프로그램 개발 시 오류 내역을 검출 하거나. 프로그램의 로직이 실행되는 각 단위 별로 
            // 결과를 확인 할 수 있도록 하는 프로그래밍 방법
            // 브레이크 포인트 : 로직이 실행 될 때 멈춰서 디버깅이 시작 되는 시점(왼쪽 음영색 라인 클릭, F9)
             
            
            // 숫자를 문자로 변환하기 기능

            // 1. 변환될 대상 숫자를 담을 변수 생성 및 초기화
            // 초기화 할때 또는 대입 할때 대입되는 대상(리터럴)
            int iValue = 10;
            int iValue2 = 20;

            double dValue = 10.1;
            double dValue2 = 20.5;
            
            // 2. 변형된 데이터 타입이 담길 문자 변수
            string sValue1;
            string sValue2;

            // 3. iValue의 데이터 타입 int 의 기능중 Tostring()이라는 기능을 사용하여
            // 숫자를 문자로 변형 후 sValue에 대입한다
            sValue1 = iValue.ToString();


            // 4. 메세지 박스로 변형된 문자형 숫자를 표현한다
            MessageBox.Show(sValue1);


            // sValue2에 dValue2을 대입 해 보세요
            sValue2 = dValue2.ToString();

            // 문자열로 변환하는 2번째 기능
            sValue2 = Convert.ToString(dValue2);

            // Convert.Tostring()의 기능은, 결과적으로 .Tostring가 같은 결과를 생성, Null 반환 오류처리때문에 더 쓴다
            // 추천


            // 문자열의 합(문자를 이어서 표현)
            // sValue1 = 10, sValue2 = 20.5
            string sValue3 = sValue1 + sValue2;

            MessageBox.Show(sValue3); //1020.5
        }

        private void btnStoI_Click(object sender, EventArgs e)
        {
            //문자 -> 숫자로 바꾸는 버튼 클릭시 실행되는 로직
            // 1. 숫자로 바꿀 문자열 변수 생성
            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1";

            // 2. .Parse() 기능을 통한 변환
            int iResult = 0; // 변환 결과를 담을 int 변수

            //iResult = int.Parse(sValue1); // 런타임 오류 나온다

            // 숫자로 변활 할 수 있는 문자일 경우 오류 없이 변환이 된다
            iResult = int.Parse(sValue2);

            // 3. Convert.ToInt32()
            // 문자 -> 숫자
            // 숫자로 바꿀수 없는 문자일 경우 시스템 오류발생
            //iResult = Convert.ToInt32(sValue1); // 오류발생



            // 4. 숫자로 변활 할 수 있는 문자인지 검증하는 기능
            // .TryParse();

            // 숫자형 데이터 형변환 실패
            // bResult : false
            // iResult : 0
            bool bResult = int.TryParse(sValue1, out iResult);


            // 숫자형 데이터 형변환 실패(실수형 데이터를 정수로 표현)
            // bResult = fales
            // iResult = 0
            bResult = int.TryParse(sValue3, out iResult);


            // 숫자형 데이터 형변환(소수 데이터를 형변환)
            double dResult = 0; // 소수 형변환 결과를 받을 변수

            
            // 소수형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출
            // sValue3 : 10.1
            // dResult : 10.1
            // bResult : true
            bResult = double.TryParse(sValue3, out dResult);


            // 정수형 문자열을 실수 데이터 타입으로 형변환 하는 경우
            // sValue2 : "10";
            // dResult : 10
            // bResult : true
            bResult = double.TryParse(sValue2, out dResult); // 성공여부 + 값을 넣을 수 있다


           
            
            // 전체 정리
            // 문자를 숫자로 형변환 할 경우, .Parse()와 Convert.ToInt32()를 사용가능하나,
            // 변환 할 수 없는 유형의 문자인 경우 런타임 오류가 발생한다
            // 데이터타입 .TryParse() 가능을 사용하여 형변환 하는것을 추천

        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            // 다중 주석 처리문
            /*
             Null 상태의 변환처리
           - Convert.Tostring() 구문을 사용 시 Null 처리된 값이 있을 경우 빈값을 반환

           - Null?
             데이터의 용량(메모리)가 할당되지 않은 상태
             ""은 아무런 값이 없는 값이 할당된 상태

             숫자형 데이터 타입은 ? 키워드를 추가하여 null 상태로 만들 수 있다
             
            */

            string sValue = null;
            // MessageBox.Show(sValue.ToString()); // sValue가 null 처리 되었으므로 오류가 발생(런타임오류)
            MessageBox.Show(Convert.ToString(sValue)); // sValue가 null 처리 되었어도 아무것도 없는 값으로 치환하여 반환

            string sValue2 = "";

            // 숫자 데이터를 null 처리하는 방법
            // Convert.ToString 과 .ToString() 형식으로 Null을 변환 할수있다
            int? iValue = null; // ?로 인해 한시적으로 처리가능
            MessageBox.Show(iValue.ToString());

            
        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            // 문자열의 합과 숫자의 합
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sValue3 = sValue1 + sValue2;
            MessageBox.Show(sValue3); // ABCDEF
            

            int iValue1 = 50;
            int iValue2 = 30;

            int iValue3 = iValue1 + iValue2;
            MessageBox.Show(Convert.ToString(iValue3)); // 80


        }
    }
}
