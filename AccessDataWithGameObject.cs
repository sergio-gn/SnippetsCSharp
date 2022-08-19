PlayerController playerController;
public GameObject player;

void Awake()
{
  playerController = player.GetComponent<PlayerController>();
}

void Update()
{
  PlayerController.isBool = true;
}
