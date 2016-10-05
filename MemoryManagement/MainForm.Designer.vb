<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnFija = New System.Windows.Forms.Button()
        Me.btnDinamica = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFija
        '
        Me.btnFija.BackColor = System.Drawing.Color.Purple
        Me.btnFija.FlatAppearance.BorderSize = 0
        Me.btnFija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFija.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFija.ForeColor = System.Drawing.Color.White
        Me.btnFija.Location = New System.Drawing.Point(29, 68)
        Me.btnFija.Name = "btnFija"
        Me.btnFija.Size = New System.Drawing.Size(218, 41)
        Me.btnFija.TabIndex = 0
        Me.btnFija.Text = "Partición Fija"
        Me.btnFija.UseVisualStyleBackColor = False
        '
        'btnDinamica
        '
        Me.btnDinamica.BackColor = System.Drawing.Color.Purple
        Me.btnDinamica.FlatAppearance.BorderSize = 0
        Me.btnDinamica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDinamica.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDinamica.ForeColor = System.Drawing.Color.White
        Me.btnDinamica.Location = New System.Drawing.Point(266, 68)
        Me.btnDinamica.Name = "btnDinamica"
        Me.btnDinamica.Size = New System.Drawing.Size(218, 41)
        Me.btnDinamica.TabIndex = 0
        Me.btnDinamica.Text = "Partición Dinamica"
        Me.btnDinamica.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Memory Management"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(518, 132)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDinamica)
        Me.Controls.Add(Me.btnFija)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFija As Button
    Friend WithEvents btnDinamica As Button
    Friend WithEvents Label1 As Label
End Class
