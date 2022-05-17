using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float xOffset;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CloneBrick()
    {
        GameObject clon;

        clon = Instantiate(brickPrefab);
        clon.transform.position = new Vector3(xOffset, 0, 0);
        Destroy(clon, 2);
        xOffset += 1.1f;

    }
}
