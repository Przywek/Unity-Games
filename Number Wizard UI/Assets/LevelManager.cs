using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string Name){	
		Debug.Log ("level lead requested for " + Name);
		Application.LoadLevel(Name);
		}
	public void Quit(string Name){	
		Debug.Log ("level lead requested for " + Name);
		
	}
	public void LoadLevel_1(string Name){	
		Debug.Log ("level lead requested for " + Name);
		Application.LoadLevel(Name);
	}
}
