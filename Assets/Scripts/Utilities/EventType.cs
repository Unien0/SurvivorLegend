public enum EventTypeI
{
    //事件的tag，需要有事件tag才能找到对应的事件
    //类似于电话号码，只需要添加新的号码就能进行对应的拨号
    command,
    Initialization,//初始化
    positionInitialization,//坐标初始化
    DungeonGeneratorStart,
    AfterWall,


}