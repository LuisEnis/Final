Imports System.Data.SqlClient


Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sejdi\source\repos\Final\Final\Database1.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()

    End Sub

    Public Sub btn_showAll_Click(sender As Object, e As EventArgs) Handles btn_showAll.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from car"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Form2.dgv_showCars.DataSource = dt
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from admins where username='" + txb_username.Text + "' and password='" + txb_password.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Username or password not correct")
        Else
            Form3.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim id, year As Integer
        Integer.TryParse(txb_carID.Text, id)
        Integer.TryParse(txb_productionYear.Text, year)
        Dim power, km, price As Decimal
        Decimal.TryParse(Txb_carPower.Text, power)
        Decimal.TryParse(txb_kilometers.Text, km)
        Decimal.TryParse(txb_price.Text, price)
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        Dim command As String = "select * from car where "
        Dim extracmd As String = ""

        If txb_carID.Text.Length > 0 Then
            extracmd = "Id=" & id & " and "
            command = command & extracmd
        End If

        If txb_carType.Text.Length > 0 Then
            extracmd = "type like '%" & txb_carType.Text & "%' and "
            command = command & extracmd
        End If

        If Txb_manual_automatic.Text.Length > 0 Then
            extracmd = "transmission='" & Txb_manual_automatic.Text & "' and "
            command = command & extracmd
        End If

        If Txb_carPower.Text.Length > 0 Then
            extracmd = "power<=" & power & " and "
            command = command & extracmd
        End If

        If txb_kilometers.Text.Length > 0 Then
            extracmd = "kilometers<=" & km & " and "
            command = command & extracmd
        End If

        If txb_fuel.Text.Length > 0 Then
            extracmd = "fuel='" & txb_fuel.Text & "' and "
            command = command & extracmd
        End If

        If txb_productionYear.Text.Length > 0 Then
            extracmd = "productionYear<=" & year & " and "
            command = command & extracmd
        End If

        If txb_price.Text.Length > 0 Then
            extracmd = "price<=" & price
            command = command & extracmd
        End If
        Dim endCount As Integer = command.Length - 1
        Dim startAnd As Integer = command.Length - 5
        Dim startWhere As Integer = command.Length - 7

        If command.EndsWith(" and ") Then
            command = command.Remove(startAnd)
        End If

        If command.EndsWith(" where ") Then
            command = command.Remove(startWhere)
        End If

        cmd.CommandText = command
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Form2.dgv_showCars.DataSource = dt
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub
End Class