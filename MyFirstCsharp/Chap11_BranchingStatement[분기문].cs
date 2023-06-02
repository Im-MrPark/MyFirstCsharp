using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCsharp
{
    public partial class Chap11_BranchingStatement : Form
    {

        // 분기문
        // 프로그램 흐름의 조건에 따라 여러 갈래로 나누는 흐름제어 구문
        // 비교연산자로 ==, !=, <=, >=, &&, ||을 사용한다

        public Chap11_BranchingStatement()
        {
            InitializeComponent();
        }

        private void Chap11_BranchingStatement_Load(object sender, EventArgs e)
        {

        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에 입력한 값이 없을 경우
            // " 아무 값도 없습니다'"
            // 아닐경우)(값이 있을경우) 해당 값을 메세제로 표현

            // 텍스트 박스에 입력한 값을 변수에 담기
            string sValue = txtIF.Text;

            if (sValue == "")
            {
                //true
                MessageBox.Show("아무 값도 없습니다");
            }
            else
            {
                // false
                MessageBox.Show(sValue);
            }
            //if(sValue !="")
            //{
            //    MessageBox.Show(sValue);
            //}
        }

        private void btnInIF_Click(object sender, EventArgs e)
        {
            /*
            만약에 덱스트 박스에 입력한 값이 
            1 일때는 "분기문 1 실행" 메세지
            2 일때는 "분기문 2 실행" 메세지
            3 일때는 "분기문 3 실행" 메세지

            아무 값도 입력하지 않은 경우 " 값을 입력 하세요" 메시지
            그리고 값은 있는데 1, 2, 3이 아닐 경우 " 적절한 분기문이 없습니다" 메세지
            */


            // 1. 텍스트 박스에 입력한 값을 받아오기
            string sTextValue = txtIF.Text;

            // 먼저 입력한 값이 없을 경우 걸러내는 분기문 바깥쪽에 작성
            if (sTextValue == "")
            {
                MessageBox.Show("값을 입력하세요");
            }
            else
            {
                if (sTextValue == "1")
                {
                    MessageBox.Show("분기문 1 실행");
                }
                if (sTextValue == "2")
                {
                    MessageBox.Show("분기문 2 실행");
                }
                if (sTextValue == "3")
                {
                    MessageBox.Show("분기문 3 실행");
                }

                else
                {
                    MessageBox.Show("적절한 분기문이 없습니다");
                }
            }

            // 마지막의 else는 3번 분기문의 예외 일 경우 결과 로직이다
            // 1, 2를 입력 하였을 경우
            // "1번, 2번 분기물 실행" 이라는 메세지를 표현하고
            // 3이 아니기 때문에 적절한 분기문이 없습니다. 표현.
            // 예상한 시나리오 대로 동작하지 않는 로직

            //1,2,3,else의 흐름을 하나로 만들어주는 if문의 흐름이 필요
        }

        private void btnelseIF_Click(object sender, EventArgs e)
        {
            // else if
            // if 문과 다음 if문을 하나의 흐름으로 만들어 준다
            // if, else if를 만족시키는 조건을 하나라도 수행하면 흐름을 종료
            // 모두 거짓 상태일 경우 else 로직을 수행한다

           /*
           만약에 덱스트 박스에 입력한 값이 
           1 일때는 "분기문 1 실행" 메세지
           2 일때는 "분기문 2 실행" 메세지
           3 일때는 "분기문 3 실행" 메세지

           아무 값도 입력하지 않은 경우 " 값을 입력 하세요" 메시지
           그리고 값은 있는데 1, 2, 3이 아닐 경우 " 적절한 분기문이 없습니다" 메세지
           */



           // 입력한 값
            string sValue = txtIF.Text;

            // 1. 값을 입력 하지 않았을 경우
            if(sValue =="")
            {
                MessageBox.Show("값을 입력 하세요");
            }
            else if(sValue == "1")
            {
                MessageBox.Show("1 분기문 실행");
            }
            else if(sValue == "2")
            {
                MessageBox.Show("2 분기문 실행");
            }
            else if(sValue == "3")
            {
                MessageBox.Show("3 분기물 실행");
            }
            else
            {
                MessageBox.Show("적절한 분기물이 없습니다");
            }
        }

        private void btnAndIF_Click(object sender, EventArgs e)
        {
            // && :  모든 조건을 만족 시킬 경우에만 참  '그리고'

            string sValue = txtIF.Text;
            
            if(sValue == "1" && sValue == "2" && sValue == "3")
            {
                // true
                MessageBox.Show($"{sValue}번 분기문 실행");
            }
            else if(sValue == "")
            {
                MessageBox.Show("값을 입력 하세요");
            }

            else
            {
                MessageBox.Show("적절한 분기물이 없습니다");
            }
        }

        private void btnOrIF_Click(object sender, EventArgs e)
        {
            // or if문 : 조건 중 하나라도 참일 경우 true로 간주.
            // || 버티컬 바 (쉬프트 + w)
            
            string sValue = txtIF.Text;

            // 1이거나 2이거나 3이거나 하나만 맞아도 true
            if (sValue == "1" || sValue == "2" || sValue == "3")
            {
                // true
                MessageBox.Show($"{sValue}번 분기문 실행");
            }
            else if (sValue == "")
            {
                MessageBox.Show("값을 입력 하세요");
            }

            else
            {
                MessageBox.Show("적절한 분기물이 없습니다");
            }
        }

        private void btnBoolIF_Click(object sender, EventArgs e)
        {
            // 분기문의 외부 변수를 이용하여 분기 흐름 제어하기
            // bool 데이터변수에 데이터가 담긴 결과로 흐름을 판단하는 로직

            // 1. 입력 한 값 받아오기
            string sValue = txtIF.Text;

            // 2. 분기 흐름 제어를 위한 외부 bool 변수 생성
            bool bFlag = false; // 기본값 : false

            // 3. 첫번째 분기 흐름 생성.
            if(sValue == "1" || sValue=="2" || sValue == "3")
            {
                bFlag = true;
            }
            else if(sValue == "")
            {
                MessageBox.Show("값을 입력하세요");
                return; // 로직 종료
                // bFlag = true; 한계가 있다
            }

            // 4. 두번째 분기 흐름 생성.
            // bFlag의 참/ 거짓에 따른 분기 흐름.


            // 아래의 두 경우는 같은 케이스이다
            // bFlag에 false 값이 있다면 if문 실행
            //if(!bFlag)
            //{
            //    // true
            //}
            if(bFlag == true)
            {
                // true
                // 1, 2, 3을 입력하지 않은 경우
                MessageBox.Show("값을 입력 하세요");
            }
            else
            {
                MessageBox.Show($"{sValue}번 분기문 실행");
            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            // 입력한 값이 음수인지 양수인지 판단

            // 입력한 값 받아오기
            string sValue = txtIF.Text;

            // 정수 데이터 변수 생성
            int iResult = 0;

            // 입력받은 값을 숫자로 변환 할 수 있는지 체크 bool 변수.
            bool bFlag = false;

            // 입력문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(sValue, out iResult);

            // 벨리데이션 체크
            // 개발자가 프로그램 개발 시 오류 사항이 발생할 수 있는 로직을
            // 예상하고 오류상황이 발생할 수 있는 로직을 처리하기 전에
            // 에러 메세지를 사용자에게 전달 해 줌으로서
            // 시스템 오류를 발생 시키지 않으면서 프로그램에 대한 신뢰도를
            // 높이는 개발 방법
            // 사용자에게 정확한 사용 방법을 알리면서 올바르게 프로그램을 사용
            // 할수 있도록 유도

            if(!bFlag)
            {
                MessageBox.Show("음수 양수 판단을 할 수 없습니다");
                return;
            }

            // 음수/양수 판단하는 로직 커몬~
            if(iResult > 0)
            {
                MessageBox.Show("양수입니다");
            }
            else if(iResult < 0)
            {
                MessageBox.Show("음수입니다");
            }
            else
            {
                MessageBox.Show("0입니다");
            }


        }

        private void btnhj_Click(object sender, EventArgs e)
        {
            string sValue = txtIF.Text;

            // 정수 데이터 변수 생성
            int iResult = 0;

            // 입력받은 값을 숫자로 변환 할 수 있는지 체크 bool 변수.
            bool bFlag = false;

            // 입력문자를 숫자로 변환 후 iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(sValue, out iResult);

            if (!bFlag)
            {
                MessageBox.Show("홀/짝 판단을 할 수 없습니다");
                return;

                
            }
            string sResult = string.Empty;
            sResult = (iResult % 2 == 0) ? "짝수입니다." : "홀수입니다.";
            MessageBox.Show(sResult);

            MessageBox.Show((iResult % 2 == 0) ? "짝수입니다." : "홀수입니다.");

            // 홀짝 판단하는 로직 커몬~
            if (iResult %2 == 0 && iResult != 0)
            {
                MessageBox.Show("짝수입니다");
            }
            else
            {
                if (iResult == 0)
                {
                    MessageBox.Show("0이여~");
                }
                else
                {
                    MessageBox.Show("홀수입니다");
                }
                
            }
        }

        private void btnTO_Click(object sender, EventArgs e)
        {
            // 상황연산자
            // 피 연산자의 개수가 3개인 조건부 연산자
            // if - else 구문을 한줄로 간단하게 표현 할 수 있기 때문에
            // IN - LINE IF 문이라고도 한다


            //홀 짝 상황연산자
         
        }
    }
}
