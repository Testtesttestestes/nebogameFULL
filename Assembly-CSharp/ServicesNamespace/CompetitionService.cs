using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Competition;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public class CompetitionService : AbstractService
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x1700009D")]
		public override short ServiceId
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x5941", Offset = "0x5941", VA = "0x5941", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400005F")]
		public event Action<ProtoCompetitionStateChangedEvt> CompetitionStateChangedEvent
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x5942", Offset = "0x5942", VA = "0x5942")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x5943", Offset = "0x5943", VA = "0x5943")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x5944", Offset = "0x5944", VA = "0x5944", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_CompetitionService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a55967 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetCompetitionStateAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a55967 = '\x01';
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
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,1,0,0);
		    param1_01 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (param1_01,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,param1_01,Method_Core_Net_SrvCommand_SetCallback_ProtoGetCompetitionStateAns___
		              );
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x5945", Offset = "0x5945", VA = "0x5945")]
		public OpToken<IMessage, object> GetCompetitionState()
		{
			return null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x5946", Offset = "0x5946", VA = "0x5946")]
		public CompetitionService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_CompetitionService__get_ServiceId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55964 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionStateChangedEvt__TypeInfo);
		    DAT_ram_00a55964 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCompetitionStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCompetitionStateChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_CompetitionStateChangedEvent ---
		void ServicesNamespace_CompetitionService__add_CompetitionStateChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55965 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoCompetitionStateChangedEvt__TypeInfo);
		    DAT_ram_00a55965 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoCompetitionStateChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoCompetitionStateChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_CompetitionStateChangedEvent ---
		void ServicesNamespace_CompetitionService__remove_CompetitionStateChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a55966 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_CompetitionEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Competition_ProtoCompetitionStateChangedEvt_TypeInfo);
		    DAT_ram_00a55966 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_CompetitionEvents___);
		  if ((iVar1 == 1) && (iVar1 = *(int *)(param1 + 0x14), iVar1 != 0)) {
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Competition_ProtoCompetitionStateChangedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance
		                (param1_00,Protocol_Competition_ProtoCompetitionStateChangedEvt_TypeInfo);
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
