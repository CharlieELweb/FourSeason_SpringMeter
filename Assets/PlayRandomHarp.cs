using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomHarp : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip[] harpSound;
    private AudioClip activeSound;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Start()
    {
        if(harpSound.Length == 0)
        {
            Debug.LogWarning("[WARNING] harpSound[] is empty in " + gameObject);
            return;
        }
        activeSound = harpSound[Random.Range(0, harpSound.Length)];
        audioSource.PlayOneShot(activeSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
