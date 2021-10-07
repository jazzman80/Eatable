using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Globals", menuName = "Assets/Globals")]

public class Globals : ScriptableObject
{
    public int starPrice;
    public int initHealth;
    public float time;
    public Stuff[] stuff;
}
