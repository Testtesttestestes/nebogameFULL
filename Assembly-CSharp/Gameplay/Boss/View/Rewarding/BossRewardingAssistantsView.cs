using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using Protocol.Boss;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class BossRewardingAssistantsView : MonoBehaviour
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEB")]
		public BossRewardingAssistantSlotView[] AssistantSlots
		{
			[Token(Token = "0x6004675")]
			[Address(RVA = "0x950C", Offset = "0x950C", VA = "0x950C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEC")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004676")]
			[Address(RVA = "0x950D", Offset = "0x950D", VA = "0x950D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DED")]
		public GameObject BacktimeGroup
		{
			[Token(Token = "0x6004677")]
			[Address(RVA = "0x950E", Offset = "0x950E", VA = "0x950E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEE")]
		public TextMeshProUGUI StatusLabel
		{
			[Token(Token = "0x6004678")]
			[Address(RVA = "0x950F", Offset = "0x950F", VA = "0x950F")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B5 RID: 437
		// (add) Token: 0x06004679 RID: 18041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600467A RID: 18042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B5")]
		public event Action<BossRewardingAssistantSlotView> SelectedAssistantSlotChangedEvent
		{
			[Token(Token = "0x6004679")]
			[Address(RVA = "0x9510", Offset = "0x9510", VA = "0x9510")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600467A")]
			[Address(RVA = "0x9511", Offset = "0x9511", VA = "0x9511")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEF")]
		public BossRewardingAssistantSlotView SelectedRewardingAssistantSlot
		{
			[Token(Token = "0x600467B")]
			[Address(RVA = "0x9512", Offset = "0x9512", VA = "0x9512")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600467D RID: 18045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF0")]
		public TeamData TeamData
		{
			[Token(Token = "0x600467C")]
			[Address(RVA = "0x9513", Offset = "0x9513", VA = "0x9513")]
			get
			{
				return null;
			}
			[Token(Token = "0x600467D")]
			[Address(RVA = "0x9514", Offset = "0x9514", VA = "0x9514")]
			set
			{
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x0600467F RID: 18047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF1")]
		public bool Editable
		{
			[Token(Token = "0x600467E")]
			[Address(RVA = "0x9515", Offset = "0x9515", VA = "0x9515")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600467F")]
			[Address(RVA = "0x9516", Offset = "0x9516", VA = "0x9516")]
			set
			{
			}
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004680")]
		[Address(RVA = "0x1B7D", Offset = "0x1B7D", VA = "0x1B7D")]
		public BossRewardingAssistantSlotView GetSlotById(ulong ownerId)
		{
			return null;
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004681")]
		[Address(RVA = "0x9517", Offset = "0x9517", VA = "0x9517")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__Awake
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param2_00;
		  undefined8 param2_01;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a579d7 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(param1 + 0x30);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param2,param2_00,0);
		  if (iVar1 == 0) {
		    local_18 = 0;
		    local_28 = 0;
		    local_20 = 0;
		    local_30 = 0;
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		              (param1,&local_30,&local_40);
		  }
		  else {
		    param2_01 = *(undefined8 *)(param2 + 0x30);
		    local_8 = 0;
		    local_10 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_10,param2_01,Method_System_Nullable_ulong___ctor__);
		    local_38 = local_8;
		    local_40 = local_10;
		    in_register_20000014 = (undefined4)((ulonglong)param2_01 >> 0x20);
		    Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		              (param1,&local_40,&local_40);
		  }
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),
		               CONCAT44(in_register_20000014,*(undefined4 *)(param1 + 0x30)),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004682 RID: 18050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x9518", Offset = "0x9518", VA = "0x9518")]
		private void SlotOnClickEvent(BossRewardingAssistantSlotView bossRewardingSlotView)
		{
		/* --- GHIDRA: SlotOnClickEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SlotOnClickEvent
		               (int param1,char *param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  longlong lVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  bool bVar5;
		  longlong lVar6;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a579d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_Value__);
		    DAT_ram_00a579d8 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x30) = 0;
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar2 + iVar4 * 4 + 0x10);
		      bVar5 = false;
		      if (*param2 != '\0') {
		        lVar6 = *(longlong *)(iVar3 + 0x30);
		        lVar1 = System_Nullable_TimeSpan___get_HasValue
		                          (param2,Method_System_Nullable_ulong__get_Value__);
		        bVar5 = lVar6 == lVar1;
		      }
		      *(bool *)(iVar3 + 0x2d) = bVar5;
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar3 + 0x18),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)*(byte *)(iVar3 + 0x2d),0);
		      if (*(char *)(iVar3 + 0x2d) != '\0') {
		        *(int *)(param1 + 0x30) = iVar3;
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x9519", Offset = "0x9519", VA = "0x9519")]
		public void SelectSlot(ulong? assistantId)
		{
		/* --- GHIDRA: SelectSlot ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__SelectSlot
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a579d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView_SlotOnClickEvent__);
		    DAT_ram_00a579d9 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_BossRewardingAssistantSlotView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,
		                 Method_Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView_SlotOnClickEvent__,
		                 0);
		      if (DAT_ram_00a579d2 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		        DAT_ram_00a579d2 = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x28);
		      do {
		        iVar2 = 0;
		        param1_02 = func_ii_7048(param1_00,param1_01,0);
		        param2_00 = System_Action_BossRewardingAssistantSlotView__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_BossRewardingAssistantSlotView__TypeInfo),
		           iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x28,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004684 RID: 18052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004684")]
		[Address(RVA = "0x951A", Offset = "0x951A", VA = "0x951A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  longlong lVar4;
		  int iVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a579da == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__GetEnumerator__
		              );
		    DAT_ram_00a579da = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      piVar1 = *(int **)(iVar2 + iVar3 * 4 + 0x10);
		      iVar5 = *piVar1;
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))(piVar1,0,*(undefined4 *)(iVar5 + 0xec));
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,param2,
		             Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__MoveNext__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e11644;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    iVar3 = 0;
		    piVar1 = *(int **)(*(int *)(param1 + 0x14) + 0x10);
		    lVar4 = *(longlong *)(piVar1 + 0xc);
		    while (*(longlong *)(local_8._4_4_ + 0x18) != lVar4) {
		      iVar3 = iVar3 + 1;
		      piVar1 = *(int **)(*(int *)(param1 + 0x14) + iVar3 * 4 + 0x10);
		      lVar4 = *(longlong *)(piVar1 + 0xc);
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(*piVar1 + 0xe8),piVar1,local_8._4_4_,*(undefined4 *)(*piVar1 + 0xec))
		    ;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e11644:
		  iVar3 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar2) {
		    piVar1 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar1;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14,&local_18);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004685")]
		[Address(RVA = "0x951B", Offset = "0x951B", VA = "0x951B")]
		public void SetAssistantRewards(List<GetTeamRewardsAns.Types.BossRewardInfo> assistantRewards)
		{
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x951C", Offset = "0x951C", VA = "0x951C")]
		public BossRewardingAssistantsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    DAT_ram_00a579db = '\x01';
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

		}

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BossTeamAssistantView[] _assistantViews;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossRewardingAssistantSlotView[] _assistantSlots;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _statusLabel;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _totalSkillBonusLabel;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillIconValue _totalSkillBonus;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x30")]
		private BossRewardingAssistantSlotView _selectedRewardingAssistantSlot;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x34")]
		private TeamData _teamData;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x38")]
		private bool _editable;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StatusLabel ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__get_StatusLabel
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    DAT_ram_00a579d3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingAssistantSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingAssistantSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectedAssistantSlotChangedEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__add_SelectedAssistantSlotChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    DAT_ram_00a579d4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingAssistantSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingAssistantSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: get_TeamData ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__get_TeamData
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  int *piVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a579d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamData_TeamAssistantData__ToArray__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3969);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3650);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3630);
		    DAT_ram_00a579d5 = '\x01';
		  }
		  *(int *)(param1 + 0x34) = param2;
		  iVar5 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      piVar7 = *(int **)(iVar5 + iVar8 * 4 + 0x10);
		      piVar7[0xc] = 0;
		      piVar7[0xd] = 0;
		      bVar1 = false;
		      if (((char)piVar7[0xb] != '\0') &&
		         (iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe0) * 4))
		                            (piVar7,*(undefined4 *)(*piVar7 + 0xe4)), bVar1 = false, iVar2 == 0)) {
		        bVar1 = *(longlong *)(piVar7 + 0xc) != 0;
		      }
		      (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x100) * 4))
		                (piVar7,bVar1,*(undefined4 *)(*piVar7 + 0x104));
		      iVar8 = iVar8 + 1;
		    } while (iVar8 < *(int *)(iVar5 + 0xc));
		    param2 = *(int *)(param1 + 0x34);
		  }
		  if (param2 != 0) {
		    iVar5 = 0;
		    iVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (*(undefined4 *)(param2 + 0x14),
		                       Method_System_Collections_Generic_List_TeamData_TeamAssistantData__ToArray__)
		    ;
		    iVar8 = *(int *)(param1 + 0x10);
		    iVar9 = *(int *)(iVar8 + 0xc);
		    if (iVar9 < *(int *)(iVar2 + 0xc)) {
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7109(StringLiteral_3969,0);
		      iVar8 = *(int *)(param1 + 0x10);
		      iVar9 = *(int *)(iVar8 + 0xc);
		    }
		    if (0 < iVar9) {
		      do {
		        iVar9 = iVar5 * 4;
		        uVar3 = *(undefined4 *)(iVar8 + iVar9 + 0x10);
		        if (iVar5 < *(int *)(iVar2 + 0xc)) {
		          piVar7 = *(int **)(iVar9 + iVar2 + 0x10);
		          Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__get_AssistantData(uVar3,piVar7,iVar5)
		          ;
		          if (piVar7 != (int *)0x0) {
		            bVar1 = false;
		            piVar6 = *(int **)(*(int *)(param1 + 0x14) + iVar9 + 0x10);
		            uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar7 + 0xe0) * 4))
		                              (piVar7,*(undefined4 *)(*piVar7 + 0xe4));
		            uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar3,0);
		            *(undefined8 *)(piVar6 + 0xc) = uVar4;
		            if (((char)piVar6[0xb] != '\0') &&
		               (iVar8 = (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))
		                                  (piVar6,*(undefined4 *)(*piVar6 + 0xe4)), bVar1 = false,
		               iVar8 == 0)) {
		              bVar1 = *(longlong *)(piVar6 + 0xc) != 0;
		            }
		            (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x100) * 4))
		                      (piVar6,bVar1,*(undefined4 *)(*piVar6 + 0x104));
		          }
		        }
		        else {
		          Gameplay_Boss_View_CaptainTab_BossTeamAssistantView__get_AssistantData(uVar3,0,iVar5);
		        }
		        iVar5 = iVar5 + 1;
		        iVar8 = *(int *)(param1 + 0x10);
		      } while (iVar5 < *(int *)(iVar8 + 0xc));
		    }
		    piVar7 = *(int **)(param1 + 0x20);
		    if (0 < *(longlong *)(*(int *)(*(int *)(param1 + 0x34) + 0x10) + 0x10)) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3630,1,0,1,0,0,0,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x2d0) * 4))
		                (piVar7,uVar3,*(undefined4 *)(*piVar7 + 0x2d4));
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,1,0);
		      func_ii_7072(*(undefined4 *)(param1 + 0x24),*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),
		                   piVar7);
		      return;
		    }
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3650,1,0,1,0,0,0,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x2d0) * 4))
		              (piVar7,uVar3,*(undefined4 *)(*piVar7 + 0x2d4));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Editable ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__get_Editable
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  bool bVar5;
		  
		  *(char *)(param1 + 0x38) = (char)param2;
		  iVar3 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    if (param2 == 0) {
		      do {
		        piVar4 = *(int **)(iVar3 + iVar1 * 4 + 0x10);
		        *(undefined1 *)(piVar4 + 0xb) = 0;
		        (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                  (piVar4,0,*(undefined4 *)(*piVar4 + 0x104));
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		    else {
		      do {
		        piVar4 = *(int **)(iVar3 + iVar1 * 4 + 0x10);
		        *(char *)(piVar4 + 0xb) = (char)param2;
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		                          (piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		        if (iVar2 == 0) {
		          bVar5 = *(longlong *)(piVar4 + 0xc) != 0;
		        }
		        else {
		          bVar5 = false;
		        }
		        (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                  (piVar4,bVar5,*(undefined4 *)(*piVar4 + 0x104));
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Editable ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView__set_Editable
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a579d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView_SlotOnClickEvent__);
		    DAT_ram_00a579d6 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(iVar3 + iVar5 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_BossRewardingAssistantSlotView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_01,param1,
		                 Method_Gameplay_Boss_View_Rewarding_BossRewardingAssistantsView_SlotOnClickEvent__,
		                 0);
		      if (DAT_ram_00a579d1 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		        DAT_ram_00a579d1 = '\x01';
		      }
		      param1_00 = *(int *)(iVar4 + 0x28);
		      do {
		        iVar2 = 0;
		        param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		        param2_00 = System_Action_BossRewardingAssistantSlotView__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_BossRewardingAssistantSlotView__TypeInfo),
		           iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar4 + 0x28,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

}
