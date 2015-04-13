<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLyNhanVien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxMaNV = New System.Windows.Forms.TextBox()
        Me.TextBoxTenNV = New System.Windows.Forms.TextBox()
        Me.TextBoxChucVu = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxPassWord = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnXem = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnThem = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(47, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã nhân viên:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(47, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên nhân viên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(47, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Chức vụ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(47, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "UserName:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(47, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "PassWord:"
        '
        'TextBoxMaNV
        '
        Me.TextBoxMaNV.Location = New System.Drawing.Point(126, 22)
        Me.TextBoxMaNV.Name = "TextBoxMaNV"
        Me.TextBoxMaNV.Size = New System.Drawing.Size(284, 20)
        Me.TextBoxMaNV.TabIndex = 1
        '
        'TextBoxTenNV
        '
        Me.TextBoxTenNV.Location = New System.Drawing.Point(126, 52)
        Me.TextBoxTenNV.Name = "TextBoxTenNV"
        Me.TextBoxTenNV.Size = New System.Drawing.Size(284, 20)
        Me.TextBoxTenNV.TabIndex = 1
        '
        'TextBoxChucVu
        '
        Me.TextBoxChucVu.Location = New System.Drawing.Point(126, 84)
        Me.TextBoxChucVu.Name = "TextBoxChucVu"
        Me.TextBoxChucVu.Size = New System.Drawing.Size(284, 20)
        Me.TextBoxChucVu.TabIndex = 1
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(126, 115)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(284, 20)
        Me.TextBoxUserName.TabIndex = 1
        '
        'TextBoxPassWord
        '
        Me.TextBoxPassWord.Location = New System.Drawing.Point(126, 148)
        Me.TextBoxPassWord.Name = "TextBoxPassWord"
        Me.TextBoxPassWord.Size = New System.Drawing.Size(284, 20)
        Me.TextBoxPassWord.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 190)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnXem
        '
        Me.BtnXem.Image = Global.Login.My.Resources.Resources.zoom_in
        Me.BtnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnXem.Location = New System.Drawing.Point(326, 179)
        Me.BtnXem.Name = "BtnXem"
        Me.BtnXem.Size = New System.Drawing.Size(84, 41)
        Me.BtnXem.TabIndex = 2
        Me.BtnXem.Text = "Xem"
        Me.BtnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnXem.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.Login.My.Resources.Resources.remove
        Me.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnXoa.Location = New System.Drawing.Point(236, 179)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(84, 41)
        Me.BtnXoa.TabIndex = 2
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.Login.My.Resources.Resources.edit_add
        Me.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSua.Location = New System.Drawing.Point(142, 179)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(84, 41)
        Me.BtnSua.TabIndex = 2
        Me.BtnSua.Text = "Sửa"
        Me.BtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnThem
        '
        Me.BtnThem.Image = Global.Login.My.Resources.Resources.add_user_icon
        Me.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnThem.Location = New System.Drawing.Point(50, 179)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(84, 41)
        Me.BtnThem.TabIndex = 2
        Me.BtnThem.Text = "Thêm"
        Me.BtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnThem.UseVisualStyleBackColor = True
        '
        'QuanLyNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImage = Global.Login.My.Resources.Resources._221114hd24y2dlg91d4i1d
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(587, 434)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnXem)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnSua)
        Me.Controls.Add(Me.BtnThem)
        Me.Controls.Add(Me.TextBoxPassWord)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.TextBoxChucVu)
        Me.Controls.Add(Me.TextBoxTenNV)
        Me.Controls.Add(Me.TextBoxMaNV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLyNhanVien"
        Me.Text = "QuanLyNhanVien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaNV As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTenNV As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxChucVu As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassWord As System.Windows.Forms.TextBox
    Friend WithEvents BtnThem As System.Windows.Forms.Button
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnXem As System.Windows.Forms.Button
End Class
