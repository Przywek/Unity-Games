using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max;
	int min; 
	int guess; 
	public Text text; 
	int MaxGuessesAllowed =10;
	void Start () {
		
		Startgame (); 
	}	
	void Startgame(){	 
		max = 1000;
		min = 1;  
		max= max +1 ;
		guess = Random.Range(min,max);
	}
	public void GuessHigher(){
		min = guess; 
		Nextguess ();
	}
	public void GuessLower(){
		max =  guess;
		Nextguess ();
	}
	void Nextguess() {
		guess = (min+max)/2 ;; 
		text.text = ""+guess; 
		MaxGuessesAllowed = MaxGuessesAllowed -1; 
		if(MaxGuessesAllowed<=0){
			Application.LoadLevel("Lose");
		}
	}
}
