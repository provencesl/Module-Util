using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		Debug.Log(this.gameObject);
		MyDebug.Log(this.name + this.transform.GetChild(0) + this);
		MyDebug.Log(this.name + "abc");

	}


	// Update is called once per frame
	void Update () {
		
	}
}
