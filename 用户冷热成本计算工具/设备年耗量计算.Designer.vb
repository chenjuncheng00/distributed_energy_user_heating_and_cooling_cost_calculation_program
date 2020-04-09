<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 设备年耗量计算
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GNZL_R_D = New System.Windows.Forms.TextBox()
        Me.GNZL_L_D = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DKTCOP_R = New System.Windows.Forms.TextBox()
        Me.DKTCOP_L = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ZJGL_R_D = New System.Windows.Forms.TextBox()
        Me.ZJGL_L_D = New System.Windows.Forms.TextBox()
        Me.GNZL_R_Q = New System.Windows.Forms.TextBox()
        Me.GNZL_L_Q = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TRQXL_R = New System.Windows.Forms.TextBox()
        Me.TRQXL_L = New System.Windows.Forms.TextBox()
        Me.ZJGL_R_Q = New System.Windows.Forms.TextBox()
        Me.ZJGL_L_Q = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.确定数据 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.清空窗体 = New System.Windows.Forms.Button()
        Me.参数建议 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "供能总量(万kWh/年)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "电制冷制热全年耗量计算"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(296, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 14)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "供热参数"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(158, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "供冷参数"
        '
        'GNZL_R_D
        '
        Me.GNZL_R_D.Location = New System.Drawing.Point(278, 72)
        Me.GNZL_R_D.Name = "GNZL_R_D"
        Me.GNZL_R_D.Size = New System.Drawing.Size(101, 21)
        Me.GNZL_R_D.TabIndex = 32
        Me.GNZL_R_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GNZL_L_D
        '
        Me.GNZL_L_D.Location = New System.Drawing.Point(140, 72)
        Me.GNZL_L_D.Name = "GNZL_L_D"
        Me.GNZL_L_D.Size = New System.Drawing.Size(101, 21)
        Me.GNZL_L_D.TabIndex = 31
        Me.GNZL_L_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "电空调综合COP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 12)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "天然气设备效率"
        '
        'DKTCOP_R
        '
        Me.DKTCOP_R.Location = New System.Drawing.Point(278, 99)
        Me.DKTCOP_R.Name = "DKTCOP_R"
        Me.DKTCOP_R.Size = New System.Drawing.Size(101, 21)
        Me.DKTCOP_R.TabIndex = 37
        Me.DKTCOP_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DKTCOP_L
        '
        Me.DKTCOP_L.Location = New System.Drawing.Point(140, 99)
        Me.DKTCOP_L.Name = "DKTCOP_L"
        Me.DKTCOP_L.Size = New System.Drawing.Size(101, 21)
        Me.DKTCOP_L.TabIndex = 36
        Me.DKTCOP_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "天然气制冷制热全年耗量计算"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "装机总功率(kW)"
        '
        'ZJGL_R_D
        '
        Me.ZJGL_R_D.Location = New System.Drawing.Point(278, 126)
        Me.ZJGL_R_D.Name = "ZJGL_R_D"
        Me.ZJGL_R_D.Size = New System.Drawing.Size(101, 21)
        Me.ZJGL_R_D.TabIndex = 44
        Me.ZJGL_R_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZJGL_L_D
        '
        Me.ZJGL_L_D.Location = New System.Drawing.Point(140, 126)
        Me.ZJGL_L_D.Name = "ZJGL_L_D"
        Me.ZJGL_L_D.Size = New System.Drawing.Size(101, 21)
        Me.ZJGL_L_D.TabIndex = 43
        Me.ZJGL_L_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GNZL_R_Q
        '
        Me.GNZL_R_Q.Location = New System.Drawing.Point(278, 218)
        Me.GNZL_R_Q.Name = "GNZL_R_Q"
        Me.GNZL_R_Q.Size = New System.Drawing.Size(101, 21)
        Me.GNZL_R_Q.TabIndex = 47
        Me.GNZL_R_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GNZL_L_Q
        '
        Me.GNZL_L_Q.Location = New System.Drawing.Point(140, 218)
        Me.GNZL_L_Q.Name = "GNZL_L_Q"
        Me.GNZL_L_Q.Size = New System.Drawing.Size(101, 21)
        Me.GNZL_L_Q.TabIndex = 46
        Me.GNZL_L_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 12)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "供能总量(万kWh/年)"
        '
        'TRQXL_R
        '
        Me.TRQXL_R.Location = New System.Drawing.Point(278, 245)
        Me.TRQXL_R.Name = "TRQXL_R"
        Me.TRQXL_R.Size = New System.Drawing.Size(101, 21)
        Me.TRQXL_R.TabIndex = 49
        Me.TRQXL_R.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TRQXL_L
        '
        Me.TRQXL_L.Location = New System.Drawing.Point(140, 245)
        Me.TRQXL_L.Name = "TRQXL_L"
        Me.TRQXL_L.Size = New System.Drawing.Size(101, 21)
        Me.TRQXL_L.TabIndex = 48
        Me.TRQXL_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZJGL_R_Q
        '
        Me.ZJGL_R_Q.Location = New System.Drawing.Point(278, 272)
        Me.ZJGL_R_Q.Name = "ZJGL_R_Q"
        Me.ZJGL_R_Q.Size = New System.Drawing.Size(101, 21)
        Me.ZJGL_R_Q.TabIndex = 52
        Me.ZJGL_R_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ZJGL_L_Q
        '
        Me.ZJGL_L_Q.Location = New System.Drawing.Point(140, 272)
        Me.ZJGL_L_Q.Name = "ZJGL_L_Q"
        Me.ZJGL_L_Q.Size = New System.Drawing.Size(101, 21)
        Me.ZJGL_L_Q.TabIndex = 51
        Me.ZJGL_L_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 12)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "装机总功率(kW)"
        '
        '确定数据
        '
        Me.确定数据.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.确定数据.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.确定数据.Location = New System.Drawing.Point(35, 308)
        Me.确定数据.Name = "确定数据"
        Me.确定数据.Size = New System.Drawing.Size(95, 49)
        Me.确定数据.TabIndex = 76
        Me.确定数据.Text = "确定数据"
        Me.确定数据.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "供热参数"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(158, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 14)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "供冷参数"
        '
        '清空窗体
        '
        Me.清空窗体.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.清空窗体.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.清空窗体.Location = New System.Drawing.Point(268, 308)
        Me.清空窗体.Name = "清空窗体"
        Me.清空窗体.Size = New System.Drawing.Size(95, 49)
        Me.清空窗体.TabIndex = 79
        Me.清空窗体.Text = "清空窗体"
        Me.清空窗体.UseVisualStyleBackColor = False
        '
        '参数建议
        '
        Me.参数建议.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.参数建议.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.参数建议.Location = New System.Drawing.Point(156, 308)
        Me.参数建议.Name = "参数建议"
        Me.参数建议.Size = New System.Drawing.Size(95, 49)
        Me.参数建议.TabIndex = 80
        Me.参数建议.Text = "参数建议"
        Me.参数建议.UseVisualStyleBackColor = False
        '
        '设备年耗量计算
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 376)
        Me.Controls.Add(Me.参数建议)
        Me.Controls.Add(Me.清空窗体)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.确定数据)
        Me.Controls.Add(Me.ZJGL_R_Q)
        Me.Controls.Add(Me.ZJGL_L_Q)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TRQXL_R)
        Me.Controls.Add(Me.TRQXL_L)
        Me.Controls.Add(Me.GNZL_R_Q)
        Me.Controls.Add(Me.GNZL_L_Q)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ZJGL_R_D)
        Me.Controls.Add(Me.ZJGL_L_D)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DKTCOP_R)
        Me.Controls.Add(Me.DKTCOP_L)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GNZL_R_D)
        Me.Controls.Add(Me.GNZL_L_D)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "设备年耗量计算"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "设备年耗量计算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GNZL_R_D As TextBox
    Friend WithEvents GNZL_L_D As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DKTCOP_R As TextBox
    Friend WithEvents DKTCOP_L As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ZJGL_R_D As TextBox
    Friend WithEvents ZJGL_L_D As TextBox
    Friend WithEvents GNZL_R_Q As TextBox
    Friend WithEvents GNZL_L_Q As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TRQXL_R As TextBox
    Friend WithEvents TRQXL_L As TextBox
    Friend WithEvents ZJGL_R_Q As TextBox
    Friend WithEvents ZJGL_L_Q As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents 确定数据 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents 清空窗体 As Button
    Friend WithEvents 参数建议 As Button
End Class
