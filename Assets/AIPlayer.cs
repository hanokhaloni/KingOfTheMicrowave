using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour {

    [SerializeField]
    KeyCode defaultPlayerKeycode;
    [SerializeField]
    public float defaultRotationSpeed = 300f;
    private float rotationSpeed = 300f;
    [SerializeField]
    private float defaultMovementSpeed = 50f;
    private float movementSpeed = 0f;
    [SerializeField]
    public float defualtReboundFactor = -500f;
    [SerializeField]
    private int playerId;
    private bool isAlive = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isAlive)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            transform.localScale = new Vector3(transform.localScale.x + 0.0005f, transform.localScale.y + 0.0005f, transform.localScale.z + 0.0005f);

            if (getBehavior())
            {
                rotationSpeed = 0f;
                movementSpeed = defaultMovementSpeed;
                //transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
                GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else
            {
                rotationSpeed = defaultRotationSpeed;
                movementSpeed = 0f;
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    collision.rigidbody.AddRelativeForce(collision * defualtReboundFactor);
    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Border"))
        {
            isAlive = false;
            
        }
    }

    private bool getBehavior()
    {
        return (Random.value > 0.1f);
    }

}
