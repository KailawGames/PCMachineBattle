using System.Collections.Generic;
using UnityEngine;

public abstract class DataBase<T> : ScriptableObject where T : Data
{
	[SerializeField]
	private List<T> itemList = new List<T>();


	public List<T> ItemList {
		get { return itemList; }
	}
}
