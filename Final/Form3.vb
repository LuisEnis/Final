Imports System.Data.SqlClient

Public Class Form3
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sejdi\source\repos\Final\Final\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

    End Sub
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into [admins] values('" + txb_username.Text + "','" + txb_password.Text + "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("User registered successfuly.")
        txb_username.ResetText()
        txb_password.ResetText()



    End Sub

    Private Sub btn_registerCar_Click(sender As Object, e As EventArgs) Handles btn_registerCar.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into [car] values('" + txb_carID.Text + "','" + txb_carType.Text + "','" + Txb_manual_automatic.Text + "','" + Txb_carPower.Text + "','" + txb_kilometers.Text + "','" + txb_fuel.Text + "','" + txb_productionYear.Text + "','" + txb_price.Text + "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Car registered successfuly.")
        txb_carID.ResetText()
        txb_carType.ResetText()
        txb_fuel.ResetText()
        txb_kilometers.ResetText()
        txb_price.ResetText()
        txb_productionYear.ResetText()
        Txb_carPower.ResetText()
        Txb_manual_automatic.ResetText()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()


    End Sub

    Private Sub txb_carID_TextChanged(sender As Object, e As EventArgs) Handles txb_carID.TextChanged
        If txb_carID.TextLength <> 0 Then
            btn_delete.Enabled = True

        Else
            btn_delete.Enabled = False


        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from [car] where Id=" & Integer.Parse(txb_carID.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Car deleted sucessfuly")
    End Sub
End Class