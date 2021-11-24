using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public float speed=6;
	public CharacterController con;
	public float jumpsp = 10;
	public float plaG = 10;
	private Vector3 mo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float plax = 0;
		float plaz = 0;



		if (con.isGrounded) {
			plax = Input.GetAxis ("Horizontal");
			plaz = Input.GetAxis ("Vertical");


			mo = transform.right * plax + transform.forward * plaz * speed;

			if (con.isGrounded && Input.GetAxis("Jump")==1) {//on ground and input jump
				mo.y=jumpsp;
			}

		}
		mo.y =mo.y- plaG*Time.deltaTime;

		con.Move (mo*Time.deltaTime);
		xiao ();

	}

	void xiao(){

		RaycastHit hi = new RaycastHit ();
		Ray r = new Ray ();
		r = Camera.main.ScreenPointToRay (Input.mousePosition);


		if (Input.GetMouseButton (0)) {//Down mouse left
			if (Physics.Raycast (r, out hi)) {
				Destroy (hi.collider.gameObject);
			}
		}

		if (Input.GetMouseButton (1)) {
		}
	}
}
