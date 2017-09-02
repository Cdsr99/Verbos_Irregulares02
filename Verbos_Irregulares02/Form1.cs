using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verbos_Irregulares02
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
            
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 novaforma = new Form2();
            novaforma.Show();
            
          
        }
        

        
        public void words()
        {
            Random rnd = new Random();
            String[] verbs = new String[] { "Arise", "Awake", "Be", "Bear", "Beat", "Become", "Begin", "Bend", "Bet", "Bid", "Bind", "Bite", "bleed", "blow", "break", "breed", "Blow", "Break", "Bring", "Bring", "Burn", "Burst", "Buy", "Cast", "Catch", "Choose", "Cling", "Clothe", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", };
            String choose = verbs[(rnd.Next(0, 25))];
            label2.Text = choose;

        }
        public void vereficacao()
        {
            if (label2.Text == "Arise" && textBox1.Text == "arose" && textBox2.Text == "arisen" && textBox4.Text == "erguer" || textBox4.Text == "levantar" )
            {
                resultado.Text = "Certo";//1
                
            }
            else if (label2.Text == "Awake" && textBox1.Text == "awoke" && textBox2.Text == "awoken" && textBox4.Text == "acordar" || textBox4.Text == "despertar")
            {
                resultado.Text = "Certo";//2
            }
            else if (label2.Text == "Be" && textBox1.Text == "was" || textBox1.Text == "were" && textBox2.Text == "been" && textBox4.Text == "ser" || textBox4.Text == "estar" || textBox4.Text == "ficar")
            {
                resultado.Text = "Certo";//3
            }
            else if (label2.Text == "Bear" && textBox1.Text == "bore" && textBox2.Text == "borne" && textBox4.Text == "suportar" || textBox4.Text == "aguentar")
            {
                resultado.Text = "Certo";//4
            }
            else if (label2.Text == "Beat" && textBox1.Text == "beat" && textBox2.Text == "beaten" && textBox4.Text == "bater" || textBox4.Text == "espancar" || textBox4.Text == "superar" || textBox4.Text == "vibrar" || textBox4.Text == "palpitar")
            {
                resultado.Text = "Certo";//5
            }
            else if (label2.Text == "Become" && textBox1.Text == "became" && textBox2.Text == "become" && textBox4.Text == "tornar-se"|| textBox4.Text == "tornar" || textBox4.Text == "torna se")
            {
                resultado.Text = "Certo";//6
            }
            else if (label2.Text == "Begin" && textBox1.Text == "began" && textBox2.Text == "begun" && textBox4.Text == "começar" || textBox4.Text == "iniciar")
            {
                resultado.Text = "Certo";//7
            }
            else if (label2.Text == "Bend" && textBox1.Text == "bent" && textBox2.Text == "bent" && textBox4.Text == "curvar"||textBox4.Text == "entortar"||textBox4.Text == "franzir"||textBox4.Text == "dirigir")
            {
                resultado.Text = "Certo";//8
            }
            else if (label2.Text == "Bet" && textBox1.Text == "bet" && textBox2.Text == "bet" && textBox4.Text == "apostar")
            {
                resultado.Text = "Certo";//9
            }
            else if (label2.Text == "Bid" && textBox1.Text == "bade" && textBox2.Text == "bidden" && textBox4.Text == "oferecer" || textBox4.Text == "convidar" || textBox4.Text == "ordenar" || textBox4.Text == "desejar" || textBox4.Text == "leiloar")
            {
                resultado.Text = "Certo";//10
            }
            else if (label2.Text == "Bind" && textBox1.Text == "bound" && textBox2.Text == "bound" && textBox4.Text == "atar" || textBox4.Text == "amarrar" || textBox4.Text == "obrigar")
            {
                resultado.Text = "Certo";//11
            }
            else if (label2.Text == "Bite" && textBox1.Text == "bit" && textBox2.Text == "bitten" && textBox4.Text == "morder" || textBox4.Text == "engolir ")
            {
                resultado.Text = "Certo";//12
            }
            else if (label2.Text == "bleed" && textBox1.Text == "bled" && textBox2.Text == "bled " && textBox4.Text == "sangrar" || textBox4.Text == "perder sangue")
            {
                resultado.Text = "Certo";//13
            }
            else if (label2.Text == "Blow" && textBox1.Text == "blew" && textBox2.Text == "blown" && textBox4.Text == "soprar" || textBox4.Text == "assobiar" || textBox4.Text == "fazer soar")
            {
                resultado.Text = "Certo";//14
            }
            else if (label2.Text == "Break" && textBox1.Text == "broke" && textBox2.Text == "broken" && textBox4.Text == "quebrar" || textBox4.Text == "romper" || textBox4.Text == "violar")
            {
                resultado.Text = "Certo";//15
            }
            else if (label2.Text == "Breed" && textBox1.Text == "bred" && textBox2.Text == "bred" && textBox4.Text == "procriar" || textBox4.Text == "gerar" || textBox4.Text == "fazer criação" || textBox4.Text == "educar" || textBox4.Text == "ensinar")
            {
                resultado.Text = "Certo";//16  
            }
            else if (label2.Text == "Bring" && textBox1.Text == "brought" && textBox2.Text == "brought" && textBox4.Text == "trazer" || textBox4.Text == "servir"||textBox4.Text == "causar"||textBox4.Text == "executar")
            {
                resultado.Text = "Certo";//17 
            }
            else if (label2.Text == "Build" && textBox1.Text == "built" && textBox2.Text == "built" && textBox4.Text == "edificar" || textBox4.Text == "construir" || textBox4.Text == "fabricar")
            {
                resultado.Text = "Certo";//18
            }
            else if (label2.Text == "Burn" && textBox1.Text == "burnt" && textBox2.Text == "burnt" && textBox4.Text == "queimar" || textBox4.Text == "incendiar" || textBox4.Text == "carbonizar")
            {
                resultado.Text = "Certo";//19
            }
            else if (label2.Text == "Burst" && textBox1.Text == "burst" && textBox2.Text == "burst" && textBox4.Text == "arrebentar" || textBox4.Text == "explodir" || textBox4.Text == "brotar")
            {
                resultado.Text = "Certo";//20
            }
            else if (label2.Text == "Buy" && textBox1.Text == "bought" && textBox2.Text == "bought" && textBox4.Text == "comprar")
            {
                resultado.Text = "Certo";//21
            }
            else if (label2.Text == "Cast" && textBox1.Text == "cast" && textBox2.Text == "cast" && textBox4.Text == "arremessar" || textBox4.Text == "jogar" || textBox4.Text == "derrubar")
            {
                resultado.Text = "Certo";//22
            }
            else if (label2.Text == "Catch" && textBox1.Text == "caught" && textBox2.Text == "caught" && textBox4.Text == "pegar" || textBox4.Text == "capturar" || textBox4.Text == "entender" || textBox4.Text == "adquirir")
            {
                resultado.Text = "Certo";//23
            }
            else if (label2.Text == "Choose" && textBox1.Text == "chose" && textBox2.Text == "chosen" && textBox4.Text == "escolher")
            {
                resultado.Text = "Certo";//24
            }
            else if (label2.Text == "Cling" && textBox1.Text == "clung" && textBox2.Text == "clung" && textBox4.Text == "pegar-se" || textBox4.Text == "unir-se" || textBox4.Text == "pegar" || textBox4.Text == "unir" || textBox4.Text == "aderir")
            {
                resultado.Text = "Certo";//25
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
            else if (label2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                resultado.Text = "Certo";
            }
                





            else
            {
                resultado.Text = "Errado";
            }

        }


        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            words();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            resultado.Text = ".....";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vereficacao();
        }

        /*private void button3_Click(object sender, EventArgs e)
        {   
            if
            textBox4.Text = "Verb: Arisen Simple Past: Arose  Past Participle: Arisen Mean:Erguer ou levantar";
        }*/

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.SelectionStart = textBox3.Text.Length;

            textBox3.ScrollToCaret();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            //this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
           // System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 novaforma = new Form3();
            novaforma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.coca-cola.com/global/");
        }

        private void showMeMyWonrryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.wizard.com.br/blog/aprender-ingles/tabela-de-verbos-irregulares-em-ingles/");

        }
       


       
    }
}
