using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int NivelHambre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void prueba_alimento (int ValorAlimenticio) 
    {
        NivelHambre -= ValorAlimenticio;
        if (NivelHambre <= 0)
        {
            NivelHambre = 0;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        AlimentoScript alimento;
        alimento = other.GetComponent<AlimentoScript>();
        if (alimento)
        {
            prueba_alimento(alimento.ValorAlimenticio);
            Destroy(other.gameObject);
        }
    }
}
