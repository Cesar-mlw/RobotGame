using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	private float hp;
	private int cost;
	private SpecialEffect spEffect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private SpecialEffect SpEffect{
		get{
			return spEffect;
		}
		set{
			spEffect = value;
		}
	}
	public int Cost{
		get{
			return cost;
		}
		set{
			cost = value;
		}
	}
	public float Hp{
		get{
			return hp;
		}
		set{
			hp = value;
		}
	}
}
