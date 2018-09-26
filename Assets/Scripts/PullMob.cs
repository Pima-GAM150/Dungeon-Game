using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullMob : MonoBehaviour {

	public GameObject target;
	
	private bool attackPlayer;

	// Use this for initialization
	void Start () {
		attackPlayer = false;
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
				attackPlayer = true;
				Debug.Log ("I hit");
			}
	}

	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				attackPlayer = false;
				Debug.Log ("I am leaving it alone");
			}
	}
}

