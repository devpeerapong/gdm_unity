using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;
	public float speed = 10f;
	public Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
	}
	
	// The fixed update run with physics. It fires every physics update.
	void FixedUpdate () {
		rb2D.velocity = Input.GetKey (moveUp) ? new Vector2 (0, speed) : (Input.GetKey (moveDown) ? new Vector2 (0, speed * -1) : new Vector2 (0, 0));
	}
}
