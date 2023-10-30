Imports System.Drawing.Text
Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormularioAdocaoGatos
    Private DateTimePicker1 As Object

    Private Sub Limpar()
        Limpar(CheckBoxAutorizo)
    End Sub

    Private Sub Limpar(checkBoxAutorizo As CheckBox)
        TxtNomeAnimal.Text = String.Empty
        TxtAnuncio.Text = String.Empty
        TxtDestinado.Text = String.Empty
        TxtCaracteristicasAnimal.Text = String.Empty
        TxtMotivacao.Text = String.Empty
        Txt_email.Text = String.Empty
        Txt_nome.Text = String.Empty
        Txt_dataNascimento.Text = String.Empty
        Txt_morada.Text = String.Empty
        Txt_telemovel.Text = String.Empty
        Txt_profissao.Text = String.Empty
        ComboBox_habitacaoVive.Text = String.Empty
        ComboBoxEspacoExterior.Text = String.Empty
        ComboBoxProtecoesJanelas.Text = String.Empty
        ComboBox1.Text = String.Empty
        Txt_agredadoFamiliar.Text = String.Empty
        ComboBoxPessoasConcordamComAdocao.Text = String.Empty
        ComboBoxCriancasEmCasa.Text = String.Empty
        ComboBoxTemAnimaisEmCasa.Text = String.Empty
        ComboBoxSaoSociaveis.Text = String.Empty
        ComboBoxJaTeveAnimaisDeEstimacao.Text = String.Empty
        TextBoxQueAlimentacaoLheDava.Text = String.Empty
        TextBoxQuandoForDeFerias.Text = String.Empty
        TextBoxAssumeAresponsabilidade.Text = String.Empty
        CheckBoxTomeiConhecimento.Text = String.Empty
        CheckBoxSim.Text = String.Empty
        checkBoxAutorizo.Text = String.Empty




    End Sub

    Private Sub Guardar()

        Dim guardaF As New SaveFileDialog
        guardaF.Filter = "txt files (*.txt) |*.txt"
        guardaF.FilterIndex = 2
        guardaF.RestoreDirectory = False

        If guardaF.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(guardaF.FileName, tAnimalAdotar.Text)
        End If
    End Sub
    Private Sub FormularioAdocaoAnimais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("A primeira fase do processo de adoção é o preenchimento deste formulário, para nos ajudar a verificar as expectativas e a viabilidade da família adotante em receber o animal em seu lar.",
        "Formulário de Adoção de Animais", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub CmdAvancar_Click(sender As Object, e As EventArgs) Handles CmdAvancar.Click
        ' Verifica se todos os campos obrigatórios foram preenchidos
        If ValidarCamposObrigatorios() Then
            ' Avança para a próxima aba do TabControl
            AvancarParaProximaAba()
        Else
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AvancarParaProximaAba()
        ' Avança para a próxima aba do TabControl
        If DadosPessoais.SelectedTab IsNot Nothing Then
            Dim proximaAba As Integer = DadosPessoais.TabPages.IndexOf(DadosPessoais.SelectedTab) + 1
            If proximaAba < DadosPessoais.TabCount Then
                DadosPessoais.SelectedTab = DadosPessoais.TabPages(proximaAba)
            End If
        End If
    End Sub

    Private Function ValidarCamposObrigatorios() As Boolean
        ' Verifica se todos os campos obrigatórios foram preenchidos
        If String.IsNullOrEmpty(TxtNomeAnimal.Text) OrElse
        String.IsNullOrEmpty(TxtAnuncio.Text) OrElse
        String.IsNullOrEmpty(TxtCaracteristicasAnimal.Text) OrElse
        String.IsNullOrEmpty(TxtMotivacao.Text) Then
            Return False
        End If

        Return True
    End Function







    Private Sub tAnimalAdotar_Click(sender As Object, e As EventArgs) Handles tAnimalAdotar.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_limpar.Click
        Limpar()
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Guardar()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles Txt_profissao.TextChanged

    End Sub




    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Txt_telemovel.TextChanged
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Txt_morada.TextChanged
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt_nome.TextChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_email.TextChanged
    End Sub

    Private Sub LblProfissao_Click(sender As Object, e As EventArgs) Handles LblProfissao.Click
    End Sub

    Private Sub LblTelefone_Click(sender As Object, e As EventArgs) Handles LblTelemovel.Click
    End Sub

    Private Sub LblMorada_Click(sender As Object, e As EventArgs) Handles LblMorada.Click
    End Sub

    Private Sub LblDataDeNascimento_Click(sender As Object, e As EventArgs) Handles LblDataDeNascimento.Click
    End Sub

    Private Sub LblNome_Click(sender As Object, e As EventArgs) Handles LblNome.Click
    End Sub

    Private Sub LblEmail_Click(sender As Object, e As EventArgs) Handles LblEmail.Click
    End Sub

    Private Sub cmd_datanascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_dataNascimento.KeyPress

        Dim texto As String = Txt_dataNascimento.Text.Replace("-", "") ' Remove os traços existentes
        If texto.Length >= 4 Then
            texto = texto.Insert(4, "-") ' ano
        End If
        If texto.Length >= 7 Then
            texto = texto.Insert(7, "-") ' Adiciona o traço após o mês
        ElseIf texto.Length >= 10 Then
            texto = texto.Insert(10, "-") 'Adiciona o traço apos o dia
        End If
        Txt_dataNascimento.Text = texto ' Atualiza o texto da caixa de texto
        Txt_dataNascimento.SelectionStart = texto.Length ' Move o cursor para o final
    End Sub


    Private Sub cmd_dataNascimento_TextChanged(sender As Object, e As EventArgs) Handles Txt_dataNascimento.TextChanged

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_guardar1.Click
        Guardar()
    End Sub

    Private Sub cmd_Avancar1_Click(sender As Object, e As EventArgs) Handles cmd_avancar1.Click
        If ValidarCamposObrigatoriosAba1() Then
            AvancarParaProximaAba1()
        Else
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function ValidarCamposObrigatoriosAba1() As Boolean
        ' Verifique se todos os campos obrigatórios na aba 1 foram preenchidos
        If String.IsNullOrEmpty(Txt_email.Text) OrElse
           String.IsNullOrEmpty(Txt_nome.Text) OrElse
           String.IsNullOrEmpty(Txt_dataNascimento.Text) OrElse
           String.IsNullOrEmpty(Txt_morada.Text) OrElse
           String.IsNullOrEmpty(Txt_telemovel.Text) OrElse
           String.IsNullOrEmpty(Txt_profissao.Text) Then




            Return False
        End If
        Return True
    End Function

    Private Sub AvancarParaProximaAba1()
        ' Lógica para avançar para a próxima aba específica do botão "Avançar1"
        If DadosPessoais.SelectedTab IsNot Nothing Then
            Dim proximaAba As Integer = DadosPessoais.TabPages.IndexOf(DadosPessoais.SelectedTab) + 1
            If proximaAba < DadosPessoais.TabCount Then
                DadosPessoais.SelectedTab = DadosPessoais.TabPages(proximaAba)
            End If
        End If
    End Sub

    Private Sub cmd_limpar1_Click(sender As Object, e As EventArgs) Handles cmd_limpar1.Click
        Limpar()
    End Sub

    Private Sub cmd_sair1_Click(sender As Object, e As EventArgs) Handles cmd_sair1.Click
        End
    End Sub
    Private Sub cmd_sair_Click(sender As Object, e As EventArgs) Handles cmd_sair.Click
        End
    End Sub

    Private Sub ComboBox_habitacaoVive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_habitacaoVive.SelectedIndexChanged
        Dim opcaoselecionada As String = ComboBox_habitacaoVive.SelectedItem.ToString()




        ' Verifica se a opção selecionada é "Outro"
        If opcaoselecionada = "Outro" Then
            ' Exibe um controle de entrada de texto para o usuário inserir o valor personalizado
            Dim textoPersonalizado As String = InputBox("Se escolheu  a opção Outro, escreva por favor em que tipo de habitação vive:")

            ' Verifica se o usuário inseriu um valor
            If Not String.IsNullOrEmpty(textoPersonalizado) Then
                ' Realize a ação com o valor personalizado
                MessageBox.Show("Opção selecionada: " & textoPersonalizado)
            Else
                ' Ação padrão, se o usuário não inserir um valor
                MessageBox.Show("Opção selecionada: Outro")
            End If
        Else
            ' Realize a ação com base na opção selecionada
            Select Case opcaoselecionada
                Case "Apartamento"
                    ' Ação para a opção "Apartamento"
                    MessageBox.Show("Opção selecionada: Apartamento")
                Case "Moradia"
                    ' Ação para a opção "Moradia"
                    MessageBox.Show("Opção selecionada: Moradia")
                Case "Andar Moradia"
                    ' Ação para a opção "Andar Moradia"
                    MessageBox.Show("Opção selecionada: Andar Moradia")
                Case "Quinta"
                    ' Ação para a opção "Quinta"
                    MessageBox.Show("Opção selecionada: Quinta")
                Case "Casa Térrea"
                    ' Ação para a opção "Casa Térrea"
                    MessageBox.Show("Opção selecionada: Casa Térrea")
            End Select
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBoxEspacoExterior_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEspacoExterior.SelectedIndexChanged
        Dim opcaoselecionada As String = ComboBoxEspacoExterior.SelectedItem.ToString()

        Select Case opcaoselecionada
            Case "Sim"
                MessageBox.Show("Opção selecionada: Sim")
            Case "Não"
                MessageBox.Show("Opção selecionada: Não")
        End Select
    End Sub

    Private Sub ComboBoxProtecoesJanelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProtecoesJanelas.SelectedIndexChanged
        Dim opcaoselecionada As String = ComboBoxProtecoesJanelas.SelectedItem.ToString()

        Select Case opcaoselecionada
            Case "Sim"
                MessageBox.Show("Opção selecionada: Sim.")
            Case "Não"
                MessageBox.Show("Opção selecionada: Não.")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim opcaoselecionada As String = ComboBox1.SelectedItem.ToString()

        Select Case opcaoselecionada
            Case "Sim permite"
                MessageBox.Show("Opção selecionada: Sim permite.")
            Case "Não permite"
                MessageBox.Show("Opção selecionada: Não permite.")
        End Select
    End Sub




    Private Sub ComboBoxPessoasConcordamComAdocao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPessoasConcordamComAdocao.SelectedIndexChanged
        Dim opcaoselecionada As String = ComboBoxPessoasConcordamComAdocao.SelectedItem.ToString()
        Select Case opcaoselecionada
            Case "Sim"
                MessageBox.Show("Opção selecionada: Sim.")
            Case "Não"
                MessageBox.Show("Opção selecionada: Não")
        End Select
    End Sub

    Private Sub ComboBoxCriancasEmCasa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCriancasEmCasa.SelectedIndexChanged
        Dim opcaoselecionada As String = ComboBoxCriancasEmCasa.SelectedItem.ToString()
        Select Case opcaoselecionada
            Case "Sim"
                MessageBox.Show("Opção selecionada: Sim.")
            Case "Não"
                MessageBox.Show("Opção selecionda: Não.")
            Case "Nao existem crianças em casa"
                MessageBox.Show("Opção selecionda: Não existem crianças em casa.")
        End Select
    End Sub

    Private Sub cmdAvancar2_Click(sender As Object, e As EventArgs) Handles cmdAvancar2.Click
        If Not ValidarCamposObrigatoriosAba2() Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        DadosPessoais.SelectedTab = tCuidadosComOsAnimais
    End Sub

    Private Function ValidarCamposObrigatoriosAba2() As Boolean
        ' Verifique se todos os campos obrigatórios na aba 1 foram preenchidos
        If ComboBox_habitacaoVive.SelectedIndex = -1 OrElse
       ComboBoxEspacoExterior.SelectedIndex = -1 OrElse
       ComboBoxProtecoesJanelas.SelectedIndex = -1 OrElse
       ComboBox1.SelectedIndex = -1 OrElse
       ComboBoxPessoasConcordamComAdocao.SelectedIndex = -1 OrElse
       ComboBoxCriancasEmCasa.SelectedIndex = -1 Then




            Return False
        End If
        Return True
    End Function

    Private Sub AvancarParaProximaAba2()
        ' Lógica para avançar para a próxima aba específica do botão "Avançar1"
        If DadosPessoais.SelectedTab IsNot Nothing Then
            Dim proximaAba As Integer = DadosPessoais.TabPages.IndexOf(DadosPessoais.SelectedTab) + 1
            If proximaAba < DadosPessoais.TabCount Then
                DadosPessoais.SelectedTab = DadosPessoais.TabPages(proximaAba)
            End If
        End If
    End Sub

    Private Sub CmdGuardar_Click(sender As Object, e As EventArgs) Handles CmdGuardar.Click
        Guardar()

    End Sub

    Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles CmdLimpar.Click
        Limpar()
    End Sub

    Private Sub CmdSair_Click(sender As Object, e As EventArgs) Handles CmdSair.Click
        End
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub tCuidadosComOsAnimais_Click(sender As Object, e As EventArgs) Handles tCuidadosComOsAnimais.Click

    End Sub





    Private Sub tRGPD_Click(sender As Object, e As EventArgs) Handles tRGPD.Click

    End Sub








    Private Sub CmdSair3_Click(sender As Object, e As EventArgs) Handles CmdSair3.Click
        End
    End Sub

    Private Sub CmdLimpar3_Click(sender As Object, e As EventArgs) Handles CmdLimpar3.Click
        Limpar()
    End Sub

    Private Sub CmdGuardar3_Click(sender As Object, e As EventArgs) Handles CmdGuardar3.Click
        Guardar()
    End Sub








    Private Sub ComboBoxSaoSociaveis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSaoSociaveis.SelectedIndexChanged

        If ComboBoxSaoSociaveis.SelectedItem IsNot Nothing Then
            Dim opcaoSelecionada As String = ComboBoxSaoSociaveis.SelectedItem.ToString()

            ' Verificar a opção selecionada na ComboBoxSaoSociaveis
            If opcaoSelecionada = "Sim" Then
                ' Realizar ações quando a opção "Sim" for selecionada
                MessageBox.Show("O usuário selecionou 'Sim' na ComboBoxSaoSociaveis.")
            ElseIf opcaoSelecionada = "Não" Then
                ' Realizar ações quando a opção "Não" for selecionada
                MessageBox.Show("O usuário selecionou 'Não' na ComboBoxSaoSociaveis.")
            End If
        End If
    End Sub

    Private Sub ComboBoxJaTeveAnimaisDeEstimacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxJaTeveAnimaisDeEstimacao.SelectedIndexChanged
        If ComboBoxJaTeveAnimaisDeEstimacao.SelectedItem IsNot Nothing Then
            Dim opcaoSelecionada As String = ComboBoxJaTeveAnimaisDeEstimacao.SelectedItem.ToString()
            If opcaoSelecionada = "Sim" Then
                Dim textoPersonalizado As String = InputBox("Se escolheu  a opção Sim, escreva por favor o que aconteceu:")
            End If
            ' Verificar a opção selecionada na ComboBoxJaTeveAnimaisDeEstimacao
            If opcaoSelecionada = "Não" Then
                ' Avançar para a TextBoxQuandoForDeFerias
                TextBoxQuandoForDeFerias.Enabled = True
                TextBoxQuandoForDeFerias.Focus()
            End If
        End If
    End Sub


    Private Sub TextBoxQueAlimentacaoLheDava_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQueAlimentacaoLheDava.TextChanged
    End Sub


    Private Sub TxtCaracteristicasAnimal_TextChanged(sender As Object, e As EventArgs) Handles TxtCaracteristicasAnimal.TextChanged

    End Sub

    Private Sub TxtNomeAnimal_TextChanged(sender As Object, e As EventArgs) Handles TxtNomeAnimal.TextChanged

    End Sub

    Private Function GetTCuidadosComOsAnimais() As TabPage
        Return tCuidadosComOsAnimais
    End Function

    Private abaAtual As Integer = 0 ' Índice da aba atual

    Private Sub ComboBoxTemAnimaisEmCasa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTemAnimaisEmCasa.SelectedIndexChanged
        If ComboBoxTemAnimaisEmCasa.SelectedItem IsNot Nothing Then
            Dim opcaoSelecionada As String = ComboBoxTemAnimaisEmCasa.SelectedItem.ToString()

            ' Verificar a opção selecionada na ComboBoxTemAnimaisEmCasa
            If opcaoSelecionada = "Não" Then
                ' Avançar para a ComboBoxJaTeveAnimaisDeEstimacao
                ComboBoxJaTeveAnimaisDeEstimacao.Enabled = True
                ComboBoxJaTeveAnimaisDeEstimacao.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guardar()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Limpar()
    End Sub

    Private Sub cmd_submeter_Click(sender As Object, e As EventArgs) Handles cmd_submeter.Click
        ' Realize a validação dos campos do formulário

        Dim ResultadoValidacao As Boolean

        ' Validação da aba 1
        ResultadoValidacao = ValidarCamposObrigatoriosAba1()
        If Not ResultadoValidacao Then
            MessageBox.Show("Preencha todos os campos obrigatórios do formulário.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validação da aba 2
        ResultadoValidacao = ValidarCamposObrigatorios()
        If Not ResultadoValidacao Then
            MessageBox.Show("Preencha todos os campos obrigatórios  do formulário.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validação da aba 3
        ResultadoValidacao = ValidarCamposObrigatoriosAba2()
        If Not ResultadoValidacao Then
            MessageBox.Show("Preencha todos os campos obrigatórios do formulário.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validação da aba 4
        ResultadoValidacao = ValidarCamposObrigatoriosAba3()
        If Not ResultadoValidacao Then
            MessageBox.Show("Preencha todos os campos obrigatórios  do formulário.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim casaArrendada As Boolean

        If ComboBox1.SelectedItem = "Sim permite" Then
            casaArrendada = True
        ElseIf ComboBox1.SelectedItem = "Não permite" Then
            casaArrendada = False
        End If

        Using conn As New MySqlConnection("server=127.0.0.1;userid=root;password='Claudiaveloso8';database=CandidatosAdocao")
            conn.Open()

            ' 1. Inserir dados na tabela "dados_pessoais"
            Dim queryDadosPessoais As String = "INSERT INTO dados_pessoais (email, nome, data_nascimento, morada, telemovel, profissao) VALUES (@email, @nome, @dataNascimento, @morada, @telemovel, @profissao)"
            Using commandDadosPessoais As New MySqlCommand(queryDadosPessoais, conn)
                commandDadosPessoais.Parameters.AddWithValue("@email", Txt_email.Text)
                commandDadosPessoais.Parameters.AddWithValue("@nome", Txt_nome.Text)
                commandDadosPessoais.Parameters.AddWithValue("@dataNascimento", Txt_dataNascimento.Text)
                commandDadosPessoais.Parameters.AddWithValue("@morada", Txt_morada.Text)
                commandDadosPessoais.Parameters.AddWithValue("@telemovel", Txt_telemovel.Text)
                commandDadosPessoais.Parameters.AddWithValue("@profissao", Txt_profissao.Text)
                commandDadosPessoais.ExecuteNonQuery()
            End Using

            ' 2. Inserir dados na tabela "animais_adotar"
            Dim queryAnimaisAdotar As String = "INSERT INTO animais_adotar (nome_animal, anuncio, destinatario, caracteristicas, motivacao) VALUES (@nomeAnimal, @anuncio, @destinatario, @caracteristicas, @motivacao)"
            Using commandAnimaisAdotar As New MySqlCommand(queryAnimaisAdotar, conn)
                commandAnimaisAdotar.Parameters.AddWithValue("@nomeAnimal", TxtNomeAnimal.Text)
                commandAnimaisAdotar.Parameters.AddWithValue("@anuncio", TxtAnuncio.Text)
                commandAnimaisAdotar.Parameters.AddWithValue("@destinatario", TxtDestinado.Text)
                commandAnimaisAdotar.Parameters.AddWithValue("@caracteristicas", TxtCaracteristicasAnimal.Text)
                commandAnimaisAdotar.Parameters.AddWithValue("@motivacao", TxtMotivacao.Text)
                commandAnimaisAdotar.ExecuteNonQuery()
            End Using

            ' 3. Inserir dados na tabela "habitacao_agregado"
            Dim queryHabitacaoAgregado As String = "INSERT INTO habitacao_agregado (tipo_habitacao, espaco_exterior, protecoes_janelas, casa_arrendada, composto_agregado_familiar, pessoas_concordam_adocao, criancas_animais) VALUES (@tipoHabitacao, @espacoExterior, @protecoesJanelas, @casaArrendada, @compostoAgregadoFamiliar, @pessoasConcordam, @criancasAnimais)"
            Using commandHabitacaoAgregado As New MySqlCommand(queryHabitacaoAgregado, conn)
                commandHabitacaoAgregado.Parameters.AddWithValue("@tipoHabitacao", ComboBox_habitacaoVive.SelectedItem.ToString())
                commandHabitacaoAgregado.Parameters.AddWithValue("@espacoExterior", ComboBoxEspacoExterior.SelectedItem.ToString())
                commandHabitacaoAgregado.Parameters.AddWithValue("@protecoesJanelas", ComboBoxProtecoesJanelas.SelectedItem.ToString())
                commandHabitacaoAgregado.Parameters.AddWithValue("@casaArrendada", casaArrendada)

                Dim compostoAgregadoFamiliar As Integer
                If Integer.TryParse(Txt_agredadoFamiliar.Text, compostoAgregadoFamiliar) Then
                    commandHabitacaoAgregado.Parameters.AddWithValue("@compostoAgregadoFamiliar", compostoAgregadoFamiliar)
                Else
                    commandHabitacaoAgregado.Parameters.AddWithValue("@compostoAgregadoFamiliar", DBNull.Value)
                End If

                commandHabitacaoAgregado.Parameters.AddWithValue("@pessoasConcordam", ComboBoxPessoasConcordamComAdocao.SelectedItem.ToString())
                commandHabitacaoAgregado.Parameters.AddWithValue("@criancasAnimais", ComboBoxCriancasEmCasa.SelectedItem.ToString())

                commandHabitacaoAgregado.ExecuteNonQuery()
            End Using

            ' 4. Inserir dados na tabela "cuidados_animais"
            Dim queryCuidadosAnimais As String = "INSERT INTO cuidados_animais (tem_outros_animais, sociaveis, ja_teve_animais, alimentacao, assistencia_veterinaria, responsabilidade) VALUES (@temOutrosAnimais, @sociaveis, @jaTeveAnimais, @alimentacao, @assistenciaVeterinaria, @responsabilidade)"
            Using commandCuidadosAnimais As New MySqlCommand(queryCuidadosAnimais, conn)
                commandCuidadosAnimais.Parameters.AddWithValue("@temOutrosAnimais", ComboBoxTemAnimaisEmCasa.SelectedItem.ToString())
                Dim sociaveisValue As String = If(ComboBoxSaoSociaveis.SelectedItem IsNot Nothing, ComboBoxSaoSociaveis.SelectedItem.ToString(), "")
                commandCuidadosAnimais.Parameters.AddWithValue("@sociaveis", sociaveisValue)


                commandCuidadosAnimais.Parameters.AddWithValue("@jaTeveAnimais", ComboBoxJaTeveAnimaisDeEstimacao.SelectedItem.ToString())
                commandCuidadosAnimais.Parameters.AddWithValue("@alimentacao", TextBoxQueAlimentacaoLheDava.Text)
                commandCuidadosAnimais.Parameters.AddWithValue("@assistenciaVeterinaria", TextBoxQuandoForDeFerias.Text)
                commandCuidadosAnimais.Parameters.AddWithValue("@responsabilidade", TextBoxAssumeAresponsabilidade.Text)

                commandCuidadosAnimais.ExecuteNonQuery()
            End Using

            ' 5. Inserir dados na tabela "nota_rgpd"
            Dim queryNotaRGPD As String = "INSERT INTO nota_rgpd (tomei_conhecimento, concorda_processo, aviso_alteracao_dados, autoriza_manipulacao) VALUES (@tomeiConhecimento, @concordaProcesso, @avisoAlteracaoDados, @autorizaManipulacao)"
            Using commandNotaRGPD As New MySqlCommand(queryNotaRGPD, conn)
                commandNotaRGPD.Parameters.AddWithValue("@tomeiConhecimento", CheckBoxTomeiConhecimento.Checked)
                commandNotaRGPD.Parameters.AddWithValue("@concordaProcesso", CheckBoxConcordo.Checked)
                commandNotaRGPD.Parameters.AddWithValue("@avisoAlteracaoDados", CheckBoxSim.Checked)
                commandNotaRGPD.Parameters.AddWithValue("@autorizaManipulacao", CheckBoxAutorizo.Checked)
                commandNotaRGPD.ExecuteNonQuery()
            End Using

            ' Exiba uma mensagem de sucesso
            MessageBox.Show("Formulário submetido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpe os campos do formulário
            Limpar()

            ' Defina a primeira aba como selecionada novamente
            DadosPessoais.SelectTab(0)

            conn.Close()
        End Using
    End Sub
    Private Sub cmdAvancar3_Click(sender As Object, e As EventArgs) Handles cmdAvancar3.Click




        If Not ValidarCamposObrigatoriosAba3() Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        AvancarParaProximaAba3()
    End Sub

    Private Function ValidarCamposObrigatoriosAba3() As Boolean
        ' Verifique se todos os campos obrigatórios na aba 3 foram preenchidos
        If ComboBox_habitacaoVive.SelectedIndex = -1 OrElse
       ComboBoxEspacoExterior.SelectedIndex = -1 OrElse
       ComboBoxProtecoesJanelas.SelectedIndex = -1 OrElse
       ComboBox1.SelectedIndex = -1 OrElse
       ComboBoxPessoasConcordamComAdocao.SelectedIndex = -1 OrElse
       ComboBoxCriancasEmCasa.SelectedIndex = -1 Then
            Return False
        End If

        Return True
    End Function

    Private Sub AvancarParaProximaAba3()
        ' Lógica para avançar para a próxima aba específica do botão "Avançar3"
        If DadosPessoais.SelectedTab IsNot Nothing Then
            Dim proximaAba As Integer = DadosPessoais.TabPages.IndexOf(DadosPessoais.SelectedTab) + 1
            If proximaAba < DadosPessoais.TabCount Then
                DadosPessoais.SelectedIndex = proximaAba
            End If
        End If
    End Sub

    Private Sub tDadosPessoais_Click(sender As Object, e As EventArgs) Handles tDadosPessoais.Click

    End Sub
End Class