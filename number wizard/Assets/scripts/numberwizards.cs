using UnityEngine;
using System.Collections;

public class numberwizards : MonoBehaviour {
	int max;
	int min; 
	int guess; 
	int range; 
	// Use this for initialization
	void Start () {
		
		Startgame (); 
	}	
	void Startgame(){
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Choose a maximum range for your number");
		print ("click 1 for 1000");
		print ("click 2 for 10000");
		print ("click 3 for 100000");
		print ("click 4 for 1000000");
		print ("click 5 for 10000000");		 
		max = range;
		min = 1;  
		guess = Random.Range(min,max); 
		max= max +1 ;
		
	}

	
	void Update () { 	
		
		if (Input.GetKeyDown("1")){
			range = 1000; 
			max = range;
			print ("Your maximum range to choose from is " + range);
		}else if (Input.GetKeyDown("2")){
			range = 10000; 
			max = range;
			print ("Your maximum range to choose from is " + range);
		} else if (Input.GetKeyDown("3")){
			range = 100000; 
			max = range;
			print ("Your maximum range to choose from is " + range);
		}else if (Input.GetKeyDown("4")){
			range = 1000000; 
			max = range;
			print ("Your maximum range to choose from is " + range); 
		}else if (Input.GetKeyDown("5")){
			range = 10000000;
			max = range;
			print ("Your maximum range to choose from is " + range);
		}
		
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess; 
			Nextguess ();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			print ("Down arrow pressed");
			max =  guess;
			Nextguess ();
		} else if (Input.GetKeyDown(KeyCode.A)){
			print("I won!");
			Startgame();
		}
	
		
		if (Input.GetKeyDown(KeyCode.Return)){
			print ("Pick a number in your head, but don't tell me");
			
			print ("The highest number you can pick is " + max);
			print ("The lowest number you can pick is " + min); 
			
			print ("Is the number higher or lower then " + guess + "?");
			print ("Up arrow = higher, Down arrow = lower, Return = equels");
			
			
		}
	}
	
	void Nextguess() {
		guess = ((max + min) /2); 
		print ("Is the number higher or lower then " + guess + "?");
		print ("Up arrow = higher, Down arrow = lower, Return = equels");
	}
}