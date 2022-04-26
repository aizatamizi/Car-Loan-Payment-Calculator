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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.cbErate = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbSrate = New System.Windows.Forms.ComboBox()
        Me.btnClea = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.ListBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Loan Payment Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtLoan)
        Me.GroupBox1.Controls.Add(Me.cbErate)
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Controls.Add(Me.cbSrate)
        Me.GroupBox1.Controls.Add(Me.btnClea)
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 264)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Calculator"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(155, 142)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(151, 27)
        Me.txtRate.TabIndex = 12
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(155, 52)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(151, 27)
        Me.txtLoan.TabIndex = 11
        '
        'cbErate
        '
        Me.cbErate.FormattingEnabled = True
        Me.cbErate.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbErate.Location = New System.Drawing.Point(470, 98)
        Me.cbErate.Name = "cbErate"
        Me.cbErate.Size = New System.Drawing.Size(151, 28)
        Me.cbErate.TabIndex = 10
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbYear.Location = New System.Drawing.Point(470, 55)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(151, 28)
        Me.cbYear.TabIndex = 9
        '
        'cbSrate
        '
        Me.cbSrate.FormattingEnabled = True
        Me.cbSrate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbSrate.Location = New System.Drawing.Point(155, 98)
        Me.cbSrate.Name = "cbSrate"
        Me.cbSrate.Size = New System.Drawing.Size(151, 28)
        Me.cbSrate.TabIndex = 7
        '
        'btnClea
        '
        Me.btnClea.Location = New System.Drawing.Point(173, 200)
        Me.btnClea.Name = "btnClea"
        Me.btnClea.Size = New System.Drawing.Size(94, 29)
        Me.btnClea.TabIndex = 6
        Me.btnClea.Text = "Clear"
        Me.btnClea.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(35, 200)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(94, 29)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(360, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 29)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "End Rate (%)"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(360, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Years"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(35, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Rate Step Size"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(35, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Star Rate  (%)"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(35, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Loan Amount"
        '
        'lblOutput
        '
        Me.lblOutput.FormattingEnabled = True
        Me.lblOutput.ItemHeight = 20
        Me.lblOutput.Items.AddRange(New Object() {"Interest Rate                               Monthly Payment", ""})
        Me.lblOutput.Location = New System.Drawing.Point(13, 347)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(708, 204)
        Me.lblOutput.TabIndex = 3
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(570, 571)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(150, 31)
        Me.btnList.TabIndex = 4
        Me.btnList.Text = "Car List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 571)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 20)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 632)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Car Loan Payment Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLoan As TextBox
    Friend WithEvents cbErate As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbSrate As ComboBox
    Friend WithEvents btnClea As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOutput As ListBox
    Friend WithEvents btnList As Button
    Friend WithEvents txtRate As TextBox
    Friend WithEvents lblName As Label
End Class
