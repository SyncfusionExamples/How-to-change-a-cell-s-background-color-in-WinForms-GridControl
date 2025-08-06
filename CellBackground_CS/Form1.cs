using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using System.Drawing;
using System.Windows.Forms;

namespace CellBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridControl1.RowCount = 10;
            gridControl1.ColCount = 6;
            //set the backcolor for particular cell
            this.gridControl1[2, 3].BackColor = Color.Red;

            // set the backcolor for the cell using interior property
            gridControl1[3, 2].Interior = new BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue);
            gridControl1[4, 2].Interior = new BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White);

            //set the backcolor for range of cells
            GridStyleInfo style = new GridStyleInfo();
            style.BackColor = Color.Aquamarine;
            this.gridControl1.ChangeCells(GridRangeInfo.Cells(4, 4, 5, 5), style);

            gridControl1.QueryCellInfo += OnQueryCellInfo;
        }

        private void OnQueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            //set the backcolor for particular cell
            if (e.RowIndex == 2 && e.ColIndex == 3)
                e.Style.BackColor = Color.Red;

            // set the backcolor for the cell using interior property
            if (e.RowIndex == 3 && e.ColIndex == 2)
                e.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue);
            if (e.RowIndex == 4 && e.ColIndex == 2)
                e.Style.Interior = new BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White);

            //set the backcolor for range of cells
            if ((e.RowIndex == 4 || e.RowIndex == 5) && (e.ColIndex == 4 || e.ColIndex == 5))
                e.Style.BackColor = Color.Aquamarine;
        }
    }
}