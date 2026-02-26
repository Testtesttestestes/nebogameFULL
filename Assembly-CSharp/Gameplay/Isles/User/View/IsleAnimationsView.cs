using System;
using System.Collections.Generic;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D15 RID: 3349
	[Token(Token = "0x2000D15")]
	public class IsleAnimationsView : BaseWorldObjectRenderer
	{
		// Token: 0x060051C0 RID: 20928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x9F9A", Offset = "0x9F9A", VA = "0x9F9A")]
		public void ShowAnimation(string assetId)
		{
		/* --- GHIDRA: ShowAnimation ---
		void Gameplay_Isles_User_View_IsleAnimationsView__ShowAnimation
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58d3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_GameAssetViewSpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&System_Func_GameAssetViewSpriteRenderer__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer__Remove__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleAnimationsView___c__DisplayClass3_0__GameAnimationViewOnAnimationCompleteEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_View_IsleAnimationsView___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a58d3c = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Isles_User_View_IsleAnimationsView___c__DisplayClass3_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = unnamed_function_1417(System_Func_GameAssetViewSpriteRenderer__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_Isles_User_View_IsleAnimationsView___c__DisplayClass3_0__GameAnimationViewOnAnimationCompleteEvent_b__0__
		             ,0);
		  uVar1 = func_ii_7423(param1_00,uVar1,
		                       Method_System_Linq_Enumerable_First_GameAssetViewSpriteRenderer___);
		  func_ii_4876(*(undefined4 *)(param1 + 0x28),uVar1,
		               Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer__Remove__);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C1")]
		[Address(RVA = "0x9F9B", Offset = "0x9F9B", VA = "0x9F9B")]
		private void GameAnimationViewOnAnimationCompleteEvent(GameAnimationView target)
		{
		/* --- GHIDRA: GameAnimationViewOnAnimationCompleteEvent ---
		void Gameplay_Isles_User_View_IsleAnimationsView__GameAnimationViewOnAnimationCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param3;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer__GetEnumerator__)
		    ;
		    DAT_ram_00a58d3d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa092f;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = local_8._4_4_;
		    param3 = func_ii_4075(param1,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x269,uVar3,param3,0)
		    ;
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa092f:
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x270,&local_18);
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

		// Token: 0x060051C2 RID: 20930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x9F9C", Offset = "0x9F9C", VA = "0x9F9C", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_User_View_IsleAnimationsView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer__GetEnumerator__)
		    ;
		    DAT_ram_00a58d3e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GameAssetViewSpriteRenderer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa0b23;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26b,local_8._4_4_,
		               *(undefined4 *)(param1 + 0x18),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa0b23:
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x271,&local_18);
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

		// Token: 0x060051C3 RID: 20931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x9F9D", Offset = "0x9F9D", VA = "0x9F9D", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		void Gameplay_Isles_User_View_IsleAnimationsView__ApplySortingLayerId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58d3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_GameAssetViewSpriteRenderer__TypeInfo);
		    DAT_ram_00a58d3f = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_GameAssetViewSpriteRenderer__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_GameAssetViewSpriteRenderer___ctor__);
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x9F9E", Offset = "0x9F9E", VA = "0x9F9E")]
		public IsleAnimationsView()
		{
		}

		// Token: 0x04002C75 RID: 11381
		[Token(Token = "0x4002C75")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetViewPrefab;

		// Token: 0x04002C76 RID: 11382
		[Token(Token = "0x4002C76")]
		[FieldOffset(Offset = "0x28")]
		private List<GameAssetViewSpriteRenderer> _animations;
	}
}
