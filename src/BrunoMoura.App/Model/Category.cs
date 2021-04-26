using System.Collections.Generic;

namespace BrunoMoura.App.Model
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Article> Articles { get; set; }
    }
}