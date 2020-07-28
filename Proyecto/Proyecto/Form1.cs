using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {

        List<string> nameList = new List<string>();
        List<string> lastnameList = new List<string>();
        int rnName, rnLastName;
      
       
        public Form1()
        {
            InitializeComponent();
           
            StreamReader name = new StreamReader("nombres.txt");
            StreamReader lastname = new StreamReader("apellidos.txt");
            







            //Añadir nombres y apellidos a listas 
            while (!name.EndOfStream)
            {

                nameList.Add(name.ReadLine());

            }
            name.Close();
            while (!lastname.EndOfStream)
            {
                lastnameList.Add(lastname.ReadLine());
            }
            lastname.Close();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            

            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            Player p4 = new Player();

            Random rname = new Random();
            Random rlastname = new Random();
           
            if (tbPlayer1.Text.Equals(""))
            {
                rnName = rname.Next(1, 101);
                rnLastName = rlastname.Next(1, 101);
                tbPlayer1.Text += nameList[rnName] + lastnameList[rnLastName];
                p1.Namee = tbPlayer1.Text;
                


            }
            else
            {
                p1.Namee = tbPlayer1.Text;
                
            }
            if (tbPlayer2.Text.Equals(""))
            {
                rnName = rname.Next(1, 101);
                rnLastName = rlastname.Next(1, 101);
                tbPlayer2.Text += nameList[rnName] + lastnameList[rnLastName];
                p2.Namee = tbPlayer2.Text;
            }
            else
            {
                p2.Namee = tbPlayer2.Text;
                
            }
            if (tbPlayer3.Text.Equals(""))
            {
                rnName = rname.Next(1, 101);
                rnLastName = rlastname.Next(1, 101);
                tbPlayer3.Text += nameList[rnName] + lastnameList[rnLastName];
                p3.Namee = tbPlayer3.Text;
            }
            else
            {
                p3.Namee = tbPlayer3.Text;
               
            }
            if (tbPlayer4.Text.Equals(""))
            {
                rnName = rname.Next(1, 101);
                rnLastName = rlastname.Next(1, 101);
                tbPlayer4.Text += nameList[rnName] + lastnameList[rnLastName];
                p4.Namee = tbPlayer4.Text;
               
            }
            else
            {
                p4.Namee = tbPlayer4.Text;
               
            }
            Gameplay gameplay = new Gameplay(p1.Namee, p2.Namee, p3.Namee, p4.Namee);
            gameplay.Show();
            
            
        }
    }
}
