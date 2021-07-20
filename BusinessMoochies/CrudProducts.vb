Imports MoochiesEnity
Imports MoochiesDataObjects
Public Class CrudProducts
    Dim conexao As New Conexao
    Public Function InsertProducts(products As Products)
        Try
            Return conexao.InsertProducts(products)
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function DeleteProducts(products As Products)
        Try
            Return conexao.DeleteProducts(products)
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function UpdateProducts(products As Products)
        Try
            Return conexao.UpdateProducts(products)
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function SelectProducts()
        Try
            Return conexao.SelectProducts()
        Catch ex As Exception
            Return ex
        End Try
    End Function
    Public Function SelectFiltroProducts(products As Products)
        Try
            Return conexao.SelectFiltroProducts(products)
        Catch ex As Exception
            Return ex
        End Try
    End Function
End Class
