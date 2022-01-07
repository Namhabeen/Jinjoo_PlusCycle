using System;

namespace baekjoon
{
    class PlusCycle
    {
        static void Pcycle()
        {
            //값을 입력받는 부분
            Console.Write("0-99 사이의 정수를 입력하세요: ");

            //처음에 0으로 값을 줬으나 주어진 수가 10보다 작을 때 뒤에 0을 붙이기 위해 String 타입으로 받음
            String input = Console.ReadLine();

            //명시 된 "0보다 크거나 같고, 99보다 작거나 같은 수"에 해당하는지 판단하는 조건문
            if (int.Parse(input) >= 0 && int.Parse(input) <= 99)
            {
                //입력 받은 값이 10보다 작으면 뒤에 0을 붙여서 10의 자리 수로 만들기
                if (int.Parse(input) < 10)
                {
                    input = input + 0;
                }

                //while 부분의 조건에 사용되기 위한 원래 input 값
                int orinInput = int.Parse(input);

                //사이클 길이 (원래 수로 돌아오기 까지 반복 횟수) count
                int cnt = 0;

                //각 자리의 수를 더한 값
                int addNum;

                //원래 수가 될 때 까지 계속 반복되는 while문
                while(true)
                {
                    //반복된 횟수 증가 시키는 부분
                    cnt++;

                    //각 자릿수 구하는 알고리즘 사용해 1의 자리 구하기
                    int Fst = int.Parse(input) / 10;

                    //각 자릿수 구하는 알고리즘 사용해 10의 자리 구하기
                    int Sec = int.Parse(input) % 10;

                    //각 자리 값을 더하기
                    addNum = Fst + Sec;

                    //문제의 규칙을 보면 26이 입력 된 경우
                    //2+6=8 새로운 수 68
                    //6+8=14 새로운 수 84
                    //8+4=12 새로운 수 42
                    //4+6=6 새로운 수 26으로 끝이 난다.
                    //여기서 찾을 수 있는 규칙은 위 식을 a+b=x라고 가정 할 때
                    //다음에 나올 새로운 x의 각 자릿수 별 값을 구하는 법은
                    //첫번째 자릿수: Sec과 같음
                    //두번째 자릿수:이전에 더해서 나온 값값이 1의 자리 숫자인 경우 그 숫자 그대로를 첫번째 자리수로 삼음
                    //만일 10의 자리 숫자인 경우 두번째 자릿수가 첫번째 자릿수가 됨
                    //따라서 bx%10 이 새로운 수이므로 위에 0 붙일 때와 같이 String 타입이여야 하므로 형 변환 후 합치기
                    input = Sec.ToString() + (addNum % 10).ToString();

                    //위에서 합친 새로운 수가 원래 입력된 값과 같다면 while문을 빠져나가기
                    if (int.Parse(input) == orinInput) break;
                }
               
                //while문을 빠져나와 빠져나오는데까지 반복 된 횟수인 cnt값 출력
                Console.WriteLine(cnt);
            }

            else
            {
                //콘솔 창의 문구를 빨간글씨로 설정해 아래의 문구가 더 눈에 들어오도록 설정
                Console.ForegroundColor = ConsoleColor.Red;

                //조건 확인 문구 출력
                Console.WriteLine("조건을 다시 확인하세요!");

                //콘솔 창의 글자 컬러 리셋
                Console.ResetColor();

                //조건에 맞는 값이 입력될때 까지 메서드가 반복되어 실행되도록 함. 
                Pcycle();
            }
        }

        static void Main(string[] args)
        {
            //메인 메서드에서 Pcycle메서드 호출
            Pcycle();
        }
    }
}