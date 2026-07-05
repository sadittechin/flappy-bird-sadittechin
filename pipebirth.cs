using UnityEngine;

public class PipeCreaterScript : MonoBehaviour
{
    public GameObject pipebirth;
    public float spawnRate = 12f;
    private float timer = 0f;
    public float heightOffset = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            float randomY = Random.Range(lowestPoint, highestPoint);
            Instantiate(pipebirth,
                new Vector3(transform.position.x, randomY, transform.position.z),
                transform.rotation);
            timer = 0f;
        }
    }
}