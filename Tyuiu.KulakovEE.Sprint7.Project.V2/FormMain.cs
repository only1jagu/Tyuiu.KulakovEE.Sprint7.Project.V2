using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KulakovEE.Sprint7.Project.V2.Lib;


namespace Tyuiu.KulakovEE.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string login = textBox1_KEElog.Text;
            string password = textBox2_KEEpass.Text;

            if (CheckCredentials(login, password))
            {
                // Если логин и пароль верные
                MessageBox.Show("Авторизация успешна!");
                // Дополнительный код, который нужно выполнить после успешной авторизации
                this.Hide();
                FormWork formWork = new FormWork();
                formWork.ShowDialog();
                this.Show();
                this.Close();
            }
            else
            {
                // Если логин и/или пароль неверные
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private bool CheckCredentials(string login, string password)
        {
            {

                // Здесь можно добавить свою логику проверки логина и пароля
                // Например, сравнение с хэшированными значениями в базе данных или сравнение с жёстко заданными значениями

                // Пример проверки на жёстко заданный логин и пароль:
                if (login == "SpirinIS" && password == "admin.tyuiu")
                {
                    return true;
                }

                return false;

            }
        }

       

        private void toolStripMenuItemExit_KEE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemAbout_KEE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemInstruction_KEE_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void техПоддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpDevWin formHelpDevWin = new FormHelpDevWin();
            formHelpDevWin.ShowDialog();
        }

        private void toolStripMenuItemInfo_KEE_Click(object sender, EventArgs e)
        {

        }

        private void labelMain_KEE_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                FormHelpDevWin formHelpDevWin = new FormHelpDevWin();
                formHelpDevWin.ShowDialog();
            
        }
    }

    
}




