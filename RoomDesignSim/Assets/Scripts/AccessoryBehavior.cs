using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This function defines the behavior of all buttons containing an accessory.
 * Its main purpose is to create the object attached to a button whenever that
 * button is clicked.
 */
public class AccessoryBehavior : MonoBehaviour
{
    //game object that will be connected to the button
    public GameObject objectPrefab;
    //create the game object connected to the button whenever it is clicked
    public void createObject()
    {
        GameObject user = GameObject.Find("Main Camera");
        Vector3 userPos = user.transform.position;
        Quaternion userRot = user.transform.rotation;
        Vector3 objPos = new Vector3(userPos.x + 1, userPos.y, userPos.z);
        Instantiate(objectPrefab, objPos, userRot);
    }
}
