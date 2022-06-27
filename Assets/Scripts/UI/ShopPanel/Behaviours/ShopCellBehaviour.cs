using Enums;
using UnityEngine;
using UnityEngine.UI;

namespace UI.ShopPanel.Behaviours {
	public sealed class ShopCellBehaviour : MonoBehaviour {
		
		public Button Button;
	
		[SerializeField] private EUnitType _unitType;
		[SerializeField] private EUnitClass _classType;

		[SerializeField] private Image _selector;
		[SerializeField] private Image _unitImage;
		
		public void SetUnitType(EUnitType type) => _unitType = type;
		public void SetUnitClass(EUnitClass type) => _classType = type;
		public void SetUnitIcon(Sprite icon) => _unitImage.sprite = icon;
		public void SetSelected(bool isSelected) => _selector.gameObject.SetActive(isSelected);
	}
}