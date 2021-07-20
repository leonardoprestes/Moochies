<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDateReg = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chxActive = New System.Windows.Forms.CheckBox()
        Me.chxInactive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdId = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ProdName :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DateReg :"
        '
        'txtDateReg
        '
        Me.txtDateReg.Location = New System.Drawing.Point(74, 120)
        Me.txtDateReg.Name = "txtDateReg"
        Me.txtDateReg.Size = New System.Drawing.Size(294, 20)
        Me.txtDateReg.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(55, 59)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(294, 20)
        Me.txtPrice.TabIndex = 7
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(74, 24)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(294, 20)
        Me.txtProdName.TabIndex = 8
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(12, 158)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 12
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(118, 158)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 13
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(260, 158)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Location = New System.Drawing.Point(369, 158)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizar.TabIndex = 15
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 187)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(773, 384)
        Me.DataGridView1.TabIndex = 16
        '
        'chxActive
        '
        Me.chxActive.AutoSize = True
        Me.chxActive.Location = New System.Drawing.Point(61, 92)
        Me.chxActive.Name = "chxActive"
        Me.chxActive.Size = New System.Drawing.Size(56, 17)
        Me.chxActive.TabIndex = 17
        Me.chxActive.Text = "Active"
        Me.chxActive.UseVisualStyleBackColor = True
        '
        'chxInactive
        '
        Me.chxInactive.AutoSize = True
        Me.chxInactive.Location = New System.Drawing.Point(142, 92)
        Me.chxInactive.Name = "chxInactive"
        Me.chxInactive.Size = New System.Drawing.Size(64, 17)
        Me.chxInactive.TabIndex = 18
        Me.chxInactive.Text = "Inactive"
        Me.chxInactive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ProdId"
        '
        'txtProdId
        '
        Me.txtProdId.Location = New System.Drawing.Point(479, 24)
        Me.txtProdId.Name = "txtProdId"
        Me.txtProdId.Size = New System.Drawing.Size(104, 20)
        Me.txtProdId.TabIndex = 20
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(633, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 583)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtProdId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chxInactive)
        Me.Controls.Add(Me.chxActive)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDateReg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDateReg As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents btnInserir As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chxActive As CheckBox
    Friend WithEvents chxInactive As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProdId As TextBox
    Friend WithEvents btnBuscar As Button
End Class
