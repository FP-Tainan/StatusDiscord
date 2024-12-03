namespace DiscStatus
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnTrabalhando = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlmoco = new System.Windows.Forms.Button();
            this.btnEmReuniao = new System.Windows.Forms.Button();
            this.btnEstudando = new System.Windows.Forms.Button();
            this.btnFerias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trabalhando = new System.Windows.Forms.ToolStripMenuItem();
            this.Almocando = new System.Windows.Forms.ToolStripMenuItem();
            this.Reuniao = new System.Windows.Forms.ToolStripMenuItem();
            this.Estudando = new System.Windows.Forms.ToolStripMenuItem();
            this.Ferias = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrabalhando
            // 
            this.btnTrabalhando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabalhando.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabalhando.Location = new System.Drawing.Point(79, 56);
            this.btnTrabalhando.Name = "btnTrabalhando";
            this.btnTrabalhando.Size = new System.Drawing.Size(154, 63);
            this.btnTrabalhando.TabIndex = 0;
            this.btnTrabalhando.Text = "Trabalhando";
            this.btnTrabalhando.UseVisualStyleBackColor = true;
            this.btnTrabalhando.Click += new System.EventHandler(this.btnTrabalhando_Click);
            // 
            // status
            // 
            this.status.Icon = ((System.Drawing.Icon)(resources.GetObject("status.Icon")));
            this.status.Text = "Orcus Status - Discord";
            this.status.Visible = true;
            this.status.DoubleClick += new System.EventHandler(this.status_DoubleClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Trabalhando,
            this.Almocando,
            this.Reuniao,
            this.Estudando,
            this.Ferias,
            this.Sair});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(224, 254);
            // 
            // Sair
            // 
            this.Sair.Image = global::DiscStatus.Properties.Resources.exit_icon_icons_com_70975;
            this.Sair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(223, 38);
            this.Sair.Text = "Sair";
            // 
            // btnAlmoco
            // 
            this.btnAlmoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlmoco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmoco.Location = new System.Drawing.Point(79, 125);
            this.btnAlmoco.Name = "btnAlmoco";
            this.btnAlmoco.Size = new System.Drawing.Size(154, 63);
            this.btnAlmoco.TabIndex = 0;
            this.btnAlmoco.Text = "Almoçando";
            this.btnAlmoco.UseVisualStyleBackColor = true;
            this.btnAlmoco.Click += new System.EventHandler(this.btnAlmoco_Click);
            // 
            // btnEmReuniao
            // 
            this.btnEmReuniao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmReuniao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmReuniao.Location = new System.Drawing.Point(79, 194);
            this.btnEmReuniao.Name = "btnEmReuniao";
            this.btnEmReuniao.Size = new System.Drawing.Size(154, 63);
            this.btnEmReuniao.TabIndex = 0;
            this.btnEmReuniao.Text = "Em Reunião";
            this.btnEmReuniao.UseVisualStyleBackColor = true;
            this.btnEmReuniao.Click += new System.EventHandler(this.btnEmReuniao_Click);
            // 
            // btnEstudando
            // 
            this.btnEstudando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEstudando.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudando.Location = new System.Drawing.Point(79, 263);
            this.btnEstudando.Name = "btnEstudando";
            this.btnEstudando.Size = new System.Drawing.Size(154, 63);
            this.btnEstudando.TabIndex = 0;
            this.btnEstudando.Text = "Estudando ou Em Treinamento";
            this.btnEstudando.UseVisualStyleBackColor = true;
            this.btnEstudando.Click += new System.EventHandler(this.btnEstudando_Click);
            // 
            // btnFerias
            // 
            this.btnFerias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnFerias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFerias.Location = new System.Drawing.Point(79, 332);
            this.btnFerias.Name = "btnFerias";
            this.btnFerias.Size = new System.Drawing.Size(154, 63);
            this.btnFerias.TabIndex = 0;
            this.btnFerias.Text = "Em Férias";
            this.btnFerias.UseVisualStyleBackColor = true;
            this.btnFerias.Click += new System.EventHandler(this.btnFerias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status Discord - Informe:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::DiscStatus.Properties.Resources.Ferias;
            this.pictureBox5.Location = new System.Drawing.Point(8, 332);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::DiscStatus.Properties.Resources.Estudando;
            this.pictureBox4.Location = new System.Drawing.Point(8, 263);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DiscStatus.Properties.Resources.reuniao;
            this.pictureBox3.Location = new System.Drawing.Point(8, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DiscStatus.Properties.Resources.Almoco;
            this.pictureBox2.Location = new System.Drawing.Point(8, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DiscStatus.Properties.Resources.Trabalhando;
            this.pictureBox1.Location = new System.Drawing.Point(8, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Trabalhando
            // 
            this.Trabalhando.Image = global::DiscStatus.Properties.Resources.support_icon_icons_com_55294;
            this.Trabalhando.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Trabalhando.Name = "Trabalhando";
            this.Trabalhando.Size = new System.Drawing.Size(223, 38);
            this.Trabalhando.Text = "Trabalhando";
            // 
            // Almocando
            // 
            this.Almocando.Image = global::DiscStatus.Properties.Resources.fast_food_icons_freeburger_107425;
            this.Almocando.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Almocando.Name = "Almocando";
            this.Almocando.Size = new System.Drawing.Size(223, 38);
            this.Almocando.Text = "Almoçando";
            // 
            // Reuniao
            // 
            this.Reuniao.Image = global::DiscStatus.Properties.Resources.chat_dialogue_conversation_bubble_speech_communication_discussion_message_talk_icon_231902;
            this.Reuniao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Reuniao.Name = "Reuniao";
            this.Reuniao.Size = new System.Drawing.Size(223, 38);
            this.Reuniao.Text = "Em Reunião";
            // 
            // Estudando
            // 
            this.Estudando.Image = global::DiscStatus.Properties.Resources.notes_notebook_smartphone_study_student_icon_191196;
            this.Estudando.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Estudando.Name = "Estudando";
            this.Estudando.Size = new System.Drawing.Size(223, 38);
            this.Estudando.Text = "Estudando / Treinamento";
            // 
            // Ferias
            // 
            this.Ferias.Image = global::DiscStatus.Properties.Resources.swimming_pool_sun_umbrella_holiday_vacation_icon_196770;
            this.Ferias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ferias.Name = "Ferias";
            this.Ferias.Size = new System.Drawing.Size(223, 38);
            this.Ferias.Text = "De Férias";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFerias);
            this.Controls.Add(this.btnEstudando);
            this.Controls.Add(this.btnEmReuniao);
            this.Controls.Add(this.btnAlmoco);
            this.Controls.Add(this.btnTrabalhando);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(261, 446);
            this.MinimumSize = new System.Drawing.Size(261, 446);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STATUS - DS";
            this.Resize += new System.EventHandler(this.frmMenu_Resize);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrabalhando;
        private System.Windows.Forms.NotifyIcon status;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Trabalhando;
        private System.Windows.Forms.ToolStripMenuItem Almocando;
        private System.Windows.Forms.ToolStripMenuItem Reuniao;
        private System.Windows.Forms.ToolStripMenuItem Estudando;
        private System.Windows.Forms.ToolStripMenuItem Ferias;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.Button btnAlmoco;
        private System.Windows.Forms.Button btnEmReuniao;
        private System.Windows.Forms.Button btnEstudando;
        private System.Windows.Forms.Button btnFerias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
    }
}