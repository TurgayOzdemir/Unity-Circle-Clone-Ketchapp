using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject lastLineObject;
    [SerializeField] private GameObject linePrefab;

    [SerializeField] private float spawnTimer;

    private GameObject newLineObject;

    void Start()
    {
        StartCoroutine(nameof(createNewLineObject));
    }
    private IEnumerator createNewLineObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimer);
            newLineObject = Instantiate(linePrefab, lastLineObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Transform>().position, transform.rotation);
            lastLineObject = newLineObject;
        }
    }


}
