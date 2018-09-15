using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{


	public LayerMask movementMask;
	public PlayerMotor motor;
	public Camera cam;

	// Use this for initialization
	void Start ()
	{
		
		
		
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100, movementMask))
			{
				//move the player to what we hit
				motor.MoveToPoint(hit.point);

			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100, movementMask))
			{
				// Check if we clicked on an interactable
				// If we did set it as our focus
				

			}
		}
	}

	
}
