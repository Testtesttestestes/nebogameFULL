using System;
using Animations;
using AssetContent;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Gameplay.Combat.View.Players;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.TutorialCombatV2.View
{
	// Token: 0x02000446 RID: 1094
	[Token(Token = "0x2000446")]
	public class TutorialCombatView : OneOnOneCombatView
	{
		// Token: 0x060019C9 RID: 6601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x6B61", Offset = "0x6B61", VA = "0x6B61", Slot = "5")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a583ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialCombatV2_View_TutorialCombatView_HandleOnMouseDownEvent__);
		    DAT_ram_00a583ea = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_BaseGameFieldMono__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialCombatV2_View_TutorialCombatView_HandleOnMouseDownEvent__,0);
		  Gameplay_Combat_View_GameField_BaseGameFieldMono__remove_SwapEvent(param1_01,param1_00,0);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1a0);
		        goto code_r0x80ee2a93;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1c);
		code_r0x80ee2a93:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80ee2b17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_Tutorial_ITutorialManager_TypeInfo,2);
		code_r0x80ee2b17:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x6B62", Offset = "0x6B62", VA = "0x6B62", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__Start
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,*(undefined4 *)(*param1 + 0x114));
		  return;
		}
		*/

		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x6B63", Offset = "0x6B63", VA = "0x6B63")]
		private void HandleOnMouseDownEvent(BaseGameFieldMono obj)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700048B")]
		public InIdleOutSpineAnimation ResultAnimation
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x6B64", Offset = "0x6B64", VA = "0x6B64")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x6B65", Offset = "0x6B65", VA = "0x6B65", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
		/* --- GHIDRA: ShowGameOverView ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__ShowGameOverView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a583eb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22554);
		    DAT_ram_00a583eb = '\x01';
		  }
		  param1_00 = *(int *)(*(int *)(param1 + 0x80) + 0x14);
		  *(undefined1 *)(param1_00 + 0x45) = 0;
		  AssetContent_GameAnimationView__OnDestroy(param1_00,StringLiteral_22554,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x6B66", Offset = "0x6B66", VA = "0x6B66", Slot = "14")]
		protected override void ShowOpponentDeath(ICombatPLayerView player)
		{
		/* --- GHIDRA: ShowOpponentDeath ---
		int Gameplay_TutorialCombatV2_View_TutorialCombatView__ShowOpponentDeath
		              (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a583ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_InIdleOutSpineAnimation___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17762);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10333);
		    DAT_ram_00a583ec = '\x01';
		  }
		  iVar4 = 0x74;
		  if (param2 == 0) {
		    iVar4 = 0x78;
		  }
		  uVar1 = *(undefined4 *)(param1 + iVar4);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = func_ii_6805(uVar1,param3,Method_UnityEngine_Object_Instantiate_InIdleOutSpineAnimation___
		                      );
		  piVar2 = *(int **)(iVar4 + 0x1c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  puVar3 = &StringLiteral_17762;
		  if (param2 == 0) {
		    puVar3 = &StringLiteral_10333;
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(*puVar3,1,0,1,0,0,0,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar1,1,0,1,0,0,0,0);
		  iVar5 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar5 + 0x2d4));
		  Animations_InIdleOutSpineAnimation__get_Particles(iVar4,0);
		  return iVar4;
		}
		*/

		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x6B67", Offset = "0x6B67", VA = "0x6B67")]
		private InIdleOutSpineAnimation CreateWinOrLoseAnimation(bool isWin, Transform parent)
		{
		/* --- GHIDRA: CreateWinOrLoseAnimation ---
		/* WARNING: Removing unreachable block (ram,0x80ee3164) */
		
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__CreateWinOrLoseAnimation
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int param2_00;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int iVar12;
		  int iVar13;
		  int *piVar14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar10 = 0;
		  if (DAT_ram_00a583ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_Point___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Point___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Point___);
		    Mono_Security_ASN1__get_Item(&System_Func_Point__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_Point__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Point__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Point__RemoveAll__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_Point__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_0__HideExcessFields_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_0__HideExcessFields_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_1__HideExcessFields_b__2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_1__HideExcessFields_b__3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_1_TypeInfo);
		    DAT_ram_00a583ed = '\x01';
		  }
		  local_4 = (int *)0x0;
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 0x14) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  uVar3 = func_ii_7394(param1,*(undefined4 *)(param2 + 0xc),0);
		  *(undefined4 *)(param2_00 + 0x10) = uVar3;
		  uVar3 = func_ii_7394(param1,*(undefined4 *)(*(int *)(param2_00 + 0x14) + 0x10),0);
		  *(undefined4 *)(param2_00 + 0xc) = uVar3;
		  uVar3 = System_Linq_Enumerable__Select_object__object_
		                    (*(undefined4 *)(*(int *)(param2_00 + 0x14) + 0x14),
		                     Method_System_Linq_Enumerable_ToList_Point___);
		  uVar4 = unnamed_function_1417(System_Predicate_Point__TypeInfo);
		  func_ii_7297(uVar4,param2_00,
		               Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_0__HideExcessFields_b__0__
		               ,0);
		  System_Collections_Generic_List_object___IsCompatibleObject
		            (uVar3,uVar4,Method_System_Collections_Generic_List_Point__RemoveAll__);
		  uVar4 = unnamed_function_1417(System_Func_Point__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,param2_00,
		             Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_0__HideExcessFields_b__1__
		             ,0);
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar4,Method_System_Linq_Enumerable_Where_Point___);
		  iVar5 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_Point___);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      iVar9 = *(int *)(iVar5 + iVar10 * 4 + 0x10);
		      iVar6 = unnamed_function_1417
		                        (
		                        Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_1_TypeInfo
		                        );
		      *(int *)(iVar6 + 0xc) = param2_00;
		      iVar11 = *(int *)(iVar9 + 0xc);
		      iVar12 = *(int *)(*(int *)(param2_00 + 0x14) + 0xc);
		      iVar13 = *(int *)(iVar12 + 0xc);
		      *(int *)(iVar6 + 8) = iVar11 - iVar13;
		      puVar2 = &
		               Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_1__HideExcessFields_b__2__
		      ;
		      if (iVar11 == iVar13) {
		        *(int *)(iVar6 + 8) = *(int *)(iVar9 + 0x10) - *(int *)(iVar12 + 0x10);
		        puVar2 = (undefined4 *)
		                 &
		                 Method_Gameplay_TutorialCombatV2_View_TutorialCombatView___c__DisplayClass14_1__HideExcessFields_b__3__
		        ;
		      }
		      uVar4 = unnamed_function_1417(System_Func_Point__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator(uVar4,iVar6,*puVar2,0);
		      piVar7 = (int *)System_Linq_Enumerable__Where_PlayerLoopSystem_
		                                (uVar3,uVar4,Method_System_Linq_Enumerable_Where_Point___);
		      iVar6 = *piVar7;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar14 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerable_Point__TypeInfo == *piVar14) {
		            puVar8 = (uint *)(iVar6 + piVar14[1] * 8 + 0xc0);
		            goto code_r0x80ee2f25;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar8 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_IEnumerable_Point__TypeInfo,0)
		      ;
		code_r0x80ee2f25:
		      local_4 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        piVar7 = local_4;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		              puVar2 = (undefined4 *)(iVar6 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80ee2fe5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x80ee2fe5:
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		        piVar7 = local_4;
		        if (DAT_ram_009d3e38 == 1) break;
		        if (iVar6 == 0) {
		          iVar6 = 0;
		          goto code_r0x80ee31f1;
		        }
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_Point__TypeInfo == *piVar14) {
		              puVar2 = (undefined4 *)(iVar6 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80ee30bf;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_Point__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x80ee30bf:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii(*puVar2,piVar7,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        iVar6 = func_ii_7394(param1,uVar4,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,
		                   *(undefined4 *)(*(int *)(param1 + 0x7c) + iVar6 * 4 + 0x10),0,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar6 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 != iVar9) {
		code_r0x80ee3296:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x15e,&local_c);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 != 1) {
		          import::env::__resumeException(uVar4);
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
		      piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		      iVar6 = *piVar7;
		      DAT_ram_009d3e38 = 0;
		      local_c = iVar6;
		      import::env::invoke_v(0x123);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x80ee3296;
		      }
		code_r0x80ee31f1:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar14 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_IDisposable_TypeInfo == *piVar14) {
		              puVar8 = (uint *)(iVar9 + piVar14[1] * 8 + 0xc0);
		              goto code_r0x80ee3265;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ee3265:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar10 = iVar10 + 1;
		    } while (iVar10 < *(int *)(iVar5 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x6B68", Offset = "0x6B68", VA = "0x6B68")]
		private void HideExcessFields(ProtoShowHintEvt msg)
		{
		/* --- GHIDRA: HideExcessFields ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__HideExcessFields
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  Gameplay_Combat_View_AbstractCombatView__GetPlayer(param1,0);
		  iVar2 = *(int *)(param1 + 0x7c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x6B69", Offset = "0x6B69", VA = "0x6B69", Slot = "10")]
		public override void HideHint()
		{
		/* --- GHIDRA: HideHint ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__HideHint
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_7394(param1,param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x7c) + iVar1 * 4 + 0x10),1,0);
		  return;
		}
		*/

		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x6B6A", Offset = "0x6B6A", VA = "0x6B6A")]
		private void ShowFieldGlow(Point point)
		{
		/* --- GHIDRA: ShowFieldGlow ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__ShowFieldGlow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_7394(param1,param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x7c) + iVar1 * 4 + 0x10),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x6B6B", Offset = "0x6B6B", VA = "0x6B6B")]
		private void HideFieldGlow(Point point)
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x6B6C", Offset = "0x6B6C", VA = "0x6B6C")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatView__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a583ee == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a583ee = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x70);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(iVar3 + iVar1 * 4 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		      if (iVar2 != 0) {
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (param1_00,0,0);
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x6B6D", Offset = "0x6B6D", VA = "0x6B6D")]
		private void OnDisable()
		{
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x6B6E", Offset = "0x6B6E", VA = "0x6B6E")]
		public TutorialCombatView()
		{
		}

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _otherViewParts;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private WinCombatGameOverAnimation _winAnimation;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InIdleOutSpineAnimation _loseAnimation;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private GameObject[] _turnHintCells;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _opponentView;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x84")]
		private InIdleOutSpineAnimation _resultAnimation;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ResultAnimation ---
		undefined4
		Gameplay_TutorialCombatV2_View_TutorialCombatView__get_ResultAnimation
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return 0;
		}
		*/

}
