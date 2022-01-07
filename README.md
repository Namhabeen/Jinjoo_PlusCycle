# Jinjoo_Ascii

🙂더하기 사이클 문제 <br>
🙂https://www.acmicpc.net/problem/1110 <br>
<pre><code>using System;

namespace baekjoon
{
    class PlusCycle
    {
        static void Pcycle()
        {
            String input = Console.ReadLine();
           
                if (int.Parse(input) < 10)
                {
                    input = input + 0;
                }
            
                int orinInput = int.Parse(input);
                int cnt = 0;
                int addNum;

                while(true)
                {
                    cnt++;
                    int Fst = int.Parse(input) / 10;
                    int Sec = int.Parse(input) % 10;
                    addNum = Fst + Sec;
                    input = Sec.ToString() + (addNum % 10).ToString();
                    if (int.Parse(input) == orinInput) break;
                }
                Console.WriteLine(cnt);
        }

        static void Main(string[] args)
        {
            Pcycle();
        }
    }
}</code></pre>
🙂오늘 코딩하며 아쉬웠던 부분은 if문의 중괄호 위치를 제대로 확인하지 못해 20분 즈음의 시간을 삽질했다는 점 입니다...😂 다음에는 같은 실수 꼭 안하기!!!로 다짐했습니다...!!!!<br>
