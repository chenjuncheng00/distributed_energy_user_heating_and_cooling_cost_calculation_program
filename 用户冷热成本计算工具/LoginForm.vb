
Public Class LoginForm
    Private Sub 确定_Click(sender As Object, e As EventArgs) Handles 确定.Click
        If TextBox1.Text = "speri1115" Then
            Form3.Show()
            Form3.Activate()
            Me.Hide()
        Else
            MsgBox("密码错误!")
            Application.Exit()
        End If
    End Sub
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim key As String
        key = e.KeyChar
        '检验按键是否为回车键，如果是就把焦点附给按钮1，并执行Click命令
        If key = ChrW(13) Then
            确定.Focus()
            确定.PerformClick()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyBase.KeyPreview = True
    End Sub

    Private Sub LoginForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        On Error Resume Next
        '关闭其它窗体
        计算结果显示.Close()
        设备年耗量计算.Close()
        边界条件输入.Close()
        计算方式选择.Close()
    End Sub
End Class