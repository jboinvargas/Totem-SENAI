using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float startPositionX = -3;
    public float land = 1;
    public bool up;
    public bool down;

    public bool isDead = false;

    private Animator anim;
    private SpriteRenderer sprR;
    //public bool enter = false;




	// Use this for initialization
	void Start () {
        transform.position = new Vector2(startPositionX, -0.75f);
        anim = GetComponent<Animator>();
        sprR = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!isDead)
        {
            if ((Input.GetKeyDown(KeyCode.DownArrow) || gameControl.instance.down) && land < 3)
            {
                land++;
                changeLand(transform.position.y - 0.65f);
            }
            else if ((Input.GetKeyDown(KeyCode.UpArrow) || gameControl.instance.up) && land > 0) {
                land--;
                changeLand(transform.position.y + 0.65f);
            }
            gameControl.instance.down = false;
            gameControl.instance.up = false;
            sprR.sortingLayerName = "land" + land.ToString();
        }
	
	}

    private void changeLand(float yAdd)
    {
        transform.position = new Vector2(startPositionX, yAdd);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SpriteRenderer sprROther = other.GetComponent<SpriteRenderer>();
        if (sprR.sortingLayerID == sprROther.sortingLayerID && other.name == "obstaculo(Clone)")
        {
            isDead = true;
            anim.SetTrigger("Die");
            gameControl.instance.playerDied();
        }
        else if (sprR.sortingLayerID == sprROther.sortingLayerID && other.name == "Coin(Clone)")
        {
            gameControl.instance.playerScored();
            sprROther.enabled = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        SpriteRenderer sprROther = other.GetComponent<SpriteRenderer>();
        if (sprR.sortingLayerID == sprROther.sortingLayerID && other.name == "obstaculo(Clone)")
        {
            isDead = true;
            anim.SetTrigger("Die");
            gameControl.instance.playerDied();
        }
        else if (sprR.sortingLayerID == sprROther.sortingLayerID && other.name == "Coin(Clone)" && sprROther.enabled)
        {
            gameControl.instance.playerScored();
            sprROther.enabled = false;            
        }

    }
    

}
