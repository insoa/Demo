using System;
using Interfaces;
using UI.InventoryPanel.Behaviours;
using UI.ShopPanel.Behaviours;
using UI.UnitButtonsPanel.Behaviours;
using UI.UnitButtonsPanel.Enums;
using Zenject;

namespace UI.Controllers {
	public sealed class GameplayUiController : IInitializable {
	
		private readonly InventoryPanelBehaviour _inventoryPanel;
		private readonly ShopPanelBehaviour _shopPanelBehaviour;
		private readonly ButtonsPanelBehaviour _buttonsPanelBehaviour;

		public GameplayUiController(ButtonsPanelBehaviour buttonsPanelBehaviour, ShopPanelBehaviour shopPanelBehaviour, InventoryPanelBehaviour inventoryPanel) {
			_buttonsPanelBehaviour = buttonsPanelBehaviour;
			_shopPanelBehaviour = shopPanelBehaviour;
			_inventoryPanel = inventoryPanel;
		}

		public void Initialize() {
			_buttonsPanelBehaviour.InventoryButton.onClick.AddListener (()  => SetState(EUiType.Inventory));
			_buttonsPanelBehaviour.ShopButton.onClick.AddListener(()  => SetState(EUiType.Shop));
			_inventoryPanel.CloseButton.onClick.AddListener(()  => SetState(EUiType.Buttons));
			_shopPanelBehaviour.CloseButton.onClick.AddListener(()  => SetState(EUiType.Buttons));
		}

		private void SetState(EUiType type) {
			switch (type) {
				case EUiType.Inventory:
					_inventoryPanel.Show();
					_shopPanelBehaviour.Hide();
					_buttonsPanelBehaviour.Hide();
					break;
				case EUiType.Shop:
					_shopPanelBehaviour.Show();
					_inventoryPanel.Hide();
					_buttonsPanelBehaviour.Hide();
					break;
				case EUiType.Buttons:
					_shopPanelBehaviour.Hide();
					_inventoryPanel.Hide();
					_buttonsPanelBehaviour.Show();
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}
		}
	}
}