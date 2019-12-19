﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string NewGameScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewGame()
	{
		print (NewGameScene);
		SceneManager.LoadScene(NewGameScene);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}