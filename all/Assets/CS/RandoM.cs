using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandoM: MonoBehaviour
{
    public RawImage img;
    public List<Texture> textures_list = new List<Texture>();
    // Start is called before the first frame update
    void Start()
    {
        img = GameObject.Find("DisplayImage").GetComponent<RawImage>();
        read_img(5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void read_img(int n)
    {
        Texture tmp;
        for (int i = 1; i < n + 1; i++)
        {
            tmp = Resources.Load("img/" + i) as Texture;
            textures_list.Add(tmp);
        }

    }

    public void ChangeImage()
    {
        int random = Random.Range(1, textures_list.Count);
        Debug.Log("ƒ‰ƒ“ƒ_ƒ€’l‚Í" + random);
        img.texture = textures_list[random];
    }
}
