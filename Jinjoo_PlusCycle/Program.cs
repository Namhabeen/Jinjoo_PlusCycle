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

            //처음 명시 된 "0보다 크거나 같고, 99보다 작거나 같은 수"에 해당하는지 판단하는 조건문
            if (int.Parse(input) >= 0 && int.Parse(input) <= 99)
            {
                
                //입력 받은 값이 10보다 작으면 뒤에 0을 붙여서 10의 자리 수로 만들기
                if (int.Parse(input) < 10)
                {
                    input = input + 0;
                    Console.WriteLine(input);
                }
            }

            else
            {
                //콘솔 창의 문구를 빨간글씨로 설정해 아래의 문구가 더 눈에 들어오도록 설정
                Console.ForegroundColor = ConsoleColor.Red;

                //조건 확인 문구 출력
                Console.WriteLine("조건을 다시 확인하세요!");

                //콘솔 창의 글자 컬러 리셋
                Console.ResetColor();

                //조건에 맞는 값이 입력될 때 까지 메서드가 반복되어 실행되도록 함. 
                Pcycle();
            }
        }
        static void Main(string[] args)
        {
            Pcycle();
        }
    }
}