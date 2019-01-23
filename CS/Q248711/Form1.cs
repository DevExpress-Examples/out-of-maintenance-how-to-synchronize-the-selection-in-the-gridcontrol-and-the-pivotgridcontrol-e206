using System;
using System.Drawing;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Q248711 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            gridView1.FocusedRowChanged += OnGridViewFocusedRowChanged;
            gridView1.FocusedColumnChanged += OnGridViewFocusedColumnChanged;
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

        }

        private void OnGridViewFocusedColumnChanged(object sender, FocusedColumnChangedEventArgs e) {
            UpdatePivotSelection(pivotGrid, e.FocusedColumn.FieldName, ((GridView)sender).GetFocusedValue());
        }

        private static void UpdatePivotSelection(PivotGridControl pivot, string fieldName, object value) {
            PivotGridField field = pivot.Fields[fieldName];
            if (field.Area == PivotArea.DataArea || field.Area == PivotArea.FilterArea) 
                pivot.Cells.Selection = Rectangle.Empty;
            int count = field.Area == PivotArea.ColumnArea ? pivot.Cells.ColumnCount : pivot.Cells.RowCount;
            List<int> range = new List<int>();
            for (int i = 0; i < count; i++)
                if (Comparer.Default.Compare(value, pivot.GetFieldValue(field, i)) == 0) range.Add(i);
            if (range.Count == 0) return;
            pivot.Cells.Selection = field.Area == PivotArea.ColumnArea ? 
                new Rectangle(range[0], 0, range.Count, pivot.Cells.RowCount) :
                new Rectangle(0, range[0], pivot.Cells.ColumnCount, range.Count);
            ((IPivotGridViewInfoDataOwner)pivot).DataViewInfo.ViewInfo.LeftTopCoord =
                pivot.Cells.Selection.Location;
        }

        private void OnGridViewFocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            GridView view = (GridView)sender;
            UpdatePivotSelection(pivotGrid, view.FocusedColumn.FieldName, view.GetFocusedValue());
        }
    }
}