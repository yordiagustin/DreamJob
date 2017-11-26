using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour {

	public float speed;
	public float relativePosition;
	public float conditionalPosition;
	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate((new Vector3(speed,0,0))* Time.deltaTime);
		if(this.transform.position.x <= conditionalPosition)
		{
			transform.position = new Vector3(relativePosition,this.transform.position.y,0);
		}
	}
}
