using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Shop;

namespace Gameplay.Shop
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public class ShopModel : AbstractModel
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600206D RID: 8301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EA")]
		public UserIsle UserIsle
		{
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x71D1", Offset = "0x71D1", VA = "0x71D1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x71D2", Offset = "0x71D2", VA = "0x71D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600206F RID: 8303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EB")]
		public ShopLevelDic ShopLevelDic
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x71D3", Offset = "0x71D3", VA = "0x71D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x71D4", Offset = "0x71D4", VA = "0x71D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x00006810 File Offset: 0x00004A10
		// (set) Token: 0x06002071 RID: 8305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EC")]
		public int NeboMarketSlots
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x71D5", Offset = "0x71D5", VA = "0x71D5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x71D6", Offset = "0x71D6", VA = "0x71D6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x00006828 File Offset: 0x00004A28
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005ED")]
		public bool HasTradeAccount
		{
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x71D7", Offset = "0x71D7", VA = "0x71D7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x71D8", Offset = "0x71D8", VA = "0x71D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x00006840 File Offset: 0x00004A40
		// (set) Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EE")]
		public int MaxNormalSlots
		{
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x71D9", Offset = "0x71D9", VA = "0x71D9")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x71DA", Offset = "0x71DA", VA = "0x71DA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EF")]
		public int LastSelectedSlotId
		{
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x71DB", Offset = "0x71DB", VA = "0x71DB")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x71DC", Offset = "0x71DC", VA = "0x71DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F0")]
		public List<ShopArtifactDataDecorator> Artifacts
		{
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x71DD", Offset = "0x71DD", VA = "0x71DD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x71DE", Offset = "0x71DE", VA = "0x71DE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x170005F1")]
		public bool IsMyShop
		{
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x71DF", Offset = "0x71DF", VA = "0x71DF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x71E0", Offset = "0x71E0", VA = "0x71E0")]
		public ShopModel(IDictProvider dictProvider, UserData loggedUser, UserData user, UserIsle userIsle)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Model_ShopModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param3_00;
		  
		  if (DAT_ram_00a63aca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__AddRange__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Clear__);
		    DAT_ram_00a63aca = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  param3_00 = *(int *)(param1_00 + 0xc);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(param1_00 + 8),0,param3_00,0);
		    param1_00 = *(int *)(param1 + 0xc);
		  }
		  func_ii_6335(param1_00,param2,Method_System_Collections_Generic_List_BankOptionData__AddRange__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Shop_ShopModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5831b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5831b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80eceaa2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80eceaa2:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x24),3,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__get_Item__
		                    );
		  uVar4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(uVar4,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetArenaLevelDic(uVar3,uVar4,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x71E1", Offset = "0x71E1", VA = "0x71E1")]
		public void UpdateShopLevel()
		{
		/* --- GHIDRA: UpdateShopLevel ---
		void Gameplay_Shop_ShopModel__UpdateShopLevel(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5831c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__FindIndex__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopModel___c__DisplayClass34_0__RemoveArtifactById_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel___c__DisplayClass34_0_TypeInfo);
		    DAT_ram_00a5831c = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Shop_ShopModel___c__DisplayClass34_0_TypeInfo);
		  *(undefined8 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(param1 + 0x2c);
		  param1_00 = unnamed_function_1417(System_Predicate_ShopArtifactDataDecorator__TypeInfo);
		  func_ii_7297(param1_00,iVar1,
		               Method_Gameplay_Shop_ShopModel___c__DisplayClass34_0__RemoveArtifactById_b__0__,0);
		  iVar1 = System_Collections_Generic_List_UsageHint___FindAll
		                    (param1_01,param1_00,
		                     Method_System_Collections_Generic_List_ShopArtifactDataDecorator__FindIndex__);
		  if (iVar1 != -1) {
		    System_Collections_Generic_List_UsageHint___get_Item
		              (*(undefined4 *)(param1 + 0x2c),iVar1,0,
		               Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x71E2", Offset = "0x71E2", VA = "0x71E2")]
		public void RemoveArtifactById(ulong artifactId)
		{
		/* --- GHIDRA: RemoveArtifactById ---
		undefined4 Gameplay_Shop_ShopModel__RemoveArtifactById(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5831d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__FindIndex__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopModel___c__GetFirstNormalEmptySlot_b__35_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel___c_TypeInfo);
		    DAT_ram_00a5831d = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x2c);
		  param3 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x10);
		  if (*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Shop_ShopModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Shop_ShopModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Predicate_ShopArtifactDataDecorator__TypeInfo);
		    func_ii_7297(param1_00,param2_00,
		                 Method_Gameplay_Shop_ShopModel___c__GetFirstNormalEmptySlot_b__35_0__,0);
		    *(int *)(*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Collections_Generic_List_UsageHint___FindIndex
		                    (uVar1,0,param3,param1_00,
		                     Method_System_Collections_Generic_List_ShopArtifactDataDecorator__FindIndex__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x71E3", Offset = "0x71E3", VA = "0x71E3")]
		public int GetFirstNormalEmptySlot()
		{
		/* --- GHIDRA: GetFirstNormalEmptySlot ---
		undefined4 Gameplay_Shop_ShopModel__GetFirstNormalEmptySlot(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a5831e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__FindIndex__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopModel___c__GetFirstNeboMarketEmptySlot_b__36_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel___c_TypeInfo);
		    DAT_ram_00a5831e = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) == '\0') {
		    return 0xffffffff;
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x1c);
		  param2_00 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Shop_ShopModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[2];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Shop_ShopModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c);
		    }
		    param2_01 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Predicate_ShopArtifactDataDecorator__TypeInfo);
		    func_ii_7297(param1_01,param2_01,
		                 Method_Gameplay_Shop_ShopModel___c__GetFirstNeboMarketEmptySlot_b__36_0__,0);
		    *(int *)(*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c) + 8) = param1_01;
		  }
		  uVar1 = System_Collections_Generic_List_UsageHint___FindIndex
		                    (param1_00,param2_00,uVar1,param1_01,
		                     Method_System_Collections_Generic_List_ShopArtifactDataDecorator__FindIndex__);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x71E4", Offset = "0x71E4", VA = "0x71E4")]
		public int GetFirstNeboMarketEmptySlot()
		{
		/* --- GHIDRA: GetFirstNeboMarketEmptySlot ---
		void Gameplay_Shop_ShopModel__GetFirstNeboMarketEmptySlot(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  int iVar1;
		  uint uVar2;
		  
		  param3_00 = 0;
		  if (DAT_ram_00a5831f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		    DAT_ram_00a5831f = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0xc);
		  if (*(int *)(iVar1 + 0x10) != 0) {
		    param3_00 = Gameplay_Shop_ShopModel__UpdateItems(param1,param2,param1);
		    iVar1 = *(int *)(param2 + 0xc);
		  }
		  iVar1 = *(int *)(iVar1 + 0xc);
		  uVar2 = *(uint *)(*(int *)(param1 + 0x18) + 0x10);
		  if ((longlong)(ulonglong)uVar2 < (longlong)iVar1) {
		    iVar1 = *(int *)(param1 + 0x24) + iVar1 + (uVar2 ^ 0xffffffff);
		  }
		  else {
		    iVar1 = iVar1 + -1;
		  }
		  System_Collections_Generic_List_UsageHint___get_Item
		            (*(undefined4 *)(param1 + 0x2c),iVar1,param3_00,
		             Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x71E5", Offset = "0x71E5", VA = "0x71E5")]
		public void AddArtifact(UserArtifactWithPrice userArtifact)
		{
		/* --- GHIDRA: AddArtifact ---
		int Gameplay_Shop_ShopModel__AddArtifact(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = *(uint *)(*(int *)(param1 + 0x18) + 0x10);
		  if ((longlong)param2 <= (longlong)(ulonglong)uVar1) {
		    return param2 + -1;
		  }
		  return *(int *)(param1 + 0x24) + (uVar1 ^ 0xffffffff) + param2;
		}
		*/

		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x71E6", Offset = "0x71E6", VA = "0x71E6")]
		private int FromServerId(int index)
		{
		/* --- GHIDRA: FromServerId ---
		int Gameplay_Shop_ShopModel__FromServerId(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 <= *(int *)(param1 + 0x24) + -1) {
		    return param2 + 1;
		  }
		  return *(int *)(*(int *)(param1 + 0x18) + 0x10) + (param2 - *(int *)(param1 + 0x24)) + 1;
		}
		*/

			return 0;
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x71E7", Offset = "0x71E7", VA = "0x71E7")]
		public uint ToServerId(int index)
		{
		/* --- GHIDRA: ToServerId ---
		void Gameplay_Shop_ShopModel__ToServerId(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a58320 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserArtifactWithPrice__ShopArtifactDataDecorator___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_ShopArtifactDataDecorator___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserArtifactWithPrice___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserArtifactWithPrice__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserArtifactWithPrice__ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopModel_ConstructShopArtifactDataDecorator__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopModel___c__UpdateItems_b__40_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel___c_TypeInfo);
		    DAT_ram_00a58320 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x20) = *(undefined1 *)(param2 + 0x10);
		  iVar2 = *(int *)(param1 + 0x2c);
		  iVar3 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar3) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar3,0);
		  }
		  iVar2 = *(int *)(param1 + 0x24);
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (0 < iVar2 + iVar3) {
		    iVar6 = 0;
		    do {
		      iVar7 = Method_System_Collections_Generic_List_ShopArtifactDataDecorator__Add__;
		      param1_00 = *(int *)(param1 + 0x2c);
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar8 = *(uint *)(param1_00 + 0xc);
		      if (uVar8 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar8 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar8 * 4 + 0x10) = 0;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,0,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		        iVar2 = *(int *)(param1 + 0x24);
		        iVar3 = *(int *)(param1 + 0x1c);
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < iVar2 + iVar3);
		  }
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  if (*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Shop_ShopModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c);
		  iVar2 = puVar5[3];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Shop_ShopModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar5;
		    iVar2 = unnamed_function_1417(System_Func_UserArtifactWithPrice__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,uVar1,Method_Gameplay_Shop_ShopModel___c__UpdateItems_b__40_0__,0);
		    *(int *)(*(int *)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c) + 0xc) = iVar2;
		  }
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar4,iVar2,Method_System_Linq_Enumerable_Where_UserArtifactWithPrice___);
		  uVar1 = unnamed_function_1417
		                    (System_Func_UserArtifactWithPrice__ShopArtifactDataDecorator__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Shop_ShopModel_ConstructShopArtifactDataDecorator__,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserArtifactWithPrice__ShopArtifactDataDecorator___
		                    );
		  iVar2 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_ShopArtifactDataDecorator___);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar3 = 0;
		    do {
		      iVar6 = *(int *)(iVar2 + iVar3 * 4 + 0x10);
		      iVar7 = *(int *)(iVar6 + 0x7c);
		      uVar8 = *(uint *)(*(int *)(param1 + 0x18) + 0x10);
		      if ((longlong)(ulonglong)uVar8 < (longlong)iVar7) {
		        iVar7 = *(int *)(param1 + 0x24) + iVar7 + (uVar8 ^ 0xffffffff);
		      }
		      else {
		        iVar7 = iVar7 + -1;
		      }
		      System_Collections_Generic_List_UsageHint___get_Item
		                (*(undefined4 *)(param1 + 0x2c),iVar7,iVar6,
		                 Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

			return 0U;
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002083")]
		[Address(RVA = "0x71E8", Offset = "0x71E8", VA = "0x71E8")]
		public void UpdateItems(ProtoGetShopItemsInfoAns msg)
		{
		/* --- GHIDRA: UpdateItems ---
		int Gameplay_Shop_ShopModel__UpdateItems(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a58321 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopArtifactDataDecorator_TypeInfo);
		    DAT_ram_00a58321 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x80eced9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80eced9e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		  iVar4 = func_ii_8553(uVar3,*(undefined4 *)(*(int *)(param2 + 0xc) + 0x10),
		                       *(undefined4 *)(param1 + 8),0);
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(Gameplay_Shop_ShopArtifactDataDecorator_TypeInfo);
		  Core_Data_ArtifactData__GetArtSkillValue(param1_00,0);
		  *(int *)(param1_00 + 0x98) = iVar4;
		  Core_Data_ArtikulData__get_MiddleBgSubstrateAssetId(param1_00,*(undefined4 *)(iVar4 + 8),uVar3,0);
		  Core_Data_ArtifactData__get_ArtifactInfo
		            (param1_00,*(undefined4 *)(*(int *)(param1_00 + 0x98) + 0x74),uVar3,0);
		  *(undefined4 *)(param1_00 + 0x80) = 4;
		  *(undefined4 *)(param1_00 + 0x94) = *(undefined4 *)(param2 + 0x10);
		  Core_Cache_ArtifactCache__GetArtifact(param1_00,*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),0);
		  *(undefined4 *)(param1_00 + 0x70) = *(undefined4 *)(*(int *)(param1_00 + 0x98) + 0x70);
		  *(undefined4 *)(param1_00 + 0x6c) = *(undefined4 *)(*(int *)(param1_00 + 0x98) + 0x6c);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06002084 RID: 8324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x71E9", Offset = "0x71E9", VA = "0x71E9")]
		private ShopArtifactDataDecorator ConstructShopArtifactDataDecorator(UserArtifactWithPrice artifactWithPrice)
		{
		/* --- GHIDRA: ConstructShopArtifactDataDecorator ---
		void Gameplay_Shop_ShopModel__ConstructShopArtifactDataDecorator(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58322 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopModel___c_TypeInfo);
		    DAT_ram_00a58322 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Shop_ShopModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Shop_ShopModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0xC")]
		public readonly UserData LoggedUser;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x10")]
		private IDictProvider _dictProvider;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Artifacts ---
		uint Gameplay_Shop_ShopModel__set_Artifacts(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  
		  lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 0xc),0);
		  return (uint)(lVar1 == lVar2);
		}
		*/


		/* --- GHIDRA: get_IsMyShop ---
		void Gameplay_Shop_ShopModel__get_IsMyShop
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5831a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_ShopLevelDic___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ShopArtifactDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25279);
		    DAT_ram_00a5831a = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = 0xffffffff;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_ShopArtifactDataDecorator__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_ShopArtifactDataDecorator___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(int **)(param1 + 0x10) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80ed09ee;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ed09ee:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_25279,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80ed0a83;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ed0a83:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar4 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(iVar4 + 0x138),
		                     Method_System_Linq_Enumerable_Last_ShopLevelDic___);
		  *(undefined4 *)(param1 + 0x24) = *(undefined4 *)(iVar4 + 0x10);
		  Gameplay_Shop_ShopModel___ctor(param1,puVar3);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/


		/* --- GHIDRA: set_Options ---
		void Gameplay_Competition_Model_ShopModel__set_Options
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ac9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyCollection_BankOptionData__TypeInfo);
		    DAT_ram_00a63ac9 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_BankOptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_BankOptionData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  param2_00 = *(undefined4 *)(param1 + 0xc);
		  uVar1 = unnamed_function_1417
		                    (System_Collections_ObjectModel_ReadOnlyCollection_BankOptionData__TypeInfo);
		  System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		            (uVar1,param2_00,
		             Method_System_Collections_ObjectModel_ReadOnlyCollection_BankOptionData___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

}
