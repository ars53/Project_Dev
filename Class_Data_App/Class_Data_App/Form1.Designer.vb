<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgvClass = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvInstructor = New System.Windows.Forms.DataGridView()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.btnFirstClass = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.dgvClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvInstructor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClass
        '
        Me.dgvClass.AllowUserToOrderColumns = True
        Me.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClass.Location = New System.Drawing.Point(0, 27)
        Me.dgvClass.Name = "dgvClass"
        Me.dgvClass.Size = New System.Drawing.Size(584, 300)
        Me.dgvClass.TabIndex = 1
        Me.dgvClass.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddToolStripMenuItem, Me.ShowToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(588, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseToolStripMenuItem, Me.StudentToolStripMenuItem, Me.InstructorToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CourseToolStripMenuItem.Text = "Course"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'InstructorToolStripMenuItem
        '
        Me.InstructorToolStripMenuItem.Name = "InstructorToolStripMenuItem"
        Me.InstructorToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.InstructorToolStripMenuItem.Text = "Instructor"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassesToolStripMenuItem, Me.StudentsToolStripMenuItem, Me.InstructorsToolStripMenuItem})
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ClassesToolStripMenuItem
        '
        Me.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem"
        Me.ClassesToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ClassesToolStripMenuItem.Text = "Classes"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'InstructorsToolStripMenuItem
        '
        Me.InstructorsToolStripMenuItem.Name = "InstructorsToolStripMenuItem"
        Me.InstructorsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.InstructorsToolStripMenuItem.Text = "Instructors"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'dgvInstructor
        '
        Me.dgvInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInstructor.Location = New System.Drawing.Point(0, 27)
        Me.dgvInstructor.Name = "dgvInstructor"
        Me.dgvInstructor.Size = New System.Drawing.Size(584, 300)
        Me.dgvInstructor.TabIndex = 3
        Me.dgvInstructor.Visible = False
        '
        'dgvStudent
        '
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Location = New System.Drawing.Point(0, 27)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.Size = New System.Drawing.Size(584, 300)
        Me.dgvStudent.TabIndex = 4
        Me.dgvStudent.Visible = False
        '
        'picHome
        '
        Me.picHome.Image = CType(resources.GetObject("picHome.Image"), System.Drawing.Image)
        Me.picHome.Location = New System.Drawing.Point(0, 27)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(588, 382)
        Me.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHome.TabIndex = 5
        Me.picHome.TabStop = False
        '
        'btnFirstClass
        '
        Me.btnFirstClass.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnFirstClass.Location = New System.Drawing.Point(44, 433)
        Me.btnFirstClass.Name = "btnFirstClass"
        Me.btnFirstClass.Size = New System.Drawing.Size(75, 23)
        Me.btnFirstClass.TabIndex = 6
        Me.btnFirstClass.Text = "First"
        Me.btnFirstClass.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(144, 433)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Button1"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirstClass)
        Me.Controls.Add(Me.picHome)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.dgvInstructor)
        Me.Controls.Add(Me.dgvClass)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Home"
        CType(Me.dgvClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvInstructor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClass As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstructorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvInstructor As DataGridView
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents picHome As PictureBox
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnFirstClass As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
End Class
