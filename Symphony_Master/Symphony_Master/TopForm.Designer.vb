<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
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
        Me.residentBtn = New System.Windows.Forms.Button()
        Me.roomBtn = New System.Windows.Forms.Button()
        Me.staffBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'residentBtn
        '
        Me.residentBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.residentBtn.Location = New System.Drawing.Point(8, 12)
        Me.residentBtn.Name = "residentBtn"
        Me.residentBtn.Size = New System.Drawing.Size(121, 75)
        Me.residentBtn.TabIndex = 0
        Me.residentBtn.Text = "入居者"
        Me.residentBtn.UseVisualStyleBackColor = True
        '
        'roomBtn
        '
        Me.roomBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.roomBtn.Location = New System.Drawing.Point(8, 99)
        Me.roomBtn.Name = "roomBtn"
        Me.roomBtn.Size = New System.Drawing.Size(121, 75)
        Me.roomBtn.TabIndex = 4
        Me.roomBtn.Text = "居　室"
        Me.roomBtn.UseVisualStyleBackColor = True
        '
        'staffBtn
        '
        Me.staffBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.staffBtn.Location = New System.Drawing.Point(137, 12)
        Me.staffBtn.Name = "staffBtn"
        Me.staffBtn.Size = New System.Drawing.Size(121, 75)
        Me.staffBtn.TabIndex = 1
        Me.staffBtn.Text = "職　員"
        Me.staffBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.exitBtn.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.exitBtn.Location = New System.Drawing.Point(137, 98)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(121, 75)
        Me.exitBtn.TabIndex = 3
        Me.exitBtn.Text = "終　了"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 184)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.staffBtn)
        Me.Controls.Add(Me.roomBtn)
        Me.Controls.Add(Me.residentBtn)
        Me.Name = "TopForm"
        Me.Text = "マスタ管理"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents residentBtn As System.Windows.Forms.Button
    Friend WithEvents roomBtn As System.Windows.Forms.Button
    Friend WithEvents staffBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
End Class
