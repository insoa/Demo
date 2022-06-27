using Units;

namespace Interfaces {
	public interface IUnitBaseFunction { 
		void GetUnitData();
		void FindEnemyTarget(UnitBehaviour target);
		void MoveToTarget(UnitBehaviour target);
		void Attack(float damage);
		void Death();
	}
}