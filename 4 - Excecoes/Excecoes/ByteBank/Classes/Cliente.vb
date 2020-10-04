Namespace Classes
    Public Class Cliente
        Private m_Cpf As String
        Public Property Cpf As String
            Get
                Return m_Cpf
            End Get
            Set(value As String)
                m_Cpf = value
            End Set
        End Property

        Public Property nome As String
        Public Property profissao As String

    End Class
End Namespace