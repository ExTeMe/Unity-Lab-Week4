using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int randNum, i = 3;
    public GameObject obj;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.tag == "Red" && i == 100)
            obj.SetActive(false);
        else if (obj.tag == "Blue" && i == randNum)
            rend.enabled = false;
        Debug.Log(obj.name + ":" + ++i);
    }
}

