using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {  
    }
    public void escenajuego(){

     SceneManager.LoadScene("juego");

    }
    public void cargarnivel(string nombrenivel){

     SceneManager.LoadScene(nombrenivel);

    }
    public void salir(){

     Application.Quit();

    }
}
