using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour {
    public Image healthBar;
    public float damageTaken;



    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void takeDMG(float healthLeftPercent)
    {
        healthBar.fillAmount = healthLeftPercent;
    }
}
