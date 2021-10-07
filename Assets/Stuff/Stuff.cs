using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "Stuff", menuName = "Assets/Stuff")]

public class Stuff : ScriptableObject
{
    public string stuffName;
    public AssetReference assetReference;
    public Quality quality;

    public enum Quality
    {
        eatable,
        uneatable
    }
}
