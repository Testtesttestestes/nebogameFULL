using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	public class TutorialAdditionalView : MonoBehaviour
	{
		// Token: 0x0600193D RID: 6461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x6ADC", Offset = "0x6ADC", VA = "0x6ADC")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_TutorialV2_View_TutorialAdditionalView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a583ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToggleButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_View_TutorialAdditionalView_ToggleValueChangedEventHandler__
		              );
		    DAT_ram_00a583ab = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_ToggleButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_View_TutorialAdditionalView_ToggleValueChangedEventHandler__
		             ,0);
		  UI_TileAndScrollEntitieDescription___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x6ADD", Offset = "0x6ADD", VA = "0x6ADD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_TutorialV2_View_TutorialAdditionalView__OnDestroy
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a583ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a583ac = '\x01';
		  }
		  UI_ToggleButton__get_Selected(param2,(uint)(*(char *)(param2 + 0x1c) == '\0'),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x220);
		        goto code_r0x80edbca5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80edbca5:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_Sound_Control_AudioController__SetSoundFXEnabled
		            (*(undefined4 *)(iVar3 + 0x18),(uint)*(byte *)(param2 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x6ADE", Offset = "0x6ADE", VA = "0x6ADE")]
		private void ToggleValueChangedEventHandler(ToggleButton btn)
		{
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x6ADF", Offset = "0x6ADF", VA = "0x6ADF")]
		public TutorialAdditionalView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_View_TutorialAdditionalView___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimationView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_BattleToIdleAnimationCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1917);
		    DAT_ram_00a583ad = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_GameAnimationView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_View_TutorialGameLeftPlayerAnimation_BattleToIdleAnimationCompleteEvent__
		             ,0);
		  AssetContent_GameAnimationView__add_AnimationCompleteEvent(param2,param1_00,0);
		  *(undefined1 *)(param2 + 0x45) = 1;
		  AssetContent_GameAnimationView__OnDestroy(param2,StringLiteral_1917,0);
		  return;
		}
		*/

		}

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ToggleButton _muteToggle;
	}
}
