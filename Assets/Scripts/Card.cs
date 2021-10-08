using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Card : MonoBehaviour
{
    [SerializeField] TextMeshPro cardName;
    [SerializeField] SpriteRenderer image;
    [SerializeField] Animator animator;
    [SerializeField] GameEvent cardDestroy;
    [SerializeField] GameEvent guessedRight;
    [SerializeField] GameEvent guessedWrong;

    bool active = false;
    Stuff.Quality quality;

    public void SetData(Stuff stuff)
    {
        quality = stuff.quality;
        cardName.text = stuff.stuffName;
        StartCoroutine(LoadImage(stuff.assetReference));
    }

    public void OnSwipeLeft()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Left");
        }

        if (quality == Stuff.Quality.uneatable) guessedRight.Raise();
        else guessedWrong.Raise();
    }

    public void OnSwipeRight()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Right");
        }

        if (quality == Stuff.Quality.eatable) guessedRight.Raise();
        else guessedWrong.Raise();
    }

    public void Activate()
    {
        active = true;
    }

    public void CardDestroy()
    {
        cardDestroy.Raise();
        Destroy(gameObject);
    }

    public void OnGameOver()
    {
        animator.Play("Swipe Right");
    }

    private IEnumerator LoadImage(AssetReference loadSprite)
    {
        AsyncOperationHandle<Sprite> handle = loadSprite.LoadAssetAsync<Sprite>();
        yield return handle;
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Sprite sprite = handle.Result;
            image.sprite = sprite;
            Addressables.Release(handle);
        }
    }
}
