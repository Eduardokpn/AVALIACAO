using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public  partial class ResponseViewModel : ObservableObject
    {
        private readonly RestService _restService;

        public ResponseViewModel()
        {

           _restService = new RestService();
            GetResultAsyncCommand = new Command(async () => await GetResultAsync());

        }

        [ObservableProperty]
        public int _index;

        [ObservableProperty]
        public string _name;

        [ObservableProperty]
        public int _level;

        [ObservableProperty]
        public string _url;

        [ObservableProperty]
        private ObservableCollection<Response> _response = new ObservableCollection<Response>();


        [ObservableProperty]
        private ObservableCollection<Result> _result = new ObservableCollection<Result>();

        public ICommand GetResultAsyncCommand { get; }

        public async Task GetResultAsync()
        {
            Response = await _restService.GetResultAsync();



        }


    }
}
