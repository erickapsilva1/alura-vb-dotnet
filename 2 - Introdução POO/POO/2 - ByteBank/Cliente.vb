﻿Namespace ByteBank
    Public Class Cliente

#Region "Construtors"
        Public Sub New(m_Nome As String, m_Cpf As String)
            Nome = m_Nome
            Cpf = m_Cpf
            m_NumeroClientes += 1
        End Sub
#End Region

#Region "Properties"
        Private Shared m_NumeroClientes
        Public Shared ReadOnly Property NumeroClientes As Integer
            Get
                Return m_NumeroClientes
            End Get
        End Property

        Private m_Nome As String
        Public Property Nome As String
            Get
                Return m_Nome
            End Get
            Set(value As String)
                m_Nome = value
            End Set
        End Property

        Private m_Cpf As String
        Public Property Cpf As String
            Get
                Return m_Cpf
            End Get
            Set(value As String)
                If TestaCPF(value) Then
                    m_Cpf = value
                End If
            End Set
        End Property

        Private m_Profissao As String
        Public Property Profissao As String
            Get
                Return m_Profissao
            End Get
            Set(value As String)
                m_Profissao = value
            End Set
        End Property

        Private m_Cidade As String
        Public Property Cidade As String
            Get
                Return m_Cidade
            End Get
            Set(value As String)
                m_Cidade = value
            End Set
        End Property
#End Region

#Region "Functions"
        Private Function TestaCPF(CPF As String) As String
            Dim dadosArray() As String = {"11111111111", "22222222222", "33333333333", "44444444444", "55555555555", "66666666666", "77777777777", "88888888888", "99999999999"}
            Dim vResultado As Boolean = True
            Dim i, x, n1, n2 As Integer
            CPF = CPF.Trim
            For i = 0 To dadosArray.Length - 1
                If CPF.Length <> 11 Or dadosArray(i).Equals(CPF) Then
                    vResultado = False
                End If
            Next
            If vResultado = False Then
                Return "00000000000"
            Else
                For x = 0 To 1
                    n1 = 0
                    For i = 0 To 8 + x
                        n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
                    Next
                    n2 = 11 - (n1 - (Int(n1 / 11) * 11))
                    If n2 = 10 Or n2 = 11 Then n2 = 0
                    If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                        vResultado = False
                        Exit For
                    End If
                Next
                If vResultado = False Then
                    Return "00000000000"
                End If
            End If
            Return CPF
        End Function
#End Region
    End Class



End Namespace
