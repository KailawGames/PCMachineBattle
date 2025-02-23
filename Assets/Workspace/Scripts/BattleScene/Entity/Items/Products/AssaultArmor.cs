using System;
using UnityEngine;


public class AssaultArmor : MonoBehaviour, IProduct {
	// TODO Scriptable Object����f�[�^�����������Ă���
	[SerializeField] private string productName = "AssaultArmor";

	public event Action<IProduct> OnTaken;

	public string ProductName {
		get { return productName; }
		set { productName = value; }
	}

	public void Initialize() {
		gameObject.name = productName;
		// effect����
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