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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Azure
        Label1.Location = New Point(44, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter The Grade Letter"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Azure
        Label2.Location = New Point(91, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 25)
        Label2.TabIndex = 0
        Label2.Text = "Results"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(65, 227)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 63)
        Button1.TabIndex = 1
        Button1.Text = "Compute!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(329, 119)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 31)
        TextBox1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"A", "A-", "B", "C", "Other"})
        ComboBox1.Location = New Point(329, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox

End Class
