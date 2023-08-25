using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using UnityEngine;

// public class FarmActionCharacterShowSpeechBalloon : IAction
// {
//     //Event phát data cho //PHÁT SỰ KIỆN SHOW VÀ HIDE TRONG NÀY CÓ DATA
//     //private ShowSpeechBalloonWithTextEvent _showSpeechBalloonWithTextEvent;
//     //private SpeechBalloonWithTextHideEvent _speechBalloonWithTextHideEvent;
//     
//     private int _characterId;
//     private int _showedCount;
//     //DỤỰA VÀO CÁI NÀY LẤY TEXT Ở TRONG TRANSIION NHƯNG GAME K CẦN THÌ BỎ QUA LÀM TRỰC TIẾP xong thì NGHE SỰ KIỆN BÊN THẰNG SỰ KIỆN HIDE KIA ĐỂ XÀI
//     private string[] _keys;
//
//     public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
//     {
//         yield return 0;
//     }
//
//     public override bool InstantExecute(GameObject target, IAction[] actions, int index)
//     {
//         return false;
//     }
//
//     //NGHE SỰ KIỆN TEXT HIDE ĐỂ MÀ XÉT CHUYỂN SANG NEXT 
//     private void OnSpeechBalloonWithTextHide()
//     {
//         //NẾU CHARACTERID KHÁC THẰNG NÀY THÌ SẼ RETURN
//         // if(data.CharacterId != this._characterId)
//         // {
//         //     return;
//         // }
//
//         //SỐ LƯỢNG SHOWEDCOUNT NẾU MAX THÌ RETURN COMPELTE K THÌ CỨ INVOKE RA DATA
//         //....
//     }
//
//     public override void Stop()
//     {
//         base.Stop();
//         //this.Complete();
//     }
// }