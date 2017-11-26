using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	public float speed;
	private Vector2 actualPosition;
	// Use this for initialization
	void Start () 
	{
		actualPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate((new Vector3(speed,0,0))* Time.deltaTime);
		var verticalPosition = Random.Range(-2f, 3f);
		if(this.transform.position.x <= -11.50)
		{
			this.transform.position = new Vector2(actualPosition.x,verticalPosition);
		}
	}
}
