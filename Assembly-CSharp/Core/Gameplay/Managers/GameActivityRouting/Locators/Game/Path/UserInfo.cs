using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E7 RID: 4583
	[Token(Token = "0x20011E7")]
	public class UserInfo : AbstractPathNode
	{
		// Token: 0x06006CE7 RID: 27879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE7")]
		[Address(RVA = "0xB7D3", Offset = "0xB7D3", VA = "0xB7D3", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE8")]
		[Address(RVA = "0xB7D4", Offset = "0xB7D4", VA = "0xB7D4", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CE9")]
		[Address(RVA = "0xB7D5", Offset = "0xB7D5", VA = "0xB7D5")]
		public UserInfo()
		{
		/* --- GHIDRA: .cctor ---
		void Protocol_Common_UserInfo___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b1a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo___c_TypeInfo);
		    DAT_ram_00a5b1a2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Protocol_Common_UserInfo___c_TypeInfo);
		  **(undefined4 **)(Protocol_Common_UserInfo___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Protocol_Common_UserInfo___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b198 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b198 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_UserInfo_TypeInfo);
		  Protocol_Common_UserInfo___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Protocol_Common_UserInfo___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b198 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b198 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Common_UserInfo_TypeInfo);
		  Protocol_Common_UserInfo___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_UserInfo___ctor
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a72f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    DAT_ram_00a5a72f = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1f0);
		        goto code_r0x81263aaf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x26);
		code_r0x81263aaf:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Gameplay_Battles_Controller_BattlesController__ShowBosses(*(undefined4 *)(iVar3 + 0x18),0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Parser ---
		undefined4 Protocol_Common_UserInfo__get_Parser(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5b194 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_CommonReflection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MessageDescriptor__TypeInfo);
		    DAT_ram_00a5b194 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_CommonReflection_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_CommonReflection_TypeInfo);
		  }
		  if (DAT_ram_00a5b77e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_CommonReflection_TypeInfo);
		    DAT_ram_00a5b77e = '\x01';
		  }
		  if (*(int *)(Protocol_Common_CommonReflection_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_CommonReflection_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(**(int **)(Protocol_Common_CommonReflection_TypeInfo + 0x5c) + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_MessageDescriptor__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8133ef78;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MessageDescriptor__TypeInfo,0);
		code_r0x8133ef78:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,10,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_Descriptor ---
		undefined4 Protocol_Common_UserInfo__get_Descriptor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b195 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b195 = '\x01';
		  }
		  param1_00 = Protocol_Common_UserInfo_TypeInfo;
		  if (*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_UserInfo_TypeInfo);
		  }
		  uVar1 = Protocol_Common_UserInfo__get_Parser(param1_00);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: pb::Google.Protobuf.IMessage.get_Descriptor ---
		void Protocol_Common_UserInfo__pb__Google_Protobuf_IMessage_get_Descriptor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b196 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5b196 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = StringLiteral_5;
		  uVar1 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_ulong__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (uVar1,Method_Google_Protobuf_Collections_RepeatedField_ulong___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  uVar1 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_uint__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (uVar1,Method_Google_Protobuf_Collections_RepeatedField_uint___ctor__);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_uint__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (uVar1,Method_Google_Protobuf_Collections_RepeatedField_uint___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: get_Nick ---
		void Protocol_Common_UserInfo__get_Nick(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b199 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_ProtoPreconditions_CheckNotNull_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    DAT_ram_00a5b199 = '\x01';
		  }
		  uVar1 = func_ii_13435(param2,StringLiteral_28217,
		                        Method_Google_Protobuf_ProtoPreconditions_CheckNotNull_string___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: set_ClanInfo ---
		undefined4 Protocol_Common_UserInfo__set_ClanInfo(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param2_00;
		  
		  if (DAT_ram_00a5b19a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b19a = '\x01';
		  }
		  if (param2 == (int *)0x0) {
		    param2_00 = (int *)0x0;
		  }
		  else {
		    param2_00 = param2;
		    if (*param2 != Protocol_Common_UserInfo_TypeInfo) {
		      param2_00 = (int *)0x0;
		    }
		  }
		  uVar1 = Protocol_Common_UserInfo__Equals(param1,param2_00,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		uint Protocol_Common_UserInfo__Equals(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint uVar3;
		  uint uVar4;
		  int *piVar5;
		  int iVar6;
		  longlong local_8;
		  
		  local_8 = 0;
		  if (*(longlong *)(param1 + 0x10) == 0) {
		    uVar1 = 1;
		  }
		  else {
		    local_8 = *(longlong *)(param1 + 0x10);
		    uVar1 = System_TimeSpan__Equals(&local_8,0);
		    uVar1 = uVar1 ^ 1;
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  if (piVar5[2] != 0) {
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xd4));
		    uVar1 = uVar4 ^ uVar1;
		  }
		  if (*(uint *)(param1 + 0x1c) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x1c);
		  }
		  if (*(uint *)(param1 + 0x20) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x20);
		  }
		  if (*(uint *)(param1 + 0x24) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x24);
		  }
		  if (*(uint *)(param1 + 0x28) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x28);
		  }
		  if (*(uint *)(param1 + 0x2c) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x2c);
		  }
		  if (*(uint *)(param1 + 0x30) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x30);
		  }
		  iVar6 = **(int **)(param1 + 0x34);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xd0) * 4))
		                    (*(int **)(param1 + 0x34),*(undefined4 *)(iVar6 + 0xd4));
		  iVar6 = **(int **)(param1 + 0x38);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xd0) * 4))
		                    (*(int **)(param1 + 0x38),*(undefined4 *)(iVar6 + 0xd4));
		  iVar6 = **(int **)(param1 + 0x3c);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xd0) * 4))
		                    (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar6 + 0xd4));
		  uVar4 = uVar2 ^ uVar1 ^ uVar3 ^ uVar4;
		  piVar5 = *(int **)(param1 + 0x40);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xd4));
		    uVar4 = uVar1 ^ uVar4;
		  }
		  piVar5 = *(int **)(param1 + 8);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xd4));
		    uVar4 = uVar1 ^ uVar4;
		  }
		  return uVar4;
		}
		*/


		/* --- GHIDRA: Equals ---
		uint Protocol_Common_UserInfo__Equals(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint uVar3;
		  uint uVar4;
		  int *piVar5;
		  int iVar6;
		  longlong local_8;
		  
		  local_8 = 0;
		  if (*(longlong *)(param1 + 0x10) == 0) {
		    uVar1 = 1;
		  }
		  else {
		    local_8 = *(longlong *)(param1 + 0x10);
		    uVar1 = System_TimeSpan__Equals(&local_8,0);
		    uVar1 = uVar1 ^ 1;
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  if (piVar5[2] != 0) {
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xd4));
		    uVar1 = uVar4 ^ uVar1;
		  }
		  if (*(uint *)(param1 + 0x1c) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x1c);
		  }
		  if (*(uint *)(param1 + 0x20) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x20);
		  }
		  if (*(uint *)(param1 + 0x24) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x24);
		  }
		  if (*(uint *)(param1 + 0x28) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x28);
		  }
		  if (*(uint *)(param1 + 0x2c) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x2c);
		  }
		  if (*(uint *)(param1 + 0x30) != 0) {
		    uVar1 = uVar1 ^ *(uint *)(param1 + 0x30);
		  }
		  iVar6 = **(int **)(param1 + 0x34);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xd0) * 4))
		                    (*(int **)(param1 + 0x34),*(undefined4 *)(iVar6 + 0xd4));
		  iVar6 = **(int **)(param1 + 0x38);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xd0) * 4))
		                    (*(int **)(param1 + 0x38),*(undefined4 *)(iVar6 + 0xd4));
		  iVar6 = **(int **)(param1 + 0x3c);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xd0) * 4))
		                    (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar6 + 0xd4));
		  uVar4 = uVar2 ^ uVar1 ^ uVar3 ^ uVar4;
		  piVar5 = *(int **)(param1 + 0x40);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xd4));
		    uVar4 = uVar1 ^ uVar4;
		  }
		  piVar5 = *(int **)(param1 + 8);
		  if (piVar5 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd0) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xd4));
		    uVar4 = uVar1 ^ uVar4;
		  }
		  return uVar4;
		}
		*/


		/* --- GHIDRA: GetHashCode ---
		undefined4 Protocol_Common_UserInfo__GetHashCode(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b19c == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_JsonFormatter_TypeInfo);
		    DAT_ram_00a5b19c = '\x01';
		  }
		  if (*(int *)(Google_Protobuf_JsonFormatter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Protobuf_JsonFormatter_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_JsonFormatter__Format(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Protocol_Common_UserInfo__ToString(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b19d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong__WriteTo__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__WriteTo__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b19d = '\x01';
		  }
		  if (*(longlong *)(param1 + 0x10) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,8,0);
		    Google_Protobuf_CodedOutputStream__WriteRawVarint32(param2,*(undefined8 *)(param1 + 0x10),0);
		  }
		  if (*(int *)(*(int *)(param1 + 0x18) + 8) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x12,0);
		    Google_Protobuf_CodedOutputStream__WriteBool(param2,*(undefined4 *)(param1 + 0x18),0);
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x18,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x1c),0);
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x20,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x20),0);
		  }
		  if (*(int *)(param1 + 0x24) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x28,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x24),0);
		  }
		  if (*(int *)(param1 + 0x28) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x30,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x28),0);
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x38,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x2c),0);
		  }
		  if (*(int *)(param1 + 0x30) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x40,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x30),0);
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_UserInfo_TypeInfo);
		  }
		  Google_Protobuf_Collections_RepeatedField_ulong___ToString
		            (param1_00,param2,
		             *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 4),
		             Method_Google_Protobuf_Collections_RepeatedField_ulong__WriteTo__);
		  Google_Protobuf_Collections_RepeatedField_uint___ToString
		            (*(undefined4 *)(param1 + 0x38),param2,
		             *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 8),
		             Method_Google_Protobuf_Collections_RepeatedField_uint__WriteTo__);
		  Google_Protobuf_Collections_RepeatedField_uint___ToString
		            (*(undefined4 *)(param1 + 0x3c),param2,
		             *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 0xc),
		             Method_Google_Protobuf_Collections_RepeatedField_uint__WriteTo__);
		  if (*(int *)(param1 + 0x40) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x62,0);
		    Google_Protobuf_CodedOutputStream__WriteTag(param2,*(undefined4 *)(param1 + 0x40),0);
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    Google_Protobuf_UnknownFieldSet__HasField(*(int *)(param1 + 8),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: WriteTo ---
		int Protocol_Common_UserInfo__WriteTo(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int iVar4;
		  longlong param1_01;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5b19e == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_CodedOutputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__CalculateSize__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__CalculateSize__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b19e = '\x01';
		  }
		  param1_01 = *(longlong *)(param1 + 0x10);
		  if (param1_01 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar4 = Google_Protobuf_CodedOutputStream__ComputeFloatSize(param1_01,0);
		    iVar4 = iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x18);
		  if (*(int *)(iVar3 + 8) != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBoolSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x20);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x24);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x28);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x2c);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  iVar3 = *(int *)(param1 + 0x30);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar3 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar3,0);
		    iVar4 = iVar3 + iVar4 + 1;
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_UserInfo_TypeInfo);
		  }
		  iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___CalculatePackedDataSize
		                    (param1_00,
		                     *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 4),
		                     Method_Google_Protobuf_Collections_RepeatedField_ulong__CalculateSize__);
		  iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CalculatePackedDataSize
		                    (*(undefined4 *)(param1 + 0x38),
		                     *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 8),
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__CalculateSize__);
		  iVar3 = Google_Protobuf_Collections_RepeatedField_uint___CalculatePackedDataSize
		                    (*(undefined4 *)(param1 + 0x3c),
		                     *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 0xc),
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__CalculateSize__);
		  iVar3 = iVar1 + iVar4 + iVar2 + iVar3;
		  iVar4 = *(int *)(param1 + 0x40);
		  if (iVar4 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar4 = Google_Protobuf_CodedOutputStream__ComputeRawVarint32Size(iVar4,0);
		    iVar3 = iVar4 + iVar3 + 1;
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    iVar4 = Google_Protobuf_UnknownFieldSet__WriteTo(*(int *)(param1 + 8),0);
		    iVar3 = iVar4 + iVar3;
		  }
		  return iVar3;
		}
		*/


		/* --- GHIDRA: CalculateSize ---
		void Protocol_Common_UserInfo__CalculateSize(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a5b19f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ClanShortInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    DAT_ram_00a5b19f = '\x01';
		  }
		  if (param2 != 0) {
		    if (*(longlong *)(param2 + 0x10) != 0) {
		      *(longlong *)(param1 + 0x10) = *(longlong *)(param2 + 0x10);
		    }
		    iVar2 = *(int *)(param2 + 0x18);
		    if (*(int *)(iVar2 + 8) != 0) {
		      if (DAT_ram_00a5b199 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_Google_Protobuf_ProtoPreconditions_CheckNotNull_string___);
		        Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		        DAT_ram_00a5b199 = '\x01';
		      }
		      uVar1 = func_ii_13435(iVar2,StringLiteral_28217,
		                            Method_Google_Protobuf_ProtoPreconditions_CheckNotNull_string___);
		      *(undefined4 *)(param1 + 0x18) = uVar1;
		    }
		    if (*(int *)(param2 + 0x1c) != 0) {
		      *(int *)(param1 + 0x1c) = *(int *)(param2 + 0x1c);
		    }
		    if (*(int *)(param2 + 0x20) != 0) {
		      *(int *)(param1 + 0x20) = *(int *)(param2 + 0x20);
		    }
		    if (*(int *)(param2 + 0x24) != 0) {
		      *(int *)(param1 + 0x24) = *(int *)(param2 + 0x24);
		    }
		    if (*(int *)(param2 + 0x28) != 0) {
		      *(int *)(param1 + 0x28) = *(int *)(param2 + 0x28);
		    }
		    if (*(int *)(param2 + 0x2c) != 0) {
		      *(int *)(param1 + 0x2c) = *(int *)(param2 + 0x2c);
		    }
		    if (*(int *)(param2 + 0x30) != 0) {
		      *(int *)(param1 + 0x30) = *(int *)(param2 + 0x30);
		    }
		    Google_Protobuf_Collections_RepeatedField_ulong___Add
		              (*(undefined4 *)(param1 + 0x34),*(undefined4 *)(param2 + 0x34),
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    Google_Protobuf_Collections_RepeatedField_uint____ctor
		              (*(undefined4 *)(param1 + 0x38),*(undefined4 *)(param2 + 0x38),
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Google_Protobuf_Collections_RepeatedField_uint____ctor
		              (*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(param2 + 0x3c),
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    iVar2 = *(int *)(param2 + 0x40);
		    if (iVar2 != 0) {
		      param1_00 = *(int *)(param1 + 0x40);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417(Protocol_Common_ClanShortInfo_TypeInfo);
		        if (DAT_ram_00a5b1ea == '\0') {
		          Mono_Security_ASN1__get_Item(&StringLiteral_5);
		          DAT_ram_00a5b1ea = '\x01';
		        }
		        *(undefined4 *)(param1_00 + 0x18) = StringLiteral_5;
		        *(int *)(param1 + 0x40) = param1_00;
		        iVar2 = *(int *)(param2 + 0x40);
		      }
		      Protocol_Common_ClanShortInfo__CalculateSize(param1_00,iVar2,param2);
		    }
		    uVar1 = Google_Protobuf_UnknownFieldSet__MergeFrom
		                      (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Common_UserInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b1a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_UserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_MessageParser_UserInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_MessageParser_UserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Protocol_Common_UserInfo___c___cctor_b__80_0__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b1a1 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_UserInfo___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_UserInfo___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)(Protocol_Common_UserInfo___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_UserInfo__TypeInfo);
		  func_ii_19797(uVar1,uVar2,Method_Protocol_Common_UserInfo___c___cctor_b__80_0__,0);
		  uVar2 = unnamed_function_1417(Google_Protobuf_MessageParser_UserInfo__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,Method_Google_Protobuf_MessageParser_UserInfo___ctor__);
		  **(undefined4 **)(Protocol_Common_UserInfo_TypeInfo + 0x5c) = uVar2;
		  uVar1 = Google_Protobuf_FieldCodec__ForSFixed64(0x4a,0);
		  *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 4) = uVar1;
		  uVar1 = Google_Protobuf_FieldCodec__ForSFixed32(0x52,0);
		  *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 8) = uVar1;
		  uVar1 = Google_Protobuf_FieldCodec__ForSFixed32(0x5a,0);
		  *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 0xc) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Common_UserInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b1a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_UserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_MessageParser_UserInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_MessageParser_UserInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Protocol_Common_UserInfo___c___cctor_b__80_0__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    DAT_ram_00a5b1a1 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_UserInfo___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_UserInfo___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)(Protocol_Common_UserInfo___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_UserInfo__TypeInfo);
		  func_ii_19797(uVar1,uVar2,Method_Protocol_Common_UserInfo___c___cctor_b__80_0__,0);
		  uVar2 = unnamed_function_1417(Google_Protobuf_MessageParser_UserInfo__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,Method_Google_Protobuf_MessageParser_UserInfo___ctor__);
		  **(undefined4 **)(Protocol_Common_UserInfo_TypeInfo + 0x5c) = uVar2;
		  uVar1 = Google_Protobuf_FieldCodec__ForSFixed64(0x4a,0);
		  *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 4) = uVar1;
		  uVar1 = Google_Protobuf_FieldCodec__ForSFixed32(0x52,0);
		  *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 8) = uVar1;
		  uVar1 = Google_Protobuf_FieldCodec__ForSFixed32(0x5a,0);
		  *(undefined4 *)(*(int *)(Protocol_Common_UserInfo_TypeInfo + 0x5c) + 0xc) = uVar1;
		  return;
		}
		*/

}
