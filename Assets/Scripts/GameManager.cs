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
	//public Text myResultText;

	// Use this for initialization
	void Start () {
		//PARA FAZER
		//pegar tempo do sistema em segundos
		// tempoInicial = ...
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