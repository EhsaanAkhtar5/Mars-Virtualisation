using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomise_Scale : MonoBehaviour
{


    public float globelScaleMultiplier = 1f;

    public bool scaleUniformly;

    public float uniformScaleMin = 1f;
    public float uniformScaleMax = 1f;

    public float xScaleMin = .1f;
    public float xScaleMax = 3f;
    public float yScaleMin = .1f;
    public float yScaleMax = 3f;
    public float zScaleMin = .1f;
    public float zScaleMax = 3f;

    // Start is called before the first frame update
    void Start()
    {

        RandomiseObjectScale();

    }



    void RandomiseObjectScale()
    {
        Vector3 randomisedScale = Vector3.one;

        if (scaleUniformly)
        {

            float uniformScale = Random.Range(uniformScaleMin, uniformScaleMax);
            randomisedScale = new Vector3(uniformScale, uniformScale, uniformScale);
        }
        else
        {
            randomisedScale = new Vector3(Random.Range(xScaleMax, xScaleMax), Random.Range(yScaleMin, yScaleMax), Random.Range(zScaleMin, zScaleMax));
        }

        transform.localScale = randomisedScale * globelScaleMultiplier;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
