using UnityEngine;

public class rockSpawner1 : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject rockPrefab;  
    public Transform target;      
    public float spawnInterval = 2f; 
    public float rockSpeed = 5f;  

    private void Start()
    {
        // Start spawning rocks at regular intervals
        InvokeRepeating(nameof(SpawnRock), 0f, spawnInterval);
    }

    private void SpawnRock()
    {
       
        GameObject rock = Instantiate(rockPrefab, transform.position, transform.rotation);

        // Attach a RockMover component to the rock to handle movement
        RockMover mover = rock.AddComponent<RockMover>();
        mover.Initialize(target, rockSpeed);
    }
}

public class RockMover : MonoBehaviour
{
    private Transform target;
    private float speed;

    public void Initialize(Transform target, float speed)
    {
        this.target = target;
        this.speed = speed;
    }

    private void Update()
    {
        if (target == null) return;

        // Move the rock towards the target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

    }

    
}
