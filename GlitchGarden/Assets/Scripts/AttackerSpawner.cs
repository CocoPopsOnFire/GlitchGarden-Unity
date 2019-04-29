using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

	bool spawn = true;
	[SerializeField] float minSpawnTime=1f;
	[SerializeField] float maxSpawnTime=1f;

	[SerializeField] Attacker AttackerPrefab;

	IEnumerator Start () {

		while(spawn){
			yield return new WaitForSeconds(Random.Range(minSpawnTime,maxSpawnTime));
			SpawnAttacker();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnAttacker(){
		Instantiate(AttackerPrefab, transform.position, transform.rotation);
	}
}
