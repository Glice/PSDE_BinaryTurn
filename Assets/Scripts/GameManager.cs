using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int resultadoTotalDecimal = 0;
	public DateTime tempoInicial;
	public int tempoNivelSegundos = 60;


	// Use this for initialization
	void Start () {
		//PARA FAZER
		//pegar tempo do sistema em segundos
		// tempoInicial = ...
		//textoTempo.text = "0";
	}


	public void VerificarRespostaNivel1() {
		if (ApplicationModel.resultadoCertoNivel1) {
			Debug.Log ("Resposta certa!");
			SceneManager.LoadScene ("Answer1");
		} else {
			Debug.Log ("Resposta errada!");
			SceneManager.LoadScene ("Answer2");
		}
	}

	public void VerificarResposta() {
		Debug.Log ("Resposta certa: " + resultadoTotalDecimal.ToString());

		// ATUALIZAR - Condição somente para teste
		if (15 == ApplicationModel.resultado) {
			SceneManager.LoadScene ("Answer1_N2");
		} else {
			SceneManager.LoadScene ("Answer2_N2");
		}
	}

	// Update is called once per frame
	void Update () {
		//PARA FAZER
		//verificar se passaram 60 segundos (tempoNivelSegundos)
		//se sim
		//chamar cena de tempo esogotado: (descomentar próxima linha)
			//SceneManager.LoadScene ("TimeOver");
	}
}