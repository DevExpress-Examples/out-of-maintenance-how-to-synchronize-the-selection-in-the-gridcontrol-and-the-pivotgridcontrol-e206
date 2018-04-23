Imports Microsoft.VisualBasic
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
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

		End Sub

		Private Sub OnGridViewFocusedColumnChanged(ByVal sender As Object, ByVal e As FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
			UpdatePivotSelection(pivotGrid, e.FocusedColumn.FieldName, (CType(sender, GridView)).GetFocusedValue())
		End Sub

		Private Shared Sub UpdatePivotSelection(ByVal pivot As PivotGridControl, ByVal fieldName As String, ByVal value As Object)
			Dim field As PivotGridField = pivot.Fields(fieldName)
			If field.Area = PivotArea.DataArea OrElse field.Area = PivotArea.FilterArea Then
				pivot.Cells.Selection = Rectangle.Empty
			End If
			Dim count As Integer
			If field.Area = PivotArea.ColumnArea Then
				count = pivot.Cells.ColumnCount
			Else
				count = pivot.Cells.RowCount
			End If
			Dim range As New List(Of Integer)()
			For i As Integer = 0 To count - 1
				If Comparer.Default.Compare(value, pivot.GetFieldValue(field, i)) = 0 Then
					range.Add(i)
				End If
			Next i
			If range.Count = 0 Then
				Return
			End If
			If field.Area = PivotArea.ColumnArea Then
                pivot.Cells.Selection = New Rectangle(range(0), 0, range.Count, pivot.Cells.RowCount)
            Else
                pivot.Cells.Selection = New Rectangle(0, range(0), pivot.Cells.ColumnCount, range.Count)
			End If
			CType(pivot, IPivotGridViewInfoDataOwner).DataViewInfo.ViewInfo.LeftTopCoord = pivot.Cells.Selection.Location
		End Sub

		Private Sub OnGridViewFocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
			Dim view As GridView = CType(sender, GridView)
			UpdatePivotSelection(pivotGrid, view.FocusedColumn.FieldName, view.GetFocusedValue())
		End Sub
	End Class
End Namespace