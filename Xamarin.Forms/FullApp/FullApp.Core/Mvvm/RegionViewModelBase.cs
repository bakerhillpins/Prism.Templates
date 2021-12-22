using Prism.Regions;
using System;
using Prism.Regions.Navigation;

namespace FullApp.Core.Mvvm
{
    public class RegionViewModelBase : ViewModelBase, IRegionAware, IConfirmRegionNavigationRequest
    {
        protected IRegionManager RegionManager { get; private set; }

        public RegionViewModelBase( IRegionManager regionManager )
        {
            RegionManager = regionManager;
        }

#region Implementation of IConfirmRegionNavigationRequest

        /// <inheritdoc />
        public virtual void ConfirmNavigationRequest(
            INavigationContext navigationContext, Action<bool> continuationCallback )
        {
            continuationCallback( true );
        }

#endregion

#region Implementation of IRegionAware

        /// <inheritdoc />
        public virtual void OnNavigatedTo( INavigationContext navigationContext )
        {

        }

        /// <inheritdoc />
        public virtual bool IsNavigationTarget( INavigationContext navigationContext )
        {
            return true;
        }

        /// <inheritdoc />
        public virtual void OnNavigatedFrom( INavigationContext navigationContext )
        {

        }

#endregion
    }
}
