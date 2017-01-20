using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {
    private Player player;
	// Use this for initialization
	void Start () {
        player = transform.parent.gameObject.GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddRelativeForce((other.transform.position - player.gameObject.transform.position).normalized * player.defualtReboundFactor);
        }
        if(other.CompareTag("Border"))
        {
            player.GetComponent<Rigidbody>().drag = 0;
            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
