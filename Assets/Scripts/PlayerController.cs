using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{

	public Interactable focus;
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
				RemoveFocus();

			}
		}
		if (Input.GetMouseButtonDown(1))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit, 100))
			{
				Interactable interactable = hit.collider.GetComponent<Interactable>();
				
				if (interactable != null)
				{
					SetFocus(interactable);	
				}
				// If we did set it as our focus
				

			}
		}
	}

	void SetFocus(Interactable newFocus)
	{
		focus = newFocus;
		motor.FollowTarget(newFocus);

	}
	void RemoveFocus() 
	{
		focus = null;
		motor.StopFollowingTarget();
	}

	
}
