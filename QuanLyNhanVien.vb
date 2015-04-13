Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class QuanLyNhanVien
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=duytienps02235.mssql.somee.com;packet size=4096;user id=duytienps02235_SQLLogin_3;pwd=oc354zaeye;data source=duytienps02235.mssql.somee.com;persist security info=False;initial catalog=duytienps02235"
  

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Khi click vào 1 ô bất kì lấy giá trị tại dòng đó đưa lên các ô tương ứng
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        TextBoxMaNV.Text = DataGridView1.Item(0, index).Value
        TextBoxTenNV.Text = DataGridView1.Item(1, index).Value
        TextBoxChucVu.Text = DataGridView1.Item(2, index).Value
        TextBoxUserName.Text = DataGridView1.Item(3, index).Value
        TextBoxPassWord.Text = DataGridView1.Item(4, index).Value
    End Sub
    Public Sub LoadData()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("Select * from Nhan_Vien", KetNoi)
        Try
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub BtnThem_Click(sender As Object, e As EventArgs) Handles BtnThem.Click
        'Kết nối đến databaseonlie thông qua chuỗi kết nối connectstr
        Dim KetNoi As New SqlConnection(connectstr)
        'Mở kết nối
        KetNoi.Open()

        Dim stradd As String = "insert into Nhan_Vien values (@Ma_NV,@Ten_NV,@ChucVu_NV,@UserName,@PassWord)"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Ma_NV", TextBoxMaNV.Text)
            com.Parameters.AddWithValue("@Ten_NV", TextBoxTenNV.Text)
            com.Parameters.AddWithValue("@ChucVu_NV", TextBoxChucVu.Text)
            com.Parameters.AddWithValue("@UserName", TextBoxUserName.Text)
            com.Parameters.AddWithValue("@PassWord", TextBoxPassWord.Text)
            ' Thực thi câu lệnh Insert dữ liệu vào Database online
            com.ExecuteNonQuery()
            ' Đóng kết nối
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub BtnXem_Click(sender As Object, e As EventArgs) Handles BtnXem.Click

        'tạo đối tượng kết nối tới Data Trên Somee.com thông qua chuỗi kết nối connectstr
        Dim KetNoi As New SqlConnection(connectstr)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_Vien", KetNoi)

        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub BtnSua_Click(sender As Object, e As EventArgs) Handles BtnSua.Click
        'Kết nối Database online
        Dim KetNoi As New SqlConnection(connectstr)
        'Mở kết nối
        KetNoi.Open()
        'Truy vấn sửa dữ liệu
        Dim stradd As String = "Update Nhan_Vien Set Ten_NV=@Ten_NV,ChucVu_NV=@ChucVu_NV,UserName=@UserName,PassWord=@PassWord Where Ma_NV=@Ma_NV "
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            'Thêm dữ liệu vào
            com.Parameters.AddWithValue("@Ma_NV", TextBoxMaNV.Text)
            com.Parameters.AddWithValue("@Ten_NV", TextBoxTenNV.Text)
            com.Parameters.AddWithValue("@ChucVu_NV", TextBoxChucVu.Text)
            com.Parameters.AddWithValue("@UserName", TextBoxUserName.Text)
            com.Parameters.AddWithValue("@PassWord", TextBoxPassWord.Text)
            'Thực thi câu truy vấn và sửa dữ liệu
            com.ExecuteNonQuery()
            'Đóng kết nối
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        End Try
        'Load lại dữ liệu
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub BtnXoa_Click(sender As Object, e As EventArgs) Handles BtnXoa.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "Delete from Nhan_Vien where Ma_NV=@Ma_NV"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Ma_NV", TextBoxMaNV.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại")
        End Try
        'Load lại dữ liệu
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub
End Class