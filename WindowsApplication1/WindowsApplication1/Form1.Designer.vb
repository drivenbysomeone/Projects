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
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblRegning = New System.Windows.Forms.Label()
        Me.txtTimeDuration = New System.Windows.Forms.TextBox()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.rdbCar = New System.Windows.Forms.RadioButton()
        Me.rdbTruck = New System.Windows.Forms.RadioButton()
        Me.btnStandard = New System.Windows.Forms.Button()
        Me.btnEventRate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Location = New System.Drawing.Point(12, 25)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(93, 13)
        Me.LblTimer.TabIndex = 0
        Me.LblTimer.Text = "Indtast antal timer:"
        '
        'LblRegning
        '
        Me.LblRegning.AutoSize = True
        Me.LblRegning.Location = New System.Drawing.Point(233, 25)
        Me.LblRegning.Name = "LblRegning"
        Me.LblRegning.Size = New System.Drawing.Size(50, 13)
        Me.LblRegning.TabIndex = 1
        Me.LblRegning.Text = "Regning:"
        '
        'txtTimeDuration
        '
        Me.txtTimeDuration.Location = New System.Drawing.Point(4, 56)
        Me.txtTimeDuration.Name = "txtTimeDuration"
        Me.txtTimeDuration.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeDuration.TabIndex = 2
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(183, 56)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(100, 20)
        Me.txtFee.TabIndex = 3
        '
        'rdbCar
        '
        Me.rdbCar.AutoSize = True
        Me.rdbCar.Location = New System.Drawing.Point(125, 107)
        Me.rdbCar.Name = "rdbCar"
        Me.rdbCar.Size = New System.Drawing.Size(41, 17)
        Me.rdbCar.TabIndex = 4
        Me.rdbCar.TabStop = True
        Me.rdbCar.Text = "Car"
        Me.rdbCar.UseVisualStyleBackColor = True
        '
        'rdbTruck
        '
        Me.rdbTruck.AutoSize = True
        Me.rdbTruck.Location = New System.Drawing.Point(125, 131)
        Me.rdbTruck.Name = "rdbTruck"
        Me.rdbTruck.Size = New System.Drawing.Size(53, 17)
        Me.rdbTruck.TabIndex = 5
        Me.rdbTruck.TabStop = True
        Me.rdbTruck.Text = "Truck"
        Me.rdbTruck.UseVisualStyleBackColor = True
        '
        'btnStandard
        '
        Me.btnStandard.Location = New System.Drawing.Point(103, 179)
        Me.btnStandard.Name = "btnStandard"
        Me.btnStandard.Size = New System.Drawing.Size(75, 23)
        Me.btnStandard.TabIndex = 6
        Me.btnStandard.Text = "Standard"
        Me.btnStandard.UseVisualStyleBackColor = True
        '
        'btnEventRate
        '
        Me.btnEventRate.Location = New System.Drawing.Point(103, 208)
        Me.btnEventRate.Name = "btnEventRate"
        Me.btnEventRate.Size = New System.Drawing.Size(75, 23)
        Me.btnEventRate.TabIndex = 7
        Me.btnEventRate.Text = "Event Rate"
        Me.btnEventRate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 268)
        Me.Controls.Add(Me.btnEventRate)
        Me.Controls.Add(Me.btnStandard)
        Me.Controls.Add(Me.rdbTruck)
        Me.Controls.Add(Me.rdbCar)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.txtTimeDuration)
        Me.Controls.Add(Me.LblRegning)
        Me.Controls.Add(Me.LblTimer)
        Me.Name = "Form1"
        Me.Text = "Parking Lot Cashier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTimer As System.Windows.Forms.Label
    Friend WithEvents LblRegning As System.Windows.Forms.Label
    Friend WithEvents txtTimeDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents rdbCar As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTruck As System.Windows.Forms.RadioButton
    Friend WithEvents btnStandard As System.Windows.Forms.Button
    Friend WithEvents btnEventRate As System.Windows.Forms.Button

End Class
