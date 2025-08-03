<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(218, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 22)
        Label1.TabIndex = 0
        Label1.Text = "IT Solution Pvt.Ltd"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(49, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 23)
        Label2.TabIndex = 1
        Label2.Text = "Employee No"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(49, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 23)
        Label3.TabIndex = 2
        Label3.Text = "Employee Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(49, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 23)
        Label4.TabIndex = 3
        Label4.Text = "Basic Salary"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(49, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 23)
        Label5.TabIndex = 4
        Label5.Text = "Department"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(49, 267)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 23)
        Label6.TabIndex = 5
        Label6.Text = "Bonus"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label7.Location = New Point(49, 310)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 23)
        Label7.TabIndex = 6
        Label7.Text = "Gross Salary"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Label8.Location = New Point(49, 357)
        Label8.Name = "Label8"
        Label8.Size = New Size(94, 23)
        Label8.TabIndex = 7
        Label8.Text = "Net Salary"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox1.Location = New Point(244, 59)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 30)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox2.Location = New Point(244, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 30)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox3.Location = New Point(244, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 30)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox4.Location = New Point(244, 260)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 30)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox5.Location = New Point(244, 310)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 30)
        TextBox5.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        TextBox6.Location = New Point(244, 357)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 30)
        TextBox6.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"HR", "FIN", "PRO"})
        ComboBox1.Location = New Point(244, 208)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 31)
        ComboBox1.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button1.Location = New Point(259, 434)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 15
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button2.Location = New Point(382, 434)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 16
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Button3.Location = New Point(515, 434)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 17
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(655, 488)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Employee Salary Sheet"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
