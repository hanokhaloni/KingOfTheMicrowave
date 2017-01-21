using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashCanvas : MonoBehaviour {

    RawImage childComponents;

    public Texture[] textures;

    private AudioSource audioSource;
    // Use this for initialization
    void Start () {
        //gameObject.Find("Name/Childname/Childname").GetComponent();
        childComponents = transform.FindChild("RawImage").gameObject.GetComponent<RawImage>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //this.enabled = true;
            Debug.Log("splash enabled");
            childComponents.texture = textures[0];
            childComponents.enabled = true;

            audioSource.Stop();
            audioSource.Play();

        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            //this.enabled = false;
            Debug.Log("splash disabled");
            childComponents.enabled = false;
            
        }
    }
}
