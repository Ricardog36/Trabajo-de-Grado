Public Class gridfactura

    Private cantidad As String
    Private codigo As String
    Private descripcion As String

    Public Property cantidadproducto As String
        Get
            Return cantidad
        End Get
        Set(value As String)
            cantidad = value
        End Set
    End Property

    Public Property codigoproducto As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property descripcionproducto As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Sub New()
        cantidadproducto = ""
        codigoproducto = ""
        descripcionproducto = ""
    End Sub

    Sub New(ByVal cantidad As Integer, ByVal codigo As Integer, ByVal descripcion As String)
        cantidadproducto = cantidad
        codigoproducto = codigo
        descripcionproducto = descripcion
    End Sub

    Public Function getList() As List(Of gridfactura)
        Dim list As New List(Of gridfactura)
        list.Add(New gridfactura("1", "01", "Bosch 5.5"))
        list.Add(New gridfactura("5", "02", "Haceb 5.5"))
        Return List
    End Function


End Class
