using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject particleBluePrint;
    private GameObject particle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnParticle(Vector3 pos)
    {
        particle = Instantiate(particleBluePrint) as GameObject;
        particle.transform.position = pos;
        Destroy(particle, 2f);
    }
}
