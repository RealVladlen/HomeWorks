using UnityEngine;

public class GeneratorChessBoard : MonoBehaviour
{
    [SerializeField] private GameObject _prefabs;

    [SerializeField] private Material _whiteMaterials, _blackMaterials;

    [SerializeField] private int _lenght = 10;

    private void Start()
    {
        for (int i = 0; i < _lenght; i++)
        {
            for (int j = 0; j < _lenght; j++)
            {
                GameObject box = Instantiate(_prefabs, new Vector3(i, 0, j), Quaternion.identity);

                if ((i + j) % 2 == 0)
                    box.GetComponent<Renderer>().material = _whiteMaterials;
                else
                    box.GetComponent<Renderer>().material = _blackMaterials;
            }
        }
    }
}
