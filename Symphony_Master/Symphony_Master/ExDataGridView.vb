Public Class ExDataGridView
    Inherits DataGridView

    Private processFlg As Boolean = False

    Private editTextBox As DataGridViewTextBoxEditingControl

    Protected Overrides Function ProcessKeyEventArgs(ByRef m As System.Windows.Forms.Message) As Boolean
        Dim code As Integer = CInt(m.WParam)
        If code = Keys.Enter Then
            If processFlg = False Then
                processFlg = True
                Return True
            Else
                processFlg = False
                Me.BeginEdit(False)
                Return True
            End If
        ElseIf code = Keys.Back Then
            Me.BeginEdit(False)
            Return True
        Else
            Return MyBase.ProcessKeyEventArgs(m)
        End If

    End Function

    Protected Overrides Function ProcessDataGridViewKey(e As System.Windows.Forms.KeyEventArgs) As Boolean
        Dim tb As DataGridViewTextBoxEditingControl = CType(Me.EditingControl, DataGridViewTextBoxEditingControl)
        If Not IsNothing(tb) AndAlso ((e.KeyCode = Keys.Left AndAlso tb.SelectionStart = 0) OrElse (e.KeyCode = Keys.Right AndAlso tb.SelectionStart = tb.TextLength)) Then
            Return False
        Else
            Return MyBase.ProcessDataGridViewKey(e)
        End If
    End Function

    Private Sub ExDataGridView_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Me.EditingControlShowing
        editTextBox = CType(e.Control, DataGridViewTextBoxEditingControl)

        'イベントハンドラを削除、追加
        RemoveHandler editTextBox.PreviewKeyDown, AddressOf dataGridViewTextBox_PreviewKeyDown
        AddHandler editTextBox.PreviewKeyDown, AddressOf dataGridViewTextBox_PreviewKeyDown

    End Sub

    Private Sub dataGridViewTextBox_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.EndEdit()
            processFlg = False
        End If
    End Sub
    
End Class