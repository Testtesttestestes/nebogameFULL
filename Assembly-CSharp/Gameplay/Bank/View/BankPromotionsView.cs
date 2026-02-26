using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C48 RID: 3144
	[Token(Token = "0x2000C48")]
	public class BankPromotionsView : MonoBehaviour
	{
		// Token: 0x140001DE RID: 478
		// (add) Token: 0x06004CAC RID: 19628 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CAD RID: 19629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DE")]
		public event Action<PromotionsDic> ShowInfoEvent
		{
			[Token(Token = "0x6004CAC")]
			[Address(RVA = "0x9AED", Offset = "0x9AED", VA = "0x9AED")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CAD")]
			[Address(RVA = "0x9AEE", Offset = "0x9AEE", VA = "0x9AEE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAE")]
		[Address(RVA = "0x9AEF", Offset = "0x9AEF", VA = "0x9AEF")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Bank_View_BankPromotionsView__Start(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int param2_00;
		  undefined4 uVar5;
		  int *piVar6;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a597a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankPromotionsView_PromotionViewOnInfoButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankPromotionView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankPromotionView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankPromotionView__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankPromotionView__GetEnumerator__);
		    DAT_ram_00a597a2 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x20),
		             Method_System_Collections_Generic_List_BankPromotionView__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BankPromotionView__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81068fc0:
		      iVar2 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar3) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar3 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x8106906f:
		          DAT_ram_009d3e38 = 0;
		          piVar6 = *(int **)(param1 + 0x18);
		          if (piVar6 != (int *)0x0) {
		            (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x130) * 4))
		                      (piVar6,*(undefined4 *)(*piVar6 + 0x134));
		          }
		          *(undefined4 *)(param1 + 0x18) = 0;
		          return;
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x374,&local_20);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar3 == 0) goto code_r0x8106906f;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = local_8._4_4_;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_PromotionsDic__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81068fb8:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81068fc0;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Bank_View_BankPromotionsView_PromotionViewOnInfoButtonClickedEvent__,
		               0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81068fb8;
		    if (DAT_ram_00a5979c == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_PromotionsDic__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81068fb8;
		      DAT_ram_00a5979c = '\x01';
		    }
		    iVar3 = *(int *)(iVar2 + 0x1c);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar5,0);
		      param3 = System_Action_PromotionsDic__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81068fa4:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81068fc0;
		      }
		      if (iVar4 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar4,
		                               System_Action_PromotionsDic__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81068fa4;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar4,param3);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81068fc0;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = func_ii_4329(iVar2 + 0x1c,param2_00,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81068fa4;
		      bVar1 = iVar3 != iVar4;
		      iVar3 = iVar4;
		    } while (bVar1);
		  } while( true );
		}
		*/

		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAF")]
		[Address(RVA = "0x9AF0", Offset = "0x9AF0", VA = "0x9AF0")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Bank_View_BankPromotionsView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  int param3_00;
		  int param2_00;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  undefined4 param2_01;
		  int iVar7;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a597a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankPromotionsView_PromotionViewOnInfoButtonClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_PromotionsDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_PromotionsDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_PromotionsDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankPromotionView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PromotionsDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BankPromotionView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a597a3 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param2,Method_System_Collections_Generic_List_PromotionsDic__GetEnumerator__)
		  ;
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_PromotionsDic__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81069625:
		      iVar7 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x810696b7:
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x378,&local_20);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
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
		    iVar7 = local_20;
		    if (iVar2 == 0) goto code_r0x810696b7;
		    uVar5 = *(undefined4 *)(param1 + 0x14);
		    uVar3 = local_8._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81069625;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x378,uVar5,
		                           Method_UnityEngine_Object_Instantiate_BankPromotionView___);
		    iVar2 = DAT_ram_009d3e38;
		    iVar7 = Method_System_Collections_Generic_List_BankPromotionView__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81069625;
		    }
		    iVar2 = *(int *)(param1 + 0x20);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar2 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar6 * 4 + 0x10) = param3_00;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,param3_00,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81069625;
		      }
		    }
		    param2_01 = *(undefined4 *)(param1 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,param3_00,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810695ff:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81069625;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x375,param2_01,uVar5,param3_00);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810695ff;
		    *(undefined4 *)(param3_00 + 0x20) = uVar3;
		    uVar5 = *(undefined4 *)(param3_00 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x376,uVar3,0)
		    ;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810695f5:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81069625;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x62,uVar5,uVar3,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810695f5;
		    piVar4 = *(int **)(param3_00 + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x377,
		                       *(undefined4 *)(param3_00 + 0x20),0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810695f5;
		    iVar7 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar7 + 0x2d0),piVar4,uVar3,*(undefined4 *)(iVar7 + 0x2d4));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810695f5;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_PromotionsDic__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810695eb:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81069625;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_Bank_View_BankPromotionsView_PromotionViewOnInfoButtonClickedEvent__,
		               0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810695eb;
		    if (DAT_ram_00a5979b == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_PromotionsDic__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810695eb;
		      DAT_ram_00a5979b = '\x01';
		    }
		    iVar7 = *(int *)(param3_00 + 0x1c);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar7,uVar3,0);
		      uVar5 = System_Action_PromotionsDic__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x810695d7:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81069625;
		      }
		      if (iVar2 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar2,
		                               System_Action_PromotionsDic__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x810695d7;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar2,uVar5);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81069625;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = func_ii_4329(param3_00 + 0x1c,param2_00,iVar7);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x810695d7;
		      bVar1 = iVar7 != iVar2;
		      iVar7 = iVar2;
		    } while (bVar1);
		  } while( true );
		}
		*/

		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB0")]
		[Address(RVA = "0x9AF1", Offset = "0x9AF1", VA = "0x9AF1")]
		public void ShowPromotions(List<PromotionsDic> promotions)
		{
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x9AF2", Offset = "0x9AF2", VA = "0x9AF2")]
		private void PromotionViewOnInfoButtonClickedEvent(PromotionsDic data)
		{
		/* --- GHIDRA: PromotionViewOnInfoButtonClickedEvent ---
		void Gameplay_Bank_View_BankPromotionsView__PromotionViewOnInfoButtonClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a597a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankPromotionView___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankPromotionView__TypeInfo);
		    DAT_ram_00a597a4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BankPromotionView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BankPromotionView___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x9AF3", Offset = "0x9AF3", VA = "0x9AF3")]
		public BankPromotionsView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Bank_View_BankPromotionsView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12571);
		    DAT_ram_00a597a5 = '\x01';
		  }
		  return StringLiteral_12571;
		}
		*/

		}

		// Token: 0x040029DC RID: 10716
		[Token(Token = "0x40029DC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BankGalleryView _bankGallery;

		// Token: 0x040029DD RID: 10717
		[Token(Token = "0x40029DD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BankPromotionView _promotionPrefab;

		// Token: 0x040029DE RID: 10718
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x18")]
		private BankPromotionsViewMediator _mediator;

		// Token: 0x040029E0 RID: 10720
		[Token(Token = "0x40029E0")]
		[FieldOffset(Offset = "0x20")]
		private List<BankPromotionView> _promotions;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ShowInfoEvent ---
		void Gameplay_Bank_View_BankPromotionsView__add_ShowInfoEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a597a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    DAT_ram_00a597a0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_PromotionsDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PromotionsDic__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_ShowInfoEvent ---
		void Gameplay_Bank_View_BankPromotionsView__remove_ShowInfoEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  
		  if (DAT_ram_00a597a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankPromotionsViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a597a1 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81068b03;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81068b03:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param2_00 = *(undefined4 *)(iVar4 + 0x2c);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81068bb2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81068bb2:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param3 = *(undefined4 *)(iVar4 + 0x28);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81068c61;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81068c61:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x24);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Bank_Controller_BankPromotionsViewMediator_TypeInfo);
		  if (DAT_ram_00a59800 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView___ctor__
		              );
		    DAT_ram_00a59800 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractViewMediator_BankModel__BankEvents__BankController__BankPromotionsView___ctor__
		            );
		  *(int **)(param1 + 0x18) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  return;
		}
		*/

}
