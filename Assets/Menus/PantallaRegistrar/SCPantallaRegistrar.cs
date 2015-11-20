using UnityEngine;
using System.Collections;

public class SCPantallaRegistrar : MonoBehaviour {
	
	public void CambiarEscena(string nuevaEscena)
	{
		Application.LoadLevel(nuevaEscena);
	}
	public void Awake(){
		DontDestroyOnLoad (transform.gameObject);
	}

}
