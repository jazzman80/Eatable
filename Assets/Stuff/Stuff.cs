using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[CreateAssetMenu(fileName = "Stuff", menuName = "Assets/Stuff")]

public class Stuff : ScriptableObject
{
    //Класс предметов, размещаемых на карточках
    
    //Название
    public string stuffName;

    //Ссылка на картинку в Addressable asset
    public AssetReference assetReference;

    //Съедобное или несъедобное 
    public Quality quality;

    public enum Quality
    {
        eatable,
        uneatable
    }
}
