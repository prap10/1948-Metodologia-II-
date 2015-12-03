using UnityEngine;
using System.Collections;

public class CambioDeEscena : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
}
