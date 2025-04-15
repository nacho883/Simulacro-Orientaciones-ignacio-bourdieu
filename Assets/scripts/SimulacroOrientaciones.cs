using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroOrientaciones : MonoBehaviour
{
    public string NombreAluumno;
    public int AñoEscolar;
    public string orientacion;
    // Start is called before the first frame update

    void Start()
    {
        if(NombreAluumno == "")
        {
            Debug.Log("el nombre no puede estar vacio");
        }
        if ( AñoEscolar < 5 || AñoEscolar > 1)
        {
            Debug.Log("error, Aún estás en el ciclo básico");
        }
        if (orientacion != "D" && orientacion != "M" && orientacion != "T" && orientacion != "H" && orientacion != "G"){
            Debug.Log(" Solo puede ingresar,T,D,G,M o H ");
        }

        Debug.Log("muchas gracias" + NombreAluumno + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
