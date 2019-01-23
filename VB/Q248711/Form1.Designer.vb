Namespace Q248711
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Q248711.nwindDataSet()
			Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colExtendedPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSalesPerson = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.salesPersonTableAdapter = New Q248711.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			DirectCast(Me.pivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGrid
			' 
			Me.pivotGrid.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGrid.DataSource = Me.salesPersonBindingSource
			Me.pivotGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldExtendedPrice, Me.fieldSalesPerson})
			Me.pivotGrid.Location = New System.Drawing.Point(0, 0)
			Me.pivotGrid.Name = "pivotGrid"
			Me.pivotGrid.OptionsCustomization.AllowFilter = False
			Me.pivotGrid.Size = New System.Drawing.Size(937, 301)
			Me.pivotGrid.TabIndex = 0
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 0
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSalesPerson.AreaIndex = 0
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.salesPersonBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(937, 289)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryName, Me.colExtendedPrice, Me.colSalesPerson})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 0
			' 
			' colExtendedPrice
			' 
			Me.colExtendedPrice.FieldName = "Extended Price"
			Me.colExtendedPrice.Name = "colExtendedPrice"
			Me.colExtendedPrice.OptionsColumn.ReadOnly = True
			Me.colExtendedPrice.Visible = True
			Me.colExtendedPrice.VisibleIndex = 1
			' 
			' colSalesPerson
			' 
			Me.colSalesPerson.FieldName = "Sales Person"
			Me.colSalesPerson.Name = "colSalesPerson"
			Me.colSalesPerson.OptionsColumn.ReadOnly = True
			Me.colSalesPerson.Visible = True
			Me.colSalesPerson.VisibleIndex = 2
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Horizontal = False
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGrid)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(937, 594)
			Me.splitContainerControl1.SplitterPosition = 301
			Me.splitContainerControl1.TabIndex = 2
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(937, 594)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As Q248711.nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colExtendedPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colSalesPerson As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

