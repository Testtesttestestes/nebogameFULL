using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	public class SpellsAndCultDescriptionPanel : MonoBehaviourWithStates<SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState>
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x72A3", Offset = "0x72A3", VA = "0x72A3")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58373 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel_HandleCloseBtnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel_HandleOpenBtnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58373 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__set_CurrentState__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel_HandleOpenBtnClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel_HandleCloseBtnClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002142")]
		[Address(RVA = "0x72A4", Offset = "0x72A4", VA = "0x72A4")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel__Start
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58374 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__set_CurrentState__
		              );
		    DAT_ram_00a58374 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002143")]
		[Address(RVA = "0x72A5", Offset = "0x72A5", VA = "0x72A5")]
		private void HandleOpenBtnClickEvent()
		{
		/* --- GHIDRA: HandleOpenBtnClickEvent ---
		void Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel__HandleOpenBtnClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58375 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__set_CurrentState__
		              );
		    DAT_ram_00a58375 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x72A6", Offset = "0x72A6", VA = "0x72A6")]
		private void HandleCloseBtnClickEvent()
		{
		/* --- GHIDRA: HandleCloseBtnClickEvent ---
		void Gameplay_RegisterV2_View_SpellsAndCultDescriptionPanel__HandleCloseBtnClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58376 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState___ctor__
		              );
		    DAT_ram_00a58376 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002145")]
		[Address(RVA = "0x72A7", Offset = "0x72A7", VA = "0x72A7")]
		public SpellsAndCultDescriptionPanel()
		{
		}

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _openBtn;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _closeBtn;

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		public enum SpellsAndCultDescriptionPanelState
		{
			// Token: 0x0400122C RID: 4652
			[Token(Token = "0x400122C")]
			Unknown,
			// Token: 0x0400122D RID: 4653
			[Token(Token = "0x400122D")]
			Open,
			// Token: 0x0400122E RID: 4654
			[Token(Token = "0x400122E")]
			Close
		}
	}
}
