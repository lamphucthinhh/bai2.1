<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Txttenfile = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Txtnoidung = New TextBox()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Rd1 = New RadioButton()
        Rd2 = New RadioButton()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Tên file"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(229, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 15)
        Label2.TabIndex = 0
        Label2.Text = "Ghi dữ liệu xuống file "
        ' 
        ' Txttenfile
        ' 
        Txttenfile.Location = New Point(122, 65)
        Txttenfile.Name = "Txttenfile"
        Txttenfile.Size = New Size(215, 23)
        Txttenfile.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(363, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "ghi file"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(350, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "Thoát"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Txtnoidung
        ' 
        Txtnoidung.Location = New Point(104, 204)
        Txtnoidung.Multiline = True
        Txtnoidung.Name = "Txtnoidung"
        Txtnoidung.Size = New Size(248, 183)
        Txtnoidung.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(48, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 0
        Label3.Text = "Nội dung"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Rd1)
        GroupBox1.Controls.Add(Rd2)
        GroupBox1.Location = New Point(120, 116)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(232, 42)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Rd1
        ' 
        Rd1.AutoSize = True
        Rd1.Location = New Point(6, 17)
        Rd1.Name = "Rd1"
        Rd1.Size = New Size(97, 19)
        Rd1.TabIndex = 5
        Rd1.TabStop = True
        Rd1.Text = "RadioButton2"
        Rd1.UseVisualStyleBackColor = True
        ' 
        ' Rd2
        ' 
        Rd2.AutoSize = True
        Rd2.Location = New Point(120, 17)
        Rd2.Name = "Rd2"
        Rd2.Size = New Size(97, 19)
        Rd2.TabIndex = 4
        Rd2.TabStop = True
        Rd2.Text = "RadioButton1"
        Rd2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Txtnoidung)
        Controls.Add(Txttenfile)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txttenfile As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Txtnoidung As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rd1 As RadioButton
    Friend WithEvents Rd2 As RadioButton
End Class
