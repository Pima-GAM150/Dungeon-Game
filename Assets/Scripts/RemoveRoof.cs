using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRoof : MonoBehaviour {

	public GameObject roof;
	public static bool disabled = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (disabled)
		{
			roof.SetActive(false);
		}
		else
		{
			roof.SetActive(true);

		}
	}
}
