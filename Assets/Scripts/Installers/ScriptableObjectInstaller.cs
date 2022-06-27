using Databases;
using UnityEngine;
using Zenject;

namespace Installers {
	
	[CreateAssetMenu(fileName = "ScriptableObjectInstaller", menuName = "Installers/ScriptableObjectInstaller")]
	public sealed class ScriptableObjectInstaller : ScriptableObjectInstaller<ScriptableObjectInstaller> {

		[SerializeField] private UnitDatabase _unitDatabase;
		[SerializeField] private InventoryDatabase _inventoryDatabase;
		public override void InstallBindings() {
			Container.BindInstance(_unitDatabase);
			Container.BindInstance(_inventoryDatabase);
		}
	}
}