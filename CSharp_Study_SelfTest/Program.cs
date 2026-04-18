using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study_SelfTest
{
    internal class Entity
    {
        private string m_id;
        public string m_name;
        protected int m_attack;
        
        public Entity(string id, string name, int attack)
        {
            m_id = id;
            m_name = name;
            m_attack = attack;
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
            entity.m_name = "바다 슬라임";
            player.Shout();

            //접근 제한자 private는 오직 자신만 수정 및 접근이 가능하다!!
            //entity.m_id = "3";

            //접근 제한자 protected는 부모와 자식만 접근이 가능하다!!
            player.MyAttack();
        }
    }
}
