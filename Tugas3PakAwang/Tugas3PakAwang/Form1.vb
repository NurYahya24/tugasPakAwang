Imports System.IO

Public Class Form1
    Dim tot As Integer
    Dim kondisi As Boolean
    Dim pathM = CurDir() & "\pics\makan\"
    Dim pathN = CurDir() & "\pics\minum\"
    Dim no As Integer = 0
    Dim pathMakan = My.Computer.FileSystem.GetFiles(pathM, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
    Dim pathMinum = My.Computer.FileSystem.GetFiles(pathN, FileIO.SearchOption.SearchTopLevelOnly, "*.jpg")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buttonMinumEnabled()
        Call buttonMakanEnabled()
        For Each namaMakan As String In pathMakan
            no += 1
            Dim result As String = Path.GetFileNameWithoutExtension(namaMakan)
            dgvMakan.Rows.Add(New String() {no, result})
        Next
        no = 0
        For Each namaMinum As String In pathMinum
            no += 1
            Dim result As String = Path.GetFileNameWithoutExtension(namaMinum)
            dgvMinum.Rows.Add(New String() {no, result})
        Next
        If dgvPesan.RowCount > -1 And dgvPesan.SelectionMode <> DataGridViewSelectionMode.CellSelect Then
            dgvPesan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Sub hitung()
        tot = 0
        For indeks As Integer = 0 To dgvPesan.RowCount - 1
            tot += dgvPesan.Rows(indeks).Cells(3).Value
        Next
        txtTotal.Text = "Rp." & tot
    End Sub

    Sub cekDataKosong()
        If txtNama.Text = "" Then
            MessageBox.Show("Nama Harus Diisi", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            kondisi = False
        ElseIf txtMeja.Text = "" Then
            MessageBox.Show("Meja Harus Diisi", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMeja.Focus()
            kondisi = False
        ElseIf txtTotal.Text = "" Or txtTotal.Text = "Rp.0" Then
            MessageBox.Show("Belum Ada Item", "WARNING",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            kondisi = False
        End If
    End Sub

    Sub buttonMakanEnabled()
        Dim ada As Boolean = False
        For Each itm As DataGridViewRow In dgvPesan.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(0).Value.ToString = dgvMakan.CurrentRow.Cells(1).Value Then
                    ada = True
                End If
            End If
        Next
        If Not ada Then
            btnMinMakan.Enabled = False
        Else
            btnMinMakan.Enabled = True
        End If
        For Each row As DataGridViewRow In dgvPesan.Rows
            If row.Cells.Item("Qty").Value = "0" Then
                dgvPesan.Rows.Remove(row)
            End If
        Next
    End Sub
    Sub buttonMinumEnabled()
        Dim ada As Boolean = False
        For Each itm As DataGridViewRow In dgvPesan.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(0).Value.ToString = dgvMinum.CurrentRow.Cells(1).Value Then
                    ada = True
                End If
            End If
        Next
        If Not ada Then
            btnMinMinum.Enabled = False
        Else
            btnMinMinum.Enabled = True
        End If
        For Each row As DataGridViewRow In dgvPesan.Rows
            If row.Cells.Item("Qty").Value = "0" Then
                dgvPesan.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub btnAddMakan_Click(sender As Object, e As EventArgs) Handles btnAddMakan.Click
        Dim hs As Integer
        Dim ada As Boolean = False, numrow As Integer, numtext As Integer
        If dgvMakan.CurrentRow.Cells(1).Value = "Ayam Penyet" Then
            hs = 12000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Bakso" Then
            hs = 15000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Coto Makassar" Then
            hs = 17000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Gado Gado" Then
            hs = 10000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Lontong Sayur" Then
            hs = 12000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Nasi Cumi Hitam Madura Pak Kris" Then
            hs = 55000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Nasi Goreng" Then
            hs = 14000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Rawon" Then
            hs = 20000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Sate" Then
            hs = 15000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Soto Ayam" Then
            hs = 18000
        End If
        For Each itm As DataGridViewRow In dgvPesan.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(0).Value.ToString = dgvMakan.CurrentRow.Cells(1).Value Then
                    ada = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(1).Value)
                End If
            End If
        Next
        If ada = False Then
            dgvPesan.Rows.Add(New String() {dgvMakan.CurrentRow.Cells(1).Value, 1, hs, hs})
        Else
            dgvPesan.Rows(numrow).Cells(3).Value += hs
            dgvPesan.Rows(numrow).Cells(1).Value = 1 + numtext
        End If
        Call buttonMakanEnabled()
        Call hitung()
    End Sub
    Private Sub btnAddMinum_Click(sender As Object, e As EventArgs) Handles btnAddMinum.Click
        Dim hs As Integer
        Dim ada As Boolean = False, numrow As Integer, numtext As Integer

        If dgvMinum.CurrentRow.Cells(1).Value = "Air Putih" Then
            hs = 1000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Boba Ice Tea" Then
            hs = 8000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Cendol" Then
            hs = 6000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Jeruk" Then
            hs = 5000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Kelapa" Then
            hs = 6000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Susu" Then
            hs = 5000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Teh" Then
            hs = 3000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Kopi Hitam" Then
            hs = 4000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Milo Ais" Then
            hs = 5000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Wedang Jahe" Then
            hs = 4000
        End If
        For Each itm As DataGridViewRow In dgvPesan.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(0).Value.ToString = dgvMinum.CurrentRow.Cells(1).Value Then
                    ada = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(1).Value)
                End If
            End If
        Next
        If ada = False Then
            dgvPesan.Rows.Add(New String() {dgvMinum.CurrentRow.Cells(1).Value, 1, hs, hs})
        Else
            dgvPesan.Rows(numrow).Cells(3).Value += hs
            dgvPesan.Rows(numrow).Cells(1).Value = 1 + numtext
        End If
        Call buttonMinumEnabled()
        Call hitung()
    End Sub




    Private Sub btnMinMakan_Click(sender As Object, e As EventArgs) Handles btnMinMakan.Click
        Dim hs As Integer
        Dim ada As Boolean = False, numrow As Integer, numtext As Integer
        If dgvMakan.CurrentRow.Cells(1).Value = "Ayam Penyet" Then
            hs = 12000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Bakso" Then
            hs = 15000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Coto Makassar" Then
            hs = 17000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Gado Gado" Then
            hs = 10000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Lontong Sayur" Then
            hs = 12000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Nasi Cumi Hitam Madura Pak Kris" Then
            hs = 55000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Nasi Goreng" Then
            hs = 14000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Rawon" Then
            hs = 20000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Sate" Then
            hs = 15000
        ElseIf dgvMakan.CurrentRow.Cells(1).Value = "Soto Ayam" Then
            hs = 18000
        End If


        For Each itm As DataGridViewRow In dgvPesan.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(0).Value.ToString = dgvMakan.CurrentRow.Cells(1).Value Then
                    ada = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(1).Value)
                End If
            End If
        Next
        If ada Then
            dgvPesan.Rows(numrow).Cells(3).Value -= hs
            dgvPesan.Rows(numrow).Cells(1).Value -= 1
        End If
        Call buttonMakanEnabled()
        Call buttonMakanEnabled()
        Call hitung()
    End Sub
    Private Sub btnMinMinum_Click(sender As Object, e As EventArgs) Handles btnMinMinum.Click
        Dim hs As Integer
        Dim ada As Boolean = False, numrow As Integer, numtext As Integer
        If dgvMinum.CurrentRow.Cells(1).Value = "Air Putih" Then
            hs = 1000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Boba Ice Tea" Then
            hs = 8000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Cendol" Then
            hs = 6000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Jeruk" Then
            hs = 5000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Kelapa" Then
            hs = 6000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Susu" Then
            hs = 5000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Es Teh" Then
            hs = 3000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Kopi Hitam" Then
            hs = 4000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Milo Ais" Then
            hs = 5000
        ElseIf dgvMinum.CurrentRow.Cells(1).Value = "Wedang Jahe" Then
            hs = 4000
        End If
        For Each itm As DataGridViewRow In dgvPesan.Rows
            If itm.Cells(0).Value IsNot Nothing Then
                If itm.Cells(0).Value.ToString = dgvMinum.CurrentRow.Cells(1).Value Then
                    ada = True
                    numrow = itm.Index
                    numtext = CInt(itm.Cells(1).Value)
                End If
            End If
        Next
        If ada Then
            dgvPesan.Rows(numrow).Cells(3).Value -= hs
            dgvPesan.Rows(numrow).Cells(1).Value -= 1
        Else

        End If
        Call buttonMinumEnabled()
        Call buttonMinumEnabled()
        Call hitung()
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        kondisi = True
        Dim sourceGrid As DataGridView = Me.dgvPesan
        Dim targetGrid As DataGridView = Form2.dgvDetil
        Dim targetRows = New List(Of DataGridViewRow)
        For Each sourceRow As DataGridViewRow In sourceGrid.Rows
            If (Not sourceRow.IsNewRow) Then
                Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
                For Each cell As DataGridViewCell In sourceRow.Cells
                    targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                Next
                targetRows.Add(targetRow)
            End If
        Next
        targetGrid.Columns.Clear()
        For Each column As DataGridViewColumn In sourceGrid.Columns
            targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
        Next
        targetGrid.Rows.AddRange(targetRows.ToArray())
        Form2.lbNama.Text = txtNama.Text
        Form2.lbMeja.Text = txtMeja.Text
        Form2.lbTotal.Text = txtTotal.Text
        Call cekDataKosong()
        If kondisi Then
            Form2.Show()
        End If


    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim del As String
        If dgvPesan.SelectedRows.Count > 0 Then
            del = MessageBox.Show("Hapus Item ?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If del = MsgBoxResult.Yes Then
                dgvPesan.Rows.Remove(dgvPesan.SelectedRows(0))
            Else

            End If
        Else
            MessageBox.Show("Tidak Ada Item")
        End If
        Call hitung()
        Call buttonMakanEnabled()
        Call buttonMinumEnabled()
    End Sub

    Private Sub dgvPesan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPesan.CellClick
        If e.RowIndex > -1 And dgvPesan.SelectionMode <> DataGridViewSelectionMode.CellSelect Then
            dgvPesan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Private Sub dgvMakan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakan.CellContentClick

    End Sub
    Private Sub dgvMakan_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMakan.SelectionChanged
        Call buttonMakanEnabled()
        If dgvMakan.SelectedRows IsNot Nothing Then
            pbMakan.Image = Image.FromFile(pathM.ToString() & dgvMakan.CurrentRow.Cells(1).Value & ".jpg")
        End If
    End Sub

    Private Sub dgvMinum_SelectionChanged(sender As Object, e As EventArgs) Handles dgvMinum.SelectionChanged
        Call buttonMinumEnabled()
        If dgvMinum.SelectedRows IsNot Nothing Then
            pbMinum.Image = Image.FromFile(pathN.ToString() & dgvMinum.CurrentRow.Cells(1).Value & ".jpg")
        End If
    End Sub
End Class
