using UnityEngine;
using System.Collections;


public class LevelManager : MonoBehaviour {
	public string Name;
	
	
	public void LoadLevel(string Name){
		Debug.Log ("level lead requested for " + Name);
		Application.LoadLevel(Name);
		Brick.breakableCount = 0; 
		}
	public void Quit(string Name){	
		Debug.Log ("level lead requested for " + Name);
		
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1 );
		Brick.breakableCount = 0; 
	}
	public void BrickDestroyed(){
		
		if(Brick.breakableCount <=0){
			LoadNextLevel();
		}
	}
}
