using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchingGMScripts : MonoBehaviour {


	public float val = 10; 
 	
	void Update()
	{
		//calling Coroutine!
		StartCoroutine (myCoroutine ());
	}


	IEnumerator myCoroutine()
	{
		//changing values of Game Object.
		GameManager.instance.floatValue = val;
		print ("Hello " + GameManager.instance.floatValue);
		yield return val;
	}




}
