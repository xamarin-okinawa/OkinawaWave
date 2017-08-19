using System;
using Prism.Mvvm;

namespace OkinawaWave.Business
{
    public class WaveData : BindableBase
    {
        public string Title
        {
            get;
            set;
        }

    		public string Wind
    		{
    			get;
    			set;
    		}

    		public string TweetCnt
    		{
    			get;
    			set;
    		}

    }
}
