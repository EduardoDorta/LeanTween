using UnityEngine;

public class Tema2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //float cronometro = 0;
    //float escala = 2f;
    public GameObject objeto;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //cronometro += Time.deltaTime;
        //transform.localScale += new Vector3(escala * Time.deltaTime, escala * Time.deltaTime, escala * Time.deltaTime);
        LeanTween.moveX(objeto, 10f, 3f);

    }
}
