using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnParticleCollision(GameObject obj)
	{
		Destroy(obj);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
