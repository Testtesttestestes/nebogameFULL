using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Tree;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	public class TreeService : AbstractService
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x170000B3")]
		public override short ServiceId
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x5AB4", Offset = "0x5AB4", VA = "0x5AB4", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000B2")]
		public event Action<ProtoRegenTreeEvt> RegenTree
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x5AB5", Offset = "0x5AB5", VA = "0x5AB5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x5AB6", Offset = "0x5AB6", VA = "0x5AB6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x5AB7", Offset = "0x5AB7", VA = "0x5AB7", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_TreeService__ServerEventHandler(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyLicenseAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_TreeCommands_TypeInfo);
		    DAT_ram_00a5b7d9 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,2,0,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Tree_TreeCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyLicenseAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5AB8", Offset = "0x5AB8", VA = "0x5AB8")]
		public OpToken<IMessage, object> BuyLicense()
		{
		/* --- GHIDRA: BuyLicense ---
		int * ServicesNamespace_TreeService__BuyLicense
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b7da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_ProtoGetBonusCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetBonusAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_TreeCommands_TypeInfo);
		    DAT_ram_00a5b7da = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Tree_ProtoGetBonusCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x18) = param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,1,iVar1,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Tree_TreeCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetBonusAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x5AB9", Offset = "0x5AB9", VA = "0x5AB9")]
		public OpToken<IMessage, object> GetBonus(ulong ownerId, uint bonusId)
		{
			return null;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x5ABA", Offset = "0x5ABA", VA = "0x5ABA")]
		public TreeService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_TreeService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRegenTreeEvt__TypeInfo);
		    DAT_ram_00a5b7d6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRegenTreeEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRegenTreeEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_RegenTree ---
		void ServicesNamespace_TreeService__add_RegenTree(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b7d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRegenTreeEvt__TypeInfo);
		    DAT_ram_00a5b7d7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoRegenTreeEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoRegenTreeEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_RegenTree ---
		void ServicesNamespace_TreeService__remove_RegenTree(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a5b7d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_ProtoRegenTreeEvt_TypeInfo);
		    DAT_ram_00a5b7d8 = '\x01';
		  }
		  if (*(int *)(param2 + 0x10) == 1) {
		    iVar2 = *(int *)(param1 + 0x14);
		    if (iVar2 != 0) {
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Tree_ProtoRegenTreeEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Tree_ProtoRegenTreeEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  System_ArgumentNullException___ctor(uVar1,0);
		  param2_00 = unnamed_function_2232(&Method_ServicesNamespace_TreeService_ServerEventHandler__);
		  func_ii_1050(uVar1,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
