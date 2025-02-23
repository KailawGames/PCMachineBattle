using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
	// TODO: network用のfactoryと切り替えできるようにする
	[SerializeField] private Factory _factory;
	[SerializeField] private int poolSize = 10;

	private Dictionary<string, Queue<IProduct>> productPoolDict = new Dictionary<string, Queue<IProduct>>();

	private void Start() {
		CreatePool();
	}

	private void CreatePool() {
		Debug.Log("ObjectPool.CreatePool is called.");

		// TODO: scriptable objectを使い、factoryに依存しないようにする
		string[] itemNameList = _factory.GetProductNameList();

		foreach (string itemName in itemNameList) {
			var queue = new Queue<IProduct>();

			for (int i = 0; i < poolSize; i++) {
				var product = _factory.CreateProduct(new Vector3(0, 0, 0), itemName);
				//product.SetActive(false);
				RegisterCallback(product);
				queue.Enqueue(product);
			}

			productPoolDict[itemName] = queue;
		}
	}

	private void RegisterCallback(IProduct product) {
		product.OnTaken += CollectProduct;
	}

	private void CollectProduct(IProduct product) {
		product.SetActive(false);
		productPoolDict[product.ProductName].Enqueue(product);
	}

	public IProduct SpawnProduct(Vector3 position, string productName ) {
		Debug.Log("ObjectPool.SpawnProduct is called.");
		IProduct product;

		try {
			if (!productPoolDict.ContainsKey(productName)) throw new System.Exception($"指定されたproductNameはproductNameDictに存在しません. productName: {productName}");

			var productPool = productPoolDict[productName];

			if (productPool.Count > 0) {
				product = productPool.Dequeue();
				product.SetActive(true);
			} else {
				product = _factory.CreateProduct(position, productName);
				RegisterCallback(product);
			}
			product.SetPosition(position);

		} catch(System.Exception e) {
			Debug.LogError($"Error has occurred in ObjectPool.SpawnProduct: {e.Message}");
			product = null;
		}

		return product;
	}

}
