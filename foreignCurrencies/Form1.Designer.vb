<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtConvertedAmount = New System.Windows.Forms.TextBox
        Me.btnConvert = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbtnBritishPounds = New System.Windows.Forms.RadioButton
        Me.rbtnCanadianDollars = New System.Windows.Forms.RadioButton
        Me.rbtnDutchGuilders = New System.Windows.Forms.RadioButton
        Me.rbtnFrenchFrancs = New System.Windows.Forms.RadioButton
        Me.rbtnGermanMarks = New System.Windows.Forms.RadioButton
        Me.rbtnItalianLira = New System.Windows.Forms.RadioButton
        Me.rbtnJapaneseYen = New System.Windows.Forms.RadioButton
        Me.rbtnMexicanPesos = New System.Windows.Forms.RadioButton
        Me.rbtnSwissFrancs = New System.Windows.Forms.RadioButton
        Me.rbtnForeignToUS = New System.Windows.Forms.CheckBox
        Me.rbtnUSToForeign = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(159, 101)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 2
        '
        'txtConvertedAmount
        '
        Me.txtConvertedAmount.Location = New System.Drawing.Point(159, 298)
        Me.txtConvertedAmount.Name = "txtConvertedAmount"
        Me.txtConvertedAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtConvertedAmount.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(119, 340)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 340)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "END"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(156, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Conversion Direction"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(11, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Input Ammount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(41, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Result"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(177, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Select Currency"
        '
        'rbtnBritishPounds
        '
        Me.rbtnBritishPounds.AutoSize = True
        Me.rbtnBritishPounds.Location = New System.Drawing.Point(14, 174)
        Me.rbtnBritishPounds.Name = "rbtnBritishPounds"
        Me.rbtnBritishPounds.Size = New System.Drawing.Size(92, 17)
        Me.rbtnBritishPounds.TabIndex = 10
        Me.rbtnBritishPounds.TabStop = True
        Me.rbtnBritishPounds.Text = "British Pounds"
        Me.rbtnBritishPounds.UseVisualStyleBackColor = True
        '
        'rbtnCanadianDollars
        '
        Me.rbtnCanadianDollars.AutoSize = True
        Me.rbtnCanadianDollars.Location = New System.Drawing.Point(168, 174)
        Me.rbtnCanadianDollars.Name = "rbtnCanadianDollars"
        Me.rbtnCanadianDollars.Size = New System.Drawing.Size(105, 17)
        Me.rbtnCanadianDollars.TabIndex = 11
        Me.rbtnCanadianDollars.TabStop = True
        Me.rbtnCanadianDollars.Text = "Canadian Dollars"
        Me.rbtnCanadianDollars.UseVisualStyleBackColor = True
        '
        'rbtnDutchGuilders
        '
        Me.rbtnDutchGuilders.AutoSize = True
        Me.rbtnDutchGuilders.Location = New System.Drawing.Point(318, 174)
        Me.rbtnDutchGuilders.Name = "rbtnDutchGuilders"
        Me.rbtnDutchGuilders.Size = New System.Drawing.Size(95, 17)
        Me.rbtnDutchGuilders.TabIndex = 12
        Me.rbtnDutchGuilders.TabStop = True
        Me.rbtnDutchGuilders.Text = "Dutch Guilders"
        Me.rbtnDutchGuilders.UseVisualStyleBackColor = True
        '
        'rbtnFrenchFrancs
        '
        Me.rbtnFrenchFrancs.AutoSize = True
        Me.rbtnFrenchFrancs.Location = New System.Drawing.Point(14, 215)
        Me.rbtnFrenchFrancs.Name = "rbtnFrenchFrancs"
        Me.rbtnFrenchFrancs.Size = New System.Drawing.Size(93, 17)
        Me.rbtnFrenchFrancs.TabIndex = 13
        Me.rbtnFrenchFrancs.TabStop = True
        Me.rbtnFrenchFrancs.Text = "French Francs"
        Me.rbtnFrenchFrancs.UseVisualStyleBackColor = True
        '
        'rbtnGermanMarks
        '
        Me.rbtnGermanMarks.AutoSize = True
        Me.rbtnGermanMarks.Location = New System.Drawing.Point(168, 215)
        Me.rbtnGermanMarks.Name = "rbtnGermanMarks"
        Me.rbtnGermanMarks.Size = New System.Drawing.Size(94, 17)
        Me.rbtnGermanMarks.TabIndex = 14
        Me.rbtnGermanMarks.TabStop = True
        Me.rbtnGermanMarks.Text = "German Marks"
        Me.rbtnGermanMarks.UseVisualStyleBackColor = True
        '
        'rbtnItalianLira
        '
        Me.rbtnItalianLira.AutoSize = True
        Me.rbtnItalianLira.Location = New System.Drawing.Point(318, 215)
        Me.rbtnItalianLira.Name = "rbtnItalianLira"
        Me.rbtnItalianLira.Size = New System.Drawing.Size(73, 17)
        Me.rbtnItalianLira.TabIndex = 15
        Me.rbtnItalianLira.TabStop = True
        Me.rbtnItalianLira.Text = "Italian Lira"
        Me.rbtnItalianLira.UseVisualStyleBackColor = True
        '
        'rbtnJapaneseYen
        '
        Me.rbtnJapaneseYen.AutoSize = True
        Me.rbtnJapaneseYen.Location = New System.Drawing.Point(14, 253)
        Me.rbtnJapaneseYen.Name = "rbtnJapaneseYen"
        Me.rbtnJapaneseYen.Size = New System.Drawing.Size(93, 17)
        Me.rbtnJapaneseYen.TabIndex = 16
        Me.rbtnJapaneseYen.TabStop = True
        Me.rbtnJapaneseYen.Text = "Japanese Yen"
        Me.rbtnJapaneseYen.UseVisualStyleBackColor = True
        '
        'rbtnMexicanPesos
        '
        Me.rbtnMexicanPesos.AutoSize = True
        Me.rbtnMexicanPesos.Location = New System.Drawing.Point(168, 253)
        Me.rbtnMexicanPesos.Name = "rbtnMexicanPesos"
        Me.rbtnMexicanPesos.Size = New System.Drawing.Size(97, 17)
        Me.rbtnMexicanPesos.TabIndex = 17
        Me.rbtnMexicanPesos.TabStop = True
        Me.rbtnMexicanPesos.Text = "Mexican Pesos"
        Me.rbtnMexicanPesos.UseVisualStyleBackColor = True
        '
        'rbtnSwissFrancs
        '
        Me.rbtnSwissFrancs.AutoSize = True
        Me.rbtnSwissFrancs.Location = New System.Drawing.Point(318, 253)
        Me.rbtnSwissFrancs.Name = "rbtnSwissFrancs"
        Me.rbtnSwissFrancs.Size = New System.Drawing.Size(87, 17)
        Me.rbtnSwissFrancs.TabIndex = 18
        Me.rbtnSwissFrancs.TabStop = True
        Me.rbtnSwissFrancs.Text = "Swiss Francs"
        Me.rbtnSwissFrancs.UseVisualStyleBackColor = True
        '
        'rbtnForeignToUS
        '
        Me.rbtnForeignToUS.AutoSize = True
        Me.rbtnForeignToUS.Location = New System.Drawing.Point(62, 50)
        Me.rbtnForeignToUS.Name = "rbtnForeignToUS"
        Me.rbtnForeignToUS.Size = New System.Drawing.Size(95, 17)
        Me.rbtnForeignToUS.TabIndex = 19
        Me.rbtnForeignToUS.Text = "Foreign To US"
        Me.rbtnForeignToUS.UseVisualStyleBackColor = True
        '
        'rbtnUSToForeign
        '
        Me.rbtnUSToForeign.AutoSize = True
        Me.rbtnUSToForeign.Location = New System.Drawing.Point(181, 50)
        Me.rbtnUSToForeign.Name = "rbtnUSToForeign"
        Me.rbtnUSToForeign.Size = New System.Drawing.Size(134, 17)
        Me.rbtnUSToForeign.TabIndex = 20
        Me.rbtnUSToForeign.Text = "Convert U.S to Foreign"
        Me.rbtnUSToForeign.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 375)
        Me.Controls.Add(Me.rbtnUSToForeign)
        Me.Controls.Add(Me.rbtnForeignToUS)
        Me.Controls.Add(Me.rbtnSwissFrancs)
        Me.Controls.Add(Me.rbtnMexicanPesos)
        Me.Controls.Add(Me.rbtnJapaneseYen)
        Me.Controls.Add(Me.rbtnItalianLira)
        Me.Controls.Add(Me.rbtnGermanMarks)
        Me.Controls.Add(Me.rbtnFrenchFrancs)
        Me.Controls.Add(Me.rbtnDutchGuilders)
        Me.Controls.Add(Me.rbtnCanadianDollars)
        Me.Controls.Add(Me.rbtnBritishPounds)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtConvertedAmount)
        Me.Controls.Add(Me.txtAmount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtConvertedAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbtnBritishPounds As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCanadianDollars As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDutchGuilders As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFrenchFrancs As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnGermanMarks As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnItalianLira As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnJapaneseYen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMexicanPesos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSwissFrancs As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnForeignToUS As System.Windows.Forms.CheckBox
    Friend WithEvents rbtnUSToForeign As System.Windows.Forms.CheckBox

End Class
