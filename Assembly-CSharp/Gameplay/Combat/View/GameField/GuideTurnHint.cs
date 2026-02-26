using System;
using System.Collections.Generic;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using UI;
using UnityEngine;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000966 RID: 2406
	[Token(Token = "0x2000966")]
	public class GuideTurnHint : MonoBehaviour, IRectProvider, IOverrideGuideShapePointer, IOverrideGuideGraphicPointerAnimationState, IOverrideGuideGraphicPointerPosition
	{
		// Token: 0x06003930 RID: 14640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003930")]
		[Address(RVA = "0x88C5", Offset = "0x88C5", VA = "0x88C5")]
		public void Show(ProtoShowHintEvt data)
		{
		/* --- GHIDRA: Show ---
		int * Gameplay_Combat_View_GameField_GuideTurnHint__Show
		                (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a56746 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Color___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Point__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Point__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Point__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Point__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Texture2D_TypeInfo);
		    DAT_ram_00a56746 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar3 = *(int *)(param1 + 0x20);
		  iVar4 = *(int *)(param1 + 0x28);
		  iVar5 = *(int *)(param1 + 0x1c);
		  iVar6 = *(int *)(param1 + 0x24);
		  param1_00 = (int *)unnamed_function_1417(UnityEngine_Texture2D_TypeInfo);
		  UnityEngine_Sprite__get_textureRect
		            (param1_00,((iVar6 - iVar5) + 1) * param3,((iVar4 - iVar3) + 1) * param3,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xe4));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xf0) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xf4));
		  iVar3 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Color___TypeInfo,iVar3 * iVar4);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = iVar3 + iVar1 * 0x10;
		      *(undefined8 *)(iVar4 + 0x18) = 0;
		      *(undefined8 *)(iVar4 + 0x10) = 0;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  UnityEngine_Texture2D__GetPixels(param1_00,iVar3,0);
		  if (*(int *)(param1 + 0x2c) == 0) {
		    iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Color___TypeInfo,param3 * param3);
		    *(int *)(param1 + 0x2c) = iVar1;
		    if (0 < *(int *)(iVar1 + 0xc)) {
		      iVar3 = 0;
		      do {
		        iVar1 = iVar1 + iVar3 * 0x10;
		        *(undefined8 *)(iVar1 + 0x18) = 0x3f80000000000000;
		        *(undefined8 *)(iVar1 + 0x10) = 0x3f80000000000000;
		        iVar3 = iVar3 + 1;
		        iVar1 = *(int *)(param1 + 0x2c);
		      } while (iVar3 < *(int *)(iVar1 + 0xc));
		    }
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param2,Method_System_Collections_Generic_List_Point__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Point__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c73a52;
		    }
		    if (iVar3 == 0) goto code_r0x80c73af4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21d,param1_00,
		               (*(int *)(local_8._4_4_ + 0xc) - *(int *)(param1 + 0x1c)) * param3,
		               (*(int *)(local_8._4_4_ + 0x10) - *(int *)(param1 + 0x20)) * param3,param3,param3,
		               *(undefined4 *)(param1 + 0x2c),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c73a52:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_01);
		    iVar3 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80c73af4:
		      DAT_ram_009d3e38 = 0;
		      UnityEngine_Texture2D__SetPixels(param1_00,0);
		      return param1_00;
		    }
		    param1_01 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21e,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_01);
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

		/* --- GHIDRA: Show ---
		int * Gameplay_Combat_View_GameField_GuideTurnHint__Show
		                (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a56746 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Color___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Point__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Point__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Point__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Point__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Texture2D_TypeInfo);
		    DAT_ram_00a56746 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar3 = *(int *)(param1 + 0x20);
		  iVar4 = *(int *)(param1 + 0x28);
		  iVar5 = *(int *)(param1 + 0x1c);
		  iVar6 = *(int *)(param1 + 0x24);
		  param1_00 = (int *)unnamed_function_1417(UnityEngine_Texture2D_TypeInfo);
		  UnityEngine_Sprite__get_textureRect
		            (param1_00,((iVar6 - iVar5) + 1) * param3,((iVar4 - iVar3) + 1) * param3,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xe4));
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xf0) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xf4));
		  iVar3 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Color___TypeInfo,iVar3 * iVar4);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = iVar3 + iVar1 * 0x10;
		      *(undefined8 *)(iVar4 + 0x18) = 0;
		      *(undefined8 *)(iVar4 + 0x10) = 0;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  UnityEngine_Texture2D__GetPixels(param1_00,iVar3,0);
		  if (*(int *)(param1 + 0x2c) == 0) {
		    iVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Color___TypeInfo,param3 * param3);
		    *(int *)(param1 + 0x2c) = iVar1;
		    if (0 < *(int *)(iVar1 + 0xc)) {
		      iVar3 = 0;
		      do {
		        iVar1 = iVar1 + iVar3 * 0x10;
		        *(undefined8 *)(iVar1 + 0x18) = 0x3f80000000000000;
		        *(undefined8 *)(iVar1 + 0x10) = 0x3f80000000000000;
		        iVar3 = iVar3 + 1;
		        iVar1 = *(int *)(param1 + 0x2c);
		      } while (iVar3 < *(int *)(iVar1 + 0xc));
		    }
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param2,Method_System_Collections_Generic_List_Point__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Point__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c73a52;
		    }
		    if (iVar3 == 0) goto code_r0x80c73af4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21d,param1_00,
		               (*(int *)(local_8._4_4_ + 0xc) - *(int *)(param1 + 0x1c)) * param3,
		               (*(int *)(local_8._4_4_ + 0x10) - *(int *)(param1 + 0x20)) * param3,param3,param3,
		               *(undefined4 *)(param1 + 0x2c),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_01 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c73a52:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_01);
		    iVar3 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80c73af4:
		      DAT_ram_009d3e38 = 0;
		      UnityEngine_Texture2D__SetPixels(param1_00,0);
		      return param1_00;
		    }
		    param1_01 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21e,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_01);
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

		// Token: 0x06003931 RID: 14641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003931")]
		[Address(RVA = "0x88C6", Offset = "0x88C6", VA = "0x88C6")]
		public Texture2D GetTexture(List<Point> points, int radius)
		{
		/* --- GHIDRA: GetTexture ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__GetTexture(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003932")]
		[Address(RVA = "0x88C7", Offset = "0x88C7", VA = "0x88C7")]
		public void Show()
		{
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003933")]
		[Address(RVA = "0x88C8", Offset = "0x88C8", VA = "0x88C8")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__Hide(int param1,undefined4 param2)
		
		{
		  byte bVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  float param2_01;
		  
		  if (DAT_ram_00a56747 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a56747 = '\x01';
		  }
		  bVar1 = *(byte *)(param1 + 0x14);
		  *(byte *)(param1 + 0x14) = bVar1 ^ 1;
		  param2_01 = 0.0;
		  if (bVar1 == 0) {
		    param2_01 = 1.0;
		  }
		  param1_00 = DG_Tweening_DOTweenModuleSprite__DOColor
		                        (*(undefined4 *)(param1 + 0x10),param2_01,0.0,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		            (param1_00,param2_00,
		             Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Color__Color__ColorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003934")]
		[Address(RVA = "0x88C9", Offset = "0x88C9", VA = "0x88C9")]
		public void DbgDraw()
		{
		/* --- GHIDRA: DbgDraw ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__DbgDraw(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a56748 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_Point_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoShowHintEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_Point__Add__);
		    DAT_ram_00a56748 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Combat_ProtoShowHintEvt_TypeInfo);
		  Protocol_Combat_ProtoShowHintEvt__pb__Google_Protobuf_IMessage_get_Descriptor(param1_00,0);
		  uVar2 = *(undefined4 *)(param1_00 + 0x14);
		  iVar1 = unnamed_function_1417(Protocol_Common_Point_TypeInfo);
		  *(undefined8 *)(iVar1 + 0xc) = 0x100000002;
		  func_ii_6441(uVar2,iVar1,Method_Google_Protobuf_Collections_RepeatedField_Point__Add__);
		  uVar2 = *(undefined4 *)(param1_00 + 0x14);
		  iVar1 = unnamed_function_1417(Protocol_Common_Point_TypeInfo);
		  *(undefined8 *)(iVar1 + 0xc) = 0x100000003;
		  func_ii_6441(uVar2,iVar1,Method_Google_Protobuf_Collections_RepeatedField_Point__Add__);
		  uVar2 = *(undefined4 *)(param1_00 + 0x14);
		  iVar1 = unnamed_function_1417(Protocol_Common_Point_TypeInfo);
		  *(undefined8 *)(iVar1 + 0xc) = 0x100000004;
		  func_ii_6441(uVar2,iVar1,Method_Google_Protobuf_Collections_RepeatedField_Point__Add__);
		  iVar1 = unnamed_function_1417(Protocol_Common_Point_TypeInfo);
		  *(undefined8 *)(iVar1 + 0xc) = 0x200000003;
		  *(int *)(param1_00 + 0xc) = iVar1;
		  iVar1 = unnamed_function_1417(Protocol_Common_Point_TypeInfo);
		  *(undefined8 *)(iVar1 + 0xc) = 0x100000003;
		  *(int *)(param1_00 + 0x10) = iVar1;
		  Gameplay_Combat_View_GameField_GameFieldMono___c__DisplayClass64_0___ShowClearFieldToCenter_b__0
		            (param1,param1_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x88CA", Offset = "0x88CA", VA = "0x88CA")]
		public void Test()
		{
		/* --- GHIDRA: Test ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__Test(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a56749 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a56749 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1e8);
		        goto code_r0x80c73d85;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x25);
		code_r0x80c73d85:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_Tutorial_Guide_Control_GuideController__HandleStop
		            (*(undefined4 *)(iVar3 + 0x10),0xffffffff,0);
		  return;
		}
		*/

		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x88CB", Offset = "0x88CB", VA = "0x88CB")]
		public void TestGuideCaptureTarget()
		{
		/* --- GHIDRA: TestGuideCaptureTarget ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__TestGuideCaptureTarget
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5674a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Renderer___);
		    DAT_ram_00a5674a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_Renderer___);
		  UnityEngine_Renderer__set_useLightProbes(&local_18,uVar1,0);
		  param1[2] = local_8;
		  param1[1] = local_10;
		  *param1 = local_18;
		  return;
		}
		*/

		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x17000B3D")]
		public Bounds Bounds
		{
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x88CC", Offset = "0x88CC", VA = "0x88CC")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x17000B3E")]
		public Rect Rect
		{
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x88CD", Offset = "0x88CD", VA = "0x88CD", Slot = "4")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x88CE", Offset = "0x88CE", VA = "0x88CE", Slot = "5")]
		public Sprite GetShape()
		{
		/* --- GHIDRA: GetShape ---
		undefined4 Gameplay_Combat_View_GameField_GuideTurnHint__GetShape(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5674b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25625);
		    DAT_ram_00a5674b = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x18) + 0x10);
		  iVar3 = *(int *)(iVar2 + 0x10);
		  iVar4 = *(int *)(*(int *)(param1 + 0x18) + 0xc);
		  iVar5 = *(int *)(iVar4 + 0x10);
		  iVar4 = *(int *)(iVar4 + 0xc);
		  iVar2 = *(int *)(iVar2 + 0xc);
		  uVar1 = StringLiteral_25625;
		  if (iVar4 == iVar2) {
		    iVar5 = iVar5 - iVar3;
		    if (iVar5 < 1) {
		      if (iVar5 < 0) {
		        local_8 = 0x6ffffffff;
		        local_c = Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo;
		        uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		      }
		    }
		    else {
		      local_8 = 0x3ffffffff;
		      local_c = Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo;
		      uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    }
		  }
		  else if (iVar3 == iVar5) {
		    if (iVar4 - iVar2 < 1) {
		      local_8 = 0x5ffffffff;
		      local_c = Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo;
		      uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    }
		    else {
		      local_8 = 0x4ffffffff;
		      local_c = Gameplay_Tutorial_Guide_View_GraphicPointerView_Animation_TypeInfo;
		      uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    }
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x88CF", Offset = "0x88CF", VA = "0x88CF", Slot = "6")]
		public string GetState()
		{
		/* --- GHIDRA: GetState ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__GetState
		               (float *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  
		  iVar1 = *(int *)(*(int *)(param2 + 0x18) + 0xc);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  iVar3 = *(int *)(param2 + 0x1c);
		  iVar4 = *(int *)(param2 + 0x24);
		  iVar1 = *(int *)(iVar1 + 0x10);
		  iVar5 = *(int *)(param2 + 0x20);
		  iVar6 = *(int *)(param2 + 0x28);
		  param1[2] = 0.0;
		  param1[1] = ((float)((iVar1 - iVar5) * 0x58) - (float)(iVar6 - iVar5) * 0.5 * 88.0) + 44.0;
		  *param1 = ((float)((iVar2 - iVar3) * 0x58) - (float)(iVar4 - iVar3) * 0.5 * 88.0) + -44.0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x88D0", Offset = "0x88D0", VA = "0x88D0", Slot = "7")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x88D1", Offset = "0x88D1", VA = "0x88D1")]
		public GuideTurnHint()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_GameField_GuideTurnHint___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5674c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_GameField_GuideTurnHint___c_TypeInfo);
		    DAT_ram_00a5674c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Combat_View_GameField_GuideTurnHint___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Combat_View_GameField_GuideTurnHint___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[FieldOffset(Offset = "0x14")]
		[NonSerialized]
		private bool _isDbgDraw;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[FieldOffset(Offset = "0x18")]
		private ProtoShowHintEvt _data;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[FieldOffset(Offset = "0x1C")]
		private int _minX;

		// Token: 0x04001FA6 RID: 8102
		[Token(Token = "0x4001FA6")]
		[FieldOffset(Offset = "0x20")]
		private int _minY;

		// Token: 0x04001FA7 RID: 8103
		[Token(Token = "0x4001FA7")]
		[FieldOffset(Offset = "0x24")]
		private int _maxX;

		// Token: 0x04001FA8 RID: 8104
		[Token(Token = "0x4001FA8")]
		[FieldOffset(Offset = "0x28")]
		private int _maxY;

		// Token: 0x04001FA9 RID: 8105
		[Token(Token = "0x4001FA9")]
		[FieldOffset(Offset = "0x2C")]
		private Color[] _cachedCellColor;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Bounds ---
		void Gameplay_Combat_View_GameField_GuideTurnHint__get_Bounds
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5674a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Renderer___);
		    DAT_ram_00a5674a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_Renderer___);
		  UnityEngine_Renderer__set_useLightProbes(&local_18,uVar1,0);
		  uVar1 = Utils_Cam_FlickerFixer___ctor(0);
		  local_38 = local_10;
		  local_30 = local_8;
		  local_40 = local_18;
		  Core_Extensions_BoundsExt__ToRect(&local_28,&local_40,uVar1,0);
		  param1[1] = local_20;
		  *param1 = local_28;
		  return;
		}
		*/


		/* --- GHIDRA: get_Rect ---
		undefined4 Gameplay_Combat_View_GameField_GuideTurnHint__get_Rect(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar1 = func_ii_7884(*(undefined4 *)(param1 + 0x10),0);
		  uVar1 = UnityEngine_UI_Image__get_activeSprite(uVar1,0);
		  uVar2 = func_ii_7884(*(undefined4 *)(param1 + 0x10),0);
		  piVar3 = (int *)UnityEngine_UI_Image__get_activeSprite(uVar2,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xe4));
		  uVar2 = func_ii_7884(*(undefined4 *)(param1 + 0x10),0);
		  piVar3 = (int *)UnityEngine_UI_Image__get_activeSprite(uVar2,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf0) * 4))
		                    (piVar3,*(undefined4 *)(*piVar3 + 0xf4));
		  local_8 = (float4)(float)iVar4;
		  local_4 = (float4)(float)iVar5;
		  local_20 = CONCAT44(local_4,local_8);
		  local_18 = 0x3f0000003f000000;
		  local_10 = 0;
		  local_28 = 0;
		  local_30 = 0x3f0000003f000000;
		  uVar1 = UnityEngine_Sprite__Create(uVar1,&local_28,&local_30,100.0,0);
		  return uVar1;
		}
		*/

}
