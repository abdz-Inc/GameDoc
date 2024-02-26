using GameDoc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.ViewModel
{
     public class FlyoutMenuViewModel
    {
        public List<PropertyInfo> Properties { get; set; }

        public FlyoutMenuViewModel()
        {
            var _ = new Game();
            Properties = _.GetType().GetProperties().ToList();
        }
    }
}
