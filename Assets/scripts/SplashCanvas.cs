using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashCanvas : MonoBehaviour {

    private Image splashImage;

    public Sprite[] textures;
    private AudioSource audioSource;
    private Animator animator;

    private int currentSpriteIndex = 0;

    // Use this for initialization
    void Start () {
        //gameObject.Find("Name/Childname/Childname").GetComponent();
        //splashImage = transform.FindChild("splashImg").gameObject.GetComponent<Image>();
        splashImage = gameObject.GetComponentInChildren<Image>();
        print(splashImage.name);
        animator = splashImage.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            doSplashAnimation();
        }
    }

    public void doSplashAnimation()
    {

       if  (splashImage) splashImage.sprite = textures[getNextSpriteIndex()];
        animator.SetTrigger("play");

        audioSource.Stop();
        audioSource.Play();
    }

    private int getNextSpriteIndex()
    {
        currentSpriteIndex++;
        if (currentSpriteIndex >= textures.Length)
        {
            currentSpriteIndex = 0;
        }
        return currentSpriteIndex;
    }
}
