<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateClass
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
        Me.txtTID = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Class Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(97, 13)
        Me.txtName.MaxLength = 8
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(16, 51)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(58, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Class Time"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(97, 51)
        Me.txtTime.MaxLength = 5
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 3
        '
        'lblTid
        '
        Me.lblTid.AutoSize = True
        Me.lblTid.Location = New System.Drawing.Point(16, 87)
        Me.lblTid.Name = "lblTid"
        Me.lblTid.Size = New System.Drawing.Size(65, 13)
        Me.lblTid.TabIndex = 4
        Me.lblTid.Text = "Instructor ID"
        '
        'txtTID
        '
        Me.txtTID.Location = New System.Drawing.Point(97, 79)
        Me.txtTID.MaxLength = 5
        Me.txtTID.Name = "txtTID"
        Me.txtTID.Size = New System.Drawing.Size(100, 20)
        Me.txtTID.TabIndex = 5
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(16, 117)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(35, 13)
        Me.lblRoom.TabIndex = 6
        Me.lblRoom.Text = "Room"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(97, 109)
        Me.txtRoom.MaxLength = 5
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(100, 20)
        Me.txtRoom.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(19, 164)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(134, 164)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'UpdateClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 196)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtRoom)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.txtTID)
        Me.Controls.Add(Me.lblTid)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "UpdateClass"
        Me.Text = "UpdateClass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTid As Label
    Friend WithEvents txtTID As TextBox
    Friend WithEvents lblRoom As Label
    Friend WithEvents txtRoom As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
End Class
