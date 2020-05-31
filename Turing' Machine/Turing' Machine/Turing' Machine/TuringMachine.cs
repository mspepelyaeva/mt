using System;
using System.Collections.Generic;

namespace Turing__Machine
{
    class TuringMachine
    {
        private protected static MainMenu menu = Program.menu; 

        // Алфавит
        public static List<char> Alphabet = new List<char>() { 'x', 'y', 'X', 'Y', '5', '2' };     

        // Статус 1
        public void Status1()
        {
            if (menu.cell6.Text == "x" || menu.cell6.Text == "y")
            {
                Status2();
            }
            else
            {
                Status3();
            }
        }

        // Статус 2
        public void Status2()
        {
            MoveToRight();
            if (menu.cell6.Text == "")
            {
                Status4();
            }
            else
            {
                Status2();
            }
        }

        // Статус 3
        public void Status3()
        {
            MoveToRight();
            if (menu.cell6.Text == "")
            {
                Status5();
            }
            else
            {
                Status3();
            }
        }

        // Статус 4
        public void Status4()
        {
            MoveToLeft();
            if (menu.cell6.Text == "")
            {
                menu.ansver.Text = "y";
            }
            else
            {
                Status4();
            }
        }

        // Статус 5
        public void Status5()
        {
            MoveToLeft();
            if (menu.cell6.Text == "")
            {
                menu.ansver.Text = "n";
            }
            else
            {
                Status5();
            }
        }

        // Смещение влево
        public void MoveToLeft()
        {
            menu.cell6.Text = "";
            menu.cells[Convert.ToInt32(menu.position6.Text) + 101] = "";

            // Смещение значений в label
            menu.cellsInit(-1);

            // Обновлени интерфейса
            menu.Refresh();

            // Пауза 1 секунда
            System.Threading.Thread.Sleep(1000);
        }

        // Смещение вправо
        public void MoveToRight()
        {
            // Смещение значений
            menu.cellsInit(1);

            // Обновлени интерфейса
            menu.Refresh();

            // Пауза 1 секунда
            System.Threading.Thread.Sleep(1000);
        }
    }
}
