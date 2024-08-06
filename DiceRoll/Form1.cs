using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();

        private Bitmap dice1;
        private Bitmap dice2;
        private Bitmap dice3;
        private Bitmap dice4;
        private Bitmap dice5;
        private Bitmap dice6;

        public Form1()
        {
            InitializeComponent();

            // PNGファイルの読み込み
            dice1 = new Bitmap("saikoro_1.png");
            dice2 = new Bitmap("saikoro_2.png");
            dice3 = new Bitmap("saikoro_3.png");
            dice4 = new Bitmap("saikoro_4.png");
            dice5 = new Bitmap("saikoro_5.png");
            dice6 = new Bitmap("saikoro_6.png");

            // ダブルバッファリングを有効にする
            this.DoubleBuffered = true;
        }


        private void btnRoll_Click(object sender, EventArgs e)
        {
            // サイコロの目をランダムに生成 (1から6の目)
            int diceValue = _random.Next(1, 7);

            // サイコロの画像を設定
            switch (diceValue)
            {
                case 1:
                    picDice.Image = dice1; 
                    break;
                case 2:
                    picDice.Image = dice2; 
                    break;
                case 3:
                    picDice.Image = dice3; 
                    break;
                case 4:
                    picDice.Image = dice4; 
                    break;
                case 5:
                    picDice.Image = dice5; 
                    break;
                case 6:
                    picDice.Image = dice6; 
                    break;
            }

            // サイコロ2の設定

            int diceValue2 = _random.Next(1, 7);

            switch (diceValue2)
            {
                case 1:
                    picDice2.Image = dice1;
                    break;
                case 2:
                    picDice2.Image = dice2;
                    break;
                case 3:
                    picDice2.Image = dice3;
                    break;
                case 4:
                    picDice2.Image = dice4;
                    break;
                case 5:
                    picDice2.Image = dice5;
                    break;
                case 6:
                    picDice2.Image = dice6;
                    break;
            }

            // サイコロ3の設定

            int diceValue3 = _random.Next(1, 7);

            // サイコロの画像を設定
            switch (diceValue3)
            {
                case 1:
                    picDice3.Image = dice1;
                    break;
                case 2:
                    picDice3.Image = dice2;
                    break;
                case 3:
                    picDice3.Image = dice3;
                    break;
                case 4:
                    picDice3.Image = dice4;
                    break;
                case 5:
                    picDice3.Image = dice5;
                    break;
                case 6:
                    picDice3.Image = dice6;
                    break;
            }


        }

    }
}
