using UnityEngine;
using System.Collections;

public class SCPantallaLogo : MonoBehaviour {

	public AudioClip musicfondo;

	 void Start(){
		AudioSource musica = GetComponent<AudioSource>();
		musica.Play();

	}
	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);

	}
	public void Awake(){
		DontDestroyOnLoad(gameObject);
	}
}
