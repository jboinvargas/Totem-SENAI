using UnityEngine;
using System.Collections;

public class videoControl : MonoBehaviour
{
    Animator anim;
    AudioSource aud;
    Renderer r;
    MovieTexture movie;
    public Material[] materials;
    public Canvas cv;
    public int videoPlay = Animator.StringToHash("videoPlay");
    public int videoStop = Animator.StringToHash("videoStop");
    Renderer rend;
    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
        r = GetComponent<Renderer>();
        movie = (MovieTexture)r.material.mainTexture;
        movie.loop = true;
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = materials[0];

    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        //print("Hit something!");

        if (movie.isPlaying)
        {
            movie.Stop();
            aud.Stop();
            anim.SetTrigger(videoStop);
            anim.ResetTrigger(videoPlay);
            rend.sharedMaterial = materials[0];
        }
        else
        {
            rend.sharedMaterial = materials[1];
            anim.SetTrigger(videoPlay);
            anim.ResetTrigger(videoStop);
            //aud.clip = movieTexture.audioClip;
            movie.Play();
            aud.Play();
        }
    }
    void ApareceTexto()
    {
        if (cv.enabled)
        {
            cv.enabled = false;
        }
        else
        {
            cv.enabled = true;
        }
    }
}
