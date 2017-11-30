using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Digit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void AlterarValor(CardController c) {
	
		c.FlipCard();
		gameObject.GetComponent<Text> ().text = c.front.ToString();
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
