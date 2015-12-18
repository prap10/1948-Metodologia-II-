using UnityEngine;
using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;

// Contenedor de las variables
[Serializable ()]
public class SaveData : ISerializable {
	
	// === Valores ===
	// Se editan durante el juego
	public static int puntaje = 0;
	public static bool pasoAlajuela = false,
						pasoCartago = false;

	//Setters-Getters
	public static int Puntaje {
		get {
			return puntaje;
		}
		set {
			puntaje = value;
		}
	}

	public static bool PasoAlajuela {
		get {
			return pasoAlajuela;
		}
		set {
			pasoAlajuela = value;
		}
	}
	
	public static bool PasoCartago {
		get {
			return pasoCartago;
		}
		set {
			pasoCartago = value;
		}
	}
	// Fin setters-getters

	public SaveData () {}

	public SaveData (SerializationInfo info, StreamingContext ctxt)
	{
		puntaje = (int)info.GetValue("puntaje", typeof(int));
		pasoAlajuela = (bool)info.GetValue("pasoAlajuela", typeof(bool));
		pasoCartago = (bool)info.GetValue("pasoCartago", typeof(bool));
	}

	public void GetObjectData (SerializationInfo info, StreamingContext ctxt)
	{
		info.AddValue("puntaje", puntaje);
		info.AddValue("pasoAlajuela", pasoAlajuela);
		info.AddValue("pasoCartago", pasoCartago);
	}
}

public class SaveLoad {
	
	public static string currentFilePath = "Guardado.cjc"; 
	

	public static void Save ()  
	{
		Save (currentFilePath);
	}
	public static void Save (string filePath)
	{
		GUI.Label(new Rect (300, 800, 800, 800), "Partida guardada");
		SaveData data = new SaveData ();
		
		Stream stream = File.Open(filePath, FileMode.Create);
		BinaryFormatter bformatter = new BinaryFormatter();
		bformatter.Binder = new VersionDeserializationBinder(); 
		bformatter.Serialize(stream, data);

		stream.Close();
	}

	public static void Load ()  { Load(currentFilePath);  }  
	public static void Load (string filePath) 
	{
		GUI.Label(new Rect (300, 800, 800, 800), "Partida Cargada");

		SaveData data = new SaveData ();
		Stream stream = File.Open(filePath, FileMode.Open);
		BinaryFormatter bformatter = new BinaryFormatter();
		bformatter.Binder = new VersionDeserializationBinder(); 
		data = (SaveData)bformatter.Deserialize(stream);

		stream.Close();

	}
	
}

public sealed class VersionDeserializationBinder : SerializationBinder 
{ 
	public override Type BindToType( string assemblyName, string typeName )
	{ 
		if ( !string.IsNullOrEmpty( assemblyName ) && !string.IsNullOrEmpty( typeName ) ) 
		{ 
			Type typeToDeserialize = null; 
			
			assemblyName = Assembly.GetExecutingAssembly().FullName; 
			 
			typeToDeserialize = Type.GetType( String.Format( "{0}, {1}", typeName, assemblyName ) ); 
			
			return typeToDeserialize; 
		} 
		
		return null; 
	} 
}