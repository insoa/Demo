using Enums;
using UnityEngine;

namespace UI.InventoryPanel.Interfaces {
	public interface IInventory {
		void CreateCell(int id);
		void DeleteCell(EUnitType type);
	}
}