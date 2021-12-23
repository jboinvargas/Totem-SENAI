using UnityEngine;
using System.Collections;

public class clickButton : MonoBehaviour {
    public string direction;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        //print("Hit something!");
        if (direction == "Cima")
        {
            gameControl.instance.up = true;
        }

        if (direction == "Baixo")
        {
            gameControl.instance.down = true;
        }
    }
}
