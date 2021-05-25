using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Sudoku.LevelControls
{
    public partial class TopTenResultForm : UserControl
    {
        private List<string[]> dataFromDB;
        public TopTenResultForm()
        {
            InitializeComponent();
            dataFromDB = DBTopTenResult.LoadDataFromDB("easy");
            FillingDataGridView(dataFromDB);
        }

        private void FillingDataGridView(List<string[]> listWithData)
        {
            foreach (string[] item in listWithData)
            {
                dataGridView1.Rows.Add(item);
            }
        }
    }
}
