using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Pipe Spawner Settings")]
    [SerializeField] private float spawnTime = 8.5f;
    [SerializeField, Range(1, 10)] private float spawnHeight = 2;
    private float timer = 0;

    public GameObject pipe;

    // spawns new pipe walls with minor differences in height position each time
    void Update()
    {
        if (timer > spawnTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-spawnHeight, spawnHeight), 0);

            Destroy(newpipe, 16);

            timer = 0;
        }

        timer += Time.deltaTime;

        switch (spawnTime)
        {
            case 50:
                spawnTime = 7f;
                break;

            case 110:
                spawnTime = 6f;
                break;

            case 160:
                spawnTime = 7f;
                break;

            case 220:
                spawnTime = 5f;
                break;

            default:
                spawnTime = 8.5f;
                break;
        }

    }
}
