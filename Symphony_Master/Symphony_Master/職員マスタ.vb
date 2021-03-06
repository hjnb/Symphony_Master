﻿Imports System.Data.OleDb

''' <summary>
''' 職員マスタクラス
''' </summary>
''' <remarks></remarks>
Public Class 職員マスタ

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

    Private Sub 職員マスタ_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'テキストボックス設定
        settingTextBox()

        'dgv初期設定
        settingDgvStaff()

        'データ表示
        displayStaff()
    End Sub

    Private Sub 職員マスタ_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub 職員マスタ_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' 職員dgv表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayStaff()
        clearInputText()
        dgvStaff.DataSource = Nothing

        Dim cnn As New ADODB.Connection
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Id, Nam, Kana, Bush, Syok, Ryak, Zai, Dsp, Sei, Mei from StffM order by Kana"
        cnn.Open(TopForm.DB_MASTER)
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "StffM")
        dgvStaff.DataSource = ds.Tables(0)

        settingDgvStaffColumn()
        dgvStaff.CurrentRow.Selected = False
        idBox.Focus()
    End Sub

    ''' <summary>
    ''' 職員dgv初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub settingDgvStaff()
        'DoubleBufferedプロパティをTrue
        Util.EnableDoubleBuffering(dgvStaff)

        'dgv設定
        With dgvStaff
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
            .RowTemplate.Height = 17
            .ShowCellToolTips = False
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(155, 202, 239)
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
        End With
    End Sub

    ''' <summary>
    ''' 職員dgv幅、スタイル設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub settingDgvStaffColumn()
        With dgvStaff
            '並び替えができないようにする
            For Each c As DataGridViewColumn In .Columns
                c.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            '非表示列
            .Columns("Sei").Visible = False
            .Columns("Mei").Visible = False

            With .Columns("Id")
                .HeaderText = "ID"
                .Width = 29
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.Blue
                .DefaultCellStyle.SelectionForeColor = Color.Blue
            End With
            With .Columns("Nam")
                .HeaderText = "氏名"
                .Width = 85
            End With
            With .Columns("Kana")
                .HeaderText = "フリガナ"
                .Width = 95
            End With
            With .Columns("Bush")
                .HeaderText = "事業所名"
                .Width = 122
            End With
            With .Columns("Syok")
                .HeaderText = "職種"
                .Width = 103
            End With
            With .Columns("Ryak")
                .HeaderText = "略名"
                .Width = 55
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            With .Columns("Zai")
                .HeaderText = "在職"
                .Width = 35
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .HeaderCell.Style.Font = New Font("", 7.5)
            End With
            With .Columns("Dsp")
                .HeaderText = "表示"
                .Width = 35
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

        '事業所名ボックス
        officeNameBox.Items.AddRange({"社会福祉法人　禎人会", "特別養護老人ホーム", "ショートステイ", "ヘルパーステーション", "デイサービスセンター", "居宅介護支援事業所", "生活支援ハウス", "その他"})

        '職種ボックス
        jobBox.Items.AddRange({"施設長", "事務局長", "総務部長", "介護主任", "管理者", "経理事務", "サービス提供責任者", "生活相談員", "介護支援専門員", "介護員", "介護員（パート）", "訪問介護員", "看護師", "管理栄養士", "栄養士", "生活援助員", "宿直", "その他"})

        '並び替えボックス
        sortBox.Items.AddRange({"ID", "フリガナ", "事業所", "職種", "在籍", "表示"})

    End Sub

    ''' <summary>
    ''' 入力テキストクリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInputText()
        idBox.Text = ""
        lastnameBox.Text = ""
        firstnameBox.Text = ""
        kanaBox.Text = ""
        officeNameBox.Text = ""
        jobBox.Text = ""
        abbreviationNameBox.Text = ""
        lastnameCheckBox.Checked = True
        existCheckBox.Checked = True
        displayCheckBox.Checked = True
        sortBox.Text = ""
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
            targetColumn = dgvStaff.Columns("Id")
        ElseIf selectedText = "フリガナ" Then
            targetColumn = dgvStaff.Columns("Kana")
        ElseIf selectedText = "事業所" Then
            targetColumn = dgvStaff.Columns("Bush")
        ElseIf selectedText = "職種" Then
            targetColumn = dgvStaff.Columns("Syok")
        ElseIf selectedText = "在籍" Then
            targetColumn = dgvStaff.Columns("Zai")
        ElseIf selectedText = "表示" Then
            targetColumn = dgvStaff.Columns("Dsp")
        Else
            Return
        End If
        dgvStaff.Sort(targetColumn, System.ComponentModel.ListSortDirection.Ascending)
        dgvStaff.CurrentCell.Selected = False
    End Sub

    ''' <summary>
    ''' 職員dgvCellFormattingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvStaff_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvStaff.CellFormatting
        If dgvStaff.Columns(e.ColumnIndex).Name = "Dsp" OrElse dgvStaff.Columns(e.ColumnIndex).Name = "Zai" Then
            Dim cellVal As String = Util.checkDBNullValue(e.Value)
            If cellVal = "1" Then
                e.Value = "○"
            ElseIf cellVal = "0" Then
                e.Value = ""
            End If
            e.FormattingApplied = True
        ElseIf dgvStaff.Columns(e.ColumnIndex).Name = "Ryak" Then
            Dim cellVal As String = Util.checkDBNullValue(e.Value)
            If cellVal = "1" Then
                e.Value = Util.checkDBNullValue(dgvStaff("Sei", e.RowIndex).Value)
                e.FormattingApplied = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' 職員dgvセルマウスクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvStaff_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvStaff.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim id As String = Util.checkDBNullValue(dgvStaff("Id", e.RowIndex).Value)
            Dim lastname As String = Util.checkDBNullValue(dgvStaff("Sei", e.RowIndex).Value)
            Dim firstname As String = Util.checkDBNullValue(dgvStaff("Mei", e.RowIndex).Value)
            Dim kana As String = Util.checkDBNullValue(dgvStaff("Kana", e.RowIndex).Value)
            Dim office As String = Util.checkDBNullValue(dgvStaff("Bush", e.RowIndex).Value)
            Dim job As String = Util.checkDBNullValue(dgvStaff("Syok", e.RowIndex).Value)
            Dim abbreviationName As String = Util.checkDBNullValue(dgvStaff("Ryak", e.RowIndex).Value)
            Dim exist As String = Util.checkDBNullValue(dgvStaff("Zai", e.RowIndex).Value)
            Dim dsp As String = Util.checkDBNullValue(dgvStaff("Dsp", e.RowIndex).Value)

            idBox.Text = id
            lastnameBox.Text = lastname
            firstnameBox.Text = firstname
            kanaBox.Text = kana
            officeNameBox.Text = office
            jobBox.Text = job
            lastnameCheckBox.Checked = If(abbreviationName = "1", True, False)
            abbreviationNameBox.Text = If(abbreviationName = "1", "", abbreviationName)
            existCheckBox.Checked = If(exist = "1", True, False)
            displayCheckBox.Checked = If(dsp = "1", True, False)
            
        End If
    End Sub

    Private Sub dgvStaff_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvStaff.CellPainting
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
        Dim office As String = officeNameBox.Text
        If office = "" Then
            MsgBox("事業所を選択して下さい。")
            officeNameBox.Focus()
            Return
        End If
        Dim job As String = jobBox.Text
        If job = "" Then
            MsgBox("職種を選択して下さい。")
            jobBox.Focus()
            Return
        End If
        Dim abbreviationName As String = If(lastnameCheckBox.Checked, "1", abbreviationNameBox.Text) '略名
        If abbreviationName = "" Then
            MsgBox("略名を入力して下さい。")
            abbreviationNameBox.Focus()
            Return
        End If
        Dim exist As Integer = If(existCheckBox.Checked, 1, 0) '在職
        Dim dsp As Integer = If(displayCheckBox.Checked, 1, 0) '表示

        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_MASTER)
        Dim cmd As New ADODB.Command()
        cmd.ActiveConnection = cn
        Dim rs As New ADODB.Recordset
        Dim sql As String
        sql = "select id from StffM where id = " & id
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.RecordCount = 0 Then
            '新規登録
            cmd.CommandText = "insert into StffM (Id, Nam, Kana, Bush, Syok, Ryak, Zai, Dsp, Sei, Mei) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            cmd.Parameters.Refresh()
            cmd.Execute(Parameters:={id, nam, kana, office, job, abbreviationName, exist, dsp, lastname, firstname})
            cn.Close()

            '再表示
            displayStaff()
        Else
            '更新
            Dim result As DialogResult = MessageBox.Show("既に登録されています。上書きしますか？", "登録", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                cmd.CommandText = "update StffM set Nam=?, Kana=?, Bush=?, Syok=?, Ryak=?, Zai=?, Dsp=?, Sei=?, Mei=? where id=?"
                cmd.Parameters.Refresh()
                cmd.Execute(Parameters:={nam, kana, office, job, abbreviationName, exist, dsp, lastname, firstname, id})
                cn.Close()

                '再表示
                displayStaff()
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

        Dim result As DialogResult = MessageBox.Show("削除して宜しいですか？", "削除", MessageBoxButtons.YesNoCancel)
        If result = Windows.Forms.DialogResult.Yes Then
            Dim cn As New ADODB.Connection()
            cn.Open(TopForm.DB_MASTER)
            Dim cmd As New ADODB.Command()
            cmd.ActiveConnection = cn
            cmd.CommandText = "delete from StffM where id=?"
            cmd.Parameters.Refresh()
            cmd.Execute(Parameters:=id)
            cn.Close()

            '再表示
            displayStaff()
        End If
    End Sub
End Class