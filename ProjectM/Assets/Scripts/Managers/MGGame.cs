using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MGGame : MonoSingleton<MGGame>
{
    // public MGTeam _gTeamManager;
    // public MGStage _gStageManager;
    // public MGMinion _gMinionManager;
    // public MGHero.MGHero _gHeroManager;

    List<CONEntity> heroConList = new List<CONEntity>();
    public List<CONEnemy> enemyConList = new List<CONEnemy>();

    public List<Image> enemyHpBars = new List<Image>();

    public Camera mainCam;

    //public Image hpPrefab;
    void Awake()
    {
        GameSceneClass.gMGGame = this;

        // GameSceneClass._gColManager = new MGUCCollider2D();

        // _gTeamManager = new MGTeam();
        // _gStageManager = new MGStage();
        // _gMinionManager = new MGMinion();
        // _gHeroManager = new MGHero.MGHero();

        // Global._gameStat = eGameStatus.Playing;

        GameObject.Instantiate(Global.prefabsDic[ePrefabs.MainCamera]);

        heroConList.Clear();
    }

    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();    
    }
    
    void OnEnable()
    {
        // GamePlayData.init();
        // MGGameStatistics.instance.initData();
    }
    public void SpawEnemy(Vector2 position, EnemyType type)
    {
        //GameObject enemy = GameObject.Instantiate(Global.prefabsDic[ePrefabs.EnemyZombie]);
        //enemy.
        GameObject enemy = MGEnemyPool.Instance.Get(type);
        enemy.transform.position = position;


        enemyConList.Add(enemy.GetComponent<CONEnemy>());
        CONEntity go =  GameSceneClass.gMGPool.CreateObj(ePrefabs.UIHpBar, position);
        go.transform.SetParent(MGScene.Instance.rootTrm);
        enemyHpBars.Add(go.GetComponent<Image>());


    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CONEntity heroCon = GameSceneClass.gMGPool.CreateObj(ePrefabs.HeroMan, Random.insideUnitCircle);
            heroConList.Add(heroCon);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SpawEnemy(Vector2.zero, EnemyType.NORMAL);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (heroConList.Count > 0)
            {
                heroConList[heroConList.Count - 1].SetActive(false);
                heroConList.RemoveAt(heroConList.Count - 1);
            }

        }



        // if (Global._gameStat == eGameStatus.Playing)
        // {
        //     if (Global._gameMode == eGameMode.Collect)
        //     {
        //         _gStageManager.UpdateCollect();
        //         _gMinionManager.UpdateCollect();
        //     }
        //     else if(Global._gameMode == eGameMode.Adventure)
        //     {
        //         _gStageManager.UpdateAdventure();
        //         _gMinionManager.UpdateAdventure();
        //         _gHeroManager.UpdateAdventure();
        //     }
        // }
    }

    void LateUpdate()
    {
        // GameSceneClass._gColManager.LateUpdate();
        HpBar();
    }

    public void HpBar()
    {
        if (enemyHpBars.Count != 0 && enemyConList.Count != 0)
        {
            for (int i = 0; i < enemyHpBars.Count; i++)
            {
                if (enemyConList[i].HpPercent() == 1)
                {
                    enemyHpBars[i].gameObject.SetActive(false);
                }
                else
                {
                    RectTransform rect = enemyHpBars[i].GetComponent<RectTransform>();
                    enemyHpBars[i].transform.position = mainCam.WorldToScreenPoint(enemyConList[i].gameObject.transform.position + new Vector3(0, -1f, 0));
                    rect.localScale = new Vector3(enemyConList[i].HpPercent(), 1, 1);
                }
            }
        }


    }

}
