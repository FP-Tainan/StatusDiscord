using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscStatus.Class;

namespace DiscStatus
{
    public partial class frmMenu : Form
    {
        private DiscordManager discordManager;
        public frmMenu()
        {
            InitializeComponent();
            discordManager = new DiscordManager("1313309308850802718");

            // Associar o ContextMenuStrip ao NotifyIcon
            status.ContextMenuStrip = menu;

            // Configurar eventos do menu
            Trabalhando.Click += (s, e) => AlterarStatus("Trabalhando");
            Almocando.Click += (s, e) => AlterarStatus("Almoçando");
            Reuniao.Click += (s, e) => AlterarStatus("Em Reunião");
            Estudando.Click += (s, e) => AlterarStatus("Estudando");
            Ferias.Click += (s, e) => AlterarStatus("De Férias");

            // Fechar pelo ícone
            Sair.Click += (s, e) => Application.Exit();
        }

        private void AlterarStatus(string status)
        {
            switch (status)
            {
                case "Trabalhando":
                    discordManager.SetStatus("Ocupado", "Trabalhando, pode chamar!", "trabalhando");
                    break;
                case "Almoçando":
                    discordManager.SetStatus("Ausente", "Almoçando! me chama depois!", "almoco");
                    break;
                case "Em Reunião":
                    discordManager.SetStatus("Ocupado", "Em Reunião! Não atrapalhe", "reuniao");
                    break;
                case "Estudando":
                    discordManager.SetStatus("Ocupado", "Em Treinamento ou Estudando", "estudando");
                    break;
                case "De Férias":
                    discordManager.SetStatus("Ausente", "Curtindo as Férias!", "ferias");
                    break;
                default:
                    discordManager.SetStatus("Ocupado", "Trabalhando", "trabalhando");
                    break;
            }


        }

        private void frmMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide(); // Esconde o formulário
            }
        }

        private void status_DoubleClick(object sender, EventArgs e)
        {
            Show(); // Mostra o formulário
            WindowState = FormWindowState.Normal;
        }

        private void btnTrabalhando_Click(object sender, EventArgs e)
        {
            AlterarStatus("Trabalhando");
            this.Hide();
        }

        private void btnAlmoco_Click(object sender, EventArgs e)
        {
            AlterarStatus("Almoçando");
            this.Hide();
        }

        private void btnEmReuniao_Click(object sender, EventArgs e)
        {
            AlterarStatus("Em Reunião");
            this.Hide();
        }

        private void btnEstudando_Click(object sender, EventArgs e)
        {
            AlterarStatus("Estudando");
            this.Hide();
        }

        private void btnFerias_Click(object sender, EventArgs e)
        {
            AlterarStatus("De Férias");
            this.Hide();
        }
    }
}
