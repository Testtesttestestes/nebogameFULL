using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public class TutorialGameLeftPlayerAnimation : MonoBehaviour
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x6AE0", Offset = "0x6AE0", VA = "0x6AE0")]
		private void BattleToIdleAnimationCompleteEvent(GameAnimationView animComponent)
		{
		/* --- GHIDRA: BattleToIdleAnimationCompleteEvent ---
		void Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation__BattleToIdleAnimationCompleteEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583ae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_IdleToBattleAnimationCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_20484);
		    DAT_ram_00a583ae = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_GameAnimationView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_IdleToBattleAnimationCompleteEvent__
		             ,0);
		  AssetContent_GameAnimationView__add_AnimationCompleteEvent(param2,param1_00,0);
		  *(undefined1 *)(param2 + 0x45) = 1;
		  AssetContent_GameAnimationView__OnDestroy(param2,StringLiteral_20484,0);
		  return;
		}
		*/

		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x6AE1", Offset = "0x6AE1", VA = "0x6AE1")]
		private void IdleToBattleAnimationCompleteEvent(GameAnimationView animComponent)
		{
		/* --- GHIDRA: IdleToBattleAnimationCompleteEvent ---
		void Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation__IdleToBattleAnimationCompleteEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int local_4;
		  
		  if (DAT_ram_00a583af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_GameAssetViewSpriteRenderer___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_IdleToBattleAnimationCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_24508);
		    DAT_ram_00a583af = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (param1,&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_GameAssetViewSpriteRenderer___);
		  if (iVar1 != 0) {
		    param1_01 = *(undefined4 *)(local_4 + 0x14);
		    param1_00 = unnamed_function_1417(System_Action_GameAnimationView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_IdleToBattleAnimationCompleteEvent__
		               ,0);
		    AssetContent_GameAnimationView__remove_AnimationReadyEvent(param1_01,param1_00,0);
		    iVar1 = *(int *)(local_4 + 0x14);
		    *(undefined1 *)(iVar1 + 0x45) = 0;
		    AssetContent_GameAnimationView__OnDestroy(iVar1,StringLiteral_24508,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x6AE2", Offset = "0x6AE2", VA = "0x6AE2")]
		public void ToBattle()
		{
		/* --- GHIDRA: ToBattle ---
		void Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation__ToBattle
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int local_4;
		  
		  if (DAT_ram_00a583b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_GameAssetViewSpriteRenderer___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_BattleToIdleAnimationCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_20487);
		    DAT_ram_00a583b0 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (param1,&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_GameAssetViewSpriteRenderer___);
		  if (iVar1 != 0) {
		    param1_01 = *(undefined4 *)(local_4 + 0x14);
		    param1_00 = unnamed_function_1417(System_Action_GameAnimationView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_BattleToIdleAnimationCompleteEvent__
		               ,0);
		    AssetContent_GameAnimationView__remove_AnimationReadyEvent(param1_01,param1_00,0);
		    iVar1 = *(int *)(local_4 + 0x14);
		    *(undefined1 *)(iVar1 + 0x45) = 0;
		    AssetContent_GameAnimationView__OnDestroy(iVar1,StringLiteral_20487,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x6AE3", Offset = "0x6AE3", VA = "0x6AE3")]
		public void ToIdle()
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x6AE4", Offset = "0x6AE4", VA = "0x6AE4")]
		public TutorialGameLeftPlayerAnimation()
		{
		}

		// Token: 0x04000D5A RID: 3418
		[Token(Token = "0x4000D5A")]
		public const string IDLE_TO_BATTLE = "idle_to_battle";

		// Token: 0x04000D5B RID: 3419
		[Token(Token = "0x4000D5B")]
		public const string BATTLE_TO_IDLE = "battle_to_idle";

		// Token: 0x04000D5C RID: 3420
		[Token(Token = "0x4000D5C")]
		public const string IDLE = "1idle";

		// Token: 0x04000D5D RID: 3421
		[Token(Token = "0x4000D5D")]
		public const string BATTLE = "battle";
	}
}
