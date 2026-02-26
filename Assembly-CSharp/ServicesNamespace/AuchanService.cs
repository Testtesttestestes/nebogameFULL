using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public class AuchanService : AbstractService
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x1700008F")]
		public override short ServiceId
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x580B", Offset = "0x580B", VA = "0x580B", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x580C", Offset = "0x580C", VA = "0x580C")]
		public OpToken<IMessage, object> GetAuchanItemsInfo()
		{
		/* --- GHIDRA: GetAuchanItemsInfo ---
		int * ServicesNamespace_AuchanService__GetAuchanItemsInfo
		                (int *param1,undefined8 param2,char *param3,undefined4 param4,undefined4 param5)
		
		{
		  int *piVar1;
		  int param3_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6287a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    Mono_Security_ASN1__get_Item(&Protocol_Auchan_ProtoBuyAuchanItemCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoBuyAuchanItemAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a6287a = '\x01';
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
		    param3_00 = unnamed_function_1417(Protocol_Auchan_ProtoBuyAuchanItemCmd_TypeInfo);
		    *(undefined4 *)(param3_00 + 0x1c) = param4;
		    *(undefined8 *)(param3_00 + 0x10) = param2;
		    if (*param3 != '\0') {
		      uVar2 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                        (param3,Method_System_Nullable_uint__get_Value__);
		      *(undefined4 *)(param3_00 + 0x18) = uVar2;
		    }
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
		              (uVar2,param1_00,Method_Core_Net_SrvCommand_SetCallback_ProtoBuyAuchanItemAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return piVar1;
		}
		*/

			return null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x580D", Offset = "0x580D", VA = "0x580D")]
		public OpToken<IMessage, object> BuyAuchanItem(ulong artifactId, uint? slotId, ResourceSet sellPrice)
		{
			return null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x580E", Offset = "0x580E", VA = "0x580E")]
		public AuchanService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		int * ServicesNamespace_AuchanService__get_ServiceId(int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int param1_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62879 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Auchan_AuchanCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetAuchanItemsInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a62879 = '\x01';
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
		    param1_00 = Core_Net_SrvCommand___ctor(uVar2,1,0,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Auchan_AuchanCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(param1_00 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_00,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetAuchanItemsInfoAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_00,0);
		  }
		  return piVar1;
		}
		*/

}
