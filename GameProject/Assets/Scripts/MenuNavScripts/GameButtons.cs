﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameButtons : MonoBehaviour {
	public Camera helpCamera;
	public AnalyticsByLevel levelAnalytics;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void PauseGame(){
		Time.timeScale = 0.0f;
	}

	public void ResumeGame(){
		Time.timeScale = 1.0f;
	}

	public void ClearWordDisplay() {
		GameObject.FindGameObjectWithTag ("JITDisplay").GetComponent<Text> ().text = "";

		ResumeGame ();
	}
	public void Menu(){
		SceneManager.LoadScene ("Menu");
	}
	public void GoToIntroduction(){
		SceneManager.LoadScene ("Introduction");
	}
	public void GoToInstructions(){
		SceneManager.LoadScene ("Instructions");
	}
	public void StartGame(){
		SceneManager.LoadScene ("HubLevel");
	}
	public void ReturnToTitle(){
		
		SceneManager.LoadScene ("STARTUP");
		Time.timeScale = 1.0f;
	}
	public void QuitGame(){
		Application.Quit ();
	}

	public void ReturnToPrevScene(){
		GlobalController.Instance.changeScene (GlobalController.Instance.previousSceneName);
	}

	public void helpScreenToggle(){
		Camera arrCam = GameObject.Find ("AssistCamera").GetComponent<Camera> ();
		GlobalController.Instance.changeSecondCamera (arrCam);
		GlobalController.Instance.toggleCamera ();
		if (GlobalController.Instance.camName != "AssistCamera") {
			levelAnalytics.noteButtonCounter++;
			levelAnalytics.NotesAnalytics ();
		}

	}

	public void helpToggleOff(){
		GlobalController.Instance.toggleCamera ();
	}
}
