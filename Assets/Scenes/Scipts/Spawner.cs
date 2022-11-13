using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Spawn;
    public GameObject Cactus;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("a", 1, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void a()
    {
        Spawn = Instantiate(Cactus, transform.position, Quaternion.identity) as GameObject;
    }
}
