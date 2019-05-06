using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waifu2xVideo.ViewModels
{
    public class ProgressViewModel : Screen
    {
        private const string BUTTON_NAME_CANCEL = "キャンセル";
        private const string BUTTON_NAME_BACK = "戻る";

        private readonly INavigationService _navigationService;
        private string _cancelButtonName;

        public string CancelButtonName
        {
            get { return _cancelButtonName; }
            set
            {
                _cancelButtonName = value;
                NotifyOfPropertyChange(() => CancelButtonName);
            }
        }

        public ProgressViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            this.CancelButtonName = BUTTON_NAME_CANCEL;
        }

        public void Loaded()
        {
        }

        public void Cancel()
        {
            if (this.CancelButtonName == BUTTON_NAME_CANCEL)
            {
                _navigationService.For<StartViewModel>().Navigate();    //TODO: 仮実装
            }
            else
            {
                _navigationService.For<StartViewModel>().Navigate();
            }
        }
    }
}
