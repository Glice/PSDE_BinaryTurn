using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

	public int resultado;
	public Text myText;
	public String myString;

	// Use this for initialization
	void Start () {
		

		//myString = GetComponent<CardController> ().front.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Text> ().text = resultado.ToString();
		//gameObject.GetComponent<Text> ().text = myString;
	}

	public void AlterarValorDigito(int digito) {
		
		Debug.Log (digito);
		//myText.text = GetComponent<CardController> ().front.ToString ();
		//Debug.Log (myText.text);
		myString = digito.ToString();
//		myText = gameObject.GetComponent<Text>();
//		myText.text = "2";
	}
	/*
	public void AlterarResultado() {
		Debug.Log ("alterou valor");

		if (GetComponent<CardController> ().front == 1) {
			gameObject.GetComponent<Text> ().text = "1";
		} else {
			gameObject.GetComponent<Text> ().text = "0";
		}

		//GetComponent<Text> ().text = resultado.ToString();
		resultado += GetComponent<CardController> ().front * GetComponent<CardController> ().valor;
		//gameObject.GetComponent<Text> ().text = resultado.ToString();

	}*/
}
