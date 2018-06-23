using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private float minx;
	private float maxx;
	private float padding = 0.5f;
	public float miny;
	public float maxy;
	public float speed;
	// Use this for initialization
	void Start () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0 , 0 , distance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1 , 0 , distance));
		minx = leftmost.x + padding;
		maxx = rightmost.x	- padding;
	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
	
	void Move(){ 
	if (Input.GetKey(KeyCode.RightArrow)){	
		transform.position += Vector3.right * speed * Time.deltaTime;
	}else if (Input.GetKey(KeyCode.LeftArrow)){
		transform.position += Vector3.left * speed * Time.deltaTime;	
	}
	float newX = Mathf.Clamp(transform.position.x, minx, maxx);
	transform.position = new Vector3(newX, transform.position.y,transform.position.z);
	
	}
}
