using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Card : MonoBehaviour
{
    //Класс карточки
    
    [SerializeField] TextMeshPro cardName;
    [SerializeField] SpriteRenderer image;
    [SerializeField] Animator animator;
    [SerializeField] GameEvent cardDestroy;
    [SerializeField] GameEvent guessedRight;
    [SerializeField] GameEvent guessedWrong;

    bool active = false;

    //Вид карточки - съедобное или несъедобное
    Stuff.Quality quality;

    //Установка данных, переданных фабрикой
    public void SetData(Stuff stuff)
    {
        quality = stuff.quality;
        cardName.text = stuff.stuffName;
        StartCoroutine(LoadImage(stuff.assetReference));
    }

    //При смахивании влево
    public void OnSwipeLeft()
    {
        if (active)
        {
            active = false;
            animator.Play("Swipe Left");
        }

        //Запуск события в зависимости от правльного или неправильного ответа
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

        //Запуск события в зависимости от правльного или неправильного ответа
        if (quality == Stuff.Quality.eatable) guessedRight.Raise();
        else guessedWrong.Raise();
    }

    //Активация карточки после окончания анимаций
    public void Activate()
    {
        active = true;
    }

    //Уничтожение карточки после окончания анимации, запуск события для генерации новой карточки
    public void CardDestroy()
    {
        cardDestroy.Raise();
        Destroy(gameObject);
    }

    //Если игра окончилась по таймеру, необходимо убрать карточку
    public void OnGameOver()
    {
        animator.Play("Swipe Right");
    }

    //Загрузка необходимой картинки из Addressable asset
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
