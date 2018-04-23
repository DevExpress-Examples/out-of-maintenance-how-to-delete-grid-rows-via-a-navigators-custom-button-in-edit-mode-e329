Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New WindowsApplication1.DataSet1()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colBoolProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStringProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCurrentDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colIntProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1BindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
			Me.gridControl1.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() { New DevExpress.XtraEditors.NavigatorCustomButton(7, 7, True, True, "", "CustomEdit")})
			Me.gridControl1.EmbeddedNavigator.Name = ""
'			Me.gridControl1.EmbeddedNavigator.ButtonClick += New DevExpress.XtraEditors.NavigatorButtonClickEventHandler(Me.gridControl1_EmbeddedNavigator_ButtonClick);
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1, Me.repositoryItemCheckEdit1, Me.repositoryItemTimeEdit1, Me.repositoryItemDateEdit1, Me.repositoryItemComboBox1})
			Me.gridControl1.Size = New System.Drawing.Size(592, 358)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.UseEmbeddedNavigator = True
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataTable1BindingSource
			' 
			Me.dataTable1BindingSource.DataMember = "DataTable1"
			Me.dataTable1BindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colBoolProperty, Me.colStringProperty, Me.colCurrentDate, Me.colIntProperty})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsNavigation.EnterMoveNextColumn = True
			Me.gridView1.OptionsSelection.MultiSelect = True
			' 
			' colBoolProperty
			' 
			Me.colBoolProperty.Caption = "BoolProperty"
			Me.colBoolProperty.FieldName = "BoolProperty"
			Me.colBoolProperty.Name = "colBoolProperty"
			Me.colBoolProperty.Visible = True
			Me.colBoolProperty.VisibleIndex = 0
			' 
			' colStringProperty
			' 
			Me.colStringProperty.Caption = "StringProperty"
			Me.colStringProperty.FieldName = "StringProperty"
			Me.colStringProperty.Name = "colStringProperty"
			Me.colStringProperty.Visible = True
			Me.colStringProperty.VisibleIndex = 1
			' 
			' colCurrentDate
			' 
			Me.colCurrentDate.Caption = "CurrentDate"
			Me.colCurrentDate.FieldName = "CurrentDate"
			Me.colCurrentDate.Name = "colCurrentDate"
			Me.colCurrentDate.Visible = True
			Me.colCurrentDate.VisibleIndex = 2
			' 
			' colIntProperty
			' 
			Me.colIntProperty.Caption = "IntProperty"
			Me.colIntProperty.ColumnEdit = Me.repositoryItemComboBox1
			Me.colIntProperty.FieldName = "IntProperty"
			Me.colIntProperty.Name = "colIntProperty"
			Me.colIntProperty.Visible = True
			Me.colIntProperty.VisibleIndex = 3
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "1", "2", "3", "4", "5"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			' 
			' repositoryItemTimeEdit1
			' 
			Me.repositoryItemTimeEdit1.AutoHeight = False
			Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			Me.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(592, 358)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private dataSet11 As DataSet1
		Private dataTable1BindingSource As System.Windows.Forms.BindingSource
		Private repositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private colBoolProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private colStringProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private colCurrentDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colIntProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	End Class
End Namespace

