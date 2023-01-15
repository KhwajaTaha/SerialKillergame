using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour
{
    public bool open = false;
    public float dooropenangle = 90f;
    public float doorcloseangle = 0f;
    public float smooth = 2f;
    public AudioSource dooropen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Changedoorstate()
    {
        open = !open;
        dooropen.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, dooropenangle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorcloseangle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}
