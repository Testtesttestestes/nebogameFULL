using System;
using Core.Gameplay.Managers.Ad.Placements.BankOptions;
using Gameplay.Bank.Controller;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C37 RID: 3127
	[Token(Token = "0x2000C37")]
	public class BankOptionAdPlacementView : MonoBehaviour
	{
		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F5C")]
		public Button WatchButton
		{
			[Token(Token = "0x6004C3C")]
			[Address(RVA = "0x9A7F", Offset = "0x9A7F", VA = "0x9A7F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F5D")]
		public GameObject LoadingGroup
		{
			[Token(Token = "0x6004C3D")]
			[Address(RVA = "0x9A80", Offset = "0x9A80", VA = "0x9A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x9A81", Offset = "0x9A81", VA = "0x9A81")]
		public void Init(BankOptionsAdPlacementManager manager, BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x9A82", Offset = "0x9A82", VA = "0x9A82")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_Bank_View_BankOptionAdPlacementView__Release
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int *param1_00;
		  undefined4 param4_00;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59767 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BankOptionsAdPlacementModel__BankOptionsAdPlacementController__BankOptionsAdPlacementEvents__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_TypeInfo);
		    DAT_ram_00a59767 = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 1;
		    param4_00 = *(undefined4 *)(param2 + 0x18);
		    param3_00 = *(undefined4 *)(param2 + 0x20);
		    param2_00 = *(undefined4 *)(param2 + 0x1c);
		    param1_00 = (int *)unnamed_function_1417
		                                 (
		                                 Gameplay_Bank_Controller_BankOptionAdPlacementViewMediator_TypeInfo
		                                 );
		    if (DAT_ram_00a597ed == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView___ctor__
		                );
		      DAT_ram_00a597ed = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3_00,param4_00,
		               Method_MVC_AbstractViewMediator_BankOptionsAdPlacementModel__BankOptionsAdPlacementEvents__BankOptionsAdPlacementController__BankOptionAdPlacementView___ctor__
		              );
		    param1_00[6] = param3;
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(int **)(param1 + 0x18) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x9A83", Offset = "0x9A83", VA = "0x9A83")]
		private void SetupMVC(BankOptionsAdPlacementManager manager, BankOptionData bankOptionData)
		{
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x9A84", Offset = "0x9A84", VA = "0x9A84")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x9A85", Offset = "0x9A85", VA = "0x9A85")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x9A86", Offset = "0x9A86", VA = "0x9A86")]
		public BankOptionAdPlacementView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_View_BankOptionAdPlacementView___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  undefined4 param3_00;
		  int local_2c;
		  int **local_28;
		  int *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59768 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtikulData__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtikulData__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArtikulData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtikulData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtikulView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27779);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1772);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3531);
		    DAT_ram_00a59768 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_c = 0;
		  local_18 = 0;
		  local_20 = 0;
		  iVar9 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar9 + 0x138) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(param2 + 8),*(undefined4 *)(iVar9 + 0x13c));
		  uVar6 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = Core_Data_ArtikulData__get_CurrentDurability(*(undefined4 *)(param2 + 8),0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar6,uVar1,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  piVar7 = *(int **)(param1 + 0x14);
		  uVar1 = Core_Data_ArtikulData__get_IsSellable(*(undefined4 *)(param2 + 8),0);
		  iVar9 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		            (piVar7,uVar1,*(undefined4 *)(iVar9 + 0x2d4));
		  piVar7 = *(int **)(param1 + 0x18);
		  iVar9 = **(int **)(param2 + 8);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0xe0) * 4))
		                    (*(int **)(param2 + 8),*(undefined4 *)(iVar9 + 0xe4));
		  uVar1 = Core_Data_Spells_AbstractSpellsBasedDescription___ctor(uVar1,0);
		  iVar9 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		            (piVar7,uVar1,*(undefined4 *)(iVar9 + 0x2d4));
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x1c),0);
		  local_24 = &local_8;
		  local_2c = 0;
		  local_28 = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81063a94;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81063cd7:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81063cdf;
		    }
		code_r0x81063a94:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81063cd7;
		    if (iVar9 == 0) goto code_r0x81063d28;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar9 + 200);
		          goto code_r0x81063b71;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81063cb9:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81063cdf;
		    }
		code_r0x81063b71:
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81063cb9;
		    if (piVar7 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar7 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar7 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                   UnityEngine_Transform_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81063cdf;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar7,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar1,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81063cdf:
		  iVar9 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar3) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar1);
		    local_2c = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x81063d28:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar7 = (int *)*local_24;
		      if (piVar7 != (int *)0x0) {
		        iVar9 = *piVar7;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		              puVar4 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x81063db8;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81063db8:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      }
		      if (local_2c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_2c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar9 = *(int *)(param2 + 0xc);
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x2c),0);
		      if (iVar9 == 0) {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar1,0,0);
		        return;
		      }
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		      piVar7 = *(int **)(param1 + 0x24);
		      uVar1 = Core_Data_ArtikulData__get_IsSellable(*(undefined4 *)(param2 + 8),0);
		      iVar9 = *piVar7;
		      (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		                (piVar7,uVar1,*(undefined4 *)(iVar9 + 0x2d4));
		      piVar7 = *(int **)(param1 + 0x28);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3531,1,0,1,0,0,0,0);
		      uVar5 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (uVar5,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar5,StringLiteral_21978,StringLiteral_1772,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      uVar1 = StringLiteral_27779;
		      if (*(int *)(param2 + 0xc) == 0) {
		        param3_00 = 0;
		      }
		      else {
		        local_c = *(undefined4 *)(*(int *)(param2 + 0xc) + 0xc);
		        param3_00 = func_ii_4443(&local_c,0);
		      }
		      System_Reflection_FieldInfo__get_IsStatic
		                (uVar5,uVar1,param3_00,
		                 Method_System_Collections_Generic_Dictionary_string__string__Add__);
		      uVar1 = Core_GameLocalization__GetTranslation(uVar6,uVar5,0);
		      iVar9 = *piVar7;
		      (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		                (piVar7,uVar1,*(undefined4 *)(iVar9 + 0x2d4));
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,*(undefined4 *)(param2 + 0xc),
		                 Method_System_Collections_Generic_List_ArtikulData__GetEnumerator__);
		      local_2c = 0;
		      local_28 = (int **)&local_20;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_ArtikulData__MoveNext__
		                          );
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81064094;
		        }
		        if (iVar3 == 0) goto code_r0x810640ea;
		        uVar6 = *(undefined4 *)(param1 + 0x1c);
		        uVar5 = *(undefined4 *)(param1 + 0x34);
		        uVar1 = local_18._4_4_;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81064094;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar7 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar5,
		                                   uVar6,Method_UnityEngine_Object_Instantiate_ArtikulView___);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81064094;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar7 + 0x138),piVar7,uVar1,*(undefined4 *)(*piVar7 + 0x13c));
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar9 != 1);
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81064094:
		      iVar9 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar3) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar1);
		        iVar3 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_2c = iVar3;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          if (iVar3 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x810640ea:
		          DAT_ram_009d3e38 = 0;
		          uVar1 = *(undefined4 *)(param1 + 0x30);
		          if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		          }
		          UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar1,0);
		          return;
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36e,&local_2c);
		      goto joined_r0x81064146;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36d,&local_2c);
		joined_r0x81064146:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400298A RID: 10634
		[Token(Token = "0x400298A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x0400298B RID: 10635
		[Token(Token = "0x400298B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _loadingGroup;

		// Token: 0x0400298C RID: 10636
		[Token(Token = "0x400298C")]
		[FieldOffset(Offset = "0x18")]
		private BankOptionAdPlacementViewMediator _mediator;

		// Token: 0x0400298D RID: 10637
		[Token(Token = "0x400298D")]
		[FieldOffset(Offset = "0x1C")]
		private bool _mvcSetup;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LoadingGroup ---
		void Gameplay_Bank_View_BankOptionAdPlacementView__get_LoadingGroup
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 0;
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  if (param2 != 0) {
		    Gameplay_Bank_View_BankOptionAdPlacementView__Release(param1,param2,param3,param1);
		  }
		  return;
		}
		*/

}
