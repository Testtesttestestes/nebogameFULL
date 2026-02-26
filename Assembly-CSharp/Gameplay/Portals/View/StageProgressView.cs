using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.ProgressBars;
using UI.ToolTip.Implementations;
using UnityEngine;

namespace Gameplay.Portals.View
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	public class StageProgressView : MonoBehaviourWithStates<StageProgressView.State>
	{
		// Token: 0x06002322 RID: 8994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x7476", Offset = "0x7476", VA = "0x7476")]
		public void SetIcon(string iconAsset)
		{
		/* --- GHIDRA: SetIcon ---
		void Gameplay_Portals_View_StageProgressView__SetIcon
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x1c),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002323")]
		[Address(RVA = "0x7477", Offset = "0x7477", VA = "0x7477")]
		public void SetStageTitle(string value)
		{
		/* --- GHIDRA: SetStageTitle ---
		void Gameplay_Portals_View_StageProgressView__SetStageTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002324")]
		[Address(RVA = "0x7478", Offset = "0x7478", VA = "0x7478")]
		public void SetStageWaitTitle(string value)
		{
		/* --- GHIDRA: SetStageWaitTitle ---
		void Gameplay_Portals_View_StageProgressView__SetStageWaitTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x28) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002325")]
		[Address(RVA = "0x7479", Offset = "0x7479", VA = "0x7479")]
		public void SetToolTip(string value)
		{
		/* --- GHIDRA: SetToolTip ---
		void Gameplay_Portals_View_StageProgressView__SetToolTip
		               (int param1,ulonglong param2,ulonglong param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  ulonglong local_10;
		  ulonglong local_8;
		  
		  if (DAT_ram_00a580f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a580f0 = '\x01';
		  }
		  UI_Elements_ProgressBars_ProgressBar__set_Value
		            (*(undefined4 *)(param1 + 0x24),(float)param2,(float)param3,0);
		  piVar2 = *(int **)(param1 + 0x24);
		  local_8 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  local_10 = param3;
		  param3_00 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar1,param3_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x118) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x747A", Offset = "0x747A", VA = "0x747A")]
		public void SetProgress(ulong current, ulong total)
		{
		/* --- GHIDRA: SetProgress ---
		void Gameplay_Portals_View_StageProgressView__SetProgress(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a580f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_StageProgressView_State___ctor__);
		    DAT_ram_00a580f1 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_StageProgressView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x747B", Offset = "0x747B", VA = "0x747B")]
		public StageProgressView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Portals_View_StageProgressView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a580f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_View_TotalizatorTab_UserInPortalsTotalizatorViewsHolder_TypeInfo);
		    DAT_ram_00a580f2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Portals_View_TotalizatorTab_UserInPortalsTotalizatorViewsHolder_TypeInfo
		                    );
		  if (DAT_ram_00a580f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ItemViewsHolder_UserInPortalTotalizatorListElement___ctor__);
		    DAT_ram_00a580f5 = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400133F RID: 4927
		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _stageTitle;

		// Token: 0x04001340 RID: 4928
		[Token(Token = "0x4001340")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _stageWaitTitle;

		// Token: 0x04001341 RID: 4929
		[Token(Token = "0x4001341")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBarWithText _stageProgress;

		// Token: 0x04001342 RID: 4930
		[Token(Token = "0x4001342")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImageLoader _icon;

		// Token: 0x04001343 RID: 4931
		[Token(Token = "0x4001343")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextToolTip _currencyToolTip;

		// Token: 0x020005B8 RID: 1464
		[Token(Token = "0x20005B8")]
		public enum State
		{
			// Token: 0x04001345 RID: 4933
			[Token(Token = "0x4001345")]
			UNKNOWN_STATE,
			// Token: 0x04001346 RID: 4934
			[Token(Token = "0x4001346")]
			STAGE,
			// Token: 0x04001347 RID: 4935
			[Token(Token = "0x4001347")]
			STAGE_WAIT
		}
	}
}
