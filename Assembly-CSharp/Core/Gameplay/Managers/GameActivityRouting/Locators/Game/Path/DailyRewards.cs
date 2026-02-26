using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011D7 RID: 4567
	[Token(Token = "0x20011D7")]
	public class DailyRewards : AbstractPathNode
	{
		// Token: 0x06006CB1 RID: 27825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB1")]
		[Address(RVA = "0xB79D", Offset = "0xB79D", VA = "0xB79D", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB2")]
		[Address(RVA = "0xB79E", Offset = "0xB79E", VA = "0xB79E", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CB3")]
		[Address(RVA = "0xB79F", Offset = "0xB79F", VA = "0xB79F")]
		public DailyRewards()
		{
		/* --- GHIDRA: .cctor ---
		void Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a553e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo);
		    DAT_ram_00a553e7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo);
		  **(undefined4 **)
		    (Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___ctor
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a553e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		    DAT_ram_00a553e0 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		  if (*(int *)(param1 + 0xc) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Protocol_Common_RewardInfo___ctor(*(int *)(param1 + 0xc),0);
		  }
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Protocol_Common_RewardInfo___ctor(*(int *)(param1 + 0x10),0);
		  }
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  *(undefined1 *)(iVar1 + 0x14) = *(undefined1 *)(param1 + 0x14);
		  uVar2 = Google_Protobuf_UnknownFieldSet__MergeFrom(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___ctor
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a553e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		    DAT_ram_00a553e0 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		  if (*(int *)(param1 + 0xc) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Protocol_Common_RewardInfo___ctor(*(int *)(param1 + 0xc),0);
		  }
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Protocol_Common_RewardInfo___ctor(*(int *)(param1 + 0x10),0);
		  }
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  *(undefined1 *)(iVar1 + 0x14) = *(undefined1 *)(param1 + 0x14);
		  uVar2 = Google_Protobuf_UnknownFieldSet__MergeFrom(*(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_DailyRewards___ctor
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a718 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a718 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x298);
		        goto code_r0x812609a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x812609a7:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (*(int *)(iVar5 + 0x14) == 0) {
		    return 0;
		  }
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x298);
		        goto code_r0x81260a34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x3b);
		code_r0x81260a34:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar6 + 0x104));
		  uVar3 = Gameplay_EndlessPaymentOptionsList_Model_EndlessPaymentOptionsListModel__get_LastList
		                    (uVar3,0);
		  return uVar3;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Parser ---
		undefined4
		Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__get_Parser(undefined4 param1)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a553de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MessageDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_ProtoRegisterVisitAns_TypeInfo);
		    DAT_ram_00a553de = '\x01';
		  }
		  if (*(int *)(Protocol_SmallGames_ProtoRegisterVisitAns_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_SmallGames_ProtoRegisterVisitAns_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = Protocol_SmallGames_ProtoRegisterVisitAns__get_Parser(0);
		  param1_00 = *(int **)(iVar2 + 0x34);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_MessageDescriptor__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80b73663;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MessageDescriptor__TypeInfo,0);
		code_r0x80b73663:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,0,puVar3[1]);
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_Descriptor ---
		undefined4
		Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__get_Descriptor
		          (undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a553df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		    DAT_ram_00a553df = '\x01';
		  }
		  param1_00 = Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo;
		  if (*(int *)(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		  }
		  uVar1 = Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__get_Parser(param1_00);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_Taken ---
		undefined4
		Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__set_Taken
		          (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a553e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		    DAT_ram_00a553e1 = '\x01';
		  }
		  if ((param2 != (int *)0x0) &&
		     (*param2 == Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo)) {
		    if (param1 == param2) {
		      return 1;
		    }
		    iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[3],param2[3],0);
		    if (((iVar2 != 0) &&
		        (iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[4],param2[4],0),
		        iVar2 != 0)) && (((char)param1[5] != '\0') == ((char)param2[5] != '\0'))) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[2],param2[2],0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		uint Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__Equals
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint uVar3;
		  undefined1 local_1;
		  
		  local_1 = 0;
		  piVar2 = *(int **)(param1 + 0xc);
		  if (piVar2 == (int *)0x0) {
		    uVar3 = 1;
		  }
		  else {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xd4));
		    uVar3 = uVar3 ^ 1;
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xd4));
		    uVar3 = uVar1 ^ uVar3;
		  }
		  if (*(char *)(param1 + 0x14) != '\0') {
		    local_1 = 1;
		    if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66944);
		    }
		    uVar1 = System_BitConverter___c___ToString_b__38_0(&local_1,0);
		    uVar3 = uVar1 ^ uVar3;
		  }
		  piVar2 = *(int **)(param1 + 8);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xd4));
		    uVar3 = uVar1 ^ uVar3;
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: Equals ---
		uint Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__Equals
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint uVar3;
		  undefined1 local_1;
		  
		  local_1 = 0;
		  piVar2 = *(int **)(param1 + 0xc);
		  if (piVar2 == (int *)0x0) {
		    uVar3 = 1;
		  }
		  else {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xd4));
		    uVar3 = uVar3 ^ 1;
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xd4));
		    uVar3 = uVar1 ^ uVar3;
		  }
		  if (*(char *)(param1 + 0x14) != '\0') {
		    local_1 = 1;
		    if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66944);
		    }
		    uVar1 = System_BitConverter___c___ToString_b__38_0(&local_1,0);
		    uVar3 = uVar1 ^ uVar3;
		  }
		  piVar2 = *(int **)(param1 + 8);
		  if (piVar2 != (int *)0x0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xd0) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0xd4));
		    uVar3 = uVar1 ^ uVar3;
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: GetHashCode ---
		undefined4
		Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__GetHashCode
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a553e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_JsonFormatter_TypeInfo);
		    DAT_ram_00a553e2 = '\x01';
		  }
		  if (*(int *)(Google_Protobuf_JsonFormatter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Protobuf_JsonFormatter_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_JsonFormatter__Format(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__ToString
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (*(int *)(param1 + 0xc) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,10,0);
		    Google_Protobuf_CodedOutputStream__WriteTag(param2,*(undefined4 *)(param1 + 0xc),0);
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x12,0);
		    Google_Protobuf_CodedOutputStream__WriteTag(param2,*(undefined4 *)(param1 + 0x10),0);
		  }
		  if (*(char *)(param1 + 0x14) != '\0') {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x18,0);
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,(uint)*(byte *)(param1 + 0x14),0);
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    Google_Protobuf_UnknownFieldSet__HasField(*(int *)(param1 + 8),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: WriteTo ---
		int Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__WriteTo
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a553e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_CodedOutputStream_TypeInfo);
		    DAT_ram_00a553e3 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0xc);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar1 = Google_Protobuf_CodedOutputStream__ComputeRawVarint32Size(iVar2,0);
		    iVar1 = iVar1 + 1;
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeRawVarint32Size(iVar2,0);
		    iVar1 = iVar2 + iVar1 + 1;
		  }
		  iVar2 = iVar1 + 2;
		  if (*(char *)(param1 + 0x14) == '\0') {
		    iVar2 = iVar1;
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    iVar1 = Google_Protobuf_UnknownFieldSet__WriteTo(*(int *)(param1 + 8),0);
		    iVar2 = iVar1 + iVar2;
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: CalculateSize ---
		void Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__CalculateSize
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a553e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a553e4 = '\x01';
		  }
		  if (param2 != 0) {
		    iVar2 = *(int *)(param2 + 0xc);
		    if (iVar2 != 0) {
		      iVar3 = *(int *)(param1 + 0xc);
		      if (iVar3 == 0) {
		        iVar3 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		        func_ii_7941(iVar3,0);
		        *(int *)(param1 + 0xc) = iVar3;
		        iVar2 = *(int *)(param2 + 0xc);
		      }
		      Protocol_Common_RewardInfo__CalculateSize(iVar3,iVar2,0);
		    }
		    iVar2 = *(int *)(param2 + 0x10);
		    if (iVar2 != 0) {
		      iVar3 = *(int *)(param1 + 0x10);
		      if (iVar3 == 0) {
		        iVar3 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		        func_ii_7941(iVar3,0);
		        *(int *)(param1 + 0x10) = iVar3;
		        iVar2 = *(int *)(param2 + 0x10);
		      }
		      Protocol_Common_RewardInfo__CalculateSize(iVar3,iVar2,0);
		    }
		    if (*(char *)(param2 + 0x14) != '\0') {
		      *(undefined1 *)(param1 + 0x14) = 1;
		    }
		    uVar1 = Google_Protobuf_UnknownFieldSet__MergeFrom
		                      (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__MergeFrom(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a553e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c___cctor_b__35_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo);
		    DAT_ram_00a553e6 = '\x01';
		  }
		  if (*(int *)(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo + 0x74) ==
		      0) {
		    func_ii_306000(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo);
		  }
		  uVar1 = **(undefined4 **)
		            (Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Func_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo);
		  func_ii_19797(param1_00,uVar1,
		                Method_Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c___cctor_b__35_0__
		                ,0);
		  uVar1 = unnamed_function_1417
		                    (
		                    Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo
		                    );
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar1,param1_00,
		             Method_Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards___ctor__)
		  ;
		  **(undefined4 **)(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards__MergeFrom(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a553e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c___cctor_b__35_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo);
		    DAT_ram_00a553e6 = '\x01';
		  }
		  if (*(int *)(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo + 0x74) ==
		      0) {
		    func_ii_306000(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo);
		  }
		  uVar1 = **(undefined4 **)
		            (Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Func_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo);
		  func_ii_19797(param1_00,uVar1,
		                Method_Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards___c___cctor_b__35_0__
		                ,0);
		  uVar1 = unnamed_function_1417
		                    (
		                    Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards__TypeInfo
		                    );
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar1,param1_00,
		             Method_Google_Protobuf_MessageParser_ProtoRegisterVisitAns_Types_DailyRewards___ctor__)
		  ;
		  **(undefined4 **)(Protocol_SmallGames_ProtoRegisterVisitAns_Types_DailyRewards_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

}
