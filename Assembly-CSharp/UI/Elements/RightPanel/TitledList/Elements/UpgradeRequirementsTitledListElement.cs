using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList.Elements.UpgradeRequirements;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public class UpgradeRequirementsTitledListElement : BaseTitledListElement<UpgradeRequirementsTitledListElementArgs>
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x602F", Offset = "0x602F", VA = "0x602F", Slot = "6")]
		protected override void OnInit(UpgradeRequirementsTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirementsTitledListElement__OnInit
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63969 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_UpgradeRequirementElement__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_UpgradeRequirementElement__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_UpgradeRequirementElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UpgradeRequirementElement__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UpgradeRequirementElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63969 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_UpgradeRequirementElement__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_UpgradeRequirementElement__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x823210da;
		    }
		    if (iVar1 == 0) goto code_r0x82321130;
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
		code_r0x823210da:
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
		code_r0x82321130:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x18);
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
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x13,&local_18);
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

		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x6030", Offset = "0x6030", VA = "0x6030")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirementsTitledListElement__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6396a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_UpgradeRequirementsTitledListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UpgradeRequirementElement___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_UpgradeRequirementElement__TypeInfo);
		    DAT_ram_00a6396a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_UpgradeRequirementElement__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_UpgradeRequirementElement___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_UpgradeRequirementsTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x6031", Offset = "0x6031", VA = "0x6031")]
		public UpgradeRequirementsTitledListElement()
		{
		}

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _requirementsContainer;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UpgradeRequirementElement _requirementElementPrefab;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x18")]
		private List<UpgradeRequirementElement> _instancedElements;
	}
}
