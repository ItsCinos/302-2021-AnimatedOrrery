using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GUIController : MonoBehaviour
{

    EventSystem events;

    public SlideTowards camTarget;

    public Transform planet1;
    public Transform planet2;
    public Transform planet3;
    public Transform planet4;
    public Transform planet5;

    void Start()
    {
        events = GetComponentInChildren<EventSystem>();
        //SoundEffectBoard.PlaySong();
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
        camTarget.target = planet1;
    }
    public void Planet2()
    {
        camTarget.target = planet2;
    }
    public void Planet3()
    {
        camTarget.target = planet3;
    }
    public void Planet4()
    {
        camTarget.target = planet4;
    }
    public void Planet5()
    {
        camTarget.target = planet5;
    }

    public void Rewind()
    {
        Time.timeScale = -2;
    }
    public void SlowTime()
    {
        Time.timeScale = .5f;
    }
    public void NormalSpeed()
    {
        Time.timeScale = 1;
    }
    public void FastForward()
    {
        Time.timeScale = 2;
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
}
