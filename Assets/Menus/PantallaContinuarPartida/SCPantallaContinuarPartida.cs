using UnityEngine;
using System.Collections;

public class SCPantallaContinuarPartida : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
}
