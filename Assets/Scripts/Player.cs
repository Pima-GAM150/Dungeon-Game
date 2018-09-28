using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject enemy;
	public EnemyHealth health;
	bool attack;
	public float counter;

	void Start()
	{
		counter = 0f;
		attack = false;

	}
	void Update()
	{
		if (attack == true)
		{
			counter += Time.deltaTime;
			if (counter > 2f)
			{
				health.takeDMG(25f);
				counter = 0f;
			}
		}
	}
	void OnTriggerEnter(Collider col)
	{
		
		if (col.gameObject.name == "Enemy")
			{
				attack = true;
				enemy = col.gameObject;
				health = enemy.GetComponent<EnemyHealth>();
				health.takeDMG( 25f );

			}
			if (col.gameObject.name == "LumberJack")
			{
				attack = true;
				enemy = col.gameObject;
				health = enemy.GetComponent<EnemyHealth>();
				health.takeDMG( 15f );

			}
			if (col.gameObject.name == "VillageHero")
			{
				attack = true;
				enemy = col.gameObject;
				health = enemy.GetComponent<EnemyHealth>();
				health.takeDMG( 10f );

			}
	}
	void OnTriggerExit(Collider col)
	{
		attack = false;
	}
}
