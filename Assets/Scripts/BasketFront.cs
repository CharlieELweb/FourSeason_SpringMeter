using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BasketFront : MonoBehaviour
{
    private float timer = 0f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag != "snowdrop")
        {
            return;
        }
        timer = 2f;
    }
    void Show(float opacity)
    {
        GetComponent<SpriteRenderer>().DOColor(new Color(0.5f, 0.5f, 0.5f, opacity), 0.5f);
    }
    void Hide()
    {
        GetComponent<SpriteRenderer>().DOColor(new Color(1f, 1f, 1f, 1f), 0.5f);
    }

    void Update()
    {
        
        if(GameMannager.Instance.isGameEnd || timer >= 0f)
        {
            Show(0.3f);
            timer -= Time.deltaTime;
        } else
        {
            Hide();
        }
    }
}
