using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	[SerializeField] float projectileSpeed=1f;
	[SerializeField] int damage = 50;

	void Update () {
		transform.Translate(Vector2.right*projectileSpeed*Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("i hit"+other.name);
		var health = other.GetComponent<Health>();
		var attacker = other.GetComponent<Attacker>();

		if(attacker && health){
			health.DealDamage(damage);
			Destroy(gameObject);
		}
	}

}
