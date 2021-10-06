using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] GameObject heart;

    public void Off()
    {
        heart.SetActive(false);
    }
}
