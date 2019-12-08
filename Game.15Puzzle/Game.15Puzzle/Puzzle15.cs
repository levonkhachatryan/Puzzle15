using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game._15Puzzle
{
    public partial class Puzzle15 : Form
    {
        Game game;
        public Puzzle15()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.Shift(position);
            Refresh();
            if (game.CheckNumbers())
            {
                MessageBox.Show("You Won!");
                StartGame();
            }
        }
        private Button button(int position)
        {
            switch (position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default: return null;
            }
        }

        private void Puzzle15_Load(object sender, EventArgs e)
        {
            StartGame();
        }
        private void menuPlay_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            game.start();
            for (int i = 0; i < 100; i++)
            {
                game.ShiftRandom();
            }
            Refresh();
            if (game.CheckNumbers())
            {
                MessageBox.Show("You Won!");
                StartGame();
            }
        }

        private void Refresh()
        {
            for (int position = 0; position < 16; position++)
            {
                button(position).Text = game.GetNumber(position).ToString();
                button(position).Visible = (game.GetNumber(position) > 0);
            }
        }

    }
}
