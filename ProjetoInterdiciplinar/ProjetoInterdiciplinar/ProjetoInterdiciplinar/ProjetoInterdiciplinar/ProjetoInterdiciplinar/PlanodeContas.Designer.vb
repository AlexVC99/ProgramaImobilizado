<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanodeContas
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
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_planocontas = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnFechar = New System.Windows.Forms.PictureBox()
        Me.Btn_CriarConta = New System.Windows.Forms.Button()
        CType(Me.dgv_planocontas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.CornerRadius = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(499, 42)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(276, 26)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2, Me.RectangleShape8, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(787, 471)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 42
        Me.LineShape1.X2 = 301
        Me.LineShape1.Y1 = 88
        Me.LineShape1.Y2 = 88
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -1
        Me.LineShape2.X2 = 917
        Me.LineShape2.Y1 = 1
        Me.LineShape2.Y2 = 1
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape8.FillColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape8.FillGradientColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape8.Location = New System.Drawing.Point(-2, 3)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(349, 469)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(354, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Pesquise Contas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(111, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 32)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Controle"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(98, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Realize Cadastro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(97, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Adição de contas"
        '
        'dgv_planocontas
        '
        Me.dgv_planocontas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_planocontas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nome})
        Me.dgv_planocontas.Location = New System.Drawing.Point(358, 87)
        Me.dgv_planocontas.Name = "dgv_planocontas"
        Me.dgv_planocontas.Size = New System.Drawing.Size(426, 372)
        Me.dgv_planocontas.TabIndex = 34
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo:"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 182
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome:"
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 200
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_busca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca.Location = New System.Drawing.Point(502, 45)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(269, 20)
        Me.txt_busca.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(69, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Plano de Contas "
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_excluir_60_1_
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFechar.Location = New System.Drawing.Point(747, 6)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(37, 32)
        Me.btnFechar.TabIndex = 41
        Me.btnFechar.TabStop = False
        '
        'Btn_CriarConta
        '
        Me.Btn_CriarConta.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_CriarConta.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_CriarConta.FlatAppearance.BorderSize = 2
        Me.Btn_CriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CriarConta.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CriarConta.ForeColor = System.Drawing.Color.White
        Me.Btn_CriarConta.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_mais_48
        Me.Btn_CriarConta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_CriarConta.Location = New System.Drawing.Point(83, 204)
        Me.Btn_CriarConta.Name = "Btn_CriarConta"
        Me.Btn_CriarConta.Size = New System.Drawing.Size(180, 116)
        Me.Btn_CriarConta.TabIndex = 30
        Me.Btn_CriarConta.Text = "Novo Plano de contas"
        Me.Btn_CriarConta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_CriarConta.UseVisualStyleBackColor = False
        '
        'PlanodeContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(787, 471)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_busca)
        Me.Controls.Add(Me.dgv_planocontas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_CriarConta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PlanodeContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControleUsuarios"
        CType(Me.dgv_planocontas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Btn_CriarConta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_planocontas As DataGridView
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFechar As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
End Class
