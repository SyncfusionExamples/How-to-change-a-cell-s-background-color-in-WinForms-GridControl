# How-to-change-a-cell-s-background-color-in-WinForms-GridControl
​[GridStyleInfo](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Grid.GridStyleInfo.html) ​object has a BackColor property that you can set to select a background color in WinForms GridControl. You can also use the [Interior](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Grid.GridStyleInfo.html#Syncfusion_Windows_Forms_Grid_GridStyleInfo_Interior) property of the cell’s background by setting it to a BrushInfo object to specify the background as a brush.

Similarly, the BackColor of range of cells can be changed using ChangeCells method.

**C#**
```
//set the backcolor for particular cell
this.gridControl1[2, 3].BackColor = Color.Red;
 
// set the backcolor for the cell using interior property
gridControl1[3, 2].Interior = new BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue);
gridControl1[4, 2].Interior = new BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White);
 
//set the backcolor for range of cells
GridStyleInfo style = new GridStyleInfo();
style.BackColor = Color.Aquamarine;
this.gridControl1.ChangeCells(GridRangeInfo.Cells(4,4,5,5),style);
```

**VB**
```
'set the backcolor for particular cell
Me.gridControl1(2, 3).BackColor = Color.Red
 
'set the backcolor for the cell using interior property
gridControl1(3, 2).Interior = New BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue)
gridControl1(4, 2).Interior = New BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White)
 
'set the backcolor for range of cells
Dim style As New GridStyleInfo()
style.BackColor = Color.Aquamarine
Me.gridControl1.ChangeCells(GridRangeInfo.Cells(4,4,5,5),style)
```

**Using QueryCellInfo Event**

QueryCellInfo Event can also be used to set the BackColor of a cell or range of cells.

**C#**
```
void gridControl1_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
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
 if ((e.RowIndex == 4 || e.RowIndex == 5)&&(e.ColIndex == 4 || e.ColIndex == 5))
  e.Style.BackColor = Color.Aquamarine;
}
```

**VB**
```
Private Sub gridControl1_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
 'set the backcolor for particular cell
 If e.RowIndex = 2 AndAlso e.ColIndex = 3 Then
  e.Style.BackColor = Color.Red
 End If
 
 'set the backcolor for the cell using interior property
 If e.RowIndex = 3 AndAlso e.ColIndex = 2 Then
  e.Style.Interior = New BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue)
 End If
 If e.RowIndex = 4 AndAlso e.ColIndex = 2 Then
  e.Style.Interior = New BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White)
 End If
 
 'set the backcolor for range of cells
 If (e.RowIndex = 4 OrElse e.RowIndex = 5) AndAlso (e.ColIndex = 4 OrElse e.ColIndex = 5) Then
  e.Style.BackColor = Color.Aquamarine
  End If
End Sub
```

After applying the properties, the grid cell is shown below,

![Applied backcolor to a specifice cell in a grid](CellBackground.png)
