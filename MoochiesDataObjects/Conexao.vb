Imports MoochiesEnity
Imports System.Data.SqlClient
Public Class Conexao
    Public Function InsertProducts(products As Products)
        Try
            Dim query As String = "INSERT INTO [dbo].[Products]
                                          ([ProdName]
                                          ,[Price]
                                          ,[Status]
                                          ,[DateReg])
                                    VALUES
                                          (@ProdName
                                          ,@Price
                                          ,@Status 
                                          ,@DateReg)"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JJ5EPPL;Initial Catalog=Teste;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ProdName", products.ProdName)
                    cmd.Parameters.AddWithValue("@Price", products.Price)
                    cmd.Parameters.AddWithValue("@Status", products.Status)
                    cmd.Parameters.AddWithValue("@DateReg", products.DateReg)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function DeleteProducts(products As Products)
        Try
            Dim query As String = "DELETE FROM [dbo].[Products]
                                    WHERE ProdId = @ProdId"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JJ5EPPL;Initial Catalog=Teste;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ProdId", products.ProdId)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function UpdateProducts(products As Products)
        Try
            Dim query As String = "UPDATE [dbo].[Products]
                                   SET [ProdName] = @ProdName
                                        ,[Price] = @Price
                                        ,[Status] = @Status 
                                        ,[DateReg] = @DateReg
                                   WHERE ProdId = @ProdId"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JJ5EPPL;Initial Catalog=Teste;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ProdId", products.ProdId)
                    cmd.Parameters.AddWithValue("@ProdName", products.ProdName)
                    cmd.Parameters.AddWithValue("@Price", products.Price)
                    cmd.Parameters.AddWithValue("@Status", products.Status)
                    cmd.Parameters.AddWithValue("@DateReg", products.DateReg)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function SelectProducts()
        Try
            Dim query As String = "SELECT  [ProdId]
                                       ,[ProdName]
                                       ,[Price]
                                       ,sp.[Status]
                                       ,[DateReg]
                                   FROM [dbo].[Products] p
                                   Join StatusProd sp on p.Status = sp.StatusId "
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JJ5EPPL;Initial Catalog=Teste;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            Return dt

                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function SelectFiltroProducts(products As Products)
        Try
            Dim query As String = "SELECT  [ProdName]
                                       ,[Price]
                                       ,[Status]
                                       ,[DateReg]
                                   FROM [dbo].[Products] 
                                   Where  ProdId = @ProdId"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JJ5EPPL;Initial Catalog=Teste;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ProdId", products.ProdId)
                    Using da As New SqlDataAdapter()
                        da.SelectCommand = cmd
                        Using dt As New DataTable()
                            da.Fill(dt)
                            products.ProdName = dt.Rows(0)("ProdName").ToString()
                            products.Price = CDec(dt.Rows(0)("Price").ToString())
                            products.DateReg = CDate(dt.Rows(0)("DateReg").ToString())
                            products.Status = CInt(dt.Rows(0)("Status").ToString())
                            Return products

                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Return ex
        End Try
    End Function
End Class
