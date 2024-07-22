using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _class
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            c.MoveForward();
            c.MoveBack();
            c.TurnRight();
            c.TurnLeft();
            c.GetAttack(10);
            c.DoAttack();
        }
    }

    class Character
    {
        int level;
        int hp;
        int speed = 0;
        int attack;

        public Character()
        {
            level = 1;
            hp = 100;
            attack = 10;
        }

        public void MoveForward()
        {
            speed += 10;
            Console.WriteLine("앞으로 이동");
        }

        public void MoveBack()
        {
            speed -= 10;
            Console.WriteLine("뒤로 이동");
        }

        public void TurnRight()
        {
            Console.WriteLine("오른쪽으로 90도 회전");
        }

        public void TurnLeft()
        {
            Console.WriteLine("왼쪽으로 90도 회전");
        }

        public int DoAttack()
        {
            Console.WriteLine($"{this.attack}의 공격을 했습니다");
            return this.attack;
        }
        public void GetAttack(int enemyAttack)
        {
            this.hp -= enemyAttack;
            Console.WriteLine($"{enemyAttack}의 공격을 받았습니다. [ 남은 체력 : {this.hp} ]");
        }
    }
}
