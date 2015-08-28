using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public float forceX = 40f;
	public float forceY = -5f;

	// Use this for initialization
	void Start () {
		Vector2 force = new Vector2 (forceX, forceY);
		GetComponent<Rigidbody2D> ().AddForce (force);
	}
}
