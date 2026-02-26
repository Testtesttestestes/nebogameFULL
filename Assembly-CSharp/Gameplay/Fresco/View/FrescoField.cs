using System;
using System.Collections.Generic;
using AssetContent.Loaders;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Fresco;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	public class FrescoField : GameRawImageLoader
	{
		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x1700095C")]
		public ulong FrescoId
		{
			[Token(Token = "0x6002FBE")]
			[Address(RVA = "0x8024", Offset = "0x8024", VA = "0x8024")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x8025", Offset = "0x8025", VA = "0x8025")]
		public void Test()
		{
		/* --- GHIDRA: Test ---
		void Gameplay_Fresco_View_FrescoField__Test(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5755f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_FrescoSpriteSelectorSO_SpriteSelectorElement__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_FrescoSpriteSelectorSO_SpriteSelectorElement__get_Item__
		              );
		    DAT_ram_00a5755f = '\x01';
		  }
		  iVar1 = 1;
		  iVar2 = 1;
		  iVar4 = *(int *)(*(int *)(param1 + 0x34) + 0xc);
		  uVar3 = UnityEngine_Random__Range(0,*(undefined4 *)(iVar4 + 0xc),0);
		  iVar4 = System_Linq_Enumerable__ToList_object_
		                    (iVar4,uVar3,
		                     Method_System_Collections_Generic_List_FrescoSpriteSelectorSO_SpriteSelectorElement__get_Item__
		                    );
		  iVar5 = *(int *)(iVar4 + 8);
		  if (iVar5 < 2) {
		    iVar2 = *(int *)(iVar4 + 0x10);
		  }
		  iVar6 = *(int *)(iVar4 + 0xc);
		  if (iVar6 < 2) {
		    iVar1 = *(int *)(iVar4 + 0x10);
		  }
		  uVar3 = Gameplay_Fresco_View_FrescoField__SetNativeHeight
		                    (param1,*(undefined4 *)(param1 + 0x38),param1);
		  iVar2 = iVar2 * iVar5;
		  iVar1 = iVar1 * iVar6;
		  Gameplay_Fresco_View_FrescoField__Init(param1,uVar3,iVar2,iVar1,param1);
		  *(ulonglong *)(param1 + 0x3c) = CONCAT44(iVar1,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x8026", Offset = "0x8026", VA = "0x8026")]
		public void RandomField()
		{
		/* --- GHIDRA: RandomField ---
		void Gameplay_Fresco_View_FrescoField__RandomField(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint param3_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 param2_00;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57560 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FrescoFragment__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FrescoFragment__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_FrescoFragment__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FrescoFragment__GetEnumerator__);
		    DAT_ram_00a57560 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(undefined4 *)(param1 + 0x48) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x44),
		             Method_System_Collections_Generic_List_FrescoFragment__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FrescoFragment__MoveNext__)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80da9379;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x48);
		    iVar1 = local_8._4_4_;
		    if (DAT_ram_00a57572 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&UnityEngine_Object_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a57572 = '\x01';
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x274,*(undefined4 *)(iVar1 + 0x14)
		               ,uVar3,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    param2_00 = *(undefined4 *)(iVar1 + 0x14);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x268,uVar3,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    param3_00 = 0;
		    if (iVar2 != 0) {
		      param3_00 = (uint)(*(int *)(iVar1 + 0x24) != 0);
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x269,param2_00,param3_00,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80da9379:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
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
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30a,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar3);
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

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x8027", Offset = "0x8027", VA = "0x8027", Slot = "11")]
		public override void SetAsset(Texture2D asset)
		{
		/* --- GHIDRA: SetAsset ---
		void Gameplay_Fresco_View_FrescoField__SetAsset
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a57561 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a57561 = '\x01';
		  }
		  *(int *)(param1 + 0x50) = param3;
		  *(undefined4 *)(param1 + 0x4c) = param2;
		  if (param3 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = *(int *)(param3 + 0x24);
		    param2_00 = Core_Extensions_Dict_FrescoDicExt__GetImage(param3,0);
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1,param2_00,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  Gameplay_Fresco_View_FrescoField__Init
		            (param1,*(undefined4 *)(param1 + 0x48),*(undefined4 *)(iVar1 + 0xc),
		             *(undefined4 *)(iVar1 + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x8028", Offset = "0x8028", VA = "0x8028")]
		public void Init(Protocol.Fresco.Fresco fresco, Protocol.Dic.Fresco.Types.FrescoDic frescoDic)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Fresco_View_FrescoField__Init
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  undefined4 uVar3;
		  int iVar4;
		  int param2_01;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  float fVar9;
		  float fVar10;
		  int iVar11;
		  uint uVar12;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a57562 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FrescoFragment__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_Cell___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_FrescoCell___);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoCell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_Cell__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoFragment__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_FrescoSpriteSelectorSO_SpriteSelectorElement__Find__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_FrescoFragment___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Predicate_FrescoSpriteSelectorSO_SpriteSelectorElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_FrescoField___c__DisplayClass17_0__SetGrid_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_FrescoField___c__DisplayClass17_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_FrescoField___c__DisplayClass17_1__SetGrid_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_View_FrescoField___c__DisplayClass17_1__SetGrid_b__2__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_FrescoField___c__DisplayClass17_1_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4603);
		    DAT_ram_00a57562 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_Fresco_View_FrescoField___c__DisplayClass17_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = param4;
		  Gameplay_Fresco_View_FrescoField__ValidateSize(param1,param4);
		  uVar5 = *(undefined4 *)(param1[0xd] + 0xc);
		  uVar3 = unnamed_function_1417
		                    (System_Predicate_FrescoSpriteSelectorSO_SpriteSelectorElement__TypeInfo);
		  func_ii_7297(uVar3,param2_00,
		               Method_Gameplay_Fresco_View_FrescoField___c__DisplayClass17_0__SetGrid_b__0__,0);
		  iVar4 = System_Collections_Generic_List_UsageHint___Exists
		                    (uVar5,uVar3,
		                     Method_System_Collections_Generic_List_FrescoSpriteSelectorSO_SpriteSelectorElement__Find__
		                    );
		  if (iVar4 == 0) {
		    local_10 = *(float4 *)(param2_00 + 0xc);
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_10);
		    local_14 = *(undefined4 *)(param2_00 + 8);
		    uVar5 = func_ii_1081(DAT_ram_00a66954,&local_14);
		    uVar3 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_4603,uVar3,uVar5,0);
		    if (*(int *)(UnityEngine_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Debug_TypeInfo);
		    }
		    Unity_Collections_NativeArray_ContactPairHeader___AsReadOnly(uVar3,0);
		  }
		  else {
		    func_ii_7050(param1[0xc],*(undefined4 *)(iVar4 + 0x20),0);
		    func_ii_7050(param1[0xb],*(undefined4 *)(iVar4 + 0x1c),0);
		    fVar9 = 0.0;
		    if (1 < *(int *)(param1[0x13] + 0x1c) - 5U) {
		      fVar9 = 1.0;
		    }
		    func_ii_9125(param1[0xb],fVar9,0.0,0);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		              (param1,*(undefined4 *)(param2_00 + 0xc),*(undefined4 *)(param2_00 + 8),iVar4,
		               *(undefined4 *)(*param1 + 0x13c));
		    iVar6 = *(int *)(param2_00 + 0xc);
		    iVar7 = *(int *)(param2_00 + 8);
		    param2_01 = unnamed_function_1417
		                          (Gameplay_Fresco_View_FrescoField___c__DisplayClass17_1_TypeInfo);
		    *(undefined4 *)(param2_01 + 8) = 0;
		    iVar8 = iVar7 * iVar6;
		    if (0 < iVar8) {
		      fVar9 = 1.0 / (float)iVar7;
		      fVar10 = 1.0 / (float)iVar6;
		      do {
		        iVar6 = param1[9];
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (param1[10],0);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar6 = func_ii_6805(iVar6,uVar3,Method_UnityEngine_Object_Instantiate_FrescoFragment___);
		        if (DAT_ram_00a57572 == '\0') {
		          Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		          DAT_ram_00a57572 = '\x01';
		        }
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		                  (*(undefined4 *)(iVar6 + 0x14),param2,0);
		        uVar3 = *(undefined4 *)(iVar6 + 0x14);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar7 = UnityEngine_Component__GetComponent_object_(param2,0);
		        if (iVar7 == 0) {
		          uVar12 = 0;
		        }
		        else {
		          uVar12 = (uint)(*(int *)(iVar6 + 0x24) != 0);
		        }
		        UnityEngine_Object__op_Implicit(uVar3,uVar12,0);
		        uVar3 = *(undefined4 *)(iVar4 + 0x24);
		        if (DAT_ram_00a57574 == '\0') {
		          Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		          DAT_ram_00a57574 = '\x01';
		        }
		        func_ii_7050(*(undefined4 *)(iVar6 + 0x10),uVar3,0);
		        uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar6 + 0x10),0);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        uVar1 = 0;
		        uVar3 = UnityEngine_Component__GetComponent_object_(uVar3,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar5,uVar3,0);
		        iVar11 = param1[0x13];
		        iVar7 = iVar11;
		        if (iVar11 == 0) {
		          iVar7 = iVar2;
		        }
		        iVar2 = iVar7;
		        uVar3 = 0;
		        if (iVar11 != 0) {
		          uVar5 = *(undefined4 *)(iVar2 + 0x18);
		          uVar3 = unnamed_function_1417(System_Func_FrescoCell__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (uVar3,param2_01,
		                     Method_Gameplay_Fresco_View_FrescoField___c__DisplayClass17_1__SetGrid_b__1__,0
		                    );
		          uVar3 = System_Func_object__bool____ctor
		                            (uVar5,uVar3,Method_System_Linq_Enumerable_FirstOrDefault_FrescoCell___)
		          ;
		        }
		        if (param1[0x14] != 0) {
		          uVar1 = *(undefined4 *)(param1[0x14] + 0x34);
		          uVar5 = unnamed_function_1417(System_Func_Fresco_Types_Cell__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (uVar5,param2_01,
		                     Method_Gameplay_Fresco_View_FrescoField___c__DisplayClass17_1__SetGrid_b__2__,0
		                    );
		          uVar1 = System_Func_object__bool____ctor
		                            (uVar1,uVar5,
		                             Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_Cell___);
		        }
		        uVar5 = unnamed_function_1417(System_Action_FrescoFragment__TypeInfo);
		        UnityEngine_UIElements_VisualElement__get_layout
		                  (uVar5,param1,*(undefined4 *)(*param1 + 0x134),0);
		        Gameplay_Fresco_View_FrescoFragment__OnDestroy(iVar6,uVar3,uVar1,uVar5,iVar6);
		        iVar7 = *(int *)(param2_00 + 0xc);
		        local_10 = (float4)((float)((int)*(uint *)(param2_01 + 8) % iVar7) / (float)iVar7);
		        local_c = (float4)((float)((int)(iVar8 + (*(uint *)(param2_01 + 8) ^ 0xffffffff)) / iVar7) /
		                          (float)*(int *)(param2_00 + 8));
		        local_20 = CONCAT44(fVar9,fVar10);
		        local_28 = CONCAT44(local_c,local_10);
		        local_8 = (float4)fVar10;
		        local_4 = (float4)fVar9;
		        UnityEngine_UI_RawImage__get_uvRect(*(undefined4 *)(iVar6 + 0x14),&local_28,0);
		        iVar7 = Method_System_Collections_Generic_List_FrescoFragment__Add__;
		        iVar11 = param1[0x11];
		        *(int *)(iVar11 + 0x10) = *(int *)(iVar11 + 0x10) + 1;
		        uVar12 = *(uint *)(iVar11 + 0xc);
		        if (uVar12 < *(uint *)(*(int *)(iVar11 + 8) + 0xc)) {
		          *(uint *)(iVar11 + 0xc) = uVar12 + 1;
		          *(int *)(*(int *)(iVar11 + 8) + uVar12 * 4 + 0x10) = iVar6;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar11,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		        }
		        iVar6 = *(int *)(param2_01 + 8) + 1;
		        *(int *)(param2_01 + 8) = iVar6;
		      } while (iVar6 < iVar8);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x8029", Offset = "0x8029", VA = "0x8029")]
		public void SetGrid(Texture2D texture, int sizeX, int sizeY)
		{
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x802A", Offset = "0x802A", VA = "0x802A", Slot = "14")]
		public virtual void ClickHandler(FrescoFragment frescoFragment)
		{
		/* --- GHIDRA: ClickHandler ---
		void Gameplay_Fresco_View_FrescoField__ClickHandler
		               (int param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  undefined4 param3_00;
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  param3_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x28),0);
		  Gameplay_Fresco_View_FrescoField__ClearField
		            (&local_8,auStack_20,param3_00,(float)*(int *)(param4 + 0x18),auStack_20);
		  local_c = (float4)((float)local_4 / (float)param3);
		  local_10 = (float4)((float)local_8 / (float)param2);
		  local_18 = CONCAT44(local_c,local_10);
		  UnityEngine_UI_GridLayoutGroup__get_cellSize(*(undefined4 *)(param1 + 0x28),&local_18,0);
		  return;
		}
		*/

		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x802B", Offset = "0x802B", VA = "0x802B", Slot = "15")]
		protected virtual void ValidateSize(int sizeX, int sizeY, FrescoSpriteSelectorSO.SpriteSelectorElement spriteElement)
		{
		/* --- GHIDRA: ValidateSize ---
		void Gameplay_Fresco_View_FrescoField__ValidateSize(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param3;
		  
		  if (DAT_ram_00a57563 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoFragment__Clear__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57563 = '\x01';
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x28),0);
		  iVar3 = UnityEngine_Transform__InverseTransformPoint(uVar2,0);
		  iVar3 = iVar3 + -1;
		  if (-1 < iVar3) {
		    do {
		      uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x28),0);
		      uVar2 = UnityEngine_Transform__GetEnumerator(uVar2,iVar3,0);
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar2,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Object__Destroy(uVar2,0);
		      bVar1 = 0 < iVar3;
		      iVar3 = iVar3 + -1;
		    } while (bVar1);
		  }
		  iVar3 = *(int *)(param1 + 0x44);
		  param3 = *(int *)(iVar3 + 0xc);
		  *(undefined4 *)(iVar3 + 0xc) = 0;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar3 + 8),0,param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0x802C", Offset = "0x802C", VA = "0x802C")]
		private void ClearField()
		{
		/* --- GHIDRA: ClearField ---
		void Gameplay_Fresco_View_FrescoField__ClearField
		               (float4 *param1,undefined4 param2,int *param3,float param4,undefined4 param5)
		
		{
		  undefined8 local_20;
		  float4 local_18;
		  float4 local_14;
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  
		  if (DAT_ram_00a57564 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    DAT_ram_00a57564 = '\x01';
		  }
		  if (param3 == (int *)0x0) {
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,0,0);
		  }
		  else {
		    if (UnityEngine_RectTransform_TypeInfo != *param3) {
		      System_Activator__CreateInstance(param3,UnityEngine_RectTransform_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,param3,0);
		    if (UnityEngine_RectTransform_TypeInfo != *param3) {
		      System_Activator__CreateInstance(param3,UnityEngine_RectTransform_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  local_18 = local_8;
		  local_20 = CONCAT44(param4,local_8);
		  local_14 = (float4)param4;
		  UnityEngine_RectTransform__get_sizeDelta(param3,&local_20,0);
		  param1[1] = (float4)param4;
		  *param1 = local_8;
		  return;
		}
		*/

		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x802D", Offset = "0x802D", VA = "0x802D")]
		protected Vector2 SetNativeHeight(Transform target, float height)
		{
		/* --- GHIDRA: SetNativeHeight ---
		undefined4
		Gameplay_Fresco_View_FrescoField__SetNativeHeight
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int param3_00;
		  int param2_00;
		  int param3_01;
		  int param2_01;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a57565 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Texture2D_TypeInfo);
		    DAT_ram_00a57565 = '\x01';
		  }
		  UnityEngine_Sprite__get_bounds(&local_10,param2,0);
		  if (ABS((float)local_4) < 2.1474836e+09) {
		    param3_00 = (int)(float)local_4;
		  }
		  else {
		    param3_00 = -0x80000000;
		  }
		  if (ABS((float)local_8) < 2.1474836e+09) {
		    param2_00 = (int)(float)local_8;
		  }
		  else {
		    param2_00 = -0x80000000;
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Texture2D_TypeInfo);
		  UnityEngine_Sprite__get_textureRect(param1_00,param2_00,param3_00,0);
		  if (ABS((float)local_c) < 2.1474836e+09) {
		    param3_01 = (int)(float)local_c;
		  }
		  else {
		    param3_01 = -0x80000000;
		  }
		  if (ABS((float)local_10) < 2.1474836e+09) {
		    param2_01 = (int)(float)local_10;
		  }
		  else {
		    param2_01 = -0x80000000;
		  }
		  uVar1 = UnityEngine_UI_Image__get_activeSprite(param2,0);
		  uVar1 = UnityEngine_Object__set_name(uVar1,param2_01,param3_01,param2_00,param3_00,0);
		  UnityEngine_Texture2D__GetPixels(param1_00,uVar1,0);
		  UnityEngine_Texture2D__SetPixels(param1_00,0);
		  return param1_00;
		}
		*/

			return default(Vector2);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x802E", Offset = "0x802E", VA = "0x802E")]
		protected Texture2D GetTexture(Sprite sprite)
		{
			return null;
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x802F", Offset = "0x802F", VA = "0x802F")]
		public FrescoField()
		{
		}

		// Token: 0x04001A15 RID: 6677
		[Token(Token = "0x4001A15")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FrescoFragment _fragmentPrefab;

		// Token: 0x04001A16 RID: 6678
		[Token(Token = "0x4001A16")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _grid;

		// Token: 0x04001A17 RID: 6679
		[Token(Token = "0x4001A17")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Image _innerBorder;

		// Token: 0x04001A18 RID: 6680
		[Token(Token = "0x4001A18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Image _outerBorder;

		// Token: 0x04001A19 RID: 6681
		[Token(Token = "0x4001A19")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private FrescoSpriteSelectorSO _frescoSpriteSelectorSO;

		// Token: 0x04001A1A RID: 6682
		[Token(Token = "0x4001A1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Sprite _sprite;

		// Token: 0x04001A1B RID: 6683
		[Token(Token = "0x4001A1B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2Int _size;

		// Token: 0x04001A1C RID: 6684
		[Token(Token = "0x4001A1C")]
		[FieldOffset(Offset = "0x44")]
		protected readonly List<FrescoFragment> _fragments;

		// Token: 0x04001A1D RID: 6685
		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x48")]
		protected Texture2D _texture;

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x4C")]
		protected Protocol.Fresco.Fresco _fresco;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x50")]
		protected Protocol.Dic.Fresco.Types.FrescoDic _frescoDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_FrescoId ---
		void Gameplay_Fresco_View_FrescoField__get_FrescoId(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = Gameplay_Fresco_View_FrescoField__SetNativeHeight
		                        (param1,*(undefined4 *)(param1 + 0x38),param1);
		  Gameplay_Fresco_View_FrescoField__Init
		            (param1,param2_00,*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(param1 + 0x40),param1);
		  return;
		}
		*/

}
