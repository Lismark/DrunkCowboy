using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootBox : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    [SerializeField] GameObject counterObject;
    [SerializeField] Sprite icon;
    [SerializeField] Inventory inventory;

    private Image counterImage;
    private float timeLeft;
    private void Start()
    {
        timeLeft = lifeTime;
        counterImage = counterObject.GetComponent<Image>();
    }
    private void FixedUpdate()
    {
        LifeTimer();
    }

    private void LifeTimer()
    {
        timeLeft -= Time.deltaTime;
        counterImage.fillAmount = timeLeft / lifeTime;
        if(timeLeft < 0)
        {
            timeLeft = lifeTime;
            Destroy(gameObject);
        }
    }

    public void ClickDestroy()
    {
        inventory.AddToInventory(gameObject);
        Destroy(gameObject);
    }
}
