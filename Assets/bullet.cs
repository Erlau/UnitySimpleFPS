using System.Collections;
using UnityEngine;

public class bullet : MonoBehaviour {
	public float speed = 2000.0f;
	// The fly speed (used by the weapon later)

	public GameObject explosionPrefab;
	// explosion prefab (particles)

	void OnCollisionEnter(Collision c) {
		// find out when it hit something
			
		Instantiate(explosionPrefab, transform.position, Quaternion.identity);
		// show explosion - transform.position because it should be where the bullet is - Quaternion.identity because it should have default rotation.

		Destroy(gameObject);
		// destroy the bullet. Destroy(this) would just destroy the script attached to it, Destroy(gameObject) destroys the whole thing
	}
}