Imports System.Data.OleDb

''' <summary>
''' 入居者マスタクラス
''' </summary>
''' <remarks></remarks>
Public Class 入居者マスタ
    '行ヘッダーのカレントセルを表す三角マークを非表示に設定する為のクラス。
    Public Class dgvRowHeaderCell

        'DataGridViewRowHeaderCell を継承
        Inherits DataGridViewRowHeaderCell

        'DataGridViewHeaderCell.Paint をオーバーライドして行ヘッダーを描画
        Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, _
           ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, _
           ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, _
           ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
           ByVal paintParts As DataGridViewPaintParts)
            '標準セルの描画からセル内容の背景だけ除いた物を描画(-5)
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, _
                     formattedValue, errorText, cellStyle, advancedBorderStyle, _
                     Not DataGridViewPaintParts.ContentBackground)
        End Sub

    End Class

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()

        Me.KeyPreview = True

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    ''' <summary>
    ''' 入居者マスタloadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 入居者マスタ_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'テキストボックス設定
        settingTextBox()

        'dgv初期設定
        settingDgvResident()

        'データ表示
        displayResident()
    End Sub

    Private Sub 入居者マスタ_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub 入居者マスタ_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' 入居者dgv表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayResident()
        clearInputText()
        dgvResident.DataSource = Nothing
        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Id, Nam, Sei, Mei, Kana, Unit, Dsp from UsrM order by Kana"
        cnn.Open(TopForm.DB_MASTER)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "UsrM")
        dgvResident.DataSource = ds.Tables(0)

        settingDgvResidentColumn()
        dgvResident.CurrentRow.Selected = False
        idBox.Focus()
    End Sub

    ''' <summary>
    ''' 入居者dgv初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub settingDgvResident()
        'DoubleBufferedプロパティをTrue
        Util.EnableDoubleBuffering(dgvResident)

        'dgv設定
        With dgvResident
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect 'クリック時に行選択
            .MultiSelect = False
            .ReadOnly = True
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .EnableHeadersVisualStyles = False
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 20
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 224, 177)
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .RowHeadersWidth = 30
            .RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(228, 236, 247)
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 202, 239)
            .RowTemplate.Height = 16
            .ShowCellToolTips = False
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 202, 239)
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
        End With
    End Sub

    ''' <summary>
    ''' 入居者dgv列、行設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub settingDgvResidentColumn()
        With dgvResident
            '並び替えができないようにする
            For Each c As DataGridViewColumn In .Columns
                c.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            '非表示列
            .Columns("Sei").Visible = False
            .Columns("Mei").Visible = False

            With .Columns("Id")
                .HeaderText = "ID"
                .Width = 45
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.Blue
                .DefaultCellStyle.SelectionForeColor = Color.Blue
            End With
            With .Columns("Nam")
                .HeaderText = "入居者名"
                .Width = 95
            End With
            With .Columns("Kana")
                .HeaderText = "フリガナ"
                .Width = 110
            End With
            With .Columns("Unit")
                .HeaderText = "ﾕﾆｯﾄ"
                .Width = 33
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            With .Columns("Dsp")
                .HeaderText = "表示"
                .Width = 33
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .HeaderCell.Style.Font = New Font("", 7.5)
            End With
        End With
    End Sub

    ''' <summary>
    ''' 入力テキストボックス設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub settingTextBox()
        'ID
        idBox.ImeMode = Windows.Forms.ImeMode.Disable
        idBox.ForeColor = Color.Blue
        idBox.BackColor = Color.FromKnownColor(KnownColor.Control)
        idBox.TextAlign = HorizontalAlignment.Center

        '姓
        lastnameBox.ImeMode = Windows.Forms.ImeMode.Hiragana

        '名
        firstnameBox.ImeMode = Windows.Forms.ImeMode.Hiragana

        'フリガナ
        kanaBox.ImeMode = Windows.Forms.ImeMode.Katakana

        'ユニットボックス
        unitBox.Items.AddRange({"空", "星", "森", "花", "月", "海"})

        '並び替えボックス
        sortBox.Items.AddRange({"ID", "フリガナ", "ユニット", "表示"})

    End Sub

    ''' <summary>
    ''' 入力テキストクリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInputText()
        sortBox.Text = ""
        idBox.Text = ""
        lastnameBox.Text = ""
        firstnameBox.Text = ""
        kanaBox.Text = ""
        unitBox.Text = ""
        displayCheckBox.Checked = True
    End Sub

    ''' <summary>
    ''' 入居者dgvセルフォーマットイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvResident_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvResident.CellFormatting
        '表示列の値表示変更
        If dgvResident.Columns(e.ColumnIndex).Name = "Dsp" Then
            Dim cellVal As String = Util.checkDBNullValue(e.Value)
            If cellVal = "1" Then
                e.Value = "○"
            ElseIf cellVal = "0" Then
                e.Value = ""
            End If
            e.FormattingApplied = True
        End If
    End Sub

    ''' <summary>
    ''' 入居者dgvセルマウスクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvResident_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvResident.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim id As String = Util.checkDBNullValue(dgvResident("Id", e.RowIndex).Value)
            Dim nam As String = Util.checkDBNullValue(dgvResident("Nam", e.RowIndex).Value)
            Dim kana As String = Util.checkDBNullValue(dgvResident("Kana", e.RowIndex).Value)
            Dim unit As String = Util.checkDBNullValue(dgvResident("Unit", e.RowIndex).Value)
            Dim dsp As String = Util.checkDBNullValue(dgvResident("Dsp", e.RowIndex).Value)

            idBox.Text = id
            kanaBox.Text = kana
            unitBox.Text = unit
            If dsp = "1" Then
                displayCheckBox.Checked = True
            Else
                displayCheckBox.Checked = False
            End If
            lastnameBox.Text = nam.Split(" ")(0)
            firstnameBox.Text = nam.Split(" ")(1)
        End If
    End Sub

    Private Sub dgvResident_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvResident.CellPainting
        '行ヘッダーかどうか調べる
        If e.ColumnIndex < 0 AndAlso e.RowIndex >= 0 Then
            'セルを描画する
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

            '行番号を描画する範囲を決定する
            'e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
            Dim indexRect As Rectangle = e.CellBounds
            indexRect.Inflate(-2, -2)
            '行番号を描画する
            TextRenderer.DrawText(e.Graphics, _
                (e.RowIndex + 1).ToString(), _
                e.CellStyle.Font, _
                indexRect, _
                e.CellStyle.ForeColor, _
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            '描画が完了したことを知らせる
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' 並び替えボックスSelectedValueChangedイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub sortBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles sortBox.SelectedValueChanged
        Dim targetColumn As DataGridViewColumn
        Dim selectedText As String = sortBox.Text
        If selectedText = "ID" Then
            targetColumn = dgvResident.Columns("Id")
        ElseIf selectedText = "フリガナ" Then
            targetColumn = dgvResident.Columns("Kana")
        ElseIf selectedText = "ユニット" Then
            targetColumn = dgvResident.Columns("Unit")
        ElseIf selectedText = "表示" Then
            targetColumn = dgvResident.Columns("Dsp")
        Else
            Return
        End If
        dgvResident.Sort(targetColumn, System.ComponentModel.ListSortDirection.Ascending)
        dgvResident.CurrentCell.Selected = False
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        Dim id As Integer = If(IsNumeric(idBox.Text) AndAlso CInt(idBox.Text) > 0, CInt(idBox.Text), -1) 'ID
        If id = -1 Then
            MsgBox("IDは1以上の数値で指定して下さい。")
            idBox.Focus()
            Return
        End If
        Dim lastname As String = lastnameBox.Text '姓
        If lastname = "" Then
            MsgBox("漢字（姓）を入力して下さい。")
            lastnameBox.Focus()
            Return
        End If
        Dim firstname As String = firstnameBox.Text '名
        If firstname = "" Then
            MsgBox("漢字（名）を入力して下さい。")
            firstnameBox.Focus()
            Return
        End If
        Dim nam As String = lastname & " " & firstname '名前
        Dim kana As String = kanaBox.Text 'フリガナ
        If kana = "" Then
            MsgBox("フリガナを入力して下さい。")
            kanaBox.Focus()
            Return
        End If
        Dim unit As String = unitBox.Text
        If unit = "" Then
            MsgBox("ユニットを選択して下さい。")
            unitBox.Focus()
            Return
        End If
        Dim dsp As Integer = If(displayCheckBox.Checked, 1, 0) '表示

        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_MASTER)
        Dim cmd As New ADODB.Command()
        cmd.ActiveConnection = cn
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "select id from UsrM where id = " & id
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.RecordCount = 0 Then
            '新規登録
            cmd.CommandText = "insert into UsrM (Id, Nam, Kana, Unit, Dsp) values (?, ?, ?, ?, ?)"
            cmd.Parameters.Refresh()
            cmd.Execute(Parameters:={id, nam, kana, unit, dsp})
            cn.Close()

            '再表示
            displayResident()
        Else
            '更新
            Dim result As DialogResult = MessageBox.Show("既に登録されています。上書きしますか？", "登録", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "update UsrM set Nam=?, Kana=?, Unit=?, Dsp=? where id=?"
                cmd.Parameters.Refresh()
                cmd.Execute(Parameters:={nam, kana, unit, dsp, id})
                cn.Close()

                '再表示
                displayResident()
            Else
                cn.Close()
            End If
        End If

    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim id As Integer = If(IsNumeric(idBox.Text) AndAlso CInt(idBox.Text) > 0, CInt(idBox.Text), -1) 'ID
        If id = -1 Then
            MsgBox("対象者を選択して下さい。")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("マスタから削除して宜しいですか？※非表示設定等で対応できる場合があります。", "削除", MessageBoxButtons.YesNoCancel)
        If result = Windows.Forms.DialogResult.Yes Then
            Dim cn As New ADODB.Connection()
            cn.Open(TopForm.DB_MASTER)
            Dim cmd As New ADODB.Command()
            cmd.ActiveConnection = cn
            cmd.CommandText = "delete from UsrM where id=?"
            cmd.Parameters.Refresh()
            cmd.Execute(Parameters:=id)
            cn.Close()

            '再表示
            displayResident()
        End If
    End Sub
End Class