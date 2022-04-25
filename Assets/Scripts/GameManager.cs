using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]public GameObject avatar;
    Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnAvatar()
    {
        Instantiate(avatar, cameraTransform.position + cameraTransform.forward, Quaternion.identity);
    }
}
