using System.Collections.Generic;

namespace BrunoMoura.App.Model
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        
        
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        
        // Entity Framework
        public virtual Category Category { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}