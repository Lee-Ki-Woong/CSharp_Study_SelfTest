using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study_SelfTest
{

    internal class Program
    {
        static void VoidMethod()
        {
            Console.WriteLine("이 친구는 출력값이 없다!! ㅠㅠ");
        }

        static int IntMethod(int i)
        {
            Console.WriteLine($"이 친구는 {i}값을 리턴한다! int의 무게는 4bytes");

            return i;
        }

        static string StringMethod(string s)
        {
            Console.WriteLine($"이 친구는 {s}값을 리턴한다! string의 무게는 무한으로 늘어날 수도 있는 'N'bytes 참고로 일반 자료형인데 참조형이다!! 허거걱");

            return s;
        }

        static bool BoolMethod(bool b)
        {
            Console.WriteLine($"이 친구는 {b}값을 리턴한다!! bool의 무게는 1bytes");
            return b;
        }

        static float FloatMethod(float f)
        {
            Console.WriteLine($"이 친구는 {f}값을 리턴한다!! 참고로 소숫점을 아무리 많이 찍어도 소숫점 7자리까지만 저장할 수 있다!! float의 무게는 4bytes");
            return f;
        }

        static char CharMethod(char c)
        {
            Console.WriteLine($"이 친구는 {c}값을 리턴한다!! 참고로 C#은 UTF-16이기 때문에 한글이든 영어든 전부다 2bytes ( 한글은 가끔 3bytes도 가능 ) 로 적용이 된다!!");
            return c;
        }

        static double DoubleMethod(double d)
        {
            Console.WriteLine($"이 친구는 {d}값을 리턴한다!! 참고로 소숫점을 아무리 많이 찍어도 소숫점 15자리까지만 저장할 수 있다!! double의 무게는 8bytes");
            return d;
        }

        static void Main(string[] args)
        {
            VoidMethod();
            var varTypeOne = IntMethod(1);
            var varTypeTwo = StringMethod("야호~");
            var varTypeThree = BoolMethod(true);
            var varTypeFour = FloatMethod(0.4350343f);
            var varTypeFive = CharMethod('갹');
            var varTypeSix = DoubleMethod(0.123456789101112);
        }
    }
}
