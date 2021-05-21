using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventListener : MonoBehaviour
{
    public Button emptyRoom;
    public Button room1;
    
    void Start()
    {
        //Loads one of the room scenes when its button is clicked
        emptyRoom.onClick.AddListener(() =>{
            SceneManager.LoadScene("EmptyRoom");
        });

        room1.onClick.AddListener(() =>{
            SceneManager.LoadScene("Room1");
        });
    }
}
