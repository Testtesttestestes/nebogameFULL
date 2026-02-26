using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Main;

namespace Gameplay.Inventory.Model
{
	// Token: 0x020006AA RID: 1706
	[Token(Token = "0x20006AA")]
	public class InventoryUtils
	{
		// Token: 0x06002946 RID: 10566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x7A4E", Offset = "0x7A4E", VA = "0x7A4E")]
		public static IList<ProtoGetUserArtifactsAns.Types.UserArtifact> FillEmptySlots(IList<ProtoGetUserArtifactsAns.Types.UserArtifact> rawSlots, long slotsLimit)
		{
		/* --- GHIDRA: FillEmptySlots ---
		undefined4
		Gameplay_Inventory_Model_InventoryUtils__FillEmptySlots
		          (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  uint uVar5;
		  longlong local_18;
		  uint local_10;
		  int local_c;
		  undefined8 local_8;
		  
		  uVar5 = 0;
		  local_8 = param2;
		  if (DAT_ram_00a5a161 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_455);
		    Mono_Security_ASN1__get_Item(&StringLiteral_456);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23175);
		    Mono_Security_ASN1__get_Item(&StringLiteral_424);
		    DAT_ram_00a5a161 = '\x01';
		  }
		  local_c = *(int *)(param1 + 0xc);
		  if (0 < local_c) {
		    iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (param1,local_c + -1,
		                       Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__);
		    uVar5 = *(uint *)(iVar2 + 0xc);
		  }
		  iVar2 = 0;
		  local_10 = uVar5;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  lVar4 = System_Math__Max((ulonglong)uVar5,param2,0);
		  local_18 = lVar4;
		  param1_00 = unnamed_function_1417
		                        (Google_Protobuf_Collections_RepeatedField_UserArtifact__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_UserArtifact___ctor__);
		  if (0 < lVar4) {
		    do {
		      iVar2 = iVar2 + 1;
		      if ((*(int *)(param1 + 0xc) < 1) ||
		         (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (param1,0,
		                             Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__
		                            ), *(int *)(iVar1 + 0xc) != iVar2)) {
		        iVar1 = unnamed_function_1417(Protocol_Main_UserArtifact_TypeInfo);
		        *(int *)(iVar1 + 0xc) = iVar2;
		        func_ii_6441(param1_00,iVar1,
		                     Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		      }
		      else {
		        uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (param1,0,
		                           Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__
		                          );
		        func_ii_6441(param1_00,uVar3,
		                     Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		        Google_Protobuf_Collections_RepeatedField_object___Insert
		                  (param1,0,
		                   Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__RemoveAt__);
		      }
		    } while (iVar2 < lVar4);
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,8);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_23175;
		  uVar3 = func_ii_4443(&local_c,0);
		  *(undefined4 *)(iVar2 + 0x14) = uVar3;
		  *(undefined4 *)(iVar2 + 0x18) = StringLiteral_456;
		  uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_10,0);
		  *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		  *(undefined4 *)(iVar2 + 0x20) = StringLiteral_455;
		  uVar3 = UnityEngine_GameObject__SetActive(&local_18,0);
		  *(undefined4 *)(iVar2 + 0x24) = uVar3;
		  *(undefined4 *)(iVar2 + 0x28) = StringLiteral_424;
		  uVar3 = UnityEngine_GameObject__SetActive(&local_8,0);
		  *(undefined4 *)(iVar2 + 0x2c) = uVar3;
		  uVar3 = System_Single__ToString(iVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: FillEmptySlots ---
		undefined4
		Gameplay_Inventory_Model_InventoryUtils__FillEmptySlots
		          (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  uint uVar5;
		  longlong local_18;
		  uint local_10;
		  int local_c;
		  undefined8 local_8;
		  
		  uVar5 = 0;
		  local_8 = param2;
		  if (DAT_ram_00a5a161 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__RemoveAt__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_UserArtifact__TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_UserArtifact_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_455);
		    Mono_Security_ASN1__get_Item(&StringLiteral_456);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23175);
		    Mono_Security_ASN1__get_Item(&StringLiteral_424);
		    DAT_ram_00a5a161 = '\x01';
		  }
		  local_c = *(int *)(param1 + 0xc);
		  if (0 < local_c) {
		    iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (param1,local_c + -1,
		                       Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__);
		    uVar5 = *(uint *)(iVar2 + 0xc);
		  }
		  iVar2 = 0;
		  local_10 = uVar5;
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  lVar4 = System_Math__Max((ulonglong)uVar5,param2,0);
		  local_18 = lVar4;
		  param1_00 = unnamed_function_1417
		                        (Google_Protobuf_Collections_RepeatedField_UserArtifact__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_UserArtifact___ctor__);
		  if (0 < lVar4) {
		    do {
		      iVar2 = iVar2 + 1;
		      if ((*(int *)(param1 + 0xc) < 1) ||
		         (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (param1,0,
		                             Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__
		                            ), *(int *)(iVar1 + 0xc) != iVar2)) {
		        iVar1 = unnamed_function_1417(Protocol_Main_UserArtifact_TypeInfo);
		        *(int *)(iVar1 + 0xc) = iVar2;
		        func_ii_6441(param1_00,iVar1,
		                     Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		      }
		      else {
		        uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (param1,0,
		                           Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__get_Item__
		                          );
		        func_ii_6441(param1_00,uVar3,
		                     Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__Add__);
		        Google_Protobuf_Collections_RepeatedField_object___Insert
		                  (param1,0,
		                   Method_Google_Protobuf_Collections_RepeatedField_UserArtifact__RemoveAt__);
		      }
		    } while (iVar2 < lVar4);
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,8);
		  *(undefined4 *)(iVar2 + 0x10) = StringLiteral_23175;
		  uVar3 = func_ii_4443(&local_c,0);
		  *(undefined4 *)(iVar2 + 0x14) = uVar3;
		  *(undefined4 *)(iVar2 + 0x18) = StringLiteral_456;
		  uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_10,0);
		  *(undefined4 *)(iVar2 + 0x1c) = uVar3;
		  *(undefined4 *)(iVar2 + 0x20) = StringLiteral_455;
		  uVar3 = UnityEngine_GameObject__SetActive(&local_18,0);
		  *(undefined4 *)(iVar2 + 0x24) = uVar3;
		  *(undefined4 *)(iVar2 + 0x28) = StringLiteral_424;
		  uVar3 = UnityEngine_GameObject__SetActive(&local_8,0);
		  *(undefined4 *)(iVar2 + 0x2c) = uVar3;
		  uVar3 = System_Single__ToString(iVar2,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x7A4F", Offset = "0x7A4F", VA = "0x7A4F")]
		public static RepeatedField<UserArtifact> FillEmptySlots(RepeatedField<UserArtifact> rawSlots, long slotsLimit = 9223372036854775807L)
		{
			return null;
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x7A50", Offset = "0x7A50", VA = "0x7A50")]
		public static bool IsChestSlot(int slotId)
		{
		/* --- GHIDRA: IsChestSlot ---
		uint Gameplay_Inventory_Model_InventoryUtils__IsChestSlot(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5a163 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a163 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  piVar2 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		  if (param1 < *piVar2) {
		    uVar1 = 0;
		  }
		  else {
		    if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		      piVar2 = *(int **)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c);
		    }
		    uVar1 = (uint)(param1 < piVar2[1]);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x7A51", Offset = "0x7A51", VA = "0x7A51")]
		public static bool IsBagSlot(int slotId)
		{
		/* --- GHIDRA: IsBagSlot ---
		uint Gameplay_Inventory_Model_InventoryUtils__IsBagSlot(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a164 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_int___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a164 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  if (DAT_ram_00a5a1ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a1ff = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  iVar1 = System_Array__IndexOf_char_
		                    (*(undefined4 *)
		                      (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0xc),
		                     param1,Method_System_Array_IndexOf_int___);
		  return (uint)(iVar1 != -1);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x7A52", Offset = "0x7A52", VA = "0x7A52")]
		public static bool IsEquipmentSlot(int slotId)
		{
		/* --- GHIDRA: IsEquipmentSlot ---
		uint Gameplay_Inventory_Model_InventoryUtils__IsEquipmentSlot(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a165 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_int___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a165 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  if (DAT_ram_00a5a201 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		    DAT_ram_00a5a201 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_InventoryConstants_TypeInfo);
		  }
		  iVar1 = System_Array__IndexOf_char_
		                    (*(undefined4 *)
		                      (*(int *)(Gameplay_Inventory_Model_InventoryConstants_TypeInfo + 0x5c) + 0x10)
		                     ,param1,Method_System_Array_IndexOf_int___);
		  return (uint)(iVar1 != -1);
		}
		*/

			return default(bool);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x7A53", Offset = "0x7A53", VA = "0x7A53")]
		public static bool IsGolemEquipmentSlot(int slotId)
		{
			return default(bool);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x7A54", Offset = "0x7A54", VA = "0x7A54")]
		public InventoryUtils()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_Model_InventoryUtils___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_14;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a166 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		    DAT_ram_00a5a166 = '\x01';
		  }
		  if (*(int *)(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_Model_ArtifactInfoProvider_TypeInfo);
		  }
		  local_c = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  local_14 = 0x3f8000003f800000;
		  local_28 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_4,&local_28,0);
		  *(undefined4 *)(param1 + 0x24) = local_4;
		  Core_Data_InfoRows_AbstractUserInformationProvider__Dispose(param1,param2,param3,0);
		  *(undefined4 *)(param1 + 0x20) = param4;
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  return;
		}
		*/

		}
	}
}
