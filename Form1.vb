Imports SpeechLib

Public Class Form1
    Dim synth As SpVoice

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        synth = New SpVoice()
    End Sub

    Private Sub SpeakText(ByVal textToSpeak As String)
        If Not String.IsNullOrEmpty(textToSpeak) Then
            Dim streamNumber As UInteger ' Capture the stream number
            synth.Speak(textToSpeak, 0, streamNumber) ' Include the streamNumber parameter
        End If
    End Sub

    ' Common Click event handler for all buttons
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, btnPlus.Click, btnMins.Click, btnDivid.Click, btnMult.Click, btnEq.Click
        Dim button As Button = DirectCast(sender, Button) ' Get the button that was clicked

        ' Debugging output to check which button was clicked
        Debug.WriteLine("Clicked button text: " & button.Text)

        SpeakText(button.Text) ' Speak the text on the clicked button
        TextBox1.Text = button.Text
    End Sub
End Class
