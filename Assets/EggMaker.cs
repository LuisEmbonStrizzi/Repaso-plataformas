using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMaker : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject eggSpawnPoint;
    float tamano;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clon;
            clon = Instantiate(eggPrefab);
            clon.transform.position = eggSpawnPoint.transform.position;
        }
        
    }
}
