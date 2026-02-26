using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Gameplay.AssetsPrefetch;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Prefetch
{
	// Token: 0x020011A3 RID: 4515
	[Token(Token = "0x20011A3")]
	public class TutorialAssetsPrefetchManager : AbstractPrefetchManager
	{
		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015DF")]
		public override string Name
		{
			[Token(Token = "0x6006B4B")]
			[Address(RVA = "0xB649", Offset = "0xB649", VA = "0xB649", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4C")]
		[Address(RVA = "0xB64A", Offset = "0xB64A", VA = "0xB64A")]
		public TutorialAssetsPrefetchManager(IGame game)
		{
		/* --- GHIDRA: <FetchRequired>b__3_1 ---
		void Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___FetchRequired_b__3_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a667 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo);
		    DAT_ram_00a5a667 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo);
		  **(undefined4 **)
		    (Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <FetchRequired>b__3_3 ---
		undefined4
		Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___FetchRequired_b__3_3
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a666 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a666 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8124cc10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124cc10:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetIcon128AssetId(param2,0);
		  uVar3 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar3,param2_00,0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: <FetchRequired>b__3_0 ---
		undefined4
		Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___FetchRequired_b__3_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a665 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a665 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8124cac5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124cac5:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8124cb4a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124cb4a:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (uVar4,*(undefined4 *)(param2 + 0xc),0);
		  uVar4 = UI_Wiki_WikiUriRouter__SetData(uVar4,0);
		  uVar3 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar3,uVar4,0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___ctor
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int param1_00;
		  int param1_01;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  uint uVar12;
		  undefined4 *puVar13;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a662 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_AudioAssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_ProtoGetUserIsleInfoAns_Types_IsleInformation___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_CultDic__AssetDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_RegistrationAprsDic__AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_UISoundEffect__AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_AssetDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_CultDic__AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RegistrationAprsDic__AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_AssetDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_UISoundEffect__AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchRequired_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchRequired_b__3_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchRequired_b__3_3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c__FetchRequired_b__3_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask___TypeInfo);
		    DAT_ram_00a5a662 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar12 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x8124bf7a;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8124bf7a:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x20);
		  uVar12 = 0;
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar12 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8124c002;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c002:
		  uVar12 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar8 = *(undefined4 *)(iVar6 + 0x2a0);
		  uVar4 = unnamed_function_1417(System_Func_UISoundEffect__AssetDic__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar4,param1,
		             Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchRequired_b__3_0__
		             ,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar8,uVar4,Method_System_Linq_Enumerable_Select_UISoundEffect__AssetDic___);
		  uVar4 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_AssetDic___);
		  iVar6 = unnamed_function_1417(Gameplay_AssetsPrefetch_AudioAssetsPrefetch_TypeInfo);
		  Sirenix_OdinInspector_LabelTextAttribute___ctor(iVar6,uVar7,uVar4,0);
		  param1_00 = unnamed_function_1417(Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(param1_00,0);
		  param1_01 = unnamed_function_1417(Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(param1_01,0);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar9 = *piVar5;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0x1a0);
		        goto code_r0x8124c107;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x8124c107:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar12 = 0;
		  iVar9 = *piVar5;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0xd8);
		        goto code_r0x8124c189;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,3);
		code_r0x8124c189:
		  iVar9 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar9 = *(int *)(iVar9 + 0x38);
		  uVar12 = 0;
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar10 = *piVar5;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x8124c20d;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c20d:
		  uVar12 = 0;
		  uVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar10 = *piVar5;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x8124c298;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c298:
		  uVar12 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar10 = *piVar5;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + iVar10 + 0x1a0);
		        goto code_r0x8124c323;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x8124c323:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar12 = 0;
		  iVar10 = *piVar5;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + iVar10 + 0xe0);
		        goto code_r0x8124c3a3;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,4);
		code_r0x8124c3a3:
		  uVar12 = 0;
		  uVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar10 = System_Linq_Enumerable__Count_object_
		                     (uVar8,
		                      Method_System_Linq_Enumerable_First_ProtoGetUserIsleInfoAns_Types_IsleInformation___
		                     );
		  iVar10 = Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		                     (uVar4,*(undefined4 *)(*(int *)(iVar10 + 0x24) + 0xc),0);
		  uVar7 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (uVar7,*(undefined4 *)(iVar10 + 0x10),0);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar10 = *piVar5;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar12 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x8124c44d;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c44d:
		  uVar12 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar10 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar8 = *(undefined4 *)(iVar10 + 0x1c0);
		  uVar4 = unnamed_function_1417(System_Func_RegistrationAprsDic__AssetDic__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar4,param1,
		             Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchRequired_b__3_3__
		             ,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar8,uVar4,
		                     Method_System_Linq_Enumerable_Select_RegistrationAprsDic__AssetDic___);
		  iVar10 = unnamed_function_1417(System_Collections_Generic_List_AssetDic__TypeInfo);
		  Sirenix_Utilities_LinqExtensions__Convert_object_
		            (iVar10,uVar4,Method_System_Collections_Generic_List_AssetDic___ctor__);
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar11 = *piVar5;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar12 * 8 + 4) * 8 + iVar11 + 0x178);
		        goto code_r0x8124c525;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c525:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar8 = Core_Extensions_Dict_AprDicExt__Get256AssetId(*(undefined4 *)(iVar9 + 0x10),0);
		  uVar4 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar4,uVar8,0);
		  iVar9 = Method_System_Collections_Generic_List_AssetDic__Add__;
		  *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		  uVar12 = *(uint *)(iVar10 + 0xc);
		  if (uVar12 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		    *(uint *)(iVar10 + 0xc) = uVar12 + 1;
		    *(undefined4 *)(*(int *)(iVar10 + 8) + uVar12 * 4 + 0x10) = uVar4;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar10,uVar4,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  }
		  uVar12 = 0;
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar9 = *piVar5;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x8124c615;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c615:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = Core_Extensions_Dict_AprDicExt__Get256AssetId(uVar7,0);
		  uVar7 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar4,uVar7,0);
		  iVar9 = Method_System_Collections_Generic_List_AssetDic__Add__;
		  *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		  uVar12 = *(uint *)(iVar10 + 0xc);
		  if (uVar12 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		    *(uint *)(iVar10 + 0xc) = uVar12 + 1;
		    *(undefined4 *)(*(int *)(iVar10 + 8) + uVar12 * 4 + 0x10) = uVar7;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar10,uVar7,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  }
		  uVar12 = 0;
		  uVar7 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (iVar10,Method_System_Collections_Generic_List_AssetDic__ToArray__);
		  UnityEngine_JsonUtility__FromJson_PreloaderBackgroundLoader_PreloaderBackgroundDto_
		            (&local_8,param1_00,uVar7,0);
		  uVar1 = local_8;
		  piVar5 = *(int **)(param1 + 0x18);
		  iVar9 = *piVar5;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar12 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x8124c723;
		      }
		      uVar12 = uVar12 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar12);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124c723:
		  uVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  iVar9 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  uVar4 = *(undefined4 *)(iVar9 + 0x30);
		  uVar7 = unnamed_function_1417(System_Func_CultDic__AssetDic__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar7,param1,
		             Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchRequired_b__3_1__
		             ,0);
		  uVar7 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,uVar7,Method_System_Linq_Enumerable_Select_CultDic__AssetDic___);
		  if (*(int *)(Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo + 0x74) ==
		      0) {
		    func_ii_306000(Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo);
		  }
		  puVar13 = *(undefined4 **)
		             (Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo + 0x5c);
		  iVar9 = puVar13[1];
		  if (iVar9 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo + 0x74)
		        == 0) {
		      func_ii_306000(Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo);
		      puVar13 = *(undefined4 **)
		                 (Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar4 = *puVar13;
		    iVar9 = unnamed_function_1417(System_Func_AssetDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar9,uVar4,
		               Method_Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c__FetchRequired_b__3_2__
		               ,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager___c_TypeInfo +
		                     0x5c) + 4) = iVar9;
		  }
		  uVar7 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar7,iVar9,Method_System_Linq_Enumerable_Where_AssetDic___);
		  uVar7 = func_ii_6295(uVar7,Method_System_Linq_Enumerable_ToArray_AssetDic___);
		  UnityEngine_JsonUtility__FromJson_PreloaderBackgroundLoader_PreloaderBackgroundDto_
		            (&local_8,param1_01,uVar7,0);
		  uVar2 = local_8;
		  Gameplay_AssetsPrefetch_AudioAssetsPrefetch___ctor(&local_8,iVar6,0);
		  piVar5 = (int *)Mono_Security_ASN1Convert__ToOid(System_IDisposable___TypeInfo,3);
		  if ((iVar6 != 0) && (iVar9 = func_ii_1082(iVar6,*(undefined4 *)(*piVar5 + 0x20)), iVar9 == 0)) {
		    uVar7 = func_ii_1083();
		    func_ii_1050(uVar7,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar5[4] = iVar6;
		  if ((param1_00 != 0) &&
		     (iVar6 = func_ii_1082(param1_00,*(undefined4 *)(*piVar5 + 0x20)), iVar6 == 0)) {
		    uVar7 = func_ii_1083();
		    func_ii_1050(uVar7,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar5[5] = param1_00;
		  if ((param1_01 != 0) &&
		     (iVar6 = func_ii_1082(param1_01,*(undefined4 *)(*piVar5 + 0x20)), iVar6 == 0)) {
		    uVar7 = func_ii_1083();
		    func_ii_1050(uVar7,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar5[6] = param1_01;
		  *param2 = (int)piVar5;
		  iVar6 = Mono_Security_ASN1Convert__ToOid(Cysharp_Threading_Tasks_UniTask___TypeInfo,3);
		  *(undefined8 *)(iVar6 + 0x20) = uVar2;
		  *(undefined8 *)(iVar6 + 0x18) = uVar1;
		  *(undefined8 *)(iVar6 + 0x10) = local_8;
		  *param3 = iVar6;
		  return;
		}
		*/

		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4D")]
		[Address(RVA = "0xB64B", Offset = "0xB64B", VA = "0xB64B", Slot = "12")]
		protected override void FetchRequired(out IList<IDisposable> fetchers, out UniTask[] tasks)
		{
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4E")]
		[Address(RVA = "0xB64C", Offset = "0xB64C", VA = "0xB64C", Slot = "13")]
		protected override void PostFetchRequired(AssetsPrefetch[] fetchers)
		{
		/* --- GHIDRA: PostFetchRequired ---
		void Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__PostFetchRequired
		               (undefined4 param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a663 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_IDisposable___);
		    DAT_ram_00a5a663 = '\x01';
		  }
		  iVar2 = Method_System_Array_Empty_IDisposable___;
		  iVar1 = *(int *)(Method_System_Array_Empty_IDisposable___ + 0x1c);
		  if (iVar1 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_IDisposable___);
		    iVar1 = *(int *)(iVar2 + 0x1c);
		  }
		  iVar1 = *(int *)(iVar1 + 8);
		  if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		    iVar1 = func_ii_1079(iVar1);
		  }
		  if (*(int *)(iVar1 + 0x74) == 0) {
		    func_ii_306000(iVar1);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x1c) + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  *param2 = **(undefined4 **)(iVar2 + 0x5c);
		  return;
		}
		*/

		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0xB64D", Offset = "0xB64D", VA = "0xB64D", Slot = "14")]
		protected override void FetchOptionalAssets(out IList<IDisposable> fetchers)
		{
		/* --- GHIDRA: FetchOptionalAssets ---
		undefined4
		Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__FetchOptionalAssets
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a664 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a664 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8124ca13;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124ca13:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                    (uVar3,*(undefined4 *)(param2 + 0x10),0);
		  return uVar3;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__get_Name
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Gameplay_Managers_Prefetch_AbstractPrefetchManager__set_Game(param1,param2,param2);
		  return;
		}
		*/

}
