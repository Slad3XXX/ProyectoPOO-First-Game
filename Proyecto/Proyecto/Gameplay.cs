using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Proyecto
{
    public partial class Gameplay : Form
    {

        public int days = 0;
        public bool dayhaspassed;
        public int ldamage;
        public int hdamage;
        public int infectedDays;
        public Form1 forma1;
        public string currentLocation;
        Player p1 = new Player();
        Player p2 = new Player();
        Player p3 = new Player();
        Player p4 = new Player();
        Chombi chombi = new Chombi();
        Random misc = new Random();
        Random r1 = new Random();
        Random r2 = new Random();
        Random r3 = new Random();

        public string name1, name2, name3, name4;
        List<string> Map = new List<string>() { "Yucatan", "Campeche", "Tabasco", "Veracruz", "San Luis Potosi", "Zacatecas", "Durango", "Chihuahua", "Sonara", "Baja California Norte", "Baja California Sur" };
        public Gameplay(string n1, string n2, string n3, string n4)
        {
            InitializeComponent();
            Maap.Controls.Add(Zombie);
            Maap.Controls.Add(Combi);
            Maap.Controls.Add(lightFire);
            Maap.Controls.Add(hFire1);
            Maap.Controls.Add(Tool);
            Maap.Controls.Add(Food);
            Maap.Controls.Add(Won1);
            Maap.Controls.Add(Won2);
            Maap.Controls.Add(Flu);
            Maap.Controls.Add(Food2);
            Maap.Controls.Add(Food3);
            Food2.BackColor = Color.Transparent;
            Food3.BackColor = Color.Transparent;
            Tool.BackColor = Color.Transparent;
            Food.BackColor = Color.Transparent;
            Won1.BackColor = Color.Transparent;
            Won2.BackColor = Color.Transparent;
            Flu.BackColor = Color.Transparent;
            lightFire.BackColor = Color.Transparent;
            hFire1.BackColor = Color.Transparent;
            Combi.BackColor = Color.Transparent;
            Zombie.BackColor = Color.Transparent;
            Zombie.Hide();
            lightFire.Hide();
            hFire1.Hide();
            Won2.Hide();
            Tool.Hide();
            Won1.Hide();
            Flu.Hide();
            Food.Hide();
            Food2.Hide();
            Food3.Hide();
            Maap.SendToBack();
            Combi.SendToBack();
            lightFire.BringToFront();
            name1 = n1;
            name2 = n2;
            name3 = n3;
            name4 = n4;
            p1.Namee = name1;
            p2.Namee = name2;
            p3.Namee = name3;
            p4.Namee = name4;
            l_P1.Text += p1.Hp;
            l_P2.Text += p2.Hp;
            l_P3.Text += p3.Hp;
            l_P4.Text += p4.Hp;
            l_Food.Text += chombi.TotalFood;
            l_CombiHp.Text += chombi.Hp;
            label_Player1.Text = p1.Namee;
            label_Player2.Text = p2.Namee;
            label_Player3.Text = p3.Namee;
            label_Player4.Text = p4.Namee;





            tbGameplayMessage.Text += "Empieza el juego, se encuentran en Yucatan \r\n ";
        }
        async Task Animations()
        {
            await Task.Delay(3000);
        }
        

        public void MaxItems()
        {
            if (chombi.Hp > 10)
            {
                chombi.Hp = 10;
            }
            if (chombi.TotalFood>40)
            {
                chombi.TotalFood = 40;
            }
        }

        public void Eat()
        {
            if (p1.IsdDead == false) 
            {
                p1.Haseaten = true;
                if (p1.Haseaten == true)
                {
                    if (chombi.TotalFood > 0)
                    {
                        chombi.TotalFood--;
                    }
                    else
                    {
                        p1.Hp -- ;
                        tbGameplayMessage.Text += "No hay comida el jugador " + p1.Namee + " ha perdido un punto de vida \r\n ";
                    }
                }
            }
            if (p2.IsdDead == false)
            {
                p2.Haseaten = true;
                if (p2.Haseaten == true)
                {
                    if (chombi.TotalFood > 0)
                    {
                        chombi.TotalFood--;
                    }
                    else
                    {
                        p2.Hp--;
                        tbGameplayMessage.Text += "No hay comida el jugador " + p2.Namee + " ha perdido un punto de vida \r\n ";
                    }
                }
            }
            if (p3.IsdDead == false)
            {
                p3.Haseaten = true;
                if (p3.Haseaten == true)
                {
                    if (chombi.TotalFood > 0)
                    {
                        chombi.TotalFood--;
                    }
                    else
                    {
                        p3.Hp--;
                        tbGameplayMessage.Text += "No hay comida el jugador " + p3.Namee + " ha perdido un punto de vida \r\n ";
                    }
                }
            }
            if (p4.IsdDead == false)
            {
                p4.Haseaten = true;
                if (p4.Haseaten == true)
                {
                    if (chombi.TotalFood > 0)
                    {
                        chombi.TotalFood--;
                    }
                    else
                    {
                        p4.Hp--;
                        tbGameplayMessage.Text += "No hay comida el jugador " + p4.Namee + " ha perdido un punto de vida \r\n ";
                    }
                }
            }
            
        }
        public void UpdateText()
        {
            l_P1.Text = p1.Hp.ToString();
            l_P2.Text = p2.Hp.ToString();
            l_P3.Text = p3.Hp.ToString();
            l_P4.Text = p4.Hp.ToString();
            l_Food.Text = chombi.TotalFood.ToString();
            l_CombiHp.Text = chombi.Hp.ToString();
            if(p1.IsdDead == true)
            {
                label_Player1.Visible = false;
                l_P1.Visible = false;
            }
            if (p2.IsdDead == true)
            {
                label_Player2.Visible = false;
                l_P2.Visible = false;

            }
            if (p3.IsdDead == true)
            {
                label_Player3.Visible = false;
                l_P3.Visible = false;
            } 
            if (p4.IsdDead == true)
            {
                label_Player4.Visible = false;
                l_P4.Visible = false;
            }
        }
        public async void checkgame()

        { 
            if (dayhaspassed == true)
            {
                days++;
                if (p1.Isinfected == true)
                {
                    p1.DaysTodie--;
                    if (p1.DaysTodie == 0) { tbGameplayMessage.Text += "El jugador " + p1.Namee + " ha sido convertido en zombie y tuvo que abandonar el viaje \r\n"; p1.IsdDead = true; }
                }
                if (p2.Isinfected == true)
                {
                    p2.DaysTodie--;
                    if (p2.DaysTodie == 0) { tbGameplayMessage.Text += "El jugador " + p2.Namee + " ha sido convertido en zombie y tuvo que abandonar el viaje \r\n"; p2.IsdDead = true; }
                }
                if (p3.Isinfected == true)
                {
                    p3.DaysTodie--;
                    if (p3.DaysTodie == 0) { tbGameplayMessage.Text += "El jugador " + p3.Namee + " ha sido convertido en zombie y tuvo que abandonar el viaje \r\n"; p3.IsdDead = true; }
                }
                if (p4.Isinfected == true)
                {
                    p4.DaysTodie--;
                    if (p4.DaysTodie == 0) { tbGameplayMessage.Text += "El jugador " + p4.Namee + " ha sido convertido en zombie y tuvo que abandonar el viaje \r\n"; p4.IsdDead = true; }
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (days == i)
                {
                    tbGameplayMessage.Text += "Estan en " + Map[i] + "\r\n";
                    if (i == 10)
                    {
                        Won1.Visible = true;
                        Won2.Visible = true;
                        await Animations();
                        tbGameplayMessage.Text += " ¡Llegaste al ultimo punto del tour, terminaste el juego! :D ";
                        bViajar.Enabled = false;
                        bBComida.Enabled = false;
                        bBRefac.Enabled = false;
                        MessageBox.Show(" ¡¡¡¡¡COMPLETASTE EL JUEGO!!!!!! ");
                       
                    }

                }

            }
            CheckHP();
            if (p1.Hp <= 0 && p2.Hp <= 0 && p3.Hp <= 0 && p4.Hp <= 0)
            {
                MessageBox.Show(" GAME OVER ");
                bViajar.Enabled = false;
                bBRefac.Enabled = false;
                bBComida.Enabled = false;
            }



        } 
        public void InfectPlayer() //Se infecta un jugador y se calcula cuanto le queda de vida 
        {
            var selec = r1.Next(1, 5);
            var random = r3.Next(1, 3);
            int infectedDays = misc.Next(3, 8);
            if (selec == 1 && p1.Isinfected == false)   // Jugador 1 seleccionado y no esta infectado
            {
                p1.Isinfected = true;
                p1.DaysTodie = infectedDays;
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " esta infectado y se convertira en un zombie en " + p1.DaysTodie + " dias \r\n";


            }
            else if (selec == 1 && p1.Isinfected == true)
            {
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " ya esta infectado y se volvera un zombie en " + p1.DaysTodie;  //Checar cuando se se va a morir
            }
            else if (selec == 2 && p2.Isinfected == false) //Jugador 2 seleccionado y no esta infectado 
            {
                p2.Isinfected = true;
                p2.DaysTodie = infectedDays;
                tbGameplayMessage.Text += "El jugador " + p2.Namee + " esta enfermo y se convertira en un zombie en " + p2.DaysTodie + " dias \r\n";

            }
            else if (selec == 2 && p2.Isinfected == true)
            {
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " ya esta infectado y se volvera un zombie en " + p2.DaysTodie;  //Checar cuando se se va a morir
            }
            else if (selec == 3 && p3.Isinfected == false) //Jugador 3 seleccionado y no esta infectado 
            {
                p2.Isinfected = true;
                p3.DaysTodie = infectedDays;
                tbGameplayMessage.Text += "El jugador " + p3.Namee + " esta infectado y se convertira en un zombie en " + p3.DaysTodie + " dias \r\n";

            }
            else if (selec == 3 && p3.Isinfected == true)
            {
                tbGameplayMessage.Text += "El jugador " + p3.Namee + " ya esta infectado y se volvera un zombie en " + p3.DaysTodie;  //Checar cuando se se va a morir
            }
            else if (selec == 4 && p4.Isinfected == false) //Jugador 4 seleccionado y no esta infectado 
            {
                p4.Isinfected = true;
                p4.DaysTodie = infectedDays;
                tbGameplayMessage.Text += "El jugador " + p4.Namee + " esta infectado y se convertira en un zombie en " + p4.DaysTodie + " dias \r\n";

            }
            else if (selec == 4 && p4.Isinfected == true)
            {
                tbGameplayMessage.Text += "El jugador " + p4.Namee + " ya esta infectado y se volvera un zombie en " + p4.DaysTodie;  //Checar cuando se se va a morir
            }


        }
        public void Sick()  // Jugador se enferma, no puede estar infectado o enfermo 
        
        {
            var selec = misc.Next(1, 5);
            
            if (p1.Issick == true && p2.Issick == true && p3.Issick == true && p4.Issick == true)
            {
                tbGameplayMessage.Text += " Todos lo jugadores ya estan enfermos \r\n";
            }
            else
            { 
            if (selec == 1)
            {
                if (p1.Isinfected == false && p1.Issick == false) // Si el jugador uno no esta infectado o enfermo 
                {
                    tbGameplayMessage.Text += "El jugador " + p1.Namee + " esta enfermo \r\n";
                    p1.Issick = true;
                }
                else // Si ya esta infectado o enfermo 
                {
                    selec = misc.Next(2, 5);

                }

            }
            else if (selec == 2)
            {
                if (p2.Isinfected == false && p2.Issick == false) // Si el jugador dos no esta infectado o enfermo 
                {
                    tbGameplayMessage.Text += "El jugador " + p2.Namee + " esta enfermo \r\n";
                    p2.Issick = true;
                }
                else // Si ya esta infectado o enfermo 
                {
                    do
                    {
                        selec = misc.Next(1, 5);
                    } while (selec != 2);
                    

                }
            }
            else if (selec == 3)
            {
                if (p3.Isinfected == false && p3.Issick == false) // Si el jugador tres no esta infectado o enfermo 
                {
                    tbGameplayMessage.Text += "El jugador " + p3.Namee + " esta enfermo \r\n";
                    p3.Issick = true;
                }
                else // Si ya esta infectado o enfermo 
                {
                    do
                    {
                        selec = misc.Next(1, 5);
                    } while (selec != 3);
                }
            }
            else if (selec == 4)
            {
                if (p4.Isinfected == false && p4.Issick == false) // Si el jugador cuatro no esta infectado o enfermo 
                {
                    tbGameplayMessage.Text += "El jugador " + p4.Namee + " esta enfermo \r\n";
                    p4.Issick = true;
                }
                else // Si ya esta infectado o enfermo 
                {
                    do
                    {
                        selec = misc.Next(1, 5);
                    } while (selec != 4);

                }
            }
        }
        }
        public void WhenSick() /// Cuando esten enfermos, al dia perderan 50% de posibilidad de perder 1 punto de vida 
        {
            int selec = misc.Next(1, 3);
            if(p1.Issick==true)
            {
                if(selec == 1)
                {
                    tbGameplayMessage.Text += " El jugador " + p1.Namee + " ha recibido 1 punto de daño, porque esta enfermo \r\n ";
                    p1.Hp--;
                }
                else
                {
                    tbGameplayMessage.Text += " El jugador " + p1.Namee + " esta enfermo pero no recibio nada de daño \r\n ";
                  
                }
            }
            if (p2.Issick == true)
            {
                if (selec == 1)
                {
                    tbGameplayMessage.Text += " El jugador " + p2.Namee + " ha recibido 1 punto de daño, porque esta enfermo \r\n ";
                    p2.Hp--;
                }
                else
                {
                    tbGameplayMessage.Text += " El jugador " + p2.Namee + " esta enfermo pero no recibio nada de daño \r\n ";
                }
            }
            if (p3.Issick == true)
            {
                if (selec == 1)
                {
                    tbGameplayMessage.Text += " El jugador " + p3.Namee + " ha recibido 1 punto de daño, porque esta enfermo \r\n ";
                    p3.Hp--;
                }
                else
                {
                    tbGameplayMessage.Text += " El jugador " + p3.Namee + " esta enfermo pero no recibio nada de daño \r\n ";
                }
            }
            if (p4.Issick == true)
            {
                if (selec == 1)
                {
                    tbGameplayMessage.Text += " El jugador " + p4.Namee + " ha recibido 1 punto de daño, porque esta enfermo \r\n ";
                    p4.Hp--;
                }
                else
                {
                    tbGameplayMessage.Text += " El jugador " + p4.Namee + " esta enfermo pero no recibio nada de daño \r\n ";
                }
            }
        }
        public void CheckHP() //Checar si el jugador o la combi tienen aun puntos de vida
        {

            if (p1.Hp <= 0)
            {
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " esta muerto RIP \r\n";
                p1.IsdDead = true;
            }
            if (p2.Hp <= 0)
            {
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " esta muerto RIP \r\n";
                p2.IsdDead = true;
            }
            if (p3.Hp <= 0)
            {
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " esta muerto RIP \r\n";
                p3.IsdDead = true;
            }
            if (p4.Hp <= 0)
            {
                tbGameplayMessage.Text += "El jugador " + p1.Namee + " esta muerto RIP \r\n";
                p4.IsdDead = true;
            }
            if (chombi.Hp <= 0)
            {
                tbGameplayMessage.Text += "La combi tiene " + chombi.Hp + " puntos de vida , la opcion de viajar no estra disponible";
                bViajar.Enabled = false;
            }

        }

        public void lightChombiDamage() // Daño leve a cobmi
        {
            ldamage = misc.Next(1, 3);
            chombi.Hp -= ldamage;
            tbGameplayMessage.Text += " Ocurrió un ataque zombie y la combi recibio " + ldamage + " puntos de daño \r\n "; 
        }
        public void heavyChombiDamage() // Daño grave a combi
        {
            hdamage = misc.Next(2, 5);
            chombi.Hp -= hdamage;
            tbGameplayMessage.Text += " Ocurrió un ataque zombie y La combi recibio " + hdamage + " puntos de daño \r\n ";
        }
        public void zombieAttaack() // Ataque zombi 
        {
            
            int random2 = r2.Next(1, 11); //Eventos
            int random3 = r3.Next(1, 5); //Seleccionar Jugador
            int infectedDays = misc.Next(3, 8);
            hdamage = r1.Next(2, 5);
            ldamage = r1.Next(1, 3);
            if (random2 <= 4) //Pasajeros Defienden bien 40%
            {
                tbGameplayMessage.Text += " Ocurrió un ataque zombie, los pasajeros defendieron bien, nadie recibio daño :D \r\n";
            }
            else if (random2 == 5) //Pasajero infectado 10% 
            {
                InfectPlayer();
            }
            else if (random2 == 6 || random2 == 7) // Zombies dañan combi 20%
            {
                lightChombiDamage();
            }
            else if (random2 == 8 || random2 == 9) // Combaatieron pero pasajeroherido levemente 20%
            {
                if (random3 == 1) //Jugador 1 dañado
                {
                    p1.Hp -= ldamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el pasajero " + p1.Namee + " ha sido dañado con " + ldamage + "\r\n";

                }
                else if (random3 == 2) //Jugador 2 dañado
                {
                    p2.Hp -= ldamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el pasajero " + p2.Namee + " ha sido dañado con " + ldamage + "\r\n";

                }
                else if (random3 == 3) //Jugador 3 dañado
                {
                    p3.Hp -= ldamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el pasajero " + p3.Namee + " ha sido dañado con " + ldamage + "\r\n";
                }
                else if (random3 == 4) //Jugador 4 dañado
                {
                    p4.Hp -= ldamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el passajero " + p4.Namee + " ha sido dañado con " + ldamage + "\r\n";
                }
            }
            else if (random2 == 10) // Combatieron pero pasajero herido gravemente 10%
            {
                if (r3.Next(1, 5) == 1) //Jugador 1 dañado
                {
                    p1.Hp -= hdamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el pasajero " + p1.Namee + " ha sido dañado con " + hdamage + "\r\n";

                }
                else if (r3.Next(1, 5) == 2) //Jugador 2 dañado
                {
                    p2.Hp -= hdamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el pasajero " + p2.Namee + " ha sido dañado con " + hdamage + "\r\n";

                }
                else if (r3.Next(1, 5) == 3) //Jugador 3 dañado
                {
                    p3.Hp -= hdamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el pasajero " + p3.Namee + " ha sido dañado con " + hdamage + "\r\n";
                }
                else if (r3.Next(1, 5) == 4) //Jugador 4 dañado
                {
                    p4.Hp -= hdamage;
                    tbGameplayMessage.Text += " Ocurrió un ataque zombie y el passajero " + p4.Namee + " ha sido dañado con " + hdamage + "\r\n";
                }
            }

        }

        private void Gameplay_Load(object sender, EventArgs e)
        {


        }

        private async void bViajar_Click(object sender, EventArgs e)
        
        {
            //await Animations();
            int random1 = r1.Next(1, 11); //Random para posibilidades exterirores
            int random4 = misc.Next(1, 11);
            if (random1 <= 3) //Ataque Zombie 30%f
            {
                Zombie.Visible = true; 
                await Animations();
                zombieAttaack();
                Zombie.Visible = false;
            }
            else if (random1 == 4 || random1 == 5) // Daño a combi 20%
            {
                if (random4 <= 7) // Daño leve a la combi 70%
                {
                    lightFire.Visible = true;
                    await Animations();
                    lightChombiDamage();
                    lightFire.Visible = false;
                }
                else if (random4 >= 8) // Daño grave a la combi 30%
                {
                    lightFire.Visible = true;
                    hFire1.Visible = true;
                    await Animations();
                    heavyChombiDamage();
                    lightFire.Visible = false;
                    hFire1.Visible = false;
                }
            }
            else if (random1 == 6 || random1 == 7) // Pasajero Enfermo 20%
            {
                Flu.Visible = true;
                await Animations();
                Sick();
                Flu.Visible = false;
            }
            else if (random1 > 7)  // No pasa nada 30%
            {
                await Animations();
                tbGameplayMessage.Text += " No paso nada, por esta vez... \r\n";
            }
            
            dayhaspassed = true;
            Eat();
            WhenSick();
            UpdateText();
            checkgame();
            
            
            
        }

        private async void bBRefac_Click(object sender, EventArgs e)
        {
            //await Animations();
            
            int random1 = r1.Next(1, 101);
            int random2 = r2.Next(2, 5);
            int random3 = r3.Next(1, 3);

            if (random1 <= 35) // 35% encontrar refacciones grandes
            {
                Tool.Visible = true;
                await Animations();
                chombi.Hp += random2;
                MaxItems();
                tbGameplayMessage.Text += "Se encontraron " + random2 + " refacciones necesarias para la combi, sus puntos han aumentado a " + chombi.Hp + "\r\n";
                Tool.Visible = false;

            }
            else if (random1 > 35 && random1 <= 70) // 35% encontrar refacciones pequeñas
            {
                Tool.Visible = true;
                await Animations();
                chombi.Hp += random3;
                MaxItems();
                tbGameplayMessage.Text += "Se encontraron " + random3 + " refacciones necesarias para la combi, sus puntos han aumentado a " + chombi.Hp + "\r\n";
                Tool.Visible = false;
            }
            else if (random1 > 70 && random1 <= 90) // 20% no se encontro nada
            {

                await Animations();
                chombi.Hp += random2;
                tbGameplayMessage.Text += "No se encontraron refacciones :( \r\n";
                
            }
            else if (random1 > 90 && random1 <= 100) // 10% ataque zombie 
            {
                Zombie.Visible = true;
                await Animations();
                zombieAttaack();
                Zombie.Visible = false;
            }
           
            dayhaspassed = true;
            Eat();
            WhenSick();
            UpdateText();
            checkgame();


        }

        private async void bBComida_Click(object sender, EventArgs e)
        {
            int random1 = r1.Next(1, 101);
            int random2 = r2.Next(10, 16);
            int random3 = r3.Next(15, 26);
            int random4 = misc.Next(7, 11);
            if (random1 <= 20) // 20% Ataque Zombie
            {
                Zombie.Visible = true;
                await Animations();
                zombieAttaack();
                Zombie.Visible = false;
            }
            else if (random1 > 20 && random1 <= 40) // 20% No hay comida
            {
                await Animations();
                tbGameplayMessage.Text += "No se encontro comida :( \r\n";
            }
            else if (random1 > 40 && random1 <= 65) // 25% Se encontro poca comida
            {
                Food.Visible = true;
                await Animations();
                chombi.TotalFood += random4;
                MaxItems();
                tbGameplayMessage.Text += "Se encontraron " + random4 + " raciones de comida en una casa \r\n";
                Food.Visible = false;
            }
            else if (random1 > 65 && random1 <= 90) // 25% Se encontro mucha comida
            {
                Food2.Visible = true;
                await Animations();
                chombi.TotalFood += random2;
                MaxItems();
                tbGameplayMessage.Text += "Se encontraron " + random2 + " raciones de comida en una casa \r\n";
                Food2.Visible = false;
            }
            else if (random1 > 90) //10% Se encontro bastante comida
            {
                Food3.Visible = true;
                await Animations();
                chombi.TotalFood += random3;
                MaxItems();
                tbGameplayMessage.Text += "Se encontraron " + random3 + " raciones de comida en un supermercado abandonado \r\n";
                Food3.Visible = false;
            }
            dayhaspassed = true;
            Eat();
            WhenSick();
            UpdateText();
            checkgame();
        }
    }
}



