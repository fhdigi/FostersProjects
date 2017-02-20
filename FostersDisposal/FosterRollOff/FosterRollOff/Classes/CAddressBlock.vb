Imports System.ComponentModel
Imports System.Globalization

<TypeConverter(GetType(CAddressBlockConverter)), DescriptionAttribute("Expand to see the address details.")>
Public Class CAddressBlock
    Public Property FirstName As String = ""
    Public Property LastName As String = ""
    Public Property Address As String = ""
    Public Property City As String = ""
    Public Property State As String = ""
    Public Property ZipCode As String = ""

    Public ReadOnly Property FullName As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property

    Public ReadOnly Property ReverseFullName As String
        Get
            If LastName.Trim <> "" Then
                Return LastName & ", " & FirstName
            Else
                Return FirstName
            End If
        End Get
    End Property

    Public ReadOnly Property CSZ As String
        Get
            Return City & ", " & State & " " & ZipCode
        End Get
    End Property

End Class

Public Class CAddressBlockConverter
    Inherits ExpandableObjectConverter

    Public Overloads Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
        If (destinationType Is GetType(CAddressBlock)) Then
            Return True
        End If
        Return MyBase.CanConvertFrom(context, destinationType)
    End Function

    Public Overloads Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object

        If (destinationType Is GetType(System.String) AndAlso TypeOf value Is CAddressBlock) Then
            Dim so As CAddressBlock = CType(value, CAddressBlock)
            Return so.FirstName & " " & so.LastName
        End If
        Return MyBase.ConvertTo(context, culture, value, destinationType)

    End Function

    Public Overloads Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As System.Type) As Boolean
        If (sourceType Is GetType(String)) Then
            Return True
        End If
        Return MyBase.CanConvertFrom(context, sourceType)
    End Function

    Public Overloads Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object

        If (TypeOf value Is String) Then

            Try
                Dim s As String = CStr(value)
                Dim colon As Integer = s.IndexOf(":")
                Dim comma As Integer = s.IndexOf(",")

                If (colon <> -1 AndAlso comma <> -1) Then

                    Dim checkWhileTyping As String = s.Substring(colon + 1, (comma - colon - 1))

                    colon = s.IndexOf(":", comma + 1)
                    comma = s.IndexOf(",", comma + 1)

                    Dim checkCaps As String = s.Substring(colon + 1, (comma - colon - 1))

                    colon = s.IndexOf(":", comma + 1)

                    Dim suggCorr As String = s.Substring(colon + 1)

                    Dim so As CAddressBlock = New CAddressBlock()

                    so.LastName = "Test"

                    Return so
                End If
            Catch
                Throw New ArgumentException("Can not convert '" & CStr(value) & "' to type SpellingOptions")
            End Try
        End If
        Return MyBase.ConvertFrom(context, culture, value)
    End Function

End Class
