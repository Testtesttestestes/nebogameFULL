using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Gameplay.AssetsPrefetch;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Prefetch
{
	// Token: 0x020011A1 RID: 4513
	[Token(Token = "0x20011A1")]
	public class AssetsPrefetchManager : AbstractPrefetchManager
	{
		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06006B3E RID: 27454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015DE")]
		public override string Name
		{
			[Token(Token = "0x6006B3E")]
			[Address(RVA = "0xB63C", Offset = "0xB63C", VA = "0xB63C", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B3F")]
		[Address(RVA = "0xB63D", Offset = "0xB63D", VA = "0xB63D")]
		public AssetsPrefetchManager(IGame game)
		{
		/* --- GHIDRA: <GetCultAssets>b__6_2 ---
		void Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___GetCultAssets_b__6_2(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a660 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		    DAT_ram_00a5a660 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <GetCultAssets>b__6_0 ---
		undefined4
		Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___GetCultAssets_b__6_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a65f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a65f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8124bd8e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124bd8e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                    (uVar3,*(undefined4 *)(param2 + 0x10),0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: <FetchRequired>b__3_0 ---
		undefined4
		Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___FetchRequired_b__3_0
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a65e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a65e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8124bcdc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124bcdc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                    (uVar3,*(undefined4 *)(param2 + 0x10),0);
		  return uVar3;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___ctor
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  undefined8 uVar3;
		  uint uVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int param1_00;
		  int param1_01;
		  int param1_02;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  undefined4 uVar11;
		  undefined4 param1_03;
		  int iVar12;
		  undefined8 uVar13;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a659 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_AssetDic___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__FetchRequired_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_AudioAssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_UISoundEffect__AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_AssetDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_UISoundEffect__AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__ToArray__);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTask_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_UserAssetsPrefetch_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15025);
		    DAT_ram_00a5a659 = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = unnamed_function_1417(Gameplay_AssetsPrefetch_UserAssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_PreloaderFetcher__Fetch_d__8__SetStateMachine(iVar5,0);
		  piVar9 = *(int **)(param1 + 0x18);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar4 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar4 * 8 + 4) * 8 + iVar10 + 0x158);
		        goto code_r0x8124af60;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar4);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8124af60:
		  iVar10 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		  uVar11 = *(undefined4 *)(iVar10 + 0x20);
		  uVar4 = 0;
		  piVar9 = *(int **)(param1 + 0x18);
		  iVar10 = *piVar9;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar4 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar4 * 8 + 4) * 8 + iVar10 + 0x178);
		        goto code_r0x8124afe8;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar4);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124afe8:
		  uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		  iVar10 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  param1_03 = *(undefined4 *)(iVar10 + 0x2a0);
		  uVar7 = unnamed_function_1417(System_Func_UISoundEffect__AssetDic__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar7,param1,
		             Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__FetchRequired_b__3_0__,0)
		  ;
		  uVar7 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_03,uVar7,Method_System_Linq_Enumerable_Select_UISoundEffect__AssetDic___
		                    );
		  uVar7 = func_ii_6295(uVar7,Method_System_Linq_Enumerable_ToArray_AssetDic___);
		  iVar10 = unnamed_function_1417(Gameplay_AssetsPrefetch_AudioAssetsPrefetch_TypeInfo);
		  Sirenix_OdinInspector_LabelTextAttribute___ctor(iVar10,uVar11,uVar7,0);
		  param1_00 = unnamed_function_1417(Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(param1_00,0);
		  param1_01 = unnamed_function_1417(Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(param1_01,0);
		  param1_02 = unnamed_function_1417(Gameplay_AssetsPrefetch_AssetsPrefetch_TypeInfo);
		  Gameplay_AssetsPrefetch_AssetsPrefetch__Warm(param1_02,0);
		  Gameplay_AssetsPrefetch_AudioAssetsPrefetch___ctor(&local_10,iVar10,0);
		  uVar1 = local_10;
		  uVar4 = 0;
		  uVar11 = Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__FetchOptionalAssets(param1,0);
		  uVar11 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                     (uVar11,Method_System_Collections_Generic_List_AssetDic__ToArray__);
		  UnityEngine_JsonUtility__FromJson_PreloaderBackgroundLoader_PreloaderBackgroundDto_
		            (&local_10,param1_00,uVar11,0);
		  uVar2 = local_10;
		  iVar8 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_AssetDic___TypeInfo,1);
		  piVar9 = *(int **)(param1 + 0x18);
		  iVar12 = *piVar9;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8 + 4) * 8 + iVar12 + 0x178);
		        goto code_r0x8124b142;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar4);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124b142:
		  uVar4 = 0;
		  uVar11 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		  piVar9 = *(int **)(param1 + 0x18);
		  iVar12 = *piVar9;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar4 * 8 + 4) * 8 + iVar12 + 0x178);
		        goto code_r0x8124b1c7;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar4);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124b1c7:
		  uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  uVar7 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar7,StringLiteral_15025,0);
		  uVar11 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar11,uVar7,0);
		  *(undefined4 *)(iVar8 + 0x10) = uVar11;
		  UnityEngine_JsonUtility__FromJson_PreloaderBackgroundLoader_PreloaderBackgroundDto_
		            (&local_10,param1_01,iVar8,0);
		  uVar3 = local_10;
		  if (*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Cysharp_Threading_Tasks_UniTask_TypeInfo);
		  }
		  uVar13 = *(undefined8 *)(*(int *)(Cysharp_Threading_Tasks_UniTask_TypeInfo + 0x5c) + 8);
		  piVar9 = *(int **)(param1 + 0x18);
		  iVar8 = *piVar9;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8 + 4) * 8 + iVar8 + 0x2b8);
		        goto code_r0x8124b2a9;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar4);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x3f);
		code_r0x8124b2a9:
		  uVar11 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		  iVar8 = Core_Gameplay_Managers_Skins_SkinManager__TryGetSkins(uVar11,&local_4,0);
		  if (iVar8 != 0) {
		    UnityEngine_JsonUtility__FromJson_PreloaderBackgroundLoader_PreloaderBackgroundDto_
		              (&local_10,param1_02,local_4,0);
		    uVar13 = local_10;
		  }
		  iVar8 = Mono_Security_ASN1Convert__ToOid(Cysharp_Threading_Tasks_UniTask___TypeInfo,4);
		  *(undefined8 *)(iVar8 + 0x28) = uVar13;
		  *(undefined8 *)(iVar8 + 0x20) = uVar3;
		  *(undefined8 *)(iVar8 + 0x18) = uVar2;
		  *(undefined8 *)(iVar8 + 0x10) = uVar1;
		  *param3 = iVar8;
		  piVar9 = (int *)Mono_Security_ASN1Convert__ToOid(System_IDisposable___TypeInfo,5);
		  if ((iVar5 != 0) && (iVar8 = func_ii_1082(iVar5,*(undefined4 *)(*piVar9 + 0x20)), iVar8 == 0)) {
		    uVar11 = func_ii_1083();
		    func_ii_1050(uVar11,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9[4] = iVar5;
		  if ((iVar10 != 0) && (iVar5 = func_ii_1082(iVar10,*(undefined4 *)(*piVar9 + 0x20)), iVar5 == 0)) {
		    uVar11 = func_ii_1083();
		    func_ii_1050(uVar11,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9[5] = iVar10;
		  if ((param1_00 != 0) &&
		     (iVar5 = func_ii_1082(param1_00,*(undefined4 *)(*piVar9 + 0x20)), iVar5 == 0)) {
		    uVar11 = func_ii_1083();
		    func_ii_1050(uVar11,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9[6] = param1_00;
		  if ((param1_01 != 0) &&
		     (iVar5 = func_ii_1082(param1_01,*(undefined4 *)(*piVar9 + 0x20)), iVar5 == 0)) {
		    uVar11 = func_ii_1083();
		    func_ii_1050(uVar11,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9[7] = param1_01;
		  if ((param1_02 != 0) &&
		     (iVar5 = func_ii_1082(param1_02,*(undefined4 *)(*piVar9 + 0x20)), iVar5 == 0)) {
		    uVar11 = func_ii_1083();
		    func_ii_1050(uVar11,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar9[8] = param1_02;
		  *param2 = (int)piVar9;
		  return;
		}
		*/

		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B40")]
		[Address(RVA = "0xB63E", Offset = "0xB63E", VA = "0xB63E", Slot = "12")]
		protected override void FetchRequired(out IList<IDisposable> fetchers, out UniTask[] tasks)
		{
		/* --- GHIDRA: FetchRequired ---
		void Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__FetchRequired
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5a65a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_AssetsPrefetch_TryGetContent_TMP_SpriteAsset___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TMP_SpriteAsset__AddRange__);
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_Settings_TypeInfo);
		    DAT_ram_00a5a65a = '\x01';
		  }
		  local_4 = 0;
		  if (0 < *(int *)(param2 + 0xc)) {
		    do {
		      iVar2 = Gameplay_AssetsPrefetch_AssetsPrefetch__GetContent_object_
		                        (*(undefined4 *)(param2 + iVar1 * 4 + 0x10),&local_4,
		                         Method_Gameplay_AssetsPrefetch_AssetsPrefetch_TryGetContent_TMP_SpriteAsset___
		                        );
		      if (iVar2 != 0) {
		        if (*(int *)(TMPro_TMP_Settings_TypeInfo + 0x74) == 0) {
		          func_ii_306000(TMPro_TMP_Settings_TypeInfo);
		        }
		        iVar1 = TMPro_TMP_Settings__get_hideSubTextObjects(0);
		        func_ii_6335(*(undefined4 *)(iVar1 + 0x94),local_4,
		                     Method_System_Collections_Generic_List_TMP_SpriteAsset__AddRange__);
		        return;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B41")]
		[Address(RVA = "0xB63F", Offset = "0xB63F", VA = "0xB63F", Slot = "13")]
		protected override void PostFetchRequired(AssetsPrefetch[] fetchers)
		{
		/* --- GHIDRA: PostFetchRequired ---
		void Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__PostFetchRequired
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param3_00;
		  undefined4 param4;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5a65b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_AssetsPrefetch_PreloaderFetcher_TypeInfo);
		    DAT_ram_00a5a65b = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x270);
		        goto code_r0x8124ba16;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x36);
		code_r0x8124ba16:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar6 = *(undefined4 *)(iVar5 + 0x10);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8124ba9e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124ba9e:
		  uVar1 = 0;
		  param3_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  piVar4 = *(int **)(param1 + 0x18);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8124bb23;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124bb23:
		  param4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = unnamed_function_1417(Gameplay_AssetsPrefetch_PreloaderFetcher_TypeInfo);
		  Gameplay_AssetsPrefetch_PreloaderFetcher__Dispose(iVar5,uVar6,param3_00,param4,0);
		  Gameplay_AssetsPrefetch_PreloaderFetcher___ctor(iVar5,0);
		  piVar4 = (int *)Mono_Security_ASN1Convert__ToOid(System_IDisposable___TypeInfo,1);
		  if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,*(undefined4 *)(*piVar4 + 0x20)), iVar3 == 0)) {
		    uVar6 = func_ii_1083();
		    func_ii_1050(uVar6,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar4[4] = iVar5;
		  *param2 = (int)piVar4;
		  return;
		}
		*/

		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B42")]
		[Address(RVA = "0xB640", Offset = "0xB640", VA = "0xB640", Slot = "14")]
		protected override void FetchOptionalAssets(out IList<IDisposable> fetchers)
		{
		/* --- GHIDRA: FetchOptionalAssets ---
		undefined4
		Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__FetchOptionalAssets
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  undefined4 *puVar9;
		  int *piVar10;
		  
		  iVar2 = 0;
		  iVar5 = 0;
		  if (DAT_ram_00a5a65c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__GetCultAssets_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__GetCultAssets_b__6_2__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanCults___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_ClanCults_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_Cults___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_Cults_var);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ContentResourceAsset__AssetDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_AssetDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_AssetDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ContentResourceAsset__AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AssetDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AssetDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c__GetCultAssets_b__6_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c__GetCultAssets_b__6_3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		    DAT_ram_00a5a65c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AssetDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AssetDic___ctor__);
		  uVar3 = Protocol_Consts_Cults_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar4 = System_Enum__GetUnderlyingType(uVar3,0);
		  uVar3 = Protocol_Consts_Cults___TypeInfo;
		  if ((iVar4 != 0) && (iVar2 = func_ii_1082(iVar4,Protocol_Consts_Cults___TypeInfo), iVar2 == 0)) {
		    System_Activator__CreateInstance(iVar4,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar5 * 4 + 0x10);
		      piVar8 = *(int **)(param1 + 0x18);
		      iVar4 = *piVar8;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		            puVar6 = (uint *)(piVar10[1] * 8 + iVar4 + 0x178);
		            goto code_r0x8124b59e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124b59e:
		      uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		      uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		      iVar4 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType(uVar7,uVar3,0);
		      if (iVar4 != 0) {
		        uVar7 = *(undefined4 *)(iVar4 + 0x18);
		        uVar3 = unnamed_function_1417(System_Func_ContentResourceAsset__AssetDic__TypeInfo);
		        System_Linq_Enumerable__Where_object_
		                  (uVar3,param1,
		                   Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__GetCultAssets_b__6_0__
		                   ,0);
		        uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                          (uVar7,uVar3,
		                           Method_System_Linq_Enumerable_Select_ContentResourceAsset__AssetDic___);
		        if (*(int *)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x74) == 0
		           ) {
		          func_ii_306000(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		        }
		        puVar9 = *(undefined4 **)
		                  (Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x5c);
		        iVar4 = puVar9[1];
		        if (iVar4 == 0) {
		          if (*(int *)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x74) ==
		              0) {
		            func_ii_306000(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		            puVar9 = *(undefined4 **)
		                      (Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x5c);
		          }
		          uVar7 = *puVar9;
		          iVar4 = unnamed_function_1417(System_Func_AssetDic__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (iVar4,uVar7,
		                     Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c__GetCultAssets_b__6_1__
		                     ,0);
		          *(int *)(*(int *)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo +
		                           0x5c) + 4) = iVar4;
		        }
		        uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                          (uVar3,iVar4,Method_System_Linq_Enumerable_Where_AssetDic___);
		        func_ii_6335(param1_00,uVar3,Method_System_Collections_Generic_List_AssetDic__AddRange__);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar2 + 0xc));
		  }
		  uVar3 = Protocol_Consts_ClanCults_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  iVar2 = 0;
		  iVar5 = System_Enum__GetUnderlyingType(uVar3,0);
		  uVar3 = Protocol_Consts_ClanCults___TypeInfo;
		  if ((iVar5 != 0) && (iVar2 = func_ii_1082(iVar5,Protocol_Consts_ClanCults___TypeInfo), iVar2 == 0)
		     ) {
		    System_Activator__CreateInstance(iVar5,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar5 = 0;
		    do {
		      uVar3 = *(undefined4 *)(iVar2 + iVar5 * 4 + 0x10);
		      piVar8 = *(int **)(param1 + 0x18);
		      iVar4 = *piVar8;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		            puVar6 = (uint *)(piVar10[1] * 8 + iVar4 + 0x178);
		            goto code_r0x8124b796;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124b796:
		      uVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar8,puVar6[1]);
		      uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		      iVar4 = Core_Extensions_Dict_DictExt__GetCult(uVar7,uVar3,0);
		      if (iVar4 != 0) {
		        uVar7 = *(undefined4 *)(iVar4 + 0x4c);
		        uVar3 = unnamed_function_1417(System_Func_ContentResourceAsset__AssetDic__TypeInfo);
		        System_Linq_Enumerable__Where_object_
		                  (uVar3,param1,
		                   Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__GetCultAssets_b__6_2__
		                   ,0);
		        uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                          (uVar7,uVar3,
		                           Method_System_Linq_Enumerable_Select_ContentResourceAsset__AssetDic___);
		        if (*(int *)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x74) == 0
		           ) {
		          func_ii_306000(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		        }
		        puVar9 = *(undefined4 **)
		                  (Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x5c);
		        iVar4 = puVar9[2];
		        if (iVar4 == 0) {
		          if (*(int *)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x74) ==
		              0) {
		            func_ii_306000(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo);
		            puVar9 = *(undefined4 **)
		                      (Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo + 0x5c);
		          }
		          uVar7 = *puVar9;
		          iVar4 = unnamed_function_1417(System_Func_AssetDic__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (iVar4,uVar7,
		                     Method_Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c__GetCultAssets_b__6_3__
		                     ,0);
		          *(int *)(*(int *)(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager___c_TypeInfo +
		                           0x5c) + 8) = iVar4;
		        }
		        uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                          (uVar3,iVar4,Method_System_Linq_Enumerable_Where_AssetDic___);
		        func_ii_6335(param1_00,uVar3,Method_System_Collections_Generic_List_AssetDic__AddRange__);
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar2 + 0xc));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B43")]
		[Address(RVA = "0xB641", Offset = "0xB641", VA = "0xB641")]
		private List<AssetDic> GetCultAssets()
		{
		/* --- GHIDRA: GetCultAssets ---
		undefined4
		Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager__GetCultAssets
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a65d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a65d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8124bc2a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8124bc2a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Core_Gameplay_Managers_DictManager__CheckSupportedService
		                    (uVar3,*(undefined4 *)(param2 + 0x10),0);
		  return uVar3;
		}
		*/

			return null;
		}
	}
}
