using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private Animator doorAnim;
    [SerializeField]
    private Animator camAnim;
    [SerializeField]
    public static bool gameStarted = false;
    [SerializeField]
    private GameObject[] players;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStarted)
        {
            doorAnim.SetBool("GameStarted",true);
            camAnim.SetBool("GameStarted", true);
        }
        if(players.Length==1)
        {
            foreach (var player in players)
            {
                if(player.GetComponent<Rigidbody>().constraints == RigidbodyConstraints.None)
                {

                }
                else
                {
                    
                }
            }
        }
    }
}
