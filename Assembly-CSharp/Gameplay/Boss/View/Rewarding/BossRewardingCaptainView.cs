using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using Protocol.Boss;
using TMPro;
using UnityEngine;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5F RID: 2911
	[Token(Token = "0x2000B5F")]
	public class BossRewardingCaptainView : MonoBehaviour
	{
		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF3")]
		public TextMeshProUGUI RewardsContainerTitle
		{
			[Token(Token = "0x600468C")]
			[Address(RVA = "0x9522", Offset = "0x9522", VA = "0x9522")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B7 RID: 439
		// (add) Token: 0x0600468D RID: 18061 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600468E RID: 18062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B7")]
		public event Action<BossRewardingCaptainSlotView> CaptainRewardClickEvent
		{
			[Token(Token = "0x600468D")]
			[Address(RVA = "0x9523", Offset = "0x9523", VA = "0x9523")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600468E")]
			[Address(RVA = "0x9524", Offset = "0x9524", VA = "0x9524")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF4")]
		public List<BossRewardingCaptainSlotView> CaptainSlots
		{
			[Token(Token = "0x600468F")]
			[Address(RVA = "0x9525", Offset = "0x9525", VA = "0x9525")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x06004691 RID: 18065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF5")]
		public bool SelectionMode
		{
			[Token(Token = "0x6004690")]
			[Address(RVA = "0x9526", Offset = "0x9526", VA = "0x9526")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004691")]
			[Address(RVA = "0x9527", Offset = "0x9527", VA = "0x9527")]
			set
			{
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF6")]
		public TeamData TeamData
		{
			[Token(Token = "0x6004692")]
			[Address(RVA = "0x9528", Offset = "0x9528", VA = "0x9528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004693")]
			[Address(RVA = "0x9529", Offset = "0x9529", VA = "0x9529")]
			set
			{
			}
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004694")]
		[Address(RVA = "0x952A", Offset = "0x952A", VA = "0x952A")]
		public void SetCaptainRewards(IList<GetTeamRewardsAns.Types.BossRewardInfo> rewards)
		{
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004695")]
		[Address(RVA = "0x952B", Offset = "0x952B", VA = "0x952B")]
		private void CaptainSlotOnClickEvent(BossRewardingCaptainSlotView obj)
		{
		/* --- GHIDRA: CaptainSlotOnClickEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__CaptainSlotOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579e1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_BossRewardingCaptainSlotView__TypeInfo);
		    DAT_ram_00a579e1 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_BossRewardingCaptainSlotView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BossRewardingCaptainSlotView___ctor__)
		  ;
		  *(undefined4 *)(param1 + 0x28) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004696 RID: 18070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004696")]
		[Address(RVA = "0x952C", Offset = "0x952C", VA = "0x952C")]
		public BossRewardingCaptainView()
		{
		}

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _rewardingSlotsContainer;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _rewardsContainerTitle;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _nickLabel;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BossTeamCaptainView _captainView;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossRewardingCaptainSlotView _rewardingSlotPrefab;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x28")]
		private List<BossRewardingCaptainSlotView> _captainSlots;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x2C")]
		private bool _selectionMode;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x30")]
		private TeamData _teamData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardsContainerTitle ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_RewardsContainerTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    DAT_ram_00a579dd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingCaptainSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingCaptainSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_CaptainRewardClickEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__add_CaptainRewardClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    DAT_ram_00a579de = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingCaptainSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingCaptainSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: get_SelectionMode ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__
		              );
		    DAT_ram_00a579df = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(undefined1 *)(param1 + 0x2c) = (undefined1)param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e11a95;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*local_8._4_4_ + 0x100),local_8._4_4_,(uint)*(byte *)(param1 + 0x2c),
		               *(undefined4 *)(*local_8._4_4_ + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e11a95:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x15,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_00);
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


		/* --- GHIDRA: get_TeamData ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_TeamData
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  
		  *(int *)(param1 + 0x30) = param2;
		  iVar2 = *(int *)(param1 + 0x1c);
		  piVar3 = *(int **)(param2 + 0x18);
		  if (DAT_ram_00a57a53 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57a53 = '\x01';
		  }
		  *(int **)(iVar2 + 0x18) = piVar3;
		  if (piVar3 != (int *)0x0) {
		    param1_00 = *(undefined4 *)(iVar2 + 0x10);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0xe4));
		    uVar1 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId
		                      (*(undefined4 *)(*(int *)(iVar2 + 0x38) + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		  }
		  piVar3 = *(int **)(param1 + 0x18);
		  piVar4 = *(int **)(*(int *)(param1 + 0x30) + 0x18);
		  iVar2 = *piVar4;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                    (piVar4,*(undefined4 *)(iVar2 + 0xe4));
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(uVar1,0);
		  iVar2 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: set_TeamData ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__set_TeamData
		               (int param1,int *param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 uVar10;
		  undefined4 uVar11;
		  int *piVar12;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_Rewarding_BossRewardingCaptainView_CaptainSlotOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_BossRewardingCaptainSlotView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a579e0 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BossRewardingCaptainSlotView__MoveNext__
		                      );
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e12008;
		    }
		    if (iVar3 == 0) goto code_r0x80e120ab;
		    DAT_ram_009d3e38 = 0;
		    iVar9 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e12000:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e12008;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_Boss_View_Rewarding_BossRewardingCaptainView_CaptainSlotOnClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e12000;
		    if (DAT_ram_00a579dc == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e12000;
		      DAT_ram_00a579dc = '\x01';
		    }
		    iVar3 = *(int *)(iVar9 + 0x24);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar3,uVar4,0);
		      uVar10 = System_Action_BossRewardingCaptainSlotView__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e11fec:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e12008;
		      }
		      if (iVar8 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar8,
		                               System_Action_BossRewardingCaptainSlotView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e11fec;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar8,uVar10);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) goto code_r0x80e127ee;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e12008;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar8 = func_ii_4329(iVar9 + 0x24,param2_00,iVar3);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e11fec;
		      bVar1 = iVar3 != iVar8;
		      iVar3 = iVar8;
		    } while (bVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,iVar9,0)
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
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e12008:
		  iVar9 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar3;
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
		code_r0x80e120ab:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = *(int *)(param1 + 0x28);
		      iVar3 = *(int *)(iVar9 + 0xc);
		      *(undefined4 *)(iVar9 + 0xc) = 0;
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar9 + 8),0,iVar3,0);
		      }
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (System_Collections_Generic_IEnumerable_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		              == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		            puVar6 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80e12153;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                                    ,0);
		code_r0x80e12153:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x80e12188:
		      do {
		        piVar5 = local_14;
		        iVar9 = *local_14;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar12) {
		              puVar7 = (undefined4 *)(iVar9 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80e1221c;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e12665:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e12695;
		        }
		code_r0x80e1221c:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        piVar5 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e12665;
		        if (iVar9 == 0) {
		          iVar9 = 7;
		          goto code_r0x80e12723;
		        }
		        iVar9 = *local_14;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IEnumerator_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                == *piVar12) {
		              puVar7 = (undefined4 *)(iVar9 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80e122f7;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e1268d:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e12695;
		        }
		code_r0x80e122f7:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iii(*puVar7,piVar5,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e1268d;
		        uVar10 = *(undefined4 *)(param1 + 0x10);
		        uVar11 = *(undefined4 *)(param1 + 0x20);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e12695;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        piVar5 = (int *)import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar11,
		                                   uVar10,
		                                   Method_UnityEngine_Object_Instantiate_BossRewardingCaptainSlotView___
		                                  );
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e12695;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar10 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                            System_Action_BossRewardingCaptainSlotView__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e1266f:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e12695;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar10,param1,
		                   Method_Gameplay_Boss_View_Rewarding_BossRewardingCaptainView_CaptainSlotOnClickEvent__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e1266f;
		        if (DAT_ram_00a579db == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e1266f;
		          DAT_ram_00a579db = '\x01';
		        }
		        iVar9 = piVar5[9];
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 5,iVar9,uVar10,0);
		          uVar11 = System_Action_BossRewardingCaptainSlotView__TypeInfo;
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80e12647:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80e12695;
		          }
		          if (iVar3 == 0) {
		            iVar8 = 0;
		          }
		          else {
		            DAT_ram_009d3e38 = 0;
		            iVar8 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_BossRewardingCaptainSlotView__TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80e12647;
		            if (iVar8 == 0) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,uVar11);
		              iVar9 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar9 != 1) {
		code_r0x80e127ee:
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e12695;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar3 = func_ii_4329(piVar5 + 9,iVar8,iVar9);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80e12647;
		          bVar1 = iVar9 != iVar3;
		          iVar9 = iVar3;
		        } while (bVar1);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(*piVar5 + 0xe8),piVar5,uVar4,*(undefined4 *)(*piVar5 + 0xec));
		        iVar3 = DAT_ram_009d3e38;
		        iVar9 = Method_System_Collections_Generic_List_BossRewardingCaptainSlotView__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e12695;
		        }
		        iVar3 = *(int *)(param1 + 0x28);
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar3 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		          *(uint *)(iVar3 + 0xc) = uVar2 + 1;
		          *(int **)(*(int *)(iVar3 + 8) + uVar2 * 4 + 0x10) = piVar5;
		          goto code_r0x80e12188;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar3,piVar5,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar9 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e12695:
		      iVar9 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        local_24 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          iVar9 = 0;
		code_r0x80e12723:
		          DAT_ram_009d3e38 = 0;
		          piVar5 = *ppiStack_20;
		          if (piVar5 != (int *)0x0) {
		            uVar2 = 0;
		            iVar3 = *piVar5;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		                  puVar6 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e127a0;
		                }
		                uVar2 = uVar2 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		            }
		            puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80e127a0:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (local_24 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(local_24);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if ((iVar9 == 0) ||
		             ((((iVar9 != 1 && (iVar9 != 2)) && (iVar9 != 3)) &&
		              (((iVar9 != 4 && (iVar9 != 5)) && ((iVar9 != 6 && (iVar9 == 7)))))))) {
		            Gameplay_Boss_View_Rewarding_BossRewardingCaptainView__get_SelectionMode
		                      (param1,(uint)*(byte *)(param1 + 0x2c),0);
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17,&local_24);
		      goto joined_r0x80e12713;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16,&local_24);
		joined_r0x80e12713:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
