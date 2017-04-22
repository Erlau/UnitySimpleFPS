using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public GameObject bulletPrefab;

	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log("Pressed left click.");

			GameObject g = (GameObject)Instantiate (bulletPrefab, transform.position, transform.parent.rotation);
			float force = g.GetComponent<bullet> ().speed;
			g.GetComponent<Rigidbody> ().AddForce (g.transform.forward * force);
		}
	}
}