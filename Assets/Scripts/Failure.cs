using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Failure : MonoBehaviour
{
    [SerializeField]
    private Menu menu;

    private void OnTriggerEnter(Collider other)
    {
        menu.ToRestartMenu();
        other.GetComponent<Sphere>().ToStartPosition();
    }
}
