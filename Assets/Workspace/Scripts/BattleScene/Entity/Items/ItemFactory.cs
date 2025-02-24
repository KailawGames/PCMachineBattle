using UnityEngine;

public class ItemFactory : Factory
{
	[SerializeField] private GameObject[] itemList;
	private GameObject productParent;
	private const string productParentObjectName = "ItemPool";

	public override IProduct CreateProduct(Vector3 position, string prefabName) {
		IProduct newProduct;

		try {
			var productPrefab = FindItemPrefabByName(prefabName);
			if (productPrefab == null) {
				throw new System.Exception($"存在しないアイテムが指定されました. prefabName: {prefabName}");
			}

			// productParent以下にproductをインスタンス化する
			productParent = FindProductObject();
			if (productParent == null) {
				throw new System.Exception($"存在しないオブジェクトを親オブジェクトとして指定しました. parentObjectName: {productParentObjectName}");
			}

			GameObject instance = Instantiate(productPrefab, position, Quaternion.identity, productParent.transform);
			newProduct = instance.GetComponent<IProduct>();
			newProduct.Initialize();

		} catch(System.Exception e) {
			Debug.LogError($"Error has occurred in ItemFactory.CreateProduct: {e.Message}");
			newProduct = null;
		}

		return newProduct;
	}

	public override string[] GetProductNameList() {
		int itemListSize = itemList.Length;
		string[] ret = new string[itemListSize];

		for (int i = 0; i < itemListSize; i++) {
			ret[i] = itemList[i].name;
		}

		return ret;
	} 

	private GameObject FindItemPrefabByName(string prefabName) {
		GameObject ret = null;

		foreach (var item in itemList) {
			if (item.name == prefabName) {
				ret = item;
				break;
			}
		}

		return ret;
	}
	private GameObject FindProductObject() {
		return GameObject.Find(productParentObjectName);
	}
}
