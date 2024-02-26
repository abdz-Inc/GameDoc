using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Background_Image { get; set; }
       
    }
}
