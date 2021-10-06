using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectsPool;

    public void ObjectsOff()
    {
        foreach (GameObject gameObject in objectsPool) gameObject.SetActive(false);
    }

    public void ObjectsOn()
    {
        foreach (GameObject gameObject in objectsPool) gameObject.SetActive(true);
    }
}

