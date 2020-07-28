using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Player
    {
        
        int hp = 5;
        bool isdDead = false;
        bool dayPast = false;
        string name = "";
        bool haseaten = false;
        bool isinfected = false;
        bool issick = false;
        int daysTodie = 0;
        
       
        
        public int Hp { get => hp; set => hp = value; }
        public bool IsdDead { get => isdDead; set => isdDead = value; }
        public bool DayPast { get => dayPast; set => dayPast = value; }
       
        public bool Haseaten { get => haseaten; set => haseaten = value; }
        public bool Isinfected { get => isinfected; set => isinfected = value; }
        public bool Issick { get => issick; set => issick = value; }
        public int DaysTodie { get => daysTodie; set => daysTodie = value; }
        public string Namee { get => name; set => name = value; }
    }
}
