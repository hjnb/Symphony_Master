Public Class passForm

    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
    End Sub

    Private Sub cancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub okBtn_Click(sender As System.Object, e As System.EventArgs) Handles okBtn.Click
        Dim inputPass As String = passBox.Text
        Dim truePass As String = (Today.Month + Today.Day).ToString()
        If inputPass = truePass Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub passForm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    Private Sub passForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ActiveControl = passBox
    End Sub
End Class