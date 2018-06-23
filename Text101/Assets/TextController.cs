using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States{Cell, Sheets, Mirror, Wall, Injury, Yell, Dead, Force, Combat, Corridor_0, Elevator,
	Code, Stairs, Forward, Force_1, Corridor_1, Corridor_2, Closet_Room, Captain_Bay, Force_2, Shoot, Lightspeed};
	private States myState; 
	public bool weapon = false; 
	void Start () {
		myState = States.Cell ; 
	}
	
	// Update is called once per frame
	void Update () {
		print (myState); 
		if 		  (myState == States.Cell) {
		cell();
		}else if (myState == States.Sheets){
		sheets (); 
		}else if (myState == States.Mirror){
			mirror (); 
		}else if (myState == States.Wall){
			wall (); 
		}else if (myState == States.Injury){
			injury (); 
		}else if (myState == States.Yell){
			yell (); 
		}else if (myState == States.Dead){
			dead (); 
		}else if (myState == States.Force){
			force (); 
		}else if (myState == States.Combat){
			combat (); 
		}else if (myState == States.Corridor_0){
			corridor_0 (); 
		}else if (myState == States.Elevator){
			elevator (); 
		}else if (myState == States.Forward){
			forward (); 
		}else if (myState == States.Stairs){
			stairs (); 
		}else if (myState == States.Code){
			code (); 
		}else if (myState == States.Force_1){
			force_1 (); 
		}else if (myState == States.Corridor_1){
			corridor_1 (); 
		}else if (myState == States.Corridor_2){
			corridor_2 (); 
		}else if (myState == States.Closet_Room){
			closet_room (); 
		}else if (myState == States.Captain_Bay){
			captain_bay (); 
		}else if (myState == States.Force_2){
			force_2 (); 
		}else if (myState == States.Shoot){
			shoot (); 
		}else if (myState == States.Lightspeed){
			lightspeed (); 
		}
	}
	void cell(){
		text.text = "Far away in the galaxy there was a Jedi inprisoned on a spaceship"+
			" Domagos was his name. Help him to return to Coruscant." +
				" Were he can tell all about darth sidius plans to Jedi Council."+
				" You are locked in a prison cell, and you need to escape."+
				" There is almost nothing around you. Only dirty Sheets, walls" + 
				" and an electromagnetic doors\n\n" +
				"Press S to show Sheets. " +
				"Press W to look up the  walls. " +
				"Press M to look in to the mirror.";  
		if (Input.GetKeyDown(KeyCode.S) ){
		myState = States.Sheets;
			
		}else if (Input.GetKeyDown(KeyCode.W) ){
			myState = States.Wall;
			
		}
		else if (Input.GetKeyDown(KeyCode.M) ){
			myState = States.Mirror;
			
		}
		}
		void sheets(){
			text.text = "It's no time to go to sleep I need to figure somthing out! "+
						"Before they will transport me to Sidius. I need to hurry!\n\n"+
						"press R to Return to roaming your cell.";
			if (Input.GetKeyDown(KeyCode.R)){
			myState = States.Cell;
			}
	}
	void mirror (){
			text.text = "What am I doing ?? Jedi never look themselfs in a mirror "+
						"I need to hurry! But still I'm looking lit as fuck\n\n"+
						"press R to Return to roaming your cell.";
			if (Input.GetKeyDown(KeyCode.R)){
				myState = States.Cell;
			}
		}
	void wall (){
				text.text = "Hmm... I can see the camera in left corner and I "+
							"Remember they need me a life So mabe if i Injur myself they."+ 
							"Will come to aid me \n\n"+
							"press R to Return to roaming your cell. " + 
							"press I to Injur yoursef.";
				if (Input.GetKeyDown(KeyCode.R)){
					myState = States.Cell;
				}
				else if (Input.GetKeyDown(KeyCode.I)){
					myState = States.Injury;
				}
		}
	void injury (){
					text.text = "You take a few steps back and with all your strength "+
								"You bash your head on the wall.\n\n"+
								"press Y to Scream for help " +
								"press D to play Dead. " ;
								
					if (Input.GetKeyDown(KeyCode.Y)){
						myState = States.Yell;
					}else if (Input.GetKeyDown(KeyCode.D)){
						myState = States.Dead;
					}
		}
	void yell (){
						text.text = "You Scream with agony! Your head is exploiding with pain. "+
									"You have never felt that kind of pain. But you can't sense anyone coming."+
									"Mabe if you would just injur yoursef again it would help\n\n"+
									"press I to Injur yoursef";
						if (Input.GetKeyDown(KeyCode.I)){
							myState = States.Injury;
					}	
		}
	void dead (){
		text.text = "You fall on the floor and you start playing Dead. "+
					"You can't concetrate to sense anyone coming, but finally you can hear steps aproching. "+
					"The electromagnetic doors open and Trooper comes in. You have two Choices use the force against him or fight him with your bear hands \n\n"+
					"press F to use The Force. " +
					"press C to Fight him with your bare hands. " ;
		if (Input.GetKeyDown(KeyCode.F)){
			myState = States.Force;
				}	else if (Input.GetKeyDown(KeyCode.C)){
					myState = States.Combat;
				}
	}
	void force (){
		text.text = "You push him on the wall knocking him out now you can go and find the captain "+
					"and restrain him.\n\n"+
					"press G to leave the cell.";
		if (Input.GetKeyDown(KeyCode.G)){
			myState = States.Corridor_0; 
		}	
	}
	void combat (){
			text.text = "When troper leans over you to check if you are alright. You immediately put "+
						"a lever over his head and knock him out. Now you can go and find the Captain and restrain him.\n\n"+
						"press G to leave the cell.";
						if (Input.GetKeyDown(KeyCode.G)){
							myState = States.Corridor_0;
						}
	}
	void corridor_0 (){
		text.text = "Now I don't have any time to waste. Guard's will be here soon "+
					"I need to hurry! Before they will find me.\n\n"+
					"press F to go Forward. press E to go to Elevator";
					if (Input.GetKeyDown(KeyCode.F)){
					myState = States.Forward; 
					}else if (Input.GetKeyDown(KeyCode.E)){
					myState = States.Elevator;
					}
	
	}
	void elevator (){
		text.text = "I enter the elevator and it look's like they cut off the power. "+
					"They must be hiding now in the Captain's Bay. I need to get There quickly!!\n\n"+
					"press R to return ";
					if (Input.GetKeyDown(KeyCode.R)){
					myState = States.Corridor_0;
					}
		
	}
	void forward (){
		text.text = "You Ran Straight a head. You are also regain full consciouusness of the Force. "+
					"You Sense that they are in the Captain's Bay. Intuition tell's you to take the Stairs. \n\n"+
					"press R to return. Press S to take the Stairs. ";
					if(Input.GetKeyDown (KeyCode.R)){
					myState = States.Corridor_0; 
					}else if (Input.GetKeyDown(KeyCode.S)){
					myState = States.Stairs;
					}
		
	}
	void stairs (){
		text.text = "After running up the stairs, You see door's with a magnetic lock on them. "+
			"You can try and hack them or use force to open them.\n\n"+
				"press F to use Force. Press H to Hack. ";
				if (Input.GetKeyDown(KeyCode.H)){
				myState = States.Code;
				}else if ( Input.GetKeyDown (KeyCode.F)){
				myState = States.Force_1;
				}
		
	}
	void code (){
		text.text = "You open the saftey locker which is near to lock. You are trying to attach the wires together "+
			"but you don't know what you are doing it was your master who usually did this thinks."+
			"When you are trying to attach blue with red you get shocked by electricity. It's time to change the tactic's \n\n"+
				"press R to Return ";
				if (Input.GetKeyDown(KeyCode.R)){	
					myState = States.Stairs;
					}
		
	}
	void force_1 (){
		text.text = "U use Force to pick this magentic lock and it's open's. "+
			"Now quickly to The Captain's Bay\n\n"+
				"press F to go forward down the corridor";
			if (Input.GetKeyDown(KeyCode.F)){	
				myState = States.Corridor_1;
			}
	}
	void corridor_1 (){
		text.text = "Now I don't have any time to waste. We just have left from Lightspeed."+
			"I need to hurry! To the Captain's Bay\n\n"+
				"Press L to continue with Corridor. press B to walk in to Captain's Bay.  "+
				"Press C to check locker room (THERE MAY BE LOOT)";
			if (Input.GetKeyDown(KeyCode.L)){	
				myState = States.Corridor_2;
			}else if (Input.GetKeyDown(KeyCode.C)){	
				myState = States.Closet_Room;
			}else if (Input.GetKeyDown(KeyCode.B)){	
				myState = States.Captain_Bay;
			}
	}
	void corridor_2 (){
		text.text = "Shit a dead end! I need to get back! Damm it! Oh wait a vent i think i can fit in it  "+
			"You come near the vent. You can hear the Captain yelling at his crew.\n\n"+
				"press R to Return. Press B to walk in to Captain's bay. ";
			if (Input.GetKeyDown(KeyCode.R)){	
				myState = States.Corridor_1;
			}else if (Input.GetKeyDown(KeyCode.B)){	
			myState = States.Captain_Bay;
			}
		
	}
	void closet_room (){ 
		text.text = "Hmm... What do we have hear! A Blaster! This can come in handy. "+
			"Ok now we are ready for Captain's Bay! :)\n\n"+
					"press R to Return. ";
			if (Input.GetKeyDown(KeyCode.R)){	
				myState = States.Corridor_1;
				weapon = true; 
			}
	}
	void captain_bay (){
		text.text = "When you enter the Captain's bay you spot five guards and a captain. "+
			"Use the force to knock them out!\n\n"+
				"press F to use Force ";
			if (Input.GetKeyDown(KeyCode.F)){	
				myState = States.Force_2;
			}else if( weapon == true){
			text.text = "When you enter the Captain's bay you spot five guards and a captain. "+
				"What do you do? Use the force to knock them out or kill them with a Blaster?\n\n"+
						"press F to Force. Press S to Shoot ";
			if (Input.GetKeyDown(KeyCode.S)){
			myState=States.Shoot;
				}else if (Input.GetKeyDown(KeyCode.F)){	
					myState = States.Force_2;
			}
	}
	}
	void force_2 (){
		text.text = "You knock out all the enamies in the room. You can see a Imperial Ship Coming your way."+
			"You quickly grab the stick and rotate your ship by 90 degree. Quickly jump to Lightspeed!\n\n"+
				"press L to Lightspeed! ";
			if (Input.GetKeyDown(KeyCode.L)){	
				myState = States.Lightspeed;
			}
	}
	void shoot (){
		text.text = "Now I don't have any time to waste. Guard's will be here soon "+
			"I need to hurry! Before they will find me.\n\n"+
					"press L to Lightspeed!  ";
			if (Input.GetKeyDown(KeyCode.L)){	
				myState = States.Lightspeed;
			}
	}
	void lightspeed (){
		text.text = "You just single handly took out the whole crew and run away an Imperial Starship. "+
			"Congratulation's on succesfouly compliting the mission.\n\n"+
				"press Enter to play again ";
			if (Input.GetKeyDown(KeyCode.Return)){	
				myState = States.Cell;
				weapon = false;
			}
	}
	}

