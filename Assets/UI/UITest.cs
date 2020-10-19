using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UIManager.Instance.PushPanel(UIPanelType.Main);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
