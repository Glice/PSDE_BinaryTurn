using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Resposta : MonoBehaviour {

	//GameObject manager;
	public Text textoResposta;

	// Use this for initialization
	void Start () {
		//manager = GameObject.FindGameObjectWithTag ("result");
		//textoResposta.text = gameObject.GetComponent<Text>();
		textoResposta.text = ApplicationModel.resultado.ToString();
		//manager.GetComponent<GameManager> ().resultadoTotalDecimal.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		//textoResposta.text = manager.GetComponent<GameManager> ().resultadoTotalDecimal.ToString ();
	}

}
