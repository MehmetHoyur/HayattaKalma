using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    public GameObject spawnPrefab;
    private void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        pos=transform.position;
        pos.y=Terrain.activeTerrain.SampleHeight(transform.position);
        transform.position=pos;
        if (Input.GetMouseButtonDown(2))
        {
            Instantiate(spawnPrefab, transform.position, transform.rotation);
            
        }
    }
    
}
