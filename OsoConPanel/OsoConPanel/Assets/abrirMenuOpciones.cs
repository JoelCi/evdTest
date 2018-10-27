using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirMenuOpciones : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Botones.BOTON_R1) || Input.GetKeyDown(KeyCode.T))
        {
            var script = GetComponent<LoadScenePausa>();
            script.enabled = true;
        }

    }
}
