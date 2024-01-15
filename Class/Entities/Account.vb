Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports WinFormsApp1.Gender_Enum
Imports WinFormsApp1.ResultUW
Imports WinFormsApp1.UserType_Enum
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Namespace Accounts

    Public Class Users
        Public Property Id As Integer
        Public Property Username As String
        Public Property Name As String
        Public Property GenderId As Integer
        Public Property Email As String
        Public Property Birth As String
        Public Property UserTypeId As Integer
        Public Property Password As String
        Public Property Failed As Boolean
    End Class
    Public Class Account
        Private connectionString As String = "server=localhost;userid=root;password=;database=sistema;"
        Public Return_msg As Boolean
        Private Function Save(AccountData)
            Dim ResultError As Boolean
            Using SQLConnection As New MySqlConnection(connectionString)
                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        .CommandText = "INSERT INTO usuarios (Username, Name, GenderId, Email, Birth, UserTypeId, Password) VALUES (
                        '" + AccountData.Username.ToString() + "',
                        '" + AccountData.Name.ToString() + "',
                        " + AccountData.GenderId.ToString() + ",
                        '" + AccountData.Email.ToString() + "',
                        '" + AccountData.Birth.ToString() + "',
                        '" + AccountData.UserTypeId.ToString() + "',
                        '" + AccountData.Password.ToString() + "'
                    ) "
                        .Connection = SQLConnection
                    End With
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()
                        ResultError = True
                    Catch ex As MySqlException
                        MsgBox("Erro: " + ex.Message)
                        ResultError = False
                    Finally
                        SQLConnection.Close()
                    End Try
                    ResultError = True
                End Using
            End Using
            MsgBox("Usuario cadastrado com sucesso")
            Return ResultError
        End Function

        Private Function GetUserById(Id)
            Dim QueryResult As MySqlDataReader
            Dim AccountData As Users
            Using SQLConnection As New MySqlConnection(connectionString)

                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        .CommandText = "SELECT * FROM usuarios WHERE Id = '" + Id.ToString() + "' "
                        .Connection = SQLConnection
                    End With
                    Try
                        SQLConnection.Open()
                        QueryResult = sqlCommand.ExecuteReader


                        If QueryResult.HasRows Then

                            QueryResult.Read()
                            AccountData = New Users With {
                                    .Id = QueryResult.Item("Id"),
                                    .Username = QueryResult.Item("Username"),
                                    .Name = QueryResult.Item("Name"),
                                    .GenderId = QueryResult.Item("GenderId"),
                                    .Email = QueryResult.Item("Email"),
                                    .Birth = QueryResult.Item("Birth"),
                                    .UserTypeId = QueryResult.Item("UserTypeId"),
                                    .Password = QueryResult.Item("Password")
                            }
                            Return AccountData
                        Else
                            MsgBox("Não foi encontrado usuario!")
                            Return Nothing
                        End If
                    Catch ex As MySqlException
                        MsgBox("Erro: " + ex.Message)
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using
            End Using
        End Function
        Private Function GetLoginByUsername(Username)
            Dim QueryResult As MySqlDataReader
            Dim AccountData As Users
            Using SQLConnection As New MySqlConnection(connectionString)

                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        .CommandText = "SELECT * FROM usuarios WHERE Username = '" + Username.ToString() + "' "
                        .Connection = SQLConnection
                    End With
                    Try
                        SQLConnection.Open()
                        QueryResult = sqlCommand.ExecuteReader


                        If QueryResult.HasRows Then

                            QueryResult.Read()
                            AccountData = New Users With {
                                    .Id = QueryResult.Item("Id"),
                                    .Username = QueryResult.Item("Username"),
                                    .Name = QueryResult.Item("Name"),
                                    .GenderId = QueryResult.Item("GenderId"),
                                    .Email = QueryResult.Item("Email"),
                                    .Birth = QueryResult.Item("Birth"),
                                    .UserTypeId = QueryResult.Item("UserTypeId"),
                                    .Password = QueryResult.Item("Password")
                            }
                            Return AccountData
                        Else
                            MsgBox("Não foi encontrado usuario!")
                        End If
                    Catch ex As MySqlException
                        MsgBox("Erro: " + ex.Message)
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using
            End Using
        End Function

        Friend Class EventReceiver
            Private Account As New Account


            Function SaveNewUser(Username, Name, GenderName, Email, Birth, UserType, Password)
                Dim ResultError As Boolean
                Dim GenderId As Integer
                Dim UserTypeId As Integer

                If GenderName = "Masculino" Then
                    GenderId = GendersId.Male
                Else
                    GenderId = GendersId.Feme
                End If

                If UserType = "Usuario" Then
                    UserTypeId = UserTypeId_Enum.Administrador
                ElseIf UserType = "Administrador" Then
                    UserTypeId = UserTypeId_Enum.User
                End If

                Dim AccountData As Users = New Users With {
                    .Username = Username,
                    .Name = Name,
                    .GenderId = GenderId,
                    .Email = Email,
                    .Birth = Birth,
                    .UserTypeId = UserTypeId,
                    .Password = Password
                }

                ResultError = Account.Save(AccountData)

                Return ResultError

            End Function

            Function LoginUser(Username, Password)
                Dim AccountData As Users

                AccountData = Account.GetLoginByUsername(Username)

                If IsNothing(AccountData) Then
                    Return False
                Else
                    If AccountData.Password <> Password Then
                        MsgBox("Senha Incorreta")
                        Return 0
                    Else
                        Return AccountData.Id
                    End If
                End If

            End Function

            Function UserGetById(Id)
                Dim AccountData As Users

                AccountData = Account.GetUserById(Id)

                If IsNothing(AccountData) Then
                    Return Nothing
                Else
                    Return AccountData
                End If

            End Function
        End Class
    End Class
End Namespace

