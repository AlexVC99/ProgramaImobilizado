<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_bens = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_empresas = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_plano = New System.Windows.Forms.Button()
        Me.btn_bens = New System.Windows.Forms.Button()
        Me.btn_cadempresa = New System.Windows.Forms.Button()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(509, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sistema Imobilizado"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.RectangleShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(961, 421)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -5
        Me.LineShape2.X2 = 956
        Me.LineShape2.Y1 = 1
        Me.LineShape2.Y2 = 1
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 515
        Me.LineShape1.X2 = 851
        Me.LineShape1.Y1 = 62
        Me.LineShape1.Y2 = 62
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.RoyalBlue
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.BorderColor = System.Drawing.Color.RoyalBlue
        Me.RectangleShape3.BorderWidth = 3
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.Ivory
        Me.RectangleShape3.Location = New System.Drawing.Point(311, 245)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(189, 118)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Ivory
        Me.RectangleShape1.Location = New System.Drawing.Point(120, 246)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(182, 118)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(155, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total de bens "
        '
        'lbl_bens
        '
        Me.lbl_bens.AutoSize = True
        Me.lbl_bens.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lbl_bens.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bens.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_bens.Location = New System.Drawing.Point(152, 274)
        Me.lbl_bens.Name = "lbl_bens"
        Me.lbl_bens.Size = New System.Drawing.Size(40, 37)
        Me.lbl_bens.TabIndex = 11
        Me.lbl_bens.Text = "0 "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Location = New System.Drawing.Point(340, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 21)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Empresas"
        '
        'lbl_empresas
        '
        Me.lbl_empresas.AutoSize = True
        Me.lbl_empresas.BackColor = System.Drawing.Color.RoyalBlue
        Me.lbl_empresas.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_empresas.Location = New System.Drawing.Point(354, 274)
        Me.lbl_empresas.Name = "lbl_empresas"
        Me.lbl_empresas.Size = New System.Drawing.Size(40, 37)
        Me.lbl_empresas.TabIndex = 30
        Me.lbl_empresas.Text = "0 "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(64, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 25)
        Me.Label9.TabIndex = 38
        '
        'btnFechar
        '
        Me.btnFechar.BackgroundImage = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_excluir_60_1_
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFechar.Location = New System.Drawing.Point(920, 8)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(37, 32)
        Me.btnFechar.TabIndex = 40
        Me.btnFechar.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_manuseie_com_cuidado_48
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(752, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(97, 50)
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'btn_plano
        '
        Me.btn_plano.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_plano.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_plano.FlatAppearance.BorderSize = 2
        Me.btn_plano.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_plano.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plano.ForeColor = System.Drawing.Color.White
        Me.btn_plano.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_plano_de_construção_64_1_
        Me.btn_plano.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_plano.Location = New System.Drawing.Point(530, 245)
        Me.btn_plano.Name = "btn_plano"
        Me.btn_plano.Size = New System.Drawing.Size(329, 118)
        Me.btn_plano.TabIndex = 33
        Me.btn_plano.Text = "Plano de contas"
        Me.btn_plano.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_plano.UseVisualStyleBackColor = False
        '
        'btn_bens
        '
        Me.btn_bens.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_bens.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_bens.FlatAppearance.BorderSize = 2
        Me.btn_bens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_bens.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bens.ForeColor = System.Drawing.Color.White
        Me.btn_bens.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_caixa_96
        Me.btn_bens.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_bens.Location = New System.Drawing.Point(530, 102)
        Me.btn_bens.Name = "btn_bens"
        Me.btn_bens.Size = New System.Drawing.Size(329, 133)
        Me.btn_bens.TabIndex = 32
        Me.btn_bens.Text = "Movimentação e Relatorio de bens"
        Me.btn_bens.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_bens.UseVisualStyleBackColor = False
        '
        'btn_cadempresa
        '
        Me.btn_cadempresa.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cadempresa.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cadempresa.FlatAppearance.BorderSize = 2
        Me.btn_cadempresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadempresa.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadempresa.ForeColor = System.Drawing.Color.White
        Me.btn_cadempresa.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_nova_empresa_961
        Me.btn_cadempresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cadempresa.Location = New System.Drawing.Point(120, 102)
        Me.btn_cadempresa.Name = "btn_cadempresa"
        Me.btn_cadempresa.Size = New System.Drawing.Size(384, 133)
        Me.btn_cadempresa.TabIndex = 28
        Me.btn_cadempresa.Text = "Cadastro Empresas"
        Me.btn_cadempresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cadempresa.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(961, 421)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_plano)
        Me.Controls.Add(Me.btn_bens)
        Me.Controls.Add(Me.lbl_empresas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_cadempresa)
        Me.Controls.Add(Me.lbl_bens)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuPrincipal"
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_bens As Label
    Friend WithEvents btn_cadempresa As Button
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_empresas As Label
    Friend WithEvents btn_bens As Button
    Friend WithEvents btn_plano As Button
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnFechar As PictureBox
End Class
