using System;
using AssetContent;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View.MyBetsTab
{
	// Token: 0x020005C8 RID: 1480
	[Token(Token = "0x20005C8")]
	public class PortalsMyBetsView : MonoBehaviourWithStates<PortalsMyBetsView.State>
	{
		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069A")]
		public PortalsTotalizatorOSAView UsersOSAView
		{
			[Token(Token = "0x600237C")]
			[Address(RVA = "0x74CE", Offset = "0x74CE", VA = "0x74CE")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069B")]
		public TextMeshProUGUI BetNumber
		{
			[Token(Token = "0x600237D")]
			[Address(RVA = "0x74CF", Offset = "0x74CF", VA = "0x74CF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600237E RID: 9086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069C")]
		public Button AllBetsButton
		{
			[Token(Token = "0x600237E")]
			[Address(RVA = "0x74D0", Offset = "0x74D0", VA = "0x74D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069D")]
		public Transform MyBetsContainer
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0x74D1", Offset = "0x74D1", VA = "0x74D1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002380 RID: 9088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700069E")]
		public StageInPortalsMyBetsListElement MyBetsElementPrefab
		{
			[Token(Token = "0x6002380")]
			[Address(RVA = "0x74D2", Offset = "0x74D2", VA = "0x74D2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x74D3", Offset = "0x74D3", VA = "0x74D3")]
		public void Init(PortalsModel model)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Portals_View_MyBetsTab_PortalsMyBetsView__Init(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58112 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsMyBetsView_State___ctor__);
		    DAT_ram_00a58112 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_PortalsMyBetsView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x74D4", Offset = "0x74D4", VA = "0x74D4")]
		public PortalsMyBetsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_MyBetsTab_PortalsMyBetsView___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 param2_00;
		  int *piVar7;
		  int iVar8;
		  uint uVar9;
		  int local_24;
		  int **local_20;
		  int *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58113 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BetHistoryRow__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BetHistoryRow__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BetHistoryRow__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BetHistoryRow__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_PortalsMyBetsListElement___)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12151);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28637);
		    DAT_ram_00a58113 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_12151,1,0,1,0,0,0,0);
		  local_24 = *(int *)(param2 + 0x1c);
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_24);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28637,uVar1,uVar2,0);
		  iVar8 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),uVar1,*(undefined4 *)(iVar8 + 0x2d4));
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_1c = &local_8;
		  local_24 = 0;
		  local_20 = &local_4;
		  do {
		    do {
		      piVar5 = local_4;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		            puVar3 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80ea3ccf;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ea3d13:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ea3fe0;
		      }
		code_r0x80ea3ccf:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		      piVar5 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ea3d13;
		      if (iVar8 == 0) goto code_r0x80ea4029;
		      iVar8 = *local_4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		            puVar3 = (undefined4 *)(piVar7[1] * 8 + iVar8 + 200);
		            goto code_r0x80ea3db8;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ea3fa6:
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ea3fe0;
		      }
		code_r0x80ea3db8:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = (int *)import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ea3fa6;
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
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ea3fe0;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ea3fe0;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                         *(undefined4 *)(param1 + 0x18),0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ea3fe0;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10c,uVar1,uVar2,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ea3fe0;
		      }
		    } while (iVar4 != 0);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar1,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ea3fe0:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    local_24 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80ea4029:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_1c;
		      if (piVar5 != (int *)0x0) {
		        iVar8 = *piVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar9 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ea40b9;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80ea40b9:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_24 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_24);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_18,*(undefined4 *)(param2 + 0x20),
		                 Method_System_Collections_Generic_List_BetHistoryRow__GetEnumerator__);
		      local_24 = 0;
		      local_20 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_BetHistoryRow__MoveNext__
		                          );
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ea4277;
		        }
		        iVar8 = local_24;
		        if (iVar4 == 0) goto code_r0x80ea42c0;
		        uVar2 = *(undefined4 *)(param1 + 0x14);
		        param2_00 = *(undefined4 *)(param1 + 0x18);
		        uVar1 = local_10._4_4_;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80ea4277;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar2,
		                           Method_UnityEngine_Object_Instantiate_PortalsMyBetsListElement___);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ea4277;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10e,uVar2,uVar1,
		                   *(undefined4 *)(param2 + 0x24),*(undefined4 *)(param2 + 0x24));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar8 != 1);
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ea4277:
		      iVar8 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		        iVar8 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_24 = iVar8;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80ea42c0:
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10f,&local_24);
		      goto joined_r0x80ea430f;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10d,&local_24);
		joined_r0x80ea430f:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PortalsTotalizatorOSAView _usersOSAView;

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _betNumber;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _allBetsButton;

		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _myBetsContainer;

		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private StageInPortalsMyBetsListElement _myBetsElementPrefab;

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameRawImage _notAvailBanner;

		// Token: 0x020005C9 RID: 1481
		[Token(Token = "0x20005C9")]
		public enum State
		{
			// Token: 0x04001393 RID: 5011
			[Token(Token = "0x4001393")]
			UNKNOWN_STATE,
			// Token: 0x04001394 RID: 5012
			[Token(Token = "0x4001394")]
			HISTORY,
			// Token: 0x04001395 RID: 5013
			[Token(Token = "0x4001395")]
			BET_INFO,
			// Token: 0x04001396 RID: 5014
			[Token(Token = "0x4001396")]
			NOT_AVAIL
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MyBetsElementPrefab ---
		void Gameplay_Portals_View_MyBetsTab_PortalsMyBetsView__get_MyBetsElementPrefab
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58111 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalsTotalizatorViewsHolder__Init__
		              );
		    DAT_ram_00a58111 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  uVar1 = UnityEngine_Transform__set_parent(uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x1c),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalsTotalizatorViewsHolder__Init__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = Core_Extensions_Dict_PortalDicExt__GetMessage(*(undefined4 *)(param2 + 0x3c),0xdb,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		  return;
		}
		*/

}
