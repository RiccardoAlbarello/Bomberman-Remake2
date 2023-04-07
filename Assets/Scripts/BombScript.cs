using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public GameObject colliderCubo;
    public float timerBomb = 3f;

    public MeshRenderer mR;

    public GameObject prefab;

    public GameObject prefabSopra;
    public GameObject prefabSotto;
    public GameObject prefabDestra;
    public GameObject prefabSinistra;

    public Transform barrelBomb;

    public Transform spawnerSopra;
    public Transform spawnerSotto;
    public Transform spawnerDestra;
    public Transform spawnerSinistra;

    public bool esplosione = true;

    public ExplosionSopra eSopra;
    public ExplosionSottp eSotto;
    public ExplosionDestra eDestra;
    public EplosionSinistra eSinistra;
    
    
    // Start is called before the first frame update
    void Start()
    {
        colliderCubo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy(gameObject, 3);
        
        if(esplosione == true)
        {
        timerBomb -= Time.deltaTime;

        }
        SpawnerAvanti();
        SpawnerDietro();
        SpawnerDx();
        SpawnerSx();

        if (timerBomb <= 0 && esplosione == true)
        {
            mR.enabled = false;
            esplosione = false;
            Debug.Log("Esplosione");
            //var spawnedBullet = Instantiate(prefab, barrelBomb.position, barrelBomb.rotation);


        }



        
    }

    private void OnTriggerExit(Collider other)
    {
            if(other.CompareTag("Player"))
            {
            colliderCubo.SetActive(true);
            
            }
    }

    void SpawnerAvanti()
    {
        if (timerBomb <= 0 && esplosione == true && eSopra.explosionSopra == true)
        {
            
            //esplosione = false;
            Debug.Log("Esplosione");
            var spawnedBullet = Instantiate(prefabSopra, spawnerSopra.position, spawnerSopra.rotation);


        }
    }

    void SpawnerDietro()
    {
        if (timerBomb <= 0 && esplosione == true && eSotto.explosionSotto == true)
        {
            
            //esplosione = false;
            Debug.Log("Esplosione");
            var spawnedBullet = Instantiate(prefabSotto, spawnerSotto.position, spawnerSotto.rotation);


        }
    }

    void SpawnerDx()
    {
        if (timerBomb <= 0 && esplosione == true && eDestra.explosionDestra == true)
        {
            
            //esplosione = false;
            Debug.Log("Esplosione");
            var spawnedBullet = Instantiate(prefabDestra, spawnerDestra.position, spawnerDestra.rotation);


        }
    }

    void SpawnerSx()
    {
        if (timerBomb <= 0 && esplosione == true && eSinistra.explosionSinistra == true)
        {
            
            //esplosione = false;
            Debug.Log("Esplosione");
            var spawnedBullet = Instantiate(prefabSinistra, spawnerSinistra.position, spawnerSinistra.rotation);


        }
    }
}
