using Caliburn.Micro;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Navigation;
using LogoUI.Samples.Client.Gui.Shell.UiServices;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;

namespace LogoUI.Samples.Client.Gui.Shell
{
	public sealed class AppBootstrapper : NavigationBootstrapper<ShellViewModel,ExtendedSimpleIocContainer>
	{
	    protected override void OnConfigure(ExtendedSimpleIocContainer container)
		{
            base.OnConfigure(container);            
            
            container.RegisterSingleton<IShellCloseService, ShellViewModel>();
            container.RegisterSingleton<IWindowManager, ShellViewModel>("LikeRT");             
        }	    
	}
}