using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This class controls events that happen in the game on a global scale
 */
public class GameBehavior : MonoBehaviour
{
    //create necessary member variable
    public Material currMaterial;

    void Start()
    {
    }
    //changes the current material value whenever a material button is clicked
    public void setCurrMaterial(Material mat)
    {
        this.currMaterial = mat;
    }
}
