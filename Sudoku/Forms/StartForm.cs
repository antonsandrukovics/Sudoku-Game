using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length > 0)
            {
                SudokuPlayForm sudokuPlayForm = new SudokuPlayForm(userNameTextBox.Text);
                sudokuPlayForm.Visible = true; 
            }
            else
            {
                MessageBox.Show("Enter your username");
            }
        }
    }
}
