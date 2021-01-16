using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public void Main(string[] args)
        {
            

        }
        public Form2()
        {

            InitializeComponent();
            textBox1.Select();//фокусирование курсора
            comboBox1.Items.Add("Дифференцированный");
            comboBox1.Items.Add("Аннуитетный");
            comboBox1.SelectedIndex = (0); // значение по умолчанию
            comboBox2.Items.Add("Лет");
            comboBox2.Items.Add("Месяцев");
            comboBox2.SelectedIndex = (1);
            comboBox3.Items.Add("EUR");
            comboBox3.Items.Add("RUB");
            comboBox3.Items.Add("USD");
            comboBox3.SelectedIndex = (1);
            textBox2.MaxLength = 2; 
            textBox1.MaxLength = 7;



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.Value.ToString("MMM");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = decimal.Parse(textBox1.Text).ToString("### ### ### ###");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {
                    }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58 )
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {


            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58 )
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            textBox1.Text = "1";
            textBox2.Text = "1";
            
        }
    }
}
