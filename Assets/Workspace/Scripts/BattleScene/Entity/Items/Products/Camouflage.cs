using System;
using UnityEngine;


public class Camouflage : MonoBehaviour, IProduct {
	// TODO Scriptable Object‚©‚çƒf[ƒ^‚ğˆø‚Á’£‚Á‚Ä‚­‚é
	[SerializeField] private string productName = "Camouflage";

	public event Action<IProduct> OnTaken;

	public string ProductName {
		get { return productName; }
		set { productName = value; }
	}

	public void Initialize() {
		gameObject.name = productName;
		// effect¶¬
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