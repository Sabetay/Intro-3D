using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOM : MonoBehaviour
{
    public GameObject preFab1;
    public GameObject preFab2;
    public GameObject preFab3;
    public int min;
    public int max;
    public int randomNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ClonerRandom()
    {
        randomNumber = Random.Range(min,max + 1);
        if (randomNumber == 0)
        {
            Instantiate(preFab1);
        } else if (randomNumber == 1)
        {
            Instantiate(preFab2);
        }else
        {
            Instantiate(preFab3);
        }
    }
}
