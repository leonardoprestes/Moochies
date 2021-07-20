Imports MoochiesEnity
Imports BusinessMoochies
Public Class Form1
    Dim crudProducts As New CrudProducts
    Dim products As New Products
    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click


        products.ProdName = txtProdName.Text
        products.Price = CDec(txtPrice.Text)
        products.DateReg = CDate(txtDateReg.Text)
        If chxActive.Checked = True Then
            products.Status = 1
        ElseIf chxInactive.Checked = True Then
            products.Status = 2
        Else
            MessageBox.Show("Selecione um dos checkbox")
        End If
        Try
            crudProducts.InsertProducts(products)
            txtProdName.Clear()
            txtPrice.Clear()
            txtDateReg.Clear()
            chxActive.Checked = False
            chxInactive.Checked = False
            MessageBox.Show("Produto Inserido com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            DataGridView1.DataSource = crudProducts.SelectProducts()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        products.ProdId = CInt(txtProdId.Text)
        Try
            crudProducts.DeleteProducts(products)
            txtProdId.Clear()
            MessageBox.Show("Produto Deletado com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        products.ProdId = CInt(txtProdId.Text)

        Try

            products.ProdName = txtProdName.Text
            products.Price = CDec(txtPrice.Text)
            products.DateReg = CDate(txtDateReg.Text)
            If chxActive.Checked = True Then
                products.Status = 1
            ElseIf chxInactive.Checked = True Then
                products.Status = 2
            Else
                MessageBox.Show("Selecione um dos checkbox")
            End If
            crudProducts.UpdateProducts(products)
            txtProdId.Clear()
            txtProdName.Clear()
            txtPrice.Clear()
            txtDateReg.Clear()
            chxActive.Checked = False
            chxInactive.Checked = False
            MessageBox.Show("Produto Atulizado com sucesso")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        products.ProdId = CInt(txtProdId.Text)

        Try
            products = crudProducts.SelectFiltroProducts(products)
            txtProdName.Text = products.ProdName
            txtPrice.Text = CStr(products.Price)
            txtDateReg.Text = CStr(products.DateReg)
            If products.Status = 1 Then
                chxActive.Checked = True
            ElseIf products.Status = 2 Then
                chxInactive.Checked = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
