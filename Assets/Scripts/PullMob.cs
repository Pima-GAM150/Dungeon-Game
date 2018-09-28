using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullMob : MonoBehaviour {

	public GameObject target;
	public GameObject damageAura;
	
	private bool attackPlayer;
	public Damage damage;
	
	// Use this for initialization
	void Start () {
		attackPlayer = false;
		damage = damageAura.GetComponent<Damage>();
		
	}
	
	void update () 
	{
		if (attackPlayer == true)
		{
			
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, .03f);
		}
	}

	void OnTriggerEnter (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				target = col.gameObject;
				attackPlayer = true;
				
				

			}
	}

	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				target = null;
				attackPlayer = false;
				
			}
	}
}

