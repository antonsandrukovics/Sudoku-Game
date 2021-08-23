using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Sudoku.LevelControls
{
    public partial class TopTenResultForm : UserControl
    {
        private DBTopTenResult dbData = new DBTopTenResult();
        public TopTenResultForm()
        {
            InitializeComponent();
            FillingDataGridView(dbData.LoadDataFromDB("easy"));
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
