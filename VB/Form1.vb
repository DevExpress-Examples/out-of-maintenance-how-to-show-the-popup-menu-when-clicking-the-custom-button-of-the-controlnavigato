Imports Microsoft.VisualBasic
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
			Dim navigator As ControlNavigator = CType(sender, ControlNavigator)
            If e.Button Is navigator.Buttons.CustomButtons(0) Then
                Dim fi As FieldInfo = GetType(NavigatorButtonsBase).GetField("viewInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
                Dim buttonsViewInfo As NavigatorButtonsViewInfo = CType(fi.GetValue(navigator.ViewInfo.Buttons), NavigatorButtonsViewInfo)
                Dim mousePosition As Point = navigator.PointToClient(Control.MousePosition)
                Dim buttonViewInfo As NavigatorButtonViewInfo = buttonsViewInfo.ButtonViewInfoAt(mousePosition)
                Dim menuPosition As New Point(buttonViewInfo.Bounds.Left, buttonViewInfo.Bounds.Bottom)
                menuPosition = navigator.PointToScreen(menuPosition)
                popupMenu1.ShowPopup(menuPosition)
            End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			Close()
		End Sub
	End Class
End Namespace