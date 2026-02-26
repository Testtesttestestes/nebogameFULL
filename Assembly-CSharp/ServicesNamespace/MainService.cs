using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Main;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public class MainService : AbstractService
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x170000A5")]
		public override short ServiceId
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x59A9", Offset = "0x59A9", VA = "0x59A9", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x060005A5 RID: 1445 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005A6 RID: 1446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000081")]
		public event Action<ProtoTriggersChangedEvt> TriggersChangedEvent
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x59AA", Offset = "0x59AA", VA = "0x59AA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x59AB", Offset = "0x59AB", VA = "0x59AB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x060005A7 RID: 1447 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005A8 RID: 1448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000082")]
		public event Action<ProtoNewLevelEvt> NewLevelEvent
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x59AC", Offset = "0x59AC", VA = "0x59AC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x59AD", Offset = "0x59AD", VA = "0x59AD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000083")]
		public event Action<ProtoExperienceChangedEvt> ExpChangedEvent
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x59AE", Offset = "0x59AE", VA = "0x59AE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x59AF", Offset = "0x59AF", VA = "0x59AF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000084 RID: 132
		// (add) Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000084")]
		public event Action<ProtoDictionariesUpdatedEvt> DictionariesUpdatedEvent
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2286", Offset = "0x2286", VA = "0x2286")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x59B0", Offset = "0x59B0", VA = "0x59B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000085")]
		public event Action<ProtoInventoryChangedEvt> InventoryChangedEvent
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x59B1", Offset = "0x59B1", VA = "0x59B1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x59B2", Offset = "0x59B2", VA = "0x59B2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000086 RID: 134
		// (add) Token: 0x060005AF RID: 1455 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000086")]
		public event Action<ProtoNewMedalsEvt> NewMedalsEvent
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x59B3", Offset = "0x59B3", VA = "0x59B3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x59B4", Offset = "0x59B4", VA = "0x59B4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x060005B1 RID: 1457 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000087")]
		public event Action<ProtoTakeOffMedalsEvt> TakeOffMedalsEvent
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x59B5", Offset = "0x59B5", VA = "0x59B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x59B6", Offset = "0x59B6", VA = "0x59B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060005B4 RID: 1460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000088")]
		public event Action<ProtoSkillsChangedEvt> SkillsChangedEvent
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x59B7", Offset = "0x59B7", VA = "0x59B7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x59B8", Offset = "0x59B8", VA = "0x59B8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x59B9", Offset = "0x59B9", VA = "0x59B9", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		int * ServicesNamespace_MainService__ServerEventHandler
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a559cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserSkillsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserSkillsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a559cc = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetUserSkillsCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,9,iVar1,0);
		    local_10 = 0x9ffffffff;
		    local_14 = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param3_00 = func_ii_8783(&local_8,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserSkillsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x59BA", Offset = "0x59BA", VA = "0x59BA")]
		public OpToken<IMessage, object> GetUserSkills(ulong userId)
		{
		/* --- GHIDRA: GetUserSkills ---
		int * ServicesNamespace_MainService__GetUserSkills(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  if (DAT_ram_00a559cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserMedalsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserMedalsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a559cd = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetUserMedalsCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0xe,iVar1,0);
		    local_10 = 0xeffffffff;
		    local_14 = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_14,0);
		    param3_00 = func_ii_8783(&local_8,0);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserMedalsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x59BB", Offset = "0x59BB", VA = "0x59BB")]
		public OpToken<IMessage, object> GetUserMedals(ulong userId)
		{
		/* --- GHIDRA: GetUserMedals ---
		int * ServicesNamespace_MainService__GetUserMedals(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a559cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10833);
		    DAT_ram_00a559cf = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x13,0,0);
		    *(undefined4 *)(iVar1 + 0x14) = StringLiteral_10833;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1E25", Offset = "0x1E25", VA = "0x1E25")]
		public OpToken<IMessage, object> GetUserStats(ulong userId)
		{
		/* --- GHIDRA: GetUserStats ---
		int ServicesNamespace_MainService__GetUserStats(int param1,int param2,int param3,int param4)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (param3 != 0) {
		    *(int *)(param1 + 0xc) = param3;
		  }
		  if (*(int *)(param1 + 8) - 2U < 3) {
		    (**(code **)((ulonglong)*(uint *)(param2 + 0xc) * 4))
		              (*(undefined4 *)(param2 + 0x20),param1,*(undefined4 *)(param2 + 0x14));
		    return param1;
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x18);
		    if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		      iVar1 = func_ii_1079(iVar1);
		    }
		    iVar1 = unnamed_function_1417(iVar1);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar1,*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x38));
		    *(int *)(param1 + 0x14) = iVar1;
		  }
		  iVar1 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (iVar1,param2,*(undefined4 *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x3c));
		  if (iVar1 == -1) {
		    iVar1 = *(int *)(*(int *)(*(int *)(param4 + 0x10) + 0x60) + 0x40);
		    param1_00 = *(int *)(param1 + 0x14);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		      return param1;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1;
		}
		*/

			return null;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x59BC", Offset = "0x59BC", VA = "0x59BC")]
		public OpToken<IMessage, object> GetUserInfo()
		{
		/* --- GHIDRA: GetUserInfo ---
		int * ServicesNamespace_MainService__GetUserInfo(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetExtUsersInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetExtUsersInfoAns___)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_String_Join_ulong___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    DAT_ram_00a559d0 = '\x01';
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetExtUsersInfoCmd_TypeInfo);
		    Protocol_Main_ProtoGetExtUsersInfoCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    Google_Protobuf_Collections_RepeatedField_ulong___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x14,iVar1,0);
		    local_8 = 0x14ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    param3_00 = System_String__Join_uint_
		                          (StringLiteral_1236,param2,Method_System_String_Join_ulong___);
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (uVar2,StringLiteral_118,param3_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetExtUsersInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x59BD", Offset = "0x59BD", VA = "0x59BD")]
		public OpToken<IMessage, object> GetShortUserInfo(params ulong[] ids)
		{
		/* --- GHIDRA: GetShortUserInfo ---
		int * ServicesNamespace_MainService__GetShortUserInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetClientStateAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a559d1 = '\x01';
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
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,2,0,0);
		    local_8 = 0x2ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetClientStateAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x59BE", Offset = "0x59BE", VA = "0x59BE")]
		public OpToken<IMessage, object> GetClientState()
		{
		/* --- GHIDRA: GetClientState ---
		int * ServicesNamespace_MainService__GetClientState(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserArtifactsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserArtifactsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a559d2 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetUserArtifactsCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,10,iVar1,0);
		    local_8 = 0xaffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserArtifactsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x59BF", Offset = "0x59BF", VA = "0x59BF")]
		public OpToken<IMessage, object> GetUserArtifacts(ulong userId)
		{
		/* --- GHIDRA: GetUserArtifacts ---
		int * ServicesNamespace_MainService__GetUserArtifacts
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSellArtifactCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559d3 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSellArtifactCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,4,iVar1,0);
		    local_8 = 0x4ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x59C0", Offset = "0x59C0", VA = "0x59C0")]
		public OpToken<IMessage, object> SellArtifact(int slotId)
		{
		/* --- GHIDRA: SellArtifact ---
		int * ServicesNamespace_MainService__SellArtifact(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoPingAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a559d4 = '\x01';
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
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,1,0,0);
		    local_8 = 0x1ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoPingAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x59C1", Offset = "0x59C1", VA = "0x59C1")]
		public OpToken<IMessage, object> Ping()
		{
		/* --- GHIDRA: Ping ---
		int * ServicesNamespace_MainService__Ping
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSwapSlotsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoSwapSlotsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559d5 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSwapSlotsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,5,iVar1,0);
		    local_8 = 0x5ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoSwapSlotsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x59C2", Offset = "0x59C2", VA = "0x59C2")]
		public OpToken<IMessage, object> SwapSlots(int slotIdFrom, int slotIdTo)
		{
		/* --- GHIDRA: SwapSlots ---
		int * ServicesNamespace_MainService__SwapSlots(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoInitCompleteAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559d6 = '\x01';
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
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x100,0,0);
		    local_8 = 0x100ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoInitCompleteAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x59C3", Offset = "0x59C3", VA = "0x59C3")]
		public OpToken<IMessage, object> InitComplete()
		{
		/* --- GHIDRA: InitComplete ---
		int * ServicesNamespace_MainService__InitComplete(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetLastDropCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoGetLastDropAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559d7 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetLastDropCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,7,iVar1,0);
		    local_8 = 0x7ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Main_DropTypes_TypeInfo;
		    local_10 = param2;
		    param2_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetLastDropAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x59C4", Offset = "0x59C4", VA = "0x59C4")]
		public OpToken<IMessage, object> GetLastDrop(DropTypes dropType)
		{
		/* --- GHIDRA: GetLastDrop ---
		int * ServicesNamespace_MainService__GetLastDrop
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5
		                )
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoTakeArtifactFromDropCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559d8 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoTakeArtifactFromDropCmd_TypeInfo);
		    Protocol_Main_ProtoTakeArtifactFromDropCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0)
		    ;
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0x14) = param2;
		    Google_Protobuf_Collections_RepeatedField_ulong___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param4,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,8,iVar1,0);
		    local_8 = 0x8ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Main_DropTypes_TypeInfo;
		    local_10 = param2;
		    param2_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x59C5", Offset = "0x59C5", VA = "0x59C5")]
		public OpToken<IMessage, object> TakeArtifactFromDrop(DropTypes dropType, uint startSlotId, params ulong[] artifactIds)
		{
		/* --- GHIDRA: TakeArtifactFromDrop ---
		int * ServicesNamespace_MainService__TakeArtifactFromDrop
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 param1_02;
		  int *piVar3;
		  undefined4 param3_00;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSellArtifactFromDropCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    DAT_ram_00a559d9 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSellArtifactFromDropCmd_TypeInfo);
		    Protocol_Main_ProtoSellArtifactFromDropCmd__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0)
		    ;
		    Google_Protobuf_Collections_RepeatedField_ulong___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0xc),param2,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,0x1b,iVar1,0);
		    local_8 = 0x1bffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    param1_02 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    uVar2 = StringLiteral_118;
		    piVar3 = *(int **)(iVar1 + 0xc);
		    if (piVar3 == (int *)0x0) {
		      param3_00 = 0;
		    }
		    else {
		      param3_00 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xd8) * 4))
		                            (piVar3,*(undefined4 *)(*piVar3 + 0xdc));
		    }
		    uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__(param1_02,uVar2,param3_00,0)
		    ;
		    *(undefined4 *)(param1_01 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x59C6", Offset = "0x59C6", VA = "0x59C6")]
		public OpToken<IMessage, object> SellArtifactFromDrop(ulong[] artifactIds)
		{
		/* --- GHIDRA: SellArtifactFromDrop ---
		int * ServicesNamespace_MainService__SellArtifactFromDrop
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoTakeAllArtifactsFromDropCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoTakeAllArtifactsFromDropAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559da = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoTakeAllArtifactsFromDropCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x1d,iVar1,0);
		    local_8 = 0x1dffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Main_DropTypes_TypeInfo;
		    local_10 = param2;
		    param2_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoTakeAllArtifactsFromDropAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x59C7", Offset = "0x59C7", VA = "0x59C7")]
		public OpToken<IMessage, object> TakeAllDrop(DropTypes dropType)
		{
		/* --- GHIDRA: TakeAllDrop ---
		int * ServicesNamespace_MainService__TakeAllDrop(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_DropTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSellAllFromDropCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559db = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSellAllFromDropCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x15,iVar1,0);
		    local_8 = 0x15ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Protocol_Main_DropTypes_TypeInfo;
		    local_10 = param2;
		    param2_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,param2_00,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x59C8", Offset = "0x59C8", VA = "0x59C8")]
		public OpToken<IMessage, object> SellAllFromDrop(DropTypes dropType)
		{
		/* --- GHIDRA: SellAllFromDrop ---
		int * ServicesNamespace_MainService__SellAllFromDrop
		                (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSetUserIdCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a559dc = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSetUserIdCmd_TypeInfo);
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,0x20,iVar1,0);
		    local_8 = 0x20ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoDefaultAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x59C9", Offset = "0x59C9", VA = "0x59C9")]
		public OpToken<IMessage, object> SetUserId(ulong userId)
		{
		/* --- GHIDRA: SetUserId ---
		int * ServicesNamespace_MainService__SetUserId
		                (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoChangeFavoriteArtifactCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a559dd = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoChangeFavoriteArtifactCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0x18) = (undefined1)param3;
		    *(undefined8 *)(iVar1 + 0x10) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,0x21,iVar1,0);
		    local_8 = 0x21ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x59CA", Offset = "0x59CA", VA = "0x59CA")]
		public OpToken<IMessage, object> ChangeFavoriteArtifact(ulong artifactId, bool favorite)
		{
		/* --- GHIDRA: ChangeFavoriteArtifact ---
		int * ServicesNamespace_MainService__ChangeFavoriteArtifact
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSetMedalsVisibilityCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a559de = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSetMedalsVisibilityCmd_TypeInfo);
		    *(undefined1 *)(iVar1 + 0xd) = (undefined1)param3;
		    *(undefined1 *)(iVar1 + 0xc) = (undefined1)param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    param1_01 = Core_Net_SrvCommand___ctor(uVar2,0x1f,iVar1,0);
		    local_8 = 0x1fffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    iVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    *(int *)(param1_01 + 0x14) = iVar1;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (param1_01,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoEmptyAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,param1_01,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x59CB", Offset = "0x59CB", VA = "0x59CB")]
		public OpToken<IMessage, object> SetMedalsVisibility(bool hideMedals, bool hideAprs)
		{
		/* --- GHIDRA: SetMedalsVisibility ---
		int * ServicesNamespace_MainService__SetMedalsVisibility
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoMergeAllStackableItemsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559df = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoMergeAllStackableItemsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x19,iVar1,0);
		    local_8 = 0x19ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x59CC", Offset = "0x59CC", VA = "0x59CC")]
		public OpToken<IMessage, object> MergeAllStackableItems(uint slotId)
		{
		/* --- GHIDRA: MergeAllStackableItems ---
		int * ServicesNamespace_MainService__MergeAllStackableItems
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSplitStackableItemsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e0 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoSplitStackableItemsCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0x10) = param3;
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x1a,iVar1,0);
		    local_8 = 0x1affffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x59CD", Offset = "0x59CD", VA = "0x59CD")]
		public OpToken<IMessage, object> SplitStackableItems(uint slotId, uint quantity)
		{
		/* --- GHIDRA: SplitStackableItems ---
		int * ServicesNamespace_MainService__SplitStackableItems
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoUserSettingsSaveCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e1 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Main_ProtoUserSettingsSaveCmd_TypeInfo);
		    Protocol_Main_ProtoUserSettingsSaveCmd__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		    Protocol_Main_ProtoUserSettingsSaveCmd__get_Settings(uVar2,param2,0);
		    param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(param1_01,0x17,uVar2,0);
		    local_8 = 0x17ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoStackableChangesAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x59CE", Offset = "0x59CE", VA = "0x59CE")]
		public OpToken<IMessage, object> UserSettingsSave(string settings)
		{
		/* --- GHIDRA: UserSettingsSave ---
		int * ServicesNamespace_MainService__UserSettingsSave
		                (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetGameEventRewardsInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetGameEventRewardsInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e2 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetGameEventRewardsInfoCmd_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x22,iVar1,0);
		    local_8 = 0x22ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,Method_Core_Net_SrvCommand_SetCallback_ProtoGetGameEventRewardsInfoAns___
		              );
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x59CF", Offset = "0x59CF", VA = "0x59CF")]
		public OpToken<IMessage, object> GetGameEventsRewardsInfo(uint eventId)
		{
		/* --- GHIDRA: GetGameEventsRewardsInfo ---
		int * ServicesNamespace_MainService__GetGameEventsRewardsInfo
		                (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a559e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_MainCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetEventMilestonesRewardsInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventMilestonesRewardsInfoAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e3 = '\x01';
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
		    iVar1 = unnamed_function_1417(Protocol_Main_ProtoGetEventMilestonesRewardsInfoCmd_TypeInfo);
		    Protocol_Main_ProtoGetEventMilestonesRewardsInfoCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		              (iVar1,0);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(iVar1 + 0x10),param3,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,0x23,iVar1,0);
		    local_8 = 0x23ffffffff;
		    local_c = Protocol_Main_MainCommands_TypeInfo;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (iVar1,uVar2,
		               Method_Core_Net_SrvCommand_SetCallback_ProtoGetEventMilestonesRewardsInfoAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x59D0", Offset = "0x59D0", VA = "0x59D0")]
		public OpToken<IMessage, object> GetEventMilestonesRewardsInfo(uint eventId, params uint[] milestoneNumbers)
		{
		/* --- GHIDRA: GetEventMilestonesRewardsInfo ---
		int * ServicesNamespace_MainService__GetEventMilestonesRewardsInfo(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a559e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserLevelRewardAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e4 = '\x01';
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
		    uVar2 = Core_Net_SrvCommand___ctor(uVar2,0x25,0,0);
		    param1_01 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (param1_01,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,param1_01,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserLevelRewardAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x59D1", Offset = "0x59D1", VA = "0x59D1")]
		public OpToken<IMessage, object> GetUserLevelReward()
		{
		/* --- GHIDRA: GetUserLevelReward ---
		int * ServicesNamespace_MainService__GetUserLevelReward(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a559e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserAnitiqArtifactsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserAnitiqArtifactsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e5 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Main_ProtoGetUserAnitiqArtifactsCmd_TypeInfo);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar3,0x26,uVar2,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserAnitiqArtifactsAns___)
		    ;
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x59D2", Offset = "0x59D2", VA = "0x59D2")]
		public OpToken<IMessage, object> GetUserAntiqArtifacts()
		{
		/* --- GHIDRA: GetUserAntiqArtifacts ---
		int * ServicesNamespace_MainService__GetUserAntiqArtifacts(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a559e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserExperimentsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserExperimentsAns___);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    DAT_ram_00a559e6 = '\x01';
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
		    uVar2 = unnamed_function_1417(Protocol_Main_ProtoGetUserExperimentsCmd_TypeInfo);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    uVar2 = Core_Net_SrvCommand___ctor(uVar3,0x27,uVar2,0);
		    uVar3 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,*(undefined4 *)(*param1 + 0xec),0);
		    Core_Data_Spells_SpellData__Create_object_
		              (uVar2,uVar3,Method_Core_Net_SrvCommand_SetCallback_ProtoGetUserExperimentsAns___);
		    Core_Net_AbstractService__LogCommandAnswer(param1,uVar2,0);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x59D3", Offset = "0x59D3", VA = "0x59D3")]
		public OpToken<IMessage, object> GetUserExperiments()
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x59D4", Offset = "0x59D4", VA = "0x59D4")]
		public void SetLevel(ProtoNewLevelEvt msg)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x59D5", Offset = "0x59D5", VA = "0x59D5")]
		public MainService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_MainService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTriggersChangedEvt__TypeInfo);
		    DAT_ram_00a559bb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTriggersChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTriggersChangedEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: add_TriggersChangedEvent ---
		void ServicesNamespace_MainService__add_TriggersChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559bc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTriggersChangedEvt__TypeInfo);
		    DAT_ram_00a559bc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTriggersChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTriggersChangedEvt__TypeInfo), iVar2 == 0)
		       ) break;
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


		/* --- GHIDRA: remove_TriggersChangedEvent ---
		void ServicesNamespace_MainService__remove_TriggersChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewLevelEvt__TypeInfo);
		    DAT_ram_00a559bd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewLevelEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewLevelEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_NewLevelEvent ---
		void ServicesNamespace_MainService__add_NewLevelEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewLevelEvt__TypeInfo);
		    DAT_ram_00a559be = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewLevelEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewLevelEvt__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_NewLevelEvent ---
		void ServicesNamespace_MainService__remove_NewLevelEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoExperienceChangedEvt__TypeInfo);
		    DAT_ram_00a559bf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoExperienceChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoExperienceChangedEvt__TypeInfo),
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


		/* --- GHIDRA: add_ExpChangedEvent ---
		void ServicesNamespace_MainService__add_ExpChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoExperienceChangedEvt__TypeInfo);
		    DAT_ram_00a559c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoExperienceChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoExperienceChangedEvt__TypeInfo),
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


		/* --- GHIDRA: remove_ExpChangedEvent ---
		void ServicesNamespace_MainService__remove_ExpChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoDictionariesUpdatedEvt__TypeInfo);
		    DAT_ram_00a559c2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoDictionariesUpdatedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoDictionariesUpdatedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_DictionariesUpdatedEvent ---
		void ServicesNamespace_MainService__remove_DictionariesUpdatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoInventoryChangedEvt__TypeInfo);
		    DAT_ram_00a559c3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoInventoryChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoInventoryChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_InventoryChangedEvent ---
		void ServicesNamespace_MainService__add_InventoryChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoInventoryChangedEvt__TypeInfo);
		    DAT_ram_00a559c4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoInventoryChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoInventoryChangedEvt__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InventoryChangedEvent ---
		void ServicesNamespace_MainService__remove_InventoryChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewMedalsEvt__TypeInfo);
		    DAT_ram_00a559c5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewMedalsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewMedalsEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: add_NewMedalsEvent ---
		void ServicesNamespace_MainService__add_NewMedalsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewMedalsEvt__TypeInfo);
		    DAT_ram_00a559c6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoNewMedalsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoNewMedalsEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: remove_NewMedalsEvent ---
		void ServicesNamespace_MainService__remove_NewMedalsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    DAT_ram_00a559c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTakeOffMedalsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTakeOffMedalsEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: add_TakeOffMedalsEvent ---
		void ServicesNamespace_MainService__add_TakeOffMedalsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    DAT_ram_00a559c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoTakeOffMedalsEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoTakeOffMedalsEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_TakeOffMedalsEvent ---
		void ServicesNamespace_MainService__remove_TakeOffMedalsEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a559c9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSkillsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSkillsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: add_SkillsChangedEvent ---
		void ServicesNamespace_MainService__add_SkillsChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a559ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    DAT_ram_00a559ca = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoSkillsChangedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoSkillsChangedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SkillsChangedEvent ---
		void ServicesNamespace_MainService__remove_SkillsChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a559cb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_MainEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoDictionariesUpdatedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoExperienceChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoInventoryChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoNewLevelEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoNewMedalsEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoSkillsChangedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoTakeOffMedalsEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoTriggersChangedEvt_TypeInfo);
		    DAT_ram_00a559cb = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x10);
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,iVar1,*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_MainEvents___);
		  if (iVar1 == 1) {
		    iVar1 = *(int *)(param1 + 0x20);
		    if (iVar1 == 0) {
		      return;
		    }
		    param1_00 = *(int **)(param2 + 0x20);
		    if ((param1_00 != (int *)0x0) &&
		       (Protocol_Main_ProtoDictionariesUpdatedEvt_TypeInfo != *param1_00)) {
		      System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoDictionariesUpdatedEvt_TypeInfo)
		      ;
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  else {
		    if (iVar1 == 2) {
		      return;
		    }
		    if (iVar1 == 3) {
		      return;
		    }
		    if (iVar1 == 4) {
		      return;
		    }
		    if (iVar1 == 5) {
		      return;
		    }
		    if (iVar1 == 6) {
		      return;
		    }
		    if (iVar1 == 7) {
		      return;
		    }
		    if (iVar1 == 8) {
		      return;
		    }
		    if (iVar1 == 9) {
		      return;
		    }
		    if (iVar1 == 10) {
		      return;
		    }
		    if (iVar1 == 0xb) {
		      return;
		    }
		    if (iVar1 == 0xc) {
		      return;
		    }
		    if (iVar1 == 0xd) {
		      return;
		    }
		    if (iVar1 == 0xe) {
		      return;
		    }
		    if (iVar1 == 0xf) {
		      iVar1 = *(int *)(param1 + 0x14);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Main_ProtoTriggersChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoTriggersChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0x10) {
		      iVar1 = *(int *)(param1 + 0x24);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Main_ProtoInventoryChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoInventoryChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0x11) {
		      iVar1 = *(int *)(param1 + 0x1c);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Main_ProtoExperienceChangedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoExperienceChangedEvt_TypeInfo)
		        ;
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0x12) {
		      iVar1 = *(int *)(param1 + 0x18);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoNewLevelEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoNewLevelEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0x13) {
		      iVar1 = *(int *)(param1 + 0x28);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoNewMedalsEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoNewMedalsEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar1 == 0x14) {
		      iVar1 = *(int *)(param1 + 0x2c);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoTakeOffMedalsEvt_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoTakeOffMedalsEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar1 == 0x15) {
		        return;
		      }
		      if (iVar1 == 0x16) {
		        return;
		      }
		      if (iVar1 != 0x17) {
		        return;
		      }
		      iVar1 = *(int *)(param1 + 0x30);
		      if (iVar1 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoSkillsChangedEvt_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoSkillsChangedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
