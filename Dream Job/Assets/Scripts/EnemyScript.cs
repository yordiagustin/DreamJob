using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.x <= 12)
		{
			this.transform.position = new Vector2(12.14f, this.transform.position.y);
		}
	}
}
