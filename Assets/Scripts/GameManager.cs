using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public int resultadoTotalDecimal = 0;
	public DateTime tempoInicial;
	public int tempoNivelSegundos = 80;
	int[] resultado = {0, 0, 0, 0};
	int[] respostasNivel2 = {0, 0, 0, 0};

	void Start () {
		respostasNivel2 [0] = 1;
		respostasNivel2 [1] = 2;
		respostasNivel2 [2] = 4;
		respostasNivel2 [3] = 8;
	}

	void Update () {
		
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

	public void ContabilizarResposta(int i) {

		if (ApplicationModel.resultadosNivel2[i].ToString() == gameObject.GetComponent<Text>().text) {
			ApplicationModel.resultados [i] = ApplicationModel.resultadosNivel2 [i];
			Debug.Log("Resultado " + i + ": " + ApplicationModel.resultados [i]);
		} else {
			ApplicationModel.resultados [i] = 0;
			Debug.Log("Resultado " + i + ": " + ApplicationModel.resultados [i]);
		}
	}

	public void VerificarResultado() {
		if ((ApplicationModel.resultadoNivel2.ToString() == gameObject.GetComponent<Text>().text) &&
			(ApplicationModel.resultados[0] +ApplicationModel.resultados[1] +ApplicationModel.resultados[2] +ApplicationModel.resultados[3]) == ApplicationModel.resultadoNivel2) {
			SceneManager.LoadScene ("Answer1_N2");
		} else {
			SceneManager.LoadScene ("Answer2_N2");
		}
	}

}