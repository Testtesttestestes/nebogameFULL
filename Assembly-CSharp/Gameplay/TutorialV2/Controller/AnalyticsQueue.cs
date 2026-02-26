using System;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	public class AnalyticsQueue : TutorialStepsQueueBase
	{
		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x1700047E")]
		public override StepActionType StepActionType
		{
			[Token(Token = "0x6001964")]
			[Address(RVA = "0x6B03", Offset = "0x6B03", VA = "0x6B03", Slot = "4")]
			get
			{
				return StepActionType.None;
			}
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x6B04", Offset = "0x6B04", VA = "0x6B04", Slot = "5")]
		protected override void ShowNextInternal(StepActionType actionType)
		{
		/* --- GHIDRA: ShowNextInternal ---
		void Gameplay_TutorialV2_Controller_AnalyticsQueue__ShowNextInternal(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param5;
		  undefined4 param4;
		  undefined4 param3;
		  
		  if (DAT_ram_00a583b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo)
		    ;
		    DAT_ram_00a583b7 = '\x01';
		  }
		  iVar1 = System_Uri___ctor(0);
		  iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x10) + 0xc);
		  if (iVar1 != 0) {
		    param2_00 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param5 = *(undefined4 *)(param1 + 0xc);
		    param4 = *(undefined4 *)(param1 + 8);
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417
		                          (Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo);
		    Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs__get_Step
		              (param1_00,param2_00,param3,param4,param5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x6B05", Offset = "0x6B05", VA = "0x6B05", Slot = "6")]
		public override void Hide()
		{
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x6B06", Offset = "0x6B06", VA = "0x6B06")]
		public AnalyticsQueue()
		{
		}

		// Token: 0x04000D7E RID: 3454
		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x8")]
		private StepActionType _currentStage;

		// Token: 0x04000D7F RID: 3455
		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0xC")]
		private int _currentStep;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepActionType ---
		void Gameplay_TutorialV2_Controller_AnalyticsQueue__get_StepActionType
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint param5;
		  undefined4 param3_00;
		  uint param4;
		  uint local_4;
		  
		  if (DAT_ram_00a583b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_StepActionType_var);
		    Mono_Security_ASN1__get_Item(&Gameplay_TutorialV2_Controller_StepActionType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_14662);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11226);
		    DAT_ram_00a583b6 = '\x01';
		  }
		  uVar1 = Gameplay_TutorialV2_Controller_StepActionType_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  param4 = param2 & 0xfff000;
		  local_4 = param4;
		  uVar2 = func_ii_1081(Gameplay_TutorialV2_Controller_StepActionType_TypeInfo,&local_4);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar1 = System_Double__ToString(uVar1,uVar2,0);
		  iVar3 = func_ii_4769(uVar1,0);
		  if (iVar3 != 0) {
		    param4 = 0;
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_11226,0);
		  }
		  param5 = param2 >> 0x18 & 0x7f;
		  if (param5 == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_14662,0);
		  }
		  *(uint *)(param1 + 0xc) = param5;
		  *(uint *)(param1 + 8) = param4;
		  iVar3 = System_Uri___ctor(0);
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0x10) + 8);
		  if (iVar3 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar2 = unnamed_function_1417(Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs_TypeInfo)
		    ;
		    Core_Events_Scopes_Tutorial2Scope_Tutorial2StepEventArgs__get_Step
		              (uVar2,uVar1,param3_00,param4,param5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

}
