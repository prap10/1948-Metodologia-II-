using UnityEngine;
using System.Collections;

public class SCPantallaCrearPartida : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
}
