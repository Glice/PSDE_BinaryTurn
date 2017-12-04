using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Resposta : MonoBehaviour {

	GameObject manager;
	public Text textoResposta;

	// Use this for initialization
	void Start () {
		manager = GameObject.FindGameObjectWithTag ("result");
		//textoResposta.text = gameObject.GetComponent<Text>();
		textoResposta.text = "testando";
		//manager.GetComponent<GameManager> ().resultadoTotalDecimal.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		//textoResposta.text = manager.GetComponent<GameManager> ().resultadoTotalDecimal.ToString ();
	}
}
