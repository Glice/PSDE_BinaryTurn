﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenHomeScene() {
		SceneManager.LoadScene ("Home");
	}

	public void OpenLearnScene() {
		SceneManager.LoadScene ("Learn");
	}

	public void OpenPracticeScene() {
		SceneManager.LoadScene ("Practice");
	}

	public void OpenPlayScene() {
		SceneManager.LoadScene ("Level1");
	}

	public void OpenLevel2Scene() {
		SceneManager.LoadScene ("Level2");
	}

	public void OpenEsquemaScene() {
		SceneManager.LoadScene ("Esquema");
	}
}
