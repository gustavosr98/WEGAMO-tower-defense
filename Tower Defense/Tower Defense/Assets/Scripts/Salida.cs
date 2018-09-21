using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour {

    [SerializeField] GameObject DustEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy( collision.gameObject );
        GameObject dust = Instantiate(DustEffect, transform.position ,  transform.rotation );
        Destroy(dust, 1f);
    }
}
