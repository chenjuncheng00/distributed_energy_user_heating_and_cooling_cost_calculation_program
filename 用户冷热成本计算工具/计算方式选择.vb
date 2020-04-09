Imports Microsoft.Office.Interop
Public Class 计算方式选择
    Private Sub 新建项目_Click(sender As Object, e As EventArgs) Handles 新建项目.Click
        Form4.Show()
        Form4.Activate()
        Me.Hide()
    End Sub

    Private Sub 导入数据_Click(sender As Object, e As EventArgs) Handles 导入数据.Click
        On Error Resume Next
        '从特定的Excel模板导入数据
        '声明Excel相关
        Dim xlApp As Excel.Application
        Dim xlBook As Excel.Workbook = Nothing
        xlApp = New Excel.Application
        '获取指定excel文件
        Dim myFileName As String '定义要读取的文件路径
        myFileName = xlApp.GetOpenFilename("EXCEL文件(*.xlsx), *.xls") '浏览文件
        If myFileName = "False" Then '如果按取消那么弹出对话框
            MsgBox("请选择文件!", vbInformation, "取消")
            Exit Sub
        Else
            xlBook = xlApp.Workbooks.Open(myFileName) '先打开要复制的文件
        End If
        xlBook.Activate() '激活打开工作簿
        '--------------------------------------------------------------------------------------------------------------------
        '从Excel导入设备年耗量数据,并计算
        Form4.Show()
        Form4.Activate()
        Form4.GNZL_L_D.Text = xlBook.Worksheets("设备年耗量").Cells(3, 2).Value.ToString '电制冷全年总量
        Form4.GNZL_R_D.Text = xlBook.Worksheets("设备年耗量").Cells(3, 3).Value.ToString '电制热全年总量
        Form4.GNZL_L_Q.Text = xlBook.Worksheets("设备年耗量").Cells(7, 2).Value.ToString '天然气制冷全年总量
        Form4.GNZL_R_Q.Text = xlBook.Worksheets("设备年耗量").Cells(7, 3).Value.ToString '天然气制热全年总量
        Form4.DKTCOP_L.Text = xlBook.Worksheets("设备年耗量").Cells(4, 2).Value.ToString '电制冷空调COP
        Form4.DKTCOP_R.Text = xlBook.Worksheets("设备年耗量").Cells(4, 3).Value.ToString '电制热空调COP
        Form4.TRQXL_L.Text = xlBook.Worksheets("设备年耗量").Cells(8, 2).Value.ToString '天然气制冷设备效率
        Form4.TRQXL_R.Text = xlBook.Worksheets("设备年耗量").Cells(8, 3).Value.ToString '天然气制热设备效率
        Form4.ZJGL_L_D.Text = xlBook.Worksheets("设备年耗量").Cells(5, 2).Value.ToString '电制冷空调装机功率
        Form4.ZJGL_R_D.Text = xlBook.Worksheets("设备年耗量").Cells(5, 3).Value.ToString '电制热空调装机功率
        Form4.ZJGL_L_Q.Text = xlBook.Worksheets("设备年耗量").Cells(9, 2).Value.ToString '天然气制冷设备装机功率
        Form4.ZJGL_R_Q.Text = xlBook.Worksheets("设备年耗量").Cells(9, 3).Value.ToString '天然气制热设备装机功率
        Form4.确定数据.PerformClick()
        '从Excel导入输入的边界条件,并计算
        Form1.Show()
        Form1.Activate()
        Form1 = ActiveForm
        '必需要用户输入的边界条件
        Form1.RGCB.Text = xlBook.Worksheets("计算边界条件").Cells(4, 2).Value.ToString '人工成本
        Form1.YDDJ.Text = xlBook.Worksheets("计算边界条件").Cells(5, 2).Value.ToString '用电单价
        Form1.TRQDJ.Text = xlBook.Worksheets("计算边界条件").Cells(6, 2).Value.ToString '天然气单价
        Form1.RLFDJ.Text = xlBook.Worksheets("计算边界条件").Cells(5, 4).Value.ToString '变压器容量费
        Form1.BSDJ.Text = xlBook.Worksheets("计算边界条件").Cells(6, 4).Value.ToString '补水单价       
        Form1.QTGDCB.Text = xlBook.Worksheets("计算边界条件").Cells(9, 4).Value.ToString '其它固定成本
        Form1.days_L.Text = xlBook.Worksheets("计算边界条件").Cells(10, 2).Value.ToString '供冷天数
        Form1.days_R.Text = xlBook.Worksheets("计算边界条件").Cells(10, 4).Value.ToString '供热天数
        Form1.CTZ_L.Text = xlBook.Worksheets("计算边界条件").Cells(2, 7).Value.ToString '供冷设备初投资
        Form1.CTZ_R.Text = xlBook.Worksheets("计算边界条件").Cells(2, 8).Value.ToString '供热设备初投资
        Form1.ECTZ_L.Text = xlBook.Worksheets("计算边界条件").Cells(3, 7).Value.ToString '供冷设备二次投资
        Form1.ECTZ_R.Text = xlBook.Worksheets("计算边界条件").Cells(3, 8).Value.ToString '供热设备二次投资
        '用户可以选择性输入的边界条件，如果输入了，则用用户输入的数据，否则用原始默认值
        If xlBook.Worksheets("计算边界条件").Cells(2, 2).Value > 0 Then
            Form1.ZJNX.Text = xlBook.Worksheets("计算边界条件").Cells(2, 2).Value.ToString '折旧年限
        End If
        If xlBook.Worksheets("计算边界条件").Cells(2, 4).Value > 0 Then
            Form1.CZL.Text = xlBook.Worksheets("计算边界条件").Cells(2, 4).Value.ToString '设备残值率
        End If
        If xlBook.Worksheets("计算边界条件").Cells(3, 2).Value > 0 Then
            Form1.DKNX.Text = xlBook.Worksheets("计算边界条件").Cells(3, 2).Value.ToString '贷款年限
        End If
        If xlBook.Worksheets("计算边界条件").Cells(3, 4).Value > 0 Then
            Form1.DKNLL.Text = xlBook.Worksheets("计算边界条件").Cells(3, 4).Value.ToString  '贷款年利率
        End If
        If xlBook.Worksheets("计算边界条件").Cells(4, 4).Value > 0 Then
            Form1.XLFL.Text = xlBook.Worksheets("计算边界条件").Cells(4, 4).Value.ToString  '修理费率
        End If
        If xlBook.Worksheets("计算边界条件").Cells(7, 2).Value > 0 Then
            Form1.CLFXS.Text = xlBook.Worksheets("计算边界条件").Cells(7, 2).Value.ToString '材料费系数
        End If
        If xlBook.Worksheets("计算边界条件").Cells(7, 4).Value > 0 Then
            Form1.QTFXS.Text = xlBook.Worksheets("计算边界条件").Cells(7, 4).Value.ToString  '其它费系数
        End If
        If xlBook.Worksheets("计算边界条件").Cells(8, 2).Value > 0 Then
            Form1.YYNX.Text = xlBook.Worksheets("计算边界条件").Cells(8, 2).Value.ToString '运营年限
        End If
        If xlBook.Worksheets("计算边界条件").Cells(8, 4).Value > 0 Then
            Form1.ZBJBL.Text = xlBook.Worksheets("计算边界条件").Cells(8, 4).Value.ToString  '资本金比例
        End If
        If xlBook.Worksheets("计算边界条件").Cells(9, 2).Value > 0 Then
            Form1.ECTZNFXH.Text = xlBook.Worksheets("计算边界条件").Cells(9, 2).Value.ToString '二次投资发生的年份序号
        End If
        Form1.开始计算.PerformClick()
        Me.Hide()
        '退出Excel程序
        xlBook.Close()
        xlApp.Quit()
        '显示计算结果
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim key As String
        key = e.KeyChar
        '检验按键是否为回车键，如果是就把焦点附给按钮1，并执行Click命令
        If key = ChrW(13) Then
            新建项目.Focus()
            新建项目.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.KeyPreview = True
    End Sub

    Private Sub 计算方式选择_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        '关闭其它窗体
        LoginForm.Close()
        设备年耗量计算.Close()
        边界条件输入.Close()
        计算结果显示.Close()
    End Sub
End Class