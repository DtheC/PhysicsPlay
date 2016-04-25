using UnityEngine;
using System.Collections;

public class CreateSphereParticles : MonoBehaviour {

	public GameObject ObjectToInstantiate;
	public int AmountToCreate = 10;
	public float ChanceToInstantiate = 0.5f;


	private int _instantiateCount = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (_instantiateCount < AmountToCreate) {
			if (Random.Range (0.00f, 1.00f) < ChanceToInstantiate) {
				Instantiate (ObjectToInstantiate, transform.position, Quaternion.identity);
				_instantiateCount++;
			}
		}
	}
}
