using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public List<Material> materialList;
    public int objectsToGenerate;
    public float delay = 3.0f;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    private System.Random random = new System.Random();

    void Start()
    {
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        // obliczenie pozycji aby obiekty generowa�y si� zgodnie z wsp�rz�dnymi obiektu do kt�rego przypisany jest skrypt
        // oraz w kwadracie o boku r�wnym po�owie objekt�w do wygenerowania
        int startplaneX = (int)transform.position.x - objectsToGenerate / 2;
        int startplaneZ = (int)transform.position.z - objectsToGenerate / 2;
        List<int> pozycje_x = new List<int>(Enumerable.Range(startplaneX, objectsToGenerate).OrderBy(x => Guid.NewGuid()).Take(objectsToGenerate));
        List<int> pozycje_z = new List<int>(Enumerable.Range(startplaneZ, objectsToGenerate).OrderBy(x => Guid.NewGuid()).Take(objectsToGenerate));

        for (int i = 0; i < objectsToGenerate; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 1, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo�ano coroutine");
        foreach (Vector3 pos in positions)
        {
            SetMaterial(this.block);
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }

    void SetMaterial(GameObject block)
    {
        Renderer renderer = block.GetComponent<Renderer>();
        renderer.material = materialList[random.Next(materialList.Count)];
    }
}
