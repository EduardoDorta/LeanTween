using UnityEngine;

public class Tema2 : MonoBehaviour
{
    //Expresion Lambda
    public LeanTweenType efecto;
    public GameObject camara;
    Vector3 posicionCamara;
    public GameObject personaje1;
    public LeanTweenType efectoPersonaje1;
    public GameObject personaje2;
    public LeanTweenType efectorPersonaje2;


    void Start()
    {
        posicionCamara = camara.transform.position;
    }

    public void MoverX()
    {
        /*LeanTween.moveX(camara, 3f, 0.03f).setOnComplete(() =>{
            LeanTween.moveY(camara, 2f, 0.05f).setOnComplete(() =>
            {
                LeanTween.move(camara, posicionCamara, 0.06f);
            });
        });*/
        LeanTween.moveY(personaje1.GetComponent<RectTransform>(), -76, 1f).setEase(efectoPersonaje1).setOnComplete(() =>
        {
            LeanTween.moveY(personaje2.GetComponent<RectTransform>(), -76, 1f).setEase(efectorPersonaje2);
        });

    }
    
}




/*  float cronometro = 0;
    float escala = 2f;  
    cronometro += Time.deltaTime;
    transform.localScale += new Vector3(escala * Time.deltaTime, escala * Time.deltaTime, escala * Time.deltaTime); */

/*LeanTween.moveY(objeto, 20f, 3f).setDelay(0.5f).setEase(efecto).setLoopPingPong(3);

        public GameObject objeto;
        Método1:  .setEaseInOut
        Método2:  .setEase(LeanTweenType.easeInOutCubic)
        Método3: public  LeanTweenType efecto */


/* public LeanTweenType efecto;
    public GameObject camara;
    Vector3 posicionCamara;


    void Start()
    {
        posicionCamara = camara.transform.position;
    }

    public void MoverX()
    {
        LeanTween.moveX(camara, 3f, 0.03f).setOnComplete(MoverY);

    }
    void MoverY()
    {
        LeanTween.moveY(camara, 2f, 0.05f).setOnComplete(MoverInicio);
    }
    void MoverInicio()
    {
        LeanTween.move(camara, posicionCamara, 0.06f);
    }
 */