using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System;

public class SCPantallaCrearPartida : MonoBehaviour {
	
	public static int nivel;
	public Dropdown dpDificultad;
	public void CambiarEscena(string escena){
		Application.LoadLevel (escena);
	}

	void Update(){
		int nivelP= dpDificultad.value;
		nivel = nivelP; 
	}
}
