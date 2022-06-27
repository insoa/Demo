using UI.Controllers;
using Zenject;

namespace Installers {
	public sealed class GameplayUiControllerInstaller : MonoInstaller {
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<GameplayUiController>().AsSingle();
		}
	}
}