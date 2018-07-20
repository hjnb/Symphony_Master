Public Class passForm

    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub cancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
        Me.Owner.Close()
    End Sub

    Private Sub okBtn_Click(sender As System.Object, e As System.EventArgs) Handles okBtn.Click
        Dim inputPass As String = passBox.Text
        Dim truePass As String = (Today.Month + Today.Day).ToString()
        If inputPass = truePass Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.Close()
            Me.Owner.Close()
        End If
    End Sub

    Private Sub passForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        passBox.Focus()
    End Sub
End Class