using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Time : MonoBehaviour {
	
	public int resultadoTotalDecimal = 0;
	public DateTime tempoInicial;
	public DateTime tempoFinal;
	public double tempoNivelSegundos;
	public Text textoTempo;

	// Use this for initialization
	void Start () {
		// Atualizar Text do tempo restante
		textoTempo.text = tempoNivelSegundos.ToString();

		// Pegar tempo do sistema
		tempoInicial = DateTime.Now;

		// Configurar tempo final do jogo
		tempoNivelSegundos = 15;
		tempoFinal = tempoInicial.AddSeconds(tempoNivelSegundos);
	}



	// Update is called once per frame
	void Update () {
		// Se tempo atual ainda for menor anterior ao final do nível
		if (DateTime.Now < tempoFinal) {
			// Atualizar Text do tempo restante
			textoTempo.text = (tempoFinal - DateTime.Now).Seconds.ToString ();
		} else { // Tempo esgotado
			Debug.Log ("Tempo acabou");
			SceneManager.LoadScene ("TimeOver");
		}
	}
}