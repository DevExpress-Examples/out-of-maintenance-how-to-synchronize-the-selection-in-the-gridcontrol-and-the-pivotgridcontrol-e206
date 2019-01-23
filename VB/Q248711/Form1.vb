Imports System
Imports System.Drawing
Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace Q248711
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler gridView1.FocusedRowChanged, AddressOf OnGridViewFocusedRowChanged
			AddHandler gridView1.FocusedColumnChanged, AddressOf OnGridViewFocusedColumnChanged
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

		End Sub

		Private Sub OnGridViewFocusedColumnChanged(ByVal sender As Object, ByVal e As FocusedColumnChangedEventArgs)
			UpdatePivotSelection(pivotGrid, e.FocusedColumn.FieldName, DirectCast(sender, GridView).GetFocusedValue())
		End Sub

		Private Shared Sub UpdatePivotSelection(ByVal pivot As PivotGridControl, ByVal fieldName As String, ByVal value As Object)
			Dim field As PivotGridField = pivot.Fields(fieldName)
			If field.Area = PivotArea.DataArea OrElse field.Area = PivotArea.FilterArea Then
				pivot.Cells.Selection = Rectangle.Empty
			End If
			Dim count As Integer = If(field.Area = PivotArea.ColumnArea, pivot.Cells.ColumnCount, pivot.Cells.RowCount)
			Dim range As New List(Of Integer)()
			For i As Integer = 0 To count - 1
				If Comparer.Default.Compare(value, pivot.GetFieldValue(field, i)) = 0 Then
					range.Add(i)
				End If
			Next i
			If range.Count = 0 Then
				Return
			End If
			pivot.Cells.Selection = If(field.Area = PivotArea.ColumnArea, New Rectangle(range(0), 0, range.Count, pivot.Cells.RowCount), New Rectangle(0, range(0), pivot.Cells.ColumnCount, range.Count))
			DirectCast(pivot, IPivotGridViewInfoDataOwner).DataViewInfo.ViewInfo.LeftTopCoord = pivot.Cells.Selection.Location
		End Sub

		Private Sub OnGridViewFocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs)
			Dim view As GridView = DirectCast(sender, GridView)
			UpdatePivotSelection(pivotGrid, view.FocusedColumn.FieldName, view.GetFocusedValue())
		End Sub
	End Class
End Namespace