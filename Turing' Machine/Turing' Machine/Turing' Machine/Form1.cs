using System;
using System.Windows.Forms;

namespace Turing__Machine
{
    public partial class MainMenu : Form
    {
        public string[] cells = new string[202];

        // Инициализация интерфейса
        public MainMenu()
        {
            InitializeComponent();
            TaskText.Text = "Алфавит А = {x, y, 5, 2}. Определить, является ли слово Р индентификатором (непустым словом, начинающимя с буквы).\nОтвет: слова y (да) или слова n (нет)";
        }

        // Инициализация массива из начальных параметров (-5...0...+5)
        public void cellsInit(int shift)
        {
            int index = Convert.ToInt32(position6.Text);

            // Смещение значений в label
            position1.Text = Convert.ToString(index + shift - 5);
            position2.Text = Convert.ToString(index + shift - 4);
            position3.Text = Convert.ToString(index + shift - 3);
            position4.Text = Convert.ToString(index + shift - 2);
            position5.Text = Convert.ToString(index + shift - 1);
            position6.Text = Convert.ToString(index + shift);
            position7.Text = Convert.ToString(index + shift + 1);
            position8.Text = Convert.ToString(index + shift + 2);
            position9.Text = Convert.ToString(index + shift + 3);
            position10.Text = Convert.ToString(index + shift + 4);
            position11.Text = Convert.ToString(index + shift + 5);

            // Обновление массива
            cells[index - shift + 94] = cell1.Text;
            cells[index - shift + 95] = cell2.Text;
            cells[index - shift + 96] = cell3.Text;
            cells[index - shift + 97] = cell4.Text;
            cells[index - shift + 98] = cell5.Text;
            cells[index - shift + 99] = cell6.Text;
            cells[index - shift + 100] = cell7.Text;
            cells[index - shift + 101] = cell8.Text;
            cells[index - shift + 102] = cell9.Text;
            cells[index - shift + 103] = cell10.Text;
            cells[index - shift + 104] = cell11.Text;

            // Смещение значений в комбобоксах
            cell1.Text = (cells[index + 94] == "" ? null : cells[index + 94]);
            cell2.Text = (cells[index + 95] == "" ? null : cells[index + 95]);
            cell3.Text = (cells[index + 96] == "" ? null : cells[index + 96]);
            cell4.Text = (cells[index + 97] == "" ? null : cells[index + 97]);
            cell5.Text = (cells[index + 98] == "" ? null : cells[index + 98]);
            cell6.Text = (cells[index + 99] == "" ? null : cells[index + 99]);
            cell7.Text = (cells[index + 100] == "" ? null : cells[index + 100]);
            cell8.Text = (cells[index + 101] == "" ? null : cells[index + 101]);
            cell9.Text = (cells[index + 102] == "" ? null : cells[index + 102]);
            cell10.Text = (cells[index + 103] == "" ? null : cells[index + 103]);
            cell11.Text = (cells[index + 104] == "" ? null : cells[index + 104]);
        }

        // Сместить указатель влево
        private void MoveToLeft_Click(object sender, EventArgs e)
        {
            if (position1.Text == "-100")
            {
                MessageBox.Show("Вы достигли левого края ленты. Сместить указатель влево невозможно",
                    "Смещение указателя влево", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cellsInit(-1);
        }

        // Сместить указатель вправо
        private void MoveToRight_Click(object sender, EventArgs e)
        {
            if (position11.Text == "100")
            {
                MessageBox.Show("Вы достигли правого края ленты. Сместить указатель вправо невозможно", 
                    "Смещение указателя вправо", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cellsInit(1);
        }

        // Запуск машины Тьюринга
        private void StartAlgorithm_Click(object sender, EventArgs e)
        {
            ansver.Text = "";
            cellsInit(0);

            TuringMachine machine = new TuringMachine();
            machine.Status1();
        }

        // Сброс начальных параметров
        private void ResetParams_Click(object sender, EventArgs e)
        {
            // Сброс значений в label's
            position1.Text = "-5";
            position2.Text = "-4";
            position3.Text = "-3";
            position4.Text = "-2";
            position5.Text = "-1";
            position6.Text = "0";
            position7.Text = "1";
            position8.Text = "2";
            position9.Text = "3";
            position10.Text = "4";
            position11.Text = "5";

            // Сброс значений в комбобоксах
            cell1.Text = null;
            cell2.Text = null;
            cell3.Text = null;
            cell4.Text = null;
            cell5.Text = null;
            cell6.Text = null;
            cell7.Text = null;
            cell8.Text = null;
            cell9.Text = null;
            cell10.Text = null;
            cell11.Text = null;

            // Перегенерация массива
            cells = new string[202];
            ansver.Text = "";
        }
    }
}
