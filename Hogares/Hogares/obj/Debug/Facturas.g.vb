﻿#ExternalChecksum("..\..\Facturas.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","7B508851692F5A64D915D16D6E722A81")
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.17929
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Facturas
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Facturas
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\Facturas.xaml",43)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtNroFactura As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",50)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents DPFecha As System.Windows.Controls.DatePicker
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",63)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtCedula As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",70)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtCliente As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",83)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtTelefono As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",85)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtDireccion As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",98)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtVendedor As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",100)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtTecnico As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",113)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents RDBSi As System.Windows.Controls.RadioButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",114)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents RDBNo As System.Windows.Controls.RadioButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",124)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents DataGridProduct As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",225)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Txtcantidad As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",226)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Txtcodigo As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",227)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Txtdescripcion As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",228)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtvalorU As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",229)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtvalorT As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Facturas.xaml",262)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents TxtTotalventa As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/Hogares;component/facturas.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Facturas.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.TxtNroFactura = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 2) Then
            Me.DPFecha = CType(target,System.Windows.Controls.DatePicker)
            Return
        End If
        If (connectionId = 3) Then
            Me.TxtCedula = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 4) Then
            
            #ExternalSource("..\..\Facturas.xaml",64)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.ConsulCliente_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.TxtCliente = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 6) Then
            Me.TxtTelefono = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 7) Then
            Me.TxtDireccion = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 8) Then
            Me.TxtVendedor = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 9) Then
            Me.TxtTecnico = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 10) Then
            Me.RDBSi = CType(target,System.Windows.Controls.RadioButton)
            Return
        End If
        If (connectionId = 11) Then
            Me.RDBNo = CType(target,System.Windows.Controls.RadioButton)
            Return
        End If
        If (connectionId = 12) Then
            
            #ExternalSource("..\..\Facturas.xaml",115)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Grid_Loaded)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 13) Then
            Me.DataGridProduct = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 14) Then
            Me.Txtcantidad = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 15) Then
            Me.Txtcodigo = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 16) Then
            Me.Txtdescripcion = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 17) Then
            Me.TxtvalorU = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 18) Then
            Me.TxtvalorT = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 19) Then
            
            #ExternalSource("..\..\Facturas.xaml",251)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.ConsulCliente_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 20) Then
            Me.TxtTotalventa = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

