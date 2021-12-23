using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class funcoes : MonoBehaviour {
    public string sceneName;
    public int idCurso = 0;
    public bool semAnimacao = false;
    Animator anim;
    int click = Animator.StringToHash("click");

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    void OnMouseDown()
    {
        //print("Hit something!");
        if (!semAnimacao)
        {
            anim.SetTrigger(click);
        }
        else
        {
            PlayerPrefs.SetInt("Codigo",idCurso);
            carregaCena();
        }
    }

    void carregaCena()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void sair()
    {
        Application.Quit();
    }
}
