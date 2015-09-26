Public Class Form1
    Dim juego As Boolean = True
    Dim pts As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Beep()
        If juego = True Then
            Button1.Text = "X"
            juego = False
            Button1.Enabled = False
        Else
            Button1.Text = "O"
            juego = True
            Button1.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1





        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beep()
        If juego = True Then
            Button2.Text = "X"
            juego = False
            Button2.Enabled = False

        Else
            Button2.Text = "O"
            juego = True
            Button2.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Beep()
        If juego = True Then
            Button3.Text = "X"
            juego = False
            Button3.Enabled = False
        Else
            Button3.Text = "O"
            juego = True
            Button3.Enabled = False
        End If
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
        
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Beep()
        If juego = True Then
            Button4.Text = "X"
            juego = False
            Button4.Enabled = False
        Else
            Button4.Text = "O"
            juego = True
            Button4.Enabled = False
        End If
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
        
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Beep()
        If juego = True Then
            Button5.Text = "X"
            juego = False
            Button5.Enabled = False
        Else
            Button5.Text = "O"
            juego = True
            Button5.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
            Stop



        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Beep()
        If juego = True Then
            Button6.Text = "X"
            juego = False
            Button6.Enabled = False
        Else
            Button6.Text = "O"
            juego = True
            Button6.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
        
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Beep()
        If juego = True Then
            Button7.Text = "X"
            juego = False
            Button7.Enabled = False
        Else
            Button7.Text = "O"
            juego = True
            Button7.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
        
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Beep()

        If juego = True Then
            Button8.Text = "X"
            juego = False
            Button8.Enabled = False
        Else
            Button8.Text = "O"
            juego = True
            Button8.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
        
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Beep()
        If juego = True Then
            Button9.Text = "X"
            juego = False
            Button9.Enabled = False
        Else
            Button9.Text = "O"
            juego = True
            Button9.Enabled = False
        End If

        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Ganó O")
            Button1.BackColor = Color.Olive
            Button2.BackColor = Color.Olive
            Button3.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ganó X")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button4.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Ya ganaste")
            Button2.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Ya ganaste")
            Button4.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button6.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button7.BackColor = Color.Olive
            Button8.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Ya ganaste")
            Button1.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button9.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If

        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label4.Text = Val(Label4.Text) + 1
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Ya ganaste")
            Button3.BackColor = Color.Olive
            Button5.BackColor = Color.Olive
            Button7.BackColor = Color.Olive
            Label5.Text = Val(Label5.Text) + 1
        End If
       
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button1.BackColor = Color.Empty
        Button2.BackColor = Color.Empty
        Button3.BackColor = Color.Empty
        Button4.BackColor = Color.Empty
        Button5.BackColor = Color.Empty
        Button6.BackColor = Color.Empty
        Button7.BackColor = Color.Empty
        Button8.BackColor = Color.Empty
        Button9.BackColor = Color.Empty
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        juego = True



    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.andresdominguez.mx")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
