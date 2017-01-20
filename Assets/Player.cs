using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

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
    [SerializeField]
    private float maxGrowth = 3f;
    float direction = 1.0f;
    // Use this for initialization
    void Start () {
        GameManager.addPlayer(this);
	}
	
	// Update is called once per frame
	void Update () {
        if (isAlive)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime * direction, 0);
            if (transform.localScale.x < maxGrowth)
            {
                transform.localScale = new Vector3(transform.localScale.x + 0.001f, transform.localScale.y + 0.001f, transform.localScale.z + 0.001f);
            }

            if (Input.GetKey(defaultPlayerKeycode))
            {
                rotationSpeed = 0f;
                movementSpeed = defaultMovementSpeed;
                //transform.Translate(Vector3.forward *W movementSpeed * Time.deltaTime);
                GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else
            {
                rotationSpeed = defaultRotationSpeed;
                movementSpeed = 0f;
            }

            if (Input.GetKeyUp(defaultPlayerKeycode))
            {
                direction = direction * -1.0f;
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
            GameManager.RemovePlayer(this);
        }
    }

}
