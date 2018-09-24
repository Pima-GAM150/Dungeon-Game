using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	private bool attackPlayer;
	// Use this for initialization
	void Start () {
		attackPlayer = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				attackPlayer = true;
				Debug.Log ("I am hitting this thing!");
			}
	}

	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				attackPlayer = false;
				Debug.Log ("I cant hit this... yet.");
			}
	}
}
