using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField]
    private Animator doorAnim;
    [SerializeField]
    private Animator camAnim;
    [SerializeField]
    public static bool gameStarted = false;
    [SerializeField]
    private static List<Player> Players = new List<Player>();

    public Text winnerText;
    
    public static void addPlayer(Player player)
    {
        Players.Add(player);
    }
    public static void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

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
        if(Players.Count ==1)
        {
            winnerText.text = "<b>"+Players[0].name.ToString() + " Is the Winner!!! Press backspace to reset"+ "</b>";
            if(Input.GetKeyDown(KeyCode.Backspace))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
