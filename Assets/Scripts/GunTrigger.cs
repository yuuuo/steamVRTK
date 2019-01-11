using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class GunTrigger : MonoBehaviour {

	public Transform transform;
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		if (GetComponent<VRTK_ControllerEvents>() == null)
			return;
		GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
	}

	private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
	{
		GameObject create = Instantiate(prefab, transform);
		ParticleSystem particle = create.GetComponent<ParticleSystem>();
		Destroy(create, particle.main.duration);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
