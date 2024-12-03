using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace DiscStatus.Class
{
    public class DiscordManager
    {
        private DiscordRpcClient _client;

        public DiscordManager(string clientId)
        {
            // Inicializa o cliente do Discord com o Client ID
            _client = new DiscordRpcClient(clientId);
            _client.Initialize();
        }

        /// <summary>
        /// Configura o status do Discord.
        /// </summary>
        /// <param name="state">O estado principal (Ex.: Disponível, Ocupado, Ausente).</param>
        /// <param name="details">Detalhes adicionais (Ex.: Trabalhando, Almoçando).</param>
        /// <param name="iconKey">A chave do ícone configurado no Discord Developer Portal.</param>
        public void SetStatus(string state, string details, string iconKey)
        {
            _client.SetPresence(new RichPresence()
            {
                State = state,
                Details = details,
                Assets = new Assets()
                {
                    LargeImageKey = iconKey,
                    LargeImageText = details // Texto ao passar o mouse no ícone
                }
            });
        }

        /// <summary>
        /// Finaliza a conexão com o Discord.
        /// </summary>
        public void Dispose()
        {
            _client.Dispose();
        }
    }
}
