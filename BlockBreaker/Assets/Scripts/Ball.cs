using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle; 
	private bool hasstarted = false; 
	private Vector3 padlleToBallVector;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		padlleToBallVector = this.transform.position - paddle.transform.position;
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasstarted){
		
	
			this.transform.position = paddle.transform.position + padlleToBallVector; 
			if (Input.GetMouseButton(0)){
				Debug.Log("pressed left click");
				this.rigidbody2D.velocity = new Vector2 (5f,15f);
				hasstarted = true; 
			}
		}
	}
	void OnCollisionEnter2D(Collision2D coll){
		Vector2 tweak = new Vector2 (Random.Range (0f,0.2f), Random.Range(0f, 0.2f));
	
		if (hasstarted && coll.gameObject.tag != "Breakable"){
			audio.Play();
			rigidbody2D.velocity += tweak;
		}
		
	}
}
