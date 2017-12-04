using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Time : MonoBehaviour {
	
	public int resultadoTotalDecimal = 0;
	public DateTime tempoInicial;
	public int tempoNivelSegundos = 60;
	public Text textoTempo;

	// Use this for initialization
	void Start () {
		// Atualizar Text do tempo restante
		textoTempo.text = tempoNivelSegundos.ToString();

		//PARA FAZER
		//RECADO PARA HERICK S2 HAHA
		//pegar tempo do sistema em segundos
		//tempoInicial = ...

	}



	// Update is called once per frame
	void Update () {
		
		//PARA FAZER
		//RECADO PARA HERICK
		// Atualizar Text do tempo restante
		//textoTempo.text = ...

		//verificar se passaram 60 segundos (tempoNivelSegundos)
		//se sim
		//chamar cena de tempo esogotado: (descomentar próxima linha)
		//SceneManager.LoadScene ("TimeOver");
	}
}