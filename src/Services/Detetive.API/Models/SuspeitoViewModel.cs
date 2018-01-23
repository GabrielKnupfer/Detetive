using Detetive.Domain.Entities;

namespace Detetive.API.Models
{
    public class SuspeitoViewModel
    {
        public SuspeitoViewModel(Suspeito model)
        {
            this.Nome = model.Nome;
        }

        public string Nome { get; set; }
    }
}
