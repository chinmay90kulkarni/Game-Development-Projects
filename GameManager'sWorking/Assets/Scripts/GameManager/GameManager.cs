using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public float floatValue = 10f;

	void Awake()
	{
		DontDestroyOnLoad (this);
		instance = this;
	}

	void Update()
	{
		if (Input.GetKey (KeyCode.N)) {
			Application.LoadLevel (1);
		}
	}
}
