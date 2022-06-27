using System;
using System.Collections.Generic;
using UI.InventoryPanel.Behaviours;
using UnityEngine;

namespace Databases {
	[CreateAssetMenu(fileName = "InventoryDatabase", menuName = "ScriptableObjects/InventoryDatabase", order = 2)]
	
	[Serializable]
	public sealed class InventoryDatabase : ScriptableObject {
		public List<InventoryCellBehaviour> UnitsInInventory = new List<InventoryCellBehaviour>();
	}
}
