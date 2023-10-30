Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        A_Associacao.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_sair.Click
        End

    End Sub

    Private Sub Cmd_donativo_Click(sender As Object, e As EventArgs) Handles Cmd_donativo.Click
        Dim Doar As Integer
        Doar = MessageBox.Show("Poderá fazer um donativo em dinheiro para ajudar-nos com nossas atividades, por transferência bancária:

            Banco dos Pets – Porto;

            N. Conta: 0009 9212 0123;

            NIB: 0921 0067 003424328922 23;

            IBAN: PT50 0921 0067 003424328922 23;

            SWIFT/BIC: BASZPTCV", "Doar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Doar = MessageBox.Show("Número Solidário:
           707 100 200
           Custo da Chamada:
           0,60€ mais iva")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub






    Private Sub FormularioAdoçãoDeAnimaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormularioAdoçãoDeGatosToolStripMenuItem.Click
        Me.Hide()
        FormularioAdocaoGatos.Show()

    End Sub

    Private Sub Cmd_GaleriaAnimais_Click(sender As Object, e As EventArgs) Handles Cmd_GaleriaAnimais.Click
        Dim animais As Integer
        animais = MessageBox.Show("CONHEÇA OS NOSSOS ANIMAIS
Estes animais precisam de si! Existem muitas formas de contribuir para o final feliz das histórias de vida repletas de sofrimento que todos os dias se cruzam com a Animais de Rua. Escolha aqui a sua: adoptar, acolher enquanto Família de Acolhimento Temporário ou apadrinhar a esterilização ou tratamento de um animal em risco - são gestos que salvam vidas!")
        Dim AnimaisDeRuaLink As String = "https://www.animaisderua.org/animals"
        Dim startInfo As New ProcessStartInfo(AnimaisDeRuaLink)
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
    End Sub


    Private Sub NumeroSolidárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumeroSolidárioToolStripMenuItem.Click
        Dim Doar As Integer
        Doar = MessageBox.Show("Número Solidário:
           707 100 200
           Custo da Chamada:
           0,60€ mais iva")



    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click
        Dim facebookLink As String = "https://www.facebook.com/animaisderua"
        Dim startInfo As New ProcessStartInfo(facebookLink)
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
    End Sub

    Private Sub InstagramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstagramToolStripMenuItem.Click
        Dim instagramLink As String = "https://www.instagram.com/animaisderua/"
        Dim startInfo As New ProcessStartInfo(instagramLink)
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
    End Sub

    Private Sub RedesSociaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedesSociaisToolStripMenuItem.Click

    End Sub

    Private Sub LojaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LojaToolStripMenuItem.Click
        Dim LojaLink As String = "https://shop.animaisderua.org"
        Dim startInfo As New ProcessStartInfo(LojaLink)
        startInfo.UseShellExecute = True
        Process.Start(startInfo)
    End Sub
End Class

