using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickCloner : MonoBehaviour
{
    public GameObject brickPrefab;
    public float xOffset;
    int counter = 0;
    public Text usrOffset;
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
        xOffset = float.Parse(usrOffset.text);
        if (counter == 0)
        {
            xOffset = float.Parse(usrOffset.text);

        }
        if (counter < 5)
        {

            GameObject clon;
            clon = Instantiate(brickPrefab);
            clon.transform.position = new Vector3(float.Parse(usrOffset.text), 0, 0);
            Destroy(clon, 2);

            counter++;
        }

    }
}
