using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
//using System.Collections;

public class lerGravarArquivo : MonoBehaviour {
    public Text campoNome;
    public Text campoTelefone;
    public Text campoEmail;
    public Text campoCurso;
    public Canvas formulario;
    public Canvas confirmacao;
    Text cabecalho;
    Boolean fileExist = true;
    // Use this for initialization
    void Start () {
        formulario.enabled = true;
        confirmacao.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Salvar()
    {

        if (!File.Exists("inscritos.csv"))
        {
            fileExist = false;

        }

        StreamWriter w = File.AppendText("inscritos.csv");// Add some text to the file.
        if (!fileExist)
        {
            w.WriteLine("Nome; Telefone; Email; Curso; Data Cadastro;");
        }
        w.Write(campoNome.text + ";");
        w.Write(campoTelefone.text + ";");
        w.Write(campoEmail.text + ";");
        w.Write(campoCurso.text + ";");
        w.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ";");
        w.Flush();
        // Close the writer and underlying file.
        w.Close();

        formulario.enabled = false;
        confirmacao.enabled = true;

    }
    
}
