<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Cmd_donativo = New Button()
        Cmd_sair = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        AnimaisToolStripMenuItem = New ToolStripMenuItem()
        FormularioAdoçãoDeGatosToolStripMenuItem = New ToolStripMenuItem()
        ComoAjudarToolStripMenuItem = New ToolStripMenuItem()
        DonativosToolStripMenuItem = New ToolStripMenuItem()
        NumeroSolidárioToolStripMenuItem = New ToolStripMenuItem()
        ParceirosToolStripMenuItem = New ToolStripMenuItem()
        RoyalCaninToolStripMenuItem = New ToolStripMenuItem()
        TiendaAnimalToolStripMenuItem = New ToolStripMenuItem()
        OToolStripMenuItem = New ToolStripMenuItem()
        PetOutletToolStripMenuItem = New ToolStripMenuItem()
        KiwokoToolStripMenuItem = New ToolStripMenuItem()
        LojaToolStripMenuItem = New ToolStripMenuItem()
        RedesSociaisToolStripMenuItem = New ToolStripMenuItem()
        FacebookToolStripMenuItem = New ToolStripMenuItem()
        InstagramToolStripMenuItem = New ToolStripMenuItem()
        Cmd_GaleriaAnimais = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ButtonShadow
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-9, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(807, 410)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Cmd_donativo
        ' 
        Cmd_donativo.BackColor = SystemColors.ButtonHighlight
        Cmd_donativo.BackgroundImageLayout = ImageLayout.None
        Cmd_donativo.FlatAppearance.BorderColor = Color.Black
        Cmd_donativo.FlatStyle = FlatStyle.Popup
        Cmd_donativo.ForeColor = SystemColors.ActiveCaptionText
        Cmd_donativo.Location = New Point(28, 62)
        Cmd_donativo.Name = "Cmd_donativo"
        Cmd_donativo.Size = New Size(94, 29)
        Cmd_donativo.TabIndex = 3
        Cmd_donativo.Text = "&Donativo"
        Cmd_donativo.UseVisualStyleBackColor = False
        ' 
        ' Cmd_sair
        ' 
        Cmd_sair.BackColor = SystemColors.ButtonHighlight
        Cmd_sair.BackgroundImageLayout = ImageLayout.None
        Cmd_sair.FlatAppearance.BorderColor = Color.Black
        Cmd_sair.FlatStyle = FlatStyle.Popup
        Cmd_sair.ForeColor = SystemColors.ActiveCaptionText
        Cmd_sair.Location = New Point(673, 372)
        Cmd_sair.Name = "Cmd_sair"
        Cmd_sair.Size = New Size(94, 29)
        Cmd_sair.TabIndex = 4
        Cmd_sair.Text = "&Sair"
        Cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, AnimaisToolStripMenuItem, ComoAjudarToolStripMenuItem, ParceirosToolStripMenuItem, LojaToolStripMenuItem, RedesSociaisToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 3, 0, 3)
        MenuStrip1.Size = New Size(798, 30)
        MenuStrip1.TabIndex = 5
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(111, 24)
        ToolStripMenuItem1.Text = "A Associação"
        ' 
        ' AnimaisToolStripMenuItem
        ' 
        AnimaisToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormularioAdoçãoDeGatosToolStripMenuItem})
        AnimaisToolStripMenuItem.Name = "AnimaisToolStripMenuItem"
        AnimaisToolStripMenuItem.Size = New Size(76, 24)
        AnimaisToolStripMenuItem.Text = "Animais"
        ' 
        ' FormularioAdoçãoDeGatosToolStripMenuItem
        ' 
        FormularioAdoçãoDeGatosToolStripMenuItem.Name = "FormularioAdoçãoDeGatosToolStripMenuItem"
        FormularioAdoçãoDeGatosToolStripMenuItem.Size = New Size(302, 26)
        FormularioAdoçãoDeGatosToolStripMenuItem.Text = "Formulario Adoção de Animais "
        ' 
        ' ComoAjudarToolStripMenuItem
        ' 
        ComoAjudarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DonativosToolStripMenuItem, NumeroSolidárioToolStripMenuItem})
        ComoAjudarToolStripMenuItem.Name = "ComoAjudarToolStripMenuItem"
        ComoAjudarToolStripMenuItem.Size = New Size(111, 24)
        ComoAjudarToolStripMenuItem.Text = "Como Ajudar"
        ' 
        ' DonativosToolStripMenuItem
        ' 
        DonativosToolStripMenuItem.Name = "DonativosToolStripMenuItem"
        DonativosToolStripMenuItem.Size = New Size(224, 26)
        DonativosToolStripMenuItem.Text = "Donativos"
        ' 
        ' NumeroSolidárioToolStripMenuItem
        ' 
        NumeroSolidárioToolStripMenuItem.Name = "NumeroSolidárioToolStripMenuItem"
        NumeroSolidárioToolStripMenuItem.Size = New Size(224, 26)
        NumeroSolidárioToolStripMenuItem.Text = "Numero Solidário"
        ' 
        ' ParceirosToolStripMenuItem
        ' 
        ParceirosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RoyalCaninToolStripMenuItem, TiendaAnimalToolStripMenuItem, OToolStripMenuItem, PetOutletToolStripMenuItem, KiwokoToolStripMenuItem})
        ParceirosToolStripMenuItem.Name = "ParceirosToolStripMenuItem"
        ParceirosToolStripMenuItem.Size = New Size(82, 24)
        ParceirosToolStripMenuItem.Text = "Parceiros"
        ' 
        ' RoyalCaninToolStripMenuItem
        ' 
        RoyalCaninToolStripMenuItem.Image = CType(resources.GetObject("RoyalCaninToolStripMenuItem.Image"), Image)
        RoyalCaninToolStripMenuItem.Name = "RoyalCaninToolStripMenuItem"
        RoyalCaninToolStripMenuItem.Size = New Size(224, 26)
        RoyalCaninToolStripMenuItem.Text = "Royal Canin"
        ' 
        ' TiendaAnimalToolStripMenuItem
        ' 
        TiendaAnimalToolStripMenuItem.Image = CType(resources.GetObject("TiendaAnimalToolStripMenuItem.Image"), Image)
        TiendaAnimalToolStripMenuItem.Name = "TiendaAnimalToolStripMenuItem"
        TiendaAnimalToolStripMenuItem.Size = New Size(224, 26)
        TiendaAnimalToolStripMenuItem.Text = "Tienda Animal"
        ' 
        ' OToolStripMenuItem
        ' 
        OToolStripMenuItem.Image = CType(resources.GetObject("OToolStripMenuItem.Image"), Image)
        OToolStripMenuItem.Name = "OToolStripMenuItem"
        OToolStripMenuItem.Size = New Size(224, 26)
        OToolStripMenuItem.Text = "Purina "
        ' 
        ' PetOutletToolStripMenuItem
        ' 
        PetOutletToolStripMenuItem.Image = CType(resources.GetObject("PetOutletToolStripMenuItem.Image"), Image)
        PetOutletToolStripMenuItem.Name = "PetOutletToolStripMenuItem"
        PetOutletToolStripMenuItem.Size = New Size(224, 26)
        PetOutletToolStripMenuItem.Text = "Pet Outlet"
        ' 
        ' KiwokoToolStripMenuItem
        ' 
        KiwokoToolStripMenuItem.Image = CType(resources.GetObject("KiwokoToolStripMenuItem.Image"), Image)
        KiwokoToolStripMenuItem.Name = "KiwokoToolStripMenuItem"
        KiwokoToolStripMenuItem.Size = New Size(224, 26)
        KiwokoToolStripMenuItem.Text = "Kiwoko"
        ' 
        ' LojaToolStripMenuItem
        ' 
        LojaToolStripMenuItem.Name = "LojaToolStripMenuItem"
        LojaToolStripMenuItem.Size = New Size(51, 24)
        LojaToolStripMenuItem.Text = "Loja"
        ' 
        ' RedesSociaisToolStripMenuItem
        ' 
        RedesSociaisToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FacebookToolStripMenuItem, InstagramToolStripMenuItem})
        RedesSociaisToolStripMenuItem.Name = "RedesSociaisToolStripMenuItem"
        RedesSociaisToolStripMenuItem.Size = New Size(113, 24)
        RedesSociaisToolStripMenuItem.Text = "Redes Sociais"
        ' 
        ' FacebookToolStripMenuItem
        ' 
        FacebookToolStripMenuItem.Image = CType(resources.GetObject("FacebookToolStripMenuItem.Image"), Image)
        FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        FacebookToolStripMenuItem.Size = New Size(224, 26)
        FacebookToolStripMenuItem.Text = "Facebook"
        ' 
        ' InstagramToolStripMenuItem
        ' 
        InstagramToolStripMenuItem.Image = CType(resources.GetObject("InstagramToolStripMenuItem.Image"), Image)
        InstagramToolStripMenuItem.Name = "InstagramToolStripMenuItem"
        InstagramToolStripMenuItem.Size = New Size(224, 26)
        InstagramToolStripMenuItem.Text = "Instagram"
        ' 
        ' Cmd_GaleriaAnimais
        ' 
        Cmd_GaleriaAnimais.BackColor = SystemColors.ButtonHighlight
        Cmd_GaleriaAnimais.FlatStyle = FlatStyle.Popup
        Cmd_GaleriaAnimais.ForeColor = SystemColors.ActiveCaptionText
        Cmd_GaleriaAnimais.Location = New Point(28, 372)
        Cmd_GaleriaAnimais.Name = "Cmd_GaleriaAnimais"
        Cmd_GaleriaAnimais.Size = New Size(136, 29)
        Cmd_GaleriaAnimais.TabIndex = 6
        Cmd_GaleriaAnimais.Text = "Galeria Animais"
        Cmd_GaleriaAnimais.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(798, 442)
        Controls.Add(Cmd_GaleriaAnimais)
        Controls.Add(Cmd_sair)
        Controls.Add(Cmd_donativo)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cmd_donativo As Button
    Friend WithEvents Cmd_sair As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AnimaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComoAjudarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParceirosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LojaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormularioAdoçãoDeGatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonativosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cmd_GaleriaAnimais As Button
    Friend WithEvents RedesSociaisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumeroSolidárioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacebookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstagramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoyalCaninToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiendaAnimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetOutletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KiwokoToolStripMenuItem As ToolStripMenuItem
End Class
