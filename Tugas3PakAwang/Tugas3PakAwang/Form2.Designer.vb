<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.lbNama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbMeja = New System.Windows.Forms.Label()
        Me.dgvDetil = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvDetil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(131, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota Pesanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama  : "
        '
        'lbNama
        '
        Me.lbNama.AutoSize = True
        Me.lbNama.Location = New System.Drawing.Point(83, 81)
        Me.lbNama.Name = "lbNama"
        Me.lbNama.Size = New System.Drawing.Size(39, 13)
        Me.lbNama.TabIndex = 2
        Me.lbNama.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meja    : "
        '
        'lbMeja
        '
        Me.lbMeja.AutoSize = True
        Me.lbMeja.Location = New System.Drawing.Point(83, 114)
        Me.lbMeja.Name = "lbMeja"
        Me.lbMeja.Size = New System.Drawing.Size(39, 13)
        Me.lbMeja.TabIndex = 4
        Me.lbMeja.Text = "Label5"
        '
        'dgvDetil
        '
        Me.dgvDetil.AllowUserToAddRows = False
        Me.dgvDetil.AllowUserToDeleteRows = False
        Me.dgvDetil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvDetil.Location = New System.Drawing.Point(24, 141)
        Me.dgvDetil.Name = "dgvDetil"
        Me.dgvDetil.ReadOnly = True
        Me.dgvDetil.Size = New System.Drawing.Size(459, 219)
        Me.dgvDetil.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Harga"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(196, 363)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(88, 38)
        Me.lbTotal.TabIndex = 7
        Me.lbTotal.Text = "lbTotal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total : "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 450)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDetil)
        Me.Controls.Add(Me.lbMeja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvDetil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbNama As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbMeja As Label
    Friend WithEvents dgvDetil As DataGridView
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
