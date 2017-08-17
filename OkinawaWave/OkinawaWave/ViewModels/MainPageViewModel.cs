using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using OkinawaWave.Business;

namespace OkinawaWave.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        private ObservableCollection<WaveData> _waveDatas = new ObservableCollection<WaveData>();
        public ObservableCollection<WaveData> WaveDatas
        {
            get
            {
                return _waveDatas;
            }
            set{
                SetProperty(ref _waveDatas, value);
            }
        }


        public MainPageViewModel()
        {
            WaveDatas = new ObservableCollection<WaveData>();
			WaveDatas.Add(new WaveData());
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";

            // todo:

        }
    }
}
