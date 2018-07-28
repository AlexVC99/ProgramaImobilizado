<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrodePlanodeContas
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
        Me.dgv_contas = New System.Windows.Forms.DataGridView()
        Me.Chamada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Classificação = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.rdb_credora = New System.Windows.Forms.RadioButton()
        Me.rdb_dev = New System.Windows.Forms.RadioButton()
        Me.rdb_indefinida = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_chamada = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_taxa = New System.Windows.Forms.TextBox()
        Me.txt_classifica = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_contas
        '
        Me.dgv_contas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_contas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chamada, Me.Classificação, Me.Descrição})
        Me.dgv_contas.Location = New System.Drawing.Point(369, 107)
        Me.dgv_contas.Name = "dgv_contas"
        Me.dgv_contas.Size = New System.Drawing.Size(370, 367)
        Me.dgv_contas.TabIndex = 41
        '
        'Chamada
        '
        Me.Chamada.HeaderText = "Chamada"
        Me.Chamada.Name = "Chamada"
        '
        'Classificação
        '
        Me.Classificação.HeaderText = "Classificação"
        Me.Classificação.Name = "Classificação"
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        Me.Descrição.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(257, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 32)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Cadastro de Contas"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_nome.Location = New System.Drawing.Point(124, 22)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(183, 20)
        Me.lbl_nome.TabIndex = 44
        Me.lbl_nome.Text = "Nome do plano de contas"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.CornerRadius = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(14, 188)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(348, 28)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape3, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(746, 497)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -67
        Me.LineShape2.X2 = 851
        Me.LineShape2.Y1 = 1
        Me.LineShape2.Y2 = 1
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 256
        Me.LineShape3.X2 = 493
        Me.LineShape3.Y1 = 39
        Me.LineShape3.Y2 = 39
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape5.Location = New System.Drawing.Point(0, 2)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(746, 85)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape4.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape4.CornerRadius = 2
        Me.RectangleShape4.Location = New System.Drawing.Point(233, 304)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(127, 28)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape3.CornerRadius = 2
        Me.RectangleShape3.Location = New System.Drawing.Point(13, 302)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(198, 28)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape2.CornerRadius = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(16, 244)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(348, 28)
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_codigo.Location = New System.Drawing.Point(8, 22)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(57, 20)
        Me.lbl_codigo.TabIndex = 46
        Me.lbl_codigo.Text = "Codigo"
        '
        'rdb_credora
        '
        Me.rdb_credora.AutoSize = True
        Me.rdb_credora.Location = New System.Drawing.Point(12, 30)
        Me.rdb_credora.Name = "rdb_credora"
        Me.rdb_credora.Size = New System.Drawing.Size(82, 24)
        Me.rdb_credora.TabIndex = 47
        Me.rdb_credora.TabStop = True
        Me.rdb_credora.Text = "Credora"
        Me.rdb_credora.UseVisualStyleBackColor = True
        '
        'rdb_dev
        '
        Me.rdb_dev.AutoSize = True
        Me.rdb_dev.Location = New System.Drawing.Point(111, 30)
        Me.rdb_dev.Name = "rdb_dev"
        Me.rdb_dev.Size = New System.Drawing.Size(94, 24)
        Me.rdb_dev.TabIndex = 48
        Me.rdb_dev.TabStop = True
        Me.rdb_dev.Text = "Devedora"
        Me.rdb_dev.UseVisualStyleBackColor = True
        '
        'rdb_indefinida
        '
        Me.rdb_indefinida.AutoSize = True
        Me.rdb_indefinida.Location = New System.Drawing.Point(227, 31)
        Me.rdb_indefinida.Name = "rdb_indefinida"
        Me.rdb_indefinida.Size = New System.Drawing.Size(96, 24)
        Me.rdb_indefinida.TabIndex = 49
        Me.rdb_indefinida.TabStop = True
        Me.rdb_indefinida.Text = "Indefinida"
        Me.rdb_indefinida.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdb_credora)
        Me.GroupBox1.Controls.Add(Me.rdb_indefinida)
        Me.GroupBox1.Controls.Add(Me.rdb_dev)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(15, 338)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 78)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origem"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(10, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Chamada:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(9, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Classificação Interna:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(11, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Descrição de conta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(229, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 21)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Taxa depreciação:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_codigo)
        Me.GroupBox2.Controls.Add(Me.lbl_nome)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(14, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 52)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Plano de contas"
        '
        'btn_gravar
        '
        Me.btn_gravar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_gravar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_gravar.FlatAppearance.BorderSize = 2
        Me.btn_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar.ForeColor = System.Drawing.Color.White
        Me.btn_gravar.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_caixa_de_seleção_marcada_48
        Me.btn_gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_gravar.Location = New System.Drawing.Point(217, 425)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(136, 60)
        Me.btn_gravar.TabIndex = 55
        Me.btn_gravar.Text = "Gravar"
        Me.btn_gravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_gravar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox2.BackgroundImage = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_excluir_60_1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(702, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'txt_chamada
        '
        Me.txt_chamada.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_chamada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_chamada.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chamada.Location = New System.Drawing.Point(17, 193)
        Me.txt_chamada.Name = "txt_chamada"
        Me.txt_chamada.Size = New System.Drawing.Size(342, 18)
        Me.txt_chamada.TabIndex = 65
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(18, 307)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(186, 18)
        Me.txt_desc.TabIndex = 67
        '
        'txt_taxa
        '
        Me.txt_taxa.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_taxa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_taxa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_taxa.Location = New System.Drawing.Point(242, 310)
        Me.txt_taxa.Name = "txt_taxa"
        Me.txt_taxa.Size = New System.Drawing.Size(106, 18)
        Me.txt_taxa.TabIndex = 68
        '
        'txt_classifica
        '
        Me.txt_classifica.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_classifica.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_classifica.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_classifica.Location = New System.Drawing.Point(21, 249)
        Me.txt_classifica.Mask = "0-0-00-00-00"
        Me.txt_classifica.Name = "txt_classifica"
        Me.txt_classifica.Size = New System.Drawing.Size(338, 18)
        Me.txt_classifica.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(236, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Verifique as classificações disponiveis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(240, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Crie contas para seu plano de contas"
        '
        'CadastrodePlanodeContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(746, 497)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_classifica)
        Me.Controls.Add(Me.txt_taxa)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_chamada)
        Me.Controls.Add(Me.btn_gravar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_contas)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadastrodePlanodeContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadastrodePlanodeContas"
        CType(Me.dgv_contas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgv_contas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_nome As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents rdb_credora As RadioButton
    Friend WithEvents rdb_dev As RadioButton
    Friend WithEvents rdb_indefinida As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_gravar As Button
    Friend WithEvents txt_chamada As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_taxa As TextBox
    Friend WithEvents Chamada As DataGridViewTextBoxColumn
    Friend WithEvents Classificação As DataGridViewTextBoxColumn
    Friend WithEvents Descrição As DataGridViewTextBoxColumn
    Friend WithEvents txt_classifica As MaskedTextBox
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
