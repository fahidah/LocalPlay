using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject avatar;
    Transform cameraTransform;
    bool singleAvatar = true;
   

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;

        
    }

    // Update is called once per frame

    public void SpawnAvatar()
    {
        if (singleAvatar)
        {
            Instantiate(avatar, cameraTransform.position + cameraTransform.forward, Quaternion.identity);
            singleAvatar = false;
        }
    }
}
