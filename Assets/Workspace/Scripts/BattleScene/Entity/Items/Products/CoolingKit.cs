using System;
using UnityEngine;


public class CoolingKit : MonoBehaviour, IProduct {
	// TODO Scriptable Objectからデータを引っ張ってくる
	[SerializeField] private string productName = "CoolingKit";

	public event Action<IProduct> OnTaken;

	public string ProductName {
		get { return productName; }
		set { productName = value; }
	}

	public void Initialize() {
		gameObject.name = productName;
		// effect生成
	}

	public void SetPosition(Vector3 position) {
		gameObject.transform.position = position;
	}

	public void SetActive(bool active) {
		gameObject.SetActive(active);
	}
}