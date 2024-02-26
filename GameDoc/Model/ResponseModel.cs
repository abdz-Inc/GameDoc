using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.Model
{
    public class ResponseModel
    {
        public int Count { get; set; }
        public string Next {  get; set; }
        public string Previous { get; set; }
        public ObservableCollection<Game> Results { get; set; }
    }
}
