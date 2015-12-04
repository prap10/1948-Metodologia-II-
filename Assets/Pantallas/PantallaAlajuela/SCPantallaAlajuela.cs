using UnityEngine;
using System.Collections;

public class SCPantallaAlajuela : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}

}
