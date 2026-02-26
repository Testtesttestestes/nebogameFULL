using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Protocol.World;
using Utils;

namespace Core.Data
{
	// Token: 0x020010C1 RID: 4289
	[Token(Token = "0x20010C1")]
	public class MonsterData
	{
		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06006425 RID: 25637 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x17001425")]
		public bool HasMonster
		{
			[Token(Token = "0x6006425")]
			[Address(RVA = "0xB019", Offset = "0xB019", VA = "0xB019")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06006426 RID: 25638 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006427 RID: 25639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001426")]
		public MonsterDic MonsterDic
		{
			[Token(Token = "0x6006426")]
			[Address(RVA = "0xB01A", Offset = "0xB01A", VA = "0xB01A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006427")]
			[Address(RVA = "0xB01B", Offset = "0xB01B", VA = "0xB01B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06006428 RID: 25640 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006429 RID: 25641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001427")]
		public AprDicWrapper Apr
		{
			[Token(Token = "0x6006428")]
			[Address(RVA = "0xB01C", Offset = "0xB01C", VA = "0xB01C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006429")]
			[Address(RVA = "0xB01D", Offset = "0xB01D", VA = "0xB01D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600642A RID: 25642 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600642B RID: 25643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001428")]
		public BackTime Backtime
		{
			[Token(Token = "0x600642A")]
			[Address(RVA = "0xB01E", Offset = "0xB01E", VA = "0xB01E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600642B")]
			[Address(RVA = "0xB01F", Offset = "0xB01F", VA = "0xB01F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x0600642C RID: 25644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001429")]
		public ResourceSet AttackPrice
		{
			[Token(Token = "0x600642C")]
			[Address(RVA = "0xB020", Offset = "0xB020", VA = "0xB020")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142A")]
		public ResourceSet KickPrice
		{
			[Token(Token = "0x600642D")]
			[Address(RVA = "0xB021", Offset = "0xB021", VA = "0xB021")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x0600642E RID: 25646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142B")]
		public string Title
		{
			[Token(Token = "0x600642E")]
			[Address(RVA = "0xB022", Offset = "0xB022", VA = "0xB022")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142C")]
		public string Description
		{
			[Token(Token = "0x600642F")]
			[Address(RVA = "0xB023", Offset = "0xB023", VA = "0xB023")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x06006430 RID: 25648 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x1700142D")]
		public uint Level
		{
			[Token(Token = "0x6006430")]
			[Address(RVA = "0xB024", Offset = "0xB024", VA = "0xB024")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006431 RID: 25649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006431")]
		[Address(RVA = "0xB025", Offset = "0xB025", VA = "0xB025")]
		public RewardData[] GetRewards(UserData user, Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetRewards ---
		uint Core_Data_MonsterData__GetRewards
		               (int param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  uint *puVar1;
		  undefined4 param2_00;
		  undefined8 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int param2_01;
		  int *piVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a607dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ArtikulStackSize__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ArtikulStackSize__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a607dc = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ArtikulStackSize__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81ce69ba;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,
		                                System_Collections_Generic_ICollection_ArtikulStackSize__TypeInfo,0)
		  ;
		code_r0x81ce69ba:
		  param2_00 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  iVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_RewardInfo___TypeInfo,param2_00);
		  *param4 = iVar4;
		  iVar4 = 0;
		  do {
		    piVar3 = *(int **)(param1 + 0x14);
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_ICollection_ArtikulStackSize__TypeInfo == *piVar7) {
		          puVar1 = (uint *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81ce6a53;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,
		                                  System_Collections_Generic_ICollection_ArtikulStackSize__TypeInfo,
		                                  0);
		code_r0x81ce6a53:
		    iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		    if (iVar5 <= iVar4) {
		      return (uint)(*(int *)(*param4 + 0xc) != 0);
		    }
		    piVar3 = *(int **)(param1 + 0x14);
		    iVar5 = *piVar3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IList_ArtikulStackSize__TypeInfo == *piVar7) {
		          puVar1 = (uint *)(iVar5 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81ce6ad7;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,System_Collections_Generic_IList_ArtikulStackSize__TypeInfo
		                                  ,0);
		code_r0x81ce6ad7:
		    iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,iVar4,puVar1[1]);
		    iVar5 = *(int *)(iVar5 + 0xc);
		    piVar3 = *(int **)(param1 + 0x14);
		    iVar6 = *piVar3;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IList_ArtikulStackSize__TypeInfo == *piVar7) {
		          puVar1 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81ce6b5d;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,System_Collections_Generic_IList_ArtikulStackSize__TypeInfo
		                                  ,0);
		code_r0x81ce6b5d:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,iVar4,puVar1[1]);
		    if (iVar5 + 1U < 2) {
		code_r0x81ce6c05:
		      iVar6 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		      func_ii_7941(iVar6,0);
		      *(undefined4 *)(iVar6 + 0xc) = 3;
		      func_ii_7707(*(undefined4 *)(iVar6 + 0x10),iVar5,
		                   Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    }
		    else {
		      param2_01 = *(int *)(iVar6 + 0x10);
		      iVar6 = Gameplay_Inventory_Model_InventoryBaseModel__GetCount(param3,iVar5,0);
		      uVar2 = func_ii_7271(*(undefined4 *)(iVar6 + 0x2c),7,
		                           Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		      if ((int)uVar2 < 1) goto code_r0x81ce6c05;
		      iVar6 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		      func_ii_7941(iVar6,0);
		      *(undefined4 *)(iVar6 + 0xc) = 0xd;
		      func_ii_7707(*(undefined4 *)(iVar6 + 0x10),iVar5,
		                   Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		      if (param2_01 == 0) {
		        func_ii_7707(*(undefined4 *)(iVar6 + 0x10),1,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		      }
		      else {
		        func_ii_7707(*(undefined4 *)(iVar6 + 0x10),param2_01,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		      }
		    }
		    *(int *)(*param4 + iVar4 * 4 + 0x10) = iVar6;
		    iVar4 = iVar4 + 1;
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x6006432")]
		[Address(RVA = "0xB026", Offset = "0xB026", VA = "0xB026")]
		private bool TryGetArtikulRewards(UserData user, Dictionaries dictionaries, out RewardInfo[] rewards)
		{
		/* --- GHIDRA: TryGetArtikulRewards ---
		undefined4
		Core_Data_MonsterData__TryGetArtikulRewards
		          (int param1,int param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  int param1_00;
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a607dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a607dd = '\x01';
		  }
		  *param4 = 0;
		  if (*(char *)(param2 + 0x74) == '\0') {
		    if (*(int *)(*(int *)(param1 + 8) + 0x38) == 0) {
		      return 0;
		    }
		    param1_00 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		    func_ii_7941(param1_00,0);
		    *(undefined4 *)(param1_00 + 0xc) = 7;
		    puVar1 = (undefined4 *)(*(int *)(param1 + 8) + 0x38);
		  }
		  else {
		    if (*(int *)(*(int *)(param1 + 8) + 0x3c) == 0) {
		      return 0;
		    }
		    param1_00 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		    func_ii_7941(param1_00,0);
		    *(undefined4 *)(param1_00 + 0xc) = 0x19;
		    puVar1 = (undefined4 *)(*(int *)(param1 + 8) + 0x3c);
		  }
		  func_ii_7707(*(undefined4 *)(param1_00 + 0x10),*puVar1,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		  *param4 = param1_00;
		  return 1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x6006433")]
		[Address(RVA = "0xB027", Offset = "0xB027", VA = "0xB027")]
		private bool TryGetExpRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
		/* --- GHIDRA: TryGetExpRewards ---
		uint Core_Data_MonsterData__TryGetExpRewards
		               (int param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  
		  *param4 = 0;
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x28),0);
		  if (uVar1 == 0) {
		    uVar2 = Core_Extensions_Dict_ResourceSetExt__GetResourcesAsList
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 0x28),0);
		    *param4 = uVar2;
		  }
		  return uVar1 ^ 1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x6006434")]
		[Address(RVA = "0xB028", Offset = "0xB028", VA = "0xB028")]
		private bool TryGetResourceRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
		/* --- GHIDRA: TryGetResourceRewards ---
		uint Core_Data_MonsterData__TryGetResourceRewards
		               (int param1,int param2,undefined4 param3,int *param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  longlong lVar3;
		  longlong lVar4;
		  longlong lVar5;
		  int iVar6;
		  uint uVar7;
		  uint uVar8;
		  int iVar9;
		  undefined4 local_4;
		  
		  lVar3 = 0;
		  lVar5 = 0;
		  if (DAT_ram_00a607de == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ulong___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo_TypeInfo);
		    DAT_ram_00a607de = '\x01';
		  }
		  local_4 = 0;
		  *param4 = 0;
		  iVar6 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  iVar9 = *(int *)(*(int *)(param2 + 0x34) + 0x20);
		  uVar7 = iVar6 - iVar9;
		  if ((int)uVar7 < 0) {
		    iVar6 = Core_Extensions_Dict_DictExt__GetUserSlotsDic(param3,1,0);
		    uVar2 = System_Linq_Enumerable__ToList_uint_
		                      (*(undefined4 *)(iVar6 + 0x10),Method_System_Linq_Enumerable_ToList_ulong___);
		  }
		  else {
		    iVar1 = Core_Extensions_Dict_DictExt__GetUserSlotsDic(param3,2,0);
		    uVar2 = System_Linq_Enumerable__ToList_uint_
		                      (*(undefined4 *)(iVar1 + 0x10),Method_System_Linq_Enumerable_ToList_ulong___);
		    if (iVar6 != iVar9) {
		      iVar6 = Core_Extensions_Dict_DictExt__GetUserSlotsDic(param3,3,0);
		      param1_00 = System_Linq_Enumerable__ToList_uint_
		                            (*(undefined4 *)(iVar6 + 0x10),
		                             Method_System_Linq_Enumerable_ToList_ulong___);
		      lVar5 = System_Collections_Generic_List_ulong___get_Count
		                        (param1_00,0,Method_System_Collections_Generic_List_ulong__get_Item__);
		      lVar5 = lVar5 * (ulonglong)uVar7;
		      lVar3 = System_Collections_Generic_List_ulong___get_Count
		                        (param1_00,3,Method_System_Collections_Generic_List_ulong__get_Item__);
		      lVar3 = lVar3 * (ulonglong)uVar7;
		    }
		  }
		  lVar4 = System_Collections_Generic_List_ulong___get_Count
		                    (uVar2,0,Method_System_Collections_Generic_List_ulong__get_Item__);
		  lVar4 = lVar4 + lVar5;
		  lVar5 = System_Collections_Generic_List_ulong___get_Count
		                    (uVar2,3,Method_System_Collections_Generic_List_ulong__get_Item__);
		  lVar5 = lVar5 + lVar3;
		  uVar2 = func_ii_7504(param2,param2);
		  iVar6 = Core_Data_UserData__get_Accounts(uVar2,1,&local_4,param2);
		  if (iVar6 != 0) {
		    iVar6 = Core_Extensions_Dict_DictExt__GetUIResourceAssetId(param3,0);
		    lVar5 = lVar5 * (ulonglong)*(uint *)(iVar6 + 0x10);
		    lVar4 = lVar4 * (ulonglong)*(uint *)(iVar6 + 0x10);
		  }
		  if (lVar5 != 0 || lVar4 != 0) {
		    iVar6 = unnamed_function_1417(Protocol_Common_RewardInfo_TypeInfo);
		    func_ii_7941(iVar6,0);
		    *param4 = iVar6;
		    *(undefined4 *)(iVar6 + 0xc) = 0x14;
		    iVar1 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar1,Method_System_Collections_Generic_List_uint___ctor__);
		    iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    iVar9 = *(int *)(iVar1 + 8);
		    uVar7 = *(uint *)(iVar9 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar9 = *(int *)(iVar1 + 8);
		      uVar7 = *(uint *)(iVar9 + 0xc);
		      iVar6 = Method_System_Collections_Generic_List_uint__Add__;
		    }
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < uVar7) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(iVar9 + uVar8 * 4 + 0x10) = 0;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar1,0,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    }
		    System_Collections_Generic_List_UsageHint___get_Item
		              (iVar1,0,(int)lVar4,Method_System_Collections_Generic_List_uint__set_Item__);
		    System_Collections_Generic_List_UsageHint___get_Item
		              (iVar1,3,(int)lVar5,Method_System_Collections_Generic_List_uint__set_Item__);
		    Google_Protobuf_Collections_RepeatedField_uint___AddEntriesFrom
		              (*(undefined4 *)(*param4 + 0x10),iVar1,
		               Method_Google_Protobuf_Collections_RepeatedField_uint__AddRange__);
		  }
		  return (uint)(lVar5 != 0 || lVar4 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x6006435")]
		[Address(RVA = "0xB029", Offset = "0xB029", VA = "0xB029")]
		private bool TryGetRatingRewards(UserData user, Dictionaries dictionaries, out RewardInfo rewards)
		{
		/* --- GHIDRA: TryGetRatingRewards ---
		int Core_Data_MonsterData__TryGetRatingRewards(int param1,int param2,undefined4 param3)
		
		{
		  return *(int *)(*(int *)(param1 + 8) + 0x14) - *(int *)(*(int *)(param2 + 0x34) + 0x20);
		}
		*/

			return default(bool);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x6006436")]
		[Address(RVA = "0xB02A", Offset = "0xB02A", VA = "0xB02A")]
		public int GetDifficulty(UserData user)
		{
		/* --- GHIDRA: GetDifficulty ---
		undefined4 Core_Data_MonsterData__GetDifficulty(int param1,int param2,undefined4 param3)
		
		{
		  int param3_00;
		  int iVar1;
		  int param2_00;
		  int iVar2;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a607df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_int__string___get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_int__string___get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6549);
		    DAT_ram_00a607df = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 8) + 0x14);
		  iVar2 = *(int *)(*(int *)(param2 + 0x34) + 0x20);
		  param3_00 = 0;
		  while( true ) {
		    if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_MonsterData_TypeInfo);
		    }
		    param2_00 = **(int **)(Core_Data_MonsterData_TypeInfo + 0x5c);
		    if (*(int *)(param2_00 + 0xc) <= param3_00) {
		      return StringLiteral_6549;
		    }
		    if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_MonsterData_TypeInfo);
		      param2_00 = **(int **)(Core_Data_MonsterData_TypeInfo + 0x5c);
		    }
		    UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		              (&local_8,param2_00,param3_00,
		               Method_System_Collections_Generic_List_ValueTuple_int__string___get_Item__);
		    if (iVar1 - iVar2 < local_8) break;
		    param3_00 = param3_00 + 1;
		  }
		  if (*(int *)(Core_Data_MonsterData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_MonsterData_TypeInfo);
		  }
		  UnityEngine_UIElements_StyleMatchingContext__GetStyleSheetAt
		            (&local_8,**(undefined4 **)(Core_Data_MonsterData_TypeInfo + 0x5c),param3_00,
		             Method_System_Collections_Generic_List_ValueTuple_int__string___get_Item__);
		  return local_4;
		}
		*/

			return 0;
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006437")]
		[Address(RVA = "0xB02B", Offset = "0xB02B", VA = "0xB02B")]
		public string GetDifficultyLocaleKey(UserData user)
		{
		/* --- GHIDRA: GetDifficultyLocaleKey ---
		int Core_Data_MonsterData__GetDifficultyLocaleKey(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  float fVar5;
		  undefined4 uVar6;
		  int iVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a607e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_ArtikulStackSize___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a607e0 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Data_MonsterData_TypeInfo);
		  if (*(int *)(param1 + 0xc) == 0) {
		    uVar8 = *(uint *)(param1 + 0x14);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar5 = func_ii_7331((ulonglong)uVar8,0);
		    uVar6 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar6,CEIL(fVar5),0);
		    *(undefined4 *)(iVar2 + 0x10) = uVar6;
		    return iVar2;
		  }
		  uVar8 = 0;
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x81ce77a6;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce77a6:
		  uVar8 = 0;
		  uVar1 = CONCAT44(in_register_20000004,param2);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(uVar1,puVar3[1]);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                    (uVar4,*(undefined4 *)(param1 + 0xc),0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + iVar7 + 0xd8);
		        goto code_r0x81ce7838;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81ce7838:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(uVar6,param2),puVar3[1]);
		  uVar6 = func_ii_7730(*(undefined4 *)(iVar7 + 0x14),*(undefined4 *)(*(int *)(iVar2 + 8) + 0x10),
		                       Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                      );
		  *(undefined4 *)(iVar2 + 0xc) = uVar6;
		  uVar6 = System_Linq_Enumerable__Select_object__object_
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_System_Linq_Enumerable_ToList_ArtikulStackSize___);
		  *(undefined4 *)(iVar2 + 0x14) = uVar6;
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006438")]
		[Address(RVA = "0xB02C", Offset = "0xB02C", VA = "0xB02C")]
		public static MonsterData Create(MonsterInfo monsterInfo, IDictProvider dictionaries)
		{
		/* --- GHIDRA: Create ---
		int Core_Data_MonsterData__Create(undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a607e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a607e1 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Data_MonsterData_TypeInfo);
		  iVar5 = *param3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x81ce796e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce796e:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  uVar4 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic(uVar4,param1,0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar5 = *param3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81ce79fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81ce79fb:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  uVar4 = func_ii_7730(*(undefined4 *)(iVar5 + 0x14),*(undefined4 *)(*(int *)(iVar2 + 8) + 0x10),
		                       Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                      );
		  *(undefined4 *)(iVar2 + 0x14) = param2;
		  *(undefined4 *)(iVar2 + 0xc) = uVar4;
		  return iVar2;
		}
		*/

		/* --- GHIDRA: Create ---
		int Core_Data_MonsterData__Create(undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a607e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    DAT_ram_00a607e1 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Core_Data_MonsterData_TypeInfo);
		  iVar5 = *param3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x81ce796e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81ce796e:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  uVar4 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic(uVar4,param1,0);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  iVar5 = *param3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81ce79fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x81ce79fb:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  uVar4 = func_ii_7730(*(undefined4 *)(iVar5 + 0x14),*(undefined4 *)(*(int *)(iVar2 + 8) + 0x10),
		                       Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                      );
		  *(undefined4 *)(iVar2 + 0x14) = param2;
		  *(undefined4 *)(iVar2 + 0xc) = uVar4;
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006439")]
		[Address(RVA = "0xB02D", Offset = "0xB02D", VA = "0xB02D")]
		public static MonsterData Create(uint monsterId, IList<ArtikulStackSize> artikuls, IDictProvider dictionaries)
		{
			return null;
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643A")]
		[Address(RVA = "0xB02E", Offset = "0xB02E", VA = "0xB02E")]
		public MonsterData()
		{
		/* --- GHIDRA: .cctor ---
		undefined4 Core_Data_MonsterData___cctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a607e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    DAT_ram_00a607e5 = '\x01';
		  }
		  if (DAT_ram_00a607e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__get_Item__);
		    DAT_ram_00a607e3 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if (iVar4 == 0) {
		    param1_00 = (int *)0x0;
		  }
		  else if (*(int *)(iVar4 + 0xc) < 1) {
		    param1_00 = (int *)0x0;
		  }
		  else {
		    param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                 (iVar4,0,
		                                  Method_System_Collections_Generic_List_IRewardInfo__get_Item__);
		  }
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x81ce7f63;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_Decorators_IRewardInfo_TypeInfo,1);
		code_r0x81ce7f63:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Data_MonsterData___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a607e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_int__string___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValueTuple_int__string____ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ValueTuple_int__string___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Data_MonsterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_int__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10788);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10787);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10785);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10786);
		    DAT_ram_00a607e2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_ValueTuple_int__string___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ValueTuple_int__string____ctor__);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,0xffffffff,StringLiteral_10788,Method_System_ValueTuple_int__string___ctor__)
		  ;
		  iVar1 = Method_System_Collections_Generic_List_ValueTuple_int__string___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined8 *)(*(int *)(param1_00 + 8) + uVar2 * 8 + 0x10) = local_10;
		  }
		  else {
		    local_30 = local_10;
		    local_8 = local_10;
		    Core_Data_CollectionData__get_CollectionId
		              (param1_00,&local_30,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,2,StringLiteral_10785,Method_System_ValueTuple_int__string___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_ValueTuple_int__string___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined8 *)(*(int *)(param1_00 + 8) + uVar2 * 8 + 0x10) = local_18;
		  }
		  else {
		    local_38 = local_18;
		    local_8 = local_18;
		    Core_Data_CollectionData__get_CollectionId
		              (param1_00,&local_38,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  local_20 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,3,StringLiteral_10787,Method_System_ValueTuple_int__string___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_ValueTuple_int__string___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined8 *)(*(int *)(param1_00 + 8) + uVar2 * 8 + 0x10) = local_20;
		  }
		  else {
		    local_40 = local_20;
		    local_8 = local_20;
		    Core_Data_CollectionData__get_CollectionId
		              (param1_00,&local_40,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  local_28 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_28,0x7fffffff,StringLiteral_10786,Method_System_ValueTuple_int__string___ctor__)
		  ;
		  iVar1 = Method_System_Collections_Generic_List_ValueTuple_int__string___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined8 *)(*(int *)(param1_00 + 8) + uVar2 * 8 + 0x10) = local_28;
		  }
		  else {
		    local_48 = local_28;
		    local_8 = local_28;
		    Core_Data_CollectionData__get_CollectionId
		              (param1_00,&local_48,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  **(int **)(Core_Data_MonsterData_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<ValueTuple<int, string>> DIFFICULTY_KEYS;

		// Token: 0x04003589 RID: 13705
		[Token(Token = "0x4003589")]
		[FieldOffset(Offset = "0x14")]
		private IList<ArtikulStackSize> _artikulRewards;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_KickPrice ---
		undefined4 Core_Data_MonsterData__get_KickPrice(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = AssetContent_GameAssetViewRawImage__set_AssetId(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Title ---
		undefined4 Core_Data_MonsterData__get_Title(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Boss_View_CaptainTab_BossInfoView__set_AttackOptions
		                    (*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Level ---
		undefined4
		Core_Data_MonsterData__get_Level(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  undefined4 local_c;
		  undefined4 local_8;
		  int local_4;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a607db == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a607db = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_c = 0;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_RewardData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RewardData___ctor__);
		  iVar2 = Core_Data_MonsterData__GetRewards(param1,param1_00,param3,&local_4,param1_00);
		  iVar1 = local_4;
		  if ((iVar2 != 0) && (0 < *(int *)(local_4 + 0xc))) {
		    do {
		      uVar4 = *(undefined4 *)(iVar1 + iVar3 * 4 + 0x10);
		      if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar4,0);
		      iVar2 = Method_System_Collections_Generic_List_RewardData__Add__;
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar5 = *(uint *)(param1_00 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  iVar3 = Core_Data_MonsterData__TryGetArtikulRewards(param1,param2,param1_00,&local_8,param1_00);
		  uVar4 = local_8;
		  if (iVar3 != 0) {
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar4,0);
		    iVar3 = Method_System_Collections_Generic_List_RewardData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar3 = Core_Data_MonsterData__TryGetResourceRewards(param1,param2,param3,&local_c,param1_00);
		  uVar4 = local_c;
		  if (iVar3 != 0) {
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar4,0);
		    iVar3 = Method_System_Collections_Generic_List_RewardData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar3 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x28),0);
		  if (iVar3 == 0) {
		    uVar4 = Core_Extensions_Dict_ResourceSetExt__GetResourcesAsList
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 0x28),0);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_RewardInfoExt__ExtractResourceSet(uVar4,0);
		    iVar3 = Method_System_Collections_Generic_List_RewardData__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar4;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  uVar4 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param1_00,Method_System_Collections_Generic_List_RewardData__ToArray__);
		  return uVar4;
		}
		*/

}
