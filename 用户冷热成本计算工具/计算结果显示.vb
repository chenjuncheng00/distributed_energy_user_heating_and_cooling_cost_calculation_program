Public Class 计算结果显示
    Private Sub 计算结果显示_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        '关闭其它窗体
        设备年耗量计算.Close()
        边界条件输入.Close()
        计算方式选择.Close()
    End Sub

    Private Sub 计算结果显示_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
