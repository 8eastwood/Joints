using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _spawnPosition;

    private void Update()
    {
        if (_inputReader.IsSpawnKeyPressed)
        {
            SpawnProjectile(_projectilePrefab, _spawnPosition.position, Quaternion.identity);
        }
    }

    private void SpawnProjectile(GameObject projectilePrefab, Vector3 position, Quaternion rotation)
    {
        Instantiate(projectilePrefab, position, rotation);
    }
}