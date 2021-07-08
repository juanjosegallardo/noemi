<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Runge
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
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.xk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.k4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtY0 = New System.Windows.Forms.TextBox()
        Me.txtIteraciones = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtX0 = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtXf = New System.Windows.Forms.TextBox()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(14, 208)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(122, 23)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'dgvTabla
        '
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.xk, Me.yk, Me.k1, Me.k2, Me.k3, Me.k4})
        Me.dgvTabla.Location = New System.Drawing.Point(142, 14)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(457, 219)
        Me.dgvTabla.TabIndex = 6
        '
        'col
        '
        Me.col.HeaderText = "k"
        Me.col.Name = "col"
        Me.col.Width = 20
        '
        'xk
        '
        Me.xk.HeaderText = "xk"
        Me.xk.Name = "xk"
        Me.xk.Width = 50
        '
        'yk
        '
        Me.yk.HeaderText = "yk"
        Me.yk.Name = "yk"
        Me.yk.Width = 50
        '
        'k1
        '
        Me.k1.HeaderText = "k1"
        Me.k1.Name = "k1"
        Me.k1.Width = 50
        '
        'k2
        '
        Me.k2.HeaderText = "k2"
        Me.k2.Name = "k2"
        Me.k2.Width = 50
        '
        'k3
        '
        Me.k3.HeaderText = "k3"
        Me.k3.Name = "k3"
        Me.k3.Width = 50
        '
        'k4
        '
        Me.k4.HeaderText = "k4"
        Me.k4.Name = "k4"
        Me.k4.Width = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "y0"
        '
        'txtY0
        '
        Me.txtY0.Location = New System.Drawing.Point(12, 107)
        Me.txtY0.Name = "txtY0"
        Me.txtY0.Size = New System.Drawing.Size(116, 20)
        Me.txtY0.TabIndex = 3
        '
        'txtIteraciones
        '
        Me.txtIteraciones.Location = New System.Drawing.Point(12, 150)
        Me.txtIteraciones.Name = "txtIteraciones"
        Me.txtIteraciones.Size = New System.Drawing.Size(116, 20)
        Me.txtIteraciones.TabIndex = 4
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(67, 134)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(13, 13)
        Me.label.TabIndex = 8
        Me.label.Text = "n"
        '
        'txtX0
        '
        Me.txtX0.Location = New System.Drawing.Point(11, 29)
        Me.txtX0.Name = "txtX0"
        Me.txtX0.Size = New System.Drawing.Size(117, 20)
        Me.txtX0.TabIndex = 1
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(59, 13)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(18, 13)
        Me.label10.TabIndex = 10
        Me.label10.Text = "x0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "xf"
        '
        'txtXf
        '
        Me.txtXf.Location = New System.Drawing.Point(11, 68)
        Me.txtXf.Name = "txtXf"
        Me.txtXf.Size = New System.Drawing.Size(117, 20)
        Me.txtXf.TabIndex = 2
        '
        'Runge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 245)
        Me.Controls.Add(Me.txtXf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtX0)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtIteraciones)
        Me.Controls.Add(Me.txtY0)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTabla)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Runge"
        Me.Text = "Runge"
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtY0 As System.Windows.Forms.TextBox
    Friend WithEvents txtIteraciones As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtX0 As System.Windows.Forms.TextBox
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents xk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents k1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents k2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents k3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents k4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtXf As TextBox
End Class
