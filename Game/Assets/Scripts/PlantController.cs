using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour {

	public GameController gameController;

	void OnTriggerEnter(Collider other) {
		gameController.Inventory.Add(this.gameObject.tag);
		this.gameObject.SetActive(false);
		gameController.CheckFinish();
	}
}
