using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralTreeGeneration : MonoBehaviour
{
    public GameObject Tree;
    public int TreeAmount;
    public LayerMask Ground;
    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }
    void Generate()
    {
        for (int i = 0; i < TreeAmount; i++)
        {
            transform.position = new Vector3(Random.Range(-29f, 24f), transform.position.y, 0);
            RaycastHit2D RayHitPos;

            RayHitPos = Physics2D.Raycast(transform.position, Vector2.down * 1, 30f, Ground);
            Instantiate(Tree, RayHitPos.point, Quaternion.identity);
        }
    }

}
