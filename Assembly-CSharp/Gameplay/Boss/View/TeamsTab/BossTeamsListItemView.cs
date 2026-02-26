using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.TeamsTab
{
	// Token: 0x02000B57 RID: 2903
	[Token(Token = "0x2000B57")]
	public class BossTeamsListItemView : MonoBehaviour
	{
		// Token: 0x140001B2 RID: 434
		// (add) Token: 0x06004641 RID: 17985 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004642 RID: 17986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B2")]
		public event Action<TeamRewardData> ButtonClickedEvent
		{
			[Token(Token = "0x6004641")]
			[Address(RVA = "0x94DA", Offset = "0x94DA", VA = "0x94DA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004642")]
			[Address(RVA = "0x94DB", Offset = "0x94DB", VA = "0x94DB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004643")]
		[Address(RVA = "0x94DC", Offset = "0x94DC", VA = "0x94DC")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x24),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x94DD", Offset = "0x94DD", VA = "0x94DD")]
		private void ButtonClickedHandler()
		{
		/* --- GHIDRA: ButtonClickedHandler ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemView__ButtonClickedHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a579c2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_TeamsTab_BossTeamsListItemView_ButtonClickedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a579c2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_TeamsTab_BossTeamsListItemView_ButtonClickedHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x94DE", Offset = "0x94DE", VA = "0x94DE")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DD8")]
		public TeamRewardData Data
		{
			[Token(Token = "0x6004646")]
			[Address(RVA = "0x94DF", Offset = "0x94DF", VA = "0x94DF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004647")]
			[Address(RVA = "0x94E0", Offset = "0x94E0", VA = "0x94E0")]
			set
			{
			}
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x94E1", Offset = "0x94E1", VA = "0x94E1")]
		public BossTeamsListItemView()
		{
		}

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossTeamMemberView[] _teamMembers;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _noButtonLabel;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x24")]
		private TeamRewardData _teamRewardData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ButtonClickedEvent ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemView__add_ButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamRewardData__TypeInfo);
		    DAT_ram_00a579c0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TeamRewardData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TeamRewardData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ButtonClickedEvent ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemView__remove_ButtonClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a579c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_TeamsTab_BossTeamsListItemView_ButtonClickedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a579c1 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_TeamsTab_BossTeamsListItemView_ButtonClickedHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Boss_View_TeamsTab_BossTeamsListItemView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param2_01;
		  int iVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a579c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3672);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3669);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3670);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3671);
		    DAT_ram_00a579c3 = '\x01';
		  }
		  *(int *)(param1 + 0x24) = param2;
		  piVar2 = *(int **)(param1 + 0x10);
		  local_8 = *(undefined8 *)(*(int *)(param2 + 8) + 0x20);
		  uVar1 = func_ii_8783(&local_8,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  iVar3 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    param2_00 = 0;
		    do {
		      iVar3 = *(int *)(iVar3 + param2_00 * 4 + 0x10);
		      uVar1 = 0;
		      if (param2_00 < *(int *)(*(int *)(param2 + 0xc) + 0xc)) {
		        uVar1 = System_Linq_Enumerable__ToList_object_
		                          (*(int *)(param2 + 0xc),param2_00,
		                           Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData__get_Item__
		                          );
		      }
		      param2_01 = *(undefined4 *)(iVar3 + 0x14);
		      *(undefined4 *)(iVar3 + 0x14) = uVar1;
		      Gameplay_Boss_View_TeamsTab_BossTeamMemberView__set_TeamMemberData
		                (iVar3,param2_01,uVar1,param2_00);
		      param2_00 = param2_00 + 1;
		      iVar3 = *(int *)(param1 + 0x14);
		    } while (param2_00 < *(int *)(iVar3 + 0xc));
		  }
		  if (*(char *)(param2 + 0x10) == '\0') {
		    iVar3 = *(int *)(*(int *)(param2 + 8) + 0x1c);
		    if (iVar3 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		      piVar2 = *(int **)(param1 + 0x18);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3672,1,0,1,0,0,0,0);
		      iVar3 = *piVar2;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		    }
		    else if (iVar3 == 1) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		      piVar2 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                                (*(undefined4 *)(param1 + 0x1c),
		                                 Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___
		                                );
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3669,1,0,1,0,0,0,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x2d0) * 4))
		                (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x2d4));
		    }
		    else if (iVar3 == 2) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,1,0);
		      piVar2 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                                (*(undefined4 *)(param1 + 0x1c),
		                                 Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___
		                                );
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3670,1,0,1,0,0,0,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x2d0) * 4))
		                (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x2d4));
		    }
		  }
		  else {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    piVar2 = *(int **)(param1 + 0x18);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3671,1,0,1,0,0,0,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  return;
		}
		*/

}
