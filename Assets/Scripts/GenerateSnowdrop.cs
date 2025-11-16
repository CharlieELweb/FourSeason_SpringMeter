using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSnowdrop : MonoBehaviour
{
    [SerializeField]
    GameObject snowdropPrefab;

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
        Instantiate(snowdropPrefab);
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
