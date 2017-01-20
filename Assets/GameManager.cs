using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject arena;
    [SerializeField]
    private float rotationSpeed = 10f;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //arena.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
