using UnityEngine;
using System.Collections;

public class SCPantallaLogo : MonoBehaviour {

	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
	public void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}
}
