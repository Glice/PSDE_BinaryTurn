using System;

public class ApplicationModel {
	// Guardar resposta final
	static public int resultado = 0;
	static public bool resultadoCertoNivel1 = false;
	static public int[] resultadoCerto = {0,0,0,0};

	static public int resultadoNivel2 = 15;
	static public int[] resultadosNivel2= {1,2,4,8};
	static public int[] resultados = {0,0,0,0};


	public ApplicationModel () {
		ApplicationModel.resultadosNivel2 [0] = 1;
		ApplicationModel.resultadosNivel2 [1] = 2;
		ApplicationModel.resultadosNivel2 [2] = 4;
		ApplicationModel.resultadosNivel2 [3] = 8;
	}

}

