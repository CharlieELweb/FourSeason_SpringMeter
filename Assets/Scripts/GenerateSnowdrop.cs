using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSnowdrop : MonoBehaviour
{
    [SerializeField]
    GameObject snowdropPrefab;
    [SerializeField]
    float offsetX;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CreateSnowdrop()
    {
        if(snowdropPrefab == null)
        {
            Debug.LogError("[ERROR] SnowdropPrefab is not valid in " + gameObject);
            return;
        }
        Instantiate(snowdropPrefab, transform.position + Random.Range(-offsetX, offsetX) * Vector3.right, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateSnowdrop();
        }
    }
}
