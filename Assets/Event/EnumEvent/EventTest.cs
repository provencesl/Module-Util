using Event;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class CustomData {

	private int a;

	public CustomData(int a)
	{
		a = 1;
	}
}

public class EventTest : MonoBehaviour {

	// Use this for initialization
	void Start() {
		EventCenter.AddListener<CustomData>(MyEventType.OnBossDie,BossDie);

		//EventCenter.Broadcast(MyEventType.OnBossDie);

		CustomData data = new CustomData(1);
		EventCenter.Broadcast<CustomData>(MyEventType.OnBossDie,data);
	}

	private void BossDie(CustomData data)
	{
		Debug.Log("Boss Die:" + data);
	}

	
	
	// Update is called once per frame
	void Update () {
		
	}
}
