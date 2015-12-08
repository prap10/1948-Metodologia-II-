using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CambioDeEscena : MonoBehaviour {

	public float tiempo;
	public Text tiempoTexto;
	public string escenaC;
	public Text puntaje;
	public void CambiarEscena(string escena){
	Logo.puntos += 10;
		Application.LoadLevel (escena);
	}

	public void ErrorRespuesta(){
		Logo.puntos -= 5;
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
		puntaje.text = Logo.puntos.ToString();
		if (tiempo <= 0) {
			Logo.puntos -= 5;
			Application.LoadLevel (escenaC);
		} else {
			tiempoTexto.text = tiempo.ToString("f0");
			tiempo -= Time.deltaTime;
		}
			
	}
}
