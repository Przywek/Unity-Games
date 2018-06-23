using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites; 
	public static int breakableCount = 0 ;
	public AudioClip crack;
	public GameObject Smoke; 
	private int timesHit;
	private LevelManager levelmanger;
	private bool isBreakable;
	void Start () {
		isBreakable =(this.tag == "Breakable");
		if (isBreakable){
		breakableCount++;
		
		}
		timesHit = 0;
		levelmanger = GameObject.FindObjectOfType<LevelManager>();
	}
	void Update(){
		
	}
	void LoadSprites(){
		int spriteIndex = timesHit - 1; 
		if (hitSprites[spriteIndex]){
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}else{
		Debug.LogError("brick sprite missing");
		}
	}
	void SimulateWin(){
	levelmanger.LoadNextLevel();
	}
	void OnCollisionEnter2D(Collision2D collision){
		AudioSource.PlayClipAtPoint (crack, transform.position);
		if (isBreakable){
		HandleHits();
		}
	}
	void HandleHits(){
		
			timesHit++;	
			int maxHits = hitSprites.Length + 1 ;
			if(maxHits <= timesHit){
				breakableCount--;
				levelmanger.BrickDestroyed();
				puffsmoke();
				Destroy(this.gameObject);
				}
				else {
				LoadSprites();
			}
		}
		void puffsmoke(){
		Vector3 smokePos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0 );
		GameObject smokepuff = Instantiate (Smoke, transform.position, Quaternion.identity)as GameObject;
		smokepuff.particleSystem.renderer.sortingLayerName = "smokeLayer";
		smokepuff.particleSystem.startColor = gameObject.GetComponent<SpriteRenderer>().color;
		Destroy(smokepuff,5f);
	}
	

}

		
		

