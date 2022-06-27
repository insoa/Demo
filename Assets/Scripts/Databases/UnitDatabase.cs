using System;
using System.Collections.Generic;
using Enums;
using Interfaces;
using UnityEngine;
using Zenject;

namespace Databases {
	[CreateAssetMenu(fileName = "UnitsDatabase", menuName = "ScriptableObjects/UnitsDatabase", order = 1)]
	public sealed class UnitDatabase : ScriptableObjectInstaller, IUnitDatabase {
	
		public List<Unit> Units = new List<Unit>();
		
		public override void InstallBindings() {
			Container.BindInterfacesAndSelfTo<UnitDatabase>().AsSingle().NonLazy();
		}

		public Unit GetUnitFromData(int id) {
			return Units[id];
		}

		public int GetUnitsCount() {
			return Units.Count;
		}
	}

	[Serializable]
	public sealed class Unit {
		public int Id;
		public int Price;
		public int Quantity;
		public EUnitType Type;
		public EUnitClass Class;
		public GameObject Prefab;
		public Sprite UnitIcon;
		public float MoveSpeed;
		public float AttackSpeed;
		public float Damage;
		public float Health;
		public float Armor;
	}

	[Serializable]
	public sealed class SkillsData {
		//SkillsDatabase
		//SkillsDatabase
		//SkillsDatabase
		//SkillsDatabase
		//SkillsDatabase
	}
}