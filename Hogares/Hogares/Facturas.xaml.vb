﻿Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Nullable
Imports System.Windows.Navigation
Imports Hogares.gridfactura


Public Class Facturas
    Dim cn As MySqlConnection
    Dim cadenaCon As String
    Dim cadenaSql As String
    Dim cmd As MySqlCommand

    Private Sub ConsulCliente_Click(sender As Object, e As RoutedEventArgs)

        cadenaCon = "Server=localhost; database=gnhogares; Uid=root;Pwd="
        cadenaSql = "select * from gnhogares.cliente where cedulacliente =" +
        TxtCedula.Text + ";"
        cn = New MySqlConnection(cadenaCon)
        Try
            cn.Open()
            cmd = New MySqlCommand(cadenaSql, cn)
            cmd.ExecuteNonQuery()
            Dim datos As MySqlDataReader = cmd.ExecuteReader
            If (datos.Read) Then
                TxtCedula.Text = datos.GetString(0)
                TxtCliente.Text = datos.GetString(1)
                TxtTelefono.Text = datos.GetString(2)
                TxtDireccion.Text = datos.GetString(3)
            Else
                MsgBox("Cliente no existe")
            End If
        Catch ex As IO.IOException
            MsgBox("Error en el registro. " + ex.Message)
        End Try

        cn.Close()


    End Sub

    Private Sub Grid_Loaded(sender As Object, e As RoutedEventArgs)

        Dim producto As New gridfactura(Txtcantidad.Text, Txtcodigo.Text, Txtdescripcion.Text, TxtvalorU.Text, TxtvalorT.Text)
        Dim list As List(Of gridfactura) = producto.getList()
        DataGridProduct.ItemsSource = list
        Txtcantidad.Text = ""
        Txtcodigo.Text = ""
        Txtdescripcion.Text = ""
        TxtvalorU.Text = ""
        TxtvalorT.Text = ""

    End Sub

End Class
