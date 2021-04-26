using System.Collections.Generic;

namespace BrunoMoura.App.Model
{
    public class Tag : Entity
    {
        public string Name { get; set; }
        
        // Entity Framework
        public virtual IEnumerable<Article> Articles { get; set; }
    }
}