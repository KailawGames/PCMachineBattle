using System;
using UnityEngine;


public class AssaultArmor : MonoBehaviour, IProduct {
	// TODO Scriptable ObjectÇ©ÇÁÉfÅ[É^Çà¯Ç¡í£Ç¡ÇƒÇ≠ÇÈ
	[SerializeField] private string productName = "AssaultArmor";

	public event Action<IProduct> OnTaken;

	public string ProductName {
		get { return productName; }
		set { productName = value; }
	}

	public void Initialize() {
		gameObject.name = productName;
		// effectê∂ê¨
	}

	public void OnUsed() {

	}

	public void SetPosition(Vector3 position) {
		gameObject.transform.position = position;
	}

	public void SetActive(bool active) {
		gameObject.SetActive(active);
	}
}