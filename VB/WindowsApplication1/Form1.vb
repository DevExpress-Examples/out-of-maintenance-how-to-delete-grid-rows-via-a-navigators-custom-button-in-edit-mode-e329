Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Base

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

		End Sub

		Public Sub InitData()
			Dim table As New DataTable()
			table.Columns.Add("BoolProperty", GetType(Boolean))
			table.Columns.Add("StringProperty", GetType(String))
			table.Columns.Add("CurrentDate", GetType(DateTime))
			table.Columns.Add("IntProperty", GetType(Integer))
			For i As Integer = 0 To 10
				table.Rows.Add(New Object() { 0, i, DateTime.Today, i })
			Next i
			gridControl1.DataSource = table
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			InitData()
		End Sub

		Private Sub gridControl1_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs) Handles gridControl1.EmbeddedNavigator.ButtonClick
			Dim gridControl As GridControl = TryCast((TryCast(sender, GridControlNavigator)).NavigatableControl, GridControl)
			Dim view As ColumnView = TryCast(gridControl.FocusedView, ColumnView)
			If e.Button.ButtonType = NavigatorButtonType.Custom AndAlso view IsNot Nothing Then
				view.DeleteSelectedRows()
			End If
		End Sub


	End Class
End Namespace
