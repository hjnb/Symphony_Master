<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 入居者マスタ
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
        Me.dgvResident = New System.Windows.Forms.DataGridView()
        Me.sortBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.firstnameBox = New System.Windows.Forms.TextBox()
        Me.lastnameBox = New System.Windows.Forms.TextBox()
        Me.kanaBox = New System.Windows.Forms.TextBox()
        Me.unitBox = New System.Windows.Forms.ComboBox()
        Me.displayCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvResident, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvResident
        '
        Me.dgvResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResident.Location = New System.Drawing.Point(12, 140)
        Me.dgvResident.Name = "dgvResident"
        Me.dgvResident.RowTemplate.Height = 21
        Me.dgvResident.Size = New System.Drawing.Size(365, 421)
        Me.dgvResident.TabIndex = 15
        '
        'sortBox
        '
        Me.sortBox.FormattingEnabled = True
        Me.sortBox.Location = New System.Drawing.Point(279, 570)
        Me.sortBox.Name = "sortBox"
        Me.sortBox.Size = New System.Drawing.Size(74, 20)
        Me.sortBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 573)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "並び替え"
        '
        'idBox
        '
        Me.idBox.ForeColor = System.Drawing.Color.Blue
        Me.idBox.Location = New System.Drawing.Point(75, 14)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(65, 19)
        Me.idBox.TabIndex = 0
        '
        'firstnameBox
        '
        Me.firstnameBox.Location = New System.Drawing.Point(200, 49)
        Me.firstnameBox.Name = "firstnameBox"
        Me.firstnameBox.Size = New System.Drawing.Size(65, 19)
        Me.firstnameBox.TabIndex = 2
        '
        'lastnameBox
        '
        Me.lastnameBox.Location = New System.Drawing.Point(97, 49)
        Me.lastnameBox.Name = "lastnameBox"
        Me.lastnameBox.Size = New System.Drawing.Size(65, 19)
        Me.lastnameBox.TabIndex = 1
        '
        'kanaBox
        '
        Me.kanaBox.Location = New System.Drawing.Point(75, 79)
        Me.kanaBox.Name = "kanaBox"
        Me.kanaBox.Size = New System.Drawing.Size(190, 19)
        Me.kanaBox.TabIndex = 3
        '
        'unitBox
        '
        Me.unitBox.FormattingEnabled = True
        Me.unitBox.Location = New System.Drawing.Point(75, 109)
        Me.unitBox.Name = "unitBox"
        Me.unitBox.Size = New System.Drawing.Size(55, 20)
        Me.unitBox.TabIndex = 4
        '
        'displayCheckBox
        '
        Me.displayCheckBox.AutoSize = True
        Me.displayCheckBox.Checked = True
        Me.displayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayCheckBox.Location = New System.Drawing.Point(206, 110)
        Me.displayCheckBox.Name = "displayCheckBox"
        Me.displayCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.displayCheckBox.TabIndex = 13
        Me.displayCheckBox.Text = "有効"
        Me.displayCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "表示"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "姓"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "漢字氏名"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 12)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "フリガナ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "ユニット"
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(315, 55)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(62, 27)
        Me.btnRegist.TabIndex = 5
        Me.btnRegist.Text = "登　録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(315, 89)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 27)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "削　除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        '入居者マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 598)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.displayCheckBox)
        Me.Controls.Add(Me.unitBox)
        Me.Controls.Add(Me.kanaBox)
        Me.Controls.Add(Me.lastnameBox)
        Me.Controls.Add(Me.firstnameBox)
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sortBox)
        Me.Controls.Add(Me.dgvResident)
        Me.Name = "入居者マスタ"
        Me.Text = "入居者マスタ"
        CType(Me.dgvResident, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvResident As System.Windows.Forms.DataGridView
    Friend WithEvents sortBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idBox As System.Windows.Forms.TextBox
    Friend WithEvents firstnameBox As System.Windows.Forms.TextBox
    Friend WithEvents lastnameBox As System.Windows.Forms.TextBox
    Friend WithEvents kanaBox As System.Windows.Forms.TextBox
    Friend WithEvents unitBox As System.Windows.Forms.ComboBox
    Friend WithEvents displayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
