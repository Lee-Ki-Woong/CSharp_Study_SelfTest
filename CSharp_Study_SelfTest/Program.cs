using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study_SelfTest
{
    internal class Entity
    {
        private string m_id;
        protected string m_name;
        protected int m_attack;
        
        public Entity(string id, string name, int attack)
        {
            m_id = id;
            m_name = name;
            m_attack = attack;
        }

        public string GetName()
        {
            return m_name;
        }

        public void SetName(string name)
        {
            m_name = name;
        }

        public void Shout()
        {
            Console.WriteLine("크아앙!!");
        }
    }
    internal class Player : Entity
    {
        public Player(string id, string name, int attack) : base(id, name, attack)
        {

        }

        public void MyAttack()
        {
            Console.WriteLine($"내 공격력은 {m_attack}이다!!");
        }
        
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("1", "기웅", 5);

            Entity entity = new Entity("2", "슬라임", 1);

            //접근 제한자 public은 어디서든 수정 및 접근이 가능하다!!
            player.Shout();

            //접근 제한자 private는 오직 자신만 수정 및 접근이 가능하다!!
            //entity.m_id = "3";

            //접근 제한자 protected는 부모와 자식만 접근이 가능하다!!
            player.MyAttack();

            //protected로 접근 제한이 걸린 필드를 Get함수 및 Set함수로 외부에서 수정 및 값 가져오기를 하기!!
            
            //Set메서드는 접근 제한이 걸린 필드를 외부에서 수정할 수 있게 만든다!!
            entity.SetName("조그마한 슬라임");

            //Get메서드는 접근 제한이 걸린 필드를 외부에서 볼 수 있도록 만든다!!
            Console.WriteLine(entity.GetName());


        }
    }
}
