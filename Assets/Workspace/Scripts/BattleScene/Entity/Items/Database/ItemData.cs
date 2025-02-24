using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObject/Data/ItemData")]
public class ItemData : Data
{
	enum EffectTiming {
		AnyTime,
		Immediate,
	}

	[SerializeField]
	private float effectValue;
    [SerializeField] 
	private float effectDuration;
	[SerializeField]
	private EffectTiming effectTiming;
	[SerializeField]
	private GameObject effectWhenGet;
	[SerializeField]
	private AudioClip SEWhenGet;
	[SerializeField]
	private GameObject effectWhenUse;
	[SerializeField]
	private AudioClip SEWhenUse;
}
