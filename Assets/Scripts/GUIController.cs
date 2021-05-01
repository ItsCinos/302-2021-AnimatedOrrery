using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GUIController : MonoBehaviour
{

    EventSystem events;

    public Camera cam;
     
    void Start()
    {
        events = GetComponentInChildren<EventSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (events.currentSelectedGameObject == null)
        {
            events.SetSelectedGameObject(events.firstSelectedGameObject);
        }
    }

    public void Planet1()
    {

    }
    public void Planet2()
    {

    }
    public void Planet3()
    {

    }
    public void Planet4()
    {

    }
    public void Planet5()
    {

    }
}
