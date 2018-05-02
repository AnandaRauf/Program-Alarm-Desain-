Imports System.IO
Public Class Form1
    Dim s As Integer = 0
    Dim d As Path


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Time
        Timer2.Enabled = True
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Choose Your Music!")
        Else
            Timer1.Enabled = True
            DateTimePicker1.CalendarForeColor = Color.LightSkyBlue
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = ""
            TextBox1.Text = OpenFileDialog1.FileName
            s = 1
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If TimeOfDay = DateTimePicker1.Text Then
                If s = 1 Then
                    AxWindowsMediaPlayer1.URL = TextBox1.Text.ToString
                Else
                    MsgBox(DateTimePicker1.Value)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
