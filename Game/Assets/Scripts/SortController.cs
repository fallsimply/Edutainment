using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SortController : MonoBehaviour {
	[Header("Inventory")]
	public string[] stages = {
		"Seed", "Seedling", "Plant", "Flower", "Fruit"
	};
	public List<string> Inventory = new List<string>();

	[Header("Controllers")]
	public UIController EventController;

	public void CheckFinish() {
		List<string> finishedItems = new List<string>(stages);
		List<string> missing = new List<string>();

		foreach (string item in finishedItems) {
			if (!Inventory.Contains(item)) {
				missing.Add(item);
			}
		}
		Debug.Log($"Missing: {missing.Count} items, {string.Join(",", missing)}");
		if (missing.Count == 0)
			FinishedSort();

	}

	//This runs when the player enters the finish zone
	public void FinishedSort() {
		Debug.Log("Sort Completed");
		EventController.Win();
	}
}
