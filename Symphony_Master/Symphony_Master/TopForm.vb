''' <summary>
''' トップフォームクラス
''' </summary>
''' <remarks></remarks>
Public Class TopForm

    'データベースのパス
    Public dbFilePath As String = My.Application.Info.DirectoryPath & "\MstrMngr.mdb"
    Public DB_MASTER As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFilePath

    'フォーム
    Private residentForm As 入居者マスタ
    Private staffForm As 職員マスタ
    Private roomForm As 居室マスタ
    Private passForm As passForm

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    ''' <summary>
    ''' トップフォームloadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TopForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データベースファイルの存在チェック
        If Not System.IO.File.Exists(dbFilePath) Then
            MsgBox("データベースファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' 入居者ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub residentBtn_Click(sender As System.Object, e As System.EventArgs) Handles residentBtn.Click
        If IsNothing(residentForm) OrElse residentForm.IsDisposed Then
            residentForm = New 入居者マスタ()
            residentForm.Owner = Me
            residentForm.ShowDialog()
        End If
    End Sub

    ''' <summary>
    ''' 職員ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub staffBtn_Click(sender As System.Object, e As System.EventArgs) Handles staffBtn.Click
        If IsNothing(passForm) OrElse passForm.IsDisposed Then
            passForm = New passForm()
            passForm.Owner = Me
            Dim result As DialogResult = passForm.ShowDialog()
            passForm = Nothing
            If result = Windows.Forms.DialogResult.OK Then
                staffForm = New 職員マスタ()
                staffForm.Owner = Me
                staffForm.ShowDialog()
            End If
        End If
    End Sub

    ''' <summary>
    ''' 居室ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub roomBtn_Click(sender As System.Object, e As System.EventArgs) Handles roomBtn.Click
        If IsNothing(roomForm) OrElse roomForm.IsDisposed Then
            roomForm = New 居室マスタ()
            roomForm.Owner = Me
            roomForm.ShowDialog()
        End If
    End Sub

    ''' <summary>
    ''' 終了ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub exitBtn_Click(sender As System.Object, e As System.EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class