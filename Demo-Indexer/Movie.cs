using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexer
{
    class Movie
    {
        public string Title { get; set; }
        private Dictionary<string, Actor> roles = new Dictionary<string, Actor>();

        public Actor this[string characterName]
        {
            get {
                Actor actor = null;
                roles.TryGetValue(characterName, out actor);
                return actor;
            }
            set {
                if(value != null) roles[characterName] = value;
            }
        }
    }
}
