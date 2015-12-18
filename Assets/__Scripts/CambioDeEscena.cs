using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CambioDeEscena : MonoBehaviour {

	public float tiempo;
	public Text tiempoTexto;
	public string escenaC;
	public Text puntaje;

	public void CambiarEscena(string escena) {

		if (escena.Equals ("PantallaCartagoPuertas"))
			SaveData.pasoAlajuela = true;
		if (escena.Equals ("PantallaSanJosePuertas"))
			SaveData.pasoCartago = true;

		SaveData.Puntaje += 10;
		Application.LoadLevel (escena);

	}

	public void ErrorRespuesta(){
		SaveData.Puntaje -= 5;
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

		puntaje.text = SaveData.Puntaje.ToString();
		if (tiempo <= 0) {
			SaveData.Puntaje -= 5;
			Application.LoadLevel (escenaC);
		} else {
			tiempoTexto.text = tiempo.ToString("f0");
			tiempo -= Time.deltaTime;
		}

		if (SaveData.pasoAlajuela && !SaveData.pasoCartago)
			Application.LoadLevel("PantallaCartagoPuertas");
		if (SaveData.pasoAlajuela && SaveData.pasoCartago)
			Application.LoadLevel("PantallaSanJosePuertas");

			
	}
}
