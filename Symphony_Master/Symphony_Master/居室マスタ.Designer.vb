<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 居室マスタ
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.BbtnClear = New System.Windows.Forms.Button()
        Me.dgvRoom = New System.Windows.Forms.DataGridView()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Location = New System.Drawing.Point(10, 8)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowTemplate.Height = 21
        Me.dgvUser.Size = New System.Drawing.Size(101, 371)
        Me.dgvUser.TabIndex = 0
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(754, 340)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(38, 33)
        Me.btnRegist.TabIndex = 1
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'BbtnClear
        '
        Me.BbtnClear.Location = New System.Drawing.Point(798, 340)
        Me.BbtnClear.Name = "BbtnClear"
        Me.BbtnClear.Size = New System.Drawing.Size(38, 33)
        Me.BbtnClear.TabIndex = 2
        Me.BbtnClear.Text = "クリア"
        Me.BbtnClear.UseVisualStyleBackColor = True
        '
        'dgvRoom
        '
        Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoom.Location = New System.Drawing.Point(126, 8)
        Me.dgvRoom.Name = "dgvRoom"
        Me.dgvRoom.RowTemplate.Height = 21
        Me.dgvRoom.Size = New System.Drawing.Size(713, 323)
        Me.dgvRoom.TabIndex = 3
        '
        '居室マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 389)
        Me.Controls.Add(Me.dgvRoom)
        Me.Controls.Add(Me.BbtnClear)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.dgvUser)
        Me.Name = "居室マスタ"
        Me.Text = "利用居室"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents BbtnClear As System.Windows.Forms.Button
    Friend WithEvents dgvRoom As System.Windows.Forms.DataGridView
End Class
