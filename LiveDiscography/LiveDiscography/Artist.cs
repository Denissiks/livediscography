using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDiscography
{
    class Artist
    {
        string name;
        string genre;
        string labels;
        string realName;

        public Artist(string name, string genre, string labels, string realName)
        {
            this.Name = name;
            this.Genre = genre;
            this.Labels = labels;
            this.RealName = realName;
        }

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Labels { get => labels; set => labels = value; }
        public string RealName { get => realName; set => realName = value; }
    }
}
