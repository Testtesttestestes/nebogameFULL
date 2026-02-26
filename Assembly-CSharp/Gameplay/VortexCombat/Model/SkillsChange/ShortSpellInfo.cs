using System;
using System.Collections.Generic;
using Gameplay.Combat.Model.SkillsChange;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Partycombat;

namespace Gameplay.VortexCombat.Model.SkillsChange
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	public class ShortSpellInfo : AbstractShortSpellInfo<PlayerSkillsInfo.Types.ShortSpellInfo>
	{
		// Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x67F6", Offset = "0x67F6", VA = "0x67F6")]
		public ShortSpellInfo(PlayerSkillsInfo.Types.ShortSpellInfo info)
		{
		/* --- GHIDRA: .cctor ---
		void Protocol_Common_ShortSpellInfo___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a52ed2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a52ed2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Protocol_Common_ShortSpellInfo___c_TypeInfo);
		  **(undefined4 **)(Protocol_Common_ShortSpellInfo___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Protocol_Common_ShortSpellInfo___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b27a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a5b27a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ShortSpellInfo_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(param1 + 0xc);
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(iVar1 + 0x14) = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(param1 + 0x1c);
		  *(undefined8 *)(iVar1 + 0x20) = *(undefined8 *)(param1 + 0x20);
		  uVar2 = Google_Protobuf_UnknownFieldSet__MergeFrom(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Protocol_Common_ShortSpellInfo___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5b27a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a5b27a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Protocol_Common_ShortSpellInfo_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(param1 + 0xc);
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param1 + 0x10);
		  *(undefined4 *)(iVar1 + 0x14) = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(param1 + 0x18);
		  *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(param1 + 0x1c);
		  *(undefined8 *)(iVar1 + 0x20) = *(undefined8 *)(param1 + 0x20);
		  uVar2 = Google_Protobuf_UnknownFieldSet__MergeFrom(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5328f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a5328f = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo);
		  **(undefined4 **)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo + 0x5c)
		       = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a53286 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a53286 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		  Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a53286 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a53286 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		  Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a53504 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a53504 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo);
		  **(undefined4 **)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo + 0x5c)
		       = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a534fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a534fb = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		  Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a534fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a534fb = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		  Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B5")]
		public override SpellKey SpellKey
		{
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x67F7", Offset = "0x67F7", VA = "0x67F7", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B6")]
		public override IList<EffectInfo> Effects
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x67F8", Offset = "0x67F8", VA = "0x67F8", Slot = "8")]
			get
			{
				return null;
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Effects ---
		void Gameplay_VortexCombat_Model_SkillsChange_ShortSpellInfo__get_Effects
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58234 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Model_FieldChange_AbstractFieldChangeDecorator_FieldChangedInfo___ctor__
		              );
		    DAT_ram_00a58234 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (param1,param2,
		             Method_Gameplay_Combat_Model_FieldChange_AbstractFieldChangeDecorator_FieldChangedInfo___ctor__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: get_Parser ---
		undefined4 Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__get_Parser(undefined4 param1)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a534f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MessageDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Partycombat_PlayerSkillsInfo_TypeInfo);
		    DAT_ram_00a534f7 = '\x01';
		  }
		  if (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Partycombat_PlayerSkillsInfo_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = Protocol_Partycombat_PlayerSkillsInfo__get_Parser(0);
		  param1_00 = *(int **)(iVar2 + 0x34);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_MessageDescriptor__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x808c8377;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MessageDescriptor__TypeInfo,0);
		code_r0x808c8377:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,0,puVar3[1]);
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_Descriptor ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__get_Descriptor
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a534f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a534f8 = '\x01';
		  }
		  param1_00 = Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo;
		  if (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		  }
		  uVar1 = Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__get_Parser(param1_00);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: pb::Google.Protobuf.IMessage.get_Descriptor ---
		void Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__pb__Google_Protobuf_IMessage_get_Descriptor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a534f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_EffectInfo__TypeInfo);
		    DAT_ram_00a534f9 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_EffectInfo__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_EffectInfo___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: get_Effects ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__get_Effects
		          (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)0x0;
		  if (DAT_ram_00a534fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a534fc = '\x01';
		  }
		  if ((param2 != (int *)0x0) &&
		     (piVar2 = param2,
		     *param2 != Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo)) {
		    piVar2 = (int *)0x0;
		  }
		  uVar1 = 0;
		  if (DAT_ram_00a534fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__);
		    DAT_ram_00a534fd = '\x01';
		  }
		  if (piVar2 != (int *)0x0) {
		    if (param1 == piVar2) {
		      return 1;
		    }
		    iVar3 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[3],piVar2[3],0);
		    if ((iVar3 != 0) &&
		       (iVar3 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                          (param1[4],piVar2[4],
		                           Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__),
		       iVar3 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[2],piVar2[2],0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__Equals
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a534fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__);
		    DAT_ram_00a534fd = '\x01';
		  }
		  if (param2 != 0) {
		    if (param1 == param2) {
		      return 1;
		    }
		    iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                      (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),0);
		    if ((iVar2 != 0) &&
		       (iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                          (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		                           Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__),
		       iVar2 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__Equals
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a534fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__);
		    DAT_ram_00a534fd = '\x01';
		  }
		  if (param2 != 0) {
		    if (param1 == param2) {
		      return 1;
		    }
		    iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                      (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),0);
		    if ((iVar2 != 0) &&
		       (iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                          (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		                           Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__),
		       iVar2 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetHashCode ---
		undefined4
		Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__GetHashCode
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a534fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_JsonFormatter_TypeInfo);
		    DAT_ram_00a534fe = '\x01';
		  }
		  if (*(int *)(Google_Protobuf_JsonFormatter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Protobuf_JsonFormatter_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_JsonFormatter__Format(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__ToString
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a534ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__WriteTo__);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a534ff = '\x01';
		  }
		  if (*(int *)(param1 + 0xc) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,10,0);
		    Google_Protobuf_CodedOutputStream__WriteTag(param2,*(undefined4 *)(param1 + 0xc),0);
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___ToString
		            (param1_00,param2,
		             *(undefined4 *)
		              (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x5c)
		              + 4),Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__WriteTo__);
		  if (*(int *)(param1 + 8) != 0) {
		    Google_Protobuf_UnknownFieldSet__HasField(*(int *)(param1 + 8),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: WriteTo ---
		int Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__WriteTo
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a53500 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_CodedOutputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__CalculateSize__);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a53500 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar1 = Google_Protobuf_CodedOutputStream__ComputeRawVarint32Size(iVar2,0);
		    iVar1 = iVar1 + 1;
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___CalculatePackedDataSize
		                    (param1_00,
		                     *(undefined4 *)
		                      (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo
		                               + 0x5c) + 4),
		                     Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__CalculateSize__);
		  iVar2 = iVar2 + iVar1;
		  if (*(int *)(param1 + 8) != 0) {
		    iVar1 = Google_Protobuf_UnknownFieldSet__WriteTo(*(int *)(param1 + 8),0);
		    iVar2 = iVar1 + iVar2;
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: CalculateSize ---
		void Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__CalculateSize
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a53501 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_SpellKey_TypeInfo);
		    DAT_ram_00a53501 = '\x01';
		  }
		  if (param2 != 0) {
		    param2_00 = *(int *)(param2 + 0xc);
		    if (param2_00 != 0) {
		      param1_00 = *(int *)(param1 + 0xc);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417(Protocol_Common_SpellKey_TypeInfo);
		        *(int *)(param1 + 0xc) = param1_00;
		        param2_00 = *(int *)(param2 + 0xc);
		      }
		      Google_Protobuf_Reflection_EnumDescriptorProto_Types_EnumReservedRange__CalculateSize
		                (param1_00,param2_00,0);
		    }
		    Google_Protobuf_Collections_RepeatedField_object____ctor
		              (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		               Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Add__);
		    uVar1 = Google_Protobuf_UnknownFieldSet__MergeFrom
		                      (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a53503 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c___cctor_b__30_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a53503 = '\x01';
		  }
		  if (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)
		            (Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		  func_ii_19797(uVar1,uVar2,
		                Method_Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c___cctor_b__30_0__
		                ,0);
		  uVar2 = unnamed_function_1417
		                    (Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,
		             Method_Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo___ctor__);
		  **(undefined4 **)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x5c) =
		       uVar2;
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  if (DAT_ram_00a53572 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    DAT_ram_00a53572 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_FieldCodec__ForEnum___Il2CppFullySharedGenericType_
		                    (0x12,**(undefined4 **)(Protocol_Common_EffectInfo_TypeInfo + 0x5c),
		                     Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		  *(undefined4 *)
		   (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x5c) + 4) =
		       uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a53503 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c___cctor_b__30_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a53503 = '\x01';
		  }
		  if (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)
		            (Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		  func_ii_19797(uVar1,uVar2,
		                Method_Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo___c___cctor_b__30_0__
		                ,0);
		  uVar2 = unnamed_function_1417
		                    (Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,
		             Method_Google_Protobuf_MessageParser_PlayerSkillsInfo_Types_ShortSpellInfo___ctor__);
		  **(undefined4 **)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x5c) =
		       uVar2;
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  if (DAT_ram_00a53572 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    DAT_ram_00a53572 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_FieldCodec__ForEnum___Il2CppFullySharedGenericType_
		                    (0x12,**(undefined4 **)(Protocol_Common_EffectInfo_TypeInfo + 0x5c),
		                     Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		  *(undefined4 *)
		   (*(int *)(Protocol_Partycombat_PlayerSkillsInfo_Types_ShortSpellInfo_TypeInfo + 0x5c) + 4) =
		       uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: get_Parser ---
		undefined4 Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__get_Parser(undefined4 param1)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a53282 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MessageDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoSkillsChangedEvt_TypeInfo);
		    DAT_ram_00a53282 = '\x01';
		  }
		  if (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Combat_ProtoSkillsChangedEvt_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = Protocol_Combat_ProtoSkillsChangedEvt__get_Parser(0);
		  param1_00 = *(int **)(iVar2 + 0x34);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_MessageDescriptor__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x808b4b1e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MessageDescriptor__TypeInfo,0);
		code_r0x808b4b1e:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,0,puVar3[1]);
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_Descriptor ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__get_Descriptor
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a53283 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a53283 = '\x01';
		  }
		  param1_00 = Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo;
		  if (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		  }
		  uVar1 = Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__get_Parser(param1_00);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: pb::Google.Protobuf.IMessage.get_Descriptor ---
		void Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__pb__Google_Protobuf_IMessage_get_Descriptor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a53284 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_EffectInfo__TypeInfo);
		    DAT_ram_00a53284 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_EffectInfo__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_EffectInfo___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: get_Effects ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__get_Effects
		          (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)0x0;
		  if (DAT_ram_00a53287 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a53287 = '\x01';
		  }
		  if ((param2 != (int *)0x0) &&
		     (piVar2 = param2,
		     *param2 != Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo)) {
		    piVar2 = (int *)0x0;
		  }
		  uVar1 = 0;
		  if (DAT_ram_00a53288 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__);
		    DAT_ram_00a53288 = '\x01';
		  }
		  if (piVar2 != (int *)0x0) {
		    if (param1 == piVar2) {
		      return 1;
		    }
		    iVar3 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[3],piVar2[3],0);
		    if ((iVar3 != 0) &&
		       (iVar3 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                          (param1[4],piVar2[4],
		                           Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__),
		       iVar3 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[2],piVar2[2],0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__Equals
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a53288 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__);
		    DAT_ram_00a53288 = '\x01';
		  }
		  if (param2 != 0) {
		    if (param1 == param2) {
		      return 1;
		    }
		    iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                      (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),0);
		    if ((iVar2 != 0) &&
		       (iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                          (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		                           Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__),
		       iVar2 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__Equals
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a53288 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__);
		    DAT_ram_00a53288 = '\x01';
		  }
		  if (param2 != 0) {
		    if (param1 == param2) {
		      return 1;
		    }
		    iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                      (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param2 + 0xc),0);
		    if ((iVar2 != 0) &&
		       (iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                          (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		                           Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Equals__),
		       iVar2 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetHashCode ---
		undefined4
		Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__GetHashCode
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a53289 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_JsonFormatter_TypeInfo);
		    DAT_ram_00a53289 = '\x01';
		  }
		  if (*(int *)(Google_Protobuf_JsonFormatter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Protobuf_JsonFormatter_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_JsonFormatter__Format(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__ToString
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5328a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__WriteTo__);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a5328a = '\x01';
		  }
		  if (*(int *)(param1 + 0xc) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,10,0);
		    Google_Protobuf_CodedOutputStream__WriteTag(param2,*(undefined4 *)(param1 + 0xc),0);
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___ToString
		            (param1_00,param2,
		             *(undefined4 *)
		              (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x5c)
		              + 4),Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__WriteTo__);
		  if (*(int *)(param1 + 8) != 0) {
		    Google_Protobuf_UnknownFieldSet__HasField(*(int *)(param1 + 8),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: WriteTo ---
		int Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__WriteTo
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5328b == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_CodedOutputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__CalculateSize__);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a5328b = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar1 = Google_Protobuf_CodedOutputStream__ComputeRawVarint32Size(iVar2,0);
		    iVar1 = iVar1 + 1;
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___CalculatePackedDataSize
		                    (param1_00,
		                     *(undefined4 *)
		                      (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo
		                               + 0x5c) + 4),
		                     Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__CalculateSize__);
		  iVar2 = iVar2 + iVar1;
		  if (*(int *)(param1 + 8) != 0) {
		    iVar1 = Google_Protobuf_UnknownFieldSet__WriteTo(*(int *)(param1 + 8),0);
		    iVar2 = iVar1 + iVar2;
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: CalculateSize ---
		void Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__CalculateSize
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a5328c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_SpellKey_TypeInfo);
		    DAT_ram_00a5328c = '\x01';
		  }
		  if (param2 != 0) {
		    param2_00 = *(int *)(param2 + 0xc);
		    if (param2_00 != 0) {
		      param1_00 = *(int *)(param1 + 0xc);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417(Protocol_Common_SpellKey_TypeInfo);
		        *(int *)(param1 + 0xc) = param1_00;
		        param2_00 = *(int *)(param2 + 0xc);
		      }
		      Google_Protobuf_Reflection_EnumDescriptorProto_Types_EnumReservedRange__CalculateSize
		                (param1_00,param2_00,0);
		    }
		    Google_Protobuf_Collections_RepeatedField_object____ctor
		              (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		               Method_Google_Protobuf_Collections_RepeatedField_EffectInfo__Add__);
		    uVar1 = Google_Protobuf_UnknownFieldSet__MergeFrom
		                      (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5328e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c___cctor_b__30_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a5328e = '\x01';
		  }
		  if (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)
		            (Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo);
		  func_ii_19797(uVar1,uVar2,
		                Method_Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c___cctor_b__30_0__
		                ,0);
		  uVar2 = unnamed_function_1417
		                    (
		                    Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo
		                    );
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,
		             Method_Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor__
		            );
		  **(undefined4 **)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x5c) =
		       uVar2;
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  if (DAT_ram_00a53572 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    DAT_ram_00a53572 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_FieldCodec__ForEnum___Il2CppFullySharedGenericType_
		                    (0x12,**(undefined4 **)(Protocol_Common_EffectInfo_TypeInfo + 0x5c),
		                     Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		  *(undefined4 *)
		   (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x5c) + 4) =
		       uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5328e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c___cctor_b__30_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a5328e = '\x01';
		  }
		  if (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)
		            (Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo);
		  func_ii_19797(uVar1,uVar2,
		                Method_Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo___c___cctor_b__30_0__
		                ,0);
		  uVar2 = unnamed_function_1417
		                    (
		                    Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo__TypeInfo
		                    );
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,
		             Method_Google_Protobuf_MessageParser_ProtoSkillsChangedEvt_Types_ShortSpellInfo___ctor__
		            );
		  **(undefined4 **)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x5c) =
		       uVar2;
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  if (DAT_ram_00a53572 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_EffectInfo_TypeInfo);
		    DAT_ram_00a53572 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_EffectInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_EffectInfo_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_FieldCodec__ForEnum___Il2CppFullySharedGenericType_
		                    (0x12,**(undefined4 **)(Protocol_Common_EffectInfo_TypeInfo + 0x5c),
		                     Method_Google_Protobuf_FieldCodec_ForMessage_EffectInfo___);
		  *(undefined4 *)
		   (*(int *)(Protocol_Combat_ProtoSkillsChangedEvt_Types_ShortSpellInfo_TypeInfo + 0x5c) + 4) =
		       uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: get_Parser ---
		undefined4 Protocol_Common_ShortSpellInfo__get_Parser(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5b278 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_CommonReflection_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MessageDescriptor__TypeInfo);
		    DAT_ram_00a5b278 = '\x01';
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
		        goto code_r0x81349a85;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MessageDescriptor__TypeInfo,0);
		code_r0x81349a85:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,0x1c,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_Descriptor ---
		undefined4 Protocol_Common_ShortSpellInfo__get_Descriptor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b279 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a5b279 = '\x01';
		  }
		  param1_00 = Protocol_Common_ShortSpellInfo_TypeInfo;
		  if (*(int *)(Protocol_Common_ShortSpellInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_ShortSpellInfo_TypeInfo);
		  }
		  uVar1 = Protocol_Common_ShortSpellInfo__get_Parser(param1_00);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_ILearnPriceCoeff ---
		undefined4
		Protocol_Common_ShortSpellInfo__set_ILearnPriceCoeff
		          (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param2_00;
		  
		  if (DAT_ram_00a5b27b == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    DAT_ram_00a5b27b = '\x01';
		  }
		  if (param2 == (int *)0x0) {
		    param2_00 = (int *)0x0;
		  }
		  else {
		    param2_00 = param2;
		    if (*param2 != Protocol_Common_ShortSpellInfo_TypeInfo) {
		      param2_00 = (int *)0x0;
		    }
		  }
		  uVar1 = Protocol_Common_ShortSpellInfo__Equals(param1,param2_00,param2);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		uint Protocol_Common_ShortSpellInfo__Equals(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  uint uVar1;
		  int *piVar2;
		  uint uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5b27d == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		    DAT_ram_00a5b27d = '\x01';
		  }
		  if (*(uint *)(param1 + 0xc) == 0) {
		    uVar3 = 1;
		  }
		  else {
		    uVar3 = *(uint *)(param1 + 0xc) ^ 1;
		  }
		  if (*(uint *)(param1 + 0x10) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x10);
		  }
		  if (*(uint *)(param1 + 0x14) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x14);
		  }
		  if (*(uint *)(param1 + 0x18) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x18);
		  }
		  if (*(uint *)(param1 + 0x1c) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x1c);
		  }
		  if (*(double *)(param1 + 0x20) != 0.0) {
		    if (*(int *)(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		    }
		    if (DAT_ram_00a64072 == '\0') {
		      Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		      DAT_ram_00a64072 = '\x01';
		    }
		    if (*(int *)(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		    }
		    uVar4 = *(undefined8 *)(param1 + 0x20);
		    iVar5 = *(int *)**(undefined4 **)
		                      (Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo + 0x5c);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x108) * 4))
		                      ((int *)**(undefined4 **)
		                                (Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo +
		                                0x5c),uVar4,*(undefined4 *)(iVar5 + 0x10c));
		    in_register_20000014 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar3 = uVar1 ^ uVar3;
		  }
		  piVar2 = *(int **)(param1 + 8);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,CONCAT44(in_register_20000014,*(undefined4 *)(*piVar2 + 0xd4)));
		    uVar3 = uVar1 ^ uVar3;
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: Equals ---
		uint Protocol_Common_ShortSpellInfo__Equals(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  uint uVar1;
		  int *piVar2;
		  uint uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5b27d == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		    DAT_ram_00a5b27d = '\x01';
		  }
		  if (*(uint *)(param1 + 0xc) == 0) {
		    uVar3 = 1;
		  }
		  else {
		    uVar3 = *(uint *)(param1 + 0xc) ^ 1;
		  }
		  if (*(uint *)(param1 + 0x10) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x10);
		  }
		  if (*(uint *)(param1 + 0x14) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x14);
		  }
		  if (*(uint *)(param1 + 0x18) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x18);
		  }
		  if (*(uint *)(param1 + 0x1c) != 0) {
		    uVar3 = uVar3 ^ *(uint *)(param1 + 0x1c);
		  }
		  if (*(double *)(param1 + 0x20) != 0.0) {
		    if (*(int *)(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		    }
		    if (DAT_ram_00a64072 == '\0') {
		      Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		      DAT_ram_00a64072 = '\x01';
		    }
		    if (*(int *)(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo);
		    }
		    uVar4 = *(undefined8 *)(param1 + 0x20);
		    iVar5 = *(int *)**(undefined4 **)
		                      (Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo + 0x5c);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x108) * 4))
		                      ((int *)**(undefined4 **)
		                                (Google_Protobuf_Collections_ProtobufEqualityComparers_TypeInfo +
		                                0x5c),uVar4,*(undefined4 *)(iVar5 + 0x10c));
		    in_register_20000014 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar3 = uVar1 ^ uVar3;
		  }
		  piVar2 = *(int **)(param1 + 8);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,CONCAT44(in_register_20000014,*(undefined4 *)(*piVar2 + 0xd4)));
		    uVar3 = uVar1 ^ uVar3;
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: GetHashCode ---
		undefined4 Protocol_Common_ShortSpellInfo__GetHashCode(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b27e == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_JsonFormatter_TypeInfo);
		    DAT_ram_00a5b27e = '\x01';
		  }
		  if (*(int *)(Google_Protobuf_JsonFormatter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Protobuf_JsonFormatter_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_JsonFormatter__Format(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Protocol_Common_ShortSpellInfo__ToString(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (*(int *)(param1 + 0xc) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,8,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0xc),0);
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x10,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x10),0);
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x18,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x14),0);
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x20,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x18),0);
		  }
		  if (*(int *)(param1 + 0x1c) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x28,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0x1c),0);
		  }
		  if (*(double *)(param1 + 0x20) != 0.0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x31,0);
		    Google_Protobuf_CodedOutputStream__get_Position(param2,*(double *)(param1 + 0x20),0);
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    Google_Protobuf_UnknownFieldSet__HasField(*(int *)(param1 + 8),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: WriteTo ---
		int Protocol_Common_ShortSpellInfo__WriteTo(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5b27f == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_CodedOutputStream_TypeInfo);
		    DAT_ram_00a5b27f = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar1 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar2,0);
		    iVar1 = iVar1 + 1;
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar2,0);
		    iVar1 = iVar2 + iVar1 + 1;
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar2,0);
		    iVar1 = iVar2 + iVar1 + 1;
		  }
		  iVar2 = *(int *)(param1 + 0x18);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar2,0);
		    iVar1 = iVar2 + iVar1 + 1;
		  }
		  iVar2 = *(int *)(param1 + 0x1c);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar2,0);
		    iVar1 = iVar2 + iVar1 + 1;
		  }
		  if (*(double *)(param1 + 0x20) != 0.0) {
		    iVar1 = iVar1 + 9;
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    iVar2 = Google_Protobuf_UnknownFieldSet__WriteTo(*(int *)(param1 + 8),0);
		    iVar1 = iVar2 + iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: CalculateSize ---
		void Protocol_Common_ShortSpellInfo__CalculateSize(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (param2 != 0) {
		    if (*(int *)(param2 + 0xc) != 0) {
		      *(int *)(param1 + 0xc) = *(int *)(param2 + 0xc);
		    }
		    if (*(int *)(param2 + 0x10) != 0) {
		      *(int *)(param1 + 0x10) = *(int *)(param2 + 0x10);
		    }
		    if (*(int *)(param2 + 0x14) != 0) {
		      *(int *)(param1 + 0x14) = *(int *)(param2 + 0x14);
		    }
		    if (*(int *)(param2 + 0x18) != 0) {
		      *(int *)(param1 + 0x18) = *(int *)(param2 + 0x18);
		    }
		    if (*(int *)(param2 + 0x1c) != 0) {
		      *(int *)(param1 + 0x1c) = *(int *)(param2 + 0x1c);
		    }
		    if (*(double *)(param2 + 0x20) != 0.0) {
		      *(double *)(param1 + 0x20) = *(double *)(param2 + 0x20);
		    }
		    uVar1 = Google_Protobuf_UnknownFieldSet__MergeFrom
		                      (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Common_ShortSpellInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b280 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_MessageParser_ShortSpellInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_MessageParser_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Protocol_Common_ShortSpellInfo___c___cctor_b__50_0__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a5b280 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_ShortSpellInfo___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_ShortSpellInfo___c_TypeInfo);
		  }
		  uVar1 = **(undefined4 **)(Protocol_Common_ShortSpellInfo___c_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Func_ShortSpellInfo__TypeInfo);
		  func_ii_19797(param1_00,uVar1,Method_Protocol_Common_ShortSpellInfo___c___cctor_b__50_0__,0);
		  uVar1 = unnamed_function_1417(Google_Protobuf_MessageParser_ShortSpellInfo__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar1,param1_00,Method_Google_Protobuf_MessageParser_ShortSpellInfo___ctor__);
		  **(undefined4 **)(Protocol_Common_ShortSpellInfo_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Common_ShortSpellInfo__MergeFrom(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b280 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_MessageParser_ShortSpellInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_MessageParser_ShortSpellInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Protocol_Common_ShortSpellInfo___c___cctor_b__50_0__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ShortSpellInfo___c_TypeInfo);
		    DAT_ram_00a5b280 = '\x01';
		  }
		  if (*(int *)(Protocol_Common_ShortSpellInfo___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Common_ShortSpellInfo___c_TypeInfo);
		  }
		  uVar1 = **(undefined4 **)(Protocol_Common_ShortSpellInfo___c_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Func_ShortSpellInfo__TypeInfo);
		  func_ii_19797(param1_00,uVar1,Method_Protocol_Common_ShortSpellInfo___c___cctor_b__50_0__,0);
		  uVar1 = unnamed_function_1417(Google_Protobuf_MessageParser_ShortSpellInfo__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar1,param1_00,Method_Google_Protobuf_MessageParser_ShortSpellInfo___ctor__);
		  **(undefined4 **)(Protocol_Common_ShortSpellInfo_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

}
