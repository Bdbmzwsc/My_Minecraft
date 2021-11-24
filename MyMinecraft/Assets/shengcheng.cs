using UnityEngine;
using System.Collections;

public class shengcheng : MonoBehaviour {

	public int x;
	public int y;
	public int z;
	public GameObject cu;
	private Transform t;
	// Use this for initialization
	void Start () {
		for (int xi = 1; xi <= x; xi++) {//生成x*y*z个方
			for (int yi = 1; yi <= y; yi++) {
				for (int zi = 1; zi <= z; zi++) {
					Instantiate (cu, new Vector3 (xi + 1, yi + 1, zi + 1), transform.rotation);
				}
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
