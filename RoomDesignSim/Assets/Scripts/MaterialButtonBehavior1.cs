using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This class dictates how material buttons will act. On click the 
 * button will change the game's current material to a new one.
 */
public class MaterialButtonBehavior1 : MonoBehaviour
{
    public Material material;
    public GameObject gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    //changes that game's global current material value to whatever material
    //is connected to this script's button
    public void selectMaterial()
    {
        gameManager.GetComponent<GameBehavior>().currMaterial = material;
    }
}
