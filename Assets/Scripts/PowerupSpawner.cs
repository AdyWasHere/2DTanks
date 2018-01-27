using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour {

	public GameObject[] powerUps;
	public Transform[] spawnSpots;

	void Start () {

		SpawnPower ();

	}
	

	void Update () {
	


	}

	void SpawnPower()
	{

		int i,j;
		i = Random.Range (0,3);
		j = Random.Range (0, 3);
		Instantiate (powerUps[i],spawnSpots[j].transform.position,Quaternion.Euler(0,0,0));


	}

}
