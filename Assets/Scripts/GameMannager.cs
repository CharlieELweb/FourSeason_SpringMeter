using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameMannager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip winSound, loseSound;
    [HideInInspector] public bool isGameEnd = false;
    public Material outlineMaterial;
    public static GameMannager Instance {get; private set;}
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            EndGame();
        }
    }

    void EndGame()
    {
        isGameEnd = true;
        GameObject[] snowdrops = GameObject.FindGameObjectsWithTag("snowdrop");
        Debug.Log(snowdrops.Length);
        StartCoroutine(CountSnowdrop(snowdrops));
        
    }
    IEnumerator CountSnowdrop(GameObject[] snowdrops)
    {
        foreach (GameObject snowdrop in snowdrops)
        {
            snowdrop.GetComponent<PlayRandomHarp>().PlayHarp();
            snowdrop.GetComponent<SpriteRenderer>().material = outlineMaterial;
            yield return new WaitForSeconds(0.2f);
        }
        yield return new WaitForSeconds(1f);
        if(snowdrops.Length >= 10)
        {
            audioSource.PlayOneShot(winSound);
        }
        else
        {
            audioSource.PlayOneShot(loseSound);
        }
        
    }
}
