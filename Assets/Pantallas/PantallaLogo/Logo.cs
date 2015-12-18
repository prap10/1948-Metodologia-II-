using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Logo : MonoBehaviour {

		public static AudioSource musicfondo;

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
