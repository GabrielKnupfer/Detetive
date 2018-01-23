using Detetive.Domain.Entities;

namespace Detetive.API.Models
{
    public class ArmaViewModel
    {
        public ArmaViewModel(Arma model)
        {
            this.Nome = model.Nome;
        }

        public string Nome { get; set; }
    }
}
