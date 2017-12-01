﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Digit : MonoBehaviour {
	int valorTotalDecimal;
	GameObject manager;

	// Use this for initialization
	void Start () {
		valorTotalDecimal = 0;
		manager = GameObject.FindGameObjectWithTag ("result");
	}
		
	// Update is called once per frame
	void Update () {
		
	}
		
	public void AlterarValor(CardController card) {
		card.FlipCard();
		gameObject.GetComponent<Text> ().text = card.front.ToString();

		// Atualizar resultado final da conversão para decimal
		// de acordo com o valor e posição da carta.
		AtualizarValorDecimalTotal(card.valorDecimalDaCarta * card.sinal);
	}


	// Atualizar valor total
	void AtualizarValorDecimalTotal(int valorAdicionado) {
		
		// À variável resultadoTotalDecimal do objeto manager (ResultText na cena),
		// adicionar o valor atualizado da carta (que pode ser negativo ou positivo),
		// utilizando o script GameManager -> Component do ResultText.
		manager.GetComponent<GameManager>().resultadoTotalDecimal += valorAdicionado;
		//manager.GetComponent<Text> ().text = (card.valorDecimalDaCarta * card.sinal).ToString();
		manager.GetComponent<Text> ().text = manager.GetComponent<GameManager>().resultadoTotalDecimal.ToString();
	}
}