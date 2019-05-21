Namespace Q143749
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
			Me.controlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' controlNavigator1
			' 
			Me.controlNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() { New DevExpress.XtraEditors.NavigatorCustomButton(0, 16, "Show Popup Menu")})
			Me.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.controlNavigator1.Location = New System.Drawing.Point(0, 334)
			Me.controlNavigator1.Name = "controlNavigator1"
			Me.controlNavigator1.NavigatableControl = Me.gridControl1
			Me.controlNavigator1.Size = New System.Drawing.Size(472, 24)
			Me.controlNavigator1.TabIndex = 0
			Me.controlNavigator1.Text = "controlNavigator1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.controlNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(472, 334)
			Me.gridControl1.TabIndex = 5
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1})
			Me.barManager1.MaxItemId = 1
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(472, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 358)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(472, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 358)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(472, 0)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 358)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "Exit"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(472, 358)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.controlNavigator1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents controlNavigator1 As DevExpress.XtraEditors.ControlNavigator
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

