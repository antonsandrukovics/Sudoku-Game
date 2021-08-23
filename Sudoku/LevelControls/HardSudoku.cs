using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku.LevelControls
{

    public partial class HardSudoku : UserControl
    {
        private int[] arrSudoku;
        private int m, s;
        private SudokuFunctionality sudokuFunctionality = new SudokuFunctionality();
        private DBTopTenResult dbData = new DBTopTenResult();
        public HardSudoku()
        {
            InitializeComponent();
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                GetNullTime();
            }
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                label9.Text = "00";
                label11.Text = "00";
                timer1.Enabled = true;
                int indexLevel = 0;
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    switch (item.ToString())
                    {
                        case "Easy":
                            {
                                indexLevel = 8;
                                break;
                            }
                        case "Medium":
                            {
                                indexLevel = 10;
                                break;
                            }
                        case "Hard":
                            {
                                indexLevel = 14;
                                break;
                            }
                        default:
                            {
                                Exception exception = new Exception();
                                MessageBox.Show(exception.Message);
                                break;
                            }
                    }
                }
                arrSudoku = sudokuFunctionality.CreateFullSudokuTable();
                sudokuFunctionality.SudokuOutPut(arrSudoku, Controls.OfType<TextBox>().ToArray(), indexLevel); 
            }
            else
            {
                MessageBox.Show("Please select a difficulty level");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (sudokuFunctionality.CheckFunction(Controls.OfType<TextBox>().ToArray(), arrSudoku, timer1))
                {
                    string s = getCheckedItemFromCheckedListBox();
                    int time = Convert.ToInt32(label9.Text) * 60 + Convert.ToInt32(label11.Text);
                    dbData.OpenDb(SudokuPlayForm.playerName, time, s);
                    MessageBox.Show("Good!");
                }                
            }
            else
            {
                MessageBox.Show("Choose a level and start playing");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s < 59)
            {
                s++;
                if (s < 10)
                {
                    label11.Text = "0" + s.ToString();
                }
                else
                {
                    label11.Text = s.ToString();
                }
            }
            else
            {
                if (m < 59) 
                {
                    m++;
                    if (m < 10)
                    {
                        label9.Text = "0" + m.ToString(); 
                    }
                    else
                    {
                        label9.Text = m.ToString();
                    }
                    s = 0;
                    label11.Text = "00";
                }
                else
                {
                    m = 0;
                    label9.Text = "00";
                }
                
            }
            TextBox[] textBox = Controls.OfType<TextBox>().ToArray();
            for (int i = 0; i < textBox.Length; i++)
            {
                textBox[i].BackColor = Color.White;
            }
        }
        private string getCheckedItemFromCheckedListBox()
        {
            string itemCheck = "";
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    itemCheck = item.ToString();
                } 
            }
            return itemCheck;
        }
        private void GetNullTime()
        {
            m = 0;
            s = 0;
        }
    }
}
