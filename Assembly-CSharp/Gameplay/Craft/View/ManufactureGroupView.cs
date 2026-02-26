using System;
using Core.Data;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	public class ManufactureGroupView : MonoBehaviourWithStates<ManufactureGroupView.State>
	{
		// Token: 0x06003487 RID: 13447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003487")]
		[Address(RVA = "0x84B1", Offset = "0x84B1", VA = "0x84B1")]
		public void ShowEmptyState(long expirationTime)
		{
		/* --- GHIDRA: ShowEmptyState ---
		void Gameplay_Craft_View_ManufactureGroupView__ShowEmptyState(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		    DAT_ram_00a63a19 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,
		             Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003488")]
		[Address(RVA = "0x84B2", Offset = "0x84B2", VA = "0x84B2")]
		public void ShowDisabledState()
		{
		/* --- GHIDRA: ShowDisabledState ---
		void Gameplay_Craft_View_ManufactureGroupView__ShowDisabledState
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63a1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		    DAT_ram_00a63a1a = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,3,
		             Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		  Gameplay_Craft_View_ManufactureGroupView__ResolveSlotState(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003489")]
		[Address(RVA = "0x84B3", Offset = "0x84B3", VA = "0x84B3")]
		public void ShowFilledState(long expirationTime)
		{
		/* --- GHIDRA: ShowFilledState ---
		void Gameplay_Craft_View_ManufactureGroupView__ShowFilledState(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		    DAT_ram_00a63a1b = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,4,
		             Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348A")]
		[Address(RVA = "0x84B4", Offset = "0x84B4", VA = "0x84B4")]
		public void ShowDisabledFilledState()
		{
		/* --- GHIDRA: ShowDisabledFilledState ---
		void Gameplay_Craft_View_ManufactureGroupView__ShowDisabledFilledState
		               (undefined4 param1,undefined4 param2,int param3,longlong param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63a1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_CraftSlotListElement_State__get_CurrentState__);
		    DAT_ram_00a63a1c = '\x01';
		  }
		  iVar1 = *(int *)(param3 + 0x18);
		  if (iVar1 != 1) {
		    if (iVar1 == 2) {
		      if (DAT_ram_00a63a18 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__
		                  );
		        DAT_ram_00a63a18 = '\x01';
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,1,
		                 Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		      Gameplay_Craft_View_ManufactureGroupView__ResolveSlotState(param1,param4,param1);
		      return;
		    }
		    if (iVar1 == 3) {
		      if (0 < param4) {
		        if (DAT_ram_00a63a1a == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__
		                    );
		          DAT_ram_00a63a1a = '\x01';
		        }
		        Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                  (param1,3,
		                   Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__)
		        ;
		        Gameplay_Craft_View_ManufactureGroupView__ResolveSlotState(param1,param4,param1);
		        return;
		      }
		      if (DAT_ram_00a63a1b == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__
		                  );
		        DAT_ram_00a63a1b = '\x01';
		      }
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,4,
		                 Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		    }
		    return;
		  }
		  if (DAT_ram_00a63a19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		    DAT_ram_00a63a19 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,
		             Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348B")]
		[Address(RVA = "0x84B5", Offset = "0x84B5", VA = "0x84B5")]
		public void ResolveSlotState(UserData user, CraftSlotListElement element, long expirationTime)
		{
		/* --- GHIDRA: ResolveSlotState ---
		void Gameplay_Craft_View_ManufactureGroupView__ResolveSlotState
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  float param2_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63a1d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a63a1d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param2,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348C")]
		[Address(RVA = "0x84B6", Offset = "0x84B6", VA = "0x84B6")]
		private void DisplayTimer(long expirationTime)
		{
		/* --- GHIDRA: DisplayTimer ---
		void Gameplay_Craft_View_ManufactureGroupView__DisplayTimer(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State___ctor__);
		    DAT_ram_00a63a1e = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600348D RID: 13453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348D")]
		[Address(RVA = "0x84B7", Offset = "0x84B7", VA = "0x84B7")]
		public ManufactureGroupView()
		{
		}

		// Token: 0x04001CC0 RID: 7360
		[Token(Token = "0x4001CC0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x020008BE RID: 2238
		[Token(Token = "0x20008BE")]
		public enum State
		{
			// Token: 0x04001CC2 RID: 7362
			[Token(Token = "0x4001CC2")]
			UNKNOWN_STATE,
			// Token: 0x04001CC3 RID: 7363
			[Token(Token = "0x4001CC3")]
			EMPTY,
			// Token: 0x04001CC4 RID: 7364
			[Token(Token = "0x4001CC4")]
			DISABLED,
			// Token: 0x04001CC5 RID: 7365
			[Token(Token = "0x4001CC5")]
			FILLED,
			// Token: 0x04001CC6 RID: 7366
			[Token(Token = "0x4001CC6")]
			DISABLED_FILLED
		}
	}
}
