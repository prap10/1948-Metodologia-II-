using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SCPantallaAlajuela : MonoBehaviour {

	public void CambiarEscena(string escena){
		Destroy (Logo.musicfondo);
		Application.LoadLevel (escena);
	}

}
