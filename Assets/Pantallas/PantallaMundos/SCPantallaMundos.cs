using UnityEngine;
using System.Collections;

public class SCPantallaMundos : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
}
