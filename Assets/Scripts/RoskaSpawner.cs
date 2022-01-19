using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoskaSpawner : MonoBehaviour
{
    [SerializeField]
    float maxX;  // spawnausalueen max X arvo

    public GameObject[] Roskat; // Taulukko, johon pistet‰‰n peliss‰ k‰ytetyt roskat



    // Start is called before the first frame update
    void Start()
    {
        SpawnRoska();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRoska()
    {
        int rand = Random.Range(0, Roskat.Length);
        //Random.Range antaa satunnaisen numeron v‰lill‰ 0 ja Roskat.Length  
        // Roskat.Length  on taulukon koko
        //satunnainen numero talletaan rand ñ muuttujaan

        float randomX = Random.Range(-maxX, maxX); // satunnainen position-arvo  +-maxX arvojen v‰liss‰

        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        // uusi Vector3 tyyppinen muuttuja randomPos
        // vain X -positio on satunnainen, y ja z eiv‰t muutu
                     
        Instantiate(Roskat[rand], randomPos, transform.rotation);
        //  Instantiate(Roskat[rand],  synnytt‰‰  satunnaisen roskan 
        //  roska syntyy paikkaan transform.position
        //  roskan rotaatio on transform.rotation

    }


}
