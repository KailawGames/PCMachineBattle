using UnityEngine;

public class EntityManager : MonoBehaviour
{
	private GameObject entityPool;
	private GameObject itemPool;
	private const string entityPoolName = "EntityPool";
	private const string itemPoolName = "ItemPool";

	private void Awake() {
		Debug.Log("EntityManager.Awake is called");
		CreatePools();
	}


	private void CreatePools() {
		entityPool = new GameObject();
		entityPool.name = entityPoolName;

		itemPool = new GameObject();
		itemPool.transform.SetParent(entityPool.transform);
		itemPool.name = itemPoolName;
	}
}
