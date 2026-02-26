using System;
using Core.Data.InfoRows;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using UI.Requirements;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	public class ArtifactInformationBox : MonoBehaviour
	{
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000793")]
		public IItemInformationProvider Data
		{
			[Token(Token = "0x60027F4")]
			[Address(RVA = "0x791A", Offset = "0x791A", VA = "0x791A")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027F5")]
			[Address(RVA = "0x791B", Offset = "0x791B", VA = "0x791B")]
			set
			{
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x2147", Offset = "0x2147", VA = "0x2147")]
		private ArtifactInformationBox.RowPrefabConfig GetRowPrefab(InformationRowTypes type)
		{
			return null;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x791C", Offset = "0x791C", VA = "0x791C")]
		private void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a0ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RequirementsView___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5a0ca = '\x01';
		  }
		  local_8 = 0;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(uVar2,0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    do {
		      do {
		        do {
		          piVar5 = local_4;
		          iVar7 = *local_4;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                puVar3 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		                goto code_r0x811be375;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811be817:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811be829;
		          }
		code_r0x811be375:
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		          piVar5 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811be817;
		          if (iVar7 == 0) goto code_r0x811be872;
		          iVar7 = *local_4;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		                puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		                goto code_r0x811be466;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,1);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811be6df:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811be829;
		          }
		code_r0x811be466:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = (int *)import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811be6df;
		          if (piVar5 != (int *)0x0) {
		            if (((uint)*(byte *)(*piVar5 + 0xb8) <
		                 (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		               (*(int *)(*(int *)(*piVar5 + 100) +
		                         (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		                UnityEngine_Transform_TypeInfo)) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                         UnityEngine_Transform_TypeInfo);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) {
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811be829;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811be829;
		          }
		          uVar8 = *(undefined4 *)(param1 + 0x1c);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       UnityEngine_Object_TypeInfo);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811be829;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,uVar2,uVar8,0);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811be829;
		          }
		        } while (iVar4 != 0);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811be829;
		        }
		        uVar8 = *(undefined4 *)(param1 + 0x24);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811be829;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,uVar2,uVar8,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811be829;
		        }
		      } while (iVar4 != 0);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x267,piVar5,
		                         Method_UnityEngine_Component_GetComponent_RequirementsView___);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811be6d5:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811be829;
		      }
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811be6d5;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3e6,uVar2,0,0);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811be829;
		      }
		    } while (iVar4 == 0);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
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
		code_r0x811be829:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x811be872:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811be902;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x811be902:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_14);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x242,&local_14);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

		// Token: 0x060027F8 RID: 10232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x791D", Offset = "0x791D", VA = "0x791D")]
		public void ResetInfo()
		{
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x791E", Offset = "0x791E", VA = "0x791E")]
		public ArtifactInformationBox()
		{
		}

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected ArtifactInformationBox.RowPrefabConfig[] _prefabsByTypes;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameObject _separatorPrefab;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RequirementsView _requirementsView;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected GameObject _requirementsViewSeparator;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected RequirementsView _targetRequirementsView;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameObject _targetRequirementsViewSeparator;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x28")]
		private IItemInformationProvider _data;

		// Token: 0x02000670 RID: 1648
		[Token(Token = "0x2000670")]
		[Serializable]
		public class RowPrefabConfig
		{
			// Token: 0x060027FA RID: 10234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027FA")]
			[Address(RVA = "0x791F", Offset = "0x791F", VA = "0x791F")]
			public RowPrefabConfig()
			{
			}

			// Token: 0x040015FE RID: 5630
			[Token(Token = "0x40015FE")]
			[FieldOffset(Offset = "0x8")]
			public InformationRowTypes Type;

			// Token: 0x040015FF RID: 5631
			[Token(Token = "0x40015FF")]
			[FieldOffset(Offset = "0xC")]
			public TitleRowView Prefab;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x28)) {
		    *(int *)(param1 + 0x28) = param2;
		    Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__set_Data(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Inventory_View_Info_InfoBox_ArtifactInformationBox__set_Data
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  undefined4 param4;
		  int *piVar13;
		  uint param2_00;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar12 = 0;
		  if (DAT_ram_00a5a0c9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IInformationRow__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IInformationRow__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IInformationRow__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IInformationRow__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameObject___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TitleRowView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_UserInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13143);
		    DAT_ram_00a5a0c9 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  piVar10 = *(int **)(param1 + 0x28);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 200);
		        goto code_r0x811beaa3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,1);
		code_r0x811beaa3:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar3,Method_System_Collections_Generic_List_IInformationRow__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_IInformationRow__MoveNext__
		                        );
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811bf04f;
		      }
		      if (iVar4 == 0) goto code_r0x811bf0a5;
		      piVar10 = local_8._4_4_;
		      if (local_8._4_4_ != (int *)0x0) break;
		      uVar6 = *(undefined4 *)(param1 + 0x14);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,param1,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811bf01f:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811bf04f;
		      }
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811bf01f;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar6,uVar3,
		                 Method_UnityEngine_Object_Instantiate_GameObject___);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811bf04f;
		      }
		    }
		    iVar11 = *local_8._4_4_;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (Core_Data_InfoRows_IInformationRow_TypeInfo == *piVar13) {
		          puVar5 = (undefined4 *)(iVar11 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x811bebf4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Core_Data_InfoRows_IInformationRow_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811bee10:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		code_r0x811bebf4:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811bee10;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x243,param1,uVar3,param1);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		    uVar6 = *(undefined4 *)(iVar4 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,param1,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811bee24:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811bee24;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar6,uVar3,
		                       Method_UnityEngine_Object_Instantiate_TitleRowView___);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		    iVar11 = *piVar10;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		        if (Core_Data_InfoRows_IInformationRow_TypeInfo == *piVar13) {
		          puVar5 = (undefined4 *)(iVar11 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x811beda4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                        Core_Data_InfoRows_IInformationRow_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811bee38:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		code_r0x811beda4:
		    DAT_ram_009d3e38 = 0;
		    iVar11 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811bee38;
		    if (iVar11 != 1) {
		      iVar11 = *piVar10;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		          if (Core_Data_InfoRows_IInformationRow_TypeInfo == *piVar13) {
		            puVar5 = (undefined4 *)(iVar11 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x811beead;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                          Core_Data_InfoRows_IInformationRow_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x811beead:
		        DAT_ram_009d3e38 = 0;
		        iVar11 = import::env::invoke_iii(*puVar5,piVar10,puVar5[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          if (iVar11 == 2) goto code_r0x811beef2;
		          goto code_r0x811bef2a;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		code_r0x811beef2:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x79,uVar3,iVar12,0);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811bf04f;
		    }
		    iVar12 = iVar12 + 1;
		code_r0x811bef2a:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x80,uVar3,piVar10,0)
		    ;
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar11 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811bf04f:
		  iVar12 = global_1;
		  iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar12 == iVar11) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar11 = *piVar10;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar11;
		    import::env::invoke_v(0x123);
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 != 1) {
		      if (iVar11 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x811bf0a5:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = 0;
		      piVar10 = *(int **)(param1 + 0x28);
		      iVar12 = *piVar10;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x811bf117;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar10,
		                                    Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf117:
		      iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		      iVar12 = *(int *)(iVar12 + 0x20);
		      uVar1 = 0;
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		      param2_00 = (uint)(iVar12 != 0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,param2_00,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x1c),param2_00,0);
		      piVar10 = *(int **)(param1 + 0x28);
		      iVar11 = *piVar10;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		            ;
		            goto code_r0x811bf1c4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar10,
		                                    Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf1c4:
		      iVar11 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		      iVar11 = *(int *)(iVar11 + 0x24);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x20),0);
		      uVar1 = (uint)(iVar11 != 0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,uVar1,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x24),uVar1,0);
		      if (iVar12 != 0) {
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (*(undefined4 *)(param1 + 0x18),0);
		        UnityEngine_Transform__get_childCount(uVar3,0);
		        uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x1c),0);
		        UnityEngine_Transform__get_childCount(uVar3,0);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf2d0;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf2d0:
		        uVar1 = 0;
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf355;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf355:
		        uVar1 = 0;
		        uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf3da;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf3da:
		        uVar1 = 0;
		        uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf45f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf45f:
		        uVar1 = 0;
		        uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf4e4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf4e4:
		        iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar9 = *(undefined4 *)(*(int *)(iVar12 + 0x20) + 0x10);
		        uVar1 = 0;
		        iVar12 = unnamed_function_1417
		                           (
		                           Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo
		                           );
		        Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		                  (iVar12,uVar7,uVar8,uVar9,0);
		        uVar7 = unnamed_function_1417
		                          (
		                          Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		                          );
		        *(undefined4 *)(iVar12 + 0x10) = uVar7;
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar4 = *piVar10;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811bf598;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf598:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar7 = *(undefined4 *)(*(int *)(iVar4 + 0x20) + 0x18);
		        uVar1 = 0;
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar4 = *piVar10;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811bf623;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf623:
		        iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar8 = *(undefined4 *)(*(int *)(iVar4 + 0x20) + 0x14);
		        uVar1 = 0;
		        iVar4 = unnamed_function_1417
		                          (
		                          Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle_TypeInfo
		                          );
		        Core_Gameplay_Managers_Requirements_Custom_RequirementsInfoProviderWhitCommonTitle__get_Title
		                  (iVar4,uVar3,uVar6,iVar12,uVar7,uVar8,0);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf6cb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf6cb:
		        iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar3 = Core_Extensions_Dict_ArtikulOptionsDicExt__GetEventPromoDescription
		                          (*(undefined4 *)(iVar12 + 0xc),0);
		        *(undefined4 *)(iVar4 + 0x30) = uVar3;
		        uVar3 = unnamed_function_1417
		                          (
		                          Core_Gameplay_Managers_Requirements_ListFillBehaviors_ListFillBehaviorWhitOutSeparation_TypeInfo
		                          );
		        *(undefined4 *)(iVar4 + 0x10) = uVar3;
		        UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x18),iVar4,0);
		      }
		      if (iVar11 != 0) {
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (*(undefined4 *)(param1 + 0x20),0);
		        UnityEngine_Transform__get_childCount(uVar3,0);
		        uVar3 = UnityEngine_UI_Selectable__set_interactable(*(undefined4 *)(param1 + 0x24),0);
		        UnityEngine_Transform__get_childCount(uVar3,0);
		        uVar3 = unnamed_function_1417(Protocol_Common_UserInfo_TypeInfo);
		        Protocol_Common_UserInfo__pb__Google_Protobuf_IMessage_get_Descriptor(uVar3,0);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar10 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 + iVar12 +
		                               0x178);
		              goto code_r0x811bf7da;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811bf7da:
		        uVar1 = 0;
		        uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar3 = Core_Data_UserData__get_IsSigninConfirmed(uVar3,uVar6,0);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf867;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf867:
		        uVar1 = 0;
		        uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf8ec;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf8ec:
		        uVar1 = 0;
		        uVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Core_Data_InfoRows_IInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf971;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,Core_Data_InfoRows_IInformationProvider_TypeInfo,0);
		code_r0x811bf971:
		        uVar1 = 0;
		        uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bf9f6;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bf9f6:
		        iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        param4 = *(undefined4 *)(*(int *)(iVar12 + 0x24) + 0x10);
		        uVar1 = 0;
		        uVar9 = unnamed_function_1417
		                          (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo
		                          );
		        Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		                  (uVar9,uVar7,uVar8,param4,0);
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bfa9a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bfa9a:
		        iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar7 = *(undefined4 *)(*(int *)(iVar12 + 0x24) + 0x18);
		        uVar1 = 0;
		        piVar10 = *(int **)(param1 + 0x28);
		        iVar12 = *piVar10;
		        if (*(ushort *)(iVar12 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo ==
		                *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811bfb25;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar10,
		                                      Gameplay_Inventory_Model_IItemInformationProvider_TypeInfo,0);
		code_r0x811bfb25:
		        iVar12 = (**(code **)((ulonglong)*puVar2 * 4))(piVar10,puVar2[1]);
		        uVar8 = *(undefined4 *)(*(int *)(iVar12 + 0x24) + 0x14);
		        iVar12 = unnamed_function_1417
		                           (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		        Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		                  (iVar12,uVar3,uVar6,uVar9,uVar7,uVar8,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = func_ii_7508(StringLiteral_13143,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar12 + 0x24) = uVar3;
		        UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x20),iVar12,0);
		      }
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x244,&local_20);
		  iVar12 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar12 != 1) {
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
