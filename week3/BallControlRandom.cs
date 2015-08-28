using UnityEngine;
using System.Collections;

public class BallControlRandom : MonoBehaviour {
	
	public float forceX = 40f;
	public float forceY = -5f;
	
	// Use this for initialization
	void Start () {
		int rNum = Random.Range (1, 5);

		switch (rNum) {
			case 1: 
				forceX = 40f;
				forceY = -5f;
				break;
			case 2:
				forceX = 40f;
				forceY = 5f;
				break;
			case 3:
				forceX = -40f;
				forceY = -5f;
				break;
			case 4:
				forceX = -40f;
				forceY = 5f;
				break;
			default:
				break;
		}

		forceX = forceX * rNum;
		forceY = forceY * rNum;

		Vector2 force = new Vector2 (forceX, forceY);
		GetComponent<Rigidbody2D> ().AddForce (force);
	}
}
