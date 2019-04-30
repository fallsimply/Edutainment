using UnityEngine;
using System.Collections;

public class FinishScript : MonoBehaviour {

	//This is a place holder for the script that controls the game
	public GameControlScript gameController;

	//This states that when an object enters the finish zone, let the
	//game control know that the current game has ended
	void OnTriggerEnter(Collider other) {
		gameController.FinishedGame();
	}
}
