using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] private Transform spawnLocation;
    [SerializeField] private SpawnObject objectPrefab;
    [SerializeField] private TMP_Text objectCountText;
    private int objectCount = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SpawnObject newObject = Instantiate(objectPrefab);
            objectCount++;
            objectCountText.text = "Fish Count: " + objectCount;
            newObject.SetColor(Random.ColorHSV(0, 1, 0.75f, 1, 0.5f, 1, 1, 1));
            newObject.transform.position = spawnLocation.position;
            newObject.transform.rotation = Random.rotation;
        }
    }
}
