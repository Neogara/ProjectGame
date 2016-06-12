

public enum TypeGameObject { Ground, Items, Wall, Ememy, Used, Npc, Hero ,UI} //возможные типы обьектов 

public enum GroundType { Water, Road, Dirt, Grass, DeadZone } // типы пола 
public enum ItemsType { Weapon, Armor, Posion, QuestItem, Garbage } //типы Вещей
public enum EnemyType { Quest, Boss, Normal } //Типы врагов
public enum UsedType { Chest, Door, Button, Stairs, Lever } //юзабельные типы 
public enum HeroType { Knight, Mage, Rogue } //типы персонажей  
public enum NpcType { Merchant , Quest , Crowd , Blacksmitch ,Alchemist} // типы нпс  
public enum UIType { Bark , InterfaceElement ,} // типы Интерфейса

public enum TriggerType { OnEnter, OnState }// типы триггеров 