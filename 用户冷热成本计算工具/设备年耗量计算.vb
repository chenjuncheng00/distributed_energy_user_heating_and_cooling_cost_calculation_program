Public Class 设备年耗量计算
    Private Sub 确定数据_Click(sender As Object, e As EventArgs) Handles 确定数据.Click
        On Error Resume Next
        Call 空文本框赋值为0()
        Call 计算主程序()
        Form1.Show()
        Form1.Activate()
    End Sub

    Private Sub 计算主程序()
        On Error Resume Next
        '读入基本数据
        Dim GNZL_L_D = CDbl(Me.GNZL_L_D.Text) '电空调供冷总量
        Dim GNZL_R_D = CDbl(Me.GNZL_R_D.Text) '电空调供热总量
        Dim GNZL_L_Q = CDbl(Me.GNZL_L_Q.Text) '天然气设备供冷总量
        Dim GNZL_R_Q = CDbl(Me.GNZL_R_Q.Text) '天然气设备供热总量
        Dim DKTCOP_L = CDbl(Me.DKTCOP_L.Text) '电空调供冷COP
        Dim DKTCOP_R = CDbl(Me.DKTCOP_R.Text) '电空调供热COP
        Dim ZJGL_L_D = CDbl(Me.ZJGL_L_D.Text) '电空调供冷装机功率
        Dim ZJGL_R_D = CDbl(Me.ZJGL_R_D.Text) '电空调供热装机功率
        Dim ZJGL_L_Q = CDbl(Me.ZJGL_L_Q.Text) '天然气设备供冷装机功率
        Dim ZJGL_R_Q = CDbl(Me.ZJGL_R_Q.Text) '天然气设备供热装机功率
        Dim TRQXL_L = CDbl(Me.TRQXL_L.Text) '天然气设备供冷效率
        Dim TRQXL_R = CDbl(Me.TRQXL_R.Text) '天然气设备供热效率
        '定义其他默认参数
        Dim TRQCOP_L = 13.3 '天然气设备供冷电COP
        Dim TRQCOP_R = 40 '天然气设备供热电COP
        Dim WCHZ = 21 '5摄氏度水温差比焓为21kj/kg
        Dim LQSBSL = 0.015 '冷却水补水率
        Dim MJSBSL = 0.0015 '冷热媒介水补水率
        Dim TRQRZ = 34000 '天然气热值
        '全年供冷供热量
        Form1.GNZL_L.Text = Math.Round(GNZL_L_D + GNZL_L_Q, 2)
        Form1.GNZL_R.Text = Math.Round(GNZL_R_D + GNZL_R_Q, 2)
        '计算变压器容量
        '冷
        If DKTCOP_L = 0 And TRQCOP_L > 0 Then '电空调制冷COP=0，天然气空调制冷COP>0
            Form1.BYQRL_L.Text = Math.Round((ZJGL_L_Q / TRQCOP_L) / 0.8, 2).ToString
        ElseIf DKTCOP_L > 0 And TRQCOP_L = 0 Then '电空调制冷COP>0，天然气空调制冷COP=0
            Form1.BYQRL_L.Text = Math.Round((ZJGL_L_D / DKTCOP_L) / 0.8, 2).ToString
        ElseIf DKTCOP_L = 0 And TRQCOP_L = 0 Then '电空调制冷COP=0，天然气空调制冷COP=0
            Form1.BYQRL_L.Text = 0
        Else
            Form1.BYQRL_L.Text = Math.Round((ZJGL_L_D / DKTCOP_L + ZJGL_L_Q / TRQCOP_L) / 0.8, 2).ToString
        End If
        '热
        If DKTCOP_R = 0 And TRQCOP_R > 0 Then '电空调制热COP=0，天然气空调制热COP>0
            Form1.BYQRL_R.Text = Math.Round((ZJGL_R_Q / TRQCOP_R) / 0.8, 2).ToString
        ElseIf DKTCOP_R > 0 And TRQCOP_R = 0 Then '电空调制热COP>0，天然气空调制热COP=0
            Form1.BYQRL_R.Text = Math.Round((ZJGL_R_D / DKTCOP_R) / 0.8, 2).ToString
        ElseIf DKTCOP_R = 0 And TRQCOP_R = 0 Then '电空调制热COP=0，天然气空调制热COP=0
            Form1.BYQRL_R.Text = 0
        Else
            Form1.BYQRL_R.Text = Math.Round((ZJGL_R_D / DKTCOP_R + ZJGL_R_Q / TRQCOP_R) / 0.8, 2).ToString
        End If
        '计算全年电耗量
        '冷
        If DKTCOP_L = 0 And TRQCOP_L > 0 Then '电空调制冷COP=0，天然气空调制冷COP>0
            Form1.YDZL_L.Text = Math.Round(GNZL_L_Q / TRQCOP_L, 2).ToString
        ElseIf DKTCOP_L > 0 And TRQCOP_L = 0 Then '电空调制冷COP>0，天然气空调制冷COP=0
            Form1.YDZL_L.Text = Math.Round(GNZL_L_D / DKTCOP_L, 2).ToString
        ElseIf DKTCOP_L = 0 And TRQCOP_L = 0 Then '电空调制冷COP=0，天然气空调制冷COP=0
            Form1.YDZL_L.Text = 0
        Else
            Form1.YDZL_L.Text = Math.Round(GNZL_L_D / DKTCOP_L + GNZL_L_Q / TRQCOP_L, 2).ToString
        End If
        '热
        If DKTCOP_R = 0 And TRQCOP_R > 0 Then '电空调制热COP=0，天然气空调制热COP>0
            Form1.YDZL_R.Text = Math.Round(GNZL_R_Q / TRQCOP_R, 2).ToString
        ElseIf DKTCOP_R > 0 And TRQCOP_R = 0 Then '电空调制热COP>0，天然气空调制热COP=0
            Form1.YDZL_R.Text = Math.Round(GNZL_R_D / DKTCOP_R, 2).ToString
        ElseIf DKTCOP_R = 0 And TRQCOP_R = 0 Then '电空调制热COP=0，天然气空调制热COP=0
            Form1.YDZL_R.Text = 0
        Else
            Form1.YDZL_R.Text = Math.Round(GNZL_R_D / DKTCOP_R + GNZL_R_Q / TRQCOP_R, 2).ToString
        End If
        '计算全年天然气耗量
        Form1.TRQZL_L.Text = Math.Round(GNZL_L_Q * 3600 / TRQXL_L / TRQRZ, 2).ToString
        Form1.TRQZL_R.Text = Math.Round(GNZL_R_Q * 3600 / TRQXL_R / TRQRZ, 2).ToString
        '计算全年补水量
        Dim QNBSL_L As Double = 0 '制冷全年补水量
        If DKTCOP_L < 3.3 Then '如果电空调制冷COP<3.3，则说明电制冷采用的不是冷水机组，则不需要冷却水补水
            QNBSL_L = (（MJSBSL + 1.173 * LQSBSL） * GNZL_L_Q + MJSBSL * GNZL_L_D) * 3600 / WCHZ / 1000
        Else
            QNBSL_L = （MJSBSL + 1.173 * LQSBSL） * (GNZL_L_D + GNZL_L_Q) * 3600 / WCHZ / 1000
        End If
        Dim QNBSL_R = MJSBSL * (GNZL_R_D + GNZL_R_Q) * 3600 / WCHZ / 1000
        Form1.YSZL_L.Text = Math.Round(QNBSL_L， 2).ToString
        Form1.YSZL_R.Text = Math.Round(QNBSL_R， 2).ToString
    End Sub

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

    Private Sub 参数建议_Click(sender As Object, e As EventArgs) Handles 参数建议.Click
        MsgBox("冷水机组制冷综合COP建议取4" & vbCrLf & "风冷热泵机组制冷综合COP建议取2.7" & vbCrLf & "风冷热泵机组制热综合COP建议取2.4" & vbCrLf & "VRV机组制冷综合COP建议取3" & vbCrLf & "VRV机组制热综合COP建议取2.7" & vbCrLf & "天然气锅炉和直燃型溴化锂制热效率建议取0.95" & vbCrLf & "直燃型溴化锂制冷效率建议取1.35")
    End Sub

    Private Sub 设备年耗量计算_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.KeyPreview = True
    End Sub
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim key As String
        key = e.KeyChar
        '检验按键是否为回车键，如果是就把焦点附给按钮1，并执行Click命令
        If key = ChrW(13) Then
            确定数据.Focus()
            确定数据.PerformClick()
        End If
    End Sub

    Private Sub 设备年耗量计算_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        '关闭其它窗体
        计算结果显示.Close()
        边界条件输入.Close()
        计算方式选择.Close()
    End Sub
End Class