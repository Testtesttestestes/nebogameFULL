using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Tweens
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public class AwaitingReceiveDataTween : MonoBehaviour
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x5CC5", Offset = "0x5CC5", VA = "0x5CC5")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void UI_Tweens_AwaitingReceiveDataTween__OnDisable(undefined4 param1,undefined4 param2)
		
		{
		  UI_Tweens_AwaitingReceiveDataTween__OnEnable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x5CC6", Offset = "0x5CC6", VA = "0x5CC6")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void UI_Tweens_AwaitingReceiveDataTween__OnEnable(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_58;
		  undefined4 local_50;
		  undefined8 local_48;
		  undefined4 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b8cc == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Quaternion__Vector3__QuaternionOptions____
		              );
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLoops_Sequence___);
		    DAT_ram_00a5b8cc = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  if (DAT_ram_00a65d4a == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Quaternion_TypeInfo);
		    DAT_ram_00a65d4a = '\x01';
		  }
		  local_38 = **(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c);
		  local_30 = (*(undefined8 **)(UnityEngine_Quaternion_TypeInfo + 0x5c))[1];
		  local_10 = local_38;
		  local_8 = local_30;
		  UnityEngine_Transform__get_rotation(uVar1,&local_38,0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar1 = DG_Tweening_DOTween__To(0);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_14 = 0xc3340000;
		  local_40 = 0xc3340000;
		  local_1c = 0;
		  local_48 = 0;
		  uVar2 = DG_Tweening_ShortcutExtensions__DOLocalMoveZ(uVar2,&local_48,0.3,0,0);
		  uVar2 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar2,0.7,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Quaternion__Vector3__QuaternionOptions____
		                    );
		  DG_Tweening_TweenParams___cctor(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_20 = 0xc3b48000;
		  local_50 = 0xc3b48000;
		  local_28 = 0;
		  local_58 = 0;
		  uVar1 = DG_Tweening_ShortcutExtensions__DOLocalMoveZ(uVar1,&local_58,0.3,0,0);
		  DG_Tweening_TweenParams___cctor(uVar2,uVar1,0);
		  DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		            (*(undefined4 *)(param1 + 0x10),0xffffffff,0,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLoops_Sequence___);
		  return;
		}
		*/

		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x5CC7", Offset = "0x5CC7", VA = "0x5CC7")]
		private void Animate()
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x5CC8", Offset = "0x5CC8", VA = "0x5CC8")]
		public AwaitingReceiveDataTween()
		{
		}

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x10")]
		private Sequence _sequence;
	}
}
