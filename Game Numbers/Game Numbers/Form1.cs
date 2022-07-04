using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Numbers
{
    public partial class Form1 : Form

    {
        int buttons = 9;
        int current = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Game Numbers
Put on buttons with numbers 1 - 9","Program");
        }

        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game()
        {
            for (int j = 1; j <= buttons; j++)
                button(j).Text = j.ToString();
            swap_buttons();
            for (int j = 1; j <= buttons * 10; j++)
                swap_buttons();
               
            for (int j = 1; j <= buttons; j++)
                button(j).Visible = true;
            current = 1;
        }

        private void swap_buttons()
        {
            int a = rnd.Next(1, buttons);
            int b = rnd.Next(1, buttons);
            if (a == b) return;
            string text = button(a).Text;
            button(a).Text = button(b).Text;
            button(b).Text = text;
        }

        private Button button(int nr)
        {
            switch (nr)
            {
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                default:
                    return null;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nr = ((Button)sender).Text;
            if (nr == current.ToString())
            {
                ((Button)sender).Visible = false;
                current++;
            }    
        }
    }
}
