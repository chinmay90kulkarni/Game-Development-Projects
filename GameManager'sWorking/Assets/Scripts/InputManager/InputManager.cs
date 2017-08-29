using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public static InputManager inputMan = null;

	// Use this for initialization
	void awake()
	{
		DontDestroyOnLoad (this);
	}
}
