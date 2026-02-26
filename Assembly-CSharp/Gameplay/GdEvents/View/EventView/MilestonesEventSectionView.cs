using System;
using System.Collections.Generic;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Gameplay.GdEvents.Model.Milestone;
using Gameplay.GdEvents.View.Milestone;
using Gameplay.GdEvents.View.Milestone.Activity;
using Gameplay.GdEvents.View.Milestone.StageContent;
using Gameplay.GdEvents.View.Milestone.StageContent.Avatars;
using Gameplay.GdEvents.View.Milestone.StageContent.Collections;
using Gameplay.GdEvents.View.Milestone.StageContent.Gifts;
using Gameplay.GdEvents.View.Milestone.StageContent.Medals;
using Gameplay.GdEvents.View.Milestone.StageContent.Monsters;
using Il2CppDummyDll;
using TMPro;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	public class MilestonesEventSectionView : AbstractEventSectionView
	{
		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087A")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002C62")]
			[Address(RVA = "0x7CF1", Offset = "0x7CF1", VA = "0x7CF1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087B")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002C63")]
			[Address(RVA = "0x7CF2", Offset = "0x7CF2", VA = "0x7CF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087C")]
		public MilestonesListOsaView List
		{
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x7CF3", Offset = "0x7CF3", VA = "0x7CF3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087D")]
		public ScrollRect ContentScroll
		{
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x7CF4", Offset = "0x7CF4", VA = "0x7CF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087E")]
		public RequirementsView Requirements
		{
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x7CF5", Offset = "0x7CF5", VA = "0x7CF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700087F")]
		public Transform RewardsOwner
		{
			[Token(Token = "0x6002C67")]
			[Address(RVA = "0x7CF6", Offset = "0x7CF6", VA = "0x7CF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000880")]
		public RewardsRender Rewards
		{
			[Token(Token = "0x6002C68")]
			[Address(RVA = "0x7CF7", Offset = "0x7CF7", VA = "0x7CF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000881")]
		public Transform Stages
		{
			[Token(Token = "0x6002C69")]
			[Address(RVA = "0x7CF8", Offset = "0x7CF8", VA = "0x7CF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000882")]
		public Transform Activity
		{
			[Token(Token = "0x6002C6A")]
			[Address(RVA = "0x7CF9", Offset = "0x7CF9", VA = "0x7CF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000883")]
		public ArtkulsStageContentGroupView ArtikulsContent
		{
			[Token(Token = "0x6002C6B")]
			[Address(RVA = "0x7CFA", Offset = "0x7CFA", VA = "0x7CFA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000884")]
		public MedalsStageContentGroupView MedalsContent
		{
			[Token(Token = "0x6002C6C")]
			[Address(RVA = "0x7CFB", Offset = "0x7CFB", VA = "0x7CFB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000885")]
		public AvatarsStageContentGroupView AvatarsContent
		{
			[Token(Token = "0x6002C6D")]
			[Address(RVA = "0x7CFC", Offset = "0x7CFC", VA = "0x7CFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000886")]
		public CollectionsStageContentGroupView CollectionsContent
		{
			[Token(Token = "0x6002C6E")]
			[Address(RVA = "0x7CFD", Offset = "0x7CFD", VA = "0x7CFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000887")]
		public MonstersStageContentGroupView MonstersContent
		{
			[Token(Token = "0x6002C6F")]
			[Address(RVA = "0x7CFE", Offset = "0x7CFE", VA = "0x7CFE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000888")]
		public GiftsStageContentGroupView GiftsContent
		{
			[Token(Token = "0x6002C70")]
			[Address(RVA = "0x7CFF", Offset = "0x7CFF", VA = "0x7CFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x7D00", Offset = "0x7D00", VA = "0x7D00", Slot = "4")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__OnDestroy
		               (undefined4 param1,undefined4 *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_TypeInfo);
		    DAT_ram_00a5a2bf = '\x01';
		  }
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x104));
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x110) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x114));
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_GdEvents_Control_EventSections_MilestoneViewMediator_TypeInfo
		                               );
		  Gameplay_GdEvents_Control_EventSections_ExecuteConditionsViewMediator__TryShowRewards
		            (param1_00,param2_00,param3_00,param3,0);
		  *param2 = param1_00;
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x811f607b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x811f607b:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x7D01", Offset = "0x7D01", VA = "0x7D01", Slot = "5")]
		protected override void CreateMediator(ref IViewMediator mediator, GdEventsController controller)
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__CreateMediator
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a2c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_GameActivityData__Invoke__);
		    DAT_ram_00a5a2c0 = '\x01';
		  }
		  func_ii_16397(*(undefined4 *)(param1 + 0x60),param2,
		                Method_UnityEngine_Events_UnityEvent_GameActivityData__Invoke__);
		  return;
		}
		*/

		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x7D02", Offset = "0x7D02", VA = "0x7D02")]
		private void HandleActivityClickEvent(GameActivityData activity)
		{
		/* --- GHIDRA: HandleActivityClickEvent ---
		void Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__HandleActivityClickEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int param2_00;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a2c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ActivityGroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ActivityGroupData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_EventView_MilestonesEventSectionView_HandleActivityClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_GameActivityContentGroupView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_GameActivityData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_GameActivityData__AddListener__);
		    DAT_ram_00a5a2c1 = '\x01';
		  }
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x40),0);
		  local_10 = &local_8;
		  local_18 = 0;
		  local_14 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811f621d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f6460:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f6468;
		    }
		code_r0x811f621d:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f6460;
		    if (iVar7 == 0) goto code_r0x811f64b1;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		          goto code_r0x811f62fa;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811f6442:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811f6468;
		    }
		code_r0x811f62fa:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811f6442;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
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
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811f6468;
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
		code_r0x811f6468:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_18 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x811f64b1:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_10;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811f6541;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x811f6541:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar1 = 0;
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_ActivityGroupData__TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811f65c9;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_ActivityGroupData__TypeInfo
		                                    ,0);
		code_r0x811f65c9:
		      local_c = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_18 = 0;
		      local_14 = &local_c;
		      do {
		        piVar5 = local_c;
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811f66d5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811f6996:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811f699e;
		        }
		code_r0x811f66d5:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811f6996;
		        if (iVar7 == 0) {
		          iVar7 = 0;
		          goto code_r0x811f69e7;
		        }
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_ActivityGroupData__TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x811f67af;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_ActivityGroupData__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811f6964:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811f699e;
		        }
		code_r0x811f67af:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811f6964;
		        uVar3 = *(undefined4 *)(param1 + 0x40);
		        uVar8 = *(undefined4 *)(param1 + 0x44);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811f699e;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar8,uVar3,
		                               Method_UnityEngine_Object_Instantiate_GameActivityContentGroupView___
		                              );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811f699e;
		        }
		        if (iVar7 != *(int *)(param2_00 + 0x20)) {
		          *(int *)(param2_00 + 0x20) = iVar7;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x286,param2_00,param2_00);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811f699e;
		          }
		        }
		        uVar8 = *(undefined4 *)(param2_00 + 0x1c);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           UnityEngine_Events_UnityAction_GameActivityData__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 8,uVar3,param1,
		                   Method_Gameplay_GdEvents_View_EventView_MilestonesEventSectionView_HandleActivityClickEvent__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd,uVar8,uVar3,
		                   Method_UnityEngine_Events_UnityEvent_GameActivityData__AddListener__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811f699e:
		      iVar7 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x811f69e7:
		          piVar5 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x811f6a5f;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar6 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x811f6a5f:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar7 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x287,&local_18);
		      goto joined_r0x811f6aae;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x285,&local_18);
		joined_r0x811f6aae:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x7D03", Offset = "0x7D03", VA = "0x7D03")]
		public void SetActivities(IEnumerable<ActivityGroupData> activities)
		{
		/* --- GHIDRA: SetActivities ---
		void Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__SetActivities
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a2c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_GameActivityData___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_GameActivityData__TypeInfo);
		    DAT_ram_00a5a2c2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityEvent_GameActivityData__TypeInfo);
		  Sirenix_Serialization_UnityEventFormatter_object___GetUninitializedObject
		            (param1_00,Method_UnityEngine_Events_UnityEvent_GameActivityData___ctor__);
		  *(undefined4 *)(param1 + 0x60) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x7D04", Offset = "0x7D04", VA = "0x7D04")]
		public MilestonesEventSectionView()
		{
		}

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ScrollRect _contentScroll;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MilestonesListOsaView _list;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _rewardsOwner;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RewardsRender _rewards;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _stages;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _activity;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _activityContent;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameActivityContentGroupView _activityGroupPrefab;

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtkulsStageContentGroupView _artikulsContent;

		// Token: 0x04001866 RID: 6246
		[Token(Token = "0x4001866")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private MedalsStageContentGroupView _medalsContent;

		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AvatarsStageContentGroupView _avatarsContent;

		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private CollectionsStageContentGroupView _collectionsContent;

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MonstersStageContentGroupView _monstersContent;

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GiftsStageContentGroupView _giftsContent;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UnityEvent<GameActivityData> ActivityItemClickEvent;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GiftsContent ---
		void Gameplay_GdEvents_View_EventView_MilestonesEventSectionView__get_GiftsContent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2a9 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811f5f64;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x811f5f64:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x18) = 0;
		  func_ii_14558(*(undefined4 *)(param1 + 0x60),0);
		  return;
		}
		*/

}
