using System;
using System.Collections.Generic;
using Databases;
using Interfaces;
using TMPro;
using UI.Interfaces;
using UI.InventoryPanel.Behaviours;
using UI.ShopPanel.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.ShopPanel.Behaviours {
	public sealed class ShopPanelBehaviour : MonoBehaviour, IShop, IUiPanel {
		
		private readonly List<ShopCellBehaviour> _shopProducts = new List<ShopCellBehaviour>();

		[Inject] private InventoryPanelBehaviour _inventoryPanel;
		[SerializeField] private TextMeshProUGUI _damage;
		[SerializeField] private TextMeshProUGUI _health;
		[SerializeField] private TextMeshProUGUI _armor;
		[SerializeField] private TextMeshProUGUI _price;
		[SerializeField] private Button _buyButton;

		[SerializeField] private ShopCellBehaviour _cellPrefab;
		[SerializeField] private Transform _contentParent;

		public Button CloseButton;
		
		public void CreateCell(Unit unit) {
			var cell = Instantiate(_cellPrefab, _contentParent);
			cell.SetUnitType(unit.Type);
			cell.SetUnitClass(unit.Class);
			cell.SetUnitIcon(unit.UnitIcon);
			_shopProducts.Add(cell);
		}

		public void Subscribe(Unit unit) {
			for (var i = 0; i < _shopProducts.Count; i++) {
				var index = i;
				_shopProducts[i].Button.onClick.AddListener(() => OnProductClick(index, unit));
			}
		}

		public void OnProductClick(int index, Unit unit) {
			for (var i = 0; i < _shopProducts.Count; i++) {
				_shopProducts[i].SetSelected(i == index);
				_buyButton.onClick.RemoveAllListeners();
				_damage.text = unit.Damage.ToString();
				_health.text = unit.Health.ToString();
				_armor.text = unit.Armor.ToString();
				_price.text = unit.Price.ToString();
				_buyButton.onClick.AddListener(() => BuyProduct(index));
			}
		}

		public void BuyProduct(int id) {
			_inventoryPanel.CreateCell(id);
		}

		public void Show() => gameObject.SetActive(true);

		public void Hide() => gameObject.SetActive(false);
	}
}