using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D18 RID: 3352
	[Token(Token = "0x2000D18")]
	public class IsleBonusesView : BaseWorldObjectRenderer
	{
		// Token: 0x140001F4 RID: 500
		// (add) Token: 0x060051D8 RID: 20952 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051D9 RID: 20953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F4")]
		public event Action<uint> BonusClickedEvent
		{
			[Token(Token = "0x60051D8")]
			[Address(RVA = "0x9FB2", Offset = "0x9FB2", VA = "0x9FB2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051D9")]
			[Address(RVA = "0x9FB3", Offset = "0x9FB3", VA = "0x9FB3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700108F")]
		private GameObjectPool<IsleBonusView> IsleBonusPool
		{
			[Token(Token = "0x60051DA")]
			[Address(RVA = "0x9FB4", Offset = "0x9FB4", VA = "0x9FB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x0000EE80 File Offset: 0x0000D080
		// (set) Token: 0x060051DC RID: 20956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001090")]
		public bool Interabtable
		{
			[Token(Token = "0x60051DB")]
			[Address(RVA = "0x9FB5", Offset = "0x9FB5", VA = "0x9FB5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051DC")]
			[Address(RVA = "0x9FB6", Offset = "0x9FB6", VA = "0x9FB6")]
			set
			{
			}
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x9FB7", Offset = "0x9FB7", VA = "0x9FB7")]
		private void ValidateInteractable()
		{
		/* --- GHIDRA: ValidateInteractable ---
		void Gameplay_Isles_User_View_IsleBonusesView__ValidateInteractable
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(*(undefined4 *)(param2 + 0x14),0,0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x9FB8", Offset = "0x9FB8", VA = "0x9FB8")]
		private void ResetPoolObjectDelegate(IsleBonusView pooledObject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void Gameplay_Isles_User_View_IsleBonusesView__ResetPoolObjectDelegate
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a58d4e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleBonusView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleBonusesView_SpriteLoaderOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_IsleBonusView__Release__);
		    DAT_ram_00a58d4e = '\x01';
		  }
		  param2_01 = *(undefined4 *)(param2 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_IsleBonusView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,Method_Gameplay_Isles_User_View_IsleBonusesView_SpriteLoaderOnClickEvent__
		             ,0);
		  if (DAT_ram_00a58d48 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleBonusView__TypeInfo);
		    DAT_ram_00a58d48 = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    param2_00 = System_Action_IsleBonusView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleBonusView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param2 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      System_Collections_Generic_List_Enumerator_uint___MoveNext
		                (*(undefined4 *)(param1 + 0x30),param2_01,
		                 Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__Remove__);
		      uVar3 = Gameplay_Isles_User_View_IsleBonusesView__remove_BonusClickedEvent(param1,iVar2);
		      func_ii_7070(uVar3,param2,Method_Utils_Cache_ObjectPool_IsleBonusView__Release__);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x9FB9", Offset = "0x9FB9", VA = "0x9FB9")]
		public void RemoveBonus(IsleBonusView bonus)
		{
		/* --- GHIDRA: RemoveBonus ---
		void Gameplay_Isles_User_View_IsleBonusesView__RemoveBonus(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x1c),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x1E10", Offset = "0x1E10", VA = "0x1E10")]
		public void AddBonus(uint positionId, uint type, TreeBonusAnimation treeBonusAnimation, Vector2 positionFromServer)
		{
		/* --- GHIDRA: AddBonus ---
		int * Gameplay_Isles_User_View_IsleBonusesView__AddBonus(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x9FBA", Offset = "0x9FBA", VA = "0x9FBA")]
		private void SpriteLoaderOnClickEvent(IsleBonusView view)
		{
		/* --- GHIDRA: SpriteLoaderOnClickEvent ---
		void Gameplay_Isles_User_View_IsleBonusesView__SpriteLoaderOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_IsleBonusView__Clear__);
		    DAT_ram_00a58d50 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    Utils_Cache_ObjectPool_object____ctor
		              (*(int *)(param1 + 0x34),Method_Utils_Cache_ObjectPool_IsleBonusView__Clear__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x9FBB", Offset = "0x9FBB", VA = "0x9FBB")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Isles_User_View_IsleBonusesView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d51 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IsleBonusView__GetEnumerator__
		              );
		    DAT_ram_00a58d51 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IsleBonusView__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa1ce9;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x274,
		                       *(undefined4 *)(local_8._4_4_ + 0x14),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa1ce9;
		    }
		    DAT_ram_009d3e38 = 0;
		    param3 = func_ii_4075(param1,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x275,uVar2,param3,0)
		    ;
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa1ce9:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x276,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
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

		// Token: 0x060051E3 RID: 20963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x9FBC", Offset = "0x9FBC", VA = "0x9FBC", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_User_View_IsleBonusesView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d52 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IsleBonusView__GetEnumerator__
		              );
		    DAT_ram_00a58d52 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IsleBonusView__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa1f0e;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x274,
		                       *(undefined4 *)(local_8._4_4_ + 0x14),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x277,uVar2,
		               *(undefined4 *)(param1 + 0x18),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa1f0e:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x278,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
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
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80fa1f0e;
		}
		*/

		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x9FBD", Offset = "0x9FBD", VA = "0x9FBD", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		void Gameplay_Isles_User_View_IsleBonusesView__ApplySortingLayerId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param3_00;
		  undefined8 local_28;
		  float local_20;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a58d53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_View_IsleBonusesView___c__DisplayClass23_0__ShowBonusCollected_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_View_IsleBonusesView___c__DisplayClass23_0_TypeInfo);
		    DAT_ram_00a58d53 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Isles_User_View_IsleBonusesView___c__DisplayClass23_0_TypeInfo);
		  *(int *)(param2_00 + 8) = param1;
		  param3_00 = (int *)(param2_00 + 0xc);
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x30),param2,param3_00,
		                     Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    uVar2 = func_ii_7674(*(undefined4 *)(*param3_00 + 0x14),0);
		    uVar2 = DG_Tweening_DOTweenModuleSprite__DOColor(uVar2,0.0,0.2,0);
		    DG_Tweening_ShortcutExtensions__DOScale
		              (uVar2,6,
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Color__Color__ColorOptions____
		              );
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*param3_00,0);
		    uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*param3_00,0);
		    func_ii_7888(&local_c,uVar3,0);
		    if (DAT_ram_00a65d42 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a65d42 = '\x01';
		    }
		    iVar1 = *(int *)(UnityEngine_Vector3_TypeInfo + 0x5c);
		    local_20 = (float)local_4 + *(float *)(iVar1 + 0x20) * 20.0;
		    local_18 = (float4)((float)local_c + *(float *)(iVar1 + 0x18) * 20.0);
		    local_14 = (float4)((float)local_8 + *(float *)(iVar1 + 0x1c) * 20.0);
		    local_28 = CONCAT44(local_14,local_18);
		    local_10 = (float4)local_20;
		    uVar2 = DG_Tweening_ShortcutExtensions__DOTime(uVar2,&local_28,0.2,0,0);
		    uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                      (uVar2,6,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (uVar3,param2_00,
		               Method_Gameplay_Isles_User_View_IsleBonusesView___c__DisplayClass23_0__ShowBonusCollected_b__0__
		               ,0);
		    DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (uVar2,uVar3,
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x9FBE", Offset = "0x9FBE", VA = "0x9FBE")]
		public void ShowBonusCollected(uint positionId)
		{
		/* --- GHIDRA: ShowBonusCollected ---
		void Gameplay_Isles_User_View_IsleBonusesView__ShowBonusCollected(int param1,undefined4 param2)
		
		{
		  int param3;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param3 = 0;
		  if (DAT_ram_00a58d54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IsleBonusView___);
		    DAT_ram_00a58d54 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(undefined4 *)(param1 + 0x30),
		                         Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__
		                        );
		  iVar1 = func_ii_6295(param1_00,Method_System_Linq_Enumerable_ToArray_IsleBonusView___);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      Gameplay_Isles_User_View_IsleBonusesView__ResetPoolObjectDelegate
		                (param1,*(undefined4 *)(iVar1 + param3 * 4 + 0x10),param3);
		      param3 = param3 + 1;
		    } while (param3 < *(int *)(iVar1 + 0xc));
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x30),
		             Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x9FBF", Offset = "0x9FBF", VA = "0x9FBF")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_Isles_User_View_IsleBonusesView__Clear(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58d55 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__IsleBonusView__TypeInfo);
		    DAT_ram_00a58d55 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__IsleBonusView__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,Method_System_Collections_Generic_Dictionary_uint__IsleBonusView___ctor__);
		  *(undefined4 *)(param1 + 0x30) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E7")]
		[Address(RVA = "0x9FC0", Offset = "0x9FC0", VA = "0x9FC0")]
		public IsleBonusesView()
		{
		}

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		private const float BONUS_HIDE_DURATION = 0.2f;

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		private const float BONUS_HIDE_OFFSET = 20f;

		// Token: 0x04002C80 RID: 11392
		[Token(Token = "0x4002C80")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _bonusesContainer;

		// Token: 0x04002C81 RID: 11393
		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IsleBonusView _bonusPrefab;

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, IsleBonusView> _views;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[FieldOffset(Offset = "0x34")]
		private GameObjectPool<IsleBonusView> _isleBonusPool;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		[FieldOffset(Offset = "0x38")]
		private bool _interactable;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_BonusClickedEvent ---
		void Gameplay_Isles_User_View_IsleBonusesView__add_BonusClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d4b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    DAT_ram_00a58d4b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_uint__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_uint__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_BonusClickedEvent ---
		int Gameplay_Isles_User_View_IsleBonusesView__remove_BonusClickedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d4c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPool_IsleBonusView___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_IsleBonusView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleBonusesView_ResetPoolObjectDelegate__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_IsleBonusView__TypeInfo);
		    DAT_ram_00a58d4c = '\x01';
		  }
		  param1_01 = *(int *)(param1 + 0x34);
		  if (param1_01 == 0) {
		    param3 = *(undefined4 *)(param1 + 0x24);
		    param2_00 = *(undefined4 *)(param1 + 0x28);
		    param1_00 = unnamed_function_1417
		                          (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_IsleBonusView__TypeInfo);
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (param1_00,param1,
		               Method_Gameplay_Isles_User_View_IsleBonusesView_ResetPoolObjectDelegate__,0);
		    param1_01 = unnamed_function_1417(Utils_Cache_GameObjectPool_IsleBonusView__TypeInfo);
		    Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		              (param1_01,param2_00,param3,param1_00,
		               Method_Utils_Cache_GameObjectPool_IsleBonusView___ctor__);
		    *(int *)(param1 + 0x34) = param1_01;
		  }
		  return param1_01;
		}
		*/


		/* --- GHIDRA: get_Interabtable ---
		void Gameplay_Isles_User_View_IsleBonusesView__get_Interabtable
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x38) = (undefined1)param2;
		  Gameplay_Isles_User_View_IsleBonusesView__set_Interabtable(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Interabtable ---
		void Gameplay_Isles_User_View_IsleBonusesView__set_Interabtable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IsleBonusView__GetEnumerator__
		              );
		    DAT_ram_00a58d4d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x30),
		                     Method_System_Collections_Generic_Dictionary_uint__IsleBonusView__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__IsleBonusView__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__IsleBonusView__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa167d;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x272,
		               *(undefined4 *)(local_8._4_4_ + 0x14),(uint)*(byte *)(param1 + 0x38),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa167d:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x273,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
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
