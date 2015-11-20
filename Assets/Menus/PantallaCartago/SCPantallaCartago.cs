using UnityEngine;
using System.Collections;

public class SCPantallaCartago : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
}
