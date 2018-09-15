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
	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.z > 0)
				{
					roof.SetActive(true);
				}
				else 
				{
					roof.SetActive(false);
				}
			}
	}		
			
		



	}
