using UnityEngine;
using System.Collections;

public class Logo : MonoBehaviour {

		public static AudioSource musicfondo;
	public static int puntos =0;
		void Start(){
			musicfondo = GetComponent<AudioSource>();
				
			musicfondo.Play ();
			
		}
		public void CambiarEscena(string escena){
			Application.LoadLevel (escena);
			
		}
		public void Awake(){
			DontDestroyOnLoad(gameObject);
		}
	}
