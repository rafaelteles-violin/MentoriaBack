
namespace Livraria.Application
{
    public class ServerStatus
    {
        public string Message { get; set; }
        public List<string> Erros { get; set; }

        //public List<object> Objects { get; set; }

        //public object Object { get; set; }

        public ServerStatus(string mensagem)
        {
            Message = mensagem;
        }

        public ServerStatus(List<string> erros)
        {
            Erros = new List<string>();
            Erros.AddRange(erros);
        }
    }
}
