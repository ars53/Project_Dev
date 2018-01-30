<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.lblTid = New System.Windows.Forms.Label()
        Me.txtTid = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(76, 13)
        Me.txtName.MaxLength = 8
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(13, 43)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(58, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Class Time"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(76, 40)
        Me.txtTime.MaxLength = 5
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 3
        '
        'lblTid
        '
        Me.lblTid.AutoSize = True
        Me.lblTid.Location = New System.Drawing.Point(13, 69)
        Me.lblTid.Name = "lblTid"
        Me.lblTid.Size = New System.Drawing.Size(61, 13)
        Me.lblTid.TabIndex = 4
        Me.lblTid.Text = "Teacher ID"
        '
        'txtTid
        '
        Me.txtTid.Location = New System.Drawing.Point(76, 66)
        Me.txtTid.MaxLength = 5
        Me.txtTid.Name = "txtTid"
        Me.txtTid.Size = New System.Drawing.Size(100, 20)
        Me.txtTid.TabIndex = 5
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(13, 95)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(35, 13)
        Me.lblRoom.TabIndex = 6
        Me.lblRoom.Text = "Room"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(76, 92)
        Me.txtRoom.MaxLength = 5
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtRoom.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(16, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(107, 136)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'AddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 172)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.txtTid)
        Me.Controls.Add(Me.lblTid)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddClass"
        Me.Text = "AddClass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTid As Label
    Friend WithEvents txtTid As TextBox
    Friend WithEvents lblRoom As Label
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
End Class
