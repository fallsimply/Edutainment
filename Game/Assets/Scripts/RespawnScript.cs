using System.Collections;
using UnityEngine;

public class RespawnScript : MonoBehaviour {

	//Place holder for the spawn point
	public Transform respawnPoint;

	//This fires off when the player enters the water hazard
	void OnTriggerEnter(Collider other) {
		//Moves the player to the spawn point
		other.gameObject.transform.position = respawnPoint.position;
	}
}
