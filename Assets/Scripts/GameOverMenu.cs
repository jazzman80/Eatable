using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] GameObject menu;

    public void On()
    {
        menu.SetActive(true);
    }

    public void Off()
    {
        menu.SetActive(false);
    }
}
