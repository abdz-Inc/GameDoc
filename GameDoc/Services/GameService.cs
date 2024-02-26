using GameDoc.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoc.Services
{
    public class GameService : IGameService
    {
        IRestService _restService;
        public async Task<ObservableCollection<Game>> GetTasksAsync()
        {
            return await _restService.RefreshDataAsync();
        }
        public GameService(RestService restService) 
        {
            _restService = restService;
        }
    }
}
