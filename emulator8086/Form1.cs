using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace emulator8086
{
    public partial class Form1 : Form
    {
        int[] Zmienne = new int[8];
        string[,] Podzial = new string[4, 2];
        static bool OnlyHexInString(string test)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public void Update_Display()
        {
            AL.Text = Convert.ToString(Zmienne[0], 16).ToUpper();
            AH.Text = Convert.ToString(Zmienne[1], 16).ToUpper();

            BL.Text = Convert.ToString(Zmienne[2], 16).ToUpper();
            BH.Text = Convert.ToString(Zmienne[3], 16).ToUpper();

            CL.Text = Convert.ToString(Zmienne[4], 16).ToUpper();
            CH.Text = Convert.ToString(Zmienne[5], 16).ToUpper();

            DL.Text = Convert.ToString(Zmienne[6], 16).ToUpper();
            DH.Text = Convert.ToString(Zmienne[7], 16).ToUpper();
            Fill();
            Merge();
        }
        public void Fill()
        {
            if (AL.Text.Length < 2)
                AL.Text = "0" + AL.Text;

            if (AH.Text.Length < 2)
                AH.Text = "0" + AH.Text;

            if (BL.Text.Length < 2)
                BL.Text = "0" + BL.Text;

            if (BH.Text.Length < 2)
                BH.Text = "0" + BH.Text;

            if (CL.Text.Length < 2)
                CL.Text = "0" + CL.Text;

            if (CH.Text.Length < 2)
                CH.Text = "0" + CH.Text;

            if (DL.Text.Length < 2)
                DL.Text = "0" + DL.Text;

            if (DH.Text.Length < 2)
                DH.Text = "0" + DH.Text;
        }
        public void Merge()
        {
            AX.Text = AH.Text + AL.Text;
            BX.Text = BH.Text + BL.Text;
            CX.Text = CH.Text + CL.Text;
            DX.Text = DH.Text + DL.Text;
        }
        public void Update_Variables(int a, string b)
        {
            if (b == "AL")
            {
                Zmienne[0] = a;
            }
            if (b == "AH")
            {
                Zmienne[1] = a;
            }
            if (b == "BL")
            {
                Zmienne[2] = a;
            }
            if (b == "BH")
            {
                Zmienne[3] = a;
            }
            if (b == "CL")
            {
                Zmienne[4] = a;
            }
            if (b == "CH")
            {
                Zmienne[5] = a;
            }
            if (b == "DL")
            {
                Zmienne[6] = a;
            }
            if (b == "DH")
            {
                Zmienne[7] = a;
            }
        }
        public string SixteenToEight(string Sixteen)
        {

            if (Sixteen == "AX")
            {
                return AH.Text + AL.Text;
            }
            if (Sixteen == "BX")
            {
                return BH.Text + BL.Text;
            }
            if (Sixteen == "CX")
            {
                return CH.Text + CL.Text;
            }
            if (Sixteen == "DX")
            {
                return DH.Text + DL.Text;
            }
            else
                return "AX";

        }
        public void Set16Bit(string target, string liczba)
        {
            liczba = new string('0', 4 - liczba.Length) + liczba;
            if (target == "AX")
            {
                Zmienne[0] = Convert.ToInt32(liczba.Remove(0, 2), 16); //Młodszy bajt
                Zmienne[1] = Convert.ToInt32(liczba.Remove(2, 2), 16); //Starszy bajt
            }
            if (target == "BX")
            {
                Zmienne[2] = Convert.ToInt32(liczba.Remove(0, 2), 16); //Młodszy bajt
                Zmienne[3] = Convert.ToInt32(liczba.Remove(2, 2), 16); //Starszy bajt
            }
            if (target == "CX")
            {
                Zmienne[4] = Convert.ToInt32(liczba.Remove(0, 2), 16); //Młodszy bajt
                Zmienne[5] = Convert.ToInt32(liczba.Remove(2, 2), 16); //Starszy bajt
            }
            if (target == "DX")
            {
                Zmienne[6] = Convert.ToInt32(liczba.Remove(0, 2), 16); //Młodszy bajt
                Zmienne[7] = Convert.ToInt32(liczba.Remove(2, 2), 16);//Starszy bajt
            }

        }
        public int Text_To_Int(string tak)
        {
            if (tak == "AL")
            {
                return (0);
            }
            else if (tak == "AH")
            {
                return (1);
            }
            else if (tak == "BL")
            {
                return (2);
            }
            else if (tak == "BH")
            {
                return (3);
            }
            else if (tak == "CL")
            {
                return (4);
            }
            else if (tak == "CH")
            {
                return (5);
            }
            else if (tak == "DL")
            {
                return (6);
            }
            else if (tak == "DH")
            {
                return (7);
            }

            else
                return (0);
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e) //set
        {

            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                if (OnlyHexInString(numericUpDown1.Text))
                {
                    string wybrane = comboBox1.SelectedItem.ToString();
                    if (comboBox1.SelectedIndex > 7)
                    {
                        if (Convert.ToInt32(numericUpDown1.Text, 16) < 65536)
                        {
                            Set16Bit(comboBox1.SelectedItem.ToString(), numericUpDown1.Text);
                            Update_Display();
                        }
                        else
                            MessageBox.Show("Za duza liczba");
                    }
                    else if (comboBox1.SelectedIndex <= 7)
                    {
                        if (Convert.ToInt32(numericUpDown1.Text, 16) < 256)
                        {
                            Update_Variables(Convert.ToInt32(numericUpDown1.Text, 16), wybrane);
                            Update_Display();
                        }
                        else
                            MessageBox.Show("Za duża liczba");
                    }
                }
                else
                    MessageBox.Show("Zły format liczby");
            }
            else
                MessageBox.Show("Proszę wybrać poprawny cel z listy!!!");
        }

        private void button2_Click(object sender, EventArgs e) //MOVE
        {
            if (comboBoxOD.Items.Contains(comboBoxOD.Text) && comboBoxDO.Items.Contains(comboBoxDO.Text))
            {
                if (comboBoxOD.SelectedItem != comboBoxDO.SelectedItem)
                {
                    if (comboBoxOD.SelectedIndex > 7 && comboBoxDO.SelectedIndex > 7)
                    {
                        Set16Bit(comboBoxDO.SelectedItem.ToString(), SixteenToEight(comboBoxOD.SelectedItem.ToString()));
                        Update_Display();
                    }
                    else if (comboBoxOD.SelectedIndex <= 7 && comboBoxDO.SelectedIndex <= 7)
                    {
                        int temp = Zmienne[Text_To_Int(comboBoxDO.SelectedItem.ToString())];
                        Update_Variables(temp, comboBoxOD.SelectedItem.ToString());
                        Update_Display();
                    }
                    else
                        MessageBox.Show("Nie ma możliwosci działania na dwóch różnych formatach!!!");
                }
                else
                    MessageBox.Show("Cele nie mogą być takie same!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e) //EXCH
        {
            if (comboBoxFrom.Items.Contains(comboBoxFrom.Text) && comboBoxTo.Items.Contains(comboBoxTo.Text))
            {
                if (comboBoxFrom.SelectedItem != comboBoxTo.SelectedItem)
                {
                    if (comboBoxFrom.SelectedIndex > 7 && comboBoxTo.SelectedIndex > 7)
                    {
                        string tmp = SixteenToEight(comboBoxTo.SelectedItem.ToString());
                        Set16Bit(comboBoxTo.SelectedItem.ToString(), SixteenToEight(comboBoxFrom.SelectedItem.ToString()));
                        Set16Bit(comboBoxFrom.SelectedItem.ToString(), tmp);
                        Update_Display();
                    }

                    else if (comboBoxFrom.SelectedIndex <= 7 && comboBoxTo.SelectedIndex <= 7)
                    {
                        int temp = Zmienne[Text_To_Int(comboBoxTo.SelectedItem.ToString())];
                        Update_Variables(Zmienne[Text_To_Int(comboBoxFrom.SelectedItem.ToString())], comboBoxTo.SelectedItem.ToString());
                        Update_Variables(temp, comboBoxFrom.SelectedItem.ToString());
                        Update_Display();
                    }
                    else
                        MessageBox.Show("Nie ma możliwości działania na dwóch róznych formatach!!!");
                }
                else
                    MessageBox.Show("Cele nie mogą być takie same!!!");
            }
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int temp;
            for (int i = 0; i < 8; i++)
            {
                temp = rand.Next(0, 256);
                Zmienne[i] = temp;
            }
            Update_Display();
        }

        private void button5_Reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                Zmienne[i] = 0;
            }
            Update_Display();
        }
    }
}

