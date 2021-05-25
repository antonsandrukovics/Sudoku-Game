using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuPlayForm : Form
    {
        public static string playerName;
        public SudokuPlayForm(string name)
        {
            InitializeComponent();
            rulesForm1.BringToFront();
            label1.Text = "Rules";
            playerName = name;
            label2.Text = $"Hello, {name}!";

        }        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playSudokuButton_Click(object sender, EventArgs e)
        {
            hardSudoku1.BringToFront();
            label1.Text = "Play sudoku";
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            rulesForm1.BringToFront();
            label1.Text = "Rules";
        }

        private void topTenButton_Click(object sender, EventArgs e)
        {
            topTenResultForm1.BringToFront();
            label1.Text = "Top 10 result";
        }
    }
}
