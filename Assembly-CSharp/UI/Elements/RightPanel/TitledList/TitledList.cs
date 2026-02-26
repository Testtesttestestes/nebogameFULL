using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	public class TitledList : MonoBehaviour
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		public bool IsInit
		{
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x600C", Offset = "0x600C", VA = "0x600C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x600D", Offset = "0x600D", VA = "0x600D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B9")]
		public string Title
		{
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x600E", Offset = "0x600E", VA = "0x600E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x600F", Offset = "0x600F", VA = "0x600F")]
			set
			{
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x6010", Offset = "0x6010", VA = "0x6010")]
		public void Init(TitledListArgs args)
		{
		/* --- GHIDRA: Init ---
		int * UI_Elements_RightPanel_TitledList_TitledList__Init
		                (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a6395f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__BaseTitledListElement__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__BaseTitledListElement__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BaseTitledListElement__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BaseTitledListElement__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BaseTitledListElement___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a6395f = '\x01';
		  }
		  uVar1 = unnamed_function_143827(param2);
		  if (0 < *(int *)(*(int *)(param1 + 0x24) + 0xc)) {
		    uVar3 = *(undefined4 *)(param1 + 0x18);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar3,0,0);
		    if (iVar2 != 0) {
		      uVar3 = *(undefined4 *)(param1 + 0x14);
		      param1_00 = *(undefined4 *)(param1 + 0x18);
		      iVar2 = *(int *)(param1 + 0x28);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar3 = func_ii_6805(param1_00,uVar3,Method_UnityEngine_Object_Instantiate_RectTransform___);
		      iVar4 = Method_System_Collections_Generic_List_RectTransform__Add__;
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar5 = *(uint *)(iVar2 + 0xc);
		      if (uVar5 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		        *(uint *)(iVar2 + 0xc) = uVar5 + 1;
		        *(undefined4 *)(*(int *)(iVar2 + 8) + uVar5 * 4 + 0x10) = uVar3;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		      }
		    }
		  }
		  param2_00 = (int *)0x0;
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)(param1 + 0x20),uVar1,
		                     Method_System_Collections_Generic_Dictionary_Type__BaseTitledListElement__ContainsKey__
		                    );
		  if (iVar2 != 0) {
		    uVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 0x20),uVar1,
		                       Method_System_Collections_Generic_Dictionary_Type__BaseTitledListElement__get_Item__
		                      );
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    param2_00 = (int *)func_ii_6805(uVar1,uVar3,
		                                    Method_UnityEngine_Object_Instantiate_BaseTitledListElement___);
		    (**(code **)((ulonglong)*(uint *)(*param2_00 + 0xe8) * 4))
		              (param2_00,param2,*(undefined4 *)(*param2_00 + 0xec));
		    iVar2 = Method_System_Collections_Generic_List_BaseTitledListElement__Add__;
		    iVar4 = *(int *)(param1 + 0x24);
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar5 = *(uint *)(iVar4 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		      *(int **)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = param2_00;
		      return param2_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  return param2_00;
		}
		*/

		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x6011", Offset = "0x6011", VA = "0x6011")]
		public BaseTitledListElement AddElement(BaseTitledListElementArgs titledListElementArgs)
		{
		/* --- GHIDRA: AddElement ---
		void UI_Elements_RightPanel_TitledList_TitledList__AddElement(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63960 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BaseTitledListElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BaseTitledListElement__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BaseTitledListElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BaseTitledListElement__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BaseTitledListElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63960 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_List_BaseTitledListElement__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BaseTitledListElement__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8232080a;
		    }
		    if (iVar1 == 0) goto code_r0x82320860;
		    uVar2 = local_8._4_4_;
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
		code_r0x8232080a:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x82320860:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x24);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x11,&local_18);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 == 1) {
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

			return null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x6012", Offset = "0x6012", VA = "0x6012")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_RightPanel_TitledList_TitledList__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63961 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__BaseTitledListElement___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Type__BaseTitledListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BaseTitledListElement___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RectTransform__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BaseTitledListElement__TypeInfo);
		    DAT_ram_00a63961 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_BaseTitledListElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_BaseTitledListElement___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_Type__BaseTitledListElement__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_Type__BaseTitledListElement___ctor__
		            );
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_BaseTitledListElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_BaseTitledListElement___ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_RectTransform__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_RectTransform___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x6013", Offset = "0x6013", VA = "0x6013")]
		public TitledList()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_RightPanel_TitledList_TitledList___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63962 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo);
		    DAT_ram_00a63962 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo);
		  **(undefined4 **)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _listContainer;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _spacerPrefab;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private List<BaseTitledListElement> _elementsPrefabs;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Type, BaseTitledListElement> _elementsPrefabsDict;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0x24")]
		private List<BaseTitledListElement> _instancedElements;

		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x28")]
		private List<RectTransform> _instancedSpacers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Title ---
		void UI_Elements_RightPanel_TitledList_TitledList__set_Title
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a6395e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_BaseTitledListElement__Type__BaseTitledListElement___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BaseTitledListElement__Type__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_BaseTitledListElement__BaseTitledListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RightPanel_TitledList_TitledList___c__Init_b__14_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RightPanel_TitledList_TitledList___c__Init_b__14_1__);
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo);
		    DAT_ram_00a6395e = '\x01';
		  }
		  if (*(char *)(param1 + 0x2c) == '\0') {
		    uVar1 = *(undefined4 *)(param1 + 0x1c);
		    if (*(int *)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x5c);
		    param1_01 = puVar2[1];
		    param1_00 = UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo;
		    if (param1_01 == 0) {
		      if (*(int *)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo);
		        puVar2 = *(undefined4 **)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar2;
		      param1_01 = unnamed_function_1417(System_Func_BaseTitledListElement__Type__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_01,uVar3,
		                 Method_UI_Elements_RightPanel_TitledList_TitledList___c__Init_b__14_0__,0);
		      param1_00 = UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo;
		      *(int *)(*(int *)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x5c) + 4) =
		           param1_01;
		    }
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      param1_00 = UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo;
		    }
		    puVar2 = *(undefined4 **)(param1_00 + 0x5c);
		    param1_02 = puVar2[2];
		    if (param1_02 == 0) {
		      if (*(int *)(param1_00 + 0x74) == 0) {
		        func_ii_306000(param1_00);
		        puVar2 = *(undefined4 **)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar2;
		      param1_02 = unnamed_function_1417
		                            (System_Func_BaseTitledListElement__BaseTitledListElement__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_02,uVar3,
		                 Method_UI_Elements_RightPanel_TitledList_TitledList___c__Init_b__14_1__,0);
		      *(int *)(*(int *)(UI_Elements_RightPanel_TitledList_TitledList___c_TypeInfo + 0x5c) + 8) =
		           param1_02;
		    }
		    uVar1 = System_Linq_Enumerable__ToDictionary_object__object__Int32Enum_
		                      (uVar1,param1_01,param1_02,
		                       Method_System_Linq_Enumerable_ToDictionary_BaseTitledListElement__Type__BaseTitledListElement___
		                      );
		    *(undefined1 *)(param1 + 0x2c) = 1;
		    *(undefined4 *)(param1 + 0x20) = uVar1;
		  }
		  return;
		}
		*/

}
