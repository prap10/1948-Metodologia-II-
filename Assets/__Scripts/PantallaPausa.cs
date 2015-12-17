using UnityEngine;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

public class PantallaPausa : MonoBehaviour {
	
	public bool pausado = false;
	public Rect menuPausa = new Rect ( 800, 300, 300, 300 );

	public PantallaPausa()  {}
	
	//private SaveData saveData;
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown( KeyCode.Escape ) ) {
			
			pausado = !pausado;
			
			if ( pausado ) {
				Time.timeScale = 0;
				AudioListener.pause = true;
			}
			else {
				Time.timeScale = 1;
				AudioListener.pause = false;
			}
		}
	}
	
	void OnGUI() {
		if (pausado)
			GUI.Window ( 0, menuPausa, opcionesPausa, "Juego en Pausa" );
	}

	void opcionesPausa( int pantallaId ) {
		
		if( GUILayout.Button( "Menu Principal" ) ) {
			Application.LoadLevel( "PantallaLogo" );
		}

		if(GUILayout.Button( "Guardar Partida" )) {
			SaveLoad.Save();
		}

		if(GUILayout.Button( "Cargar Partida" )) {
			SaveLoad.Load();
			if (SaveData.pasoAlajuela && !SaveData.pasoCartago)
				Application.LoadLevel("Pantalla1Cartago");
			if (SaveData.pasoAlajuela && SaveData.pasoCartago)
				Application.LoadLevel("Pantalla1SanJose");
		}

		if(GUILayout.Button( "Salir" )) {
			Application.Quit();
		}
		
	}
	
}