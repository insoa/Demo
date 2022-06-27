using Databases;
using Enums;
using Other;
using Units;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.InventoryPanel.Behaviours {
	public sealed class InventoryCellBehaviour : MonoBehaviour {
		
		public Button Button;
		public EUnitType ButtonType;
		public Image UnitImage;

		[SerializeField] private int _unitQuantity;
		[SerializeField] private bool _isSelected;

		private void Start() {
			Button.onClick.AddListener(SetUnit);
		}

		private void SetUnit() {
			if (!_isSelected) {
				_isSelected = true;
				UnitSpawnerBehaviour.Instance.SelectUnitFromData(ButtonType);
			} else
				_isSelected = false;
		}
	}
}