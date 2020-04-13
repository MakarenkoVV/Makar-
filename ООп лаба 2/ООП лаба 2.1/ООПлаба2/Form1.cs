using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООПлаба2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Регистрация";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if(textBox3.Text.Length > 6)
                {
                    if(checkBox1.Checked == true)
                    {
                        User objUser = new User();
                        objUser.Name = textBox1.Text;
                        objUser.Login = textBox2.Text;
                        objUser.Password = textBox3.Text;
                        MessageBox.Show($"Имя: {textBox1.Text} \n Логин: {textBox2.Text} \n Пароль: {textBox3.Text}");
                    }
                    else
                    {
                        MessageBox.Show("Подтвердите согласие с пользовательским соглашением");
                    }
                }
                else
                {
                    MessageBox.Show("Пароль недостаточной длины");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
