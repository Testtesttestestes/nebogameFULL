using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B51 RID: 2897
	[Token(Token = "0x2000B51")]
	public class BossRewardsView : AbstractBossWindowView<BossRewardsView, BossRewardsViewMediator>
	{
		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCB")]
		public RectTransform RewardsContainer
		{
			[Token(Token = "0x6004611")]
			[Address(RVA = "0x94AA", Offset = "0x94AA", VA = "0x94AA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06004612 RID: 17938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCC")]
		public RewardsRender CaptainRewardsRender
		{
			[Token(Token = "0x6004612")]
			[Address(RVA = "0x94AB", Offset = "0x94AB", VA = "0x94AB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCD")]
		public RewardsRender AssistantRewardsRender
		{
			[Token(Token = "0x6004613")]
			[Address(RVA = "0x94AC", Offset = "0x94AC", VA = "0x94AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B0 RID: 432
		// (add) Token: 0x06004614 RID: 17940 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004615 RID: 17941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B0")]
		public event Action<BossInfo.BossRewardRangeData> SelectedEvent
		{
			[Token(Token = "0x6004614")]
			[Address(RVA = "0x94AD", Offset = "0x94AD", VA = "0x94AD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004615")]
			[Address(RVA = "0x94AE", Offset = "0x94AE", VA = "0x94AE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DCE")]
		public BossInfo.BossRewardRangeData SelectedItem
		{
			[Token(Token = "0x6004616")]
			[Address(RVA = "0x94AF", Offset = "0x94AF", VA = "0x94AF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DCF")]
		public List<BossInfo.BossRewardRangeData> Data
		{
			[Token(Token = "0x6004617")]
			[Address(RVA = "0x94B0", Offset = "0x94B0", VA = "0x94B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004618")]
			[Address(RVA = "0x94B1", Offset = "0x94B1", VA = "0x94B1")]
			set
			{
			}
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x94B2", Offset = "0x94B2", VA = "0x94B2")]
		private void ItemOnClickEvent(BossRewardListItemView itemView)
		{
		/* --- GHIDRA: ItemOnClickEvent ---
		void Gameplay_Boss_View_BossRewardsView__ItemOnClickEvent(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardListItemView__GetEnumerator__);
		    DAT_ram_00a579ad = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(int *)(param1 + 0x40) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x38),
		             Method_System_Collections_Generic_List_BossRewardListItemView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e0e21c;
		    }
		    if (iVar1 == 0) goto code_r0x80e0e272;
		    iVar4 = local_8._4_4_;
		    *(bool *)(local_8._4_4_ + 0x38) = *(int *)(local_8._4_4_ + 0x34) == param2;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                       *(undefined4 *)(local_8._4_4_ + 0x18),0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,
		               (uint)*(byte *)(iVar4 + 0x38),0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e0e21c:
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
		code_r0x80e0e272:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x3c);
		      if (iVar4 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                  (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(param1 + 0x40),
		                   *(undefined4 *)(iVar4 + 0x14));
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 7,&local_18);
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

		// Token: 0x0600461A RID: 17946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x94B3", Offset = "0x94B3", VA = "0x94B3")]
		public void Select(BossInfo.BossRewardRangeData data)
		{
		/* --- GHIDRA: Select ---
		undefined4 Gameplay_Boss_View_BossRewardsView__Select(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a579ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRewardsViewMediator_TypeInfo);
		    DAT_ram_00a579ae = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossRewardsViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossRewardingWindowMediator___c___ConfirmApplyRewards_b__18_0
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x94B4", Offset = "0x94B4", VA = "0x94B4", Slot = "5")]
		protected override BossRewardsViewMediator CreateMediator()
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Boss_View_BossRewardsView__CreateMediator(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a579af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossRewardsView__BossRewardsViewMediator__OnDestroy__
		              );
		    DAT_ram_00a579af = '\x01';
		  }
		  Gameplay_Boss_View_AbstractBossWindowView_object__object___OnDestroy
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossRewardsView__BossRewardsViewMediator__OnDestroy__
		            );
		  Gameplay_Boss_View_BossRewardsView__get_Data(param1,0,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x94B5", Offset = "0x94B5", VA = "0x94B5", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Boss_View_BossRewardsView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossRewardsView__BossRewardsViewMediator___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardListItemView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossRewardListItemView__TypeInfo);
		    DAT_ram_00a579b0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_BossRewardListItemView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BossRewardListItemView___ctor__);
		  *(undefined4 *)(param1 + 0x38) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossRewardsView__BossRewardsViewMediator___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x94B6", Offset = "0x94B6", VA = "0x94B6")]
		public BossRewardsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_BossRewardsView___ctor(int param1,int param2,undefined4 param3)
		
		{
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param2 + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _captainRewardsRender;

		// Token: 0x04002656 RID: 9814
		[Token(Token = "0x4002656")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RectTransform _rewardsContainer;

		// Token: 0x04002657 RID: 9815
		[Token(Token = "0x4002657")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RewardsRender _assistantRewardsRender;

		// Token: 0x04002658 RID: 9816
		[Token(Token = "0x4002658")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BossRewardListItemView _listItemPrefab;

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x38")]
		private List<BossRewardListItemView> _items;

		// Token: 0x0400265B RID: 9819
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x40")]
		private BossInfo.BossRewardRangeData _selectedItem;

		// Token: 0x0400265C RID: 9820
		[Token(Token = "0x400265C")]
		[FieldOffset(Offset = "0x44")]
		private List<BossInfo.BossRewardRangeData> _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AssistantRewardsRender ---
		void Gameplay_Boss_View_BossRewardsView__get_AssistantRewardsRender
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossRewardRangeData__TypeInfo);
		    DAT_ram_00a579aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInfo_BossRewardRangeData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInfo_BossRewardRangeData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Boss_View_BossRewardsView__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossRewardRangeData__TypeInfo);
		    DAT_ram_00a579ab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInfo_BossRewardRangeData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInfo_BossRewardRangeData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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


		/* --- GHIDRA: get_Data ---
		void Gameplay_Boss_View_BossRewardsView__get_Data(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 *puVar9;
		  uint uVar10;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardListItemView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Boss_View_BossRewardsView_ItemOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossRewardRangeData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossRewardRangeData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossRewardRangeData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardListItemView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardListItemView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardListItemView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BossRewardListItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a579ac = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  *(undefined4 *)(param1 + 0x44) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x38),
		             Method_System_Collections_Generic_List_BossRewardListItemView__GetEnumerator__);
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossRewardListItemView__MoveNext__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e0da55;
		    }
		    if (iVar2 == 0) goto code_r0x80e0daf5;
		    DAT_ram_009d3e38 = 0;
		    iVar7 = local_8._4_4_;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_BossRewardListItemView__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0da4d:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e0da55;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		               Method_Gameplay_Boss_View_BossRewardsView_ItemOnClickEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e0da4d;
		    if (DAT_ram_00a579a7 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_BossRewardListItemView__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e0da4d;
		      DAT_ram_00a579a7 = '\x01';
		    }
		    iVar2 = *(int *)(iVar7 + 0x30);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar2,uVar3,0);
		      uVar8 = System_Action_BossRewardListItemView__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0da39:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e0da55;
		      }
		      if (iVar5 == 0) {
		        iVar6 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                           System_Action_BossRewardListItemView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0da39;
		        if (iVar6 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,uVar8);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 != 1) goto code_r0x80e0e04e;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0da55;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = func_ii_4329(iVar7 + 0x30,iVar6,iVar2);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e0da39;
		      bVar1 = iVar2 != iVar5;
		      iVar2 = iVar5;
		    } while (bVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar7,0)
		    ;
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
		code_r0x80e0da55:
		  iVar7 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e0daf5:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = *(int *)(param1 + 0x38);
		      iVar2 = *(int *)(iVar7 + 0xc);
		      *(undefined4 *)(iVar7 + 0xc) = 0;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar7 + 8),0,iVar2,0);
		      }
		      if (*(int *)(param1 + 0x44) == 0) {
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,*(int *)(param1 + 0x44),
		                 Method_System_Collections_Generic_List_BossInfo_BossRewardRangeData__GetEnumerator__
		                );
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		code_r0x80e0db7a:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_BossInfo_BossRewardRangeData__MoveNext__
		                          );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0df97;
		        }
		        iVar7 = local_30;
		        if (iVar2 == 0) goto code_r0x80e0e024;
		        uVar3 = *(undefined4 *)(param1 + 0x24);
		        uVar8 = *(undefined4 *)(param1 + 0x34);
		        iVar7 = local_18._4_4_;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e0df97;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar8,uVar3,
		                           Method_UnityEngine_Object_Instantiate_BossRewardListItemView___);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0df97;
		        }
		        *(int *)(iVar5 + 0x34) = iVar7;
		        if (iVar7 != 0) {
		          iVar2 = **(int **)(iVar5 + 0x10);
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (*(undefined4 *)(iVar2 + 0x2d0),*(int **)(iVar5 + 0x10),
		                     *(undefined4 *)(iVar7 + 0x18),*(undefined4 *)(iVar2 + 0x2d4));
		          if (DAT_ram_009d3e38 != 1) {
		            iVar7 = *(int *)(*(int *)(iVar5 + 0x34) + 0xc);
		            if (iVar7 == 0) {
		              puVar9 = (undefined4 *)(iVar5 + 0x20);
		            }
		            else if (iVar7 == 1) {
		              puVar9 = (undefined4 *)(iVar5 + 0x24);
		            }
		            else if (iVar7 == 2) {
		              puVar9 = (undefined4 *)(iVar5 + 0x28);
		            }
		            else {
		              puVar9 = (undefined4 *)(iVar5 + 0x2c);
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 4,
		                       *(undefined4 *)(iVar5 + 0x1c),*puVar9,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x80e0dd11;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0df97;
		        }
		code_r0x80e0dd11:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_BossRewardListItemView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0df71:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0df97;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar3,param1,
		                   Method_Gameplay_Boss_View_BossRewardsView_ItemOnClickEvent__,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0df71;
		        if (DAT_ram_00a579a6 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Action_BossRewardListItemView__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e0df71;
		          DAT_ram_00a579a6 = '\x01';
		        }
		        iVar7 = *(int *)(iVar5 + 0x30);
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar7,uVar3,0);
		          uVar8 = System_Action_BossRewardListItemView__TypeInfo;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0df53:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e0df97;
		          }
		          if (iVar2 == 0) {
		            iVar6 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar6 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar2,
		                               System_Action_BossRewardListItemView__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e0df53;
		            if (iVar6 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar2,uVar8);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) {
		code_r0x80e0e04e:
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e0df97;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar6 = func_ii_4329(iVar5 + 0x30,iVar6,iVar7);
		          iVar2 = Method_System_Collections_Generic_List_BossRewardListItemView__Add__;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e0df53;
		          bVar1 = iVar7 != iVar6;
		          iVar7 = iVar6;
		        } while (bVar1);
		        iVar7 = *(int *)(param1 + 0x38);
		        *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		        uVar10 = *(uint *)(iVar7 + 0xc);
		        if (uVar10 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		          *(uint *)(iVar7 + 0xc) = uVar10 + 1;
		          *(int *)(*(int *)(iVar7 + 8) + uVar10 * 4 + 0x10) = iVar5;
		          goto code_r0x80e0db7a;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,iVar5,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e0df97:
		      iVar7 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x80e0e024:
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 0) {
		            DAT_ram_009d3e38 = 0;
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 6,&local_30);
		      goto joined_r0x80e0e00f;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 3,&local_30);
		joined_r0x80e0e00f:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
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


		/* --- GHIDRA: set_Data ---
		void Gameplay_Boss_View_BossRewardsView__set_Data(undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Boss_View_BossRewardsView__ItemOnClickEvent(param1,*(undefined4 *)(param2 + 0x34),param2)
		  ;
		  return;
		}
		*/

}
