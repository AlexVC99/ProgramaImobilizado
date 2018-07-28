<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cadastrodebens
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.PictureBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.dgv_controle = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContaBem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrição = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Taxadep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAtual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDepr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_adicionar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BtnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_controle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(275, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 32)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Controle de bens"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscar)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Controls.Add(Me.txt_codigo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(24, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(725, 88)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empresa"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_detetive_filled_50
        Me.BtnBuscar.Location = New System.Drawing.Point(651, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(62, 50)
        Me.BtnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnBuscar.TabIndex = 68
        Me.BtnBuscar.TabStop = False
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(248, 48)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(372, 18)
        Me.txt_nome.TabIndex = 67
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_codigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(12, 50)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(202, 18)
        Me.txt_codigo.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(9, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(247, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 21)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Nome:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 23)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(719, 62)
        Me.ShapeContainer1.TabIndex = 47
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape2.CornerRadius = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(240, 21)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(388, 26)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.CornerRadius = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 23)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(213, 26)
        '
        'dgv_controle
        '
        Me.dgv_controle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_controle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.ContaBem, Me.Descrição, Me.ValorBase, Me.Taxadep, Me.ValorAtual, Me.ValorDepr})
        Me.dgv_controle.Location = New System.Drawing.Point(5, 207)
        Me.dgv_controle.Name = "dgv_controle"
        Me.dgv_controle.Size = New System.Drawing.Size(743, 207)
        Me.dgv_controle.TabIndex = 66
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'ContaBem
        '
        Me.ContaBem.HeaderText = "ContaBem"
        Me.ContaBem.Name = "ContaBem"
        '
        'Descrição
        '
        Me.Descrição.HeaderText = "Descrição"
        Me.Descrição.Name = "Descrição"
        '
        'ValorBase
        '
        Me.ValorBase.HeaderText = "Valor Base"
        Me.ValorBase.Name = "ValorBase"
        '
        'Taxadep
        '
        Me.Taxadep.HeaderText = "Taxa Dep"
        Me.Taxadep.Name = "Taxadep"
        '
        'ValorAtual
        '
        Me.ValorAtual.HeaderText = "Valor Atual"
        Me.ValorAtual.Name = "ValorAtual"
        '
        'ValorDepr
        '
        Me.ValorDepr.HeaderText = "Valor Depreciado"
        Me.ValorDepr.Name = "ValorDepr"
        '
        'btn_adicionar
        '
        Me.btn_adicionar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_adicionar.Enabled = False
        Me.btn_adicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.btn_adicionar.FlatAppearance.BorderSize = 2
        Me.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_adicionar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_adicionar.ForeColor = System.Drawing.Color.White
        Me.btn_adicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_adicionar.Location = New System.Drawing.Point(532, 424)
        Me.btn_adicionar.Name = "btn_adicionar"
        Me.btn_adicionar.Size = New System.Drawing.Size(209, 56)
        Me.btn_adicionar.TabIndex = 67
        Me.btn_adicionar.Text = "Adicionar bem "
        Me.btn_adicionar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox2.BackgroundImage = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_excluir_60_1_
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(718, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape9.Location = New System.Drawing.Point(0, 3)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(761, 83)
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.RectangleShape9})
        Me.ShapeContainer2.Size = New System.Drawing.Size(761, 501)
        Me.ShapeContainer2.TabIndex = 68
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 261
        Me.LineShape3.X2 = 498
        Me.LineShape3.Y1 = 36
        Me.LineShape3.Y2 = 36
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.LineShape2.BorderWidth = 4
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -31
        Me.LineShape2.X2 = 815
        Me.LineShape2.Y1 = 1
        Me.LineShape2.Y2 = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(271, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Pesquise por codigo ou nome "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(232, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Adicione ou exclua os bens por empresa "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(290, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 56)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Gerar relatorio "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cadastrodebens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(761, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_adicionar)
        Me.Controls.Add(Me.dgv_controle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cadastrodebens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrodebens"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BtnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_controle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents dgv_controle As DataGridView
    Friend WithEvents BtnBuscar As PictureBox
    Friend WithEvents btn_adicionar As Button
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents ContaBem As DataGridViewTextBoxColumn
    Friend WithEvents Descrição As DataGridViewTextBoxColumn
    Friend WithEvents ValorBase As DataGridViewTextBoxColumn
    Friend WithEvents Taxadep As DataGridViewTextBoxColumn
    Friend WithEvents ValorAtual As DataGridViewTextBoxColumn
    Friend WithEvents ValorDepr As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
