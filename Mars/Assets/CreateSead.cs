using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSead : MonoBehaviour
{

    public string stringSeed = "seed string";
    public bool useStringSeed;
    public int seed;
    public bool randomiseSeed;
    // Start is called before the first frame update



    void Awake()
    {
        if (useStringSeed)
        {
            seed = stringSeed.GetHashCode(); // gets hash code of that string
        }

        if (randomiseSeed)
        {
            seed = Random.Range(0, 999999);
        }

        Random.InitState(seed);
    }

}

