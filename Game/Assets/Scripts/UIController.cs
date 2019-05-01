using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	public Object GameScene;

	public void Quit() {
		Application.Quit();
	}

	public void Play() {
		SceneManager.LoadScene(GameScene.name);
	}

	public void Controls() {
		SceneManager.LoadScene("", LoadSceneMode.Additive);
	}
}
