using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZ : MonoBehaviour
{
    public GameObject prefabZ;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenPrefabZ());
    }

    private IEnumerator GenPrefabZ()
    {
        yield return new WaitForSeconds(1f);

        while (true)
        {
            for (int i = 0; i < 3; i++)
            {
                Debug.Log("Instantiate"+i);
                GameObject z = Instantiate(prefabZ);
                z.transform.SetParent(this.transform, false);
                yield return new WaitForSeconds(0.3f);
            }
            Debug.Log("WaitForSeconds");
            yield return new WaitForSeconds(4f);
        }
        
    }
}
