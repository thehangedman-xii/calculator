using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {


            InitializeComponent();
            textBox1.ReadOnly = true; // только для чтения. Запрет ввода
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        Form2 f2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            f2.ShowDialog();

            this.textBox1.Text = f2.textBox1.Text;
            this.textBox2.Text = f2.dateTimePicker1.Text;
            this.textBox3.Text = f2.textBox2.Text;
            int chis = Convert.ToInt16(f2.textBox2.Text);
            string mes = "";
            if (f2.comboBox2.Text == "Месяцев")
            {
                switch (chis) // подбор падежей
                {
                    case 1: case 21: case 31: case 41:
                    case 51: case 61: case 71: case 81:
                    case 91:
                        mes = "Месяц";
                        break;
                    case 2: case 3: case 4: case 22:
                    case 23: case 24: case 32: case 33:
                    case 34: case 42: case 43: case 44:
                    case 52: case 53: case 54: case 62:
                    case 63: case 64: case 72: case 73:
                    case 74: case 82: case 83: case 84:
                    case 92: case 93: case 94:
                        mes = "Месяца";
                        break;
                    default:
                        mes = "Месяцев";
                        break;
                }
            }
            else if (f2.comboBox2.Text == "Лет")
            {
                switch (chis) // подбор падежей
                {
                    case 1: case 21: case 31: case 41:
                    case 51: case 61: case 71: case 81:
                    case 91:
                        mes = "Год";
                        break;
                    case 2: case 3: case 4: case 22:
                    case 23: case 24: case 32: case 33:
                    case 34: case 42: case 43: case 44:
                    case 52: case 53: case 54: case 62:
                    case 63: case 64: case 72: case 73:
                    case 74: case 82: case 83: case 84:
                    case 92: case 93: case 94:
                        mes = "Года";
                        break;
                    default:
                        mes = "Лет";
                        break;
                }
            }
            textBox7.Text = mes;
            this.textBox4.Text = f2.comboBox1.Text;
            this.textBox5.Text = f2.comboBox3.Text;

            int sum = Convert.ToInt32(textBox1.Text);
            var vid = textBox4.Text;
            int num = Convert.ToInt32(textBox3.Text);
            string valut = textBox5.Text;
            if (vid == "Аннуитетный")
            {
                Ann();
            }
            else if (vid == "Дифференцированный")
            {
                Diff();
            }
            if (f2.textBox1.Text == "1")
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();
                textBox6.Clear();
            }

            f2.textBox1.Clear();
            f2.textBox2.Clear();

        }

        private void Rodit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void Ann()
        {

            int sum = Convert.ToInt32(textBox1.Text);
            int num = Convert.ToInt32(textBox3.Text);
            if (textBox7.Text == "Лет" || textBox7.Text == "Год" || textBox7.Text == "Года")
            {
                num *= 12;
            }
            double P = 0;
            if (textBox5.Text == "RUB") // определение фиксир. процента
            {
                P = 0.12;
            }
            else if (textBox5.Text == "USD")
            {
                P = 0.05;
            }
            else if (textBox5.Text == "EUR")
            {
                P = 0.04;
            }
            string valut = textBox5.Text;

            double g = Math.Pow(1 + P / 12, num);
            double k = (P / 12) * g / (g - 1);
            double a = k * sum;
            a = Math.Round(a, 0);
            textBox6.Text = "Ежемесячная выплата аннуитетного платежа составляет " + a + " " + valut;

        }

        public void Diff()
        {

            int sum = Convert.ToInt32(textBox1.Text);
            int num = Convert.ToInt32(textBox3.Text);
            if (textBox7.Text == "Лет"|| textBox7.Text == "Год"||textBox7.Text == "Года")
            {
                num *= 12;
            }
            double P = 0;
            if (textBox5.Text == "RUB")
            {
                P = 0.12;
            }
            else if (textBox5.Text == "USD")
            {
                P = 0.05;
            }
            else if (textBox5.Text == "EUR")
            {
                P = 0.04;
            }
            string valut = textBox5.Text;
            string temp = " ";
            string month = " ";
            string data = f2.dateTimePicker1.Value.ToString("MM");
            double y = P / 12; //P
            double sost = sum; // Summa ostatka
            double sosn = sum / num;//Summa osnovnaya
            double sproz, x = 0;
            for (int i = 1; i <= num; i++)
            {
                switch (data) // Определение названия месяца
                {
                    case "01":
                        month = "Январь";
                        data = "02";
                        break;
                    case "02":
                        month = "Февраль";
                        data = "03";
                        break;
                    case "03":
                        month = "Март";
                        data = "04";
                        break;
                    case "04":
                        month = "Апрель";
                        data = "05";
                        break;
                    case "06":
                        month = "Июнь";
                        data = "07";
                        break;
                    case "05":
                        month = "Май";
                        data = "06";
                        break;
                    case "07":
                        month = "Июль";
                        data = "08";
                        break;
                    case "08":
                        month = "Август";
                        data = "09";
                        break;
                    case "09":
                        month = "Сентябрь";
                        data = "10";
                        break;
                    case "10":
                        month = "Октябрь";
                        data = "11";
                        break;
                    case "11":
                        month = "Ноябрь";
                        data = "12";
                        break;
                    case "12":
                        month = "Декабрь";
                        data = "01";
                        break;
                }
                temp = textBox6.Text;
                sproz = sost * y;
                x = sosn + sproz; // tekushaya vyplata
                sost = sost - sosn;
                x = Math.Round(x, 2); //okrugleniye
                textBox6.Text = temp +"В месяце №" + i +" ("+month+") "+ " выплата по кредиту составляет " + x + " "+ valut+Environment.NewLine;
                

            }
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 0;
             if (sfd.ShowDialog() == DialogResult.OK)
             File.WriteAllText(sfd.FileName, textBox6.Text);
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox6.Clear();


    }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
