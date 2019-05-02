using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
	[SerializeField]
	private Object GameScene;
	[SerializeField]
	private Object MenuScene;
	[SerializeField]
	private Object SortScene;
	[SerializeField]
	private Object ControlsScene;
	[SerializeField]
	private Object WinScene;

	public void Quit() {
		Application.Quit();
	}

	public void Play() {
		SceneManager.LoadScene(GameScene.name);
	}

	public void Sort() {
		SceneManager.LoadScene(SortScene.name);
	}

	public void Controls() {
		SceneManager.LoadScene(ControlsScene.name, LoadSceneMode.Additive);
	}

	public void Win() {
		SceneManager.LoadScene(WinScene.name, LoadSceneMode.Additive);
	}

	public void MainMenu() {
		SceneManager.LoadScene(MenuScene.name);
	}
}
