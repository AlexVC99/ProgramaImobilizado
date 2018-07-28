<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorio
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BensBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bancoDataSet1 = New ProjetoInterdiciplinar.bancoDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BensTableAdapter = New ProjetoInterdiciplinar.bancoDataSet1TableAdapters.BensTableAdapter()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.PictureBox()
        CType(Me.BensBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bancoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BensBindingSource
        '
        Me.BensBindingSource.DataMember = "Bens"
        Me.BensBindingSource.DataSource = Me.bancoDataSet1
        '
        'bancoDataSet1
        '
        Me.bancoDataSet1.DataSetName = "bancoDataSet1"
        Me.bancoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.BensBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoInterdiciplinar.ReportBens.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 85)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(665, 281)
        Me.ReportViewer1.TabIndex = 0
        '
        'BensTableAdapter
        '
        Me.BensTableAdapter.ClearBeforeFill = True
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RectangleShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.RectangleShape9.Location = New System.Drawing.Point(-4, -2)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(801, 86)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.RectangleShape9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(663, 369)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 204
        Me.LineShape3.X2 = 412
        Me.LineShape3.Y1 = 41
        Me.LineShape3.Y2 = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(259, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Relatorio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(131, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(336, 20)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Imprima ou compartilhe em pdf  seus relatorios "
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFechar.Image = Global.ProjetoInterdiciplinar.My.Resources.Resources.icons8_excluir_60_1_1
        Me.btnFechar.Location = New System.Drawing.Point(613, 3)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(38, 35)
        Me.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnFechar.TabIndex = 58
        Me.btnFechar.TabStop = False
        '
        'Relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 369)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Relatorio"
        Me.Text = "Relatorio"
        CType(Me.BensBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bancoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BensBindingSource As BindingSource
    Friend WithEvents bancoDataSet1 As bancoDataSet1
    Friend WithEvents BensTableAdapter As bancoDataSet1TableAdapters.BensTableAdapter
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents Label7 As Label
    Friend WithEvents btnFechar As PictureBox
End Class
