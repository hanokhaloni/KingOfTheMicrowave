using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    private Player player;

    private AudioSource audiosource;



    // Use this for initialization
    void Start()
    {
        player = transform.parent.gameObject.GetComponent<Player>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddRelativeForce((other.transform.position - player.gameObject.transform.position).normalized * player.defualtReboundFactor / 6);
            playRandomSound();
        }
        if (other.CompareTag("Border"))
        {
            player.GetComponent<Rigidbody>().drag = 0;
            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }


    private void playRandomSound()
    {
        audiosource.pitch = Random.Range(1.8f, 2.0f);
        audiosource.Play();
    }




}
