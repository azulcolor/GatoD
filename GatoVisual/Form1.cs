using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Focus();
            bool rest = false;
            if (rest == false)
            {
                button10.Enabled = false;
            }

        }
        bool x = false;
        bool o = true;
        int mode, conta = 1;
        bool hard = false;
        string equis = "";
        string circulo = "";
        int k1 = 10, k2 = 10, k3 = 10, k4 = 10, k5 = 10, k6 = 10, k7 = 10, k8 = 10, k9 = 10, contador;
        bool hardWinBool = true, hardWinBool2 = false, normalMode = false, second = false, checkNormal = false, win = false;
        int hardWinOpc;
        Random rnd = new Random();


        public void Winner()
        {
            //Horizontal

            comprobation(k1, k2, k3);

            comprobation(k4, k5, k6);

            comprobation(k7, k8, k9);

            //vertical

            comprobation(k1, k4, k7);

            comprobation(k2, k5, k8);

            comprobation(k3, k6, k9);


            //diagonal

            comprobation(k1, k5, k9);

            comprobation(k3, k5, k7);

        }
        public void AsignarValor(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            if (mode == 1)
            {
                if (x == true)
                {
                    btn.Text = "X";
                    ver(btn, 1);
                    x = false;
                    o = true;
                    btn.Enabled = false;
                    radioButton1.Checked = true;
                }
                else
                {
                    btn.Text = "O";
                    ver(btn, 3);
                    o = false;
                    x = true;
                    btn.Enabled = false;
                    radioButton2.Checked = true;
                }
                Winner();
            }

            if (mode == 2)
            {
                btn.Text = "X";
                ver(btn, 1);
                btn.Enabled = false;
                radioButton1.Checked = true;
                Winner(); contador += 1;
                if (mode != 0)
                {
                    radioButton2.Checked = true;
                    System.Threading.Thread.Sleep(250);
                    easyMode(5);
                    Winner();
                }

            }
             if (mode == 3)
            {
                btn.Text = "X";
                ver(btn, 1);
                btn.Enabled = false;
                radioButton1.Checked = true;
                Winner(); contador += 1;
                if (mode != 0)
                {
                    radioButton2.Checked = true;
                    System.Threading.Thread.Sleep(250);
                    intermadeMode(5);
                    Winner();
                }
            }
            if (mode == 4)
            {
      
            btn.Text = "X";
            ver(btn, 1);
            btn.Enabled = false;
            radioButton1.Checked = true;
            Winner(); contador += 1;

                radioButton2.Checked = true;
                System.Threading.Thread.Sleep(250);
                hardMode();
                Winner();

                if (win == false)
                {
                    empate();
                }
                


            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
            textBox2.Visible = true;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            equis = textBox1.Text;
            radioButton1.Text = equis;
            circulo = textBox2.Text;
            radioButton2.Text = circulo;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            uno.Enabled = true;
            dos.Enabled = true;
            tres.Enabled = true;
            cuatro.Enabled = true;
            cinco.Enabled = true;
            seis.Enabled = true;
            siete.Enabled = true;
            ocho.Enabled = true;
            nueve.Enabled = true;
            button10.Enabled = true;

            if (mode == 4)
            {
                radioButton2.Checked = true;
                System.Threading.Thread.Sleep(300);
                hardMode();
                Winner(); contador += 1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            circulo = "Robotsito";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            mode = 1;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            textBox2.Enabled = false;
            mode = 2;
            textBox2.Text = "Robotsito";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            textBox2.Enabled = false;
            mode = 3;
            textBox2.Text = "Robotsito";
            k1 = 2;
            k2 = 2;
            k3 = 2;
            k5 = 2;
            k6 = 2;
            k7 = 2;
            k8 = 2;
            k9 = 2;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("En este modo la máquita tira al azar");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este modo la máquina evitará que ganes");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este modo la máquina intentará ganarte");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            textBox2.Enabled = false;
            mode = 4;
            textBox2.Text = "Robotsito";
            k1 = 2;
            k2 = 2;
            k3 = 2;
            k4 = 2;
            k5 = 2;
            k6 = 2;
            k7 = 2;
            k8 = 2;
            k9 = 2;

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ver(object sender, int num)
        {
            if (sender == uno)
            {
                k1 = num;
            }
            if (sender == dos)
            {
                k2 = num;
            }

            if (sender == tres)
            {
                k3 = num;
            }

            if (sender == cuatro)
            {
                k4 = num;
            }

            if (sender == cinco)
            {
                k5 = num;
            }

            if (sender == seis)
            {
                k6 = num;
            }

            if (sender == siete)
            {
                k7 = num;
            }

            if (sender == ocho)
            {
                k8 = num;
            }

            if (sender == nueve)
            {
                k9 = num;
            }

        }

        private void comprobation(int num1, int num2, int num3)
        {
            if (num1 + num2 + num3 == 3 || num1 + num2 + num3 == 9)
            {
                if (num1 + num2 + num3 == 3 )
                {
                    MessageBox.Show("ha ganado  " + equis);
                    mode = 0;
                }
                if (num1 + num2 + num3 == 9)
                {
                    MessageBox.Show("ha ganado  " + circulo);
                    mode = 0;
                }
                uno.Enabled = false;
                dos.Enabled = false;
                tres.Enabled = false;
                cuatro.Enabled = false;
                cinco.Enabled = false;
                seis.Enabled = false;
                siete.Enabled = false;
                ocho.Enabled = false;
                nueve.Enabled = false;
            }
        }

        

        private void easyMode(int timer)
        {
            int numero;
            bool encontrar = false;

            while (encontrar == false)
            {
                numero = rnd.Next(1, 9);

                switch (numero)
                {
                    case 1:
                        if (uno.Text != "X" & uno.Text != "O")
                        {
                            uno.Text = "O"; uno.Enabled = false;
                            encontrar = true; ver(uno, 3);
                        }
                        break;

                    case 2:
                        if (dos.Text != "X" & dos.Text != "O")
                        {
                            dos.Text = "O"; dos.Enabled = false;
                            encontrar = true; ver(dos, 3);
                        }
                        break;

                    case 3:
                        if (tres.Text != "X" & tres.Text != "O")
                        {
                            tres.Text = "O"; tres.Enabled = false;
                            encontrar = true; ver(tres, 3);
                        }
                        break;

                    case 4:
                        if (cuatro.Text != "X" & cuatro.Text != "O")
                        {
                            cuatro.Text = "O"; cuatro.Enabled = false;
                            encontrar = true; ver(cuatro, 3);
                        }
                        break;

                    case 5:
                        if (cinco.Text != "X" & cinco.Text != "O")
                        {
                            cinco.Text = "O"; cinco.Enabled = false;
                            encontrar = true; ver(cinco, 3);
                        }
                        break;

                    case 6:
                        if (seis.Text != "X" & seis.Text != "O")
                        {
                            seis.Text = "O"; seis.Enabled = false;
                            encontrar = true; ver(seis, 3);
                        }
                        break;

                    case 7:
                        if (siete.Text != "X" & siete.Text != "O")
                        {
                            siete.Text = "O"; siete.Enabled = false;
                            encontrar = true; ver(siete, 3);
                        }
                        break;

                    case 8:
                        if (ocho.Text != "X" & ocho.Text != "O")
                        {
                            ocho.Text = "O"; ocho.Enabled = false;
                            encontrar = true; ver(ocho, 3);
                        }
                        break;

                    case 9:
                        if (nueve.Text != "X" & nueve.Text != "O")
                        {
                            nueve.Text = "O"; nueve.Enabled = false;
                            encontrar = true; ver(nueve, 3);
                        }
                        break;




                    default: numero = 0; break;
                }
                if (contador == timer) { encontrar = true; MessageBox.Show("Empate"); }
            }
            encontrar = false;
        }

         void intermadeMode(int num)
        {

            bool comprobation = false;
            

            if (hard == false)
            {
                if (k1 == 1 || k3 == 1 || k7 == 1 || k9 == 1) { cinco.Text = "O"; cinco.Enabled = false; ver(cinco, 3); }
                else { hard = true; second = true; }
                hard = true;
            }
            

            if (hard == true & second == true) { 

            if (contador == num) { MessageBox.Show("Empate"); comprobation = true; }

            if (comprobationIntermade(k2, k3, k1) || comprobationIntermade(k4, k7, k1) || comprobationIntermade(k5, k9, k1))
            {
                uno.Text = "O"; uno.Enabled = false; ver(uno, 3); comprobation = true;
            }

            else if (comprobationIntermade(k1, k3, k2) || comprobationIntermade(k5, k8, k2))
            {
                dos.Text = "O"; dos.Enabled = false; ver(dos, 3); comprobation = true;
            }

            else if (comprobationIntermade(k1, k2, k3) || comprobationIntermade(k6, k9, k3) || comprobationIntermade(k5, k7, k3))
            {
                tres.Text = "O"; tres.Enabled = false; ver(tres, 3); comprobation = true;
            }

            else if (comprobationIntermade(k1, k7, k4) || comprobationIntermade(k5, k6, k4))
            {
                cuatro.Text = "O"; cuatro.Enabled = false; ver(cuatro, 3); comprobation = true;
            }

            else if (comprobationIntermade(k4, k6, k5) || comprobationIntermade(k2, k8, k5) || comprobationIntermade(k3, k7, k5) || comprobationIntermade(k1, k9, k5))
            {
                cinco.Text = "O"; cinco.Enabled = false; ver(cinco, 3); comprobation = true;
            }

            else if (comprobationIntermade(k3, k9, k6) || comprobationIntermade(k4, k5, k6))
            {
                seis.Text = "O"; seis.Enabled = false; ver(seis, 3); comprobation = true;
            }

            else if (comprobationIntermade(k1, k4, k7) || comprobationIntermade(k8, k9, k7) || comprobationIntermade(k5, k3, k7))
            {
                siete.Text = "O"; siete.Enabled = false; ver(siete, 3); comprobation = true;
            }

            else if (comprobationIntermade(k7, k9, k8) || comprobationIntermade(k5, k2, k8))
            {
                ocho.Text = "O"; ocho.Enabled = false; ver(ocho, 3); comprobation = true;
            }

            else if (comprobationIntermade(k7, k8, k9) || comprobationIntermade(k1, k5, k9) || comprobationIntermade(k3, k6, k9))
            {
                nueve.Text = "O"; nueve.Enabled = false; ver(nueve, 3); comprobation = true;
            }

            

            if (comprobation == false)
            {
                easyMode(10);
            }
            
            comprobation = false;
            }
            second = true;
           
        }

        bool comprobationIntermade(int num1, int num2, int num3)
        {
            if (num1 + num2 == 2 & num3 == 2)
            {
                return true;
            }

            return false;
        }

        bool comprobationHard(int num1, int num2, int num3)
        {
            if (num1 + num2 == 6 & num3 == 2)
            {
                return true;
            }

            return false;
        }

        void hardMode()
        {

            if (second == false)
            {
                if (k3 == 2)
                {
                    k3 = 3; tres.Text = "O"; tres.Enabled = false; hardWinBool = false; second = true;
                }
            }

            else if (second == true & win == false){
                if (checkNormal == false)
                {
                    if (k5 == 1) { normalMode = true; }
                    else { normalMode = false; }
                    checkNormal = true;
                }



                if (normalMode == false & win == false)
                {
                    hardWinDefinitive();

                 if (hardWinBool == false & win == false)
                {
                  hardWin();
                }
                 else if (hardWinBool2 == false & win == false)
                  {
                    hardWin2();

                  }
                                 
                }

                if (normalMode == true & win == false)
                {
                    hardWinDefinitive();

                    if (win == false)
                    {
                        intermadeMode(6);
                    }
                    


                }

            }





            
            
            


        }

        void hardWin()
        {
            if (k1 == 1 || k9 == 1)
            {
                
                siete.Text = "O"; siete.Enabled = false; ver(siete, 3);
                if (k1 == 1)
                {
                    hardWinOpc = 1;
                }
                else if (k9 == 1)
                {
                    hardWinOpc = 9;
                }
            }
            else if (k2 == 1 || k4 == 1 || k7 == 1)
            {
                nueve.Text = "O"; nueve.Enabled = false; ver(nueve, 3);
                if (k2 == 1)
                {
                    hardWinOpc = 2;
                }
                else if (k4 == 1)
                {
                    hardWinOpc = 4;
                }
                else if (k7 == 1)
                {
                    hardWinOpc = 7;
                }
            }

            else if (k6 == 1 || k8 == 1)
            {
                uno.Text = "O"; uno.Enabled = false; ver(uno, 3);
                if (k6 == 1)
                {
                    hardWinOpc = 6;
                }
                else if (k8 == 1)
                {
                    hardWinOpc = 8;
                }
            }
            
            else if (k5 == 1)
            {
                normalMode = true;
            }
                hardWinBool = true;
            
        }

        void hardWin2()
        {
            switch (hardWinOpc)
            {
                case 1: if (conta == 1) {  nueve.Text = "O"; nueve.Enabled = false; ver(nueve, 3); } break;
                case 2: if (conta == 1) { siete.Text = "O"; siete.Enabled = false; ver(siete, 3); } break;
                case 4: if (conta == 1) { cinco.Text = "O"; cinco.Enabled = false; ver(cinco, 3); } break;
                case 6: if (conta == 1) { siete.Text = "O"; siete.Enabled = false; ver(siete, 3); } break;
                case 7: if (conta == 1) { uno.Text = "O"; uno.Enabled = false; ver(uno, 3); } break;
                case 8: if (conta == 1) { cinco.Text = "O"; cinco.Enabled = false; ver(cinco, 3); } break;
                case 9: if (conta == 1) { uno.Text = "O"; uno.Enabled = false; ver(uno, 3); } break;
            }

            hardWinBool2 = true;
        }

        void hardWinDefinitive()
        {
            

            

            if (comprobationHard(k2, k3, k1) || comprobationHard(k4, k7, k1) || comprobationHard(k5, k9, k1))
            {
                uno.Text = "O"; uno.Enabled = false; ver(uno, 3); win = true;
            }

            else if (comprobationHard(k1, k3, k2) || comprobationHard(k5, k8, k2))
            {
                dos.Text = "O"; dos.Enabled = false; ver(dos, 3); win = true;
            }

            else if (comprobationHard(k1, k2, k3) || comprobationHard(k6, k9, k3) || comprobationHard(k5, k7, k3))
            {
                tres.Text = "O"; tres.Enabled = false; ver(tres, 3); win = true;
            }

            else if (comprobationHard(k1, k7, k4) || comprobationHard(k5, k6, k4))
            {
                cuatro.Text = "O"; cuatro.Enabled = false; ver(cuatro, 3); win = true; 
            }

            else if (comprobationHard(k4, k6, k5) || comprobationHard(k2, k8, k5) || comprobationHard(k3, k7, k5) || comprobationHard(k1, k9, k5))
            {
                cinco.Text = "O"; cinco.Enabled = false; ver(cinco, 3); win = true; 
            }

            else if (comprobationHard(k3, k9, k6) || comprobationHard(k4, k5, k6))
            {
                seis.Text = "O"; seis.Enabled = false; ver(seis, 3); win = true;
            }

            else if (comprobationHard(k1, k4, k7) || comprobationHard(k8, k9, k7) || comprobationHard(k5, k3, k7))
            {
                siete.Text = "O"; siete.Enabled = false; ver(siete, 3); win = true;
            }

            else if (comprobationHard(k7, k9, k8) || comprobationHard(k5, k2, k8))
            {
                ocho.Text = "O"; ocho.Enabled = false; ver(ocho, 3); win = true;
            }

            else if (comprobationHard(k7, k8, k9) || comprobationHard(k1, k5, k9) || comprobationHard(k3, k6, k9))
            {
                nueve.Text = "O"; nueve.Enabled = false; ver(nueve, 3); win = true;
            }

        }

        void empate()
        {
            if (k1 != 2 & k2 != 2 & k3 != 2 & k4 != 2 & k5 != 2 & k6 != 2 & k7 != 2 & k8 != 2 & k9 != 2)
            {
                MessageBox.Show("Empate");
            }
        }


    }
}