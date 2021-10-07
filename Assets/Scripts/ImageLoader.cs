using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class ImageLoader : MonoBehaviour
{
    [SerializeField] AssetReference loadSprite;
    [SerializeField] SpriteRenderer image;

    private IEnumerator Start()
    {
        AsyncOperationHandle<Sprite> handle = loadSprite.LoadAssetAsync<Sprite>();
        yield return handle;
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            Sprite sprite = handle.Result;
            image.sprite = sprite;
            Addressables.Release(handle);
        }
    }
}
