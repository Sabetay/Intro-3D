using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INSTANTIATPOR : MonoBehaviour
{
    public GameObject cubePreFab;
    // Start is called before the first frame update
    void Start()
    {
        CLONARCUBO();
    }

    // Update is called once per frame
    void Update()
    {

    } 
    public void CLONARCUBO()
    {
        Instantiate(cubePreFab);
    }
}

