﻿using UnityEngine;
using System.Collections;

public class BluePlayerI_Script : MonoBehaviour {

	public static string bluePlayerI_ColName;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "blocks") 
		{			
			bluePlayerI_ColName = col.gameObject.name;
			if (col.gameObject.name.Contains("Safe House")) {
				SoundManagerScript.safeHouseAudioSource.Play ();
			}
		}
	}

	void Start () 
	{
		bluePlayerI_ColName = "none";
	}
}
