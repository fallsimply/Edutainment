using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControlScript : MonoBehaviour {

	//The amount of ellapsed time
	private float time = 0;

	//Flags that control the state of the game
	private bool isRunning = false;
	private bool isFinished = false;

	//place holders for the player and the spawn point
	public Transform spawnPoint;
	public GameObject player;

	// UI Objects
	public Text message;

	public Text[] Inventory;

	//This resets to game back to the way it started
	public void InitLevel() {
		Debug.Log("Level Init Started");
		time = 0;
		isRunning = true;
		isFinished = false;

		//move the player to the spawn point
		player.transform.position = spawnPoint.position;
	}

	// Update is called once per frame
	void Update() {
		//add time to the clock if the game is running
		if (isRunning)
			time += Time.deltaTime;
	}

	//This runs when the player enters the finish zone
	public void FinishedGame() {
		isRunning = false;
		isFinished = true;
		message.text = $"Completed in {((int)time).ToString()} seconds.";

	}

	//This section creates the Graphical User Interface (GUI)
	void OnGUI() {
		//If the game is running, show the current time
		if (isRunning) {
			message.text = $"Time: {((int)time).ToString()} seconds.";
		}
	}
}
