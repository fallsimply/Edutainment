using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	[SerializeField]
	private string GameScene;
	[SerializeField]
	private string MenuScene;
	[SerializeField]
	private string SortScene;
	[SerializeField]
	private string ControlsScene;
	[SerializeField]
	private string WinScene;

	public void Quit() {
		Application.Quit();
	}

	public void Play() {
		SceneManager.LoadScene(GameScene);
	}

	public void Sort() {
		SceneManager.LoadScene(SortScene);
	}

	public void Controls() {
		SceneManager.LoadScene(ControlsScene, LoadSceneMode.Additive);
	}

	public void Win() {
		SceneManager.LoadScene(WinScene, LoadSceneMode.Additive);
	}

	public void MainMenu() {
		SceneManager.LoadScene(MenuScene);
	}
}
