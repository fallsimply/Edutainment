using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameControlScript : MonoBehaviour {

	//The amount of ellapsed time
	private float time = 0;

	//Flags that control the state of the game
	private bool isRunning = false;
	private bool isFinished = false;

	//place holders for the player and the spawn point
	public Transform spawnPoint;
	public GameObject player;

	[Header("Inventory")]
	public string[] stages = {
		"Seed", "Seedling", "Plant", "Flower", "Fruit"
	};
	public List<string> Inventory = new List<string>();

	[Header("UI")]
	public Text message;


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
		// if (isRunning) {
		// 	time += Time.deltaTime;
		// }
	}

	public void CheckFinish() {
		List<string> finishedItems = new List<string>(stages);
		List<string> missing = new List<string>();

		foreach (string item in finishedItems) {
			if (!finishedItems.Contains(item))
				missing.Add(item);
		}
		Debug.Log($"Missing: {missing.Count} items, {string.Join(",", missing)}");
		if (missing.Count == 0)
			FinishedGame();

	}

	//This runs when the player enters the finish zone
	public void FinishedGame() {
		isRunning = false;
		isFinished = true;
		message.text = $"Completed in {((int)time).ToString()} seconds.";
		Debug.Log("Game Completed");

	}

	//This section creates the Graphical User Interface (GUI)
	void OnGUI() {
		//If the game is running, show the current time
		// if (isRunning) {
		// 	message.text = $"Time: {((int)time).ToString()} seconds.";
		// }
		message.text = $"Inventory: {string.Join(", ", Inventory)}";
	}
}
