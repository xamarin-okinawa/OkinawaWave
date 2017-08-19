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

        private string _imgTitle;
		public string ImgTitle
		{
			get { return _imgTitle; }
			set { SetProperty(ref _imgTitle, value); }
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
            WaveDatas.Add(new WaveData(){
               Title = "真栄田岬", TweetCnt = "6", Wind="1.5"
            });
      			WaveDatas.Add(new WaveData()
      			{
      				Title = "宮城海岸",
      				TweetCnt = "2",
      				Wind = "2.0"
      			});
      			WaveDatas.Add(new WaveData()
      			{
      				Title = "大泊ビーチ",
      				TweetCnt = "11",
      				Wind = "0.5"
      			});
      			WaveDatas.Add(new WaveData()
      			{
      				Title = "ゴリラチョップ",
      				TweetCnt = "4",
      				Wind = "0.5"
      			});
      			WaveDatas.Add(new WaveData()
      			{
      				Title = "大度海浜岸",
      				TweetCnt = "7",
      				Wind = "0.5"
      			});
      			WaveDatas.Add(new WaveData()
      			{
      				Title = "備瀬崎",
      				TweetCnt = "3",
      				Wind = "1.0"
      			});

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
            ImgTitle = "Images/okinawa.png";

            // todo:

        }
    }
}
