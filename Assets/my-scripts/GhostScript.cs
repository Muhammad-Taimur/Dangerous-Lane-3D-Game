using UnityEngine;
using System.Collections;

public class GhostScript : MonoBehaviour {


	// inputs you can use to better create the AI:
	// speed, play with the distance,
	// play with the score, the higher the score, the faster the ghost speed will be
	// hiding: you can hide the ghost behind objects and make it jump on the main character (surprise)
	// patroling - add waypoints (cubes) - Make the ghost go from one waypoint to another and repeat

	public GameObject mainCharacter;

	public float speed = 10;
	public float regularSpeed = 10;
	public float maxSpeed = 50;


	private bool gameIsPlaying = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (gameIsPlaying == false)
			return;
		if (gameIsPlaying == true){
		float distance = Vector3.Distance (mainCharacter.transform.position, this.transform.position);
		if (distance < 10) {
			speed = regularSpeed;
		} else {
			speed = maxSpeed;
		}
		transform.position = Vector3.MoveTowards (transform.position, mainCharacter.transform.position, speed * Time.fixedDeltaTime);
		transform.LookAt (mainCharacter.transform.position);
	}
	}


	public void GameHasStarted(){
		gameIsPlaying = true;
	}
}
