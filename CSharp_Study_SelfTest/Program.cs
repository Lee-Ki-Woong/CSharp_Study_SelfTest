using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study_SelfTest
{
    internal class Program
    {
        public static void Text()
        {
            // 2) textOne 변수가 스택 메모리에 생성이 되며
            // 3) textOne이 가르키는(포인터) 문자열 데이터(인스턴스)가 힙 메모리에 할당이 된다!!
            string textOne = "문자열 데이터는 참조형! 참조형이니 생성 시 힙 메모리에 저장되며, 참조가 끊길 경우 GC에 의해 정리가 될 수 있다!!";
            Console.WriteLine(textOne);

        }


        static void Main(string[] args)
        {
            // 1) Text 메서드로 들어가면,
            Text();
            // 3) Text 메서드를 나오게 되면 textOne이 스택 메모리에서 사라져 참조가 끊겨, 힙 메모리에 할당 된 "" GC의 대상이 되어 나중에 GC가 구동되면 메모리 헤제가 된다!!

        }
    }
}
