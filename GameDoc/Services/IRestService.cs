using GameDoc.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.Services
{
    public interface IRestService
    {
        Task<ObservableCollection<Game>> RefreshDataAsync();
    }
}
