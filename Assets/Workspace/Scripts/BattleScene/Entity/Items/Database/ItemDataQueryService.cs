using UnityEditor;
using UnityEngine;

namespace Other.Infrastructure {
	public class ItemDataQueryService : QueryService<ItemDataBase, ItemData> {
		private const string DATABASE_NAME = "ItemDataBase";
		private ItemDataBase _database;

		public ItemDataQueryService() { }

		public override ItemData FetchByName(string name) {
			if (_database == null) {
				_database = LoadDatabase(DATABASE_NAME);
			}
			
			return _database.ItemList.Find(e => e.EntityName == name);
		}
	}
}
