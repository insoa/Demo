using Databases;

namespace Interfaces {
	public interface IUnitDatabase { 
		Unit GetUnitFromData(int id);
		int GetUnitsCount();
	}
}