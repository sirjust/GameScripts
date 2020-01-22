using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject platformPrefab;
    public GameObject spikePlatformPrefab;
    public GameObject[] movingPlatforms;
    public GameObject breakablePlatform;

    public float platform_Spawn_Timer = 2f;
    private float current_Platform_Spawn_Timer;

    private int platform_Spawn_Count;

    public float min_X = -2f, max_X = 2f;

    // Start is called before the first frame update
    void Start()
    {
        current_Platform_Spawn_Timer = platform_Spawn_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms()
    {
        current_Platform_Spawn_Timer += Time.deltaTime;

        if(current_Platform_Spawn_Timer >= platform_Spawn_Timer)
        {

        }
    }
} // class










