<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Euler
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
        Me.dgvTabla = New System.Windows.Forms.DataGridView()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtX0 = New System.Windows.Forms.TextBox()
        Me.x0 = New System.Windows.Forms.Label()
        Me.xf = New System.Windows.Forms.Label()
        Me.txtXF = New System.Windows.Forms.TextBox()
        Me.y0 = New System.Windows.Forms.Label()
        Me.txtY0 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.derivada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTabla
        '
        Me.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.derivada, Me.x, Me.y})
        Me.dgvTabla.Location = New System.Drawing.Point(119, 12)
        Me.dgvTabla.Name = "dgvTabla"
        Me.dgvTabla.Size = New System.Drawing.Size(540, 198)
        Me.dgvTabla.TabIndex = 0
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(13, 187)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtX0
        '
        Me.txtX0.Location = New System.Drawing.Point(12, 28)
        Me.txtX0.Name = "txtX0"
        Me.txtX0.Size = New System.Drawing.Size(100, 20)
        Me.txtX0.TabIndex = 2
        '
        'x0
        '
        Me.x0.AutoSize = True
        Me.x0.Location = New System.Drawing.Point(50, 12)
        Me.x0.Name = "x0"
        Me.x0.Size = New System.Drawing.Size(18, 13)
        Me.x0.TabIndex = 3
        Me.x0.Text = "x0"
        '
        'xf
        '
        Me.xf.AutoSize = True
        Me.xf.Location = New System.Drawing.Point(50, 53)
        Me.xf.Name = "xf"
        Me.xf.Size = New System.Drawing.Size(15, 13)
        Me.xf.TabIndex = 4
        Me.xf.Text = "xf"
        '
        'txtXF
        '
        Me.txtXF.Location = New System.Drawing.Point(12, 69)
        Me.txtXF.Name = "txtXF"
        Me.txtXF.Size = New System.Drawing.Size(100, 20)
        Me.txtXF.TabIndex = 5
        '
        'y0
        '
        Me.y0.AutoSize = True
        Me.y0.Location = New System.Drawing.Point(47, 94)
        Me.y0.Name = "y0"
        Me.y0.Size = New System.Drawing.Size(18, 13)
        Me.y0.TabIndex = 6
        Me.y0.Text = "y0"
        '
        'txtY0
        '
        Me.txtY0.Location = New System.Drawing.Point(12, 110)
        Me.txtY0.Name = "txtY0"
        Me.txtY0.Size = New System.Drawing.Size(100, 20)
        Me.txtY0.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "n"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(13, 149)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(100, 20)
        Me.txtN.TabIndex = 9
        '
        'derivada
        '
        Me.derivada.HeaderText = "dy/dx"
        Me.derivada.Name = "derivada"
        '
        'x
        '
        Me.x.HeaderText = "x"
        Me.x.Name = "x"
        '
        'y
        '
        Me.y.HeaderText = "y"
        Me.y.Name = "y"
        '
        'Euler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 222)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtY0)
        Me.Controls.Add(Me.y0)
        Me.Controls.Add(Me.txtXF)
        Me.Controls.Add(Me.xf)
        Me.Controls.Add(Me.x0)
        Me.Controls.Add(Me.txtX0)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvTabla)
        Me.Name = "Euler"
        Me.Text = "Euler"
        CType(Me.dgvTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTabla As System.Windows.Forms.DataGridView
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtX0 As System.Windows.Forms.TextBox
    Friend WithEvents x0 As System.Windows.Forms.Label
    Friend WithEvents xf As System.Windows.Forms.Label
    Friend WithEvents txtXF As System.Windows.Forms.TextBox
    Friend WithEvents y0 As System.Windows.Forms.Label
    Friend WithEvents txtY0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents derivada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents x As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents y As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
