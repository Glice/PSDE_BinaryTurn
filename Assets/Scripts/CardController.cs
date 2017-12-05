using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour {
	
	public int front = 0;
	public int sinal;
	public int valorDecimalDaCarta;
	public int valorDecimalTotal;

	// Sprites (frente e verso) para atribuir à imagem clicada
	Image myImageComponent;
	public Sprite myCardFront;
	public Sprite myCardBack;

	// Use this for initialization
	void Start () {

		// Criar evento para aguardar clique do botão (carta)
		Button btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);

		// <Image> para auxiliar troca de sprites (variável recebe a própria imagem do componente para depois ser alterada no click)
		myImageComponent = GetComponent<Image>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Se é a frente ou não da carta, troca o sprite da respectiva imagem
	void TaskOnClick() {
		/*
		//restaurar?
		/*gameObject.GetComponent<GameManager> ().AlterarValorDigito (front);*/

	}

	// Se é a frente ou não da carta, troca o sprite da respectiva imagem
	public void FlipCard() {
		Debug.Log ("Virou carta");
		if (front == 1) {
			front = 0;
			sinal = -1;
			Debug.Log ("Showing back");
			gameObject.GetComponent<Image> ().sprite = myCardBack;
		} else {
			front = 1;
			sinal = 1;
			Debug.Log ("Showing front");
			gameObject.GetComponent<Image> ().sprite = myCardFront;
		}
	}
}