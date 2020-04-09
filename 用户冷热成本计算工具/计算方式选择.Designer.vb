<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 计算方式选择
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.新建项目 = New System.Windows.Forms.Button()
        Me.导入数据 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '新建项目
        '
        Me.新建项目.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.新建项目.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.新建项目.Location = New System.Drawing.Point(50, 23)
        Me.新建项目.Name = "新建项目"
        Me.新建项目.Size = New System.Drawing.Size(125, 62)
        Me.新建项目.TabIndex = 76
        Me.新建项目.Text = "新建项目"
        Me.新建项目.UseVisualStyleBackColor = False
        '
        '导入数据
        '
        Me.导入数据.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.导入数据.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.导入数据.Location = New System.Drawing.Point(50, 102)
        Me.导入数据.Name = "导入数据"
        Me.导入数据.Size = New System.Drawing.Size(125, 62)
        Me.导入数据.TabIndex = 77
        Me.导入数据.Text = "导入数据"
        Me.导入数据.UseVisualStyleBackColor = False
        '
        '计算方式选择
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 189)
        Me.Controls.Add(Me.导入数据)
        Me.Controls.Add(Me.新建项目)
        Me.Name = "计算方式选择"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计算方式选择"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 新建项目 As Button
    Friend WithEvents 导入数据 As Button
End Class
