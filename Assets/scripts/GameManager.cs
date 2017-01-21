using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

    [SerializeField]
    private Animator doorAnim;
    [SerializeField]
    private Animator camAnim;
    [SerializeField]
    public static bool gameStarted = false;
    [SerializeField]
    private static List<Player> Players = new List<Player>();
    [SerializeField]
    //public GameObject splashManagerPrefab;

    public Text winnerText;

   // private GameObject splashManagerCanvas;
    //private SplashCanvas splashManagerScript;

    public static GameManager GetInstance()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = new GameManager();
        }

        return instance;
    }

    void Start()
    {
        Debug.Log("Game manager started");
        winnerText.text = "";
        //splashManagerCanvas = Instantiate(splashManagerPrefab) as GameObject;
        //splashManagerScript = splashManagerCanvas.GetComponent<SplashCanvas>();
       
       // splashManagerScript.doSplashAnimation();
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
            string txt = Players[0].name.ToString() + " Is the Winner!!!\n Press backspace to reset";
            winnerText.text = txt;
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                SceneManager.LoadScene(0);
            }
        }
    }


    public static void addPlayer(Player player)
    {
        Players.Add(player);
    }
    public static void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

    public void Splash()
    {
        //splashManagerScript = splashManagerCanvas.GetComponent<SplashCanvas>();
        //splashManagerScript.doSplashAnimation();

    }
}
