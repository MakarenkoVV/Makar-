using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_лаба2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Январь", "Февраль", "март", "Апрель",
                "Май", "Июнь", "Июль", "Август", "Сентябрь",
                "Октябрь", "Ноябрь", "Декабрь" });

            comboBox2.Items.AddRange(new string[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026",
                "2027", "2028", "2029", "2030" });
            this.Text = "Доступ к карте";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Январь", "Февраль", "март", "Апрель", 
                "Май", "Июнь", "Июль", "Август", "Сентябрь", 
                "Октябрь", "Ноябрь", "Декабрь" });
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(new string[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026", 
                "2027", "2028", "2029", "2030" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                if(comboBox1.Text != "" && comboBox2.Text != "")
                {
                    Person per = new Person();
                    per.Name = textBox1.Text;
                    per.Month = comboBox1.Text;
                    per.Year = Convert.ToInt32(comboBox2.Text);
                    per.Number = Convert.ToInt32(textBox2.Text);
                    MessageBox.Show($"Имя: {textBox1.Text}\nМесяц: {comboBox1.Text}\nГод: {comboBox2.Text}\nНомер карты: {textBox2.Text}");
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
