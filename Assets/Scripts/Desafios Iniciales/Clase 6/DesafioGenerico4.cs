using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesafioGenerico4 : MonoBehaviour
{

    public float tempo = 5;

    public float restTempo = 5;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {

            Activar();

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            Desactivar();

        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            Resetear();

        }
    }

    private void Activar()
    {
        while (tempo > 0)   //Busque la sintaxis porque recordé que en JS teníamos estos loops, el ejercicio es re-hecho igual! Y ahora funcionando
        {

            Debug.Log("Tiempo restante: " + tempo);

            tempo -= Time.deltaTime;

        }
        Desactivar();

    }

    private void Desactivar()
    {

        tempo = 0;

        Debug.Log("¡Desactivado! Tiempo restante: " + tempo);

    }

    private void Resetear()
    {

        tempo = restTempo;

        Debug.Log("¡Reset! Tiempo restante: " + tempo);

        Activar();

    }
}
