using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	private Animator animator;

	private SpriteRenderer sprite;
	public float speed=100;

	public Sprite Front;
	public Sprite Back;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		sprite = this.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)|| Input.touchCount==1){
			GetComponent<Rigidbody>().velocity = Vector3.zero;
			GetComponent<Rigidbody>().AddForce(Vector3.up*speed);
		}


		var horizontal = Input.GetAxis("Horizontal");

		if (horizontal > 0) {
			sprite.sprite = Front;
			animator.enabled=true;
			animator.SetInteger ("Direction", 0);
			
			//Geser Ke Kanan
			transform.position += (Vector3.right/20);
		} else if (horizontal < 0) {
			sprite.sprite = Back;
			animator.enabled=true;
			animator.SetInteger ("Direction", 1);
			
			//Geser Ke Kiri
			transform.position += (Vector3.left/20);
		} else {
			animator.enabled=false;
		}
		
	}
}
