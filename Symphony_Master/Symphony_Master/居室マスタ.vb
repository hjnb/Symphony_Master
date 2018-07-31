Imports System.Data.OleDb

Public Class 居室マスタ

    '各家の部屋番号の行のセルスタイル
    Private roomNumRowCellStyleArray() As DataGridViewCellStyle

    '各家の家の名前列のセルスタイル
    Private houseNameColumnCellStyle As DataGridViewCellStyle

    '各家のID行のセルスタイル
    Private idRowCellStyle As DataGridViewCellStyle

    '各家の名前の行のセルスタイル
    Private nameRowCellStyle As DataGridViewCellStyle

    '居室表示用データテーブル
    Private dtRoom As DataTable = New DataTable()

    '部屋番号配列
    Private roomInitialArray() As String = {"1", "2", "3", "5", "6"}

    '家配列
    Private houseNameArray() As String = {"空", "森", "星", "月", "花"}

    '選択入居者名前保持用
    Private residentName As String = ""

    '選択入居者ID保持用
    Private residentId As Integer = 0

    Public Sub New()

        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

    End Sub

    Private Sub 居室マスタ_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dgvRoom.EndEdit()
        Me.Dispose()
    End Sub

    Private Sub 居室マスタ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'セルスタイル作成
        createCellStyle()

        'dgv初期設定
        settingDgvUser()
        initDgvRoom()

        '入居者リスト表示
        displayDgvUser()

        '居室表示
        displayDgvRoom()

    End Sub

    Private Sub displayDgvUser()
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Nam, Id, Kana, Dsp from UsrM where Dsp='1' order by Kana"
        cnn.Open(TopForm.DB_MASTER)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "UsrM")
        dgvUser.DataSource = ds.Tables(0)
        cnn.Close()

        settingDgvUserColumn()
        dgvUser.CurrentRow.Selected = False
    End Sub

    Private Sub displayDgvRoom()
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Gyo, Sora, Hosi, Mori, Tuki, Hana, Id1, Id2, Id3, Id4, Id5, Ymd from RmM order by Gyo"
        cnn.Open(TopForm.DB_MASTER)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)

        Dim columnNum As Integer = 1
        While Not rs.EOF
            dtRoom.Rows(1).Item("R" & columnNum) = rs.Fields("Sora").Value
            dtRoom.Rows(2).Item("R" & columnNum) = If(rs.Fields("Id1").Value = 0, "", rs.Fields("Id1").Value)
            dtRoom.Rows(4).Item("R" & columnNum) = rs.Fields("Mori").Value
            dtRoom.Rows(5).Item("R" & columnNum) = If(rs.Fields("Id2").Value = 0, "", rs.Fields("Id2").Value)
            dtRoom.Rows(7).Item("R" & columnNum) = rs.Fields("Hosi").Value
            dtRoom.Rows(8).Item("R" & columnNum) = If(rs.Fields("Id3").Value = 0, "", rs.Fields("Id3").Value)
            dtRoom.Rows(10).Item("R" & columnNum) = rs.Fields("Tuki").Value
            dtRoom.Rows(11).Item("R" & columnNum) = If(rs.Fields("Id4").Value = 0, "", rs.Fields("Id4").Value)
            dtRoom.Rows(13).Item("R" & columnNum) = rs.Fields("Hana").Value
            dtRoom.Rows(14).Item("R" & columnNum) = If(rs.Fields("Id5").Value = 0, "", rs.Fields("Id5").Value)
            ymdLabel.Text = rs.Fields("Ymd").Value

            rs.MoveNext()
            If columnNum = 3 OrElse columnNum = 8 Then
                columnNum += 2
            Else
                columnNum += 1
            End If
        End While
        cnn.Close()

    End Sub

    Private Sub createCellStyle()
        '各家の部屋番号行のセルスタイル
        Dim skyRowCellStyle, forestRowCellStyle, starRowCellStyle, moonRowCellStyle, flowerRowCellStyle As DataGridViewCellStyle

        '空の行
        skyRowCellStyle = New DataGridViewCellStyle()
        skyRowCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'skyRowCellStyle.Font = New Font("MS UI Gothic", 9)
        skyRowCellStyle.BackColor = Color.FromArgb(147, 220, 255)

        '森の行
        forestRowCellStyle = New DataGridViewCellStyle()
        forestRowCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'forestRowCellStyle.Font = New Font("MS UI Gothic", 9)
        forestRowCellStyle.BackColor = Color.FromArgb(23, 255, 139)

        '星の行
        starRowCellStyle = New DataGridViewCellStyle()
        starRowCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'starRowCellStyle.Font = New Font("MS UI Gothic", 9)
        starRowCellStyle.BackColor = Color.FromArgb(255, 255, 128)

        '月の行
        moonRowCellStyle = New DataGridViewCellStyle()
        moonRowCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'moonRowCellStyle.Font = New Font("MS UI Gothic", 9)
        moonRowCellStyle.BackColor = Color.FromArgb(255, 149, 98)

        '花の行
        flowerRowCellStyle = New DataGridViewCellStyle()
        flowerRowCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'flowerRowCellStyle.Font = New Font("MS UI Gothic", 9)
        flowerRowCellStyle.BackColor = Color.FromArgb(248, 129, 211)

        '
        roomNumRowCellStyleArray = {skyRowCellStyle, forestRowCellStyle, starRowCellStyle, moonRowCellStyle, flowerRowCellStyle}

        '家の名前列
        houseNameColumnCellStyle = New DataGridViewCellStyle()
        houseNameColumnCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        houseNameColumnCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
        houseNameColumnCellStyle.Font = New Font("MS UI Gothic", 9)

        'idの行
        idRowCellStyle = New DataGridViewCellStyle()
        idRowCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        idRowCellStyle.Font = New Font("MS UI Gothic", 7)
        idRowCellStyle.ForeColor = Color.FromArgb(211, 211, 211)
        idRowCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
        idRowCellStyle.SelectionForeColor = Color.FromArgb(211, 211, 211)

        '
        nameRowCellStyle = New DataGridViewCellStyle()
        nameRowCellStyle.Font = New Font("MS UI Gothic", 8)
    End Sub

    Private Sub clearText()
        'dgvの名前、IDを空にする
        For i As Integer = 0 To 14
            If i Mod 3 <> 0 Then
                For j As Integer = 1 To 12
                    If j = 4 OrElse j = 9 Then
                        j += 1
                    End If
                    dgvRoom.Rows(i).Cells("R" & j).Value = ""
                Next
            End If
        Next

        '更新日テキストを空にする
        ymdLabel.Text = ""

    End Sub

    Private Sub initDgvRoom()
        'dgv設定
        settingDgvRoom()

        '列追加
        dtRoom.Columns.Add("House", Type.GetType("System.String"))
        For i As Integer = 1 To 12
            If i = 4 OrElse i = 9 Then
                i += 1
            End If
            dtRoom.Columns.Add("R" & i, Type.GetType("System.String"))
        Next

        '行追加
        Dim row As DataRow
        For i As Integer = 0 To 14
            row = dtRoom.NewRow()
            If i Mod 3 = 0 Then
                '部屋番号
                row("R1") = roomInitialArray(i / 3) & "01"
                row("R2") = roomInitialArray(i / 3) & "02"
                row("R3") = roomInitialArray(i / 3) & "03"
                row("R5") = roomInitialArray(i / 3) & "05"
                row("R6") = roomInitialArray(i / 3) & "06"
                row("R7") = roomInitialArray(i / 3) & "07"
                row("R8") = roomInitialArray(i / 3) & "08"
                row("R10") = roomInitialArray(i / 3) & "10"
                row("R11") = roomInitialArray(i / 3) & "11"
                row("R12") = roomInitialArray(i / 3) & "12"
            ElseIf i Mod 3 = 1 Then
                row("House") = houseNameArray(i / 3) & "の家"
            End If
            dtRoom.Rows.Add(row)
        Next

        '表示
        dgvRoom.DataSource = dtRoom

        '列、行のスタイル設定等
        settingDgvRoomColumn()

        '空にする（空文字セット）
        clearText()

        'セル選択解除
        dgvRoom.CurrentCell.Selected = False

    End Sub

    Private Sub settingDgvUser()
        'DoubleBufferedプロパティをTrue
        Util.EnableDoubleBuffering(dgvUser)

        'dgv設定
        With dgvUser
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect 'クリック時に行選択
            .MultiSelect = False
            .ReadOnly = True
            .ColumnHeadersVisible = False
            .RowHeadersVisible = False
            .RowTemplate.Height = 16
            .ShowCellToolTips = False
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 202, 239)
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
        End With
    End Sub

    Private Sub settingDgvRoom()
        'DoubleBufferedプロパティをTrue
        Util.EnableDoubleBuffering(dgvRoom)

        'dgv設定
        With dgvRoom
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .MultiSelect = False
            .ColumnHeadersVisible = False
            .RowHeadersVisible = False
            .RowTemplate.Height = 16
            .ShowCellToolTips = False
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .GridColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub

    Private Sub settingDgvUserColumn()
        With dgvUser
            '非表示列
            .Columns("Id").Visible = False
            .Columns("Kana").Visible = False
            .Columns("Dsp").Visible = False

            With .Columns("Nam")
                .Width = 81
            End With
        End With
    End Sub

    Private Sub settingDgvRoomColumn()
        With dgvRoom
            With .Columns("House")
                .Width = 60
            End With
            For i As Integer = 1 To 12
                If i = 4 OrElse i = 9 Then
                    i += 1
                End If
                .Columns("R" & i).Width = 65
            Next
        End With

        For i As Integer = 0 To dgvRoom.Rows.Count - 1
            If i Mod 3 = 0 Then
                '部屋番号行の設定
                dgvRoom.Rows(i).DefaultCellStyle = roomNumRowCellStyleArray(i / 3)
                dgvRoom.Rows(i).Cells("House").Style = houseNameColumnCellStyle
                dgvRoom.Rows(i).ReadOnly = True
            ElseIf i Mod 3 = 1 Then
                '家、名前行の設定
                dgvRoom.Rows(i).Height = 32
                dgvRoom.Rows(i).DefaultCellStyle = nameRowCellStyle
                dgvRoom.Rows(i).Cells("House").Style = houseNameColumnCellStyle
                dgvRoom.Rows(i).Cells("House").ReadOnly = True
            ElseIf i Mod 3 = 2 Then
                'ID行の設定
                dgvRoom.Rows(i).DefaultCellStyle = idRowCellStyle
                dgvRoom.Rows(i).ReadOnly = True
            End If
        Next
    End Sub

    Private Sub dgvRoom_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvRoom.CellMouseClick
        If e.RowIndex Mod 3 = 1 Then
            If residentName = "" Then
                Return
            End If
            dgvRoom(e.ColumnIndex, e.RowIndex).Value = residentName
            dgvRoom(e.ColumnIndex, e.RowIndex + 1).Value = residentId
        End If
    End Sub

    Private Sub dgvRoom_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvRoom.CellPainting
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 AndAlso (e.PaintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
            e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)

            If (e.PaintParts And DataGridViewPaintParts.SelectionBackground) = DataGridViewPaintParts.SelectionBackground AndAlso (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                e.Graphics.DrawRectangle(New Pen(Color.Black, 2I), e.CellBounds.X + 1I, e.CellBounds.Y + 1I, e.CellBounds.Width - 3I, e.CellBounds.Height - 3I)
            End If

            Dim pParts As DataGridViewPaintParts = e.PaintParts And Not DataGridViewPaintParts.Background
            e.Paint(e.ClipBounds, pParts)
            e.Handled = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clearText()
    End Sub

    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        cnn.Open(TopForm.DB_MASTER)
        Dim sql As String = "select Gyo, Sora, Hosi, Mori, Tuki, Hana, Id1, Id2, Id3, Id4, Id5, Ymd from RmM order by Gyo"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

        If rs.RecordCount <> 10 Then
            '新規登録
            Dim result As DialogResult = MessageBox.Show("新規登録してよろしいですか？", "登録", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                'データを削除する
                Dim cmd As New ADODB.Command()
                cmd.ActiveConnection = cnn
                cmd.CommandText = "delete from RmM"
                cmd.Execute()

                'レコードセットに追加、登録
                Dim ymd As String = Today.ToString("yyyy/MM/dd")
                Dim rowCount As Integer = 1
                For i As Integer = 1 To 12
                    If i = 4 OrElse i = 9 Then
                        i += 1
                    End If
                    rs.AddNew()
                    rs.Fields("Gyo").Value = rowCount
                    rs.Fields("Sora").Value = dtRoom.Rows(1).Item("R" & i)
                    rs.Fields("Id1").Value = If(Util.checkDBNullValue(dtRoom.Rows(1).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(2).Item("R" & i)) = "", 0, dtRoom.Rows(2).Item("R" & i)))
                    rs.Fields("Mori").Value = dtRoom.Rows(4).Item("R" & i)
                    rs.Fields("Id2").Value = If(Util.checkDBNullValue(dtRoom.Rows(4).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(5).Item("R" & i)) = "", 0, dtRoom.Rows(5).Item("R" & i)))
                    rs.Fields("Hosi").Value = dtRoom.Rows(7).Item("R" & i)
                    rs.Fields("Id3").Value = If(Util.checkDBNullValue(dtRoom.Rows(7).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(8).Item("R" & i)) = "", 0, dtRoom.Rows(8).Item("R" & i)))
                    rs.Fields("Tuki").Value = dtRoom.Rows(10).Item("R" & i)
                    rs.Fields("Id4").Value = If(Util.checkDBNullValue(dtRoom.Rows(10).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(11).Item("R" & i)) = "", 0, dtRoom.Rows(11).Item("R" & i)))
                    rs.Fields("Hana").Value = dtRoom.Rows(13).Item("R" & i)
                    rs.Fields("Id5").Value = If(Util.checkDBNullValue(dtRoom.Rows(13).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(14).Item("R" & i)) = "", 0, dtRoom.Rows(14).Item("R" & i)))
                    rs.Fields("Ymd").Value = ymd
                    If i <> 12 Then
                        rs.MoveNext()
                        rowCount += 1
                    End If
                Next
                rs.Update()
                cnn.Close()

                '再表示
                clearText()
                displayDgvRoom()
            End If
        Else
            Dim result As DialogResult = MessageBox.Show("既に登録されています。上書きしますか？", "登録", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                'レコードセットのデータ更新
                Dim ymd As String = Today.ToString("yyyy/MM/dd")
                For i As Integer = 1 To 12
                    If i = 4 OrElse i = 9 Then
                        i += 1
                    End If
                    rs.Fields("Sora").Value = dtRoom.Rows(1).Item("R" & i)
                    rs.Fields("Id1").Value = If(Util.checkDBNullValue(dtRoom.Rows(1).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(2).Item("R" & i)) = "", 0, dtRoom.Rows(2).Item("R" & i)))
                    rs.Fields("Mori").Value = dtRoom.Rows(4).Item("R" & i)
                    rs.Fields("Id2").Value = If(Util.checkDBNullValue(dtRoom.Rows(4).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(5).Item("R" & i)) = "", 0, dtRoom.Rows(5).Item("R" & i)))
                    rs.Fields("Hosi").Value = dtRoom.Rows(7).Item("R" & i)
                    rs.Fields("Id3").Value = If(Util.checkDBNullValue(dtRoom.Rows(7).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(8).Item("R" & i)) = "", 0, dtRoom.Rows(8).Item("R" & i)))
                    rs.Fields("Tuki").Value = dtRoom.Rows(10).Item("R" & i)
                    rs.Fields("Id4").Value = If(Util.checkDBNullValue(dtRoom.Rows(10).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(11).Item("R" & i)) = "", 0, dtRoom.Rows(11).Item("R" & i)))
                    rs.Fields("Hana").Value = dtRoom.Rows(13).Item("R" & i)
                    rs.Fields("Id5").Value = If(Util.checkDBNullValue(dtRoom.Rows(13).Item("R" & i)) = "", 0, If(Util.checkDBNullValue(dtRoom.Rows(14).Item("R" & i)) = "", 0, dtRoom.Rows(14).Item("R" & i)))
                    rs.Fields("Ymd").Value = ymd
                    If i <> 12 Then
                        rs.MoveNext()
                    End If
                Next
                rs.Update()
                cnn.Close()

                '再表示
                clearText()
                displayDgvRoom()
            End If
        End If

    End Sub

    Private Sub dgvUser_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvUser.CellMouseClick
        If e.RowIndex >= 0 Then
            residentName = Util.checkDBNullValue(dgvUser("Nam", e.RowIndex).Value)
            residentId = If(Util.checkDBNullValue(dgvUser("Id", e.RowIndex).Value) = "", 0, dgvUser("Id", e.RowIndex).Value)
        End If
    End Sub
End Class