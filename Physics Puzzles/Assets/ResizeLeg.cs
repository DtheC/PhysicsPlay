using UnityEngine;
using System.Collections;

public class ResizeLeg : MonoBehaviour {

	private Vector3 startingScale;
	private Vector3 newScale;

	// Use this for initialization
	void Start () {
		startingScale = transform.localScale;
		GetNewScale ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.Lerp (transform.localScale, newScale, 0.01f);
		if (Vector3.Distance(transform.localScale, newScale) < 0.01) {
			GetNewScale();
		}
	}

	void GetNewScale(){
		newScale = transform.localScale + new Vector3(0, Random.Range(-0.2f, 0.2f), 0);
	}
}
