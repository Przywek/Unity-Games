using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemyPrefab;
	public float width = 10f;
	public float height = 5f;  
	private float padding = 0.5f;
	private bool movingRight = true;
	public float speed;
	private float minx;
	private float maxx;
	
	// Use this for initialization
	void Start () {
		float distanceToCamera = transform.position.z - Camera.main.transform.position.z; 
		Vector3 leftedge = Camera.main.ViewportToWorldPoint(new Vector3(0,0, distanceToCamera));
		Vector3 rightedge = Camera.main.ViewportToWorldPoint(new Vector3(1,0, distanceToCamera));	
		minx = leftedge.x;
		maxx = rightedge.x;
		foreach( Transform child in transform){
			GameObject enemy = Instantiate(enemyPrefab, child.transform.position, Quaternion.identity)as GameObject;
			enemy.transform.parent = child;
			
		}
	}
	public void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position,new Vector3(width,height));
		
		}
	
	// Update is called once per frame
	void Update () {
		if(movingRight){
			transform.position += Vector3.right * speed*Time.deltaTime;
		}else{
			transform.position += Vector3.left * speed*Time.deltaTime;
		}
		float leftEdgeOfFarmation = transform.position.x - (0.5f*width);
		float rightEdgeOfFarmation = transform.position.x + (0.5f*width);
		if(leftEdgeOfFarmation < minx || rightEdgeOfFarmation > maxx){
			movingRight=!movingRight;
		}
	}
}

