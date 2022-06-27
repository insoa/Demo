using UI.ShopPanel;
using Zenject;

namespace Installers {
	public sealed class ShopControllerInstaller : MonoInstaller {
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<ShopController>().AsSingle();
		}
	}
}