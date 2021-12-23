using UnityEngine;
using System.Collections;

public class changeLand : MonoBehaviour {

    private SpriteRenderer sprR;

    // Use this for initialization
    void Start () {
        sprR = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y == -0.22f)
        {
            sprR.sortingLayerName = "land0";
        }
        else if (transform.position.y == -1f)
        {
            sprR.sortingLayerName = "land1";
        }
        else if (transform.position.y == -1.7f)
        {
            sprR.sortingLayerName = "land2";
        }
        else
        {
            sprR.sortingLayerName = "land3";
        }

    }
}
