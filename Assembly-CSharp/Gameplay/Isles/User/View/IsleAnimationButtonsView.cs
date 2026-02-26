using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D12 RID: 3346
	[Token(Token = "0x2000D12")]
	public class IsleAnimationButtonsView : MonoBehaviour
	{
		// Token: 0x140001F0 RID: 496
		// (add) Token: 0x060051A6 RID: 20902 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051A7 RID: 20903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F0")]
		public event Action<IsleAnimationsDic> ButtonClickedEvent
		{
			[Token(Token = "0x60051A6")]
			[Address(RVA = "0x9F81", Offset = "0x9F81", VA = "0x9F81")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051A7")]
			[Address(RVA = "0x9F82", Offset = "0x9F82", VA = "0x9F82")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001086")]
		public Dictionary<IsleAnimationsDic, GameAnimatedButton> Buttons
		{
			[Token(Token = "0x60051A8")]
			[Address(RVA = "0x9F83", Offset = "0x9F83", VA = "0x9F83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A9")]
		[Address(RVA = "0x9F84", Offset = "0x9F84", VA = "0x9F84")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x18),0,*(undefined4 *)(iVar1 + 0x164));
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060051AA RID: 20906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AA")]
		[Address(RVA = "0x9F85", Offset = "0x9F85", VA = "0x9F85")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AB")]
		[Address(RVA = "0x9F86", Offset = "0x9F86", VA = "0x9F86")]
		public void SetButtonAvailability(bool available)
		{
		/* --- GHIDRA: SetButtonAvailability ---
		undefined4
		Gameplay_Isles_User_View_IsleAnimationButtonsView__SetButtonAvailability
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a58d2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_IsleAnimationsDic__GameAnimatedButton__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_IsleAnimationsDic__GameAnimatedButton__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58d2c = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__MoveNext__
		                      );
		    param2_00 = local_8;
		    uVar3 = uStack_c;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f9f96d:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f9fa0c:
		          DAT_ram_009d3e38 = 0;
		          *param3 = 0;
		          return 0;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26d,&local_20);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
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
		    if (iVar2 == 0) goto code_r0x80f9fa0c;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f9f96d;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,param2_00,param2,0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9f96d;
		    }
		    if (iVar2 != 0) {
		      *param3 = uVar3;
		      return 1;
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60051AC")]
		[Address(RVA = "0x1E0A", Offset = "0x1E0A", VA = "0x1E0A")]
		public GameAnimatedButton AddButton(IsleAnimationsDic isleAnimationsDic)
		{
		/* --- GHIDRA: AddButton ---
		int Gameplay_Isles_User_View_IsleAnimationButtonsView__AddButton
		              (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int local_4;
		  
		  if (DAT_ram_00a6283e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__TryGetValue__
		              );
		    DAT_ram_00a6283e = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0xc),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(local_4 + 0xc);
		  }
		  *param3 = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x60051AD")]
		[Address(RVA = "0x9F87", Offset = "0x9F87", VA = "0x9F87")]
		private bool TryGetButtonData(GameAnimatedButton button, out IsleAnimationsDic animationsDic)
		{
		/* --- GHIDRA: TryGetButtonData ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__TryGetButtonData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = 0;
		  iVar1 = Gameplay_Isles_User_View_IsleAnimationButtonsView__SetButtonAvailability
		                    (param1,param2,&local_4,auStack_10);
		  if ((iVar1 != 0) && (iVar1 = *(int *)(param1 + 0x1c), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),local_4,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AE")]
		[Address(RVA = "0x9F88", Offset = "0x9F88", VA = "0x9F88")]
		private void ButtonOnClickEvent(GameAnimatedButton button)
		{
		/* --- GHIDRA: ButtonOnClickEvent ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__ButtonOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d2d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimatedButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_IsleAnimationsDic__GameAnimatedButton__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_IsleAnimationsDic__GameAnimatedButton__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_IsleAnimationsDic__GameAnimatedButton__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_View_IsleAnimationButtonsView_ButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_IsleAnimationsDic__GameAnimatedButton__GetEnumerator__
		              );
		    DAT_ram_00a58d2d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_IsleAnimationsDic__GameAnimatedButton__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_IsleAnimationsDic__GameAnimatedButton__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9fcff;
		    }
		    if (iVar3 == 0) goto code_r0x80f9fd55;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_GameAnimatedButton__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f9fce3:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f9fcff;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,param2_00,param1,
		               Method_Gameplay_Isles_User_View_IsleAnimationButtonsView_ButtonOnClickEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f9fce3;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26e,uVar2,param2_00,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f9fce3;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,uVar2,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f9fcff:
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
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f9fd55:
		      DAT_ram_009d3e38 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 0x20),
		                 Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__Clear__
		                );
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26f,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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
		*/

		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AF")]
		[Address(RVA = "0x9F89", Offset = "0x9F89", VA = "0x9F89")]
		public void RemoveAllButtons()
		{
		/* --- GHIDRA: RemoveAllButtons ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__RemoveAllButtons
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58d2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__TypeInfo
		              );
		    DAT_ram_00a58d2e = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B0")]
		[Address(RVA = "0x9F8A", Offset = "0x9F8A", VA = "0x9F8A")]
		public IsleAnimationButtonsView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Isles_User_View_IsleAnimationButtonsView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d2f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12644);
		    DAT_ram_00a58d2f = '\x01';
		  }
		  return StringLiteral_12644;
		}
		*/

		}

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimatedButton _buttonPrefab;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002C63 RID: 11363
		[Token(Token = "0x4002C63")]
		[FieldOffset(Offset = "0x18")]
		private IsleAnimationButtonsViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ButtonClickedEvent ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__add_ButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d29 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationsDic__TypeInfo);
		    DAT_ram_00a58d29 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IsleAnimationsDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IsleAnimationsDic__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: get_Buttons ---
		void Gameplay_Isles_User_View_IsleAnimationButtonsView__get_Buttons(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param3;
		  undefined4 param4;
		  undefined4 param5;
		  
		  if (DAT_ram_00a58d2a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_TypeInfo);
		    DAT_ram_00a58d2a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f9f42e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f9f42e:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3 = *(undefined4 *)(iVar4 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f9f4dd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f9f4dd:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0xc);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x80f9f58c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f9f58c:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param5 = *(undefined4 *)(iVar4 + 0x10);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_TypeInfo);
		  if (DAT_ram_00a58d96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView___ctor__
		              );
		    DAT_ram_00a58d96 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

}
