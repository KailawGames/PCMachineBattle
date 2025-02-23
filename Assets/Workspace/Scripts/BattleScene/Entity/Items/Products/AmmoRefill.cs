using System;
using UnityEngine;


public class AmmoRefill : MonoBehaviour, IProduct {
	// TODO Scriptable Object����f�[�^�����������Ă���
	[SerializeField] private string productName = "AmmoRefill";

	public event Action<IProduct> OnTaken;

	public string ProductName {
		get { return productName; }
	}

	public void Initialize() {
		gameObject.name = productName;
		// effect����
	}

	public void SetPosition(Vector3 position) {
		gameObject.transform.position = position;
	}

	public void SetActive(bool active) {
		gameObject.SetActive(active);
	}
}