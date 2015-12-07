using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CambioDeEscena : MonoBehaviour {

	public float tiempo;
	public Text tiempoTexto;
	public string escenaC;
	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
	void Start(){
		if (SCPantallaCrearPartida.nivel == 0)
			tiempo = 10;
		else
			if (SCPantallaCrearPartida.nivel == 1)
			tiempo = 5;
		else
			tiempo = 3;
	}
	void Update(){
		if (tiempo <= 0) {
			Application.LoadLevel (escenaC);
		} else {
			tiempoTexto.text = tiempo.ToString("f0");
			tiempo -= Time.deltaTime;
		}
			
	}
}
