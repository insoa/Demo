using UI.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace UI.UnitButtonsPanel.Behaviours {
	public sealed class ButtonsPanelBehaviour : MonoBehaviour, IUiPanel {

		public Button InventoryButton;
		public Button ShopButton;
		
		public void Show() => gameObject.SetActive(true);

		public void Hide() => gameObject.SetActive(false);
	}
}