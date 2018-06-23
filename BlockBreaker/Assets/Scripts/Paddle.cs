﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	private Ball ball;
	public float min, max; 
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!autoPlay){
		move_Mouse();
		}else{
			AutoPlay();
		}
	}
	void AutoPlay(){
		
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, min,max);
		this.transform.position = paddlePos;
		
	}
	void move_Mouse(){
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,0f);
		float mousePosInBlocks = Input.mousePosition.x /Screen.width*16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks,min,max);
		this.transform.position = paddlePos;
	}
	
}