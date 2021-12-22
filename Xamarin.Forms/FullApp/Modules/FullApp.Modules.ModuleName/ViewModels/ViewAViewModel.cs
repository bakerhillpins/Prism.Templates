using Prism.Regions;
using Prism.Regions.Navigation;
using FullApp.Core.Mvvm;
using FullApp.Services.Interfaces;

namespace FullApp.Modules.ModuleName.ViewModels
{
    public class ViewAViewModel : RegionViewModelBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty( ref _message, value ); }
        }

        public ViewAViewModel( IRegionManager regionManager, IMessageService messageService )
            : base( regionManager )
        {
            Message = messageService.GetMessage();
        }

#region Overrides of RegionViewModelBase

        /// <inheritdoc />
        public override void OnNavigatedTo( INavigationContext navigationContext )
        {
            //do something
        }

#endregion
    }
}
