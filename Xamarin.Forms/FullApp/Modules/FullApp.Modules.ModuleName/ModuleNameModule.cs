using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using FullApp.Core;
using FullApp.Modules.ModuleName.Views;

namespace FullApp.Modules.ModuleName
{
    public class ModuleNameModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleNameModule( IRegionManager regionManager )
        {
            _regionManager = regionManager;
        }

#region Implementation of IModule

        /// <inheritdoc />
        public void OnInitialized( IContainerProvider containerProvider )
        {
            _regionManager.RequestNavigate( RegionNames.ContentRegion, "ViewA" );
        }

        /// <inheritdoc />
        public void RegisterTypes( IContainerRegistry containerRegistry )
        {
            containerRegistry.RegisterForRegionNavigation<ViewA>();
        }

#endregion
    }
}
