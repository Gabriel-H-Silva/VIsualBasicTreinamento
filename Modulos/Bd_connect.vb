Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Module Bd_connect
    Public connectionString As String = "server=localhost;userid=root;password=;database=sistema;"
    Public Class Users
        Public Property _FirstName As String
        Public Property _LastName As String
        Public Property _GenderId As Integer
        Public Property _Email As String
        Public Property _Birth As String

        Public Property _UserTypeId As Integer
    End Class
    Public Sub SaveNewUser(FirstName, LastName, GenderName, Email, Birth, UserType)
        Dim GenderId As Integer
        Dim UserTypeId As Integer

        If GenderName = "Masculino" Then
            GenderId = 1
        Else
            UserTypeId = 2
        End If

        If UserType = "Usuario" Then
            UserTypeId = 2
        ElseIf UserType = "Administrador" Then
            UserTypeId = 1
        End If

        Dim NewUser As Users = New Users With {
            ._FirstName = FirstName,
            ._LastName = LastName,
            ._GenderId = GenderId,
            ._Email = Email,
            ._Birth = Birth,
            ._UserTypeId = UserTypeId
        }
        Save(NewUser)
    End Sub
    Private Sub Save(NewUser)
        Using SQLConnection As New MySqlConnection(connectionString)
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO usuarios (FirstName, LastName, Gender, Email, Birth, Adm_type) VALUES (
                        '" + NewUser._FirstName.ToString() + "',
                        '" + NewUser._LastName.ToString() + "',
                        " + NewUser._GenderId.ToString() + ",
                        '" + NewUser._Email.ToString() + "',
                        '" + NewUser._Birth.ToString() + "',
                        '" + NewUser._UserTypeId.ToString() + "'
                    ) "
                    .Connection = SQLConnection
                End With
                Try
                    SQLConnection.Open()
                    sqlCommand.ExecuteNonQuery()
                Catch ex As MySqlException
                    MsgBox("Erro: " + ex.Message)
                Finally
                    SQLConnection.Close()
                End Try
            End Using
        End Using
        MsgBox("Usuario cadastrado com sucesso")
    End Sub
End Module
