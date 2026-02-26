using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Gameplay.Market.Model.Data;
using Gameplay.Market.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Shop;
using UI.Tabs;
using Utils;

namespace Gameplay.Market.Model
{
	// Token: 0x02000624 RID: 1572
	[Token(Token = "0x2000624")]
	public class MarketModel : AbstractModel
	{
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700072C")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6002621")]
			[Address(RVA = "0x775F", Offset = "0x775F", VA = "0x775F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072D")]
		public List<MarketLotListElement.MarketLotListElementArgs> UserLots
		{
			[Token(Token = "0x6002622")]
			[Address(RVA = "0x7760", Offset = "0x7760", VA = "0x7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002623")]
			[Address(RVA = "0x7761", Offset = "0x7761", VA = "0x7761")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072E")]
		public List<MarketLotListElement.MarketLotListElementArgs> MarketOptions
		{
			[Token(Token = "0x6002624")]
			[Address(RVA = "0x7762", Offset = "0x7762", VA = "0x7762")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002625")]
			[Address(RVA = "0x7763", Offset = "0x7763", VA = "0x7763")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072F")]
		public Dictionary<ulong, MarketLotListElement.MarketLotListElementArgs> UserLotsById
		{
			[Token(Token = "0x6002626")]
			[Address(RVA = "0x7764", Offset = "0x7764", VA = "0x7764")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002627")]
			[Address(RVA = "0x7765", Offset = "0x7765", VA = "0x7765")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000730")]
		public IList<MarketLotListElement.MarketLotListElementArgs> ExtraArtifactsResult
		{
			[Token(Token = "0x6002628")]
			[Address(RVA = "0x7766", Offset = "0x7766", VA = "0x7766")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002629")]
			[Address(RVA = "0x7767", Offset = "0x7767", VA = "0x7767")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262A")]
		[Address(RVA = "0x7768", Offset = "0x7768", VA = "0x7768")]
		public MarketModel(UserData user)
		{
		/* --- GHIDRA: <PopulateMarketArtifacts>g__HandleOptionsToAdd|28_3 ---
		undefined4
		Gameplay_Market_Model_MarketModel___PopulateMarketArtifacts_g__HandleOptionsToAdd_28_3
		          (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a010 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__get_Item__
		              );
		    DAT_ram_00a5a010 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(param1 + 0x20),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__get_Item__
		                    );
		  return uVar1;
		}
		*/

		/* --- GHIDRA: <PopulateMarketArtifacts>g__HandleOptionToExpire|28_2 ---
		void Gameplay_Market_Model_MarketModel___PopulateMarketArtifacts_g__HandleOptionToExpire_28_2
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param2_00;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a00f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_MarketModel_MarketOptionWithBacktime__float___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_MarketModel_MarketOptionWithBacktime___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Where_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_MarketModel_MarketOptionWithBacktime___);
		    Mono_Security_ASN1__get_Item(&System_Func_MarketModel_MarketOptionWithBacktime__float__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_MarketModel_MarketOptionWithBacktime__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__RemoveAll__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel_ConstructMarketOptionWithBacktime__);
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_MarketLotListElement_MarketLotListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_6__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_7__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_8__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Model_MarketModel___c__DisplayClass28_1__PopulateMarketArtifacts_b__9__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c__DisplayClass28_1_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    DAT_ram_00a5a00f = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*param2 + 0x10);
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[6];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417
		                      (
		                      System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar2,
		               Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_6__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x18) = iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,iVar5,
		                     Method_System_Linq_Enumerable_Where_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer___
		                    );
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,
		             Method_Gameplay_Market_Model_MarketModel_ConstructMarketOptionWithBacktime__,0);
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,uVar2,
		                     Method_System_Linq_Enumerable_Select_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime___
		                    );
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[7];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_MarketModel_MarketOptionWithBacktime__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar2,
		               Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_7__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x1c) = iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,iVar5,
		                     Method_System_Linq_Enumerable_Where_MarketModel_MarketOptionWithBacktime___);
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[8];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_MarketModel_MarketOptionWithBacktime__float__TypeInfo)
		    ;
		    System_Func_object__SerializableProjectConfiguration___Invoke
		              (iVar5,uVar2,
		               Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_8__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x20) = iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__OrderBy_object__object_
		                    (uVar3,iVar5,
		                     Method_System_Linq_Enumerable_OrderBy_MarketModel_MarketOptionWithBacktime__float___
		                    );
		  iVar5 = func_ii_6295(uVar3,
		                       Method_System_Linq_Enumerable_ToArray_MarketModel_MarketOptionWithBacktime___
		                      );
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    iVar1 = 0;
		    do {
		      param2_00 = unnamed_function_1417
		                            (Gameplay_Market_Model_MarketModel___c__DisplayClass28_1_TypeInfo);
		      *(undefined4 *)(param2_00 + 8) = *(undefined4 *)(iVar5 + iVar1 * 4 + 0x10);
		      uVar2 = *(undefined4 *)(param1 + 0x1c);
		      uVar3 = unnamed_function_1417
		                        (System_Predicate_MarketLotListElement_MarketLotListElementArgs__TypeInfo);
		      func_ii_7297(uVar3,param2_00,
		                   Method_Gameplay_Market_Model_MarketModel___c__DisplayClass28_1__PopulateMarketArtifacts_b__9__
		                   ,0);
		      System_Collections_Generic_List_object___IsCompatibleObject
		                (uVar2,uVar3,
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__RemoveAll__
		                );
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar5 + 0xc));
		  }
		  uVar3 = unnamed_function_1417
		                    (System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__TypeInfo
		                    );
		  System_Collections_Generic_Stack_object____ctor
		            (uVar3,iVar5,
		             Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar3;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Market_Model_MarketModel___ctor(int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59ffd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___ContainsKey__
		              );
		    DAT_ram_00a59ffd = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___ContainsKey__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600262B RID: 9771 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x600262B")]
		[Address(RVA = "0x7769", Offset = "0x7769", VA = "0x7769")]
		public bool ContainsInCache(ulong artId)
		{
		/* --- GHIDRA: ContainsInCache ---
		void Gameplay_Market_Model_MarketModel__ContainsInCache
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59ffe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___get_Item__
		              );
		    DAT_ram_00a59ffe = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___get_Item__
		                    );
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262C")]
		[Address(RVA = "0x776A", Offset = "0x776A", VA = "0x776A")]
		public void EnableArtifactsFromCache(ulong artId)
		{
		/* --- GHIDRA: EnableArtifactsFromCache ---
		void Gameplay_Market_Model_MarketModel__EnableArtifactsFromCache
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a59fff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_MarketLotListElement_MarketLotListElementArgs__string___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_MarketLotListElement_MarketLotListElementArgs__ulong___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel_ConstructUserMarketLotData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    DAT_ram_00a59fff = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  local_8 = param2;
		  local_4 = param1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Market_Model_MarketModel_ConstructUserMarketLotData__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs___
		                    );
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[2];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar3;
		    iVar4 = unnamed_function_1417
		                      (System_Func_MarketLotListElement_MarketLotListElementArgs__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar2,
		               Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_0__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 8) = iVar4;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_object__long_
		                    (uVar1,iVar4,
		                     Method_System_Linq_Enumerable_OrderBy_MarketLotListElement_MarketLotListElementArgs__string___
		                    );
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,
		                     Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[3];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar3;
		    iVar4 = unnamed_function_1417
		                      (System_Func_MarketLotListElement_MarketLotListElementArgs__ulong__TypeInfo);
		    func_ii_7542(iVar4,uVar2,
		                 Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_1__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0xc) = iVar4;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__uint_
		                    (uVar1,iVar4,
		                     Method_System_Linq_Enumerable_ToDictionary_MarketLotListElement_MarketLotListElementArgs__ulong___
		                    );
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  Gameplay_Market_Model_MarketModel__get_AllFilters(param1,&local_8,param1);
		  Gameplay_Market_Model_MarketModel___PopulateMarketArtifacts_g__HandleOptionToExpire_28_2
		            (param1,&local_8,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600262D RID: 9773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262D")]
		[Address(RVA = "0x776B", Offset = "0x776B", VA = "0x776B")]
		public void PopulateMarketArtifacts(ProtoGetMarketArtifactsAns artifacts)
		{
		/* --- GHIDRA: PopulateMarketArtifacts ---
		void Gameplay_Market_Model_MarketModel__PopulateMarketArtifacts(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a000 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__RemoveAll__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_MarketLotListElement_MarketLotListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Pop__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Model_MarketModel___c__DisplayClass29_0__RemoveExpiredElements_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c__DisplayClass29_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13494);
		    DAT_ram_00a5a000 = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                    (*(undefined4 *)(param1 + 0x28),
		                     Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                    );
		  fVar2 = func_ii_7103(*(undefined4 *)(iVar1 + 0x10),0);
		  if (fVar2 <= 0.0) {
		    uVar3 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_uint__TypeInfo);
		    Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		              (uVar3,Method_Google_Protobuf_Collections_RepeatedField_uint___ctor__);
		    iVar1 = *(int *)(*(int *)(param1 + 0x28) + 0xc);
		    while (0 < iVar1) {
		      iVar1 = unnamed_function_1417
		                        (Gameplay_Market_Model_MarketModel___c__DisplayClass29_0_TypeInfo);
		      iVar4 = System_Linq_Expressions_Interpreter_LightCompiler__CompileAsVoid
		                        (*(undefined4 *)(param1 + 0x28),
		                         Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Pop__
		                        );
		      *(int *)(iVar1 + 8) = iVar4;
		      fVar2 = func_ii_7103(*(undefined4 *)(iVar4 + 0x10),0);
		      if (0.0 < fVar2) break;
		      param1_01 = *(undefined4 *)(param1 + 0x1c);
		      param1_00 = unnamed_function_1417
		                            (
		                            System_Predicate_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                            );
		      func_ii_7297(param1_00,iVar1,
		                   Method_Gameplay_Market_Model_MarketModel___c__DisplayClass29_0__RemoveExpiredElements_b__0__
		                   ,0);
		      System_Collections_Generic_List_object___IsCompatibleObject
		                (param1_01,param1_00,
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__RemoveAll__
		                );
		      func_ii_7707(uVar3,*(undefined4 *)(*(int *)(iVar1 + 8) + 8),
		                   Method_Google_Protobuf_Collections_RepeatedField_uint__Add__);
		      iVar1 = *(int *)(*(int *)(param1 + 0x28) + 0xc);
		    }
		    uVar3 = func_ii_4419(StringLiteral_13494,uVar3,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600262E RID: 9774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x776C", Offset = "0x776C", VA = "0x776C")]
		public void RemoveExpiredElements()
		{
		/* --- GHIDRA: RemoveExpiredElements ---
		void Gameplay_Market_Model_MarketModel__RemoveExpiredElements(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int param1_00;
		  uint uVar7;
		  int *piVar8;
		  int local_4;
		  
		  if (DAT_ram_00a5a001 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Pop__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a001 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                    (*(undefined4 *)(param1 + 0x2c),
		                     Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                    );
		  fVar2 = func_ii_7103(*(undefined4 *)(iVar1 + 0xc),0);
		  if (fVar2 <= 0.0) {
		    iVar1 = *(int *)(param1 + 0x2c);
		    iVar5 = *(int *)(iVar1 + 0xc);
		    while (0 < iVar5) {
		      iVar1 = System_Linq_Expressions_Interpreter_LightCompiler__CompileAsVoid
		                        (iVar1,
		                         Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Pop__
		                        );
		      fVar2 = func_ii_7103(*(undefined4 *)(iVar1 + 0xc),0);
		      if (0.0 < fVar2) {
		        return;
		      }
		      if (DAT_ram_00a59ffb == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		        DAT_ram_00a59ffb = '\x01';
		      }
		      piVar6 = *(int **)(param1 + 0xc);
		      iVar5 = *piVar6;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar8) {
		            puVar3 = (uint *)(piVar8[1] * 8 + iVar5 + 0xd0);
		            goto code_r0x811b1bbc;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811b1bbc:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      iVar1 = func_ii_8054(uVar4,*(undefined4 *)(iVar1 + 8),&local_4,0);
		      if (iVar1 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar1 = *piVar6;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar7 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		              puVar3 = (uint *)(piVar8[1] * 8 + iVar1 + 0x160);
		              goto code_r0x811b1c77;
		            }
		            uVar7 = uVar7 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x811b1c77:
		        uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		        iVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                          (uVar4,*(undefined4 *)(*(int *)(local_4 + 0xc) + 0x28),
		                           *(undefined4 *)(param1 + 8),0);
		        if ((iVar1 != 0) &&
		           (iVar5 = Gameplay_Market_Model_MarketModel__AddArtifacts(param1,local_4,puVar3),
		           iVar1 = 
		           Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__
		           , iVar5 != 0)) {
		          param1_00 = *(int *)(param1 + 0x1c);
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar7 = *(uint *)(param1_00 + 0xc);
		          if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		            *(int *)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = iVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,iVar5,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      iVar1 = *(int *)(param1 + 0x2c);
		      iVar5 = *(int *)(iVar1 + 0xc);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600262F RID: 9775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600262F")]
		[Address(RVA = "0x776D", Offset = "0x776D", VA = "0x776D")]
		public void AddScheduledElements()
		{
		/* --- GHIDRA: AddScheduledElements ---
		uint Gameplay_Market_Model_MarketModel__AddScheduledElements
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a002 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a002 = '\x01';
		  }
		  *param2 = 0;
		  iVar2 = *(int *)(*(int *)(param1 + 0x28) + 0xc);
		  if (iVar2 != 0) {
		    uVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(param1 + 0x28),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    *param2 = uVar1;
		  }
		  return (uint)(iVar2 != 0);
		}
		*/

		}

		// Token: 0x06002630 RID: 9776 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x6002630")]
		[Address(RVA = "0x776E", Offset = "0x776E", VA = "0x776E")]
		public bool RemoveStackSorted(out MarketModel.MarketOptionWithBacktime result)
		{
		/* --- GHIDRA: RemoveStackSorted ---
		uint Gameplay_Market_Model_MarketModel__RemoveStackSorted
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a003 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__get_Count__
		              );
		    DAT_ram_00a5a003 = '\x01';
		  }
		  *param2 = 0;
		  iVar2 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (iVar2 != 0) {
		    uVar1 = Newtonsoft_Json_Utilities_ThreadSafeStore_object__object___Get
		                      (*(int *)(param1 + 0x2c),
		                       Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__Peek__
		                      );
		    *param2 = uVar1;
		  }
		  return (uint)(iVar2 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6002631")]
		[Address(RVA = "0x776F", Offset = "0x776F", VA = "0x776F")]
		public bool RemoveAddStackSorted(out MarketModel.MarketOptionWithBacktime result)
		{
		/* --- GHIDRA: RemoveAddStackSorted ---
		void Gameplay_Market_Model_MarketModel__RemoveAddStackSorted
		               (int param1,undefined8 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000024;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  undefined8 param3_00;
		  int iVar6;
		  uint uVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a004 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_ulong___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ulong__MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ulong__MarketLotListElement_MarketLotListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel__CacheOtherArtifacts_b__33_0__);
		    DAT_ram_00a5a004 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar6 = *param3;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811b21c8;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(param3,System_Collections_Generic_ICollection_ulong__TypeInfo,2);
		code_r0x811b21c8:
		  (**(code **)((ulonglong)*puVar1 * 4))(param3,param2,CONCAT44(in_register_20000024,puVar1[1]));
		  uVar2 = System_Linq_Enumerable__Distinct_object_
		                    (param3,Method_System_Linq_Enumerable_Distinct_ulong___);
		  uVar3 = unnamed_function_1417
		                    (System_Func_ulong__MarketLotListElement_MarketLotListElementArgs__TypeInfo);
		  System_Func_ulong__InternedString___Invoke
		            (uVar3,param1,Method_Gameplay_Market_Model_MarketModel__CacheOtherArtifacts_b__33_0__,0)
		  ;
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar3,
		                     Method_System_Linq_Enumerable_Select_ulong__MarketLotListElement_MarketLotListElementArgs___
		                    );
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,
		                     Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b233d;
		    }
		    if (iVar4 == 0) goto code_r0x811b2393;
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    param3_00 = unnamed_function_184054
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x12,
		                           *(undefined4 *)(*(int *)(local_8._4_4_ + 0xc) + 8),0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184063
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x262,uVar3,param3_00,uVar2,
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___set_Item__
		              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b233d:
		      iVar6 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar4 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x811b2393:
		          DAT_ram_009d3e38 = 0;
		          *(undefined4 *)(param1 + 0x24) = uVar2;
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x232,&local_18);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x811b233d;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x7770", Offset = "0x7770", VA = "0x7770")]
		public void CacheOtherArtifacts(ulong key, IList<ulong> list)
		{
		/* --- GHIDRA: CacheOtherArtifacts ---
		int Gameplay_Market_Model_MarketModel__CacheOtherArtifacts
		              (int param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a005 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Model_MarketModel___c__DisplayClass34_0__GetOptionsLots_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c__DisplayClass34_0_TypeInfo);
		    DAT_ram_00a5a005 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Market_Model_MarketModel___c__DisplayClass34_0_TypeInfo);
		  uVar3 = *(undefined4 *)
		           (*(int *)(*(int *)(*(int *)(*(int *)(*param2 + 0xc) + 8) + 8) + 0x10) + 0x54);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_uint____ctor
		            (uVar2,uVar3,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar3 = *param3;
		  uVar2 = unnamed_function_1417
		                    (System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_Market_Model_MarketModel___c__DisplayClass34_0__GetOptionsLots_b__0__,0
		            );
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,
		                     Method_System_Linq_Enumerable_Where_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  iVar1 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		                      );
		  if (*(int *)(iVar1 + 0xc) == 0) {
		    uVar2 = Gameplay_Market_Model_MarketModel__GetOptionsLots(param1,param2,param3,iVar1);
		    return uVar2;
		  }
		  *(int *)(param1 + 0x24) = iVar1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x7771", Offset = "0x7771", VA = "0x7771")]
		public IList<MarketLotListElement.MarketLotListElementArgs> GetOptionsLots(in MarketLotListElement.MarketLotListElementArgs targetItem, in IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		/* --- GHIDRA: GetOptionsLots ---
		undefined4
		Gameplay_Market_Model_MarketModel__GetOptionsLots
		          (int param1,int *param2,undefined4 *param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a006 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Model_MarketModel___c__DisplayClass35_0__GetSimilarArtifacts_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c__DisplayClass35_0_TypeInfo);
		    DAT_ram_00a5a006 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Market_Model_MarketModel___c__DisplayClass35_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) =
		       *(undefined4 *)(*(int *)(*(int *)(*(int *)(*(int *)(*param2 + 0xc) + 8) + 8) + 0x10) + 0x20);
		  param1_00 = *param3;
		  uVar1 = unnamed_function_1417
		                    (System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_Market_Model_MarketModel___c__DisplayClass35_0__GetSimilarArtifacts_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Where_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x7772", Offset = "0x7772", VA = "0x7772")]
		public IList<MarketLotListElement.MarketLotListElementArgs> GetSimilarArtifacts(in MarketLotListElement.MarketLotListElementArgs targetItem, in IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		/* --- GHIDRA: GetSimilarArtifacts ---
		undefined4
		Gameplay_Market_Model_MarketModel__GetSimilarArtifacts
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a007 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_MarketLotListElement_MarketLotListElementArgs__int___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Take_MarketLotListElement_MarketLotListElementArgs___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Random_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Model_MarketModel___c__DisplayClass36_0__GetRandomOptionsArtifacts_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c__DisplayClass36_0_TypeInfo);
		    DAT_ram_00a5a007 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Market_Model_MarketModel___c__DisplayClass36_0_TypeInfo);
		  uVar1 = unnamed_function_1417(System_Random_TypeInfo);
		  System_PlatformNotSupportedException___ctor(uVar1,0);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  param1_00 = *param2;
		  uVar1 = unnamed_function_1417
		                    (System_Func_MarketLotListElement_MarketLotListElementArgs__int__TypeInfo);
		  func_ii_7937(uVar1,param2_00,
		               Method_Gameplay_Market_Model_MarketModel___c__DisplayClass36_0__GetRandomOptionsArtifacts_b__0__
		               ,0);
		  uVar1 = System_Linq_Enumerable__OrderBy_KeyValuePair_uint__object___uint_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_OrderBy_MarketLotListElement_MarketLotListElementArgs__int___
		                    );
		  uVar1 = System_Linq_Enumerable__Sum___Il2CppFullySharedGenericType_
		                    (uVar1,*(undefined4 *)(param1 + 0x14),
		                     Method_System_Linq_Enumerable_Take_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002635")]
		[Address(RVA = "0x7773", Offset = "0x7773", VA = "0x7773")]
		public IList<MarketLotListElement.MarketLotListElementArgs> GetRandomOptionsArtifacts(in IList<MarketLotListElement.MarketLotListElementArgs> availableLots)
		{
		/* --- GHIDRA: GetRandomOptionsArtifacts ---
		int Gameplay_Market_Model_MarketModel__GetRandomOptionsArtifacts
		              (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined8 param2_00;
		  undefined8 uVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  iVar10 = 0;
		  if (DAT_ram_00a5a008 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    DAT_ram_00a5a008 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  piVar6 = (int *)*param2;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811b27db;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811b27db:
		  uVar5 = CONCAT44(in_register_20000014,puVar1[1]);
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,uVar5);
		  uVar4 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  iVar7 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  uVar5 = CONCAT44(uVar4,uVar2);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar7,uVar2,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  do {
		    uVar4 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    piVar6 = (int *)*param2;
		    iVar8 = *piVar6;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8);
		        if (System_Collections_Generic_ICollection_ulong__TypeInfo == *piVar12) {
		          puVar1 = (uint *)(iVar8 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x811b2878;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811b2878:
		    uVar5 = CONCAT44(uVar4,puVar1[1]);
		    iVar8 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,uVar5);
		    uVar4 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    if (iVar8 <= iVar10) break;
		    piVar6 = (int *)*param2;
		    iVar8 = *piVar6;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8);
		        if (System_Collections_Generic_IList_ulong__TypeInfo == *piVar12) {
		          puVar1 = (uint *)(iVar8 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x811b28fc;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IList_ulong__TypeInfo,0);
		code_r0x811b28fc:
		    param2_00 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,CONCAT44(uVar4,iVar10),puVar1[1]);
		    uVar5 = param2_00;
		    iVar3 = func_ii_7090(*(undefined4 *)(param1 + 0x20),param2_00,&local_4,
		                         Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__TryGetValue__
		                        );
		    iVar8 = 
		    Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__;
		    if (iVar3 != 0) {
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar9 = *(uint *)(iVar7 + 0xc);
		      if (uVar9 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar9 + 1;
		        *(undefined4 *)(*(int *)(iVar7 + 8) + uVar9 * 4 + 0x10) = local_4;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar7,local_4,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		      }
		      Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		                (*(undefined4 *)(param1 + 0x20),param2_00,
		                 Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__Remove__
		                );
		      uVar5 = param2_00;
		      iVar8 = func_ii_7090(*(undefined4 *)(param1 + 0x10),param2_00,&local_8,
		                           Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___TryGetValue__
		                          );
		      if (iVar8 != 0) {
		        iVar8 = 0;
		        iVar3 = func_ii_6295(local_8,
		                             Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		                            );
		        if (0 < *(int *)(iVar3 + 0xc)) {
		          do {
		            uVar4 = *(undefined4 *)(param1 + 0x10);
		            uVar5 = func_ii_7957(*(undefined4 *)
		                                  (*(int *)(*(int *)(iVar3 + iVar8 * 4 + 0x10) + 0xc) + 8),0);
		            piVar6 = (int *)System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                                      (uVar4,uVar5,
		                                       Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___get_Item__
		                                      );
		            uVar4 = local_4;
		            uVar2 = (undefined4)((ulonglong)uVar5 >> 0x20);
		            iVar11 = *piVar6;
		            if (*(ushort *)(iVar11 + 0xb6) != 0) {
		              uVar9 = 0;
		              do {
		                piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar9 * 8);
		                if (System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    == *piVar12) {
		                  puVar1 = (uint *)(piVar12[1] * 8 + iVar11 + 0xf0);
		                  goto code_r0x811b2a79;
		                }
		                uVar9 = uVar9 + 1;
		              } while (*(ushort *)(iVar11 + 0xb6) != uVar9);
		            }
		            puVar1 = (uint *)func_ii_1080(piVar6,
		                                          System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                          ,6);
		code_r0x811b2a79:
		            (**(code **)((ulonglong)*puVar1 * 4))(piVar6,CONCAT44(uVar2,uVar4),puVar1[1]);
		            iVar8 = iVar8 + 1;
		          } while (iVar8 < *(int *)(iVar3 + 0xc));
		        }
		        Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		                  (*(undefined4 *)(param1 + 0x10),param2_00,
		                   Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___Remove__
		                  );
		        uVar5 = param2_00;
		      }
		    }
		    iVar10 = iVar10 + 1;
		  } while( true );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_18,iVar7,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                       Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		                      );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b2b8d;
		    }
		    if (iVar8 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return iVar7;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x389,
		               *(undefined4 *)(param1 + 0x18),local_10._4_4_,
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Remove__
		              );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b2b8d:
		  iVar10 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar8) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar8 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar8;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		      if (iVar8 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return iVar7;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x233,&local_20);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 != 1) {
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x7774", Offset = "0x7774", VA = "0x7774")]
		public IEnumerable<MarketLotListElement.MarketLotListElementArgs> RemoveArtifacts(in IList<ulong> ids)
		{
		/* --- GHIDRA: RemoveArtifacts ---
		int Gameplay_Market_Model_MarketModel__RemoveArtifacts
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined8 param2_01;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_02;
		  int param3_00;
		  
		  if (DAT_ram_00a5a009 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_MarketLotListElement_MarketLotListElementArgs__string___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel_ConstructUserMarketLotData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__AddArtifacts_b__38_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    DAT_ram_00a5a009 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Market_Model_MarketModel_ConstructUserMarketLotData__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_UserArtifactWithMarketBacktimer__MarketLotListElement_MarketLotListElementArgs___
		                    );
		  param2_00 = func_ii_6295(uVar1,
		                           Method_System_Linq_Enumerable_ToArray_MarketLotListElement_MarketLotListElementArgs___
		                          );
		  func_ii_6335(*(undefined4 *)(param1 + 0x18),param2_00,
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__AddRange__
		              );
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[9];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    param2_02 = *puVar2;
		    iVar3 = unnamed_function_1417
		                      (System_Func_MarketLotListElement_MarketLotListElementArgs__string__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar3,param2_02,Method_Gameplay_Market_Model_MarketModel___c__AddArtifacts_b__38_0__,
		               0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x24) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_object__long_
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_OrderBy_MarketLotListElement_MarketLotListElementArgs__string___
		                    );
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,
		                     Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  if (0 < *(int *)(param2_00 + 0xc)) {
		    iVar3 = 0;
		    do {
		      uVar1 = *(undefined4 *)(param1 + 0x20);
		      param3_00 = *(int *)(param2_00 + iVar3 * 4 + 0x10);
		      param2_01 = func_ii_7957(*(undefined4 *)(*(int *)(param3_00 + 0xc) + 8),0);
		      BestHTTP_Caching_HTTPCacheFileInfo___ctor
		                (uVar1,param2_01,param3_00,
		                 Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__Add__
		                );
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(param2_00 + 0xc));
		  }
		  return param2_00;
		}
		*/

			return null;
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002637")]
		[Address(RVA = "0x7775", Offset = "0x7775", VA = "0x7775")]
		public IEnumerable<MarketLotListElement.MarketLotListElementArgs> AddArtifacts(IList<UserArtifactWithMarketBacktimer> artifacts)
		{
		/* --- GHIDRA: AddArtifacts ---
		int Gameplay_Market_Model_MarketModel__AddArtifacts(int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int *param1_00;
		  undefined4 uVar6;
		  uint uVar7;
		  int local_4;
		  
		  if (DAT_ram_00a5a00a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Market_View_MarketLotListElement_MarketLotListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_Data_MarketOptionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a5a00a = '\x01';
		  }
		  local_4 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 400);
		        goto code_r0x811b1e25;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x811b1e25:
		  iVar5 = 0;
		  iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  iVar2 = func_ii_6875(*(undefined4 *)(iVar2 + 0x2c),*(undefined4 *)(*(int *)(param2 + 0xc) + 0xc),
		                       &local_4,0);
		  if (iVar2 != 0) {
		    uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(param2 + 0x10),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Item__);
		    iVar2 = Core_Data_ArtifactData__IsGuideTarget
		                      (uVar3,*(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 0xc),0);
		    iVar5 = local_4;
		    *(undefined4 *)(iVar2 + 0x80) = 4;
		    *(undefined4 *)(iVar2 + 0x70) = *(undefined4 *)(param1 + 8);
		    piVar4 = (int *)unnamed_function_1417(Gameplay_Market_Model_Data_MarketOptionData_TypeInfo);
		    piVar4[5] = iVar5;
		    piVar4[2] = iVar2;
		    if (DAT_ram_00a59ffb == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a59ffb = '\x01';
		    }
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811b1f37;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811b1f37:
		    uVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    iVar5 = Core_Extensions_Dict_DictExt__TryGetAccountDic(uVar3,*(undefined4 *)(param2 + 0x14),0);
		    if (iVar5 == 0) {
		      iVar5 = 0;
		    }
		    else {
		      iVar5 = Core_Extensions_Dict_OptionStickerDicExt__GetBadgeAssetId(iVar5,0);
		    }
		    piVar4[4] = iVar5;
		    uVar3 = *(undefined4 *)(local_4 + 0x5c);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar5 = Core_Money_Money__get_IsEmpty(uVar3,0,0);
		    if (iVar5 != 0) {
		      uVar3 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		      uVar6 = *(undefined4 *)(*(int *)(local_4 + 0x5c) + 8);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar6 = func_ii_7278(uVar6,0);
		      Core_Extensions_Dict_ResourceSetExt__HasNewCurrency
		                (uVar3,uVar6,*(double *)(*(int *)(local_4 + 0x5c) + 0x10),0);
		      (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe8) * 4))
		                (piVar4,uVar3,*(undefined4 *)(*piVar4 + 0xec));
		    }
		    iVar5 = unnamed_function_1417
		                      (Gameplay_Market_View_MarketLotListElement_MarketLotListElementArgs_TypeInfo);
		    Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext(iVar5,0)
		    ;
		    *(int **)(iVar5 + 0xc) = piVar4;
		  }
		  return iVar5;
		}
		*/

			return null;
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002638")]
		[Address(RVA = "0x7776", Offset = "0x7776", VA = "0x7776")]
		private MarketLotListElement.MarketLotListElementArgs ConstructOptionLotData(MarketOptionsDic dic)
		{
		/* --- GHIDRA: ConstructOptionLotData ---
		int Gameplay_Market_Model_MarketModel__ConstructOptionLotData
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a00b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Market_View_MarketLotListElement_MarketLotListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_Data_UserMarketLotData_TypeInfo);
		    DAT_ram_00a5a00b = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x158);
		        goto code_r0x811b2ee6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x811b2ee6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar3,0);
		  param1_00 = func_ii_8553(uVar3,*(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0xc) + 0x10),
		                           *(undefined4 *)(param1 + 8),0);
		  *(undefined4 *)(param1_00 + 0x80) = 4;
		  iVar5 = *(int *)(*(int *)(param2 + 0xc) + 0x10);
		  if (iVar5 == 0) {
		    iVar5 = Core_Data_ArtifactData__get_IsTemporaryWithExpiredLifetime(param1_00,0);
		  }
		  piVar4 = (int *)unnamed_function_1417(Gameplay_Market_Model_Data_UserMarketLotData_TypeInfo);
		  piVar4[2] = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe8) * 4))
		            (piVar4,iVar5,*(undefined4 *)(*piVar4 + 0xec));
		  iVar5 = unnamed_function_1417
		                    (Gameplay_Market_View_MarketLotListElement_MarketLotListElementArgs_TypeInfo);
		  Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext(iVar5,0);
		  *(int **)(iVar5 + 0xc) = piVar4;
		  return iVar5;
		}
		*/

			return null;
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x7777", Offset = "0x7777", VA = "0x7777")]
		private MarketLotListElement.MarketLotListElementArgs ConstructUserMarketLotData(UserArtifactWithMarketBacktimer userArtifact)
		{
		/* --- GHIDRA: ConstructUserMarketLotData ---
		int Gameplay_Market_Model_MarketModel__ConstructUserMarketLotData
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  ulonglong uVar3;
		  
		  if (DAT_ram_00a5a00c == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Market_Model_MarketModel_MarketOptionWithBacktime_TypeInfo);
		    DAT_ram_00a5a00c = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Market_Model_MarketModel_MarketOptionWithBacktime_TypeInfo)
		  ;
		  *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param2 + 0xc);
		  uVar3 = *(ulonglong *)(param2 + 0x10);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,(float)uVar3,0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  uVar3 = *(ulonglong *)(param2 + 0x18);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,(float)uVar3,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600263A")]
		[Address(RVA = "0x7778", Offset = "0x7778", VA = "0x7778")]
		private MarketModel.MarketOptionWithBacktime ConstructMarketOptionWithBacktime(ProtoGetMarketArtifactsAns.Types.MarketOptionTimer optionTimer)
		{
			return null;
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600263B RID: 9787 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x17000731")]
		public ArtikulTypeFilters.Types.FilterType FilterType
		{
			[Token(Token = "0x600263B")]
			[Address(RVA = "0x7779", Offset = "0x7779", VA = "0x7779")]
			get
			{
				return ArtikulTypeFilters.Types.FilterType.UnknownFilterType;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000732")]
		public Dictionary<uint, ArtikulTypeFilters> AllFilters
		{
			[Token(Token = "0x600263C")]
			[Address(RVA = "0x777A", Offset = "0x777A", VA = "0x777A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263D")]
		[Address(RVA = "0x777B", Offset = "0x777B", VA = "0x777B")]
		[CompilerGenerated]
		private void <PopulateMarketArtifacts>g__HandleOptionToExpire|28_2(ref MarketModel.<>c__DisplayClass28_0 A_1)
		{
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x777C", Offset = "0x777C", VA = "0x777C")]
		[CompilerGenerated]
		private void <PopulateMarketArtifacts>g__HandleOptionsToAdd|28_3(ref MarketModel.<>c__DisplayClass28_0 A_1)
		{
		}

		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<ulong, IList<MarketLotListElement.MarketLotListElementArgs>> _cachedOtherArtifacts;

		// Token: 0x040014DF RID: 5343
		[Token(Token = "0x40014DF")]
		[FieldOffset(Offset = "0x14")]
		public readonly int MaxSimilarItemsCount;

		// Token: 0x040014E4 RID: 5348
		[Token(Token = "0x40014E4")]
		[FieldOffset(Offset = "0x28")]
		private Stack<MarketModel.MarketOptionWithBacktime> _removeStackSorted;

		// Token: 0x040014E5 RID: 5349
		[Token(Token = "0x40014E5")]
		[FieldOffset(Offset = "0x2C")]
		private Stack<MarketModel.MarketOptionWithBacktime> _addStackSorted;

		// Token: 0x040014E6 RID: 5350
		[Token(Token = "0x40014E6")]
		[FieldOffset(Offset = "0x30")]
		public readonly TabBarItemData<MarketLotData.DataType>[] TabBarData;

		// Token: 0x040014E7 RID: 5351
		[Token(Token = "0x40014E7")]
		[FieldOffset(Offset = "0x34")]
		public readonly TabBarItemData[] ExtraTabsData;

		// Token: 0x040014E8 RID: 5352
		[Token(Token = "0x40014E8")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, ArtikulTypeFilters> _allFilters;

		// Token: 0x02000625 RID: 1573
		[Token(Token = "0x2000625")]
		public class MarketOptionWithBacktime
		{
			// Token: 0x06002640 RID: 9792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002640")]
			[Address(RVA = "0x777E", Offset = "0x777E", VA = "0x777E")]
			public MarketOptionWithBacktime()
			{
			}

			// Token: 0x040014E9 RID: 5353
			[Token(Token = "0x40014E9")]
			[FieldOffset(Offset = "0x8")]
			public uint OptionId;

			// Token: 0x040014EA RID: 5354
			[Token(Token = "0x40014EA")]
			[FieldOffset(Offset = "0xC")]
			public BackTime StartBackTime;

			// Token: 0x040014EB RID: 5355
			[Token(Token = "0x40014EB")]
			[FieldOffset(Offset = "0x10")]
			public BackTime EndBackTime;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ExtraArtifactsResult ---
		void Gameplay_Market_Model_MarketModel__set_ExtraArtifactsResult
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  
		  if (DAT_ram_00a59ffc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_MarketOptionsDic__MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Where_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_MarketOptionsDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_MarketOptionsDic__MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_MarketOptionsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Market_Model_MarketModel_ConstructOptionLotData__)
		    ;
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_MarketLotData_DataType____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_MarketLotData_DataType___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_MarketLotData_DataType__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Market_Model_MarketModel___c___ctor_b__25_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__DisplayClass25_0___ctor_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c__DisplayClass25_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25281);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10699);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10698);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10701);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10700);
		    DAT_ram_00a59ffc = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_ulong__IList_MarketLotListElement_MarketLotListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Tabs_TabBarItemData_MarketLotData_DataType____TypeInfo,2);
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10700,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x20) = 0;
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar4;
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10699,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x20) = 1;
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[5] = iVar4;
		  *(int **)(param1 + 0x30) = piVar3;
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,3);
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10701,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar4;
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10702,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[5] = iVar4;
		  iVar4 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10698,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar2;
		  iVar5 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar5 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[6] = iVar4;
		  *(int **)(param1 + 0x34) = piVar3;
		  iVar4 = unnamed_function_1417(Gameplay_Market_Model_MarketModel___c__DisplayClass25_0_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(int *)(iVar4 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x811b0623;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b0623:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		  *(int **)(param1 + 0xc) = piVar3;
		  if (DAT_ram_00a59ffb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a59ffb = '\x01';
		    piVar3 = *(int **)(param1 + 0xc);
		  }
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811b06d1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811b06d1:
		  uVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_25281,0);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		        goto code_r0x811b0788;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x811b0788:
		  uVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		  *(undefined4 *)(iVar4 + 0xc) = uVar2;
		  if (DAT_ram_00a59ffb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a59ffb = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0xc);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811b082e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811b082e:
		  iVar5 = (**(code **)((ulonglong)*puVar6 * 4))(piVar3,puVar6[1]);
		  uVar7 = *(undefined4 *)(iVar5 + 0x1cc);
		  uVar2 = unnamed_function_1417(System_Func_MarketOptionsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar4,
		             Method_Gameplay_Market_Model_MarketModel___c__DisplayClass25_0___ctor_b__0__,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar7,uVar2,Method_System_Linq_Enumerable_Where_MarketOptionsDic___);
		  uVar7 = unnamed_function_1417
		                    (
		                    System_Func_MarketOptionsDic__MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar7,param1,Method_Gameplay_Market_Model_MarketModel_ConstructOptionLotData__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar7,
		                     Method_System_Linq_Enumerable_Select_MarketOptionsDic__MarketLotListElement_MarketLotListElementArgs___
		                    );
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar8[1];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar8;
		    iVar4 = unnamed_function_1417
		                      (System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar7,Method_Gameplay_Market_Model_MarketModel___c___ctor_b__25_1__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 4) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_Where_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,
		                     Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/


		/* --- GHIDRA: get_FilterType ---
		int Gameplay_Market_Model_MarketModel__get_FilterType(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  undefined4 *puVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a00d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_ArtikulTypeFilters__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeFilters__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__get_AllFilters_b__46_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    DAT_ram_00a5a00d = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x38);
		  if (iVar4 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x811b310e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b310e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar3 = Core_Extensions_Dict_DictExt__GetGameFiledGems(uVar3,4,0);
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    }
		    puVar5 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    iVar4 = puVar5[10];
		    if (iVar4 == 0) {
		      if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		        puVar5 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar5;
		      iVar4 = unnamed_function_1417(System_Func_ArtikulTypeFilters__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar4,param2_00,
		                 Method_Gameplay_Market_Model_MarketModel___c__get_AllFilters_b__46_0__,0);
		      *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x28) = iVar4;
		    }
		    iVar4 = System_Linq_Enumerable__ToDictionary_object__object_
		                      (uVar3,iVar4,
		                       Method_System_Linq_Enumerable_ToDictionary_ArtikulTypeFilters__uint___);
		    *(int *)(param1 + 0x38) = iVar4;
		  }
		  return iVar4;
		}
		*/


		/* --- GHIDRA: get_AllFilters ---
		void Gameplay_Market_Model_MarketModel__get_AllFilters(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a00e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_MarketModel_MarketOptionWithBacktime__float___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_MarketModel_MarketOptionWithBacktime___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Where_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_MarketModel_MarketOptionWithBacktime__float__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel_ConstructMarketOptionWithBacktime__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_5__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel___c_TypeInfo);
		    DAT_ram_00a5a00e = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*param2 + 0x10);
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[4];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417
		                      (
		                      System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__bool__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar1,
		               Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_4__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x10) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_Where_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer___
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_Market_Model_MarketModel_ConstructMarketOptionWithBacktime__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetMarketArtifactsAns_Types_MarketOptionTimer__MarketModel_MarketOptionWithBacktime___
		                    );
		  if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[5];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Model_MarketModel___c_TypeInfo);
		      puVar3 = *(undefined4 **)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_MarketModel_MarketOptionWithBacktime__float__TypeInfo)
		    ;
		    System_Func_object__SerializableProjectConfiguration___Invoke
		              (iVar4,uVar1,
		               Method_Gameplay_Market_Model_MarketModel___c__PopulateMarketArtifacts_b__28_5__,0);
		    *(int *)(*(int *)(Gameplay_Market_Model_MarketModel___c_TypeInfo + 0x5c) + 0x14) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__OrderBy_object__object_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_OrderBy_MarketModel_MarketOptionWithBacktime__float___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_MarketModel_MarketOptionWithBacktime___
		                      );
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime__TypeInfo
		                    );
		  System_Collections_Generic_Stack_object____ctor
		            (uVar1,uVar2,
		             Method_System_Collections_Generic_Stack_MarketModel_MarketOptionWithBacktime___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  Gameplay_Market_Model_MarketModel__PopulateMarketArtifacts(param1,param1);
		  return;
		}
		*/

}
