Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Manager
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=duytienps02235.mssql.somee.com;packet size=4096;user id=duytienps02235_SQLLogin_3;pwd=oc354zaeye;data source=duytienps02235.mssql.somee.com;persist security info=False;initial catalog=duytienps02235"
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpToolStripMenuItem.Click

    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        QuanLySanPham.Show()
    End Sub

    Private Sub QuảnLýLoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýLoạiSảnPhẩmToolStripMenuItem.Click

    End Sub

    Private Sub QuảnLýNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNhânViênToolStripMenuItem.Click
        QuanLyNhanVien.Show()
    End Sub

    Private Sub DanhSáchNhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchNhânViênToolStripMenuItem.Click
        
    End Sub

    Private Sub DanhSaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSaToolStripMenuItem.Click
       
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox3.Click, PictureBox2.Click

    End Sub
End Class