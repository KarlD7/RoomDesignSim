using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/**
 * This class dictates how the prefab objects accessories will behave upon instantiation
 */
public class ObjectBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameManager;
    public bool hovering;
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        hovering = false;
    }

    // Update is called once per frame
    void Update()
    {
        //changing the material's object
        if (Input.GetButtonDown("XRI_Right_TriggerButton") && hovering)
        {
            changeMaterial();
        }
        //delete the object
        if(Input.GetButtonDown("XRI_Right_PrimaryButton") && hovering)
        {
            Destroy(gameObject);
        }
    }
    //This function will change the material of the current gameobject
    public void changeMaterial()
    {
        Material newMat = gameManager.GetComponent<GameBehavior>().currMaterial;
        gameObject.GetComponent<Renderer>().material = newMat;
        int numChildren = gameObject.transform.childCount;
        if(numChildren > 0)
        {
            for (int i = 0; i < numChildren; i++)
            {
                gameObject.transform.GetChild(i).GetComponent<Renderer>().material = newMat;
            }
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = newMat;
        }
    }
    //changes the value of our hover variable depending on whether or not one of the VR controllers
    //are hovering over the game object
    public void setHover(bool hover)
    {
        hovering = hover;
    }
}
