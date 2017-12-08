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

		for (int i = 0; i < 4; i++) {
			ApplicationModel.resultadoCerto [i] = 0;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TrocarPotencia(int referencia) {
		potenciaCounter++;
		//ApplicationModel.resultadoCertoNivel1 = false;
		if (potenciaCounter == referencia) { // resposta certa para aquela carta
			ApplicationModel.resultadoCerto[referencia] = 1;
			ApplicationModel.resultadoCertoNivel1 = true;
			for (int i = 0; i < 4; i++) {
				//Debug.Log ("ResultadoCerto?" + i + ": " + ApplicationModel.resultadoCerto [i]);
				if (ApplicationModel.resultadoCerto[i] != 1) { 
					ApplicationModel.resultadoCertoNivel1 = false;
				}
			}
			Debug.Log ("ResultadoCertoNivel1: " + ApplicationModel.resultadoCertoNivel1);
		} else {
			ApplicationModel.resultadoCerto[referencia] = 0;
			ApplicationModel.resultadoCertoNivel1 = false;
			Debug.Log ("ResultadoCertoNivel1: " + ApplicationModel.resultadoCertoNivel1);
		}

		// Atualizar texto da potência
		gameObject.GetComponent<Text> ().text = potenciaCounter.ToString();

		if (potenciaCounter == 9) {
			potenciaCounter = -1;
		}
	}
}
