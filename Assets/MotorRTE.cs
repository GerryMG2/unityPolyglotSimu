using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotorRTE : MonoBehaviour
{
    public GameObject cuadrito;

    public Text inputRotation;
    public Text inputEscalamiento;
    public Text inputPosition;


    private int posicion = 0;
    private int rotation = 0;
    private float escalamiento = 0;

   

    int angles;
    float initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = cuadrito.transform.position.x;

        
    }

    // Update is called once per frame
    void Update()
    {
        cuadrito.transform.rotation = Quaternion.Euler(Vector3.forward * -rotation);
        cuadrito.transform.position = new Vector3(initialPosition + posicion, cuadrito.transform.position.y, cuadrito.transform.position.z);
        cuadrito.transform.localScale = new Vector3(1 + escalamiento / 10, 1 + escalamiento / 10, 1 + escalamiento / 10);
    }

    void getValues()
    {
        if (inputRotation.text != "")
        {
            rotation = int.Parse(inputRotation.text);
        }
        
        if (inputPosition.text != "")
        {
            posicion = int.Parse(inputPosition.text);
        }
        

        if (inputEscalamiento.text != "")
        {
            escalamiento = int.Parse(inputEscalamiento.text);
        }

        Debug.Log("get values");
    }


    public void rotar()
    {
        getValues();
        
        
    }
    public void trasladar()
    {
        getValues();
    }

    public void escalar()
    {
        getValues();
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
