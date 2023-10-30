<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAdocaoGatos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormularioAdocaoGatos))
        DadosPessoais = New TabControl()
        tDadosPessoais = New TabPage()
        cmd_sair1 = New Button()
        cmd_limpar1 = New Button()
        cmd_guardar1 = New Button()
        cmd_avancar1 = New Button()
        Txt_profissao = New TextBox()
        Txt_telemovel = New TextBox()
        Txt_morada = New TextBox()
        Txt_dataNascimento = New TextBox()
        Txt_nome = New TextBox()
        Txt_email = New TextBox()
        LblProfissao = New Label()
        LblTelemovel = New Label()
        LblMorada = New Label()
        LblDataDeNascimento = New Label()
        LblNome = New Label()
        LblEmail = New Label()
        tAnimalAdotar = New TabPage()
        cmd_limpar = New Button()
        TxtDestinado = New TextBox()
        CmdAvancar = New Button()
        cmd_sair = New Button()
        cmd_guardar = New Button()
        TxtMotivacao = New TextBox()
        TxtCaracteristicasAnimal = New TextBox()
        TxtAnuncio = New TextBox()
        TxtNomeAnimal = New TextBox()
        Label1 = New Label()
        lblCaracteristicas = New Label()
        Label3 = New Label()
        lblAnuncio = New Label()
        LblNomeAnimal = New Label()
        tHabitacaoAgregadoFamiliar = New TabPage()
        ComboBox1 = New ComboBox()
        CmdSair = New Button()
        ComboBoxCriancasEmCasa = New ComboBox()
        CmdLimpar = New Button()
        ComboBoxPessoasConcordamComAdocao = New ComboBox()
        CmdGuardar = New Button()
        Txt_agredadoFamiliar = New TextBox()
        cmdAvancar2 = New Button()
        ComboBoxProtecoesJanelas = New ComboBox()
        ComboBoxEspacoExterior = New ComboBox()
        ComboBox_habitacaoVive = New ComboBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        tCuidadosComOsAnimais = New TabPage()
        CmdSair3 = New Button()
        CmdLimpar3 = New Button()
        CmdGuardar3 = New Button()
        cmdAvancar3 = New Button()
        TextBoxAssumeAresponsabilidade = New TextBox()
        TextBoxQuandoForDeFerias = New TextBox()
        TextBoxQueAlimentacaoLheDava = New TextBox()
        ComboBoxJaTeveAnimaisDeEstimacao = New ComboBox()
        ComboBoxSaoSociaveis = New ComboBox()
        ComboBoxTemAnimaisEmCasa = New ComboBox()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        LblAmimaisEmCasa = New Label()
        tRGPD = New TabPage()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        cmd_submeter = New Button()
        CheckBoxAutorizo = New CheckBox()
        Label18 = New Label()
        CheckBoxSim = New CheckBox()
        Label16 = New Label()
        CheckBoxConcordo = New CheckBox()
        CheckBoxTomeiConhecimento = New CheckBox()
        LinkLabel1 = New LinkLabel()
        Label17 = New Label()
        Label10 = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        DadosPessoais.SuspendLayout()
        tDadosPessoais.SuspendLayout()
        tAnimalAdotar.SuspendLayout()
        tHabitacaoAgregadoFamiliar.SuspendLayout()
        tCuidadosComOsAnimais.SuspendLayout()
        tRGPD.SuspendLayout()
        SuspendLayout()
        ' 
        ' DadosPessoais
        ' 
        DadosPessoais.Controls.Add(tDadosPessoais)
        DadosPessoais.Controls.Add(tAnimalAdotar)
        DadosPessoais.Controls.Add(tHabitacaoAgregadoFamiliar)
        DadosPessoais.Controls.Add(tCuidadosComOsAnimais)
        DadosPessoais.Controls.Add(tRGPD)
        DadosPessoais.Cursor = Cursors.IBeam
        DadosPessoais.Location = New Point(-3, 2)
        DadosPessoais.Name = "DadosPessoais"
        DadosPessoais.SelectedIndex = 0
        DadosPessoais.Size = New Size(798, 446)
        DadosPessoais.TabIndex = 0
        ' 
        ' tDadosPessoais
        ' 
        tDadosPessoais.BackColor = Color.Linen
        tDadosPessoais.BackgroundImage = CType(resources.GetObject("tDadosPessoais.BackgroundImage"), Image)
        tDadosPessoais.BackgroundImageLayout = ImageLayout.Stretch
        tDadosPessoais.Controls.Add(cmd_sair1)
        tDadosPessoais.Controls.Add(cmd_limpar1)
        tDadosPessoais.Controls.Add(cmd_guardar1)
        tDadosPessoais.Controls.Add(cmd_avancar1)
        tDadosPessoais.Controls.Add(Txt_profissao)
        tDadosPessoais.Controls.Add(Txt_telemovel)
        tDadosPessoais.Controls.Add(Txt_morada)
        tDadosPessoais.Controls.Add(Txt_dataNascimento)
        tDadosPessoais.Controls.Add(Txt_nome)
        tDadosPessoais.Controls.Add(Txt_email)
        tDadosPessoais.Controls.Add(LblProfissao)
        tDadosPessoais.Controls.Add(LblTelemovel)
        tDadosPessoais.Controls.Add(LblMorada)
        tDadosPessoais.Controls.Add(LblDataDeNascimento)
        tDadosPessoais.Controls.Add(LblNome)
        tDadosPessoais.Controls.Add(LblEmail)
        tDadosPessoais.ForeColor = SystemColors.ActiveCaptionText
        tDadosPessoais.Location = New Point(4, 29)
        tDadosPessoais.Name = "tDadosPessoais"
        tDadosPessoais.Padding = New Padding(3)
        tDadosPessoais.Size = New Size(790, 413)
        tDadosPessoais.TabIndex = 0
        tDadosPessoais.Text = "Dados Pessoais"
        ' 
        ' cmd_sair1
        ' 
        cmd_sair1.BackColor = SystemColors.Info
        cmd_sair1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_sair1.Location = New Point(669, 346)
        cmd_sair1.Name = "cmd_sair1"
        cmd_sair1.Size = New Size(94, 29)
        cmd_sair1.TabIndex = 15
        cmd_sair1.Text = "&Sair"
        cmd_sair1.UseVisualStyleBackColor = False
        ' 
        ' cmd_limpar1
        ' 
        cmd_limpar1.BackColor = SystemColors.Info
        cmd_limpar1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_limpar1.Location = New Point(669, 287)
        cmd_limpar1.Name = "cmd_limpar1"
        cmd_limpar1.Size = New Size(94, 29)
        cmd_limpar1.TabIndex = 14
        cmd_limpar1.Text = "&Limpar Formulário"
        cmd_limpar1.UseVisualStyleBackColor = False
        ' 
        ' cmd_guardar1
        ' 
        cmd_guardar1.BackColor = SystemColors.Info
        cmd_guardar1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_guardar1.Location = New Point(669, 227)
        cmd_guardar1.Name = "cmd_guardar1"
        cmd_guardar1.Size = New Size(94, 29)
        cmd_guardar1.TabIndex = 13
        cmd_guardar1.Text = "&Guardar"
        cmd_guardar1.UseVisualStyleBackColor = False
        ' 
        ' cmd_avancar1
        ' 
        cmd_avancar1.BackColor = SystemColors.Info
        cmd_avancar1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_avancar1.Location = New Point(669, 170)
        cmd_avancar1.Name = "cmd_avancar1"
        cmd_avancar1.Size = New Size(94, 29)
        cmd_avancar1.TabIndex = 12
        cmd_avancar1.Text = "&Avançar"
        cmd_avancar1.UseVisualStyleBackColor = False
        ' 
        ' Txt_profissao
        ' 
        Txt_profissao.BackColor = SystemColors.Menu
        Txt_profissao.Location = New Point(125, 303)
        Txt_profissao.Name = "Txt_profissao"
        Txt_profissao.Size = New Size(404, 27)
        Txt_profissao.TabIndex = 11
        ' 
        ' Txt_telemovel
        ' 
        Txt_telemovel.BackColor = SystemColors.Menu
        Txt_telemovel.Location = New Point(122, 250)
        Txt_telemovel.Name = "Txt_telemovel"
        Txt_telemovel.Size = New Size(407, 27)
        Txt_telemovel.TabIndex = 10
        ' 
        ' Txt_morada
        ' 
        Txt_morada.BackColor = SystemColors.Menu
        Txt_morada.Location = New Point(117, 184)
        Txt_morada.Name = "Txt_morada"
        Txt_morada.Size = New Size(412, 27)
        Txt_morada.TabIndex = 9
        ' 
        ' Txt_dataNascimento
        ' 
        Txt_dataNascimento.BackColor = SystemColors.Menu
        Txt_dataNascimento.Location = New Point(198, 129)
        Txt_dataNascimento.Name = "Txt_dataNascimento"
        Txt_dataNascimento.Size = New Size(331, 27)
        Txt_dataNascimento.TabIndex = 8
        ' 
        ' Txt_nome
        ' 
        Txt_nome.BackColor = SystemColors.Menu
        Txt_nome.Location = New Point(106, 72)
        Txt_nome.Name = "Txt_nome"
        Txt_nome.Size = New Size(423, 27)
        Txt_nome.TabIndex = 7
        ' 
        ' Txt_email
        ' 
        Txt_email.BackColor = SystemColors.Menu
        Txt_email.Location = New Point(108, 19)
        Txt_email.Name = "Txt_email"
        Txt_email.Size = New Size(421, 27)
        Txt_email.TabIndex = 6
        ' 
        ' LblProfissao
        ' 
        LblProfissao.AutoSize = True
        LblProfissao.BackColor = SystemColors.AppWorkspace
        LblProfissao.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblProfissao.Location = New Point(40, 306)
        LblProfissao.Name = "LblProfissao"
        LblProfissao.Size = New Size(81, 20)
        LblProfissao.TabIndex = 5
        LblProfissao.Text = "Profissão *"
        ' 
        ' LblTelemovel
        ' 
        LblTelemovel.AutoSize = True
        LblTelemovel.BackColor = SystemColors.AppWorkspace
        LblTelemovel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblTelemovel.Location = New Point(32, 250)
        LblTelemovel.Name = "LblTelemovel"
        LblTelemovel.Size = New Size(89, 20)
        LblTelemovel.TabIndex = 4
        LblTelemovel.Text = "Telemóvel *"
        ' 
        ' LblMorada
        ' 
        LblMorada.AutoSize = True
        LblMorada.BackColor = SystemColors.AppWorkspace
        LblMorada.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblMorada.Location = New Point(40, 191)
        LblMorada.Name = "LblMorada"
        LblMorada.Size = New Size(74, 20)
        LblMorada.TabIndex = 3
        LblMorada.Text = "Morada *"
        ' 
        ' LblDataDeNascimento
        ' 
        LblDataDeNascimento.AutoSize = True
        LblDataDeNascimento.BackColor = SystemColors.AppWorkspace
        LblDataDeNascimento.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblDataDeNascimento.Location = New Point(40, 129)
        LblDataDeNascimento.Name = "LblDataDeNascimento"
        LblDataDeNascimento.Size = New Size(157, 20)
        LblDataDeNascimento.TabIndex = 2
        LblDataDeNascimento.Text = "Data de nascimento *"
        ' 
        ' LblNome
        ' 
        LblNome.AutoSize = True
        LblNome.BackColor = SystemColors.AppWorkspace
        LblNome.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblNome.Location = New Point(40, 72)
        LblNome.Name = "LblNome"
        LblNome.Size = New Size(61, 20)
        LblNome.TabIndex = 1
        LblNome.Text = "Nome *"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.BackColor = SystemColors.AppWorkspace
        LblEmail.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblEmail.Location = New Point(40, 19)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(64, 20)
        LblEmail.TabIndex = 0
        LblEmail.Text = "E-mail *"
        ' 
        ' tAnimalAdotar
        ' 
        tAnimalAdotar.BackgroundImage = CType(resources.GetObject("tAnimalAdotar.BackgroundImage"), Image)
        tAnimalAdotar.BackgroundImageLayout = ImageLayout.Stretch
        tAnimalAdotar.Controls.Add(cmd_limpar)
        tAnimalAdotar.Controls.Add(TxtDestinado)
        tAnimalAdotar.Controls.Add(CmdAvancar)
        tAnimalAdotar.Controls.Add(cmd_sair)
        tAnimalAdotar.Controls.Add(cmd_guardar)
        tAnimalAdotar.Controls.Add(TxtMotivacao)
        tAnimalAdotar.Controls.Add(TxtCaracteristicasAnimal)
        tAnimalAdotar.Controls.Add(TxtAnuncio)
        tAnimalAdotar.Controls.Add(TxtNomeAnimal)
        tAnimalAdotar.Controls.Add(Label1)
        tAnimalAdotar.Controls.Add(lblCaracteristicas)
        tAnimalAdotar.Controls.Add(Label3)
        tAnimalAdotar.Controls.Add(lblAnuncio)
        tAnimalAdotar.Controls.Add(LblNomeAnimal)
        tAnimalAdotar.Location = New Point(4, 29)
        tAnimalAdotar.Name = "tAnimalAdotar"
        tAnimalAdotar.Padding = New Padding(3)
        tAnimalAdotar.Size = New Size(790, 413)
        tAnimalAdotar.TabIndex = 1
        tAnimalAdotar.Text = "Animal a Adotar"
        tAnimalAdotar.UseVisualStyleBackColor = True
        ' 
        ' cmd_limpar
        ' 
        cmd_limpar.BackColor = SystemColors.Info
        cmd_limpar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_limpar.Location = New Point(647, 322)
        cmd_limpar.Name = "cmd_limpar"
        cmd_limpar.Size = New Size(94, 29)
        cmd_limpar.TabIndex = 12
        cmd_limpar.Text = "&Limpar Formulário"
        cmd_limpar.UseVisualStyleBackColor = False
        ' 
        ' TxtDestinado
        ' 
        TxtDestinado.Location = New Point(277, 157)
        TxtDestinado.Name = "TxtDestinado"
        TxtDestinado.Size = New Size(507, 27)
        TxtDestinado.TabIndex = 7
        ' 
        ' CmdAvancar
        ' 
        CmdAvancar.BackColor = SystemColors.Info
        CmdAvancar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        CmdAvancar.Location = New Point(647, 218)
        CmdAvancar.Name = "CmdAvancar"
        CmdAvancar.Size = New Size(94, 29)
        CmdAvancar.TabIndex = 11
        CmdAvancar.Text = "&Avançar"
        CmdAvancar.UseVisualStyleBackColor = False
        ' 
        ' cmd_sair
        ' 
        cmd_sair.BackColor = SystemColors.Info
        cmd_sair.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_sair.Location = New Point(647, 378)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(94, 29)
        cmd_sair.TabIndex = 10
        cmd_sair.Text = "&Sair"
        cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' cmd_guardar
        ' 
        cmd_guardar.BackColor = SystemColors.Info
        cmd_guardar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_guardar.Location = New Point(647, 271)
        cmd_guardar.Name = "cmd_guardar"
        cmd_guardar.Size = New Size(94, 29)
        cmd_guardar.TabIndex = 9
        cmd_guardar.Text = "&Guardar"
        cmd_guardar.UseVisualStyleBackColor = False
        ' 
        ' TxtMotivacao
        ' 
        TxtMotivacao.Location = New Point(27, 342)
        TxtMotivacao.Multiline = True
        TxtMotivacao.Name = "TxtMotivacao"
        TxtMotivacao.Size = New Size(423, 27)
        TxtMotivacao.TabIndex = 8
        ' 
        ' TxtCaracteristicasAnimal
        ' 
        TxtCaracteristicasAnimal.Location = New Point(27, 255)
        TxtCaracteristicasAnimal.Multiline = True
        TxtCaracteristicasAnimal.Name = "TxtCaracteristicasAnimal"
        TxtCaracteristicasAnimal.Size = New Size(404, 27)
        TxtCaracteristicasAnimal.TabIndex = 7
        ' 
        ' TxtAnuncio
        ' 
        TxtAnuncio.Location = New Point(193, 83)
        TxtAnuncio.Name = "TxtAnuncio"
        TxtAnuncio.Size = New Size(583, 27)
        TxtAnuncio.TabIndex = 6
        ' 
        ' TxtNomeAnimal
        ' 
        TxtNomeAnimal.Location = New Point(232, 19)
        TxtNomeAnimal.Name = "TxtNomeAnimal"
        TxtNomeAnimal.Size = New Size(552, 27)
        TxtNomeAnimal.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(27, 306)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 20)
        Label1.TabIndex = 4
        Label1.Text = "Qual e a sua principal motivação para adotar este animal? *"
        ' 
        ' lblCaracteristicas
        ' 
        lblCaracteristicas.AutoSize = True
        lblCaracteristicas.BackColor = SystemColors.ButtonFace
        lblCaracteristicas.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblCaracteristicas.ForeColor = SystemColors.ActiveCaptionText
        lblCaracteristicas.Location = New Point(27, 227)
        lblCaracteristicas.Name = "lblCaracteristicas"
        lblCaracteristicas.Size = New Size(404, 20)
        lblCaracteristicas.TabIndex = 3
        lblCaracteristicas.Text = "Que características procura num animal de companhia? *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonFace
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(27, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(248, 20)
        Label3.TabIndex = 2
        Label3.Text = "Destinado a si ou a outra pessoa? *"
        ' 
        ' lblAnuncio
        ' 
        lblAnuncio.AutoSize = True
        lblAnuncio.BackColor = SystemColors.ButtonFace
        lblAnuncio.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAnuncio.ForeColor = SystemColors.ActiveCaptionText
        lblAnuncio.Location = New Point(27, 90)
        lblAnuncio.Name = "lblAnuncio"
        lblAnuncio.Size = New Size(160, 20)
        lblAnuncio.TabIndex = 1
        lblAnuncio.Text = "Onde viu o anuncio? *"
        ' 
        ' LblNomeAnimal
        ' 
        LblNomeAnimal.AutoSize = True
        LblNomeAnimal.BackColor = SystemColors.ButtonFace
        LblNomeAnimal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblNomeAnimal.ForeColor = SystemColors.ActiveCaptionText
        LblNomeAnimal.Location = New Point(27, 26)
        LblNomeAnimal.Name = "LblNomeAnimal"
        LblNomeAnimal.Size = New Size(198, 20)
        LblNomeAnimal.TabIndex = 0
        LblNomeAnimal.Text = "Nome do Animal a adotar *"
        ' 
        ' tHabitacaoAgregadoFamiliar
        ' 
        tHabitacaoAgregadoFamiliar.BackgroundImage = CType(resources.GetObject("tHabitacaoAgregadoFamiliar.BackgroundImage"), Image)
        tHabitacaoAgregadoFamiliar.BackgroundImageLayout = ImageLayout.Stretch
        tHabitacaoAgregadoFamiliar.Controls.Add(ComboBox1)
        tHabitacaoAgregadoFamiliar.Controls.Add(CmdSair)
        tHabitacaoAgregadoFamiliar.Controls.Add(ComboBoxCriancasEmCasa)
        tHabitacaoAgregadoFamiliar.Controls.Add(CmdLimpar)
        tHabitacaoAgregadoFamiliar.Controls.Add(ComboBoxPessoasConcordamComAdocao)
        tHabitacaoAgregadoFamiliar.Controls.Add(CmdGuardar)
        tHabitacaoAgregadoFamiliar.Controls.Add(Txt_agredadoFamiliar)
        tHabitacaoAgregadoFamiliar.Controls.Add(cmdAvancar2)
        tHabitacaoAgregadoFamiliar.Controls.Add(ComboBoxProtecoesJanelas)
        tHabitacaoAgregadoFamiliar.Controls.Add(ComboBoxEspacoExterior)
        tHabitacaoAgregadoFamiliar.Controls.Add(ComboBox_habitacaoVive)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label9)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label8)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label7)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label6)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label5)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label4)
        tHabitacaoAgregadoFamiliar.Controls.Add(Label2)
        tHabitacaoAgregadoFamiliar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        tHabitacaoAgregadoFamiliar.Location = New Point(4, 29)
        tHabitacaoAgregadoFamiliar.Name = "tHabitacaoAgregadoFamiliar"
        tHabitacaoAgregadoFamiliar.Padding = New Padding(3)
        tHabitacaoAgregadoFamiliar.Size = New Size(790, 413)
        tHabitacaoAgregadoFamiliar.TabIndex = 2
        tHabitacaoAgregadoFamiliar.Text = "Habitação e Agregado Familiar"
        tHabitacaoAgregadoFamiliar.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Sim permite", "Não permite"})
        ComboBox1.Location = New Point(472, 157)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 18
        ' 
        ' CmdSair
        ' 
        CmdSair.BackColor = SystemColors.Info
        CmdSair.Location = New Point(648, 369)
        CmdSair.Name = "CmdSair"
        CmdSair.Size = New Size(94, 29)
        CmdSair.TabIndex = 17
        CmdSair.Text = "&Sair"
        CmdSair.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxCriancasEmCasa
        ' 
        ComboBoxCriancasEmCasa.BackColor = SystemColors.Menu
        ComboBoxCriancasEmCasa.ForeColor = SystemColors.Desktop
        ComboBoxCriancasEmCasa.FormattingEnabled = True
        ComboBoxCriancasEmCasa.Items.AddRange(New Object() {"Sim", "Não", "Não existem crianças em casa."})
        ComboBoxCriancasEmCasa.Location = New Point(390, 311)
        ComboBoxCriancasEmCasa.Name = "ComboBoxCriancasEmCasa"
        ComboBoxCriancasEmCasa.Size = New Size(242, 28)
        ComboBoxCriancasEmCasa.TabIndex = 13
        ' 
        ' CmdLimpar
        ' 
        CmdLimpar.BackColor = SystemColors.Info
        CmdLimpar.Location = New Point(435, 369)
        CmdLimpar.Name = "CmdLimpar"
        CmdLimpar.Size = New Size(94, 29)
        CmdLimpar.TabIndex = 16
        CmdLimpar.Text = "&Limpar"
        CmdLimpar.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxPessoasConcordamComAdocao
        ' 
        ComboBoxPessoasConcordamComAdocao.BackColor = SystemColors.Menu
        ComboBoxPessoasConcordamComAdocao.ForeColor = SystemColors.Desktop
        ComboBoxPessoasConcordamComAdocao.FormattingEnabled = True
        ComboBoxPessoasConcordamComAdocao.Items.AddRange(New Object() {"Sim", "Não"})
        ComboBoxPessoasConcordamComAdocao.Location = New Point(629, 265)
        ComboBoxPessoasConcordamComAdocao.Name = "ComboBoxPessoasConcordamComAdocao"
        ComboBoxPessoasConcordamComAdocao.Size = New Size(151, 28)
        ComboBoxPessoasConcordamComAdocao.TabIndex = 12
        ' 
        ' CmdGuardar
        ' 
        CmdGuardar.BackColor = SystemColors.Info
        CmdGuardar.Location = New Point(224, 369)
        CmdGuardar.Name = "CmdGuardar"
        CmdGuardar.Size = New Size(94, 29)
        CmdGuardar.TabIndex = 15
        CmdGuardar.Text = "&Guardar"
        CmdGuardar.UseVisualStyleBackColor = False
        ' 
        ' Txt_agredadoFamiliar
        ' 
        Txt_agredadoFamiliar.BackColor = SystemColors.Menu
        Txt_agredadoFamiliar.Location = New Point(337, 215)
        Txt_agredadoFamiliar.Name = "Txt_agredadoFamiliar"
        Txt_agredadoFamiliar.Size = New Size(125, 28)
        Txt_agredadoFamiliar.TabIndex = 11
        ' 
        ' cmdAvancar2
        ' 
        cmdAvancar2.BackColor = SystemColors.Info
        cmdAvancar2.Location = New Point(21, 369)
        cmdAvancar2.Name = "cmdAvancar2"
        cmdAvancar2.Size = New Size(94, 29)
        cmdAvancar2.TabIndex = 14
        cmdAvancar2.Text = "&Avançar"
        cmdAvancar2.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxProtecoesJanelas
        ' 
        ComboBoxProtecoesJanelas.ForeColor = SystemColors.Desktop
        ComboBoxProtecoesJanelas.FormattingEnabled = True
        ComboBoxProtecoesJanelas.Items.AddRange(New Object() {"Sim", "Não"})
        ComboBoxProtecoesJanelas.Location = New Point(503, 108)
        ComboBoxProtecoesJanelas.Name = "ComboBoxProtecoesJanelas"
        ComboBoxProtecoesJanelas.Size = New Size(151, 28)
        ComboBoxProtecoesJanelas.TabIndex = 9
        ' 
        ' ComboBoxEspacoExterior
        ' 
        ComboBoxEspacoExterior.ForeColor = SystemColors.Desktop
        ComboBoxEspacoExterior.FormattingEnabled = True
        ComboBoxEspacoExterior.Items.AddRange(New Object() {"Sim", "Não"})
        ComboBoxEspacoExterior.Location = New Point(555, 57)
        ComboBoxEspacoExterior.Name = "ComboBoxEspacoExterior"
        ComboBoxEspacoExterior.Size = New Size(151, 28)
        ComboBoxEspacoExterior.TabIndex = 8
        ' 
        ' ComboBox_habitacaoVive
        ' 
        ComboBox_habitacaoVive.ForeColor = SystemColors.Desktop
        ComboBox_habitacaoVive.FormattingEnabled = True
        ComboBox_habitacaoVive.Items.AddRange(New Object() {"Apartamento", "Moradia", "Andar Moradia", "Quinta", "Casa Térrea", "Outro"})
        ComboBox_habitacaoVive.Location = New Point(261, 9)
        ComboBox_habitacaoVive.Name = "ComboBox_habitacaoVive"
        ComboBox_habitacaoVive.Size = New Size(151, 28)
        ComboBox_habitacaoVive.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ButtonFace
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label9.Location = New Point(9, 273)
        Label9.Name = "Label9"
        Label9.Size = New Size(614, 20)
        Label9.TabIndex = 6
        Label9.Text = "Caso se aplique, todas as pessoas do seu agregado familiar concordam com a adoção? * "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ButtonFace
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label8.Location = New Point(6, 319)
        Label8.Name = "Label8"
        Label8.Size = New Size(369, 20)
        Label8.TabIndex = 5
        Label8.Text = "Se tem crianças em casa, já viveram com animais? * "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonFace
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label7.Location = New Point(11, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(314, 20)
        Label7.TabIndex = 4
        Label7.Text = "Como e composto o seu agregado familiar? *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonFace
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.Location = New Point(11, 165)
        Label6.Name = "Label6"
        Label6.Size = New Size(451, 20)
        Label6.TabIndex = 3
        Label6.Text = "Se vive numa casa arrendada, o contrato permite ter animais ? *"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonFace
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(9, 116)
        Label5.Name = "Label5"
        Label5.Size = New Size(486, 20)
        Label5.TabIndex = 2
        Label5.Text = "Há proteções nas janelas e nas varandas, ou nos espaços exteriores? *"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.Location = New Point(6, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(543, 20)
        Label4.TabIndex = 1
        Label4.Text = " Tem um espaço exterior ou uma varanda onde o animal possa apanhar sol? *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(11, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(234, 20)
        Label2.TabIndex = 0
        Label2.Text = "Em que tipo de habitação vive? *"
        ' 
        ' tCuidadosComOsAnimais
        ' 
        tCuidadosComOsAnimais.BackgroundImage = CType(resources.GetObject("tCuidadosComOsAnimais.BackgroundImage"), Image)
        tCuidadosComOsAnimais.BackgroundImageLayout = ImageLayout.Stretch
        tCuidadosComOsAnimais.Controls.Add(CmdSair3)
        tCuidadosComOsAnimais.Controls.Add(CmdLimpar3)
        tCuidadosComOsAnimais.Controls.Add(CmdGuardar3)
        tCuidadosComOsAnimais.Controls.Add(cmdAvancar3)
        tCuidadosComOsAnimais.Controls.Add(TextBoxAssumeAresponsabilidade)
        tCuidadosComOsAnimais.Controls.Add(TextBoxQuandoForDeFerias)
        tCuidadosComOsAnimais.Controls.Add(TextBoxQueAlimentacaoLheDava)
        tCuidadosComOsAnimais.Controls.Add(ComboBoxJaTeveAnimaisDeEstimacao)
        tCuidadosComOsAnimais.Controls.Add(ComboBoxSaoSociaveis)
        tCuidadosComOsAnimais.Controls.Add(ComboBoxTemAnimaisEmCasa)
        tCuidadosComOsAnimais.Controls.Add(Label15)
        tCuidadosComOsAnimais.Controls.Add(Label14)
        tCuidadosComOsAnimais.Controls.Add(Label13)
        tCuidadosComOsAnimais.Controls.Add(Label12)
        tCuidadosComOsAnimais.Controls.Add(Label11)
        tCuidadosComOsAnimais.Controls.Add(LblAmimaisEmCasa)
        tCuidadosComOsAnimais.Location = New Point(4, 29)
        tCuidadosComOsAnimais.Name = "tCuidadosComOsAnimais"
        tCuidadosComOsAnimais.Padding = New Padding(3)
        tCuidadosComOsAnimais.Size = New Size(790, 413)
        tCuidadosComOsAnimais.TabIndex = 3
        tCuidadosComOsAnimais.Text = "Cuidados Com os Animais de Companhia"
        tCuidadosComOsAnimais.UseVisualStyleBackColor = True
        ' 
        ' CmdSair3
        ' 
        CmdSair3.BackColor = SystemColors.Info
        CmdSair3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        CmdSair3.Location = New Point(690, 294)
        CmdSair3.Name = "CmdSair3"
        CmdSair3.Size = New Size(94, 29)
        CmdSair3.TabIndex = 15
        CmdSair3.Text = "&Sair"
        CmdSair3.UseVisualStyleBackColor = False
        ' 
        ' CmdLimpar3
        ' 
        CmdLimpar3.BackColor = SystemColors.Info
        CmdLimpar3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        CmdLimpar3.Location = New Point(690, 229)
        CmdLimpar3.Name = "CmdLimpar3"
        CmdLimpar3.Size = New Size(94, 29)
        CmdLimpar3.TabIndex = 14
        CmdLimpar3.Text = "&Limpar"
        CmdLimpar3.UseVisualStyleBackColor = False
        ' 
        ' CmdGuardar3
        ' 
        CmdGuardar3.BackColor = SystemColors.Info
        CmdGuardar3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        CmdGuardar3.Location = New Point(690, 165)
        CmdGuardar3.Name = "CmdGuardar3"
        CmdGuardar3.Size = New Size(94, 29)
        CmdGuardar3.TabIndex = 13
        CmdGuardar3.Text = "&Guardar"
        CmdGuardar3.UseVisualStyleBackColor = False
        ' 
        ' cmdAvancar3
        ' 
        cmdAvancar3.BackColor = SystemColors.Info
        cmdAvancar3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmdAvancar3.Location = New Point(690, 100)
        cmdAvancar3.Name = "cmdAvancar3"
        cmdAvancar3.Size = New Size(94, 29)
        cmdAvancar3.TabIndex = 12
        cmdAvancar3.Text = "&Avançar"
        cmdAvancar3.UseVisualStyleBackColor = False
        ' 
        ' TextBoxAssumeAresponsabilidade
        ' 
        TextBoxAssumeAresponsabilidade.Location = New Point(22, 364)
        TextBoxAssumeAresponsabilidade.Name = "TextBoxAssumeAresponsabilidade"
        TextBoxAssumeAresponsabilidade.Size = New Size(677, 27)
        TextBoxAssumeAresponsabilidade.TabIndex = 11
        ' 
        ' TextBoxQuandoForDeFerias
        ' 
        TextBoxQuandoForDeFerias.Location = New Point(22, 286)
        TextBoxQuandoForDeFerias.Name = "TextBoxQuandoForDeFerias"
        TextBoxQuandoForDeFerias.Size = New Size(573, 27)
        TextBoxQuandoForDeFerias.TabIndex = 10
        ' 
        ' TextBoxQueAlimentacaoLheDava
        ' 
        TextBoxQueAlimentacaoLheDava.Location = New Point(22, 216)
        TextBoxQueAlimentacaoLheDava.Name = "TextBoxQueAlimentacaoLheDava"
        TextBoxQueAlimentacaoLheDava.Size = New Size(619, 27)
        TextBoxQueAlimentacaoLheDava.TabIndex = 9
        ' 
        ' ComboBoxJaTeveAnimaisDeEstimacao
        ' 
        ComboBoxJaTeveAnimaisDeEstimacao.ForeColor = SystemColors.Desktop
        ComboBoxJaTeveAnimaisDeEstimacao.FormattingEnabled = True
        ComboBoxJaTeveAnimaisDeEstimacao.Items.AddRange(New Object() {"Sim", "Não"})
        ComboBoxJaTeveAnimaisDeEstimacao.Location = New Point(463, 129)
        ComboBoxJaTeveAnimaisDeEstimacao.Name = "ComboBoxJaTeveAnimaisDeEstimacao"
        ComboBoxJaTeveAnimaisDeEstimacao.Size = New Size(151, 28)
        ComboBoxJaTeveAnimaisDeEstimacao.TabIndex = 8
        ' 
        ' ComboBoxSaoSociaveis
        ' 
        ComboBoxSaoSociaveis.ForeColor = SystemColors.Desktop
        ComboBoxSaoSociaveis.FormattingEnabled = True
        ComboBoxSaoSociaveis.Items.AddRange(New Object() {"Sim", "Não"})
        ComboBoxSaoSociaveis.Location = New Point(336, 68)
        ComboBoxSaoSociaveis.Name = "ComboBoxSaoSociaveis"
        ComboBoxSaoSociaveis.Size = New Size(151, 28)
        ComboBoxSaoSociaveis.TabIndex = 7
        ' 
        ' ComboBoxTemAnimaisEmCasa
        ' 
        ComboBoxTemAnimaisEmCasa.ForeColor = SystemColors.Desktop
        ComboBoxTemAnimaisEmCasa.FormattingEnabled = True
        ComboBoxTemAnimaisEmCasa.Items.AddRange(New Object() {"Sim", "Não"})
        ComboBoxTemAnimaisEmCasa.Location = New Point(252, 11)
        ComboBoxTemAnimaisEmCasa.Name = "ComboBoxTemAnimaisEmCasa"
        ComboBoxTemAnimaisEmCasa.Size = New Size(151, 28)
        ComboBoxTemAnimaisEmCasa.TabIndex = 6
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.ButtonFace
        Label15.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label15.Location = New Point(22, 341)
        Label15.Name = "Label15"
        Label15.Size = New Size(677, 20)
        Label15.TabIndex = 5
        Label15.Text = "Está preparado para assumir o compromisso e a responsabilidade de cuidar do seu novo amigo? *"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.ButtonFace
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label14.Location = New Point(22, 263)
        Label14.Name = "Label14"
        Label14.Size = New Size(573, 20)
        Label14.TabIndex = 4
        Label14.Text = "Quando for de férias, pensa em levar o animal consigo ou tem com que o deixar? *"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = SystemColors.ButtonFace
        Label13.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label13.Location = New Point(22, 193)
        Label13.Name = "Label13"
        Label13.Size = New Size(619, 20)
        Label13.TabIndex = 3
        Label13.Text = "Que tipo de alimentação lhes dá/dava? São/eram assistidos por um médico veterinário? *"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.ButtonFace
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label12.Location = New Point(22, 137)
        Label12.Name = "Label12"
        Label12.Size = New Size(436, 20)
        Label12.TabIndex = 2
        Label12.Text = "Já teve animais de estimação ? Se sim, o que lhes aconteceu? *"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ButtonFace
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label11.Location = New Point(22, 76)
        Label11.Name = "Label11"
        Label11.Size = New Size(301, 20)
        Label11.TabIndex = 1
        Label11.Text = "Se sim, são sociaveis com outros animais? *"
        ' 
        ' LblAmimaisEmCasa
        ' 
        LblAmimaisEmCasa.AllowDrop = True
        LblAmimaisEmCasa.AutoSize = True
        LblAmimaisEmCasa.BackColor = SystemColors.ButtonFace
        LblAmimaisEmCasa.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LblAmimaisEmCasa.ForeColor = SystemColors.ActiveCaptionText
        LblAmimaisEmCasa.Location = New Point(22, 19)
        LblAmimaisEmCasa.Name = "LblAmimaisEmCasa"
        LblAmimaisEmCasa.Size = New Size(220, 20)
        LblAmimaisEmCasa.TabIndex = 0
        LblAmimaisEmCasa.Text = "Tem outros animais em casa? *"
        ' 
        ' tRGPD
        ' 
        tRGPD.BackColor = Color.DarkGoldenrod
        tRGPD.BackgroundImageLayout = ImageLayout.Stretch
        tRGPD.Controls.Add(Button4)
        tRGPD.Controls.Add(Button3)
        tRGPD.Controls.Add(Button2)
        tRGPD.Controls.Add(cmd_submeter)
        tRGPD.Controls.Add(CheckBoxAutorizo)
        tRGPD.Controls.Add(Label18)
        tRGPD.Controls.Add(CheckBoxSim)
        tRGPD.Controls.Add(Label16)
        tRGPD.Controls.Add(CheckBoxConcordo)
        tRGPD.Controls.Add(CheckBoxTomeiConhecimento)
        tRGPD.Controls.Add(LinkLabel1)
        tRGPD.Controls.Add(Label17)
        tRGPD.Controls.Add(Label10)
        tRGPD.ForeColor = SystemColors.ControlText
        tRGPD.Location = New Point(4, 29)
        tRGPD.Name = "tRGPD"
        tRGPD.Size = New Size(790, 413)
        tRGPD.TabIndex = 4
        tRGPD.Text = "Nota sobre o RGPD"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button4.Location = New Point(677, 349)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 14
        Button4.Text = "&Sair"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button3.Location = New Point(677, 283)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 13
        Button3.Text = "&Limpar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button2.Location = New Point(677, 212)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "&Guardar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' cmd_submeter
        ' 
        cmd_submeter.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        cmd_submeter.Location = New Point(677, 145)
        cmd_submeter.Name = "cmd_submeter"
        cmd_submeter.Size = New Size(94, 29)
        cmd_submeter.TabIndex = 11
        cmd_submeter.Text = "&Submeter"
        cmd_submeter.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxAutorizo
        ' 
        CheckBoxAutorizo.AutoSize = True
        CheckBoxAutorizo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxAutorizo.Location = New Point(429, 326)
        CheckBoxAutorizo.Name = "CheckBoxAutorizo"
        CheckBoxAutorizo.Size = New Size(92, 24)
        CheckBoxAutorizo.TabIndex = 10
        CheckBoxAutorizo.Text = "Autorizo"
        CheckBoxAutorizo.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(11, 310)
        Label18.Name = "Label18"
        Label18.Size = New Size(407, 40)
        Label18.TabIndex = 9
        Label18.Text = "Autoriza que usemos fotografias nas redes sociais, " & vbCrLf & "do animal já na sua casa, de forma a incentivar a adoção?"
        ' 
        ' CheckBoxSim
        ' 
        CheckBoxSim.AutoSize = True
        CheckBoxSim.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxSim.Location = New Point(387, 232)
        CheckBoxSim.Name = "CheckBoxSim"
        CheckBoxSim.Size = New Size(57, 24)
        CheckBoxSim.TabIndex = 8
        CheckBoxSim.Text = "Sim"
        CheckBoxSim.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(11, 232)
        Label16.Name = "Label16"
        Label16.Size = New Size(370, 40)
        Label16.TabIndex = 7
        Label16.Text = "Se os seus dados pessoais de contacto se alterarem " & vbCrLf & "compromete-se a informar a Bem-Estar Animal?"
        ' 
        ' CheckBoxConcordo
        ' 
        CheckBoxConcordo.AutoSize = True
        CheckBoxConcordo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxConcordo.Location = New Point(464, 144)
        CheckBoxConcordo.Name = "CheckBoxConcordo"
        CheckBoxConcordo.Size = New Size(98, 24)
        CheckBoxConcordo.TabIndex = 6
        CheckBoxConcordo.Text = "Concordo"
        CheckBoxConcordo.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxTomeiConhecimento
        ' 
        CheckBoxTomeiConhecimento.AutoSize = True
        CheckBoxTomeiConhecimento.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxTomeiConhecimento.Location = New Point(330, 67)
        CheckBoxTomeiConhecimento.Name = "CheckBoxTomeiConhecimento"
        CheckBoxTomeiConhecimento.Size = New Size(179, 24)
        CheckBoxTomeiConhecimento.TabIndex = 5
        CheckBoxTomeiConhecimento.Text = "Tomei Conhecimento"
        CheckBoxTomeiConhecimento.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(11, 67)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(301, 20)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "https://bem-estar-animal.org/privacy-policy" & vbCrLf
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.ForeColor = SystemColors.ControlText
        Label17.Location = New Point(11, 125)
        Label17.Name = "Label17"
        Label17.Size = New Size(436, 60)
        Label17.TabIndex = 2
        Label17.Text = "Concorda que os detalhes fornecidos neste formulário sejam " & vbCrLf & "armazenados pelo período necessário à gestão do" & vbCrLf & "processo de adoção do animal ao qual se está a candidatar?"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(11, 38)
        Label10.Name = "Label10"
        Label10.Size = New Size(670, 20)
        Label10.TabIndex = 0
        Label10.Text = "Tomou conhecimento dos termos e condições de privacidade da Bem-Estar Animal no website:" & vbCrLf
        ' 
        ' FormularioAdocaoGatos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 441)
        Controls.Add(DadosPessoais)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormularioAdocaoGatos"
        Text = "Formulário Adoção Animais"
        DadosPessoais.ResumeLayout(False)
        tDadosPessoais.ResumeLayout(False)
        tDadosPessoais.PerformLayout()
        tAnimalAdotar.ResumeLayout(False)
        tAnimalAdotar.PerformLayout()
        tHabitacaoAgregadoFamiliar.ResumeLayout(False)
        tHabitacaoAgregadoFamiliar.PerformLayout()
        tCuidadosComOsAnimais.ResumeLayout(False)
        tCuidadosComOsAnimais.PerformLayout()
        tRGPD.ResumeLayout(False)
        tRGPD.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DadosPessoais As TabControl
    Friend WithEvents tDadosPessoais As TabPage
    Friend WithEvents tAnimalAdotar As TabPage
    Friend WithEvents tHabitacaoAgregadoFamiliar As TabPage
    Friend WithEvents tCuidadosComOsAnimais As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAnuncio As Label
    Friend WithEvents LblNomeAnimal As Label
    Friend WithEvents tRGPD As TabPage
    Friend WithEvents TxtMotivacao As TextBox
    Friend WithEvents TxtCaracteristicasAnimal As TextBox
    Friend WithEvents TxtAnuncio As TextBox
    Friend WithEvents TxtNomeAnimal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCaracteristicas As Label
    Friend WithEvents TxtDestinado As TextBox
    Friend WithEvents cmd_sair As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LblProfissao As Label
    Friend WithEvents LblTelemovel As Label
    Friend WithEvents LblMorada As Label
    Friend WithEvents LblDataDeNascimento As Label
    Friend WithEvents LblNome As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents Txt_profissao As TextBox
    Friend WithEvents Txt_telemovel As TextBox
    Friend WithEvents Txt_morada As TextBox
    Friend WithEvents Txt_dataNascimento As TextBox
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents cmd_avancar1 As Button
    Friend WithEvents cmd_limpar1 As Button
    Friend WithEvents cmd_guardar1 As Button
    Friend WithEvents cmd_limpar As Button
    Friend WithEvents CmdAvancar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents cmd_sair1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox_habitacaoVive As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxEspacoExterior As ComboBox
    Friend WithEvents ComboBoxProtecoesJanelas As ComboBox
    Friend WithEvents ComboBoxPessoasConcordamComAdocao As ComboBox
    Friend WithEvents Txt_agredadoFamiliar As TextBox
    Friend WithEvents ComboBoxCriancasEmCasa As ComboBox
    Friend WithEvents cmdAvancar2 As Button
    Friend WithEvents CmdGuardar As Button
    Friend WithEvents CmdLimpar As Button
    Friend WithEvents CmdSair As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblAmimaisEmCasa As Label
    Friend WithEvents ComboBoxTemAnimaisEmCasa As ComboBox
    Friend WithEvents ComboBoxSaoSociaveis As ComboBox
    Friend WithEvents TextBoxAssumeAresponsabilidade As TextBox
    Friend WithEvents TextBoxQuandoForDeFerias As TextBox
    Friend WithEvents TextBoxQueAlimentacaoLheDava As TextBox
    Friend WithEvents ComboBoxJaTeveAnimaisDeEstimacao As ComboBox
    Friend WithEvents CmdSair3 As Button
    Friend WithEvents CmdLimpar3 As Button
    Friend WithEvents CmdGuardar3 As Button
    Friend WithEvents cmdAvancar3 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents CheckBoxConcordo As CheckBox
    Friend WithEvents CheckBoxTomeiConhecimento As CheckBox
    Friend WithEvents CheckBoxAutorizo As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents CheckBoxSim As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmd_submeter As Button
End Class
