using System;
using System.Collections.Generic;
using Databases;
using Enums;
using Interfaces;
using UI.Interfaces;
using UI.InventoryPanel.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace UI.InventoryPanel.Behaviours {
	public sealed class InventoryPanelBehaviour : MonoBehaviour, IUiPanel, IInventory {
		
		[Inject] private readonly UnitDatabase _unitDatabase;

		[SerializeField] private InventoryCellBehaviour _cellPrefab;
		[SerializeField] private Transform _contentParent;
		[SerializeField] private List<InventoryCellBehaviour> _inventoryCellBehaviours = new List<InventoryCellBehaviour>();
		
		public Button CloseButton;

		public void CreateCell(int id) {
			var cell = Instantiate(_cellPrefab, _contentParent);
			foreach (var unit in _unitDatabase.Units) {
				if (id != unit.Id)
					continue;
				cell.ButtonType = unit.Type;
				cell.UnitImage.sprite = unit.UnitIcon;
				_inventoryCellBehaviours.Add(cell);
			}
		}
		
		public void DeleteCell(EUnitType type) {
			foreach (var cell in _inventoryCellBehaviours) {
				if (cell.ButtonType == type)
					Destroy(cell.gameObject);
			}
		}
		
		public void Show() => gameObject.SetActive(true);
		
		public void Hide() => gameObject.SetActive(false);
	}
}