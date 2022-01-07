using System;

namespace baekjoon
{
    class PlusCycle
    {
        static void Pcycle()
        {
            //값을 입력받는 부분
            Console.Write("0-99 사이의 정수를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());

            //처음 명시 된 "0보다 크거나 같고, 99보다 작거나 같은 수"에 해당하는지 판단하는 조건문
            if (input >= 0 && input <= 99)
            {
                Console.WriteLine("조건에 헤딩!");
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