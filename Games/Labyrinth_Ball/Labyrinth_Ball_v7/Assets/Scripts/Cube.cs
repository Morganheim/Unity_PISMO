using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public AudioClip cubeSound;

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(cubeSound, transform.position);
    }
    private void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }
}
