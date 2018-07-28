<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastroEmpresas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_empresas = New System.Windows.Forms.DataGridView()
        Me.cadi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape8.CornerRadius = 2
        Me.RectangleShape8.FillColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape8.FillGradientColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape8.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(388, 471)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.LineShape1, Me.RectangleShape8})
        Me.ShapeContainer1.Size = New System.Drawing.Size(865, 470)
        Me.ShapeContainer1.TabIndex = 42
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.CornerRadius = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(422, 70)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(392, 26)
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 54
        Me.LineShape1.X2 = 340
        Me.LineShape1.Y1 = 93
        Me.LineShape1.Y2 = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(96, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 25)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "alteração e exclução"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(62, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(267, 25)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Realize cadastro de empresas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(59, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 32)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Cadastro de Empresas"
        '
        'dgv_empresas
        '
        Me.dgv_empresas.AllowUserToAddRows = False
        Me.dgv_empresas.AllowUserToDeleteRows = False
        Me.dgv_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cadi, Me.nom, Me.estad, Me.cj, Me.CRC})
        Me.dgv_empresas.Location = New System.Drawing.Point(397, 112)
        Me.dgv_empresas.Name = "dgv_empresas"
        Me.dgv_empresas.ReadOnly = True
        Me.dgv_empresas.Size = New System.Drawing.Size(464, 346)
        Me.dgv_empresas.TabIndex = 46
        '
        'cadi
        '
        Me.cadi.HeaderText = "Cadastro"
        Me.cadi.Name = "cadi"
        Me.cadi.ReadOnly = True
        Me.cadi.Width = 70
        '
        'nom
        '
        Me.nom.HeaderText = "Nome"
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        '
        'estad
        '
        Me.estad.HeaderText = "UF"
        Me.estad.Name = "estad"
        Me.estad.ReadOnly = True
        Me.estad.Width = 35
        '
        'cj
        '
        Me.cj.HeaderText = "CNPJ"
        Me.cj.Name = "cj"
        Me.cj.ReadOnly = True
        Me.cj.Width = 115
        '
        'CRC
        '
        Me.CRC.HeaderText = "Creci"
        Me.CRC.Name = "CRC"
        Me.CRC.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(432, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 21)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Cadastro/Nome :"
        '
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_busca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca.Location = New System.Drawing.Point(426, 75)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(372, 18)
        Me.txt_busca.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_alianças_de_casamento_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(209, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 94)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Vincular Conta"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cadastro.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cadastro.FlatAppearance.BorderSize = 2
        Me.btn_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastro.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastro.ForeColor = System.Drawing.Color.White
        Me.btn_cadastro.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_adicionar_64
        Me.btn_cadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cadastro.Location = New System.Drawing.Point(41, 251)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(162, 94)
        Me.btn_cadastro.TabIndex = 47
        Me.btn_cadastro.Text = "Adicionar Conta"
        Me.btn_cadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_excluir_60_1_
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFechar.Location = New System.Drawing.Point(816, 12)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(37, 32)
        Me.btnFechar.TabIndex = 41
        Me.btnFechar.TabStop = False
        '
        'CadastroEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(865, 470)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_busca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.dgv_empresas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadastroEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadastroEmpresas"
        CType(Me.dgv_empresas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFechar As PictureBox
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents dgv_empresas As DataGridView
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents cadi As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
    Friend WithEvents estad As DataGridViewTextBoxColumn
    Friend WithEvents cj As DataGridViewTextBoxColumn
    Friend WithEvents CRC As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
