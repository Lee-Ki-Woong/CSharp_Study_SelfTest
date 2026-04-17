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
        public string m_id;
        public string m_name;
        
        public Entity(string id, string name)
        {
            m_id = id;
            m_name = name;
        }

        public void Shout()
        {
            Console.WriteLine("크아앙!!");
        }

    
    }
    internal class Player : Entity
    {
        public Player(string id, string name) : base(id, name)
        {

        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("1", "기웅");

            player.Shout();
        }
    }
}
