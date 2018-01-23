using Detetive.Domain.Entities;
using System;
using System.Linq;

namespace Detetive.Infrastructure.Migrations
{
    public static class DbInitializer
    {
        public static void Initialize(DetetiveContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Armas.Any())
            {
                var armas = new Arma[]
                    {
                        new Arma{Nome ="Cajado Devastador"},
                        new Arma{Nome ="Phaser"},
                        new Arma{Nome ="Peixeira"},
                        new Arma{Nome ="Trezoitão"},
                        new Arma{Nome ="Sabre de Luz"},
                        new Arma{Nome ="Bomba"},
                    };

                foreach(Arma a in armas)
                {
                    context.Armas.Add(a);
                }

                context.SaveChanges();
            }

            if(!context.Locais.Any())
            {
                var locais = new Local[]
                {
                        new Local{Nome ="Etérnia"},
                        new Local{Nome ="Vulcano"},
                        new Local{Nome ="Tatooine"},
                        new Local{Nome ="Springfield"},
                        new Local{Nome ="Gotham"},
                        new Local{Nome ="Nova York"},
                        new Local{Nome ="Sibéria"},
                        new Local{Nome ="Machu Picchu"},
                        new Local{Nome ="Show do Katinguele"},
                        new Local{Nome ="São Paulo"}
                };

                foreach (Local l in locais)
                {
                    context.Locais.Add(l);
                }

                context.SaveChanges();
            }

            if (!context.Suspeitos.Any())
            {
                var suspeitos = new Suspeito[]
                {
                        new Suspeito{Nome ="Esqueleto"},
                        new Suspeito{Nome ="Khan"},
                        new Suspeito{Nome ="Darth vader"},
                        new Suspeito{Nome ="Sideshow Bob"},
                        new Suspeito{Nome ="Coringa"},
                        new Suspeito{Nome ="Duende Verde"},
                };

                foreach (Suspeito s in suspeitos)
                {
                    context.Suspeitos.Add(s);
                }

                context.SaveChanges();
            }

        }
    }
}
