using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay;
using Gameplay.Collections.Model.Factories;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Collections;
using Protocol.Common;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.Collections.Model
{
	// Token: 0x020009D7 RID: 2519
	[Token(Token = "0x20009D7")]
	public class CollectionsModel : AbstractModel
	{
		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDF")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6003C3F")]
			[Address(RVA = "0x8B0D", Offset = "0x8B0D", VA = "0x8B0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C40")]
			[Address(RVA = "0x8B0E", Offset = "0x8B0E", VA = "0x8B0E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE0")]
		public IGame Game
		{
			[Token(Token = "0x6003C41")]
			[Address(RVA = "0x8B0F", Offset = "0x8B0F", VA = "0x8B0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C42")]
			[Address(RVA = "0x8B10", Offset = "0x8B10", VA = "0x8B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BE1")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003C43")]
			[Address(RVA = "0x8B11", Offset = "0x8B11", VA = "0x8B11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003C45 RID: 15429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BE2")]
		[NotNull]
		public ICollectionDataFactory CollectionDataFactory
		{
			[Token(Token = "0x6003C44")]
			[Address(RVA = "0x8B12", Offset = "0x8B12", VA = "0x8B12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C45")]
			[Address(RVA = "0x8B13", Offset = "0x8B13", VA = "0x8B13")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C46")]
		[Address(RVA = "0x8B14", Offset = "0x8B14", VA = "0x8B14", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Collections_Model_CollectionsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,int param4,int *param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57eb6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__HashSet_uint____ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__HashSet_uint___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__CollectionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_MarketOptionsDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_MarketOptionsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Model_CollectionsModel___c___ctor_b__23_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		    DAT_ram_00a57eb6 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs____ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__CollectionData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__CollectionData___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__HashSet_uint___TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__HashSet_uint____ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x34) = param2;
		  *(int **)(param1 + 0x10) = param5;
		  *(int *)(param1 + 0x14) = param4;
		  *(bool *)(param1 + 0x18) = *(int *)(param1 + 8) == param4;
		  iVar6 = *param5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80e74058;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e74058:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param5,puVar3[1]);
		  *(int **)(param1 + 0xc) = param1_00;
		  if (DAT_ram_00a57eb4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57eb4 = '\x01';
		    param1_00 = *(int **)(param1 + 0xc);
		  }
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e740fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e740fe:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = *(undefined4 *)(iVar6 + 0x1cc);
		  if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar5[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_MarketOptionsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,uVar4,Method_Gameplay_Collections_Model_CollectionsModel___c___ctor_b__23_0__,0
		              );
		    *(int *)(*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,iVar6,Method_System_Linq_Enumerable_Select_MarketOptionsDic__uint___);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		  System_Collections_Generic_HashSet_uint____ctor
		            (uVar4,uVar2,Method_System_Collections_Generic_HashSet_uint___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar4;
		  return;
		}
		*/

		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x8B15", Offset = "0x8B15", VA = "0x8B15")]
		public CollectionsModel(ICollectionDataFactory collectionDataFactory, UserData user, UserData loggedUser, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		int * Gameplay_Collections_Model_CollectionsModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  int param1_00;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  undefined4 param2_00;
		  int iVar9;
		  
		  if (DAT_ram_00a57eb7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_CollectionsCategoriesDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_CollectionsCategoriesDic___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_CollectionsCategoriesDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Model_CollectionsModel___c__GetTabBarData_b__24_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9110);
		    DAT_ram_00a57eb7 = '\x01';
		  }
		  if (DAT_ram_00a57eb4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57eb4 = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = *(int **)(param1 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e770a9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e770a9:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x120);
		  if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		  }
		  puVar8 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar8[2];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		      puVar8 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar8;
		    iVar6 = unnamed_function_1417(System_Func_CollectionsCategoriesDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,param2_00,
		               Method_Gameplay_Collections_Model_CollectionsModel___c__GetTabBarData_b__24_0__,0);
		    *(int *)(*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c) + 8) = iVar6;
		  }
		  uVar7 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar7,iVar6,
		                     Method_System_Linq_Enumerable_OrderBy_CollectionsCategoriesDic__uint___);
		  iVar6 = func_ii_6295(uVar7,Method_System_Linq_Enumerable_ToArray_CollectionsCategoriesDic___);
		  piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (UI_Tabs_TabBarItemData___TypeInfo,*(int *)(iVar6 + 0xc) + 1);
		  iVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar7 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9110,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar3 + 0x14) = 0;
		  *(undefined4 *)(iVar3 + 0x10) = uVar7;
		  iVar4 = func_ii_1082(iVar3,*(undefined4 *)(*piVar5 + 0x20));
		  if (iVar4 != 0) {
		    piVar5[4] = iVar3;
		    iVar3 = 1;
		    if (0 < *(int *)(iVar6 + 0xc)) {
		      iVar4 = 0;
		      do {
		        iVar9 = *(int *)(iVar6 + iVar4 * 4 + 0x10);
		        param1_00 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		        *(undefined4 *)(param1_00 + 0x10) = *(undefined4 *)(iVar9 + 0x10);
		        *(undefined4 *)(param1_00 + 0x14) = *(undefined4 *)(iVar9 + 0xc);
		        iVar9 = func_ii_1082(param1_00,*(undefined4 *)(*piVar5 + 0x20));
		        if (iVar9 == 0) {
		          uVar7 = func_ii_1083();
		          func_ii_1050(uVar7,0);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar5[iVar3 + 4] = param1_00;
		        iVar3 = iVar3 + 1;
		        iVar4 = iVar4 + 1;
		      } while (iVar4 < *(int *)(iVar6 + 0xc));
		    }
		    return piVar5;
		  }
		  uVar7 = func_ii_1083();
		  func_ii_1050(uVar7,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x8B16", Offset = "0x8B16", VA = "0x8B16")]
		public TabBarItemData[] GetTabBarData()
		{
			return null;
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x8B17", Offset = "0x8B17", VA = "0x8B17")]
		public List<CollectionListElement.CollectionListElementArgs> GetAllCollections()
		{
		/* --- GHIDRA: GetAllCollections ---
		void Gameplay_Collections_Model_CollectionsModel__GetAllCollections
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57eb8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Model_CollectionsModel__PopulateModel_b__26_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_CollectionsCategoriesDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_SelectMany_CollectionsCategoriesDic__CollectionListElement_CollectionListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_CollectionListElement_CollectionListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_CollectionsCategoriesDic__IEnumerable_CollectionListElement_CollectionListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_CollectionsCategoriesDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ProtoGetUserCollectionsAns_Types_UserCollection__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoGetUserCollectionsAns_Types_UserCollection__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Model_CollectionsModel___c__PopulateModel_b__26_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		    DAT_ram_00a57eb8 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ProtoGetUserCollectionsAns_Types_UserCollection__TypeInfo
		          == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e77368;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_ProtoGetUserCollectionsAns_Types_UserCollection__TypeInfo
		                                ,0);
		code_r0x80e77368:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e77436;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x80e775b9:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e775c1;
		    }
		code_r0x80e77436:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x80e775b9;
		    if (iVar9 == 0) {
		      iVar9 = 0;
		      puVar2 = DAT_ram_009d3e38;
		      goto code_r0x80e7760a;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ProtoGetUserCollectionsAns_Types_UserCollection__TypeInfo
		            == *piVar8) {
		          puVar3 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e77510;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = (uint *)0x0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProtoGetUserCollectionsAns_Types_UserCollection__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == (uint *)0x1) {
		code_r0x80e775a5:
		      DAT_ram_009d3e38 = (uint *)0x0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e775c1;
		    }
		code_r0x80e77510:
		    DAT_ram_009d3e38 = (uint *)0x0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == (uint *)0x1) goto code_r0x80e775a5;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd0,*(undefined4 *)(param1 + 0x24)
		               ,*(undefined4 *)(iVar9 + 0xc),*(undefined4 *)(iVar9 + 0x10),
		               Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		    iVar9 = (int)DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		  } while (iVar9 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e775c1:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar9 = *piVar6;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    puVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = (uint *)0x0;
		    if (puVar2 != (uint *)0x1) {
		code_r0x80e7760a:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = (uint *)0x0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e77682;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e77682:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar9 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      Gameplay_Collections_Model_CollectionsModel__ClearCallbacks(param1,puVar2);
		      Gameplay_Collections_Model_CollectionsModel__GetAcquiredCollectionsWhitMaxLevelCount
		                (param1,puVar2);
		      if (DAT_ram_00a57eb4 == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		        DAT_ram_00a57eb4 = '\x01';
		      }
		      piVar6 = *(int **)(param1 + 0xc);
		      iVar9 = *piVar6;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xd0);
		            goto code_r0x80e77734;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e77734:
		      iVar9 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      uVar4 = *(undefined4 *)(iVar9 + 0x120);
		      if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		      }
		      puVar3 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		      iVar9 = puVar3[3];
		      if (iVar9 == 0) {
		        if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		          puVar3 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c)
		          ;
		        }
		        uVar7 = *puVar3;
		        iVar9 = unnamed_function_1417(System_Func_CollectionsCategoriesDic__uint__TypeInfo);
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar9,uVar7,
		                   Method_Gameplay_Collections_Model_CollectionsModel___c__PopulateModel_b__26_0__,0
		                  );
		        *(int *)(*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c) + 0xc) =
		             iVar9;
		      }
		      uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                        (uVar4,iVar9,
		                         Method_System_Linq_Enumerable_OrderBy_CollectionsCategoriesDic__uint___);
		      uVar7 = unnamed_function_1417
		                        (
		                        System_Func_CollectionsCategoriesDic__IEnumerable_CollectionListElement_CollectionListElementArgs___TypeInfo
		                        );
		      System_Linq_Enumerable__Where_object_
		                (uVar7,param1,
		                 Method_Gameplay_Collections_Model_CollectionsModel__PopulateModel_b__26_1__,0);
		      uVar4 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                        (uVar4,uVar7,
		                         Method_System_Linq_Enumerable_SelectMany_CollectionsCategoriesDic__CollectionListElement_CollectionListElementArgs___
		                        );
		      uVar4 = System_Linq_Enumerable__Select_object__object_
		                        (uVar4,
		                         Method_System_Linq_Enumerable_ToList_CollectionListElement_CollectionListElementArgs___
		                        );
		      *(undefined4 *)(param1 + 0x28) = uVar4;
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = (uint *)0x0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd1,&local_c);
		  iVar9 = (int)DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = (uint *)0x0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x8B18", Offset = "0x8B18", VA = "0x8B18")]
		public void PopulateModel(IList<ProtoGetUserCollectionsAns.Types.UserCollection> collections)
		{
		/* --- GHIDRA: PopulateModel ---
		void Gameplay_Collections_Model_CollectionsModel__PopulateModel(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57eb9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__GetEnumerator__
		              );
		    DAT_ram_00a57eb9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_CollectionListElement_CollectionListElementArgs__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    *(undefined4 *)(local_8._4_4_ + 0x10) = 0;
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd6,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_00);
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

		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x8B19", Offset = "0x8B19", VA = "0x8B19")]
		public void ClearCallbacks()
		{
		/* --- GHIDRA: ClearCallbacks ---
		void Gameplay_Collections_Model_CollectionsModel__ClearCallbacks(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 param2_00;
		  int param2_01;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 param2_02;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57eba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_CollectionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CollectionsDic__GetEnumerator__);
		    DAT_ram_00a57eba = '\x01';
		  }
		  if (DAT_ram_00a57eb4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57eb4 = '\x01';
		  }
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0xc);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80e77981;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e77981:
		  iVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar8 + 0x124),
		                              Method_Google_Protobuf_Collections_RepeatedField_CollectionsDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80e779cc:
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e77a60;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e77ea4:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		code_r0x80e77a60:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e77ea4;
		    if (iVar8 == 0) goto code_r0x80e77ef5;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CollectionsDic__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e77b41;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_CollectionsDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e77c13:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		code_r0x80e77b41:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e77c13;
		    uVar5 = *(undefined4 *)(iVar8 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd2,
		                       *(undefined4 *)(param1 + 0x24),*(undefined4 *)(iVar8 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__uint__ContainsKey__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		    if (iVar4 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd3,param1,uVar5,
		                 *(undefined4 *)(iVar8 + 0xc),iVar8);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e77eac;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd4,param1,iVar8,iVar8);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,
		               *(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar8 + 0xc),
		               *(undefined4 *)(iVar4 + 0xc),
		               Method_System_Collections_Generic_Dictionary_uint__CollectionData__Add__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,
		                       *(undefined4 *)(param1 + 0x1c),uVar5,
		                       Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___ContainsKey__
		                      );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		    if (iVar6 == 0) {
		      param2_02 = *(undefined4 *)(param1 + 0x1c);
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__TypeInfo
		                            );
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,param2_00,
		                   Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs___ctor__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,param2_02,uVar5,
		                     param2_00,
		                     Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___set_Item__
		                    );
		          if (DAT_ram_009d3e38 != 1) goto code_r0x80e77dc1;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		code_r0x80e77dc1:
		    DAT_ram_009d3e38 = 0;
		    param2_01 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,
		                           *(undefined4 *)(param1 + 0x1c),uVar5,
		                           Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Item__
		                          );
		    iVar6 = DAT_ram_009d3e38;
		    iVar8 = 
		    Method_System_Collections_Generic_List_CollectionListElement_CollectionListElementArgs__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e77eac;
		    }
		    *(int *)(param2_01 + 0x10) = *(int *)(param2_01 + 0x10) + 1;
		    uVar1 = *(uint *)(param2_01 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param2_01 + 8) + 0xc)) {
		      *(uint *)(param2_01 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(param2_01 + 8) + uVar1 * 4 + 0x10) = iVar4;
		      goto code_r0x80e779cc;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_01,iVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e77eac:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_c = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80e77ef5:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8;
		      if (piVar7 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *piVar7;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e77f70;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80e77f70:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd5,&local_c);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x8B1A", Offset = "0x8B1A", VA = "0x8B1A")]
		private void PopulateCollections()
		{
		/* --- GHIDRA: PopulateCollections ---
		void Gameplay_Collections_Model_CollectionsModel__PopulateCollections
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ebc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		    DAT_ram_00a57ebc = '\x01';
		  }
		  if (*(int *)(param2 + 0x1c) == 0) {
		    iVar1 = System_Xml_XsdCachingReader__get_Name(param2,0);
		    uVar3 = *(undefined4 *)(iVar1 + 0x10);
		    uVar2 = System_Linq_Enumerable__FirstOrDefault_uint_(param2,0);
		    System_Collections_Generic_Dictionary_uint__uint___ContainsKey(param1,uVar3,uVar2,param2);
		  }
		  Core_Data_CollectionData___ctor(param2,0);
		  uVar3 = *(undefined4 *)(param1 + 0x24);
		  uVar2 = System_Linq_Enumerable__FirstOrDefault_uint_(param2,0);
		  func_ii_7254(uVar3,uVar2,*(undefined4 *)(param2 + 0x1c),
		               Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		  return;
		}
		*/

		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x1C5A", Offset = "0x1C5A", VA = "0x1C5A")]
		private void AddAcquiredCollection(uint categoryId, uint collectionId)
		{
		/* --- GHIDRA: AddAcquiredCollection ---
		int Gameplay_Collections_Model_CollectionsModel__AddAcquiredCollection
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  float fVar6;
		  int iVar7;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57ec3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_Factories_ICollectionDataFactory_TypeInfo);
		    DAT_ram_00a57ec3 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x34);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Collections_Model_Factories_ICollectionDataFactory_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e7833d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,
		                                Gameplay_Collections_Model_Factories_ICollectionDataFactory_TypeInfo
		                                ,0);
		code_r0x80e7833d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param2,puVar2[1]);
		  if (DAT_ram_00a57ebd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		    DAT_ram_00a57ebd = '\x01';
		  }
		  local_4 = 0;
		  iVar3 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		  uVar4 = local_4;
		  if (iVar3 == 0) {
		    uVar4 = 0;
		  }
		  Gameplay_Collections_View_CollectionIconView__Init(param1_00,uVar4,0);
		  iVar3 = Core_Data_CollectionData__get_NextMedalDic(param1_00,0);
		  uVar4 = *(undefined4 *)(iVar3 + 0x14);
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo
		                    );
		  Unity_Collections_NativeArray_ReadOnly_Enumerator_Painter2D_Painter2DJobData___MoveNext(iVar3,0);
		  *(undefined4 *)(iVar3 + 0xc) = param1_00;
		  iVar5 = *(int *)(param1 + 8);
		  *(int *)(iVar3 + 0x18) = iVar5;
		  iVar7 = *(int *)(param1 + 0x14);
		  *(bool *)(iVar3 + 0x14) = iVar5 == iVar7;
		  if (iVar5 == iVar7) {
		    fVar6 = Gameplay_Collections_Model_CollectionsModel__GetMaterials(param1,uVar4,iVar3);
		  }
		  else {
		    fVar6 = 0.0;
		  }
		  *(float *)(iVar3 + 0x1c) = fVar6;
		  return iVar3;
		}
		*/

		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x8B1B", Offset = "0x8B1B", VA = "0x8B1B")]
		public void SetNextUserCollection(CollectionData data)
		{
		/* --- GHIDRA: SetNextUserCollection ---
		undefined4
		Gameplay_Collections_Model_CollectionsModel__SetNextUserCollection
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57ebd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		    DAT_ram_00a57ebd = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__uint__TryGetValue__);
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0x8B1C", Offset = "0x8B1C", VA = "0x8B1C")]
		public uint DetermineCollectionRank(CollectionsDic dic)
		{
		/* --- GHIDRA: DetermineCollectionRank ---
		int Gameplay_Collections_Model_CollectionsModel__DetermineCollectionRank
		              (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int *piVar11;
		  int local_2c;
		  int **ppiStack_28;
		  undefined8 local_24;
		  int *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  iVar10 = 0;
		  if (DAT_ram_00a57ebe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__HashSet_uint___TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CollectionData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__HashSet_uint___get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__HashSet_uint___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__HashSet_uint___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__HashSet_uint___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_CollectionListElement_CollectionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_AddRange_uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__HashSet_uint___GetEnumerator__
		              );
		    DAT_ram_00a57ebe = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_1c = (int *)0x0;
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x2c),param3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__HashSet_uint___TryGetValue__
		                    );
		  if (iVar2 == 0) {
		    uVar7 = unnamed_function_1417(System_Collections_Generic_HashSet_uint__TypeInfo);
		    System_Collections_Generic_HashSet_PropertyPath___get_Count
		              (uVar7,Method_System_Collections_Generic_HashSet_uint___ctor__);
		    local_4 = uVar7;
		    uVar7 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(undefined4 *)(param1 + 0x2c),
		                       Method_System_Collections_Generic_Dictionary_uint__HashSet_uint___get_Values__
		                      );
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_2c,uVar7,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__HashSet_uint___GetEnumerator__
		              );
		    local_10 = local_24;
		    local_18 = CONCAT44(ppiStack_28,local_2c);
		    local_2c = 0;
		    ppiStack_28 = (int **)&local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_18,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__HashSet_uint___MoveNext__
		                        );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e79014;
		      }
		      if (iVar8 == 0) goto code_r0x80e7906a;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd8,local_4,local_10._4_4_,
		                 Method_Sirenix_Utilities_LinqExtensions_AddRange_uint___);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar2 != 1);
		    uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e79014:
		    iVar2 = global_1;
		    iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 == iVar8) {
		      piVar9 = (int *)import::env::__cxa_begin_catch(uVar7);
		      iVar8 = *piVar9;
		      DAT_ram_009d3e38 = 0;
		      local_2c = iVar8;
		      import::env::invoke_v(0x123);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        if (iVar8 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        goto code_r0x80e7906a;
		      }
		      uVar7 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd9,&local_2c);
		  }
		  else {
		code_r0x80e7906a:
		    uVar1 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IEnumerable_CollectionListElement_CollectionListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e790db;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IEnumerable_CollectionListElement_CollectionListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80e790db:
		    local_1c = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    local_2c = 0;
		    ppiStack_28 = &local_1c;
		code_r0x80e79149:
		    piVar9 = local_1c;
		    iVar2 = *local_1c;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar4 = (undefined4 *)(iVar2 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80e791e2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_1c,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e79471:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e79479;
		    }
		code_r0x80e791e2:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    piVar9 = local_1c;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e79471;
		    if (iVar2 == 0) {
		      iVar2 = 0;
		      goto code_r0x80e794c2;
		    }
		    iVar2 = *local_1c;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_CollectionListElement_CollectionListElementArgs__TypeInfo
		            == *piVar11) {
		          puVar4 = (undefined4 *)(iVar2 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x80e792c5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_1c,
		                        System_Collections_Generic_IEnumerator_CollectionListElement_CollectionListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e7937e:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e79479;
		    }
		code_r0x80e792c5:
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(*puVar4,piVar9,puVar4[1]);
		    uVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e7937e;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = System_Linq_Enumerable__FirstOrDefault_uint_(*(undefined4 *)(iVar2 + 0xc),0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e79479;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3bc,uVar7,uVar5,
		                       Method_System_Collections_Generic_HashSet_uint__Contains__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		      if (iVar6 != 0) {
		        uVar5 = *(undefined4 *)(param1 + 0x20);
		        DAT_ram_009d3e38 = 0;
		        uVar7 = System_Linq_Enumerable__FirstOrDefault_uint_(*(undefined4 *)(iVar2 + 0xc),0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e79479;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar5,uVar7,
		                           Method_System_Collections_Generic_Dictionary_uint__CollectionData__get_Item__
		                          );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e79479;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xda,uVar7,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e79479;
		        }
		        iVar10 = iVar8 + iVar10;
		      }
		      goto code_r0x80e79149;
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e79479:
		    iVar2 = global_1;
		    iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 == iVar8) {
		      piVar9 = (int *)import::env::__cxa_begin_catch(uVar7);
		      iVar2 = *piVar9;
		      DAT_ram_009d3e38 = 0;
		      local_2c = iVar2;
		      import::env::invoke_v(0x123);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		code_r0x80e794c2:
		        piVar9 = local_1c;
		        DAT_ram_009d3e38 = 0;
		        if (local_1c != (int *)0x0) {
		          uVar1 = 0;
		          iVar8 = *local_1c;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		                puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x80e7953a;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		          }
		          puVar3 = (uint *)func_ii_1080(local_1c,System_IDisposable_TypeInfo,0);
		code_r0x80e7953a:
		          (**(code **)((ulonglong)*puVar3 * 4))(piVar9,puVar3[1]);
		        }
		        if (iVar2 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        return iVar10;
		      }
		      uVar7 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xdb,&local_2c);
		  }
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0U;
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x8B1D", Offset = "0x8B1D", VA = "0x8B1D")]
		public int GetAcquiredCollectionsWhitMaxLevelCount(IList<CollectionListElement.CollectionListElementArgs> collectionsList, uint categoryId)
		{
		/* --- GHIDRA: GetAcquiredCollectionsWhitMaxLevelCount ---
		void Gameplay_Collections_Model_CollectionsModel__GetAcquiredCollectionsWhitMaxLevelCount
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param2_00;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a57ebf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_CollectionListElement_CollectionListElementArgs__uint___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderBy_CollectionListElement_CollectionListElementArgs__uint___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_CollectionListElement_CollectionListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_CollectionListElement_CollectionListElementArgs__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Model_CollectionsModel___c__SortCollections_b__33_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Model_CollectionsModel___c__SortCollections_b__33_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		    DAT_ram_00a57ebf = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Keys__
		                    );
		  iVar2 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_uint___);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(param1 + 0x1c);
		      param2_00 = *(undefined4 *)(iVar2 + iVar6 * 4 + 0x10);
		      uVar1 = System_Collections_Generic_List_object___get_Item
		                        (param1_00,param2_00,
		                         Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Item__
		                        );
		      if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		      }
		      puVar3 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		      iVar4 = puVar3[4];
		      if (iVar4 == 0) {
		        if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		          puVar3 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c)
		          ;
		        }
		        uVar5 = *puVar3;
		        iVar4 = unnamed_function_1417
		                          (
		                          System_Func_CollectionListElement_CollectionListElementArgs__uint__TypeInfo
		                          );
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar4,uVar5,
		                   Method_Gameplay_Collections_Model_CollectionsModel___c__SortCollections_b__33_0__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c) + 0x10) =
		             iVar4;
		      }
		      uVar1 = System_Linq_Enumerable__OrderBy___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                        (uVar1,iVar4,
		                         Method_System_Linq_Enumerable_OrderByDescending_CollectionListElement_CollectionListElementArgs__uint___
		                        );
		      if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		      }
		      puVar3 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c);
		      iVar4 = puVar3[5];
		      if (iVar4 == 0) {
		        if (*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo);
		          puVar3 = *(undefined4 **)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c)
		          ;
		        }
		        uVar5 = *puVar3;
		        iVar4 = unnamed_function_1417
		                          (
		                          System_Func_CollectionListElement_CollectionListElementArgs__uint__TypeInfo
		                          );
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar4,uVar5,
		                   Method_Gameplay_Collections_Model_CollectionsModel___c__SortCollections_b__33_1__
		                   ,0);
		        *(int *)(*(int *)(Gameplay_Collections_Model_CollectionsModel___c_TypeInfo + 0x5c) + 0x14) =
		             iVar4;
		      }
		      uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                        (uVar1,iVar4,
		                         Method_System_Linq_Enumerable_OrderBy_CollectionListElement_CollectionListElementArgs__uint___
		                        );
		      uVar1 = System_Linq_Enumerable__Select_object__object_
		                        (uVar1,
		                         Method_System_Linq_Enumerable_ToList_CollectionListElement_CollectionListElementArgs___
		                        );
		      System_Collections_Generic_Dictionary_uint__object___get_Item
		                (param1_00,param2_00,uVar1,
		                 Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___set_Item__
		                );
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C51")]
		[Address(RVA = "0x8B1E", Offset = "0x8B1E", VA = "0x8B1E")]
		private void SortCollections()
		{
		/* --- GHIDRA: SortCollections ---
		int Gameplay_Collections_Model_CollectionsModel__SortCollections
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int param1_00;
		  int iVar10;
		  int iVar11;
		  int iVar12;
		  uint uVar13;
		  int iVar14;
		  int iVar15;
		  undefined4 uVar16;
		  int param2_00;
		  undefined4 uVar17;
		  int *piVar18;
		  undefined4 local_4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57ec0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_MedalInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CollectionsModel_CollectionMaterial__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CollectionsModel_CollectionMaterial___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_CollectionsModel_CollectionMaterial__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Model_CollectionsModel___c__DisplayClass34_0__GetMaterials_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel___c__DisplayClass34_0_TypeInfo);
		    DAT_ram_00a57ec0 = '\x01';
		  }
		  local_4 = 0;
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x160);
		        goto code_r0x80e7970e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e7970e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  iVar9 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit(uVar3,param2,0);
		  param1_00 = *(int *)(iVar9 + 0x14);
		  iVar9 = unnamed_function_1417
		                    (System_Collections_Generic_List_CollectionsModel_CollectionMaterial__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar9,
		             Method_System_Collections_Generic_List_CollectionsModel_CollectionMaterial___ctor__);
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar10 = *piVar8;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x130);
		        goto code_r0x80e797b6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e797b6:
		  iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  iVar11 = *(int *)(param1_00 + 0xc);
		  if (0 < iVar11) {
		    iVar10 = *(int *)(iVar10 + 0x14);
		    do {
		      iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		      iVar12 = *(int *)(iVar4 + 0xc);
		      if (iVar12 == 0xc) {
		        uVar1 = 0;
		        iVar12 = *(int *)(*(int *)(iVar4 + 0x10) + 0xc);
		        if (0 < iVar12) {
		          do {
		            uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(iVar4 + 0x10),uVar1,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            piVar8 = *(int **)(param1 + 0x10);
		            iVar14 = *piVar8;
		            if (*(ushort *)(iVar14 + 0xb6) != 0) {
		              uVar13 = 0;
		              do {
		                piVar18 = (int *)(*(int *)(iVar14 + 0x58) + uVar13 * 8);
		                if (Core_Gameplay_IGame_TypeInfo == *piVar18) {
		                  puVar2 = (uint *)(piVar18[1] * 8 + iVar14 + 0x120);
		                  goto code_r0x80e79894;
		                }
		                uVar13 = uVar13 + 1;
		              } while (*(ushort *)(iVar14 + 0xb6) != uVar13);
		            }
		            puVar2 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e79894:
		            iVar14 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		            uVar6 = Core_Gameplay_Managers_Skins_SkinManager__PlanePackage
		                              (*(undefined4 *)(iVar14 + 0x10),uVar3,0);
		            uVar16 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                               (*(undefined4 *)(iVar4 + 0x10),uVar1 | 1,
		                                Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            uVar17 = Core_Data_Skills_SkillData___ctor
		                               (*(undefined4 *)(param1 + 0x30),uVar3,
		                                Method_System_Collections_Generic_HashSet_uint__Contains__);
		            uVar3 = func_ii_7944(uVar3,*(undefined4 *)(param1 + 0xc),0);
		            iVar5 = unnamed_function_1417
		                              (Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo)
		            ;
		            *(char *)(iVar5 + 0x14) = (char)uVar17;
		            *(undefined4 *)(iVar5 + 0xc) = uVar16;
		            *(undefined4 *)(iVar5 + 8) = uVar6;
		            *(undefined4 *)(iVar5 + 0x10) = uVar3;
		            iVar14 = 
		            Method_System_Collections_Generic_List_CollectionsModel_CollectionMaterial__Add__;
		            *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		            uVar13 = *(uint *)(iVar9 + 0xc);
		            if (uVar13 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		              *(uint *)(iVar9 + 0xc) = uVar13 + 1;
		              *(int *)(*(int *)(iVar9 + 8) + uVar13 * 4 + 0x10) = iVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar9,iVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		            }
		            uVar1 = uVar1 + 2;
		          } while ((int)uVar1 < iVar12);
		          iVar12 = *(int *)(iVar4 + 0xc);
		          goto code_r0x80e79985;
		        }
		      }
		      else {
		code_r0x80e79985:
		        if (iVar12 == 0x6e) {
		          iVar12 = 0;
		          iVar14 = *(int *)(*(int *)(iVar4 + 0x10) + 0xc);
		          if (0 < iVar14) {
		            do {
		              iVar5 = unnamed_function_1417
		                                (
		                                Gameplay_Collections_Model_CollectionsModel___c__DisplayClass34_0_TypeInfo
		                                );
		              uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                                (*(undefined4 *)(iVar4 + 0x10),iVar12,
		                                 Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		              *(undefined4 *)(iVar5 + 8) = uVar3;
		              piVar8 = *(int **)(param1 + 0xc);
		              iVar15 = *piVar8;
		              if (*(ushort *)(iVar15 + 0xb6) != 0) {
		                uVar1 = 0;
		                do {
		                  piVar18 = (int *)(*(int *)(iVar15 + 0x58) + uVar1 * 8);
		                  if (Core_Dict_IDictProvider_TypeInfo == *piVar18) {
		                    puVar2 = (uint *)(piVar18[1] * 8 + iVar15 + 0xd8);
		                    goto code_r0x80e79a31;
		                  }
		                  uVar1 = uVar1 + 1;
		                } while (*(ushort *)(iVar15 + 0xb6) != uVar1);
		              }
		              puVar2 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,3);
		code_r0x80e79a31:
		              iVar15 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		              iVar15 = func_ii_7730(*(undefined4 *)(iVar15 + 0xc),*(undefined4 *)(iVar5 + 8),
		                                    Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_MedalDicWrapper__uint__GetWrapper__
		                                   );
		              if (iVar15 != 0) {
		                uVar16 = *(undefined4 *)(iVar15 + 0x10);
		                uVar17 = *(undefined4 *)(param1 + 0xc);
		                uVar3 = func_ii_6965(*(undefined4 *)(param1 + 8),0);
		                uVar6 = Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_object__uint___GetWrapper
		                                  (*(undefined4 *)(param1 + 8),0);
		                iVar7 = Core_Extensions_Dict_MedalDicExt__GetDescription
		                                  (uVar16,uVar17,uVar3,uVar6,&local_4,0);
		                if (iVar7 == 0) {
		                  iVar7 = unnamed_function_1417
		                                    (
		                                    Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo
		                                    );
		                  *(int *)(iVar7 + 0xc) = iVar15;
		                  uVar3 = System_Collections_Generic_List_object___get_Item
		                                    (*(undefined4 *)(iVar10 + 0x20),*(undefined4 *)(iVar5 + 8),
		                                     Method_System_Collections_Generic_Dictionary_uint__MedalData__get_Item__
		                                    );
		                  *(undefined4 *)(iVar7 + 8) = uVar3;
		                  iVar5 = 
		                  Method_System_Collections_Generic_List_CollectionsModel_CollectionMaterial__Add__;
		                  *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		                  uVar1 = *(uint *)(iVar9 + 0xc);
		                  if (uVar1 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		                    *(uint *)(iVar9 + 0xc) = uVar1 + 1;
		                    *(int *)(*(int *)(iVar9 + 8) + uVar1 * 4 + 0x10) = iVar7;
		                  }
		                  else {
		                    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                              (iVar9,iVar7,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		                  }
		                }
		                else {
		                  uVar6 = *(undefined4 *)(*(int *)(param1 + 8) + 0x40);
		                  uVar3 = unnamed_function_1417(System_Func_MedalInfo__bool__TypeInfo);
		                  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                            (uVar3,iVar5,
		                             Method_Gameplay_Collections_Model_CollectionsModel___c__DisplayClass34_0__GetMaterials_b__0__
		                             ,0);
		                  uVar3 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                                    (uVar6,uVar3,Method_System_Linq_Enumerable_Any_MedalInfo___);
		                  iVar5 = unnamed_function_1417
		                                    (
		                                    Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo
		                                    );
		                  *(undefined4 *)(iVar5 + 8) = local_4;
		                  iVar7 = *(int *)(iVar15 + 0x10);
		                  uVar6 = *(undefined4 *)(iVar7 + 0x24);
		                  *(char *)(iVar5 + 0x14) = (char)uVar3;
		                  *(undefined4 *)(iVar5 + 0x10) = uVar6;
		                  if (*(int *)(iVar7 + 0x34) != 0) {
		                    if (DAT_ram_00a57eb4 == '\0') {
		                      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		                      DAT_ram_00a57eb4 = '\x01';
		                    }
		                    piVar8 = *(int **)(param1 + 0xc);
		                    iVar7 = *piVar8;
		                    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		                      uVar1 = 0;
		                      do {
		                        piVar18 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		                        if (Core_Dict_IDictProvider_TypeInfo == *piVar18) {
		                          puVar2 = (uint *)(piVar18[1] * 8 + iVar7 + 0xd0);
		                          goto code_r0x80e79b84;
		                        }
		                        uVar1 = uVar1 + 1;
		                      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		                    }
		                    puVar2 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e79b84:
		                    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		                    uVar3 = Core_Extensions_Dict_DictExt__GetEventTagDic
		                                      (uVar3,*(undefined4 *)(*(int *)(iVar15 + 0x10) + 0x38),0);
		                    *(undefined4 *)(iVar5 + 0xc) = uVar3;
		                  }
		                  iVar15 = 
		                  Method_System_Collections_Generic_List_CollectionsModel_CollectionMaterial__Add__;
		                  *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		                  uVar1 = *(uint *)(iVar9 + 0xc);
		                  if (uVar1 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		                    *(uint *)(iVar9 + 0xc) = uVar1 + 1;
		                    *(int *)(*(int *)(iVar9 + 8) + uVar1 * 4 + 0x10) = iVar5;
		                  }
		                  else {
		                    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                              (iVar9,iVar5,
		                               *(undefined4 *)(*(int *)(*(int *)(iVar15 + 0x10) + 0x60) + 0x38));
		                  }
		                }
		              }
		              iVar12 = iVar12 + 1;
		            } while (iVar12 != iVar14);
		          }
		        }
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar11);
		  }
		  return iVar9;
		}
		*/

		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C52")]
		[Address(RVA = "0x8B1F", Offset = "0x8B1F", VA = "0x8B1F")]
		public List<CollectionsModel.CollectionMaterial> GetMaterials(uint requirementId)
		{
		/* --- GHIDRA: GetMaterials ---
		float Gameplay_Collections_Model_CollectionsModel__GetMaterials
		                (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  uint uVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  undefined4 param1_00;
		  int iVar14;
		  float fVar15;
		  double dVar16;
		  double dVar17;
		  int iVar18;
		  longlong lVar19;
		  int *piVar20;
		  uint uVar21;
		  longlong lVar22;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  iVar14 = 0;
		  dVar16 = 0.0;
		  dVar17 = 0.0;
		  if (DAT_ram_00a57ec1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_MedalInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Model_CollectionsModel___c__DisplayClass35_0__GetProgress_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel___c__DisplayClass35_0_TypeInfo);
		    DAT_ram_00a57ec1 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar21 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar21 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar21 * 8 + 4) * 8 + iVar9 + 0x160);
		        goto code_r0x80e786d4;
		      }
		      uVar21 = uVar21 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar21);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e786d4:
		  fVar15 = 1.0;
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		  iVar9 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit(uVar2,param2,0);
		  iVar9 = *(int *)(iVar9 + 0x14);
		  iVar10 = *(int *)(iVar9 + 0xc);
		  if (0 < iVar10) {
		    do {
		      iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar9,iVar14,
		                         Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		      iVar11 = *(int *)(*(int *)(iVar3 + 0x10) + 0xc);
		      iVar12 = *(int *)(iVar3 + 0xc);
		      if (iVar12 == 0xc) {
		        uVar21 = 0;
		        if (0 < iVar11) {
		          do {
		            uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(iVar3 + 0x10),uVar21,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            piVar8 = *(int **)(param1 + 0x10);
		            iVar12 = *piVar8;
		            if (*(ushort *)(iVar12 + 0xb6) != 0) {
		              uVar4 = 0;
		              do {
		                piVar20 = (int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8);
		                if (Core_Gameplay_IGame_TypeInfo == *piVar20) {
		                  puVar1 = (uint *)(piVar20[1] * 8 + iVar12 + 0x120);
		                  goto code_r0x80e787c3;
		                }
		                uVar4 = uVar4 + 1;
		              } while (*(ushort *)(iVar12 + 0xb6) != uVar4);
		            }
		            puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e787c3:
		            iVar12 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		            uVar4 = Core_Gameplay_Managers_Skins_SkinManager__PlanePackage
		                              (*(undefined4 *)(iVar12 + 0x10),uVar2,0);
		            uVar5 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(iVar3 + 0x10),uVar21 | 1,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            if (uVar5 <= uVar4) {
		              uVar4 = uVar5;
		            }
		            dVar17 = dVar17 + (double)uVar4;
		            dVar16 = dVar16 + (double)uVar5;
		            uVar21 = uVar21 + 2;
		          } while ((int)uVar21 < iVar11);
		          iVar12 = *(int *)(iVar3 + 0xc);
		          goto code_r0x80e78823;
		        }
		      }
		      else {
		code_r0x80e78823:
		        if ((iVar12 == 0x6e) && (iVar12 = 0, 0 < iVar11)) {
		          do {
		            iVar6 = unnamed_function_1417
		                              (
		                              Gameplay_Collections_Model_CollectionsModel___c__DisplayClass35_0_TypeInfo
		                              );
		            uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(iVar3 + 0x10),iVar12,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            *(undefined4 *)(iVar6 + 8) = uVar2;
		            if (DAT_ram_00a57eb4 == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		              DAT_ram_00a57eb4 = '\x01';
		            }
		            piVar8 = *(int **)(param1 + 0xc);
		            iVar13 = *piVar8;
		            if (*(ushort *)(iVar13 + 0xb6) != 0) {
		              uVar21 = 0;
		              do {
		                piVar20 = (int *)(*(int *)(iVar13 + 0x58) + uVar21 * 8);
		                if (Core_Dict_IDictProvider_TypeInfo == *piVar20) {
		                  puVar1 = (uint *)(piVar20[1] * 8 + iVar13 + 0xd0);
		                  goto code_r0x80e788e5;
		                }
		                uVar21 = uVar21 + 1;
		              } while (*(ushort *)(iVar13 + 0xb6) != uVar21);
		            }
		            puVar1 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e788e5:
		            uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		            iVar13 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                               (uVar2,*(undefined4 *)(iVar6 + 8),0);
		            if (iVar13 != 0) {
		              param1_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x40);
		              uVar2 = unnamed_function_1417(System_Func_MedalInfo__bool__TypeInfo);
		              System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                        (uVar2,iVar6,
		                         Method_Gameplay_Collections_Model_CollectionsModel___c__DisplayClass35_0__GetProgress_b__0__
		                         ,0);
		              iVar6 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                                (param1_00,uVar2,Method_System_Linq_Enumerable_Any_MedalInfo___);
		              local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                         (*(undefined4 *)(iVar13 + 0x2c),
		                                          Method_Google_Protobuf_Collections_RepeatedField_RestrictionInfo__GetEnumerator__
		                                         );
		              local_10 = 0;
		              local_c = &local_4;
		              while( true ) {
		                piVar8 = local_4;
		                iVar13 = *local_4;
		                if (*(ushort *)(iVar13 + 0xb6) != 0) {
		                  uVar21 = 0;
		                  do {
		                    piVar20 = (int *)(*(int *)(iVar13 + 0x58) + uVar21 * 8);
		                    if (System_Collections_IEnumerator_TypeInfo == *piVar20) {
		                      puVar7 = (undefined4 *)(iVar13 + piVar20[1] * 8 + 0xc0);
		                      goto code_r0x80e78a07;
		                    }
		                    uVar21 = uVar21 + 1;
		                  } while (*(ushort *)(iVar13 + 0xb6) != uVar21);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar7 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                                    System_Collections_IEnumerator_TypeInfo,0);
		                if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e78a07:
		                DAT_ram_009d3e38 = 0;
		                iVar13 = import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		                piVar8 = local_4;
		                if (DAT_ram_009d3e38 == 1) break;
		                if (iVar13 == 0) {
		                  iVar13 = 0xb;
		                  iVar6 = 0;
		                  goto code_r0x80e78c3a;
		                }
		                iVar13 = *local_4;
		                if (*(ushort *)(iVar13 + 0xb6) != 0) {
		                  uVar21 = 0;
		                  do {
		                    piVar20 = (int *)(*(int *)(iVar13 + 0x58) + uVar21 * 8);
		                    if (System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo == *piVar20
		                       ) {
		                      puVar7 = (undefined4 *)(iVar13 + piVar20[1] * 8 + 0xc0);
		                      goto code_r0x80e78ae1;
		                    }
		                    uVar21 = uVar21 + 1;
		                  } while (*(ushort *)(iVar13 + 0xb6) != uVar21);
		                }
		                DAT_ram_009d3e38 = 0;
		                puVar7 = (undefined4 *)
		                         import::env::invoke_iiii
		                                   (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                                    System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo
		                                    ,0);
		                if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e78ae1:
		                DAT_ram_009d3e38 = 0;
		                iVar13 = import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		                if (DAT_ram_009d3e38 == 1) break;
		                DAT_ram_009d3e38 = 0;
		                piVar8 = (int *)import::env::invoke_iii
		                                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x43,
		                                           *(undefined4 *)(param1 + 8),0);
		                if (DAT_ram_009d3e38 == 1) break;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_iiiii
		                          (*(undefined4 *)(*piVar8 + 0x100),piVar8,*(undefined4 *)(iVar13 + 0xc),
		                           &local_8,*(undefined4 *)(*piVar8 + 0x104));
		                if (DAT_ram_009d3e38 == 1) break;
		                lVar19 = *(longlong *)(iVar13 + 0x10);
		                dVar16 = dVar16 + (double)lVar19;
		                lVar22 = *(longlong *)(local_8 + 0x10);
		                if (lVar19 <= *(longlong *)(local_8 + 0x10)) {
		                  lVar22 = lVar19;
		                }
		                if (iVar6 == 0) {
		                  lVar19 = lVar22;
		                }
		                dVar17 = dVar17 + (double)lVar19;
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              iVar6 = global_1;
		              iVar13 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		              if (iVar6 != iVar13) {
		code_r0x80e78cd7:
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_ii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd7,&local_10);
		                iVar14 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar14 == 1) {
		                  import::env::__cxa_find_matching_catch_3(0);
		                  unnamed_function_937();
		                  do {
		                    halt_trap();
		                  } while( true );
		                }
		                import::env::__resumeException(uVar2);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              piVar8 = (int *)import::env::__cxa_begin_catch(uVar2);
		              iVar6 = *piVar8;
		              iVar13 = 0;
		              DAT_ram_009d3e38 = 0;
		              local_10 = iVar6;
		              import::env::invoke_v(0x123);
		              iVar18 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar18 == 1) {
		                uVar2 = import::env::__cxa_find_matching_catch_2();
		                goto code_r0x80e78cd7;
		              }
		code_r0x80e78c3a:
		              piVar8 = local_4;
		              DAT_ram_009d3e38 = 0;
		              if (local_4 != (int *)0x0) {
		                iVar18 = *local_4;
		                if (*(ushort *)(iVar18 + 0xb6) != 0) {
		                  uVar21 = 0;
		                  do {
		                    piVar20 = (int *)(*(int *)(iVar18 + 0x58) + uVar21 * 8);
		                    if (System_IDisposable_TypeInfo == *piVar20) {
		                      puVar1 = (uint *)(iVar18 + piVar20[1] * 8 + 0xc0);
		                      goto code_r0x80e78cae;
		                    }
		                    uVar21 = uVar21 + 1;
		                  } while (*(ushort *)(iVar18 + 0xb6) != uVar21);
		                }
		                puVar1 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e78cae:
		                (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		              }
		              if (iVar6 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              if (iVar13 != 0) {
		                if (iVar13 == 1) {
		                  return 1.0;
		                }
		                if (iVar13 == 2) {
		                  return 1.0;
		                }
		                if (iVar13 == 3) {
		                  return 1.0;
		                }
		                if (iVar13 == 4) {
		                  return 1.0;
		                }
		                if (iVar13 == 5) {
		                  return 1.0;
		                }
		                if (iVar13 == 6) {
		                  return 1.0;
		                }
		                if (iVar13 == 7) {
		                  return 1.0;
		                }
		                if (iVar13 == 8) {
		                  return 1.0;
		                }
		                if (iVar13 == 9) {
		                  return 1.0;
		                }
		                if (iVar13 == 10) {
		                  return 1.0;
		                }
		                if (iVar13 != 0xb) {
		                  return 1.0;
		                }
		              }
		            }
		            iVar12 = iVar12 + 1;
		          } while (iVar12 != iVar11);
		        }
		      }
		      iVar14 = iVar14 + 1;
		    } while (iVar14 != iVar10);
		    if (dVar16 != 0.0) {
		      fVar15 = (float)(dVar17 / dVar16);
		    }
		  }
		  return fVar15;
		}
		*/

			return null;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x8B20", Offset = "0x8B20", VA = "0x8B20")]
		public float GetProgress(uint requirementId)
		{
		/* --- GHIDRA: GetProgress ---
		void Gameplay_Collections_Model_CollectionsModel__GetProgress
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 param1_01;
		  float fVar3;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57ec2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_CollectionListElement_CollectionListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_CollectionListElement_CollectionListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Model_CollectionsModel___c__DisplayClass36_0__RecalculateCollectionProgress_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel___c__DisplayClass36_0_TypeInfo);
		    DAT_ram_00a57ec2 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Collections_Model_CollectionsModel___c__DisplayClass36_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  iVar2 = System_Xml_XsdCachingReader__get_Name(param2,0);
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0x10),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___TryGetValue__
		                    );
		  param1_00 = local_4;
		  if (iVar2 != 0) {
		    param1_01 = unnamed_function_1417
		                          (
		                          System_Func_CollectionListElement_CollectionListElementArgs__bool__TypeInfo
		                          );
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_01,iVar1,
		               Method_Gameplay_Collections_Model_CollectionsModel___c__DisplayClass36_0__RecalculateCollectionProgress_b__0__
		               ,0);
		    iVar2 = System_Func_object__bool____ctor
		                      (param1_00,param1_01,
		                       Method_System_Linq_Enumerable_FirstOrDefault_CollectionListElement_CollectionListElementArgs___
		                      );
		    if (iVar2 != 0) {
		      iVar1 = Core_Data_CollectionData__get_NextMedalDic(*(undefined4 *)(iVar1 + 8),0);
		      fVar3 = Gameplay_Collections_Model_CollectionsModel__GetMaterials
		                        (param1,*(undefined4 *)(iVar1 + 0x14),auStack_10);
		      *(float *)(iVar2 + 0x1c) = fVar3;
		      iVar1 = *(int *)(iVar2 + 0x20);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C54")]
		[Address(RVA = "0x8B21", Offset = "0x8B21", VA = "0x8B21")]
		public void RecalculateCollectionProgress(CollectionData data)
		{
		/* --- GHIDRA: RecalculateCollectionProgress ---
		undefined4
		Gameplay_Collections_Model_CollectionsModel__RecalculateCollectionProgress
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ec4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Item__
		              );
		    DAT_ram_00a57ec4 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___get_Item__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C55")]
		[Address(RVA = "0x1C5B", Offset = "0x1C5B", VA = "0x1C5B")]
		public CollectionListElement.CollectionListElementArgs ConstructArgs(CollectionsDic dic)
		{
			return null;
		}

		// Token: 0x0400214E RID: 8526
		[Token(Token = "0x400214E")]
		[FieldOffset(Offset = "0x14")]
		public readonly UserData LoggedUser;

		// Token: 0x0400214F RID: 8527
		[Token(Token = "0x400214F")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool SameUser;

		// Token: 0x04002150 RID: 8528
		[Token(Token = "0x4002150")]
		[FieldOffset(Offset = "0x1C")]
		public readonly Dictionary<uint, List<CollectionListElement.CollectionListElementArgs>> CollectionsByCategoryId;

		// Token: 0x04002151 RID: 8529
		[Token(Token = "0x4002151")]
		[FieldOffset(Offset = "0x20")]
		public readonly Dictionary<uint, CollectionData> CollectionsById;

		// Token: 0x04002152 RID: 8530
		[Token(Token = "0x4002152")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, uint> _acquiredCollectionsRanksById;

		// Token: 0x04002153 RID: 8531
		[Token(Token = "0x4002153")]
		[FieldOffset(Offset = "0x28")]
		private List<CollectionListElement.CollectionListElementArgs> _allElements;

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[FieldOffset(Offset = "0x2C")]
		private readonly Dictionary<uint, HashSet<uint>> _acquiredCollectionIdsByCategoryId;

		// Token: 0x04002155 RID: 8533
		[Token(Token = "0x4002155")]
		[FieldOffset(Offset = "0x30")]
		public readonly HashSet<uint> MarketArtikuls;

		// Token: 0x020009D8 RID: 2520
		[Token(Token = "0x20009D8")]
		public enum CollectionMaterialType
		{
			// Token: 0x04002158 RID: 8536
			[Token(Token = "0x4002158")]
			UNKNOWN_MATERIAL,
			// Token: 0x04002159 RID: 8537
			[Token(Token = "0x4002159")]
			ARTIKUL,
			// Token: 0x0400215A RID: 8538
			[Token(Token = "0x400215A")]
			MEDAL,
			// Token: 0x0400215B RID: 8539
			[Token(Token = "0x400215B")]
			APR
		}

		// Token: 0x020009D9 RID: 2521
		[Token(Token = "0x20009D9")]
		public abstract class CollectionMaterial
		{
			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x06003C57 RID: 15447
			[Token(Token = "0x17000BE3")]
			public abstract CollectionsModel.CollectionMaterialType RewardType { [Token(Token = "0x6003C57")] get; }

			// Token: 0x06003C58 RID: 15448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C58")]
			[Address(RVA = "0x8B23", Offset = "0x8B23", VA = "0x8B23")]
			protected CollectionMaterial()
			{
			}
		}

		// Token: 0x020009DA RID: 2522
		[Token(Token = "0x20009DA")]
		public class ArtikulMaterial : CollectionsModel.CollectionMaterial
		{
			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
			[Token(Token = "0x17000BE4")]
			public override CollectionsModel.CollectionMaterialType RewardType
			{
				[Token(Token = "0x6003C59")]
				[Address(RVA = "0x8B24", Offset = "0x8B24", VA = "0x8B24", Slot = "4")]
				get
				{
					return CollectionsModel.CollectionMaterialType.UNKNOWN_MATERIAL;
				}
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x06003C5A RID: 15450 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000BE5")]
			public string Text
			{
				[Token(Token = "0x6003C5A")]
				[Address(RVA = "0x8B25", Offset = "0x8B25", VA = "0x8B25")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x06003C5B RID: 15451 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000BE6")]
			public string TextAvailable
			{
				[Token(Token = "0x6003C5B")]
				[Address(RVA = "0x8B26", Offset = "0x8B26", VA = "0x8B26")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x06003C5C RID: 15452 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000BE7")]
			public string TextRequired
			{
				[Token(Token = "0x6003C5C")]
				[Address(RVA = "0x8B27", Offset = "0x8B27", VA = "0x8B27")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
			[Token(Token = "0x17000BE8")]
			public bool? IsValid
			{
				[Token(Token = "0x6003C5D")]
				[Address(RVA = "0x8B28", Offset = "0x8B28", VA = "0x8B28")]
				get
				{
					return null;
				}
			}

			// Token: 0x06003C5E RID: 15454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x8B29", Offset = "0x8B29", VA = "0x8B29")]
			public ArtikulMaterial()
			{
			}

			// Token: 0x0400215C RID: 8540
			[Token(Token = "0x400215C")]
			[FieldOffset(Offset = "0x8")]
			public uint Have;

			// Token: 0x0400215D RID: 8541
			[Token(Token = "0x400215D")]
			[FieldOffset(Offset = "0xC")]
			public uint Required;

			// Token: 0x0400215E RID: 8542
			[Token(Token = "0x400215E")]
			[FieldOffset(Offset = "0x10")]
			public ArtikulData Artikul;

			// Token: 0x0400215F RID: 8543
			[Token(Token = "0x400215F")]
			[FieldOffset(Offset = "0x14")]
			public bool IsOnMarket;
		}

		// Token: 0x020009DB RID: 2523
		[Token(Token = "0x20009DB")]
		public class MedalMaterial : CollectionsModel.CollectionMaterial
		{
			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
			[Token(Token = "0x17000BE9")]
			public override CollectionsModel.CollectionMaterialType RewardType
			{
				[Token(Token = "0x6003C5F")]
				[Address(RVA = "0x8B2A", Offset = "0x8B2A", VA = "0x8B2A", Slot = "4")]
				get
				{
					return CollectionsModel.CollectionMaterialType.UNKNOWN_MATERIAL;
				}
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x06003C60 RID: 15456 RVA: 0x0000C210 File Offset: 0x0000A410
			[Token(Token = "0x17000BEA")]
			public bool BuyableMedal
			{
				[Token(Token = "0x6003C60")]
				[Address(RVA = "0x8B2B", Offset = "0x8B2B", VA = "0x8B2B")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003C61 RID: 15457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C61")]
			[Address(RVA = "0x8B2C", Offset = "0x8B2C", VA = "0x8B2C")]
			public MedalMaterial()
			{
			}

			// Token: 0x04002160 RID: 8544
			[Token(Token = "0x4002160")]
			[FieldOffset(Offset = "0x8")]
			public MedalData MedalData;

			// Token: 0x04002161 RID: 8545
			[Token(Token = "0x4002161")]
			[FieldOffset(Offset = "0xC")]
			public MedalDicWrapper Medal;
		}

		// Token: 0x020009DC RID: 2524
		[Token(Token = "0x20009DC")]
		public class AprMaterial : CollectionsModel.CollectionMaterial
		{
			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x06003C62 RID: 15458 RVA: 0x0000C228 File Offset: 0x0000A428
			[Token(Token = "0x17000BEB")]
			public override CollectionsModel.CollectionMaterialType RewardType
			{
				[Token(Token = "0x6003C62")]
				[Address(RVA = "0x8B2D", Offset = "0x8B2D", VA = "0x8B2D", Slot = "4")]
				get
				{
					return CollectionsModel.CollectionMaterialType.UNKNOWN_MATERIAL;
				}
			}

			// Token: 0x06003C63 RID: 15459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C63")]
			[Address(RVA = "0x8B2E", Offset = "0x8B2E", VA = "0x8B2E")]
			public AprMaterial()
			{
			}

			// Token: 0x04002162 RID: 8546
			[Token(Token = "0x4002162")]
			[FieldOffset(Offset = "0x8")]
			public AprDicWrapper Apr;

			// Token: 0x04002163 RID: 8547
			[Token(Token = "0x4002163")]
			[FieldOffset(Offset = "0xC")]
			public CollectionRanksInfoDic CollectionRankInfoDic;

			// Token: 0x04002164 RID: 8548
			[Token(Token = "0x4002164")]
			[FieldOffset(Offset = "0x10")]
			public ResourceSet Price;

			// Token: 0x04002165 RID: 8549
			[Token(Token = "0x4002165")]
			[FieldOffset(Offset = "0x14")]
			public bool Achieved;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		undefined4 Gameplay_Collections_Model_CollectionsModel__set_Game(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57eb4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57eb4 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80e76f35;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e76f35:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: set_CollectionDataFactory ---
		void Gameplay_Collections_Model_CollectionsModel__set_CollectionDataFactory
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57eb5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__HashSet_uint___Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__uint__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___Clear__
		              );
		    DAT_ram_00a57eb5 = '\x01';
		  }
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined4 *)(param1 + 0x34) = 0;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_Dictionary_uint__List_CollectionListElement_CollectionListElementArgs___Clear__
		            );
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_Dictionary_uint__uint__Clear__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_Dictionary_uint__HashSet_uint___Clear__);
		  return;
		}
		*/

}
