using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObject : MonoBehaviour
{
    // Ball Object colors to determine a ball-object's value in game points.
    public enum BallColor {Red, Green, Blue, Golden};
    public BallColor ballColor;
    
    // Some values for internal usage.
    [HideInInspector]
    public Rigidbody rigidBody;
    [HideInInspector]
    public SphereCollider sphereCollider;
    [HideInInspector]
    public Transform objectTransform;
    [HideInInspector]
    public float startingWeight;
    [HideInInspector]
    public float currentWeight;

    // Audio, particle effects
    public AudioClip catchAudio;
    public GameObject catchEffect;

    public void Awake ()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        sphereCollider = this.GetComponent<SphereCollider>();
        objectTransform = this.GetComponent<Transform>();
        startingWeight = rigidBody.mass;
        currentWeight = rigidBody.mass;
    }

    public void Update ()
    {
        currentWeight = rigidBody.mass;
    }
}
