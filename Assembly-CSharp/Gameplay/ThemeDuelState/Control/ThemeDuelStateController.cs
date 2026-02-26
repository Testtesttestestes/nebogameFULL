using System;
using Gameplay.ThemeDuelState.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Themeduel;
using ServicesNamespace;
using Utils;

namespace Gameplay.ThemeDuelState.Control
{
	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20004D4")]
	public class ThemeDuelStateController : AbstractController<ThemeDuelStateModel, ThemeDuelStateEvents>
	{
		// Token: 0x06001D68 RID: 7528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x6EE7", Offset = "0x6EE7", VA = "0x6EE7")]
		public ThemeDuelStateController(ThemeDuelStateModel model, ThemeDuelStateEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58597 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleEntryAttemptChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleStateChangedEvent__
		              );
		    DAT_ram_00a58597 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleBalanceChangedEvent__
		             ,0);
		  ServicesNamespace_ThemeDuelService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleEntryAttemptChangedEvent__
		             ,0);
		  ServicesNamespace_ThemeDuelService__remove_BalanceChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleStateChangedEvent__
		             ,0);
		  ServicesNamespace_ThemeDuelService__remove_EntryAttemptChangedEvent(uVar2,uVar1,0);
		  Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleStop(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x6EE8", Offset = "0x6EE8", VA = "0x6EE8", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58598 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserScoreChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleEntryAttemptChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleStateChangedEvent__
		              );
		    DAT_ram_00a58598 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserScoreChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleBalanceChangedEvent__
		             ,0);
		  ServicesNamespace_ThemeDuelService__add_BalanceChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleEntryAttemptChangedEvent__
		             ,0);
		  ServicesNamespace_ThemeDuelService__add_EntryAttemptChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleStateChangedEvent__
		             ,0);
		  ServicesNamespace_ThemeDuelService__add_StateChangedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x6EE9", Offset = "0x6EE9", VA = "0x6EE9", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleStop
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58599 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleGetThemeDuelStateService__
		              );
		    DAT_ram_00a58599 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ThemeDuelService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_ThemeDuelState_Control_ThemeDuelStateController_HandleGetThemeDuelStateService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x6EEA", Offset = "0x6EEA", VA = "0x6EEA")]
		private void RequestState()
		{
		/* --- GHIDRA: RequestState ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__RequestState
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar3;
		  longlong lVar2;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar4;
		  int *param1_01;
		  int param2_00;
		  longlong param2_01;
		  int iVar5;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5859a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoGetThemeDuelEventStateAns_TypeInfo);
		    DAT_ram_00a5859a = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Themeduel_ProtoGetThemeDuelEventStateAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Themeduel_ProtoGetThemeDuelEventStateAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  iVar5 = param1_01[3];
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___ctor(param1_00,iVar5,param3_00,param1);
		  if (param1_01[4] != 0) {
		    uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    param2_01 = *(longlong *)(param1_01[4] + 0x18);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (DAT_ram_00a5858c == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__get_HasValue__);
		      DAT_ram_00a5858c = '\x01';
		    }
		    if ((*(char *)(iVar5 + 0x18) == '\0') || (*(longlong *)(iVar5 + 0x20) != param2_01)) {
		      local_8 = 0;
		      local_10 = 0;
		      lVar2 = param2_01;
		      Core_Log_Files_FileDownloadLogger__LogDownload
		                (&local_10,param2_01,Method_System_Nullable_long___ctor__);
		      uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		      *(undefined8 *)(iVar5 + 0x20) = local_8;
		      *(undefined8 *)(iVar5 + 0x18) = local_10;
		      iVar5 = *(int *)(iVar4 + 0x20);
		      if (iVar5 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),param2_01,*(undefined4 *)(iVar5 + 0x14));
		        uVar3 = (undefined4)((ulonglong)param2_01 >> 0x20);
		      }
		    }
		    uVar1 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    param2_00 = *(int *)(param1_01[4] + 0x10);
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (DAT_ram_00a5858d == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		      DAT_ram_00a5858d = '\x01';
		    }
		    if ((*(ulonglong *)(iVar5 + 0x28) & 0xff) == 0 ||
		        (int)(*(ulonglong *)(iVar5 + 0x28) >> 0x20) != param2_00) {
		      local_10 = 0;
		      System_Data_SqlTypes_SqlInt32___ctor(&local_10,param2_00,Method_System_Nullable_int___ctor__);
		      *(undefined8 *)(iVar5 + 0x28) = local_10;
		      iVar5 = *(int *)(iVar4 + 0x24);
		      if (iVar5 != 0) {
		        uVar1 = CONCAT44(uVar3,param2_00);
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),uVar1,*(undefined4 *)(iVar5 + 0x14));
		        uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      }
		    }
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x114)));
		  iVar5 = *(int *)(iVar5 + 0x14);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x6EEB", Offset = "0x6EEB", VA = "0x6EEB")]
		private void HandleGetThemeDuelStateService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetThemeDuelStateService ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleGetThemeDuelStateService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param3_00;
		  int iVar1;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(param2 + 0xc);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		  Gameplay_ThemeDuelState_Model_ThemeDuelStateModel___ctor(param1_00,param2_00,param3_00,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x6EEC", Offset = "0x6EEC", VA = "0x6EEC")]
		private void HandleStateChangedEvent(ProtoThemeDuelStateChangedEvt evt)
		{
		/* --- GHIDRA: HandleStateChangedEvent ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleStateChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  longlong param2_00;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = *(longlong *)(param2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (DAT_ram_00a5858c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__get_HasValue__);
		    DAT_ram_00a5858c = '\x01';
		  }
		  if ((*(char *)(iVar1 + 0x18) == '\0') || (*(longlong *)(iVar1 + 0x20) != param2_00)) {
		    local_8 = 0;
		    local_10 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_10,param2_00,Method_System_Nullable_long___ctor__);
		    *(undefined8 *)(iVar1 + 0x20) = local_8;
		    *(undefined8 *)(iVar1 + 0x18) = local_10;
		    iVar1 = *(int *)(iVar2 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x6EED", Offset = "0x6EED", VA = "0x6EED")]
		public void HandleBalanceChangedEvent(ProtoUserScoreChangedEvt evt)
		{
		/* --- GHIDRA: HandleBalanceChangedEvent ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleBalanceChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  undefined8 local_8;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(int *)(param2 + 0x10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (DAT_ram_00a5858d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    DAT_ram_00a5858d = '\x01';
		  }
		  if ((*(ulonglong *)(iVar1 + 0x28) & 0xff) == 0 ||
		      (int)(*(ulonglong *)(iVar1 + 0x28) >> 0x20) != param2_00) {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_8,param2_00,Method_System_Nullable_int___ctor__);
		    *(undefined8 *)(iVar1 + 0x28) = local_8;
		    iVar1 = *(int *)(iVar2 + 0x24);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x6EEE", Offset = "0x6EEE", VA = "0x6EEE")]
		public void HandleEntryAttemptChangedEvent(ProtoUserEntryAttempsChangedEvt evt)
		{
		/* --- GHIDRA: HandleEntryAttemptChangedEvent ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelStateController__HandleEntryAttemptChangedEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a5859b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView___ctor__
		              );
		    DAT_ram_00a5859b = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param6,
		             Method_Gameplay_Combat_AbstractCombat_ThemeDuelCombatModel__ThemeDuelCombatEvents__ThemeDuelCombatController__ThemeDuelCombatViewMediator__ThemeDuelCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param5;
		  return;
		}
		*/

		}

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x18")]
		private readonly ThemeDuelService _themeDuelService;
	}
}
