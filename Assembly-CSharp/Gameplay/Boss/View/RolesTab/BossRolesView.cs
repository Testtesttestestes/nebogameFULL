using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Model;
using Gameplay.School.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buildings;
using UnityEngine;

namespace Gameplay.Boss.View.RolesTab
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	public class BossRolesView : AbstractBossWindowView<BossRolesView, BossRolesViewMediator>
	{
		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDC")]
		public BossPossibleEmptyWindowStateController StateController
		{
			[Token(Token = "0x6004650")]
			[Address(RVA = "0x94E9", Offset = "0x94E9", VA = "0x94E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06004651 RID: 18001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDD")]
		public BossRoleSpellDescription SpellDescription
		{
			[Token(Token = "0x6004651")]
			[Address(RVA = "0x94EA", Offset = "0x94EA", VA = "0x94EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDE")]
		public SpellTitle SpellTitle
		{
			[Token(Token = "0x6004652")]
			[Address(RVA = "0x94EB", Offset = "0x94EB", VA = "0x94EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06004653 RID: 18003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DDF")]
		public TextMeshProUGUI CultTitle
		{
			[Token(Token = "0x6004653")]
			[Address(RVA = "0x94EC", Offset = "0x94EC", VA = "0x94EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DE0")]
		public GameRawImage CultIcon
		{
			[Token(Token = "0x6004654")]
			[Address(RVA = "0x94ED", Offset = "0x94ED", VA = "0x94ED")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DE1")]
		public BossInfo.BossCultSpellData SelectedItem
		{
			[Token(Token = "0x6004655")]
			[Address(RVA = "0x94EE", Offset = "0x94EE", VA = "0x94EE")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B3 RID: 435
		// (add) Token: 0x06004656 RID: 18006 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004657 RID: 18007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B3")]
		public event Action<BossInfo.BossCultSpellData> SelectedEvent
		{
			[Token(Token = "0x6004656")]
			[Address(RVA = "0x94EF", Offset = "0x94EF", VA = "0x94EF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004657")]
			[Address(RVA = "0x94F0", Offset = "0x94F0", VA = "0x94F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004658")]
		[Address(RVA = "0x94F1", Offset = "0x94F1", VA = "0x94F1", Slot = "5")]
		protected override BossRolesViewMediator CreateMediator()
		{
			return null;
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600465A RID: 18010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE2")]
		public List<BossInfo.BossCultSpellData> Spells
		{
			[Token(Token = "0x6004659")]
			[Address(RVA = "0x94F2", Offset = "0x94F2", VA = "0x94F2")]
			get
			{
				return null;
			}
			[Token(Token = "0x600465A")]
			[Address(RVA = "0x94F3", Offset = "0x94F3", VA = "0x94F3")]
			set
			{
			}
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465B")]
		[Address(RVA = "0x94F4", Offset = "0x94F4", VA = "0x94F4")]
		private void OnSpellClickedEvent(SpellItemArgs arg0)
		{
		/* --- GHIDRA: OnSpellClickedEvent ---
		void Gameplay_Boss_View_RolesTab_BossRolesView__OnSpellClickedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579cd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossRolesView__BossRolesViewMediator___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SpellItem__TypeInfo);
		    DAT_ram_00a579cd = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_SpellItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_SpellItem___ctor__);
		  *(undefined4 *)(param1 + 0x40) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossRolesView__BossRolesViewMediator___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465C")]
		[Address(RVA = "0x1B97", Offset = "0x1B97", VA = "0x1B97")]
		public void Select(BossInfo.BossCultSpellData selectedItem)
		{
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465D")]
		[Address(RVA = "0x94F5", Offset = "0x94F5", VA = "0x94F5")]
		public BossRolesView()
		{
		}

		// Token: 0x04002676 RID: 9846
		[Token(Token = "0x4002676")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002677 RID: 9847
		[Token(Token = "0x4002677")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _cultTitle;

		// Token: 0x04002678 RID: 9848
		[Token(Token = "0x4002678")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameRawImage _cultIcon;

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SpellTitle _spellTitle;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BossRoleSpellDescription _spellDescription;

		// Token: 0x0400267B RID: 9851
		[Token(Token = "0x400267B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BossPossibleEmptyWindowStateController _stateController;

		// Token: 0x0400267C RID: 9852
		[Token(Token = "0x400267C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SpellItem _spellItemPrefab;

		// Token: 0x0400267D RID: 9853
		[Token(Token = "0x400267D")]
		[FieldOffset(Offset = "0x40")]
		private List<SpellItem> _spellItems;

		// Token: 0x0400267E RID: 9854
		[Token(Token = "0x400267E")]
		[FieldOffset(Offset = "0x44")]
		private BossInfo.BossCultSpellData _selectedItem;

		// Token: 0x04002680 RID: 9856
		[Token(Token = "0x4002680")]
		[FieldOffset(Offset = "0x4C")]
		private List<BossInfo.BossCultSpellData> _spells;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SelectedItem ---
		void Gameplay_Boss_View_RolesTab_BossRolesView__get_SelectedItem
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossCultSpellData__TypeInfo);
		    DAT_ram_00a579c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInfo_BossCultSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInfo_BossCultSpellData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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
		void Gameplay_Boss_View_RolesTab_BossRolesView__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInfo_BossCultSpellData__TypeInfo);
		    DAT_ram_00a579c8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x48);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInfo_BossCultSpellData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInfo_BossCultSpellData__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x48,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectedEvent ---
		undefined4
		Gameplay_Boss_View_RolesTab_BossRolesView__remove_SelectedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a579c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossRolesViewMediator_TypeInfo);
		    DAT_ram_00a579c9 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossRolesViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossRewardsViewMediator__ViewOnSelectedEvent
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/


		/* --- GHIDRA: get_Spells ---
		void Gameplay_Boss_View_RolesTab_BossRolesView__get_Spells
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int param2_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  uint uVar6;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_RolesTab_BossRolesView_OnSpellClickedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SpellItem__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SpellItem__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SpellItem__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__Init__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItem__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItem__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItem__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SpellItem___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_SpellItemArgs__RemoveListener__);
		    DAT_ram_00a579ca = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  *(undefined4 *)(param1 + 0x4c) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x40),
		             Method_System_Collections_Generic_List_SpellItem__GetEnumerator__);
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_SpellItem__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e0f859;
		    }
		    if (iVar1 == 0) goto code_r0x80e0f8af;
		    iVar4 = local_8._4_4_;
		    uVar5 = *(undefined4 *)(local_8._4_4_ + 0x14);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0f83d:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e0f859;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 8,uVar2,param1,
		               Method_Gameplay_Boss_View_RolesTab_BossRolesView_OnSpellClickedEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e0f83d;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 9,uVar5,uVar2,
		               Method_UnityEngine_Events_UnityEvent_SpellItemArgs__RemoveListener__);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e0f83d;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar4,0)
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e0f859:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar1;
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
		code_r0x80e0f8af:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x40);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      if (*(int *)(param1 + 0x4c) == 0) {
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,*(int *)(param1 + 0x4c),
		                 Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__GetEnumerator__)
		      ;
		      local_18 = local_28;
		      local_20 = CONCAT44(puStack_2c,local_30);
		      local_30 = 0;
		      puStack_2c = &local_20;
		code_r0x80e0f96e:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__MoveNext__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0fc57;
		        }
		        iVar4 = local_30;
		        if (iVar1 == 0) goto code_r0x80e0fca0;
		        uVar2 = *(undefined4 *)(param1 + 0x24);
		        uVar5 = *(undefined4 *)(param1 + 0x3c);
		        iVar4 = local_18._4_4_;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e0fc57;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar5,uVar2,
		                               Method_UnityEngine_Object_Instantiate_SpellItem___);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0fc57;
		        }
		        uVar5 = *(undefined4 *)(iVar4 + 0x10);
		        param3_00 = *(undefined4 *)(iVar4 + 0xc);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           UI_Elements_Buildings_SpellItemArgs_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0fc31:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0fc57;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xb,uVar2,param3_00,uVar5,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0fc31;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc,param2_00,uVar2,
		                   Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__Init__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0fc31;
		        uVar5 = *(undefined4 *)(param2_00 + 0x14);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           UnityEngine_Events_UnityAction_SpellItemArgs__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e0fc3b:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e0fc57;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 8,uVar2,param1,
		                   Method_Gameplay_Boss_View_RolesTab_BossRolesView_OnSpellClickedEvent__,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0fc3b;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd,uVar5,uVar2,
		                   Method_UnityEngine_Events_UnityEvent_SpellItemArgs__AddListener__);
		        iVar4 = Method_System_Collections_Generic_List_SpellItem__Add__;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0fc3b;
		        iVar1 = *(int *)(param1 + 0x40);
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar6 = *(uint *)(iVar1 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar6 + 1;
		          *(int *)(*(int *)(iVar1 + 8) + uVar6 * 4 + 0x10) = param2_00;
		          goto code_r0x80e0f96e;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar1,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar4 != 1);
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e0fc57:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar4 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x80e0fca0:
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xe,&local_30);
		      goto joined_r0x80e0fced;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 10,&local_30);
		joined_r0x80e0fced:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
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


		/* --- GHIDRA: set_Spells ---
		/* WARNING: Removing unreachable block (ram,0x80e1000d) */
		
		void Gameplay_Boss_View_RolesTab_BossRolesView__set_Spells(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined1 auStack_40 [8];
		  int local_38;
		  undefined1 *local_34;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579cb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SpellItem__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SpellItem__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_SpellItem__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_SpellItemArgs__get_args__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_SpellItem__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__GetEnumerator__);
		    DAT_ram_00a579cb = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x40),
		             Method_System_Collections_Generic_List_SpellItem__GetEnumerator__);
		  local_8 = local_28;
		  local_38 = 0;
		  local_34 = local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                         Method_System_Collections_Generic_List_Enumerator_SpellItem__MoveNext__);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar2 = global_1;
		        goto code_r0x80e100b3;
		      }
		      if (iVar1 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		    } while (*(int *)(*(int *)(local_8._4_4_ + 0x18) + 0xc) != *(int *)(param2 + 0xc));
		    DAT_ram_009d3e38 = 0;
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_30,*(undefined4 *)(param1 + 0x4c),
		               Method_System_Collections_Generic_List_BossInfo_BossCultSpellData__GetEnumerator__);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		      goto code_r0x80e100b3;
		    }
		    local_18 = local_28;
		    local_20 = CONCAT44(puStack_2c,local_30);
		    local_30 = 0;
		    puStack_2c = &local_20;
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                           Method_System_Collections_Generic_List_Enumerator_BossInfo_BossCultSpellData__MoveNext__
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0ff8f;
		        if (iVar2 == 0) {
		          iVar2 = 0;
		          goto code_r0x80e0ffe1;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = local_18._4_4_;
		        iVar2 = UnityEngine_AndroidJavaObject___GetRawObject(local_18._4_4_,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e0ff8f;
		      } while (iVar2 != *(int *)(param2 + 0xc));
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x10,param1,uVar3,auStack_40);
		    } while (DAT_ram_009d3e38 != 1);
		code_r0x80e0ff8f:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar2 = global_1;
		    iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 != iVar1) {
		code_r0x80e10071:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x11,&local_30);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) goto code_r0x80e10146;
		      goto code_r0x80e100b3;
		    }
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		      goto code_r0x80e10071;
		    }
		code_r0x80e0ffe1:
		    if (iVar2 != 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar2);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		code_r0x80e100b3:
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar1 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_38 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          if (iVar1 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x12,&local_38);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e10146:
		      DAT_ram_009d3e38 = 0;
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  } while( true );
		}
		*/

}
