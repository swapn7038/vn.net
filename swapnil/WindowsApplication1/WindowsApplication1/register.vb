Imports System.Data.OleDb
Public Class register



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim sqlQuery As String
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ADMIN 26\Documents\cafe.accdb;Persist Security Info=True"
        Dim user_name, pwd, cpwd As String
        user_name = TextBox1.Text
        pwd = TextBox2.Text
        cpwd = TextBox3.Text
        cn.open()



        Try
            sqlQuery = "INSERT INTO register(user_name,pwd,cpwd) VALUES( @user,@pwd,@cpwd)"
            cmd.Connection = cn
            cmd.CommandText = sqlQuery
            cmd.Parameters.AddWithValue("@user", user_name)
            cmd.Parameters.AddWithValue("@pwd", pwd)
            cmd.Parameters.AddWithValue("@cpwd", cpwd)


            If pwd = cpwd Then


                cmd.ExecuteNonQuery()
                MsgBox("Registered Succesfully")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Duplicate entry")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        End Try











    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        login.Show()
    End Sub

    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class