using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potencia : MonoBehaviour {

	int potenciaCounter;

	// Use this for initialization
	void Start () {
		potenciaCounter = -1;
		ApplicationModel.resultado = 15;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TrocarPotencia(int referencia) {
		potenciaCounter++;
		if (potenciaCounter == referencia) { // resposta certa
			ApplicationModel.resultadoCertoNivel1 = true;
		} else {
			ApplicationModel.resultadoCertoNivel1 = false;
		}

		// Atualizar texto da potência
		gameObject.GetComponent<Text> ().text = potenciaCounter.ToString();

		if (potenciaCounter == 9) {
			gameObject.GetComponent<Text> ().text = potenciaCounter.ToString();
			potenciaCounter = -1;
		}
	}
}
