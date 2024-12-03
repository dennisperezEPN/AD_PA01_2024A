using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protocolo
{
    public class ProtocoloData
    {
        public Pedido Pedido { get; set; }
        public Respuesta Respuesta { get; set; }

        // Constructor vacío
        public ProtocoloData()
        {
            // Inicializa las propiedades si es necesario.
            Pedido = null;
            Respuesta = null;
        }

        // Constructor para inicializar con un Pedido
        public ProtocoloData(Pedido pedido)
        {
            this.Pedido = pedido;
            this.Respuesta = null;  // No necesita Respuesta
        }

        // Constructor para inicializar con una Respuesta
        public ProtocoloData(Respuesta respuesta)
        {
            this.Respuesta = respuesta;
            this.Pedido = null;  // No necesita Pedido
        }

        public static ProtocoloData CrearConPedido(string comando, string[] parametros)
        {
            Pedido pedido = new Pedido
            {
                Comando = comando,
                Parametros = parametros
            };

            return new ProtocoloData(pedido);
        }

        public static ProtocoloData CrearConRespuesta()
        {
            Respuesta respuesta = new Respuesta();
            return new ProtocoloData(respuesta);
        }
    }
}
