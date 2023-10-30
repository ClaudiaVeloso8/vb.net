Public Class A_Associacao
    Private Sub A_Associacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "A associação Bem-Estar Animal surgiu da necessidade e do desejo" & vbCrLf & "de ajudar animais em situação de vulnerabilidade seja por maus-tratos ou abandono," & vbCrLf & "bem como ajudar pessoas com o desejo e a disposição para adotar um animal de companhia," & vbCrLf & "de forma responsável a fim de evitar novos abandonos. Em respeito ao bem-estar do animal" & vbCrLf & "e para promover a saúde pública, realizamos a esterilização dos bichinhos para" & vbCrLf & "evitar a reprodução desordenada e trazer mais qualidade de vida para eles."
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class