using System;
using Gameplay.BlitzTournament.Controller;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;
using TMPro;
using UI;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC7 RID: 3015
	[Token(Token = "0x2000BC7")]
	public class BlitzTournamentProgressWindow : ClosableBaseWindow<BlitzTournamentProgressWindow.BlitzTournamentProgressWindowArgs>
	{
		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEC")]
		public override string WindowId
		{
			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x984D", Offset = "0x984D", VA = "0x984D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x060049E4 RID: 18916 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EED")]
		public BacktimeViewUGUI Timer
		{
			[Token(Token = "0x60049E4")]
			[Address(RVA = "0x984E", Offset = "0x984E", VA = "0x984E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060049E5 RID: 18917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEE")]
		public TextMeshProUGUI TournamentStatus
		{
			[Token(Token = "0x60049E5")]
			[Address(RVA = "0x984F", Offset = "0x984F", VA = "0x984F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEF")]
		public TextMeshProUGUI RoundStatus
		{
			[Token(Token = "0x60049E6")]
			[Address(RVA = "0x9850", Offset = "0x9850", VA = "0x9850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060049E7 RID: 18919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF0")]
		public BlitzTournamentBracketInfoBox InfoBox
		{
			[Token(Token = "0x60049E7")]
			[Address(RVA = "0x9851", Offset = "0x9851", VA = "0x9851")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF1")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x60049E8")]
			[Address(RVA = "0x9852", Offset = "0x9852", VA = "0x9852")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060049E9 RID: 18921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF2")]
		public Button RulesButton
		{
			[Token(Token = "0x60049E9")]
			[Address(RVA = "0x9853", Offset = "0x9853", VA = "0x9853")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EA")]
		[Address(RVA = "0x9854", Offset = "0x9854", VA = "0x9854")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6089d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__OnShow_b__30_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6089d = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__OnShow__
		              );
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x68) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__OnShow_b__30_0__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__ShowWinPage(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060049EB RID: 18923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EB")]
		[Address(RVA = "0x9855", Offset = "0x9855", VA = "0x9855", Slot = "22")]
		protected override void OnShow(BlitzTournamentProgressWindow.BlitzTournamentProgressWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		int * Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__OnShow
		                (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 param1_00;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a6089e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_View_BattleInfoListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BattleInfoListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BattleInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BattleInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a6089e = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x54),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar8 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81cf2cd3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cf2f16:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cf2f1e;
		    }
		code_r0x81cf2cd3:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cf2f16;
		    if (iVar8 == 0) goto code_r0x81cf2f67;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(piVar7[1] * 8 + iVar8 + 200);
		          goto code_r0x81cf2db0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81cf2ef8:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cf2f1e;
		    }
		code_r0x81cf2db0:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81cf2ef8;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
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
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81cf2f1e;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cf2f1e:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x81cf2f67:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar8 = *piVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81cf2ff7;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x81cf2ff7:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                                (Gameplay_BlitzTournament_View_BattleInfoListElement___TypeInfo,
		                                 *(undefined4 *)(*(int *)(param2 + 0x24) + 0xc));
		      if (0 < *(int *)(*(int *)(param2 + 0x24) + 0xc)) {
		        iVar8 = 0;
		        do {
		          uVar3 = *(undefined4 *)(param1 + 0x54);
		          param1_00 = *(undefined4 *)(param1 + 0x3c);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          piVar7 = (int *)func_ii_6805(param1_00,uVar3,
		                                       Method_UnityEngine_Object_Instantiate_BattleInfoListElement___
		                                      );
		          uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (*(undefined4 *)(param2 + 0x24),iVar8,
		                             Method_Google_Protobuf_Collections_RepeatedField_BattleInfo__get_Item__
		                            );
		          (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe8) * 4))
		                    (piVar7,uVar3,*(undefined4 *)(*piVar7 + 0xec));
		          iVar4 = func_ii_1082(piVar7,*(undefined4 *)(*piVar5 + 0x20));
		          if (iVar4 == 0) {
		            uVar3 = func_ii_1083();
		            func_ii_1050(uVar3,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          piVar5[iVar8 + 4] = (int)piVar7;
		          iVar8 = iVar8 + 1;
		        } while (iVar8 < *(int *)(*(int *)(param2 + 0x24) + 0xc));
		      }
		      return piVar5;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 10,&local_14);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
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
		*/

		}

		// Token: 0x060049EC RID: 18924 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60049EC")]
		[Address(RVA = "0x9856", Offset = "0x9856", VA = "0x9856")]
		public BattleInfoListElement[] Init(ProtoGetTournamentInfoAns.Types.TournamentInfo tournamentInfo)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6089f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3615);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3611);
		    DAT_ram_00a6089f = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x48),0,0);
		  uVar2 = *(undefined4 *)(param1 + 100);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3615,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x68),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3611,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x4c),1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049ED")]
		[Address(RVA = "0x9857", Offset = "0x9857", VA = "0x9857")]
		public void ShowLosePage()
		{
		/* --- GHIDRA: ShowLosePage ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__ShowLosePage
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a608a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3613);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3620);
		    DAT_ram_00a608a0 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x48),0,0);
		  uVar2 = *(undefined4 *)(param1 + 100);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3620,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x68),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3613,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x4c),1,0);
		  return;
		}
		*/

		}

		// Token: 0x060049EE RID: 18926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EE")]
		[Address(RVA = "0x9858", Offset = "0x9858", VA = "0x9858")]
		public void ShowWinPage()
		{
		/* --- GHIDRA: ShowWinPage ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__ShowWinPage
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  undefined4 param4;
		  int iVar2;
		  
		  if (DAT_ram_00a608a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_TypeInfo);
		    DAT_ram_00a608a1 = '\x01';
		  }
		  if (*(char *)(param1 + 0x70) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = **(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                          (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = **(int **)(iVar1 + 0x18);
		    param3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                       (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(undefined4 *)(iVar1 + 0x18);
		    param1_00 = (int *)unnamed_function_1417
		                                 (
		                                 Gameplay_BlitzTournament_Controller_BlitzTournamentProgressMediator_TypeInfo
		                                 );
		    if (DAT_ram_00a608cd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow___ctor__
		                );
		      Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_View_BattleInfoListElement___TypeInfo);
		      DAT_ram_00a608cd = '\x01';
		    }
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (Gameplay_BlitzTournament_View_BattleInfoListElement___TypeInfo,0);
		    param1_00[6] = iVar1;
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentProgressWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x70) = 1;
		    *(int **)(param1 + 0x6c) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060049EF RID: 18927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049EF")]
		[Address(RVA = "0x9859", Offset = "0x9859", VA = "0x9859")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__SetupMVC
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x70) != '\0') {
		    iVar1 = **(int **)(param1 + 0x6c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x6c) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F0")]
		[Address(RVA = "0x985A", Offset = "0x985A", VA = "0x985A")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a608a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs___ctor__
		              );
		    DAT_ram_00a608a2 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_BlitzTournamentProgressWindow_BlitzTournamentProgressWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F1")]
		[Address(RVA = "0x985B", Offset = "0x985B", VA = "0x985B")]
		public BlitzTournamentProgressWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/BlitzTournament/BlitzTournamentProgressWindow";

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BattleInfoListElement _listElementPrefab;

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BlitzTournamentBracketInfoBox _infoBox;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04002833 RID: 10291
		[Token(Token = "0x4002833")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _generalPage;

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameObject _endPage;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x54")]
		[Header("General page")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _tournamentStatus;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _roundStatus;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[FieldOffset(Offset = "0x64")]
		[Header("End page")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		[FieldOffset(Offset = "0x6C")]
		private BlitzTournamentProgressMediator _mediator;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x70")]
		private bool _mvcSetUp;

		// Token: 0x02000BC8 RID: 3016
		[Token(Token = "0x2000BC8")]
		public class BlitzTournamentProgressWindowArgs : BaseWindowArgs
		{
			// Token: 0x060049F3 RID: 18931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049F3")]
			[Address(RVA = "0x985D", Offset = "0x985D", VA = "0x985D")]
			public BlitzTournamentProgressWindowArgs()
			{
			}

			// Token: 0x0400283E RID: 10302
			[Token(Token = "0x400283E")]
			[FieldOffset(Offset = "0x18")]
			public BlitzTournamentController Controller;

			// Token: 0x0400283F RID: 10303
			[Token(Token = "0x400283F")]
			[FieldOffset(Offset = "0x1C")]
			public BlitzTournamentWindow.WindowState WindowState;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RulesButton ---
		void Gameplay_BlitzTournament_View_BlitzTournamentProgressWindow__get_RulesButton
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x68) + 0xb4),0);
		  if (*(char *)(param1 + 0x70) != '\0') {
		    iVar1 = **(int **)(param1 + 0x6c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x6c) = 0;
		  }
		  return;
		}
		*/

}
