using UnityEngine;

public abstract class Data : ScriptableObject
{
    [SerializeField]
    private string entityName;

    public string EntityName {
        get { return entityName; }
    }

    [SerializeField]
    private string id;

    public string Id {
        get { return id; }
    }
}
