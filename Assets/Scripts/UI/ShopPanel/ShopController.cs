using Databases;
using UI.ShopPanel.Behaviours;
using Zenject;

namespace UI.ShopPanel {
	public sealed class ShopController : IInitializable {

		private readonly ShopPanelBehaviour _shopPanelBehaviour;
		private readonly UnitDatabase _unitDatabase;
		
		public ShopController(ShopPanelBehaviour shopPanelBehaviour, UnitDatabase unitDatabase) {
			_shopPanelBehaviour = shopPanelBehaviour;
			_unitDatabase = unitDatabase;
		}

		public void Initialize() {
			var unitCount = _unitDatabase.GetUnitsCount();
			for (var i = 0; i < unitCount; i++) {
				var unit = _unitDatabase.GetUnitFromData(i);
				_shopPanelBehaviour.CreateCell(unit);
				_shopPanelBehaviour.Subscribe(unit);
			}
		}
	}
}