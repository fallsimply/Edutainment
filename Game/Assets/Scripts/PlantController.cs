using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour {

	public GameControlScript gameController;

	void OnTriggerEnter(Collider other) {
		gameController.Inventory.Add(this.gameObject.tag);
		gameController.CheckFinish();
	}
}
