using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundObjectManager : MonoBehaviour
{
    public GameObject _arbolPixel1;
    public GameObject _arbolPixel2;
    public GameObject _nubePixel1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BackrgoundWave());
    }

    IEnumerator BackrgoundWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            spawn();
        }
    }

    private void spawn()
    {
        int number = Random.Range(0, 100);
        if (number >= 35 && number < 85)
        {
            GameObject backgroundObject = Instantiate(_arbolPixel1) as GameObject;
        }
        else if (number >= 85 && number < 90)
        {
            GameObject backgroundObject = Instantiate(_arbolPixel2) as GameObject;
        }
        else if (number >= 90 && number < 95)
        {
            GameObject backgroundObject = Instantiate(_nubePixel1) as GameObject;
            backgroundObject.transform.position = new Vector3(backgroundObject.transform.position.x, Random.Range(1.2f, 1.5f));
        }
        else
            new WaitForSeconds(1f);
    }
}
