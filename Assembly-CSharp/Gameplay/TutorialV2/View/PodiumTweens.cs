using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	public class PodiumTweens : MonoBehaviour
	{
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046B")]
		public Transform LeftPodium
		{
			[Token(Token = "0x6001931")]
			[Address(RVA = "0x6AD0", Offset = "0x6AD0", VA = "0x6AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046C")]
		public Transform RightPodium
		{
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x6AD1", Offset = "0x6AD1", VA = "0x6AD1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x6AD2", Offset = "0x6AD2", VA = "0x6AD2")]
		public void PlayFirst()
		{
		/* --- GHIDRA: <PlayFirst>b__8_2 ---
		void Gameplay_TutorialV2_View_PodiumTweens___PlayFirst_b__8_2
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2[1];
		  local_10 = *param2;
		  UnityEngine_SpriteRenderer__get_color(*(undefined4 *)(param1 + 0x1c),&local_10,0);
		  return;
		}
		*/

		/* --- GHIDRA: <PlayFirst>b__8_1 ---
		void Gameplay_TutorialV2_View_PodiumTweens___PlayFirst_b__8_1
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  UnityEngine_SpriteRenderer__set_size(&local_10,*(undefined4 *)(param2 + 0x1c),0);
		  param1[1] = local_8;
		  *param1 = local_10;
		  return;
		}
		*/

		/* --- GHIDRA: <PlayFirst>b__8_0 ---
		void Gameplay_TutorialV2_View_PodiumTweens___PlayFirst_b__8_0
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2[1];
		  local_10 = *param2;
		  UnityEngine_SpriteRenderer__get_color(*(undefined4 *)(param1 + 0x18),&local_10,0);
		  return;
		}
		*/

		/* --- GHIDRA: PlayFirst ---
		void Gameplay_TutorialV2_View_PodiumTweens__PlayFirst(int param1,undefined4 param2)
		
		{
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(param1 + 0x10),-435.0,1.0,0,0);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(param1 + 0x14),435.0,1.0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x6AD3", Offset = "0x6AD3", VA = "0x6AD3")]
		public void PlaySecond()
		{
		/* --- GHIDRA: PlaySecond ---
		void Gameplay_TutorialV2_View_PodiumTweens__PlaySecond(int param1,undefined4 param2)
		
		{
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(param1 + 0x10),-362.0,1.0,0,0);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(param1 + 0x14),362.0,1.0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x6AD4", Offset = "0x6AD4", VA = "0x6AD4")]
		public void PlayThird()
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x6AD5", Offset = "0x6AD5", VA = "0x6AD5")]
		public PodiumTweens()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_View_PodiumTweens___ctor(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  UnityEngine_SpriteRenderer__set_size(&local_10,*(undefined4 *)(param2 + 0x18),0);
		  param1[1] = local_8;
		  *param1 = local_10;
		  return;
		}
		*/

		}

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _leftTransform;

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _rightTransform;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer _leftSprite;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SpriteRenderer _rightSprite;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RightPodium ---
		void Gameplay_TutorialV2_View_PodiumTweens__get_RightPodium(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a583a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOGetter_Color__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_Color__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_0__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_1__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_2__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_3__);
		    DAT_ram_00a583a9 = '\x01';
		  }
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(param1 + 0x10),-362.0,1.0,0,0);
		  DG_Tweening_ShortcutExtensions__DOLocalMove(*(undefined4 *)(param1 + 0x14),362.0,1.0,0,0);
		  uVar1 = unnamed_function_1417(DG_Tweening_Core_DOGetter_Color__TypeInfo);
		  UnityEngine_UIElements_CustomStyleProperty___Il2CppFullySharedGenericType___set_name
		            (uVar1,param1,Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_0__,0);
		  uVar2 = unnamed_function_1417(DG_Tweening_Core_DOSetter_Color__TypeInfo);
		  DG_Tweening_Core_DOGetter___Il2CppFullySharedGenericType___Invoke
		            (uVar2,param1,Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_1__,0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  DG_Tweening_DOTween__ToAxis(uVar1,uVar2,1.0,1.0,0);
		  uVar1 = unnamed_function_1417(DG_Tweening_Core_DOGetter_Color__TypeInfo);
		  UnityEngine_UIElements_CustomStyleProperty___Il2CppFullySharedGenericType___set_name
		            (uVar1,param1,Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_2__,0);
		  uVar2 = unnamed_function_1417(DG_Tweening_Core_DOSetter_Color__TypeInfo);
		  DG_Tweening_Core_DOGetter___Il2CppFullySharedGenericType___Invoke
		            (uVar2,param1,Method_Gameplay_TutorialV2_View_PodiumTweens__PlayFirst_b__8_3__,0);
		  DG_Tweening_DOTween__ToAxis(uVar1,uVar2,1.0,1.0,0);
		  return;
		}
		*/

}
