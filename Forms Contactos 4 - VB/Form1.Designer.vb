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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.dtpbirth = New System.Windows.Forms.DateTimePicker()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.PERSON = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(89, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(79, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PHONE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(20, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DATE OF BIRTH:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(9, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "E-MAIL ADDRESS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Goudy Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(328, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CONTACT"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtemail.Location = New System.Drawing.Point(160, 243)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(125, 25)
        Me.txtemail.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtname.Location = New System.Drawing.Point(160, 111)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(125, 25)
        Me.txtname.TabIndex = 6
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtphone.Location = New System.Drawing.Point(160, 152)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(125, 25)
        Me.txtphone.TabIndex = 7
        '
        'dtpbirth
        '
        Me.dtpbirth.CalendarFont = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.dtpbirth.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dtpbirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpbirth.Location = New System.Drawing.Point(160, 197)
        Me.dtpbirth.Name = "dtpbirth"
        Me.dtpbirth.Size = New System.Drawing.Size(125, 25)
        Me.dtpbirth.TabIndex = 8
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnshow.Location = New System.Drawing.Point(210, 293)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(75, 38)
        Me.btnshow.TabIndex = 9
        Me.btnshow.Text = "SHOW"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'PERSON
        '
        Me.PERSON.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PERSON.FormattingEnabled = True
        Me.PERSON.ItemHeight = 17
        Me.PERSON.Location = New System.Drawing.Point(328, 111)
        Me.PERSON.Name = "PERSON"
        Me.PERSON.Size = New System.Drawing.Size(431, 208)
        Me.PERSON.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 343)
        Me.Controls.Add(Me.PERSON)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dtpbirth)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents dtpbirth As DateTimePicker
    Friend WithEvents btnshow As Button
    Friend WithEvents PERSON As ListBox
End Class
