using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {
	private LevelManager levelmanager ;
	void OnCollisionEnter2D(Collision2D collision){
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		print ("Collision");
		levelmanager.LoadLevel("Game_Over");
	}
}
