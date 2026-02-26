using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x020007FC RID: 2044
	[Token(Token = "0x20007FC")]
	public class FrescoGroupListElement : GenericListElement<FrescoGroupListElementArgs>
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002FFC RID: 12284 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002FFD RID: 12285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000966")]
		public FrescoGroupListElementArgs Data
		{
			[Token(Token = "0x6002FFC")]
			[Address(RVA = "0x8062", Offset = "0x8062", VA = "0x8062")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002FFD")]
			[Address(RVA = "0x8063", Offset = "0x8063", VA = "0x8063")]
			set
			{
			}
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x8064", Offset = "0x8064", VA = "0x8064", Slot = "4")]
		protected override void OnInit(FrescoGroupListElementArgs newArgs)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Fresco_View_Groups_FrescoGroupListElement__OnInit
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Fresco_View_Groups_FrescoGroupListElement__ApplyArgs(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x8065", Offset = "0x8065", VA = "0x8065")]
		private void ApplyArgs(FrescoGroupListElementArgs newArgs)
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Fresco_View_Groups_FrescoGroupListElement__ApplyArgs
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param4;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 param2_00;
		  int iVar5;
		  uint uVar6;
		  int iVar7;
		  undefined1 auStack_30 [8];
		  undefined4 local_28;
		  undefined4 local_24;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5757c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_Fresco__Fresco_Types_FrescoDic__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_Fresco__Fresco_Types_FrescoDic__get_Value__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoListElement__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_FrescoListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__GetEnumerator__
		              );
		    DAT_ram_00a5757c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  uVar1 = 0;
		  if (*(char *)(param2 + 0xc) == '\0') {
		    uVar1 = 0xffffffee;
		  }
		  UnityEngine_RectOffset__set_top(*(undefined4 *)(*(int *)(param1 + 0x24) + 0x10),uVar1,0);
		  piVar4 = *(int **)(param1 + 0x28);
		  uVar1 = Core_Extensions_Dict_FrescoGroupsDicExt__GetGroupMessage(*(undefined4 *)(param2 + 0x14),0)
		  ;
		  iVar7 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		            (piVar4,uVar1,*(undefined4 *)(iVar7 + 0x2d4));
		  Gameplay_Fresco_View_Groups_FrescoGroupListElement__InitGroup(param1,auStack_30);
		  System_Collections_Generic_SortedDictionary_object__object___CopyTo
		            (&local_18,*(undefined4 *)(param2 + 0x18),
		             Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30c,&local_18,
		                       Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80daacd0;
		    }
		    iVar7 = local_20;
		    if (iVar2 == 0) goto code_r0x80daad19;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30d,&local_28,&local_18,
		               Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__get_Current__
		              );
		    param4 = local_24;
		    uVar1 = local_28;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) break;
		    param2_00 = *(undefined4 *)(param1 + 0x20);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,
		                       *(undefined4 *)(param1 + 0x24),0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80daaca0:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80daacd0;
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80daaca0;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar3,
		                       Method_UnityEngine_Object_Instantiate_FrescoListElement___);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80daacd0;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiiiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30f,uVar3,uVar1,param4,iVar5,
		               (uint)*(byte *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),auStack_30);
		    iVar2 = DAT_ram_009d3e38;
		    iVar7 = Method_System_Collections_Generic_List_FrescoListElement__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80daacd0;
		    }
		    iVar5 = iVar5 + 1;
		    iVar2 = *(int *)(param1 + 0x2c);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar2 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar6 * 4 + 0x10) = uVar3;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,uVar3,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80daacd0:
		        iVar5 = global_1;
		        iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 == iVar7) {
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		          iVar7 = *piVar4;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 1) {
		code_r0x80daad19:
		            DAT_ram_009d3e38 = 0;
		            System_Collections_Generic_SortedDictionary_Enumerator_object__object____ctor
		                      (local_1c,
		                       Method_System_Collections_Generic_SortedDictionary_Enumerator_Fresco__Fresco_Types_FrescoDic__Dispose__
		                      );
		            if (iVar7 == 0) {
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x310,&local_20);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80daacd0;
		}
		*/

		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x8066", Offset = "0x8066", VA = "0x8066")]
		private void InitGroup(FrescoGroupListElementArgs newArgs)
		{
		/* --- GHIDRA: InitGroup ---
		void Gameplay_Fresco_View_Groups_FrescoGroupListElement__InitGroup(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param3;
		  
		  if (DAT_ram_00a5757d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoListElement__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5757d = '\x01';
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x24),0);
		  iVar3 = UnityEngine_Transform__InverseTransformPoint(uVar2,0);
		  iVar3 = iVar3 + -1;
		  if (-1 < iVar3) {
		    do {
		      uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x24),0);
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
		  iVar3 = *(int *)(param1 + 0x2c);
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

		// Token: 0x06003001 RID: 12289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x8067", Offset = "0x8067", VA = "0x8067")]
		private void ClearElements()
		{
		/* --- GHIDRA: ClearElements ---
		void Gameplay_Fresco_View_Groups_FrescoGroupListElement__ClearElements(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5757e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_FrescoListElement___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_FrescoListElement__TypeInfo);
		    DAT_ram_00a5757e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_FrescoListElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_FrescoListElement___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x8068", Offset = "0x8068", VA = "0x8068")]
		public FrescoGroupListElement()
		{
		}

		// Token: 0x04001A41 RID: 6721
		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FrescoListElement _frescoListElementPrefab;

		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private HorizontalLayoutGroup _container;

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _header;

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x2C")]
		private List<FrescoListElement> _elements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Fresco_View_Groups_FrescoGroupListElement__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5757b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__set_args__
		              );
		    DAT_ram_00a5757b = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__Init__)
		    ;
		    return;
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  Gameplay_Fresco_View_Groups_FrescoGroupListElement__ApplyArgs(param1,param2,param1);
		  return;
		}
		*/

}
