<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.passBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "パスワードを入力して下さい。"
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(271, 12)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(60, 23)
        Me.okBtn.TabIndex = 1
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(271, 41)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(60, 23)
        Me.cancelBtn.TabIndex = 2
        Me.cancelBtn.Text = "キャンセル"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'passBox
        '
        Me.passBox.Location = New System.Drawing.Point(14, 81)
        Me.passBox.Name = "passBox"
        Me.passBox.Size = New System.Drawing.Size(317, 19)
        Me.passBox.TabIndex = 0
        '
        'passForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 111)
        Me.Controls.Add(Me.passBox)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "passForm"
        Me.Text = "起動"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents passBox As System.Windows.Forms.TextBox
End Class
