using Databases;

namespace UI.ShopPanel.Interfaces {
	public interface IShop {
		void CreateCell(Unit unit);
		void Subscribe(Unit unit);
		void OnProductClick(int index, Unit unit);
		void BuyProduct(int id);
	}
}