using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C80 RID: 3200
	[Token(Token = "0x2000C80")]
	public class AuchanActionInfoDisplay : MonoBehaviourWithStates<AuchanActionInfoDisplay.State>
	{
		// Token: 0x06004E19 RID: 19993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x9C4C", Offset = "0x9C4C", VA = "0x9C4C")]
		private void Awake()
		{
		/* --- GHIDRA: <Awake>b__13_0 ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay___Awake_b__13_0(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59842 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_AuchanArtifactView___);
		    DAT_ram_00a59842 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellViewsHolder__InitWithExistingRootPrefab
		            (param1,0);
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_AuchanArtifactView___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Awake ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay__Awake(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5983d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_View_AuchanActionInfoDisplay_HandleItemBought__);
		    DAT_ram_00a5983d = '\x01';
		  }
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4),0);
		  param1_02 = *(undefined4 *)
		               (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Gameplay_Auchan_View_AuchanActionInfoDisplay_HandleItemBought__
		             ,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)
		     (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10) =
		           param1_01, *param1_01 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x9C4D", Offset = "0x9C4D", VA = "0x9C4D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5983e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5983e = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x48);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x81078407;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Inventory_View_IArtifactView_TypeInfo,6);
		code_r0x81078407:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (iVar4 != 0) {
		    uVar1 = 0;
		    param1_00 = *(undefined4 *)(param1 + 0x2c);
		    piVar3 = *(int **)(param1 + 0x48);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		          goto code_r0x81078493;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Inventory_View_IArtifactView_TypeInfo,6);
		code_r0x81078493:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x81078517;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,1);
		code_r0x81078517:
		    local_4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    param2_00 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x9C4E", Offset = "0x9C4E", VA = "0x9C4E")]
		private void HandleItemBought()
		{
		/* --- GHIDRA: HandleItemBought ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay__HandleItemBought
		               (int param1,int *param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  int *param1_00;
		  undefined4 uVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  double param3_00;
		  int *piVar12;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5983f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_IActionInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AuchanActionInfoDisplay_State__set_CurrentState__)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2774);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2776);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2772);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2777);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2773);
		    DAT_ram_00a5983f = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  *(int **)(param1 + 0x48) = param2;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xf0);
		        goto code_r0x8107866f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,6);
		code_r0x8107866f:
		  uVar1 = 0;
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd0);
		        goto code_r0x810786f1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x810786f1:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (piVar3 == (int *)0x0) {
		    uVar4 = func_ii_7954(uVar4,0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    param1_00 = (int *)Core_Money_Money__op_Explicit(uVar4,0);
		  }
		  else {
		    uVar1 = 0;
		    iVar10 = *piVar3;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8);
		          goto code_r0x81078793;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,3);
		code_r0x81078793:
		    uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    iVar10 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar8,0);
		    if (iVar10 == 0) {
		code_r0x81078ec6:
		      uVar4 = func_ii_7954(uVar4,0);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      param1_00 = (int *)Core_Money_Money__op_Explicit(uVar4,0);
		    }
		    else {
		      iVar10 = *piVar3;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8)
		            ;
		            goto code_r0x8107881a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,3);
		code_r0x8107881a:
		      uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      piVar5 = (int *)Core_Money_Money__GetEnumerator(uVar8,0);
		      if (piVar5 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(Core_Money_Money_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar5 + 100) + (uint)*(byte *)(Core_Money_Money_TypeInfo + 0xb8) * 4
		                    + -4) != Core_Money_Money_TypeInfo)) {
		          System_Activator__CreateInstance(piVar5,Core_Money_Money_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      iVar10 = *piVar3;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8)
		            ;
		            goto code_r0x810788d7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,3);
		code_r0x810788d7:
		      local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      local_10 = 0;
		      local_c = &local_4;
		      do {
		        do {
		          param1_00 = piVar5;
		          piVar5 = local_4;
		          iVar10 = *local_4;
		          if (*(ushort *)(iVar10 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		                puVar6 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		                goto code_r0x810789ab;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar6 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x810789f7:
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81078de1;
		          }
		code_r0x810789ab:
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_iii(*puVar6,piVar5,puVar6[1]);
		          piVar5 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810789f7;
		          if (iVar10 == 0) {
		            iVar9 = 9;
		            iVar10 = 0;
		            goto code_r0x81078e2c;
		          }
		          iVar10 = *local_4;
		          if (*(ushort *)(iVar10 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar12) {
		                puVar6 = (undefined4 *)(iVar10 + piVar12[1] * 8 + 0xc0);
		                goto code_r0x81078a9c;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar6 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x81078d90:
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81078de1;
		          }
		code_r0x81078a9c:
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_iii(*puVar6,piVar5,puVar6[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x81078d90;
		          piVar5 = param1_00;
		        } while (*(double *)(iVar10 + 0x10) <= 0.0);
		        iVar10 = *(int *)(iVar10 + 8);
		        if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Money_Money_MoneyType_TypeInfo);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81078de1;
		          }
		        }
		        if (iVar10 != *(int *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x18)) {
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                             &System_NotSupportedException_TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            uVar8 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,uVar8);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              uVar7 = import::env::invoke_ii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                 &StringLiteral_3289);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1f8,uVar8,uVar7,0);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  uVar7 = import::env::invoke_ii
		                                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                                     &Method_Gameplay_Auchan_View_AuchanActionInfoDisplay_Init__);
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_vii(0x41b,uVar8,uVar7);
		                    if (DAT_ram_009d3e38 != 1) {
		                      do {
		                        halt_trap();
		                      } while( true );
		                    }
		                  }
		                }
		              }
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81078de1;
		        }
		        if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Money_Money_MoneyType_TypeInfo);
		          iVar10 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar10 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81078de1;
		          }
		          iVar10 = *(int *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x18);
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar11 = func_ii_7954(uVar4,0);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81078de1;
		        }
		        param3_00 = *(double *)(iVar11 + 0x28);
		        if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Money_Money_TypeInfo);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81078de1;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iidi
		                                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x10,iVar10,
		                                   param3_00,0);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar10 != 1);
		      uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81078de1:
		      iVar10 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar10 != iVar9) {
		code_r0x81078fc8:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x11,&local_10);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5 = (int *)import::env::__cxa_begin_catch(uVar8);
		      iVar10 = *piVar5;
		      iVar9 = 0;
		      DAT_ram_009d3e38 = 0;
		      local_10 = iVar10;
		      import::env::invoke_v(0x123);
		      iVar11 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar11 == 1) {
		        uVar8 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x81078fc8;
		      }
		code_r0x81078e2c:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar11 = *local_4;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x81078ea4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81078ea4:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar9 == 0) goto code_r0x81078ec6;
		      if (iVar9 == 1) {
		        return;
		      }
		      if (iVar9 == 2) {
		        return;
		      }
		      if (iVar9 == 3) {
		        return;
		      }
		      if (iVar9 == 4) {
		        return;
		      }
		      if (iVar9 == 5) {
		        return;
		      }
		      if (iVar9 == 6) {
		        return;
		      }
		      if (iVar9 == 7) {
		        return;
		      }
		      if (iVar9 == 8) {
		        return;
		      }
		      if (iVar9 != 9) {
		        return;
		      }
		    }
		    uVar1 = 0;
		    iVar10 = *piVar3;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8);
		          goto code_r0x81078f61;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,3);
		code_r0x81078f61:
		    uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    iVar10 = Core_Money_Money__get_IsEmpty(param1_00,uVar4,0);
		    if (iVar10 != 0) {
		      uVar1 = 0;
		      uVar4 = *(undefined4 *)(param1 + 0x2c);
		      iVar10 = *piVar3;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		            goto code_r0x810790a4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,1);
		code_r0x810790a4:
		      local_8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      uVar1 = 0;
		      uVar8 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		      uVar4 = *(undefined4 *)(param1 + 0x38);
		      iVar10 = *piVar3;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8)
		            ;
		            goto code_r0x8107913d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,3);
		code_r0x8107913d:
		      uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      UI_Price_Price__SetColor(uVar4,param4,uVar8,0);
		      uVar4 = *(undefined4 *)(param1 + 0x30);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2774,1,0,1,0,0,0,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		      goto code_r0x81079191;
		    }
		  }
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x38),param4,param1_00,0);
		  uVar4 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2776,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,0,0);
		code_r0x81079191:
		  uVar4 = *(undefined4 *)(param1 + 0x2c);
		  if (piVar3 == (int *)0x0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2772,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    uVar8 = *(undefined4 *)(param1 + 0x30);
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2776,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar4,0);
		  }
		  else {
		    uVar1 = 0;
		    iVar10 = *piVar3;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Protocol_IActionInfo_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		          goto code_r0x81079284;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Protocol_IActionInfo_TypeInfo,1);
		code_r0x81079284:
		    local_8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar1 = 0;
		    uVar8 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		    piVar3 = *(int **)(param1 + 0x48);
		    iVar10 = *piVar3;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xf8);
		          goto code_r0x81079319;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Inventory_View_IArtifactView_TypeInfo,7);
		code_r0x81079319:
		    iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar10 == 0) {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x28),0,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x20),1,0);
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,0,0);
		    }
		    else {
		      uVar1 = 0;
		      uVar4 = *(undefined4 *)(param1 + 0x24);
		      piVar3 = *(int **)(param1 + 0x48);
		      iVar10 = *piVar3;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xf8)
		            ;
		            goto code_r0x810793a5;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar3,Gameplay_Inventory_View_IArtifactView_TypeInfo,7);
		code_r0x810793a5:
		      uVar8 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		      UI_Elements_RightPanel_TitleWithLevel__set_Level(uVar4,uVar8,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x28),1,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x20),0,0);
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		    }
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2777,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		  uVar8 = *(undefined4 *)(param1 + 0x34);
		  uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2773,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar4,0);
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x3c),param4,param1_00,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar10 = 0;
		  iVar9 = UnityEngine_Component__GetComponent_object_(param3,0);
		  iVar11 = *(int *)(param1 + 0x44);
		  if (iVar9 == 0) {
		    if (0 < *(int *)(iVar11 + 0xc)) {
		      do {
		        uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar11 + iVar10 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar4,0,0);
		        iVar10 = iVar10 + 1;
		      } while (iVar10 < *(int *)(iVar11 + 0xc));
		    }
		  }
		  else if (0 < *(int *)(iVar11 + 0xc)) {
		    do {
		      uVar8 = *(undefined4 *)(iVar11 + iVar10 * 4 + 0x10);
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar8,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      func_ii_7050(uVar8,*(undefined4 *)(param3 + 0x80),0);
		      uVar4 = UnityEngine_Awaitable___c____cctor_b__76_1(param3,0);
		      UnityEngine_Object__op_Implicit(uVar8,uVar4,0);
		      iVar10 = iVar10 + 1;
		    } while (iVar10 < *(int *)(iVar11 + 0xc));
		  }
		  UI_Price_Price__SetColor(*(undefined4 *)(*(int *)(param1 + 0x40) + 0xb8),param4,param1_00,0);
		  uVar4 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x40),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar8 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar8,0);
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x100);
		        goto code_r0x8107961f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,8);
		code_r0x8107961f:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar4,
		             Method_UI_MonoBehaviourWithStates_AuchanActionInfoDisplay_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x9C4F", Offset = "0x9C4F", VA = "0x9C4F")]
		public void Init(IArtifactView artifactData, Image marker, UserData user)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay__Init(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x28),param2 ^ 1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x20),param2,0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x9C50", Offset = "0x9C50", VA = "0x9C50")]
		private void SetIndefiniteTime(bool isIndefinite)
		{
		/* --- GHIDRA: SetIndefiniteTime ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay__SetIndefiniteTime
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59840 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AuchanActionInfoDisplay_State___ctor__);
		    DAT_ram_00a59840 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_AuchanActionInfoDisplay_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x9C51", Offset = "0x9C51", VA = "0x9C51")]
		public AuchanActionInfoDisplay()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_View_AuchanActionInfoDisplay___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59841 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a59841 = '\x01';
		  }
		  if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		  }
		  uVar2 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		  UnityEngine_EventSystems_EventSystem__get_baseEventDataCache(uVar2,0,0);
		  piVar4 = *(int **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		  iVar5 = piVar4[2];
		  if (iVar5 != 0) {
		    piVar4 = *(int **)(param1 + 0x48);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x81079794;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x81079794:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),uVar2,*(undefined4 *)(iVar5 + 0x14));
		    piVar4 = *(int **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		  }
		  iVar5 = *piVar4;
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param1 + 0x48),
		               *(undefined4 *)(iVar5 + 0x14));
		    piVar4 = *(int **)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c);
		  }
		  iVar5 = piVar4[1];
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param1 + 0x48),
		               *(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002A9A RID: 10906
		[Token(Token = "0x4002A9A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _timeText;

		// Token: 0x04002A9B RID: 10907
		[Token(Token = "0x4002A9B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _indefinetelyText;

		// Token: 0x04002A9C RID: 10908
		[Token(Token = "0x4002A9C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x04002A9D RID: 10909
		[Token(Token = "0x4002A9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _timeBg;

		// Token: 0x04002A9E RID: 10910
		[Token(Token = "0x4002A9E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _left;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _oldPriceText;

		// Token: 0x04002AA0 RID: 10912
		[Token(Token = "0x4002AA0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _newPriceText;

		// Token: 0x04002AA1 RID: 10913
		[Token(Token = "0x4002AA1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Price _oldPrice;

		// Token: 0x04002AA2 RID: 10914
		[Token(Token = "0x4002AA2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _newPrice;

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Image[] _markers;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x48")]
		private IArtifactView _artifactView;

		// Token: 0x02000C81 RID: 3201
		[Token(Token = "0x2000C81")]
		public enum State
		{
			// Token: 0x04002AA7 RID: 10919
			[Token(Token = "0x4002AA7")]
			UNKNOWN_STATE,
			// Token: 0x04002AA8 RID: 10920
			[Token(Token = "0x4002AA8")]
			MARKET_ITEM
		}
	}
}
