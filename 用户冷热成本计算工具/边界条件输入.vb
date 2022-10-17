Public Class 边界条件输入
    Private Sub 载入默认值_Click(sender As Object, e As EventArgs) Handles 载入默认值.Click
        Dim xz = MsgBox("是否载入部分参数的默认值？", vbOKCancel)
        If xz = vbOK Then
            '载入部分默认值
            ZJNX.Text = 15 '折旧年限
            CZL.Text = 5 '设备残值率
            DKNX.Text = 15 '贷款年限
            DKNLL.Text = 4.9 '贷款年利率
            XLFL.Text = 2 '修理费率
            CLFXS.Text = 12 '材料费系数
            QTFXS.Text = 20 '其它费系数
            YYNX.Text = 20 '运营年限
            ZBJBL.Text = 20 '资本金比例
            ECTZNFXH.Text = 10 '二次投资发生的年份序号
            MsgBox("载入默认计算参数成功！")
        End If
    End Sub

    Private Sub 清空窗体_Click(sender As Object, e As EventArgs) Handles 清空窗体.Click
        Dim xz = MsgBox("是否需要清空全部文本框内容？", vbOKCancel)
        If xz = vbOK Then
            Dim ctl As Control
            For Each ctl In Controls
                If TypeOf ctl Is TextBox Then
                    ctl.Text = Nothing
                End If
            Next
        End If
    End Sub

    Private Sub 开始计算_Click(sender As Object, e As EventArgs) Handles 开始计算.Click
        On Error Resume Next
        Call 空文本框赋值为0()
        Call 计算主程序()
        Form2.Show()
        Form2.Activate()
    End Sub
    Private Sub 清除异常_Click(sender As Object, e As EventArgs) Handles 清除异常.Click
        '清空不是数字的内容
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Text = "非数字" Then
                    ctl.Text = 0
                End If
                If ctl.Text = "无穷大" Then
                    ctl.Text = 0
                End If
                If ctl.Text = "NaN" Then
                    ctl.Text = 0
                End If
            End If
        Next
    End Sub
    Private Sub 计算主程序()
        On Error Resume Next
        '计算固定成本分摊比例
        Dim days_L = CInt(Me.days_L.Text) '全年供冷天数（V1.2版本中改为供冷占比）
        Dim days_R = CInt(Me.days_R.Text) '全年供热天数（V1.2版本中改为供热占比）
        '验证冷热占比相加是否等于100
        If days_L + days_R <> 100 Then
            MsgBox("输入的供冷分摊比例和供热分摊比例之和必须等于100，请重新输入")
            Exit Sub
        End If
        Dim GDCBBL_L = (days_L / (days_L + days_R)) '供冷分摊的固定成本比例
        Dim GDCBBL_R = (days_R / (days_L + days_R))  '供热分摊的固定成本比例
        '计算二次投资发生时，还剩下的运营期年限数量百分比
        Dim ECTZ_NFSBL = (CInt(Me.YYNX.Text) - CInt(Me.ECTZNFXH.Text)) / CInt(Me.YYNX.Text) '二次投资年份数比例
        '读取冷热量
        Dim GNZL_L_N = CDbl(Me.GNZL_L.Text) '全年供冷总量
        Dim GNZL_R_N = CDbl(Me.GNZL_R.Text) '全年供热总量
        '计算各种动态投资
        Dim JTTZ_L = CDbl(Me.CTZ_L.Text) '制冷设备静态投资
        Dim JTTZ_R = CDbl(Me.CTZ_R.Text) '制热设备静态投资
        Dim DTTZ_L = 动态投资计算(JTTZ_L) '制冷设备动态投资
        Dim DTTZ_R = 动态投资计算(JTTZ_R) '制热设备动态投资
        Dim JTTZ_L_E = CDbl(Me.ECTZ_L.Text) '制冷设备二次静态投资
        Dim JTTZ_R_E = CDbl(Me.ECTZ_R.Text) '制热设备二次静态投资
        Dim DTTZ_L_E = 动态投资计算(JTTZ_L_E) '制冷设备二次动态投资
        Dim DTTZ_R_E = 动态投资计算(JTTZ_R_E) '制热设备二次动态投资
        '设备折旧
        Dim CZL = CDbl(Me.CZL.Text) '残值率
        Dim ZJNX = CDbl(Me.ZJNX.Text) '折旧年限
        Dim ZJCB_L_N = (（DTTZ_L + DTTZ_L_E） * (100 - CZL) / ZJNX) / 100 '每年的冷设备折旧成本，不考虑可抵扣增值税
        Dim ZJCB_R_N = (（DTTZ_R + DTTZ_R_E） * (100 - CZL) / ZJNX) / 100 '每年的热设备折旧成本，不考虑可抵扣增值税
        Form2.ZJF_L.Text = Math.Round(ZJCB_L_N / GNZL_L_N, 4).ToString
        Form2.ZJF_R.Text = Math.Round(ZJCB_R_N / GNZL_R_N, 4).ToString
        '修理费
        Dim XLFL = CDbl(Me.XLFL.Text) '修理费率
        Dim XLFCB_L_N = （DTTZ_L + DTTZ_L_E * ECTZ_NFSBL） * XLFL / 100 '每年的冷设备修理费成本，不考虑可抵扣增值税，二次投资乘以二次投资年分数比例系数
        Dim XLFCB_R_N = （DTTZ_R + DTTZ_R_E * ECTZ_NFSBL） * XLFL / 100 '每年的热设备修理费成本，不考虑可抵扣增值税，二次投资乘以二次投资年分数比例系数
        Form2.XLF_L.Text = Math.Round(XLFCB_L_N / GNZL_L_N, 4).ToString
        Form2.XLF_R.Text = Math.Round(XLFCB_R_N / GNZL_R_N, 4).ToString
        '用电成本
        Dim YDDJ = CDbl(Me.YDDJ.Text) '用电单价
        Dim YDZL_L = CDbl(Me.YDZL_L.Text) '制冷设备用电总量
        Dim YDZL_R = CDbl(Me.YDZL_R.Text) '制热设备用电总量
        Dim YDCB_L_N = YDDJ * YDZL_L '制冷设备全年用电成本
        Dim YDCB_R_N = YDDJ * YDZL_R '制热设备全年用电成本
        Form2.DF_L.Text = Math.Round(YDCB_L_N / GNZL_L_N, 4).ToString
        Form2.DF_R.Text = Math.Round(YDCB_R_N / GNZL_R_N, 4).ToString
        '天然气成本
        Dim TRQDJ = CDbl(Me.TRQDJ.Text) '天然气单价
        Dim TRQZL_L = CDbl(Me.TRQZL_L.Text) '制冷设备天然气总量
        Dim TRQZL_R = CDbl(Me.TRQZL_R.Text) '制热设备天然气总量
        Dim TRQCB_L_N = TRQDJ * TRQZL_L '制冷设备全年天然气成本
        Dim TRQCB_R_N = TRQDJ * TRQZL_R '制热设备全年天然气成本
        Form2.TRQF_L.Text = Math.Round(TRQDJ * TRQZL_L / GNZL_L_N, 4).ToString
        Form2.TRQF_R.Text = Math.Round(TRQDJ * TRQZL_R / GNZL_R_N, 4).ToString
        '补水成本
        Dim BSDJ = CDbl(Me.BSDJ.Text) '补水单价
        Dim BSZL_L = CDbl(Me.YSZL_L.Text) '制冷设备用水总量
        Dim BSZL_R = CDbl(Me.YSZL_R.Text) '制热设备用水总量
        Dim BSCB_L_N = BSDJ * BSZL_L '制冷设备全年用水成本
        Dim BSCB_R_N = BSDJ * BSZL_R '制热设备全年用水成本
        Form2.SF_L.Text = Math.Round(BSCB_L_N / GNZL_L_N, 4).ToString
        Form2.SF_R.Text = Math.Round(BSCB_R_N / GNZL_R_N, 4).ToString
        '材料和其它费
        Dim CLQTF = (CDbl(Me.CLFXS.Text) + CDbl(Me.QTFXS.Text)) / 1000
        Form2.CLF_L.Text = CLQTF.ToString
        Form2.CLF_R.Text = CLQTF.ToString
        '人工费
        Dim RGCB = CDbl(Me.RGCB.Text) '人工总成本
        Dim RGCB_L_N = RGCB * GDCBBL_L
        Dim RGCB_R_N = RGCB * GDCBBL_R
        Form2.RGF_L.Text = Math.Round(RGCB * GDCBBL_L / GNZL_L_N, 4).ToString '按照固定成本分摊比例计算
        Form2.RGF_R.Text = Math.Round(RGCB * GDCBBL_R / GNZL_R_N, 4).ToString '按照固定成本分摊比例计算
        '变压器容量成本
        Dim BYQRL_L = CDbl(Me.BYQRL_L.Text) '制冷设备变压器容量
        Dim BYQRL_R = CDbl(Me.BYQRL_R.Text) '制热设备变压器容量
        Dim BYQRL = Math.Max(BYQRL_L, BYQRL_R) '取大值
        Dim BYQRLDJ = CDbl(Me.RLFDJ.Text) '变压器容量费单价
        Dim BYQRLF_L_N = BYQRL * BYQRLDJ * 12 * GDCBBL_L / 10000 '制冷设备全年变压器容量成本
        Dim BYQRLF_R_N = BYQRL * BYQRLDJ * 12 * GDCBBL_R / 10000 '制热设备全年变压器容量成本
        Form2.DRLF_L.Text = Math.Round(BYQRLF_L_N / GNZL_L_N, 4).ToString
        Form2.DRLF_R.Text = Math.Round(BYQRLF_R_N / GNZL_R_N, 4).ToString
        '其它固定成本
        Dim QTGDCB = CDbl(Me.QTGDCB.Text) '其它固定成本金额
        Dim QTGDCB_L_N = QTGDCB * GDCBBL_L
        Dim QTGDCB_R_N = QTGDCB * GDCBBL_R
        Form2.QTGDCB_L.Text = Math.Round(QTGDCB * GDCBBL_L / GNZL_L_N, 4).ToString '按照固定成本分摊比例计算
        Form2.QTGDCB_R.Text = Math.Round(QTGDCB * GDCBBL_R / GNZL_R_N, 4).ToString '按照固定成本分摊比例计算
        '长期贷款利息成本
        Dim YYNX = CInt(Me.YYNX.Text)
        Dim DKNX1 = CInt(Me.DKNX.Text)
        Dim DKNX2 = CInt(Me.DKNX.Text) - Math.Round(YYNX * (1 - ECTZ_NFSBL), 0)
        Dim DKLX_L_N = (长期贷款利息总额(JTTZ_L, DKNX1) + 长期贷款利息总额(JTTZ_L_E, DKNX2)) / DKNX1
        Dim DKLX_R_N = (长期贷款利息总额(JTTZ_R, DKNX1) + 长期贷款利息总额(JTTZ_R_E, DKNX2)) / DKNX1
        Form2.DKLX_L.Text = Math.Round(DKLX_L_N / GNZL_L_N, 4).ToString
        Form2.DKLX_R.Text = Math.Round(DKLX_R_N / GNZL_R_N, 4).ToString
        '成本合计
        Form2.ZCB_L.Text = Math.Round((BYQRLF_L_N + YDCB_L_N + TRQCB_L_N + BSCB_L_N + XLFCB_L_N + RGCB_L_N + ZJCB_L_N + DKLX_L_N + QTGDCB_L_N) / GNZL_L_N + CLQTF, 4).ToString
        Form2.ZCB_R.Text = Math.Round((BYQRLF_R_N + YDCB_R_N + TRQCB_R_N + BSCB_R_N + XLFCB_R_N + RGCB_R_N + ZJCB_R_N + DKLX_R_N + QTGDCB_R_N) / GNZL_R_N + CLQTF, 4).ToString
    End Sub

    Private Function 动态投资计算(ByVal JTTZ As Double)
        '需要输入的参数为静态投资
        Dim DKNLL = CDbl(Me.DKNLL.Text) '贷款年利率
        Dim ZBJBL = CDbl(Me.ZBJBL.Text) '资本金比例
        Dim JSQTZDKJE As Double = 0 '建设期投资贷款金额
        Dim JSTZZBJ As Double = 0 '建设投资资本金
        Dim JSQDKLX As Double = 0 '建设期贷款利息
        Dim DTTZ As Double = 0 '动态投资
        For i = 1 To 200 '迭代最大200次
            JSQDKLX = (JSQTZDKJE / 2) * DKNLL / 100
            JSTZZBJ = DTTZ * ZBJBL / 100
            JSQTZDKJE = DTTZ - JSTZZBJ
            DTTZ = JTTZ + JSQDKLX
        Next
        Return DTTZ
    End Function

    Private Function 长期贷款利息总额(ByVal JTTZ As Double， ByVal DKNX As Double)
        Dim DKLXSUM As Double = 0 '长期贷款利息合计
        Dim DKNLL = CDbl(Me.DKNLL.Text) '贷款年利率
        Dim ZBJBL = CDbl(Me.ZBJBL.Text) '资本金比例
        Dim JSQTZDKJE As Double = 0 '建设期投资贷款金额
        Dim JSTZZBJ As Double = 0 '建设投资资本金
        Dim JSQDKLX As Double = 0 '建设期贷款利息
        Dim DTTZ As Double = 0 '动态投资
        For i = 1 To 200 '迭代最大200次
            JSQDKLX = (JSQTZDKJE / 2) * DKNLL / 100
            JSTZZBJ = DTTZ * ZBJBL / 100
            JSQTZDKJE = DTTZ - JSTZZBJ
            DTTZ = JTTZ + JSQDKLX
        Next
        Dim CQDKNX = DKNX '贷款年限
        Dim BXZH = (JSQTZDKJE * (DKNLL / 100) * (1 + DKNLL / 100) ^ CQDKNX) / (((1 + DKNLL / 100) ^ CQDKNX) - 1) '等额本息贷款每年还本付息额
        Dim SYDKE As Double = JSQTZDKJE '剩余的贷款金额，初始值为建设期贷款额
        Dim DQFX As Double = 0 '当期付息额
        Dim DQHB As Double '当期还本
        For i = 1 To CQDKNX '初投资利息总额计算
            DQFX = SYDKE * (DKNLL / 100)
            DQHB = BXZH - DQFX
            DKLXSUM = DKLXSUM + DQFX
            SYDKE = SYDKE - DQHB
        Next
        Return DKLXSUM
    End Function

    Private Sub 空文本框赋值为0()
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Text = Nothing Then
                    ctl.Text = 0
                End If
            End If
        Next
    End Sub

    Private Sub 边界条件输入_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '清空不是数字的内容
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then
                If ctl.Text = "非数字" Then
                    ctl.Text = 0
                End If
                If ctl.Text = "无穷大" Then
                    ctl.Text = 0
                End If
                If ctl.Text = "NaN" Then
                    ctl.Text = 0
                End If
            End If
        Next
        '载入部分默认值
        ZJNX.Text = 15 '折旧年限
        CZL.Text = 5 '设备残值率
        DKNX.Text = 15 '贷款年限
        DKNLL.Text = 4.9 '贷款年利率
        XLFL.Text = 2 '修理费率
        CLFXS.Text = 12 '材料费系数
        QTFXS.Text = 20 '其它费系数
        YYNX.Text = 20 '运营年限
        ZBJBL.Text = 20 '资本金比例
        ECTZNFXH.Text = 10 '二次投资发生的年份序号
        '设置按键捕捉
        MyBase.KeyPreview = True
    End Sub
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim key As String
        key = e.KeyChar
        '检验按键是否为回车键，如果是就把焦点附给按钮1，并执行Click命令
        If key = ChrW(13) Then
            开始计算.Focus()
            开始计算.PerformClick()
        End If
    End Sub

    Private Sub 边界条件输入_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        '关闭其它窗体
        设备年耗量计算.Close()
        计算结果显示.Close()
        计算方式选择.Close()
    End Sub
End Class