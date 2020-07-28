using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Chombi
    {
        int hp = 10;
        int totalFood = 40;
        bool isDead = false;

        public int Hp { get => hp; set => hp = value; }
        public int TotalFood { get => totalFood; set => totalFood = value; }
        public bool IsDead { get => isDead; set => isDead = value; }
    }
}
