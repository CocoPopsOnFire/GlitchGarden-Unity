﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

	[SerializeField] GameObject defender;

	void OnMouseDown()
	{
		Debug.Log("mouse was clicked");
		SpawnDefender();
	}

	private void SpawnDefender(){
		GameObject newDefender = Instantiate (defender,transform.position, Quaternion.identity) as GameObject;
	}
}
