using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
// using GameCreator.Core;
using UnityEngine;

//
// public class FarmActionCharacterCollectGatherable : IAction
// {
//     //Trong này se có một số thứ sau :
//
//     public override bool InstantExecute(GameObject target, IAction[] actions, int index)
//     {
//         return false;
//     }
//
//     //ddAAY LA LOAI ACTION CHO LAM XONG MS TIEP TUC
//     public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
//     {
//         //Cho //Nch ddoaj nay rat phujc tap cho viejc chay xong action
//         yield return StartWalk();
//     }
//
//
// // public override void Execute()
//     // {
//
//     //     //this.StartWalk();
//     // }
//     //Chủ yếu là hàm chạy di chuyển tới sau đó thì chạy TI ĐIỂM VỊ TRÍ Của thằng rác đó rồi setdestination
//
//
//     private IEnumerator StartWalk()
//     {
//         // if ((this._currencyService.GetCurrency(currency: Currency.Energy)) >= 1)
//         // {
//         //     //Thử xem thử năng lượng đủ để giải quyết thằng gatherable không đã:::nếu k đủ thì complete luôn:
//         //     this._character.SetDestination(destination: new UnityEngine.Vector3(), onDestinationReached: null,
//         //         warpInsteadOfWalkDistance: val_7.x);
//         //     this._walking = true;
//         //     return;
//         // }
//         yield return new WaitForEndOfFrame();
//     }
//
//
//     //sau đó thì truyền callback di chuyển xong vào character destination và chạy::khi chạy
//     private void OnAgentMoveCompleted()
//     {
//         //Quay nhân vật nhìn vào vị trí cây
//         //this._character.LookAt(worldPosition:  new UnityEngine.Vector3());
//
//         //Lấy niatmion của thằng này để chạy và từ đó chạy animancer với aniamtion và có callback để xong thì sẽ bắt đầu dọn rác:
//         //Animancer.AnimancerState val_9 = this._character.Play(clipName:  -701893936);
//
//         //this._animancerState = this._character;
//         //int val_12 = this._animancerState.Add(normalizedTime:  val_7.x, callback:
//         //typeof(FarmMatch.Map.GatherableAnimationCollection).__il2cppRuntimeField_14);
//     }
//
//
//     //Chạy animation thu hoạch xong thì sẽ tới 
//     public void OnGatherAnimationEnd()
//     {
//         //Tạo gọi tới thằng gatherable đó và sẽ hủy nó đi và tạo hiệu ứng
//     }
// }