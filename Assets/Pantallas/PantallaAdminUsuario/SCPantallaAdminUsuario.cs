using UnityEngine;
using System.Collections;

public class SCPantallaAdminUsuario : MonoBehaviour {
	
	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}
	
}
