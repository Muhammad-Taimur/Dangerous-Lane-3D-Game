using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public float speed = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Rotate (new Vector3 (speed * Time.fixedDeltaTime, 0, 0));
	
	}
}
