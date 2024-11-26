using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public AudioSource goofySound1;

    public AudioSource goofySound2;
    
    public Sprite imagenBomba;
   
    public Sprite imagenChill;
    
    public void cambiarImagen(GameObject boton)
    {
        int rndNum = Random.Range(0, 10);

        if (rndNum < 7)
        {
            Image imagenDelBoton=boton.GetComponent<Image>();

            imagenDelBoton.sprite = imagenChill;

            goofySound1.Play();
        }
        else
        {
            Image imagenDelBoton = boton.GetComponent<Image>();

            imagenDelBoton.sprite = imagenBomba;
            
            goofySound2.Play();
        }
    }
}
