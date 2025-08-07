Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid

Public Class Form1
    Public Sub New()
        InitializeComponent()

        Me.GridControl1.RowCount = 10
        Me.GridControl1.ColCount = 6

        ' Set the backcolor for a particular cell
        Me.GridControl1(2, 3).BackColor = Color.Red

        ' Set the backcolor using Interior property
        Me.GridControl1(3, 2).Interior = New BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue)
        Me.GridControl1(4, 2).Interior = New BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White)

        ' Set the backcolor for a range of cells
        Dim style As New GridStyleInfo()
        style.BackColor = Color.Aquamarine
        Me.GridControl1.ChangeCells(GridRangeInfo.Cells(4, 4, 5, 5), style)

        ' Attach the QueryCellInfo event
        AddHandler Me.GridControl1.QueryCellInfo, AddressOf OnQueryCellInfo
    End Sub

    Private Sub OnQueryCellInfo(sender As Object, e As GridQueryCellInfoEventArgs)
        ' Set the backcolor for a particular cell
        If e.RowIndex = 2 AndAlso e.ColIndex = 3 Then
            e.Style.BackColor = Color.Red
        End If

        ' Set the backcolor using Interior property
        If e.RowIndex = 3 AndAlso e.ColIndex = 2 Then
            e.Style.Interior = New BrushInfo(GradientStyle.Horizontal, Color.Yellow, Color.Blue)
        End If

        If e.RowIndex = 4 AndAlso e.ColIndex = 2 Then
            e.Style.Interior = New BrushInfo(PatternStyle.DashedHorizontal, Color.Black, Color.White)
        End If

        ' Set the backcolor for a range of cells
        If (e.RowIndex = 4 OrElse e.RowIndex = 5) AndAlso (e.ColIndex = 4 OrElse e.ColIndex = 5) Then
            e.Style.BackColor = Color.Aquamarine
        End If
    End Sub

End Class