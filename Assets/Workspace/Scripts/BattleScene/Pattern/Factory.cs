using UnityEngine;

public abstract class Factory : MonoBehaviour {
	public abstract IProduct CreateProduct(Vector3 position, string prefabName);
	public abstract string[] GetProductNameList();
}
