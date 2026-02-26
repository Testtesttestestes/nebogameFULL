using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Themeduel;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	public class ThemeDuelService : AbstractService
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x170000B0")]
		public override short ServiceId
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x5A8D", Offset = "0x5A8D", VA = "0x5A8D", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A9")]
		public event Action<ProtoUserScoreChangedEvt> BalanceChangedEvent
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x5A8E", Offset = "0x5A8E", VA = "0x5A8E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x5A8F", Offset = "0x5A8F", VA = "0x5A8F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AA")]
		public event Action<ProtoUserEntryAttempsChangedEvt> EntryAttemptChangedEvent
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x5A90", Offset = "0x5A90", VA = "0x5A90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x5A91", Offset = "0x5A91", VA = "0x5A91")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000AB RID: 171
		// (add) Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000AB")]
		public event Action<ProtoThemeDuelStateChangedEvt> StateChangedEvent
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x5A92", Offset = "0x5A92", VA = "0x5A92")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x5A93", Offset = "0x5A93", VA = "0x5A93")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x5A94", Offset = "0x5A94", VA = "0x5A94", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_ThemeDuelService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5b7bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetThemeDuelEventStateAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5b7bc = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    uVar3 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,1,uVar3,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetThemeDuelEventStateAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x5A95", Offset = "0x5A95", VA = "0x5A95")]
		public OpToken<IMessage, object> GetThemeDuelState()
		{
		/* --- GHIDRA: GetThemeDuelState ---
		int * ServicesNamespace_ThemeDuelService__GetThemeDuelState(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5b7bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventStoreItemsInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5b7bd = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    uVar3 = unnamed_function_1417(Protocol_Common_ProtoEmptyCmd_TypeInfo);
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,2,uVar3,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventStoreItemsInfoAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x5A96", Offset = "0x5A96", VA = "0x5A96")]
		public OpToken<IMessage, object> GetEventStoreItemsInfo()
		{
		/* --- GHIDRA: GetEventStoreItemsInfo ---
		int * ServicesNamespace_ThemeDuelService__GetEventStoreItemsInfo
		                (int *param1,undefined8 param2,undefined8 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b7be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoBuyEventStoreItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyEventStoreItemAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a5b7be = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    iVar1 = unnamed_function_1417(Protocol_Themeduel_ProtoBuyEventStoreItemCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = param4;
		    *(undefined8 *)(iVar1 + 0x10) = param3;
		    *(undefined8 *)(iVar1 + 0x20) = param2;
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,3,iVar1,0);
		    param1_01 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (param1_01,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,param1_01,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyEventStoreItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x5A97", Offset = "0x5A97", VA = "0x5A97")]
		public OpToken<IMessage, object> BuyEventShopItem(ulong price, ulong artId, int destSlot)
		{
			return null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x5A98", Offset = "0x5A98", VA = "0x5A98")]
		public ThemeDuelService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_ThemeDuelService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserScoreChangedEvt__TypeInfo);
		    DAT_ram_00a5b7b5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserScoreChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserScoreChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_BalanceChangedEvent ---
		void ServicesNamespace_ThemeDuelService__add_BalanceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserScoreChangedEvt__TypeInfo);
		    DAT_ram_00a5b7b6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserScoreChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserScoreChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_BalanceChangedEvent ---
		void ServicesNamespace_ThemeDuelService__remove_BalanceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo);
		    DAT_ram_00a5b7b7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_EntryAttemptChangedEvent ---
		void ServicesNamespace_ThemeDuelService__add_EntryAttemptChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo);
		    DAT_ram_00a5b7b8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoUserEntryAttempsChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_EntryAttemptChangedEvent ---
		void ServicesNamespace_ThemeDuelService__remove_EntryAttemptChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    DAT_ram_00a5b7b9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_StateChangedEvent ---
		void ServicesNamespace_ThemeDuelService__add_StateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo);
		    DAT_ram_00a5b7ba = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoThemeDuelStateChangedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_StateChangedEvent ---
		void ServicesNamespace_ThemeDuelService__remove_StateChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5b7bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ThemeduelEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoThemeDuelStateChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoUserEntryAttempsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Themeduel_ProtoUserScoreChangedEvt_TypeInfo);
		    DAT_ram_00a5b7bb = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ThemeduelEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Themeduel_ProtoUserScoreChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Themeduel_ProtoUserScoreChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else if (iVar1 == 2) {
		    iVar1 = *(int *)(param1 + 0x18);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Themeduel_ProtoUserEntryAttempsChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Themeduel_ProtoUserEntryAttempsChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 != 3) {
		      return;
		    }
		    iVar1 = *(int *)(param1 + 0x1c);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Themeduel_ProtoThemeDuelStateChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Themeduel_ProtoThemeDuelStateChangedEvt_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
