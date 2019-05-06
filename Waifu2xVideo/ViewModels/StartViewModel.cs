using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Waifu2xVideo.ViewModels
{
    public class StartViewModel : Screen
    {
        private readonly INavigationService _navigationService;
        private string _folderPath;

        public string FolderPath
        {
            get { return _folderPath; }
            set
            {
                _folderPath = value;
                NotifyOfPropertyChange(() => FolderPath);
            }
        }

        public StartViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        public void Start()
        {
            _navigationService.For<ProgressViewModel>()
                .Navigate();
        }
    }
}
