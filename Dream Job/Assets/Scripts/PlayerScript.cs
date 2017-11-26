using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public AudioClip backgroundSound;
	public AudioClip coinSound;
	public Text scoreTxt;
	public Text timeTxt;

	private static int points = 0;
	private static float time = 100;
	private Rigidbody2D _rigidbody;
	private PolygonCollider2D _collider;

	// Use this for initialization
	void Start () {
		_rigidbody = GetComponent<Rigidbody2D>();
		_collider = GetComponent<PolygonCollider2D>();
		PlayAudio(backgroundSound);
	}

    private void PlayAudio(AudioClip sound)
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }

    // Update is called once per frame
    void Update () 
	{
		Vector2 vector = new Vector2(0,250);
		if(Input.GetKeyDown(KeyCode.Space))
		{
			_rigidbody.velocity = new Vector2(0,2);
			_rigidbody.AddForce(vector);
		}
	}

	void FixedUpdate()
	{
		time -= Time.deltaTime;
		timeTxt.text = "Time " + time.ToString("0");
		if(time == 0)
		{
			
		}  
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Coin")
		{
			points++;
			scoreTxt.text = "Coins " + points;
			_rigidbody.velocity = Vector2.zero;
			ReturnCoin(collision.gameObject);
			PlayAudio(coinSound);
		}
	}

	void ReturnCoin(GameObject coin)
	{
		var verticalPosition = Random.Range(-2f, 3f);
		coin.transform.position = new Vector2(13,verticalPosition);

	}
}
