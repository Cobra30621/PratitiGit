﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace InventorySystem {
    [System.Serializable]
    public class Item {
        public ItemName itemName;
        public int quantity;

        public Item(ItemName iN , int q)
        {
            itemName = iN;
            quantity = q;
        }
        public Item()
        {

        }

        public enum ItemName {
            藍莓 = 0,
            黃油,
            巧克力,
            雞蛋,
            快樂草,
            牛奶,
            堅果,
            拴繩,
            糖,
            布丁,
            巧克力蛋糕
        }

        public string ItemInfo(Item item){
            switch(item.itemName)
            {
                default:
                case ItemName.藍莓: return 
                        "a 藍莓";
                case ItemName.黃油: return 
                        "a 黃油";
                case ItemName.巧克力:return 
                        "a 巧克力";
                case ItemName.雞蛋: return 
                        "an 雞蛋";
                case ItemName.快樂草: return 
                        "a 快樂草";
                case ItemName.牛奶: return 
                        "a 牛奶";
                case ItemName.堅果: return 
                        "a 堅果";
                case ItemName.糖: return 
                        "a 糖";
                case ItemName.布丁: return 
                        "a 布丁";
                case ItemName.巧克力蛋糕:return
                        "a 巧克力蛋糕";
                case ItemName.拴繩:return
                        "a 拴繩";
            }
        }

        public static int ItemType(Item item)
        {
            switch (item.itemName)
            {
                case ItemName.藍莓:
                case ItemName.黃油:
                case ItemName.巧克力:
                case ItemName.雞蛋:
                case ItemName.快樂草:
                case ItemName.牛奶:
                case ItemName.堅果:
                case ItemName.糖:
                    return 0;
                case ItemName.巧克力蛋糕:
                case ItemName.布丁:
                    return 1;
                case ItemName.拴繩 :
                    return 2;
                default:
                    return -1;
            }
        }

        public Sprite ItemSprite(Item item) {
            switch(item.itemName) {
                default:
                case ItemName.藍莓: return Resources.Load<Sprite>("ItemAssets/藍莓");
                case ItemName.黃油: return Resources.Load<Sprite>("ItemAssets/黃油");
                case ItemName.巧克力: return Resources.Load<Sprite>("ItemAssets/巧克力");
                case ItemName.雞蛋: return Resources.Load<Sprite>("ItemAssets/雞蛋");
                case ItemName.快樂草: return Resources.Load<Sprite>("ItemAssets/快樂草");
                case ItemName.牛奶: return Resources.Load<Sprite>("ItemAssets/牛奶");
                case ItemName.糖: return Resources.Load<Sprite>("ItemAssets/糖");
                case ItemName.堅果: return Resources.Load<Sprite>("ItemAssets/堅果");
                case ItemName.拴繩: return Resources.Load<Sprite>("ItemAssets/拴繩");
                case ItemName.巧克力蛋糕: return Resources.Load<Sprite>("ItemAssets/巧克力蛋糕");
                case ItemName.布丁: return Resources.Load<Sprite>("ItemAssets/布丁");
            }
        }
    }    
}
