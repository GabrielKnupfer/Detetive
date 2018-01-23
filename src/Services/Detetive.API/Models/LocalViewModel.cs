using Detetive.Domain.Entities;

namespace Detetive.API.Models
{
    public class LocalViewModel
    {
        public LocalViewModel(Local model)
        {
            this.Nome = model.Nome;
        }

        public string Nome { get; set; }
    }
}
