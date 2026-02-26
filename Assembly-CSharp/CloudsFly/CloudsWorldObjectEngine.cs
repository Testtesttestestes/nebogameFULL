using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace CloudsFly
{
	// Token: 0x02001300 RID: 4864
	[Token(Token = "0x2001300")]
	public class CloudsWorldObjectEngine : WorldObjectEngine<CloudWorldObjectEngineArgs>
	{
		// Token: 0x060073BD RID: 29629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0xBDA4", Offset = "0xBDA4", VA = "0xBDA4", Slot = "10")]
		protected override void OnInit(CloudWorldObjectEngineArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void CloudsFly_CloudsWorldObjectEngine__OnInit(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  float fVar3;
		  float fVar4;
		  undefined1 auStack_10 [4];
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  fVar2 = *(float *)(param1 + 0x3c);
		  fVar3 = *(float *)(param1 + 0x38);
		  fVar4 = *(float *)(param1 + 0x34);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 8),0);
		  func_ii_7888(&local_c,uVar1,0);
		  fVar4 = fVar4 - (float)local_c;
		  fVar3 = fVar3 - (float)local_8;
		  fVar2 = fVar2 - (float)local_4;
		  if (9.9999994e-11 <= fVar4 * fVar4 + fVar3 * fVar3 + fVar2 * fVar2) {
		    uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 8),0);
		    func_ii_7888(&local_c,uVar1,0);
		    *(float4 *)(param1 + 0x3c) = local_4;
		    *(ulonglong *)(param1 + 0x34) = CONCAT44(local_8,local_c);
		    CloudsFly_CloudsWorldObjectEngine__OnReleaseCloud(param1,auStack_10);
		    CloudsFly_CloudsWorldObjectEngine__OnResetPositions(param1,auStack_10);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060073BE RID: 29630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0xBDA5", Offset = "0xBDA5", VA = "0xBDA5", Slot = "8")]
		protected override void OnLateUpdate()
		{
		/* --- GHIDRA: OnLateUpdate ---
		void CloudsFly_CloudsWorldObjectEngine__OnLateUpdate(int param1,float *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  float fVar4;
		  float fVar5;
		  float fVar6;
		  undefined4 param2_00;
		  int iVar7;
		  undefined8 local_40;
		  float local_38;
		  float4 local_34;
		  float4 local_30;
		  float4 local_2c;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5968a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TiledCloudSpriteWorldObject__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TiledCloudSpriteWorldObject__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_TiledCloudSpriteWorldObject__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__GetEnumerator__)
		    ;
		    DAT_ram_00a5968a = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__GetEnumerator__);
		  local_28 = 0;
		  local_24 = &local_20;
		  fVar4 = param2[2];
		  fVar5 = param2[1];
		  fVar6 = *param2;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                       Method_System_Collections_Generic_List_Enumerator_TiledCloudSpriteWorldObject__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810499fb;
		    }
		    if (iVar1 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = local_18._4_4_;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,local_18._4_4_,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810499fb;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34a,&local_c,uVar2,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810499fb;
		    }
		    local_38 = (float)local_4 + fVar4;
		    local_30 = (float4)((float)local_8 + fVar5);
		    local_34 = (float4)((float)local_c + fVar6);
		    DAT_ram_009d3e38 = 0;
		    local_40 = CONCAT44(local_30,local_34);
		    local_2c = (float4)local_38;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34b,uVar2,&local_40,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    param2_00 = *(undefined4 *)(iVar1 + 0x28);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,iVar1,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34a,&local_c,uVar2,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    if (ABS(-(float)local_4) < 2.1474836e+09) {
		      iVar7 = (int)-(float)local_4;
		    }
		    else {
		      iVar7 = -0x80000000;
		    }
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x275,param2_00,iVar7,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810499fb:
		  iVar7 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar1 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34c,&local_28);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x060073BF RID: 29631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0xBDA6", Offset = "0xBDA6", VA = "0xBDA6", Slot = "9")]
		protected override void OnResetPositions(Vector3 deltaPos)
		{
		/* --- GHIDRA: OnResetPositions ---
		void CloudsFly_CloudsWorldObjectEngine__OnResetPositions(int param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined1 auStack_c [8];
		  float4 local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5968b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__ToArray__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Cache_ObjectPool_TiledCloudSpriteWorldObject__Release__);
		    DAT_ram_00a5968b = '\x01';
		  }
		  iVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(param1 + 0x2c),
		                     Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__ToArray__);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(iVar2 + iVar4 * 4 + 0x10);
		      uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1_00,0);
		      func_ii_7888(auStack_c,uVar3,0);
		      fVar1 = local_4;
		      uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 8),0);
		      func_ii_7888(auStack_c,uVar3,0);
		      if (*(float *)(*(int *)(param1 + 0x28) + 0x50) * -2.0 <= (float)fVar1 - (float)local_4) {
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param1_00,0);
		        func_ii_7888(auStack_c,uVar3,0);
		        fVar1 = local_4;
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (*(undefined4 *)(param1 + 8),0);
		        func_ii_7888(auStack_c,uVar3,0);
		        if (*(float *)(*(int *)(param1 + 0x28) + 0x14) < (float)fVar1 - (float)local_4)
		        goto code_r0x8104970c;
		      }
		      else {
		code_r0x8104970c:
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1_00,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,0,0);
		        UnityEngine_Object__op_Implicit(param1_00,0,0);
		        func_ii_7070(*(undefined4 *)(param1 + 0x30),param1_00,
		                     Method_Utils_Cache_ObjectPool_TiledCloudSpriteWorldObject__Release__);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0xBDA7", Offset = "0xBDA7", VA = "0xBDA7")]
		private void CloudsCheck()
		{
		/* --- GHIDRA: CloudsCheck ---
		void CloudsFly_CloudsWorldObjectEngine__CloudsCheck(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5968c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Contains__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Remove__);
		    DAT_ram_00a5968c = '\x01';
		  }
		  iVar1 = func_ii_4685(*(undefined4 *)(param1 + 0x2c),param2,
		                       Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Contains__
		                      );
		  if (iVar1 != 0) {
		    func_ii_4876(*(undefined4 *)(param1 + 0x2c),param2,
		                 Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Remove__);
		  }
		  CloudsFly_CloudsWorldObjectEngine__OnReleaseCloud(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0xBDA8", Offset = "0xBDA8", VA = "0xBDA8")]
		private void OnReleaseCloud(TiledCloudSpriteWorldObject tiledCloud)
		{
		/* --- GHIDRA: OnReleaseCloud ---
		void CloudsFly_CloudsWorldObjectEngine__OnReleaseCloud(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  float param2_00;
		  int iVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5968d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a5968d = '\x01';
		  }
		  if (DAT_ram_00a5968f == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsWorldObjectEngine__GetPositions_d__12_TypeInfo);
		    DAT_ram_00a5968f = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417
		                               (CloudsFly_CloudsWorldObjectEngine__GetPositions_d__12_TypeInfo);
		  param1_00[4] = param1;
		  param1_00[2] = 0;
		  do {
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar4 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar4) {
		          puVar2 = (uint *)(iVar3 + piVar4[1] * 8 + 0xc0);
		          goto code_r0x81049327;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_IEnumerator_TypeInfo,0);
		code_r0x81049327:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (iVar3 == 0) {
		      return;
		    }
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar4 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_float__TypeInfo == *piVar4) {
		          puVar2 = (uint *)(iVar3 + piVar4[1] * 8 + 0xc0);
		          goto code_r0x810493a3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IEnumerator_float__TypeInfo,0
		                                 );
		code_r0x810493a3:
		    param2_00 = (float)(**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    CloudsFly_CloudsWorldObjectEngine__SpawnClouds(param1,param2_00,puVar2);
		  } while( true );
		}
		*/

		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C2")]
		[Address(RVA = "0xBDA9", Offset = "0xBDA9", VA = "0xBDA9")]
		private void SpawnClouds()
		{
		/* --- GHIDRA: SpawnClouds ---
		void CloudsFly_CloudsWorldObjectEngine__SpawnClouds(int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param2_00;
		  undefined4 param4;
		  undefined4 param1_01;
		  undefined4 param1_02;
		  float fVar2;
		  float param6;
		  float param5;
		  float fVar3;
		  undefined8 local_28;
		  float local_20;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5968e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_float__float__float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_TiledCloudSpriteWorldObject__Get__);
		    Mono_Security_ASN1__get_Item(&CloudsFly_TiledSpriteCloudWorldObjectArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudsWorldObjectEngine___c__DisplayClass11_0__SpawnCloud_b__0__);
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsWorldObjectEngine___c__DisplayClass11_0_TypeInfo);
		    DAT_ram_00a5968e = '\x01';
		  }
		  iVar1 = unnamed_function_1417(CloudsFly_CloudsWorldObjectEngine___c__DisplayClass11_0_TypeInfo);
		  *(float *)(iVar1 + 0xc) = param2;
		  *(int *)(iVar1 + 8) = param1;
		  param1_00 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                        (*(undefined4 *)(param1 + 0x30),
		                         Method_Utils_Cache_ObjectPool_TiledCloudSpriteWorldObject__Get__);
		  do {
		    param2_00 = UnityEngine_Random__Range
		                          (0,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x4c) + 0xc),0);
		  } while (param2_00 == *(int *)(param1 + 0x40));
		  *(int *)(param1 + 0x40) = param2_00;
		  param4 = System_Linq_Enumerable__ToList_object_
		                     (*(undefined4 *)(*(int *)(param1 + 0x28) + 0x4c),param2_00,
		                      Method_System_Collections_Generic_List_Sprite__get_Item__);
		  fVar2 = *(float *)(iVar1 + 0xc);
		  func_ii_7888(&local_c,*(undefined4 *)(*(int *)(param1 + 0x28) + 0x44),0);
		  param1_01 = unnamed_function_1417(System_Func_float__float__float__TypeInfo);
		  System_Func_float__float__bool___Invoke
		            (param1_01,iVar1,
		             Method_CloudsFly_CloudsWorldObjectEngine___c__DisplayClass11_0__SpawnCloud_b__0__,0);
		  iVar1 = *(int *)(param1 + 0x28);
		  param6 = *(float *)(iVar1 + 0x50);
		  param5 = *(float *)(iVar1 + 0x14);
		  fVar3 = *(float *)(iVar1 + 0x1c);
		  param1_02 = unnamed_function_1417(CloudsFly_TiledSpriteCloudWorldObjectArgs_TypeInfo);
		  local_20 = fVar2 + (float)local_4;
		  local_14 = (float4)((float)local_8 + 0.0);
		  local_18 = (float4)((float)local_c + 0.0);
		  local_28 = CONCAT44(local_14,local_18);
		  local_10 = (float4)local_20;
		  CloudsFly_TiledCloudSpriteWorldObject___ctor
		            (param1_02,&local_28,param1_01,param4,param5,param6,fVar3 + fVar3,0);
		  UnityEngine_UIElements_CallbackEventHandler__HandleEventTrickleDownDisabled(param1_00,param1_02,0)
		  ;
		  CloudsFly_CloudsWorldObjectEngine__GetPositions(param1,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0xBDAA", Offset = "0xBDAA", VA = "0xBDAA")]
		private void SpawnCloud(float position)
		{
		/* --- GHIDRA: SpawnCloud ---
		int CloudsFly_CloudsWorldObjectEngine__SpawnCloud(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5968f == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsWorldObjectEngine__GetPositions_d__12_TypeInfo);
		    DAT_ram_00a5968f = '\x01';
		  }
		  iVar1 = unnamed_function_1417(CloudsFly_CloudsWorldObjectEngine__GetPositions_d__12_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0xBDAB", Offset = "0xBDAB", VA = "0xBDAB")]
		private IEnumerator<float> GetPositions()
		{
		/* --- GHIDRA: GetPositions ---
		void CloudsFly_CloudsWorldObjectEngine__GetPositions(int param1,undefined4 param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  undefined4 uVar2;
		  int param1_00;
		  uint uVar3;
		  int iVar4;
		  undefined1 auStack_c [8];
		  float4 local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a59690 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Insert__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__get_Item__);
		    DAT_ram_00a59690 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param2,0);
		  func_ii_7888(auStack_c,uVar2,0);
		  fVar1 = local_4;
		  param1_00 = *(int *)(param1 + 0x2c);
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (0 < (int)uVar3) {
		    do {
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,iVar4,
		                         Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__get_Item__
		                        );
		      uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (uVar2,0);
		      func_ii_7888(auStack_c,uVar2,0);
		      if ((float)fVar1 < (float)local_4) {
		        System_Collections_Generic_List_IntPtr___AddWithResize
		                  (*(undefined4 *)(param1 + 0x2c),iVar4,param2,
		                   Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Insert__);
		        return;
		      }
		      iVar4 = iVar4 + 1;
		      param1_00 = *(int *)(param1 + 0x2c);
		      uVar3 = *(uint *)(param1_00 + 0xc);
		    } while (iVar4 < (int)uVar3);
		  }
		  iVar4 = Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0xBDAC", Offset = "0xBDAC", VA = "0xBDAC")]
		private void AddUsedCloud(TiledCloudSpriteWorldObject tiledCloudSpriteControl)
		{
		/* --- GHIDRA: AddUsedCloud ---
		void CloudsFly_CloudsWorldObjectEngine__AddUsedCloud(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59691 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TiledCloudSpriteWorldObject__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_WorldObjectEngine_CloudWorldObjectEngineArgs___ctor__);
		    DAT_ram_00a59691 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_TiledCloudSpriteWorldObject__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TiledCloudSpriteWorldObject___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C6")]
		[Address(RVA = "0xBDAD", Offset = "0xBDAD", VA = "0xBDAD")]
		public CloudsWorldObjectEngine()
		{
		}

		// Token: 0x04003CA0 RID: 15520
		[Token(Token = "0x4003CA0")]
		[FieldOffset(Offset = "0x28")]
		private CloudWorldObjectEngineArgs _args;

		// Token: 0x04003CA1 RID: 15521
		[Token(Token = "0x4003CA1")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<TiledCloudSpriteWorldObject> usedTiledClouds;

		// Token: 0x04003CA2 RID: 15522
		[Token(Token = "0x4003CA2")]
		[FieldOffset(Offset = "0x30")]
		private GameObjectPool<TiledCloudSpriteWorldObject> tiledCloudsPool;

		// Token: 0x04003CA3 RID: 15523
		[Token(Token = "0x4003CA3")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _lastCameraPosition;

		// Token: 0x04003CA4 RID: 15524
		[Token(Token = "0x4003CA4")]
		[FieldOffset(Offset = "0x40")]
		private int _lastIndex;
	}
}
