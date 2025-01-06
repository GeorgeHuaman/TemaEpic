using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageUi : MonoBehaviour
{
    public List<Images> images = new List<Images>();

    private void Start()
    {
        foreach (Images image in images)
        {
            image.name = image.imageUi.name;
        }
    }
    public void OpenWordUi(string name)
    {
        foreach (Images image in images)
        {
            if (name == image.name)
            {
                image.imageUi.SetActive(true);
                image.imageUi.GetComponent<ImageUiActive>().imageWorld = image.imageWorld;
            }
        }
    }

    [System.Serializable]
    public class Images
    {
        public string name;
        public GameObject imageWorld;
        public GameObject imageUi;
    }
}
