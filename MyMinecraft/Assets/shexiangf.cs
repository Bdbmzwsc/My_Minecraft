using UnityEngine;
using System.Collections;

public class shexiangf : MonoBehaviour {
	public float mousesp=7;
	public Transform tran;
	float fx1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float fx = Input.GetAxis ("Mouse X") * mousesp * Time.deltaTime;
		float fy=Input.GetAxis("Mouse Y")*mousesp*Time.deltaTime;

		fx1 -= fy;

		transform.localRotation = Quaternion.Euler (fx1, 0, 0);

		tran.Rotate (Vector3.up * fx);
	}
}
