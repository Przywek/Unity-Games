using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour { 
	static MusicPlayer instance = null ; 
	void Awake(){
		Debug.Log("muisc player awake" + GetInstanceID());
		if (instance !=null){
			Destroy(gameObject);
			print("Duplicate music destroy");
		} else {
			instance = this; 
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	void Start (){
		Debug.Log("muisc player start" + GetInstanceID());
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
