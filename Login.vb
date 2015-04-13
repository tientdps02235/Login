Imports System.Data.SqlClient
Public Class Login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim chuoiketnoi As String = "workstation id=duytienps02235.mssql.somee.com;packet size=4096;user id=duytienps02235_SQLLogin_3;pwd=oc354zaeye;data source=duytienps02235.mssql.somee.com;persist security info=False;initial catalog=duytienps02235"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from Nhan_Vien where UserName='" & TextBoxUserName.Text & "' and PassWord='" & TextBoxPassWord.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                Manager.Show()
                Me.Hide()
            Else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
