//using System;
//using System.Linq;
//using UnityEngine;
//using UnityEngine.UI;

//namespace JellyGarden.Scripts.Targets
//{
//    public class TargetIcon : MonoBehaviour
//    {
//        public Image imageRenderer;
//        public Text textObj;
//        public int count;
//        public Sprite[] checkUncheck;
//        public Image checkObject;
//        private TargetObject targetObject;

//        public TargetObject target
//        {
//            get
//            {
//                if (targetObject == null)
//                {
//                    if (LevelManager.Instance != null)
//                        targetObject = LevelManager.Instance.targetObject.First(i => i.icon.name == imageRenderer.sprite.name);
//                }
//                return targetObject;
//            }
//            set => targetObject = value;
//        }

//        public void SetTarget(TargetObject target)
//        {
//            checkObject.gameObject.SetActive(false);
//            imageRenderer.sprite = target.icon;
//            count = target.targetCount;
//            textObj.text = target.targetCount.ToString();
//            if(target.type == Target.COLLECT)
//            {
//                textObj.GetComponent<TargetText>().TextUpdate = GetCount;
//            }
//        }

//        private void Update()
//        {
//            if(target?.Done() ?? false) SetCheck();
//            else if(LevelManager.Instance.gameStatus == GameState.PreFailed || LevelManager.Instance.gameStatus == GameState.GameOver) SetFailed();
//            else if((!target?.Done() ?? false) && checkObject.gameObject.activeSelf) SetContinue();
//        }

//        void SetCheck()
//        {
//            checkObject.sprite = checkUncheck[0];
//            checkObject.gameObject.SetActive(true);
//            textObj.gameObject.SetActive(false);
//        }
        
//        void SetFailed()
//        {
//            checkObject.sprite = checkUncheck[1];
//            checkObject.gameObject.SetActive(true);
//            textObj.gameObject.SetActive(false);
//        }
        
//        void SetContinue()
//        {
//            checkObject.gameObject.SetActive(false);
//            textObj.gameObject.SetActive(true);
//        }
//        string GetCount() => target?.GetCount().ToString();
//    }
//}