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
        Me.btnConverttoMiles = New System.Windows.Forms.Button()
        Me.btnConverttoKM = New System.Windows.Forms.Button()
        Me.txtKM = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConverttoMiles
        '
        Me.btnConverttoMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConverttoMiles.Location = New System.Drawing.Point(321, 233)
        Me.btnConverttoMiles.Name = "btnConverttoMiles"
        Me.btnConverttoMiles.Size = New System.Drawing.Size(109, 57)
        Me.btnConverttoMiles.TabIndex = 1
        Me.btnConverttoMiles.Text = "Convert to Miles"
        Me.btnConverttoMiles.UseVisualStyleBackColor = True
        '
        'btnConverttoKM
        '
        Me.btnConverttoKM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConverttoKM.Location = New System.Drawing.Point(89, 233)
        Me.btnConverttoKM.Name = "btnConverttoKM"
        Me.btnConverttoKM.Size = New System.Drawing.Size(109, 57)
        Me.btnConverttoKM.TabIndex = 2
        Me.btnConverttoKM.Text = "Convert to Kilometers"
        Me.btnConverttoKM.UseVisualStyleBackColor = True
        '
        'txtKM
        '
        Me.txtKM.Location = New System.Drawing.Point(321, 207)
        Me.txtKM.Name = "txtKM"
        Me.txtKM.Size = New System.Drawing.Size(109, 20)
        Me.txtKM.TabIndex = 3
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(89, 207)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(109, 20)
        Me.txtMiles.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(72, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(374, 57)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "DIstance Converter"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Miles"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kilometers"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(206, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtKM)
        Me.Controls.Add(Me.btnConverttoKM)
        Me.Controls.Add(Me.btnConverttoMiles)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConverttoMiles As Button
    Friend WithEvents btnConverttoKM As Button
    Friend WithEvents txtKM As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
