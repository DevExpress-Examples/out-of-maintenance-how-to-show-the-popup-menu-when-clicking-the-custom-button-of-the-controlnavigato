Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Reflection
Imports DevExpress.XtraEditors.ViewInfo

Namespace Q143749
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub controlNavigator1_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs) Handles controlNavigator1.ButtonClick
			Dim navigator As ControlNavigator = DirectCast(sender, ControlNavigator)
			If e.Button Is navigator.Buttons.CustomButtons(0) Then
				Dim fi As FieldInfo = GetType(NavigatorButtonsBase).GetField("viewInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
				Dim buttonsViewInfo As NavigatorButtonsViewInfo = DirectCast(fi.GetValue(navigator.ViewInfo.Buttons), NavigatorButtonsViewInfo)
'INSTANT VB NOTE: The variable mousePosition was renamed since Visual Basic does not handle local variables named the same as class members well:
				Dim mousePosition_Renamed As Point = navigator.PointToClient(Control.MousePosition)
				Dim buttonViewInfo As NavigatorButtonViewInfo = buttonsViewInfo.ButtonViewInfoAt(mousePosition_Renamed)
				Dim menuPosition As New Point(buttonViewInfo.Bounds.Left, buttonViewInfo.Bounds.Bottom)
				menuPosition = navigator.PointToScreen(menuPosition)
				popupMenu1.ShowPopup(menuPosition)
			End If
		End Sub

		Private Function CreateTable() As DataTable
			Dim table As New DataTable()
			Dim dataRow As DataRow

			table.Columns.Add("Prod_NO", GetType(String))
			table.Columns.Add("Prod_Name", GetType(String))
			table.Columns.Add("Order_Date", GetType(String))
			table.Columns.Add("Quantity", GetType(String))

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "101"
			dataRow("Prod_Name") = "Product1"
			dataRow("Order_Date") = "12/06/2012"
			dataRow("Quantity") = "50"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "102"
			dataRow("Prod_Name") = "Product2"
			dataRow("Order_Date") = "15/06/2012"
			dataRow("Quantity") = "70"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "103"
			dataRow("Prod_Name") = "Product3"
			dataRow("Order_Date") = "18/06/2012"
			dataRow("Quantity") = "30"
			table.Rows.Add(dataRow)

			dataRow = table.NewRow()
			dataRow("Prod_NO") = "104"
			dataRow("Prod_Name") = "Product4"
			dataRow("Order_Date") = "25/06/2012"
			dataRow("Quantity") = "20"
			table.Rows.Add(dataRow)

			Return table
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			gridControl1.DataSource = CreateTable()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			Close()
		End Sub
	End Class
End Namespace