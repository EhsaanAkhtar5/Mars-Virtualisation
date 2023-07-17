using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items_spread : MonoBehaviour

{

    public GameObject[] Items;





    public float itemXSpread = 500;
    public float itemYSpread = 0;
    public float itemZSpread = 500;

    public int numberOfItems = 100;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < numberOfItems; i++)
        {
            spreadItem();
        }
    }



    void spreadItem()
    {


        int randomRange = Random.Range(0, Items.Length);
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(Items[randomRange], randPosition, Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {

    }
}