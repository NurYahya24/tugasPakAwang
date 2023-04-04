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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtMeja = New System.Windows.Forms.TextBox()
        Me.pbMakan = New System.Windows.Forms.PictureBox()
        Me.pbMinum = New System.Windows.Forms.PictureBox()
        Me.btnAddMakan = New System.Windows.Forms.Button()
        Me.btnMinMakan = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.dgvPesan = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMinMinum = New System.Windows.Forms.Button()
        Me.btnAddMinum = New System.Windows.Forms.Button()
        Me.btnPesan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvMakan = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMinum = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbMakan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMinum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPesan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMakan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMinum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(577, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(577, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Meja"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(646, 9)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(118, 20)
        Me.txtNama.TabIndex = 3
        '
        'txtMeja
        '
        Me.txtMeja.Location = New System.Drawing.Point(646, 35)
        Me.txtMeja.Name = "txtMeja"
        Me.txtMeja.Size = New System.Drawing.Size(118, 20)
        Me.txtMeja.TabIndex = 4
        '
        'pbMakan
        '
        Me.pbMakan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMakan.Location = New System.Drawing.Point(278, 65)
        Me.pbMakan.Name = "pbMakan"
        Me.pbMakan.Size = New System.Drawing.Size(100, 86)
        Me.pbMakan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMakan.TabIndex = 7
        Me.pbMakan.TabStop = False
        '
        'pbMinum
        '
        Me.pbMinum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMinum.Location = New System.Drawing.Point(664, 65)
        Me.pbMinum.Name = "pbMinum"
        Me.pbMinum.Size = New System.Drawing.Size(100, 86)
        Me.pbMinum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMinum.TabIndex = 8
        Me.pbMinum.TabStop = False
        '
        'btnAddMakan
        '
        Me.btnAddMakan.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMakan.Location = New System.Drawing.Point(278, 170)
        Me.btnAddMakan.Name = "btnAddMakan"
        Me.btnAddMakan.Size = New System.Drawing.Size(45, 45)
        Me.btnAddMakan.TabIndex = 9
        Me.btnAddMakan.Text = "+"
        Me.btnAddMakan.UseVisualStyleBackColor = True
        '
        'btnMinMakan
        '
        Me.btnMinMakan.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinMakan.Location = New System.Drawing.Point(333, 170)
        Me.btnMinMakan.Name = "btnMinMakan"
        Me.btnMinMakan.Size = New System.Drawing.Size(45, 45)
        Me.btnMinMakan.TabIndex = 10
        Me.btnMinMakan.Text = "-"
        Me.btnMinMakan.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(396, 421)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(118, 20)
        Me.txtTotal.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(347, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Total"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(153, 256)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'dgvPesan
        '
        Me.dgvPesan.AllowUserToAddRows = False
        Me.dgvPesan.AllowUserToDeleteRows = False
        Me.dgvPesan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPesan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Item, Me.Qty, Me.Harga, Me.Total})
        Me.dgvPesan.Location = New System.Drawing.Point(249, 256)
        Me.dgvPesan.Name = "dgvPesan"
        Me.dgvPesan.ReadOnly = True
        Me.dgvPesan.Size = New System.Drawing.Size(445, 146)
        Me.dgvPesan.TabIndex = 16
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.ReadOnly = True
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'btnMinMinum
        '
        Me.btnMinMinum.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinMinum.Location = New System.Drawing.Point(719, 170)
        Me.btnMinMinum.Name = "btnMinMinum"
        Me.btnMinMinum.Size = New System.Drawing.Size(45, 45)
        Me.btnMinMinum.TabIndex = 18
        Me.btnMinMinum.Text = "-"
        Me.btnMinMinum.UseVisualStyleBackColor = True
        '
        'btnAddMinum
        '
        Me.btnAddMinum.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMinum.Location = New System.Drawing.Point(664, 170)
        Me.btnAddMinum.Name = "btnAddMinum"
        Me.btnAddMinum.Size = New System.Drawing.Size(45, 45)
        Me.btnAddMinum.TabIndex = 17
        Me.btnAddMinum.Text = "+"
        Me.btnAddMinum.UseVisualStyleBackColor = True
        '
        'btnPesan
        '
        Me.btnPesan.Location = New System.Drawing.Point(153, 285)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(75, 23)
        Me.btnPesan.TabIndex = 19
        Me.btnPesan.Text = "Pesan"
        Me.btnPesan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Pesanan"
        '
        'dgvMakan
        '
        Me.dgvMakan.AllowUserToAddRows = False
        Me.dgvMakan.AllowUserToDeleteRows = False
        Me.dgvMakan.AllowUserToResizeColumns = False
        Me.dgvMakan.AllowUserToResizeRows = False
        Me.dgvMakan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        Me.dgvMakan.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvMakan.Location = New System.Drawing.Point(17, 65)
        Me.dgvMakan.Name = "dgvMakan"
        Me.dgvMakan.ReadOnly = True
        Me.dgvMakan.RowHeadersVisible = False
        Me.dgvMakan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMakan.Size = New System.Drawing.Size(220, 150)
        Me.dgvMakan.TabIndex = 21
        '
        'Column2
        '
        Me.Column2.HeaderText = "No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 170
        '
        'dgvMinum
        '
        Me.dgvMinum.AllowUserToAddRows = False
        Me.dgvMinum.AllowUserToDeleteRows = False
        Me.dgvMinum.AllowUserToResizeColumns = False
        Me.dgvMinum.AllowUserToResizeRows = False
        Me.dgvMinum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMinum.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.dgvMinum.Location = New System.Drawing.Point(408, 65)
        Me.dgvMinum.Name = "dgvMinum"
        Me.dgvMinum.ReadOnly = True
        Me.dgvMinum.RowHeadersVisible = False
        Me.dgvMinum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMinum.Size = New System.Drawing.Size(220, 150)
        Me.dgvMinum.TabIndex = 22
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 170
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvMinum)
        Me.Controls.Add(Me.dgvMakan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnPesan)
        Me.Controls.Add(Me.btnMinMinum)
        Me.Controls.Add(Me.btnAddMinum)
        Me.Controls.Add(Me.dgvPesan)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnMinMakan)
        Me.Controls.Add(Me.btnAddMakan)
        Me.Controls.Add(Me.pbMinum)
        Me.Controls.Add(Me.pbMakan)
        Me.Controls.Add(Me.txtMeja)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbMakan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMinum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPesan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMakan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMinum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtMeja As TextBox
    Friend WithEvents pbMakan As PictureBox
    Friend WithEvents pbMinum As PictureBox
    Friend WithEvents btnAddMakan As Button
    Friend WithEvents btnMinMakan As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvPesan As DataGridView
    Friend WithEvents btnMinMinum As Button
    Friend WithEvents btnAddMinum As Button
    Friend WithEvents btnPesan As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents dgvMakan As DataGridView
    Friend WithEvents dgvMinum As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
