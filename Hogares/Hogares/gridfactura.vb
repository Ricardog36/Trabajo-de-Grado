Public Class gridfactura

    Private cantidad As String
    Private codigo As String
    Private descripcion As String
    Private valorU As String
    Private valorT As String

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

    Public Property valorUproducto As String
        Get
            Return valorU
        End Get
        Set(value As String)
            valorU = value
        End Set
    End Property

    Public Property valorTproducto As String
        Get
            Return valorT
        End Get
        Set(value As String)
            valorT = value
        End Set
    End Property

    'Sub New()
    '    cantidadproducto = ""
    '    codigoproducto = ""
    '    descripcionproducto = ""
    '    valorUproducto = ""
    '    valorTproducto = ""
    'End Sub

    Sub New(ByVal cantidad As Integer, ByVal codigo As Integer, ByVal descripcion As String, ByVal valorU As Integer, ByVal valorT As Integer)
        cantidadproducto = cantidad
        codigoproducto = codigo
        descripcionproducto = descripcion
        valorUproducto = valorU
        valorTproducto = valorT
    End Sub

    Public Function getList() As List(Of gridfactura)
        Dim list As New List(Of gridfactura)

        list.Add(New gridfactura(cantidadproducto, codigoproducto, descripcionproducto, valorUproducto, valorTproducto))
        'list.Add(New gridfactura("5", "02", "Haceb 5.5"))
        'list.Add(New gridfactura("5", "02", "Haceb 5.5"))
        Return list
    End Function


End Class
