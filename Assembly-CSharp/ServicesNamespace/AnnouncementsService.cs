using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Announcements;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public class AnnouncementsService : AbstractService
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700008E")]
		public override short ServiceId
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x5804", Offset = "0x5804", VA = "0x5804", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000013")]
		public event Action<ProtoGetListCmd.Types.Ans> ThereIsNewAnnouncementsEvent
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x5805", Offset = "0x5805", VA = "0x5805")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x5806", Offset = "0x5806", VA = "0x5806")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x5807", Offset = "0x5807", VA = "0x5807", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_AnnouncementsService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a62877 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetListCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62877 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar1 = (int *)Core_Net_AbstractService__PushCommand
		                            (param1,*(undefined4 *)
		                                     (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  if (piVar1[2] == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,1,0,0);
		    param1_00 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (param1_00,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,param1_00,Method_Core_Net_SrvCommand_SetCallback_ProtoGetListCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return piVar1;
		}
		*/

		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5808", Offset = "0x5808", VA = "0x5808")]
		public OpToken<IMessage, object> GetList()
		{
		/* --- GHIDRA: GetList ---
		int * ServicesNamespace_AnnouncementsService__GetList
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int param3_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a62878 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Announcements_ProtoReadCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoReadCmd_Types_Ans___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62878 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  piVar1 = (int *)Core_Net_AbstractService__PushCommand
		                            (param1,*(undefined4 *)
		                                     (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  if (piVar1[2] == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		    param3_00 = unnamed_function_1417(Protocol_Announcements_ProtoReadCmd_TypeInfo);
		    *(undefined8 *)(param3_00 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,2,param3_00,0);
		    param1_00 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (param1_00,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,param1_00,Method_Core_Net_SrvCommand_SetCallback_ProtoReadCmd_Types_Ans___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5809", Offset = "0x5809", VA = "0x5809")]
		public OpToken<IMessage, object> Read(ulong id)
		{
			return null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x580A", Offset = "0x580A", VA = "0x580A")]
		public AnnouncementsService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_AnnouncementsService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62874 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetListCmd_Types_Ans__TypeInfo);
		    DAT_ram_00a62874 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetListCmd_Types_Ans__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetListCmd_Types_Ans__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: add_ThereIsNewAnnouncementsEvent ---
		void ServicesNamespace_AnnouncementsService__add_ThereIsNewAnnouncementsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62875 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetListCmd_Types_Ans__TypeInfo);
		    DAT_ram_00a62875 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoGetListCmd_Types_Ans__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoGetListCmd_Types_Ans__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ThereIsNewAnnouncementsEvent ---
		void ServicesNamespace_AnnouncementsService__remove_ThereIsNewAnnouncementsEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a62876 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_AnnouncementsEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Announcements_ProtoGetListCmd_Types_Ans_TypeInfo);
		    DAT_ram_00a62876 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_AnnouncementsEvents___);
		  if ((iVar1 == 1) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Announcements_ProtoGetListCmd_Types_Ans_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Announcements_ProtoGetListCmd_Types_Ans_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
