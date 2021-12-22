using Prism.Mvvm;
using Prism.Navigation;

namespace FullApp.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase()
        { }

#region Implementation of IDestructible

        /// <inheritdoc />
        public void Destroy()
        { }

#endregion
    }
}
