using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculPipaScript : MonoBehaviour
{
    public GameObject pipa;
    public float spawnRate = 2;
    private float timer = 0;
    private float heightOffset = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipa();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }else{
           spawnPipa();
        }
    }

    void spawnPipa(){
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Instantiate(pipa, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint), 0), transform.rotation);
        timer = 0;
    }
}
