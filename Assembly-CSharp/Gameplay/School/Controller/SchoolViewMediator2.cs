using System;
using Gameplay.MageSchool.Events;
using Gameplay.School.Model;
using Il2CppDummyDll;
using MVC;
using UI.Windows;
using UI.Windows.Buildings.MageSchoolWindow;

namespace Gameplay.School.Controller
{
	// Token: 0x0200064D RID: 1613
	[Token(Token = "0x200064D")]
	public class SchoolViewMediator2 : AbstractViewMediator<SchoolModel, SchoolEvents, SchoolController, SchoolWindow2>
	{
		// Token: 0x17000760 RID: 1888
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000760")]
		public override SchoolEvents Events
		{
			[Token(Token = "0x6002724")]
			[Address(RVA = "0x7858", Offset = "0x7858", VA = "0x7858", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000761 RID: 1889
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000761")]
		public override SchoolWindow2 View
		{
			[Token(Token = "0x6002725")]
			[Address(RVA = "0x7859", Offset = "0x7859", VA = "0x7859", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x785A", Offset = "0x785A", VA = "0x785A")]
		public SchoolViewMediator2(SchoolModel model, SchoolEvents events, SchoolController controller)
		{
		/* --- GHIDRA: <ShowConfirmCancelImproveSpell>b__19_0 ---
		void Gameplay_School_Controller_SchoolViewMediator2___ShowConfirmCancelImproveSpell_b__19_0
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a07a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo);
		    DAT_ram_00a5a07a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo);
		  **(undefined4 **)(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_School_Controller_SchoolViewMediator2___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_School_Controller_SchoolViewMediator2__SpellInfoButtonClickedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x785B", Offset = "0x785B", VA = "0x785B")]
		private void OnInitEvent()
		{
		/* --- GHIDRA: OnInitEvent ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnInitEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int param1_00;
		  uint *puVar3;
		  undefined4 param1_01;
		  int iVar4;
		  int *param1_02;
		  
		  if (DAT_ram_00a5a06f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    DAT_ram_00a5a06f = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 8) + 0x20);
		  uVar2 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                    (param1 + 0x20,Method_System_Nullable_uint__get_Value__);
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (param1_01,uVar2,
		                         Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                        );
		  if (*(int *)(param1_00 + 0x30) == 0) {
		    UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow__Show(param1_00,0);
		    return;
		  }
		  iVar4 = *(int *)(param1 + 8);
		  if (DAT_ram_00a5a050 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a5a050 = '\x01';
		  }
		  param1_02 = *(int **)(iVar4 + 0x10);
		  iVar4 = *param1_02;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811bd36a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_02,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811bd36a:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_02,puVar3[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetItemQuality
		                    (uVar2,*(undefined4 *)(*(int *)(param1_00 + 0x30) + 0xc),0);
		  UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow__HandleContent
		            (param1_00,uVar2,*(undefined4 *)(param1_00 + 0x30),0);
		  return;
		}
		*/

		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x785C", Offset = "0x785C", VA = "0x785C")]
		private void SpellInfoButtonClickedEventHandler()
		{
		/* --- GHIDRA: SpellInfoButtonClickedEventHandler ---
		void Gameplay_School_Controller_SchoolViewMediator2__SpellInfoButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a070 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_SchoolSpellData__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_SchoolSpellData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_SchoolSpellData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItemArgs__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItemArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SpellItemArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellListArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolViewMediator2___c__InitSpells_b__10_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo);
		    DAT_ram_00a5a070 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_SpellItemArgs__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_SpellItemArgs___ctor__);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_SpellItemArgs__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_SpellItemArgs___ctor__);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1[2] + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Values__
		                    );
		  if (*(int *)(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo + 0x5c);
		  iVar8 = puVar7[1];
		  if (iVar8 == 0) {
		    if (*(int *)(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo);
		      puVar7 = *(undefined4 **)(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo + 0x5c);
		    }
		    uVar9 = *puVar7;
		    iVar8 = unnamed_function_1417(System_Func_SchoolSpellData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar8,uVar9,
		               Method_Gameplay_School_Controller_SchoolViewMediator2___c__InitSpells_b__10_0__,0);
		    *(int *)(*(int *)(Gameplay_School_Controller_SchoolViewMediator2___c_TypeInfo + 0x5c) + 4) =
		         iVar8;
		  }
		  uVar1 = 0;
		  piVar4 = (int *)System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                            (uVar3,iVar8,
		                             Method_System_Linq_Enumerable_OrderBy_SchoolSpellData__uint___);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_SchoolSpellData__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811bcc34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,
		                                System_Collections_Generic_IEnumerable_SchoolSpellData__TypeInfo,0);
		code_r0x811bcc34:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x811bcc59:
		  do {
		    piVar4 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x811bcd03;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811bcd4b:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bd09a;
		    }
		code_r0x811bcd03:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar7,piVar4,puVar7[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811bcd4b;
		    if (iVar8 == 0) {
		      iVar8 = 6;
		      goto code_r0x811bd0e7;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_SchoolSpellData__TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x811bcdf6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_SchoolSpellData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811bcedb:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bd09a;
		    }
		code_r0x811bcdf6:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar7,piVar4,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811bcedb;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = func_ii_8514(uVar3,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bd09a;
		    }
		    if (iVar6 != 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x240,iVar8,uVar3,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(undefined4 *)(iVar8 + 0x1c) = *(undefined4 *)(param1[2] + 0xc);
		          iVar6 = Method_System_Collections_Generic_List_SpellItemArgs__Add__;
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar1 = *(uint *)(param1_00 + 0xc);
		          if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		            *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = iVar8;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,iVar8,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811bd09a;
		            }
		          }
		          goto code_r0x811bcc59;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bd09a;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811bd04b:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bd09a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x240,iVar8,uVar3,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811bd04b;
		    *(undefined4 *)(iVar8 + 0x1c) = *(undefined4 *)(param1[2] + 0xc);
		    iVar6 = Method_System_Collections_Generic_List_SpellItemArgs__Add__;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar8;
		      goto code_r0x811bcc59;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811bd09a:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar4;
		    iVar8 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x811bd0e7:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = *local_8;
		      if (piVar4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *piVar4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811bd162;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x811bd162:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (local_c == 0) {
		        if ((iVar8 == 0) ||
		           ((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) &&
		            (((iVar8 != 4 && (iVar8 != 5)) && (iVar8 == 6)))))) {
		          iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          uVar9 = *(undefined4 *)(iVar8 + 0x3c);
		          uVar3 = unnamed_function_1417(UI_Elements_Buildings_SpellListArgs_TypeInfo);
		          UI_Elements_Buildings_SpellListArgs___ctor(uVar3,iVar2,0);
		          UI_Elements_GenericList_SelectorGenericList_object__object__object___get_SelectedIndex
		                    (uVar9,uVar3,
		                     Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__set_Data__
		                    );
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          uVar9 = *(undefined4 *)(iVar2 + 0x40);
		          uVar3 = unnamed_function_1417(UI_Elements_Buildings_SpellListArgs_TypeInfo);
		          UI_Elements_Buildings_SpellListArgs___ctor(uVar3,param1_00,0);
		          UI_Elements_GenericList_SelectorGenericList_object__object__object___get_SelectedIndex
		                    (uVar9,uVar3,
		                     Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__set_Data__
		                    );
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x241,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
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

		// Token: 0x06002729 RID: 10025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x785D", Offset = "0x785D", VA = "0x785D")]
		private void InitSpells()
		{
		/* --- GHIDRA: InitSpells ---
		void Gameplay_School_Controller_SchoolViewMediator2__InitSpells
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5a071 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_SpellItemArgs___);
		    Mono_Security_ASN1__get_Item(&System_Func_SpellItemArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericList_SpellListArgs__SpellItem__SpellItemArgs__UpdateElement__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_SpellListArgs__SpellItem__SpellItemArgs__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass11_0__UpdateSpell_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass11_0__UpdateSpell_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass11_0_TypeInfo);
		    DAT_ram_00a5a071 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass11_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1[2] + 0x20),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                        );
		  iVar1 = func_ii_8514(param1_00,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*param1 + 0x15c);
		  uVar4 = *(uint *)(*param1 + 0x158);
		  if (iVar1 == 0) {
		    uVar5 = *(undefined4 *)(iVar2 + 0x3c);
		    iVar1 = (**(code **)((ulonglong)uVar4 * 4))(param1,uVar3);
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x3c) + 0x28) + 8);
		    uVar3 = unnamed_function_1417(System_Func_SpellItemArgs__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,param2_00,
		               Method_Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass11_0__UpdateSpell_b__1__
		               ,0);
		    iVar1 = func_ii_7423(uVar6,uVar3,Method_System_Linq_Enumerable_First_SpellItemArgs___);
		    uVar3 = *(undefined4 *)(iVar1 + 8);
		    iVar1 = unnamed_function_1417(UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Core_Data_Spells_SpellData__get_IsCultSpell(iVar1,param1_00,0);
		    *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(param1[2] + 0xc);
		    UI_Elements_GenericList_GenericList_object__object__object___UpdateElement
		              (uVar5,uVar3,iVar1,
		               Method_UI_Elements_GenericList_GenericList_SpellListArgs__SpellItem__SpellItemArgs__UpdateElement__
		              );
		  }
		  else {
		    uVar5 = *(undefined4 *)(iVar2 + 0x40);
		    iVar1 = (**(code **)((ulonglong)uVar4 * 4))(param1,uVar3);
		    uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x40) + 0x28) + 8);
		    uVar3 = unnamed_function_1417(System_Func_SpellItemArgs__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,param2_00,
		               Method_Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass11_0__UpdateSpell_b__0__
		               ,0);
		    iVar1 = func_ii_7423(uVar6,uVar3,Method_System_Linq_Enumerable_First_SpellItemArgs___);
		    uVar3 = *(undefined4 *)(iVar1 + 8);
		    iVar1 = unnamed_function_1417(UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Core_Data_Spells_SpellData__get_IsCultSpell(iVar1,param1_00,0);
		    *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(param1[2] + 0xc);
		    UI_Elements_GenericList_GenericList_object__object__object___UpdateElement
		              (uVar5,uVar3,iVar1,
		               Method_UI_Elements_GenericList_GenericList_SpellListArgs__SpellItem__SpellItemArgs__UpdateElement__
		              );
		  }
		  if (((*(ulonglong *)(param1 + 8) & 0xff) != 0) &&
		     (iVar1 = (int)(*(ulonglong *)(param1 + 8) >> 0x20), *(int *)(param2_00 + 8) == iVar1)) {
		    Gameplay_School_Controller_SchoolViewMediator2__OnCancelSpellClicked(param1,iVar1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x785E", Offset = "0x785E", VA = "0x785E")]
		private void UpdateSpell(uint spellId)
		{
		/* --- GHIDRA: UpdateSpell ---
		void Gameplay_School_Controller_SchoolViewMediator2__UpdateSpell
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 auStack_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a072 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    DAT_ram_00a5a072 = '\x01';
		  }
		  local_8 = 0;
		  System_Data_SqlTypes_SqlInt32___ctor(&local_8,param2,Method_System_Nullable_uint___ctor__);
		  *(undefined8 *)(param1 + 0x20) = local_8;
		  Gameplay_School_Controller_SchoolViewMediator2__InitSpells(param1,param2,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x785F", Offset = "0x785F", VA = "0x785F")]
		private void OnSelectSpell(uint spellId)
		{
		/* --- GHIDRA: OnSelectSpell ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnSelectSpell
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a073 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		    DAT_ram_00a5a073 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),2,
		             Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x48),2,
		             Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x7860", Offset = "0x7860", VA = "0x7860")]
		private void OnDeselectSpell(uint spellId)
		{
		/* --- GHIDRA: OnDeselectSpell ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnDeselectSpell(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a073 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		    DAT_ram_00a5a073 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x44),2,
		             Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__set_CurrentState__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x48),2,
		             Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x7861", Offset = "0x7861", VA = "0x7861")]
		private void ShowEmptyInfo()
		{
		/* --- GHIDRA: ShowEmptyInfo ---
		void Gameplay_School_Controller_SchoolViewMediator2__ShowEmptyInfo(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a074 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    DAT_ram_00a5a074 = '\x01';
		  }
		  if ((char)param1[8] != '\0') {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		    param2_00 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                          (param1 + 8,Method_System_Nullable_uint__get_Value__);
		    Gameplay_School_Controller_SchoolController__OnLearnSpellCanceledEvent
		              (param1_00,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x7862", Offset = "0x7862", VA = "0x7862")]
		private void OnLearnSpellClicked()
		{
		/* --- GHIDRA: OnLearnSpellClicked ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnLearnSpellClicked
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a075 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    DAT_ram_00a5a075 = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) != '\0') {
		    param1_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x20);
		    uVar1 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (param1 + 0x20,Method_System_Nullable_uint__get_Value__);
		    uVar1 = System_Collections_Generic_List_object___get_Item
		                      (param1_00,uVar1,
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    Gameplay_School_Controller_SchoolViewMediator2__ShowConfirmCancelImproveSpell
		              (param1,uVar1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x7863", Offset = "0x7863", VA = "0x7863")]
		private void OnBoostSpellClicked()
		{
		/* --- GHIDRA: OnBoostSpellClicked ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnBoostSpellClicked
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a076 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_Value__);
		    DAT_ram_00a5a076 = '\x01';
		  }
		  if (*(char *)(param1 + 0x20) != '\0') {
		    param1_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x20);
		    uVar1 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (param1 + 0x20,Method_System_Nullable_uint__get_Value__);
		    uVar1 = System_Collections_Generic_List_object___get_Item
		                      (param1_00,uVar1,
		                       Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                      );
		    Gameplay_School_Controller_SchoolViewMediator2__UpdateState(param1,uVar1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x7864", Offset = "0x7864", VA = "0x7864")]
		private void OnCancelSpellClicked()
		{
		/* --- GHIDRA: OnCancelSpellClicked ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnCancelSpellClicked
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  uint *puVar2;
		  undefined4 param3_00;
		  int iVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  uint uVar4;
		  
		  if (DAT_ram_00a5a077 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    DAT_ram_00a5a077 = '\x01';
		  }
		  if (((*(ulonglong *)(param1 + 8) & 0xff) != 0) &&
		     ((int)(*(ulonglong *)(param1 + 8) >> 0x20) == param2)) {
		    param2_00 = System_Collections_Generic_List_object___get_Item
		                          (*(undefined4 *)(param1[2] + 0x20),param2,
		                           Method_System_Collections_Generic_Dictionary_uint__SchoolSpellData__get_Item__
		                          );
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Windows_Buildings_ShopWindow_ShopWindow_ShopWindowArgs___ctor
		              (*(undefined4 *)(iVar1 + 0x44),param2_00,0);
		    iVar3 = *(int *)(param2_00 + 0x30);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar1 + 0x48);
		    if (iVar3 == 0) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1_00,2,
		                 Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		      return;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar4 = 0;
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *param1_01;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar4 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar4 * 8 + 4) * 8 + iVar1 + 0x160);
		          goto code_r0x811bd71b;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar4);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x811bd71b:
		    param3_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__ButtonClickedEventHandler
		              (param1_00,param2_00,param3_00,*(undefined4 *)(param1[2] + 8),
		               *(undefined4 *)(param1[2] + 0x14),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x7865", Offset = "0x7865", VA = "0x7865")]
		private void UpdateState(uint spellId)
		{
		/* --- GHIDRA: UpdateState ---
		undefined4
		Gameplay_School_Controller_SchoolViewMediator2__UpdateState
		          (int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  int param1_01;
		  int param1_02;
		  double param2_00;
		  undefined4 *puVar6;
		  int param1_03;
		  uint uVar7;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a078 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__SchoolSpellData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_School_Controller_SchoolViewMediator2__ShowConfirmCancelImproveSpell_b__19_0__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13733);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13734);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26445);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13732);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4111);
		    DAT_ram_00a5a078 = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c));
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))(param1,uVar1);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param2 + 0x114));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))(param2,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Protocol_Common_ResourceSet___ctor(uVar3,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		            (piVar2,CONCAT44(uVar5,*(undefined4 *)(*piVar2 + 0x104)));
		  param2_00 = Gameplay_School_Model_SchoolModel__set_Spells(param2,param2);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__Round(uVar3,param2_00,0);
		  uVar5 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar3,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                    (param2,CONCAT44(uVar5,*(undefined4 *)(*param2 + 0xf4)));
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar6 = &StringLiteral_13732;
		  if (iVar4 == 0) {
		    puVar6 = &StringLiteral_13734;
		  }
		  uVar5 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  puVar6 = &StringLiteral_4111;
		  if (iVar4 == 0) {
		    puVar6 = &StringLiteral_13733;
		  }
		  param1_00 = func_ii_7508(*puVar6,1,0,1,0,0,0,0);
		  param1_01 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_01,0);
		  *(undefined4 *)(param1_01 + 0x18) = uVar5;
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar5 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar3,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26445,uVar5,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_8;
		  uVar5 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar4,0);
		  *(undefined4 *)(param1_01 + 0x1c) = uVar5;
		  param1_03 = *(int *)(param1_01 + 0x24);
		  param1_02 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_02,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar5 = UI_Windows_DialogWindow__get_WindowId(0);
		  *(undefined4 *)(param1_02 + 8) = uVar5;
		  iVar4 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		                    );
		  *(int **)(iVar4 + 0xc) = param2;
		  uVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__SchoolSpellData__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar5,param1,
		             Method_Gameplay_School_Controller_SchoolViewMediator2__ShowConfirmCancelImproveSpell_b__19_0__
		             ,0);
		  *(undefined4 *)(iVar4 + 0x10) = uVar5;
		  *(int *)(param1_02 + 0x14) = iVar4;
		  iVar4 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_03 + 0x10) = *(int *)(param1_03 + 0x10) + 1;
		  uVar7 = *(uint *)(param1_03 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(param1_03 + 8) + 0xc)) {
		    *(uint *)(param1_03 + 0xc) = uVar7 + 1;
		    *(int *)(*(int *)(param1_03 + 8) + uVar7 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_03,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar5 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_01,0);
		  return uVar5;
		}
		*/

		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x7866", Offset = "0x7866", VA = "0x7866")]
		private DialogWindow ShowConfirmCancelImproveSpell(SchoolSpellData spell)
		{
		/* --- GHIDRA: ShowConfirmCancelImproveSpell ---
		undefined4
		Gameplay_School_Controller_SchoolViewMediator2__ShowConfirmCancelImproveSpell
		          (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int param2_00;
		  int iVar2;
		  float fVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  double param3_00;
		  int *param1_00;
		  int iVar6;
		  uint uVar7;
		  undefined4 param1_01;
		  double param4;
		  uint uVar8;
		  
		  if (DAT_ram_00a5a079 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass20_0__ShowAccelerateImproveSpell_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass20_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a5a079 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass20_0_TypeInfo
		                        );
		  *(int **)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0xf4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))(param2,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  fVar3 = func_ii_7103(*(undefined4 *)(*(int *)(param2_00 + 0xc) + 0x38),0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar7 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x811bda12;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811bda12:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar5,puVar4[1]));
		  uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		  param3_00 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar5,StringLiteral_25458,0);
		  param4 = *(double *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x14) + 0x78) + 0x18);
		  uVar5 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar5,param2_00,
		             Method_Gameplay_School_Controller_SchoolViewMediator2___c__DisplayClass20_0__ShowAccelerateImproveSpell_b__0__
		             ,0);
		  fVar3 = CEIL(fVar3);
		  if (fVar3 < 4.2949673e+09 && 0.0 <= fVar3) {
		    uVar7 = (uint)fVar3;
		  }
		  else {
		    uVar7 = 0;
		  }
		  param1_01 = 3;
		  if (iVar2 == 0) {
		    param1_01 = 1;
		  }
		  if (ABS(fVar3) < 2.1474836e+09) {
		    uVar8 = (uint)fVar3;
		  }
		  else {
		    uVar8 = 0x80000000;
		  }
		  if (0.0 <= fVar3) {
		    uVar8 = uVar7;
		  }
		  uVar5 = UI_Windows_Alert_AlertArgs___ctor(param1_01,(double)uVar8,param3_00,param4,uVar5,0);
		  return uVar5;
		}
		*/

			return null;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x7867", Offset = "0x7867", VA = "0x7867")]
		private BaseWindow ShowAccelerateImproveSpell(SchoolSpellData spell)
		{
			return null;
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x7868", Offset = "0x7868", VA = "0x7868")]
		private void OnWindowClose()
		{
		/* --- GHIDRA: OnWindowClose ---
		void Gameplay_School_Controller_SchoolViewMediator2__OnWindowClose
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param2_00 = UnityEngine_AndroidJavaObject___GetRawObject(param3,0);
		  Gameplay_School_Controller_SchoolController__HandleAccelerateLearnSpellService
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0400156A RID: 5482
		[Token(Token = "0x400156A")]
		[FieldOffset(Offset = "0x18")]
		private string MAGE_SCHOOL_NEUTRAL_SPELLS;

		// Token: 0x0400156B RID: 5483
		[Token(Token = "0x400156B")]
		[FieldOffset(Offset = "0x1C")]
		private string MAGE_SCHOOL_SPECIAL_SPELLS;

		// Token: 0x0400156C RID: 5484
		[Token(Token = "0x400156C")]
		[FieldOffset(Offset = "0x20")]
		private uint? _selectedSpell;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_School_Controller_SchoolViewMediator2__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a06d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolViewMediator2_OnBoostSpellClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolViewMediator2_OnDeselectSpell__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolViewMediator2_OnLearnSpellClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolViewMediator2_OnSelectSpell__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolViewMediator2_OnWindowClose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_School_Controller_SchoolViewMediator2_SpellInfoButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a06d = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__BindCallbacks
		              (*(undefined4 *)(iVar2 + 0x48),0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_School_Controller_SchoolViewMediator2_OnWindowClose__,0)
		    ;
		    UI_Windows_BaseWindow__add_onClose(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,Method_Gameplay_School_Controller_SchoolViewMediator2_OnSelectSpell__
		                  ,0);
		    UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__add_OnSelectSpell(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_School_Controller_SchoolViewMediator2_OnDeselectSpell__,0);
		    UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__add_OnDeselectSpell(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_School_Controller_SchoolViewMediator2_SpellInfoButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x48);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_School_Controller_SchoolViewMediator2_OnLearnSpellClicked__,0);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_School_Controller_SchoolViewMediator2_OnBoostSpellClicked__,0);
		    UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfo__ResolveButtonState
		              (param1_00,uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,Method_Gameplay_School_Controller_SchoolViewMediator2_OnWindowClose__,0)
		    ;
		    UI_Windows_BaseWindow__get_IsActiveResourceBar(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,Method_Gameplay_School_Controller_SchoolViewMediator2_OnSelectSpell__
		                  ,0);
		    UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__get_WindowId(uVar1,uVar3,0);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_School_Controller_SchoolViewMediator2_OnDeselectSpell__,0);
		    UI_Windows_Buildings_MageSchoolWindow_SchoolWindow2__remove_OnSelectSpell(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_School_Controller_SchoolViewMediator2_SpellInfoButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = *(undefined4 *)(iVar2 + 0x3c);
		    iVar2 = param1[6];
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(iVar2,1,0,1,0,0,0,0);
		    UI_Elements_Buildings_SpellList__get_Title(uVar1,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x40);
		    uVar1 = func_ii_7508(param1[7],1,0,1,0,0,0,0);
		    UI_Elements_Buildings_SpellList__get_Title(uVar3,uVar1,0);
		    if (DAT_ram_00a5a073 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__set_CurrentState__);
		      Mono_Security_ASN1__get_Item
		                (&Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		      DAT_ram_00a5a073 = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x44),2,
		               Method_UI_MonoBehaviourWithStates_BasicSpellInfo_State__set_CurrentState__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x48),2,
		               Method_UI_MonoBehaviourWithStates_SpellUpgradeInfo_State__set_CurrentState__);
		    if (*(int *)(param1[2] + 8) == *(int *)(param1[2] + 0x14)) {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_School_Controller_SchoolController__ValidateInit(uVar1,param1);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_School_Controller_SchoolViewMediator2__set_View
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a5a06e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_13725);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13727);
		    DAT_ram_00a5a06e = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = StringLiteral_13725;
		  *(undefined4 *)(param1 + 0x1c) = StringLiteral_13727;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_SchoolModel__SchoolEvents__SchoolController__SchoolWindow2___ctor__
		            );
		  return;
		}
		*/

}
