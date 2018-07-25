<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 職員マスタ
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
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.lastnameBox = New System.Windows.Forms.TextBox()
        Me.firstnameBox = New System.Windows.Forms.TextBox()
        Me.kanaBox = New System.Windows.Forms.TextBox()
        Me.abbreviationNameBox = New System.Windows.Forms.TextBox()
        Me.officeNameBox = New System.Windows.Forms.ComboBox()
        Me.jobBox = New System.Windows.Forms.ComboBox()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lastnameCheckBox = New System.Windows.Forms.CheckBox()
        Me.displayCheckBox = New System.Windows.Forms.CheckBox()
        Me.existCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.sortBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idBox
        '
        Me.idBox.BackColor = System.Drawing.SystemColors.Control
        Me.idBox.Location = New System.Drawing.Point(99, 15)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(74, 19)
        Me.idBox.TabIndex = 0
        '
        'lastnameBox
        '
        Me.lastnameBox.Location = New System.Drawing.Point(122, 50)
        Me.lastnameBox.Name = "lastnameBox"
        Me.lastnameBox.Size = New System.Drawing.Size(66, 19)
        Me.lastnameBox.TabIndex = 1
        '
        'firstnameBox
        '
        Me.firstnameBox.Location = New System.Drawing.Point(215, 50)
        Me.firstnameBox.Name = "firstnameBox"
        Me.firstnameBox.Size = New System.Drawing.Size(66, 19)
        Me.firstnameBox.TabIndex = 2
        '
        'kanaBox
        '
        Me.kanaBox.Location = New System.Drawing.Point(99, 85)
        Me.kanaBox.Name = "kanaBox"
        Me.kanaBox.Size = New System.Drawing.Size(182, 19)
        Me.kanaBox.TabIndex = 3
        '
        'abbreviationNameBox
        '
        Me.abbreviationNameBox.Location = New System.Drawing.Point(155, 111)
        Me.abbreviationNameBox.Name = "abbreviationNameBox"
        Me.abbreviationNameBox.Size = New System.Drawing.Size(66, 19)
        Me.abbreviationNameBox.TabIndex = 7
        '
        'officeNameBox
        '
        Me.officeNameBox.FormattingEnabled = True
        Me.officeNameBox.Location = New System.Drawing.Point(403, 49)
        Me.officeNameBox.Name = "officeNameBox"
        Me.officeNameBox.Size = New System.Drawing.Size(181, 20)
        Me.officeNameBox.TabIndex = 4
        '
        'jobBox
        '
        Me.jobBox.FormattingEnabled = True
        Me.jobBox.Location = New System.Drawing.Point(403, 84)
        Me.jobBox.Name = "jobBox"
        Me.jobBox.Size = New System.Drawing.Size(181, 20)
        Me.jobBox.TabIndex = 5
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(558, 123)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(58, 29)
        Me.btnRegist.TabIndex = 6
        Me.btnRegist.Text = "登　録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(558, 158)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 29)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "削　除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lastnameCheckBox
        '
        Me.lastnameCheckBox.AutoSize = True
        Me.lastnameCheckBox.Checked = True
        Me.lastnameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.lastnameCheckBox.Location = New System.Drawing.Point(99, 113)
        Me.lastnameCheckBox.Name = "lastnameCheckBox"
        Me.lastnameCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.lastnameCheckBox.TabIndex = 10
        Me.lastnameCheckBox.Text = "苗字"
        Me.lastnameCheckBox.UseVisualStyleBackColor = True
        '
        'displayCheckBox
        '
        Me.displayCheckBox.AutoSize = True
        Me.displayCheckBox.Checked = True
        Me.displayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayCheckBox.Location = New System.Drawing.Point(99, 171)
        Me.displayCheckBox.Name = "displayCheckBox"
        Me.displayCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.displayCheckBox.TabIndex = 11
        Me.displayCheckBox.Text = "有効"
        Me.displayCheckBox.UseVisualStyleBackColor = True
        '
        'existCheckBox
        '
        Me.existCheckBox.AutoSize = True
        Me.existCheckBox.Checked = True
        Me.existCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.existCheckBox.Location = New System.Drawing.Point(99, 142)
        Me.existCheckBox.Name = "existCheckBox"
        Me.existCheckBox.Size = New System.Drawing.Size(48, 16)
        Me.existCheckBox.TabIndex = 12
        Me.existCheckBox.Text = "有効"
        Me.existCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "姓"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "名"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "漢字氏名"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "フリガナ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "略名"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "表示"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "在職"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(328, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "事業所名"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "職種"
        '
        'dgvStaff
        '
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Location = New System.Drawing.Point(12, 196)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.RowTemplate.Height = 21
        Me.dgvStaff.Size = New System.Drawing.Size(608, 362)
        Me.dgvStaff.TabIndex = 25
        '
        'sortBox
        '
        Me.sortBox.FormattingEnabled = True
        Me.sortBox.Location = New System.Drawing.Point(524, 566)
        Me.sortBox.Name = "sortBox"
        Me.sortBox.Size = New System.Drawing.Size(74, 20)
        Me.sortBox.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(470, 569)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 12)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "並び替え"
        '
        '職員マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 594)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.sortBox)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.existCheckBox)
        Me.Controls.Add(Me.displayCheckBox)
        Me.Controls.Add(Me.lastnameCheckBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.jobBox)
        Me.Controls.Add(Me.officeNameBox)
        Me.Controls.Add(Me.abbreviationNameBox)
        Me.Controls.Add(Me.kanaBox)
        Me.Controls.Add(Me.firstnameBox)
        Me.Controls.Add(Me.lastnameBox)
        Me.Controls.Add(Me.idBox)
        Me.Name = "職員マスタ"
        Me.Text = "職員"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idBox As System.Windows.Forms.TextBox
    Friend WithEvents lastnameBox As System.Windows.Forms.TextBox
    Friend WithEvents firstnameBox As System.Windows.Forms.TextBox
    Friend WithEvents kanaBox As System.Windows.Forms.TextBox
    Friend WithEvents abbreviationNameBox As System.Windows.Forms.TextBox
    Friend WithEvents officeNameBox As System.Windows.Forms.ComboBox
    Friend WithEvents jobBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lastnameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents displayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents existCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvStaff As System.Windows.Forms.DataGridView
    Friend WithEvents sortBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
