using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscibed")]
    //Prefab for instantiating aples
    public GameObject applePrefab;

    //speed at which the appleTree moves
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //Chance that the AppleTree will change direction
    public float ChangeDirChance = 0.1f;

    //Seconds between Apple Instantiations
    public float appleDropDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // start dropping apples
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        // Changing Direction
    }
}
