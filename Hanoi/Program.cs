using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Move(int N,int Start,int Def)
        {
            Console.WriteLine(N + "번째 원반이 " + (char)Start+ "에서" + (char)Def+ "으로 이동");
        }
        static void hanoi(int N,int Start,int Buff,int Def)
        {
            if (N == 1)
            {
                Move(N, Start, Def);
            }
            else
            {
                hanoi(N - 1, Start, Def, Buff);
                Move(N, Start, Def);
                hanoi(N - 1, Buff, Start, Def);
            }
        }
        static void Main(string[] args)
        {
            int N;  //원반
            Console.Write("원반 개수 입력 : ");
            N = int.Parse(Console.ReadLine());
            hanoi(N, (int)'A', (int)'B', (int)'C');
        }
    }
}
