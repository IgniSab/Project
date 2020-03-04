using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


                  Label label = new Label();
                  Random rand = new Random();
                  Random rand2 = new Random();
                  
                  int x = rand.Next(1, 10);
                  int y = rand.Next(1, 10);
                
                  label1.Text = Convert.ToString(x);
                  this.label2.Text = Convert.ToString(y);
                  this.label3.Text = "+";
                  this.label4.Text = "=";
                  this.label5.Text = Convert.ToString(x+y);
                  label6.Text = label5.Text;
                  if((x+y>10 && x>y)||(x+y>10 && y>x)){
                    label5.Text = Convert.ToString(x-y);

                  }else
                  {
                    label5.Text = Convert.ToString(x + y);
                  }


        }

        
        private void Update(){
        
            Random rand = new Random();
            Random rand2 = new Random();
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            label1.Text = Convert.ToString(a);
            this.label2.Text = Convert.ToString(b);
            this.label3.Text = "-";
            this.label4.Text = "=";
            this.label5.Text = Convert.ToString(a-b);
            label6.Text = label5.Text;
            if ((a - b < 0 && a > b) || (a - b < 0 && b > a))
            {
                label5.Text = Convert.ToString(a + b);

            }
            else
            {
                label5.Text = Convert.ToString(a - b);
            }

          
        }
           private void Update2(){
        
            Random rand = new Random();
            Random rand2 = new Random();
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            label1.Text = Convert.ToString(a);
            this.label2.Text = Convert.ToString(b);
            this.label3.Text = "+";
            this.label4.Text = "=";
            this.label5.Text = Convert.ToString(a+b);
            label6.Text = label5.Text;
            if ((a + b < 0 && a > b) || (a + b < 0 && b > a))
            {
                label5.Text = Convert.ToString(a - b);

            }
            else
            {
                label5.Text = Convert.ToString(a + b);
            }

          
        }
        private void Audio()
        {
            string fileName = "2.wav";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            SoundPlayer soundPlayer = new SoundPlayer(path);
            soundPlayer.Play();
        }
        private void Audio2()
        {
            string fileName2 = "1.wav";
            string path2 = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName2);
            SoundPlayer soundPlayer2 = new SoundPlayer(path2);
            soundPlayer2.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            Form2 form = new Form2();
            Form3 form2 = new Form3();
           
            if (label6.Text!=label5.Text)
            {

                Audio2();
                // form2.Show();
                MessageBox.Show("Неправильно", "Попробуй еще раз!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Update2();
               
            }
            else
            {

                Audio();
                //form.Show();
                MessageBox.Show("Правильно", "Молодец!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Update();
                
            }

          

          



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            Form3 form2 = new Form3();
            if (label6.Text != label5.Text)
            {
                Audio();
             //   form.Show();
                MessageBox.Show("Правильно", "Молодец!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Update2();
            }
            else
            {
                Audio2();
                MessageBox.Show("Неправильно", "Попробуй еще раз!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
              //  form2.Show();
                Update();
            }

         
     
        }

      
    }
}
