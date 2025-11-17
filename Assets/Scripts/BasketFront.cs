using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BasketFront : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag != "snowdrop")
        {
            return;
        }
        Show(0.5f);
        Invoke("Hide", 2f);
    }
    void Show(float opacity)
    {
        GetComponent<SpriteRenderer>().DOColor(new Color(0.5f, 0.5f, 0.5f, opacity), 0.5f);
    }
    void Hide()
    {
        GetComponent<SpriteRenderer>().DOColor(new Color(1f, 1f, 1f, 1f), 0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMannager.Instance.isGameEnd)
        {
            Show(0.3f);
        }
    }
}
