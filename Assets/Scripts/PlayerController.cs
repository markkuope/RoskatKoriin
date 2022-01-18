using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool canMove = true;

    [SerializeField]
    float maxPos; // maksimikohta johon voidaan liikkua


    [SerializeField]
    float moveSpeed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }

    }

    private void Move()
    {

        float inputX = Input.GetAxis("Horizontal"); // vasen- ja oikea nuoliarvo talteen

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        // transform.position +=  eli positioon lis�t��n arvoa
        // Vector3.right eli liikutaan oikealle
        // inputX  nuolin�pp�inten antama arvo, joko +1 tai -1
        //  moveSpeed itse annettu vakioarvo nopeudelle
        // Time.deltaTime liikkeest� tulee tasaista, nopeus ei riipu kehysten vaihtumisnopeudesta

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);

        //  Mathf.Clamp rajoittaa liikkeen arvon annettuihin kohtiin, joka talletetaan muuttujaan xPos

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

        // Playerin paikan x -arvo rajoitetaan XPos -arvoon, y ja z pysyv�t ennallaan

    }


}