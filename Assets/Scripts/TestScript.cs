using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private double someVar = 0.01;
    public float startPos;
    public int test1;
    public string test2;
    public int[] test3;
    public GameObject test4;

    // Start is called before the first frame update
    private void Start()
    {
        this.transform.position = new Vector3(startPos, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0.01f, 0, 0);

        if (this.transform.position.x > 10)
        {
            this.transform.position = new Vector3(-6.45f, 0, 0);

            Instantiate(test4, new Vector3(-7, 0, 0), this.transform.rotation);
        }
    }
}
