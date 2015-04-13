<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLySanPham
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
        Me.TextBoxMaSP = New System.Windows.Forms.TextBox()
        Me.BtnThem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTenSP = New System.Windows.Forms.TextBox()
        Me.TextBoxDonGia = New System.Windows.Forms.TextBox()
        Me.TextBoxSoLuong = New System.Windows.Forms.TextBox()
        Me.TextBoxMoTa = New System.Windows.Forms.TextBox()
        Me.BtnSua = New System.Windows.Forms.Button()
        Me.BtnXoa = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnXem = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxMaLoai = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'TextBoxMaSP
        '
        Me.TextBoxMaSP.Location = New System.Drawing.Point(118, 30)
        Me.TextBoxMaSP.Name = "TextBoxMaSP"
        Me.TextBoxMaSP.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxMaSP.TabIndex = 1
        '
        'BtnThem
        '
        Me.BtnThem.Image = Global.Login.My.Resources.Resources.add_user_icon
        Me.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnThem.Location = New System.Drawing.Point(38, 205)
        Me.BtnThem.Name = "BtnThem"
        Me.BtnThem.Size = New System.Drawing.Size(84, 41)
        Me.BtnThem.TabIndex = 2
        Me.BtnThem.Text = "Thêm"
        Me.BtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnThem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(35, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên Sản Phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(35, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Đơn giá:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(35, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số lượng:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(35, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Mô tả:"
        '
        'TextBoxTenSP
        '
        Me.TextBoxTenSP.Location = New System.Drawing.Point(118, 56)
        Me.TextBoxTenSP.Name = "TextBoxTenSP"
        Me.TextBoxTenSP.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxTenSP.TabIndex = 1
        '
        'TextBoxDonGia
        '
        Me.TextBoxDonGia.Location = New System.Drawing.Point(118, 86)
        Me.TextBoxDonGia.Name = "TextBoxDonGia"
        Me.TextBoxDonGia.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxDonGia.TabIndex = 1
        '
        'TextBoxSoLuong
        '
        Me.TextBoxSoLuong.Location = New System.Drawing.Point(118, 113)
        Me.TextBoxSoLuong.Name = "TextBoxSoLuong"
        Me.TextBoxSoLuong.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxSoLuong.TabIndex = 1
        '
        'TextBoxMoTa
        '
        Me.TextBoxMoTa.Location = New System.Drawing.Point(118, 141)
        Me.TextBoxMoTa.Name = "TextBoxMoTa"
        Me.TextBoxMoTa.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxMoTa.TabIndex = 1
        '
        'BtnSua
        '
        Me.BtnSua.Image = Global.Login.My.Resources.Resources.edit_add
        Me.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSua.Location = New System.Drawing.Point(136, 205)
        Me.BtnSua.Name = "BtnSua"
        Me.BtnSua.Size = New System.Drawing.Size(84, 41)
        Me.BtnSua.TabIndex = 2
        Me.BtnSua.Text = "Sửa"
        Me.BtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSua.UseVisualStyleBackColor = True
        '
        'BtnXoa
        '
        Me.BtnXoa.Image = Global.Login.My.Resources.Resources.remove
        Me.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnXoa.Location = New System.Drawing.Point(234, 205)
        Me.BtnXoa.Name = "BtnXoa"
        Me.BtnXoa.Size = New System.Drawing.Size(84, 41)
        Me.BtnXoa.TabIndex = 2
        Me.BtnXoa.Text = "Xóa"
        Me.BtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnXoa.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 262)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 171)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnXem
        '
        Me.BtnXem.Image = Global.Login.My.Resources.Resources.zoom_in
        Me.BtnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnXem.Location = New System.Drawing.Point(334, 205)
        Me.BtnXem.Name = "BtnXem"
        Me.BtnXem.Size = New System.Drawing.Size(84, 41)
        Me.BtnXem.TabIndex = 2
        Me.BtnXem.Text = "Xem"
        Me.BtnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnXem.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(35, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mã loại:"
        '
        'TextBoxMaLoai
        '
        Me.TextBoxMaLoai.Location = New System.Drawing.Point(118, 170)
        Me.TextBoxMaLoai.Name = "TextBoxMaLoai"
        Me.TextBoxMaLoai.Size = New System.Drawing.Size(300, 20)
        Me.TextBoxMaLoai.TabIndex = 1
        '
        'QuanLySanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Login.My.Resources.Resources._221114hd24y2dlg91d4i1d
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(575, 445)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnXem)
        Me.Controls.Add(Me.BtnXoa)
        Me.Controls.Add(Me.BtnSua)
        Me.Controls.Add(Me.BtnThem)
        Me.Controls.Add(Me.TextBoxMaLoai)
        Me.Controls.Add(Me.TextBoxMoTa)
        Me.Controls.Add(Me.TextBoxSoLuong)
        Me.Controls.Add(Me.TextBoxDonGia)
        Me.Controls.Add(Me.TextBoxTenSP)
        Me.Controls.Add(Me.TextBoxMaSP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QuanLySanPham"
        Me.Text = "QuanLySanPham"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaSP As System.Windows.Forms.TextBox
    Friend WithEvents BtnThem As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTenSP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDonGia As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMoTa As System.Windows.Forms.TextBox
    Friend WithEvents BtnSua As System.Windows.Forms.Button
    Friend WithEvents BtnXoa As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnXem As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMaLoai As System.Windows.Forms.TextBox
End Class
