using System;
using UnityEngine;

public interface IProduct {

	public event Action<IProduct> OnTaken;

	public void Initialize();

	public void SetPosition(Vector3 position);
	
	public void SetActive(bool active);

	public string ProductName { get; }
}