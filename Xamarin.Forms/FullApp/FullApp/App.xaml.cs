using FullApp.Modules.ModuleName;
using FullApp.Services;
using FullApp.Services.Interfaces;
using Prism;
using Prism.Ioc;
using Prism.Modularity;
using FullApp.ViewModels;
using FullApp.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace FullApp
{
    public partial class App
    {
        public App( IPlatformInitializer initializer = null )
            : base( initializer )
        { }

#region Overrides of PrismApplicationBase

        /// <inheritdoc />
        protected override async void OnInitialized()
        {
            InitializeComponent();

            //var result = await NavigationService.NavigateAsync( "MainPage" );

            //if ( !result.Success )
            //{
            //    System.Diagnostics.Debugger.Break();
            //}
        }

        /// <inheritdoc />
        protected override async void InitializeModules()
        {
            /// BUG? Need to navigate to MainPage here if planning to Navigate to region in IModule.OnInitialized
            var result = await NavigationService.NavigateAsync("MainPage");

            if (!result.Success)
            {
                System.Diagnostics.Debugger.Break();
            }

            base.InitializeModules();
        }

        /// <inheritdoc />
        protected override void RegisterTypes( IContainerRegistry containerRegistry )
        {
            containerRegistry.RegisterRegionServices();

            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        /// <inheritdoc />
        protected override void ConfigureModuleCatalog( IModuleCatalog moduleCatalog )
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }

#endregion
    }
}
