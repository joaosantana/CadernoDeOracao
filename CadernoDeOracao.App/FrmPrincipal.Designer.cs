namespace CadernoDeOracao.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonApagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRespondido = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNaoRespondido = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConfiguracoes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSobre = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNovo,
            this.toolStripButtonEditar,
            this.toolStripButtonApagar,
            this.toolStripSeparator1,
            this.toolStripButtonRespondido,
            this.toolStripButtonNaoRespondido,
            this.toolStripSeparator2,
            this.toolStripButtonConfiguracoes,
            this.toolStripButtonSobre});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(624, 55);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            this.toolStripButtonNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNovo.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_add_48;
            this.toolStripButtonNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNovo.Name = "toolStripButtonNovo";
            this.toolStripButtonNovo.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonNovo.Text = "Novo pedido";
            this.toolStripButtonNovo.Click += new System.EventHandler(this.ToolStripButtonNovo_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditar.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_edit_48;
            this.toolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonEditar.Text = "Editar pedido";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.ToolStripButtonEditar_Click);
            // 
            // toolStripButtonApagar
            // 
            this.toolStripButtonApagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonApagar.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_remove_48;
            this.toolStripButtonApagar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApagar.Name = "toolStripButtonApagar";
            this.toolStripButtonApagar.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonApagar.Text = "Apagar pedido";
            this.toolStripButtonApagar.Click += new System.EventHandler(this.ToolStripButtonApagar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonRespondido
            // 
            this.toolStripButtonRespondido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRespondido.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_checked_checkbox_48;
            this.toolStripButtonRespondido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRespondido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRespondido.Name = "toolStripButtonRespondido";
            this.toolStripButtonRespondido.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonRespondido.Text = "Pedido respondido";
            this.toolStripButtonRespondido.Click += new System.EventHandler(this.ToolStripButtonRespondido_Click);
            // 
            // toolStripButtonNaoRespondido
            // 
            this.toolStripButtonNaoRespondido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNaoRespondido.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_unchecked_checkbox_48;
            this.toolStripButtonNaoRespondido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonNaoRespondido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNaoRespondido.Name = "toolStripButtonNaoRespondido";
            this.toolStripButtonNaoRespondido.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonNaoRespondido.Text = "Pedido não respondido";
            this.toolStripButtonNaoRespondido.Click += new System.EventHandler(this.ToolStripButtonNaoRespondido_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonConfiguracoes
            // 
            this.toolStripButtonConfiguracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConfiguracoes.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_gears_48;
            this.toolStripButtonConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonConfiguracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConfiguracoes.Name = "toolStripButtonConfiguracoes";
            this.toolStripButtonConfiguracoes.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonConfiguracoes.Text = "Configurações";
            this.toolStripButtonConfiguracoes.Click += new System.EventHandler(this.ToolStripButtonConfiguracoes_Click);
            // 
            // toolStripButtonSobre
            // 
            this.toolStripButtonSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSobre.Image = global::CadernoDeOracao.App.Properties.Resources.icons8_about_48;
            this.toolStripButtonSobre.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSobre.Name = "toolStripButtonSobre";
            this.toolStripButtonSobre.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonSobre.Text = "Sobre este app";
            this.toolStripButtonSobre.Click += new System.EventHandler(this.ToolStripButtonSobre_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusVersao});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusVersao
            // 
            this.toolStripStatusVersao.Name = "toolStripStatusVersao";
            this.toolStripStatusVersao.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusVersao.Text = "toolStripStatusVersao";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caderno de Oração";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonApagar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonRespondido;
        private ToolStripButton toolStripButtonNaoRespondido;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonConfiguracoes;
        private ToolStripButton toolStripButtonSobre;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusVersao;
    }
}