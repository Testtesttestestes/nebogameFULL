using System;
using Core.Sorting;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.InvitesTab;
using Il2CppDummyDll;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA9 RID: 2985
	[Token(Token = "0x2000BA9")]
	public class BossAssistantViewMediator : AbstractBossWindowViewMediator<BossInvitesView>
	{
		// Token: 0x0600491D RID: 18717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x978F", Offset = "0x978F", VA = "0x978F")]
		public BossAssistantViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		/* --- GHIDRA: <RenderInvites>b__14_1 ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator___RenderInvites_b__14_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a578f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo);
		    DAT_ram_00a578f7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <BuyLicenceButtonClickHandler>b__10_0 ---
		uint Gameplay_Boss_Controller_BossAssistantViewMediator___BuyLicenceButtonClickHandler_b__10_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  
		  lVar2 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  return (uint)(lVar2 == *(longlong *)(*(int *)(*(int *)(iVar1 + 0x24) + 0xa8) + 0x10));
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_Controller_BossAssistantViewMediator__RenderInvites(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491E")]
		[Address(RVA = "0x9790", Offset = "0x9790", VA = "0x9790")]
		private void LicenceCountChangedEvent()
		{
		/* --- GHIDRA: LicenceCountChangedEvent ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__LicenceCountChangedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_Controller_BossAssistantViewMediator__TeamInfoReceivedEvent(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x0600491F RID: 18719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x9791", Offset = "0x9791", VA = "0x9791")]
		private void TeamInfoReceivedEvent(TeamData teamData)
		{
		/* --- GHIDRA: TeamInfoReceivedEvent ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__TeamInfoReceivedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  
		  if ((param2 != 0) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c)),
		     *(int *)(*(int *)(iVar1 + 0x24) + 0xa8) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    lVar4 = *(longlong *)(*(int *)(*(int *)(iVar1 + 0x24) + 0xa8) + 0x10);
		    iVar1 = **(int **)(param2 + 0x18);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))
		                      (*(int **)(param2 + 0x18),*(undefined4 *)(iVar1 + 0xe4));
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		    if (lVar4 == lVar3) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x28),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_Boss_View_CaptainTab_BossTeamView__add_AssistantClickedEvent
		                (*(undefined4 *)(iVar1 + 0x28),param2,0);
		      return;
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004920 RID: 18720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x9792", Offset = "0x9792", VA = "0x9792")]
		private void ShowTeamData(TeamData teamData)
		{
		/* --- GHIDRA: ShowTeamData ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__ShowTeamData
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Boss_Controller_BossAssistantViewMediator__ListAdapterOnSelectedEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x9793", Offset = "0x9793", VA = "0x9793")]
		private void CaptainInvitesChangedEvent()
		{
		/* --- GHIDRA: CaptainInvitesChangedEvent ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__CaptainInvitesChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a578ef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_CaptainInvitesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_LicenceCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_TeamInfoReceivedEvent__);
		    DAT_ram_00a578ef = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_CaptainInvitesChangedEvent__,
		             0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x30) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x30) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x3c);
		  uVar1 = unnamed_function_1417(System_Action_TeamData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_TeamInfoReceivedEvent__,0);
		  iVar3 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_TeamData__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x3c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_TeamData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x3c) = iVar4;
		    uVar1 = System_Action_TeamData__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_TeamData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_LicenceCountChangedEvent__,0)
		  ;
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x38) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar2) && (*(int **)(param2 + 0x38) = piVar2, *piVar2 == iVar3))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar2,iVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x9794", Offset = "0x9794", VA = "0x9794", Slot = "21")]
		protected override void ResetEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a578f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TeamData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_CaptainInvitesChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_LicenceCountChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_TeamInfoReceivedEvent__);
		    DAT_ram_00a578f0 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_CaptainInvitesChangedEvent__,
		             0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x30) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x30) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x3c);
		  uVar1 = unnamed_function_1417(System_Action_TeamData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_TeamInfoReceivedEvent__,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_TeamData__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x3c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_TeamData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(param2 + 0x3c) = iVar4;
		    uVar1 = System_Action_TeamData__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_TeamData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_LicenceCountChangedEvent__,0)
		  ;
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x38) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar2) && (*(int **)(param2 + 0x38) = piVar2, *piVar2 == iVar3))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar2,iVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x9795", Offset = "0x9795", VA = "0x9795", Slot = "22")]
		protected override void SetupEvents(BossInstanceEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Sorting_AbstractSortControlView_BossInviteData__remove_ComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_BossInviteData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_AcceptButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_BuyLicenceButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_ListAdapterOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_RefuseButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_SortControlOnComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a578f1 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x44) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_AcceptButtonClickHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x48) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_RefuseButtonClickHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x3c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_BuyLicenceButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_BuyLicenceButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_BossInviteData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_ListAdapterOnSelectedEvent__,
		             0);
		  Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__add_SelectedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_IGameDataComparer_BossInviteData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_SortControlOnComparerChangedEvent__
		             ,0);
		  UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___get_SelectedFilter
		            (uVar2,uVar1,
		             Method_UI_Sorting_AbstractSortControlView_BossInviteData__remove_ComparerChangedEvent__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004924")]
		[Address(RVA = "0x9796", Offset = "0x9796", VA = "0x9796", Slot = "23")]
		protected override void ResetView(BossInvitesView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__ResetView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a578f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_BossInviteData__add_ComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossInvitesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IGameDataComparer_BossInviteData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_AcceptButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_BuyLicenceButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_ListAdapterOnSelectedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator_RefuseButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator_SortControlOnComparerChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a578f2 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x44) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_AcceptButtonClickHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x48) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_RefuseButtonClickHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x3c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_BuyLicenceButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_BuyLicenceButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x24);
		  uVar1 = unnamed_function_1417(System_Action_BossInviteData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_ListAdapterOnSelectedEvent__,
		             0);
		  Gameplay_Boss_View_InvitesTab_BossInviteItemView___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param2 + 0x38);
		  uVar1 = unnamed_function_1417(System_Action_IGameDataComparer_BossInviteData___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator_SortControlOnComparerChangedEvent__
		             ,0);
		  UI_Sorting_AbstractSortControlView___Il2CppFullySharedGenericType___SwitcherValueChangedHandler
		            (uVar2,uVar1,
		             Method_UI_Sorting_AbstractSortControlView_BossInviteData__add_ComparerChangedEvent__);
		  Gameplay_Boss_Controller_BossAssistantViewMediator__RenderInvites(param1,param1);
		  Gameplay_Boss_Controller_BossAssistantViewMediator__ListAdapterOnSelectedEvent(param1,param1);
		  Gameplay_Boss_Controller_BossCaptainViewMediator__TrySelectLastSavedOptionAndVariant
		            (*(undefined4 *)(param2 + 0x28),*(undefined4 *)(*(int *)(param1 + 8) + 0x30),0);
		  return;
		}
		*/

		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004925")]
		[Address(RVA = "0x9797", Offset = "0x9797", VA = "0x9797", Slot = "24")]
		protected override void SetupView(BossInvitesView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a578f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInviteData__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BossInviteData__get_List__
		              );
		    DAT_ram_00a578f3 = '\x01';
		  }
		  Gameplay_Boss_Controller_BossAssistantViewMediator__ListAdapterOnSelectedEvent(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar2 = *(int **)(iVar1 + 0x24);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x24) + 0xa4) + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (uVar3,*(undefined4 *)(*(int *)(iVar1 + 0x24) + 0xa8),
		                     Method_System_Collections_Generic_List_BossInviteData__IndexOf__);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x398) * 4))
		            (piVar2,uVar3,0x3e99999a,0,0,0,0,0,*(undefined4 *)(iVar1 + 0x39c));
		  return;
		}
		*/

		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004926")]
		[Address(RVA = "0x9798", Offset = "0x9798", VA = "0x9798")]
		private void SortControlOnComparerChangedEvent(IGameDataComparer<BossInviteData> comparer)
		{
		/* --- GHIDRA: SortControlOnComparerChangedEvent ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__SortControlOnComparerChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param3;
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a578f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossInvitesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator__BuyLicenceButtonClickHandler_b__10_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_3634);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3633);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3646);
		    DAT_ram_00a578f4 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 8) + 0x40) ==
		      *(int *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0xc) + 0x14)) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3646,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,5,param3,0);
		    return;
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3634,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3633,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar2,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x30) + 0xc) + 0x18);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  *(undefined4 *)(iVar3 + 0xc) = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  *(int *)(iVar2 + 0x10) = iVar3;
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Gameplay_Boss_Controller_BossAssistantViewMediator__BuyLicenceButtonClickHandler_b__10_0__
		             ,0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  *(int *)(iVar2 + 0x14) = iVar3;
		  iVar3 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar3,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = UI_Windows_DialogWindow__get_OK_LABEL(0);
		  *(undefined4 *)(iVar3 + 8) = uVar1;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = iVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004927")]
		[Address(RVA = "0x9799", Offset = "0x9799", VA = "0x9799")]
		private void BuyLicenceButtonClickHandler()
		{
		/* --- GHIDRA: BuyLicenceButtonClickHandler ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__BuyLicenceButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_Controller_BossInstanceController__AcceptInvite
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(iVar1 + 0x24) + 0xa8) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004928")]
		[Address(RVA = "0x979A", Offset = "0x979A", VA = "0x979A")]
		private void RefuseButtonClickHandler()
		{
		/* --- GHIDRA: RefuseButtonClickHandler ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__RefuseButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_Controller_BossInstanceController__KickAssistant
		            (param1_00,*(undefined8 *)(*(int *)(*(int *)(iVar1 + 0x24) + 0xa8) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004929")]
		[Address(RVA = "0x979B", Offset = "0x979B", VA = "0x979B")]
		private void AcceptButtonClickHandler()
		{
		/* --- GHIDRA: AcceptButtonClickHandler ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__AcceptButtonClickHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  Gameplay_Boss_Controller_BossInstanceController__GetPlace
		            (param1_00,*(undefined8 *)(param2 + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492A")]
		[Address(RVA = "0x979C", Offset = "0x979C", VA = "0x979C")]
		private void ListAdapterOnSelectedEvent(BossInviteData invite)
		{
		/* --- GHIDRA: ListAdapterOnSelectedEvent ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__ListAdapterOnSelectedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  
		  if (DAT_ram_00a578f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_AbstractSortControlView_BossInviteData__get_SelectedFilter__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossInvitesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_Controller_BossAssistantViewMediator__RenderInvites_b__14_1__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_BossInviteData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_BossInviteData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_BossInviteData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BossInviteData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_BossInviteData__BossInviteData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IEnumerableExt_SortGameData_BossInviteData__BossInviteData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInviteData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator___c__RenderInvites_b__14_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo);
		    DAT_ram_00a578f5 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1[2] + 0x2c) + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar3 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar1 + 0x2c),1,
		               Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		              );
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar1 + 0x2c),2,
		             Method_UI_MonoBehaviourWithStates_BossPossibleEmptyWindowStateController_WindowStates__set_CurrentState__
		            );
		  uVar4 = *(undefined4 *)(param1[2] + 0x2c);
		  if (*(int *)(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo + 0x5c);
		  iVar1 = puVar5[1];
		  if (iVar1 == 0) {
		    if (*(int *)(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo);
		      puVar5 = *(undefined4 **)
		                (Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar5;
		    iVar1 = unnamed_function_1417(System_Func_BossInviteData__BossInviteData__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar1,uVar2,
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator___c__RenderInvites_b__14_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Boss_Controller_BossAssistantViewMediator___c_TypeInfo + 0x5c) + 4) =
		         iVar1;
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = func_ii_7521(uVar4,iVar1,*(undefined4 *)(*(int *)(iVar3 + 0x38) + 0x28),
		                       Method_Core_Extensions_IEnumerableExt_SortGameData_BossInviteData__BossInviteData___
		                      );
		  uVar4 = System_Linq_Enumerable__Select_object__object_
		                    (uVar4,Method_System_Linq_Enumerable_ToList_BossInviteData___);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__UpdateViewsHolder
		            (*(undefined4 *)(iVar1 + 0x24),uVar4,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(*(int *)(iVar1 + 0x24) + 0xa8) != 0) {
		    uVar2 = unnamed_function_1417(System_Func_BossInviteData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,param1,
		               Method_Gameplay_Boss_Controller_BossAssistantViewMediator__RenderInvites_b__14_1__,0)
		    ;
		    iVar1 = System_Func_object__bool____ctor
		                      (uVar4,uVar2,Method_System_Linq_Enumerable_FirstOrDefault_BossInviteData___);
		    if (iVar1 != 0) goto code_r0x80df9a80;
		  }
		  iVar1 = System_Linq_Enumerable__Count_object_
		                    (uVar4,Method_System_Linq_Enumerable_First_BossInviteData___);
		code_r0x80df9a80:
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_InvitesTab_BossInvitesListAdapter__BossInviteItemViewOnClickEvent
		            (*(undefined4 *)(iVar3 + 0x24),iVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600492B RID: 18731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492B")]
		[Address(RVA = "0x979D", Offset = "0x979D", VA = "0x979D")]
		private void RenderInvites()
		{
		/* --- GHIDRA: RenderInvites ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__RenderInvites
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a578f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BossInstanceModel__BossInstanceEvents__BossInstanceController__BossInvitesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25102);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3638);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25101);
		    DAT_ram_00a578f6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar1 != 0) {
		    uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    local_4 = *(undefined4 *)(param1[2] + 0x40);
		    uVar3 = func_ii_4443(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar2,StringLiteral_25101,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    local_4 = *(undefined4 *)(*(int *)(*(int *)(param1[2] + 0x30) + 0xc) + 0x14);
		    uVar3 = func_ii_4443(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar2,StringLiteral_25102,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3638,1,0,1,0,0,0,0);
		    uVar2 = Core_GameLocalization__GetTranslation(uVar3,uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = **(int **)(iVar1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (*(int **)(iVar1 + 0x30),uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = **(int **)(iVar1 + 0x34);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (*(int **)(iVar1 + 0x34),uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600492C")]
		[Address(RVA = "0x979E", Offset = "0x979E", VA = "0x979E")]
		private void RenderLicenceCount()
		{
		/* --- GHIDRA: RenderLicenceCount ---
		void Gameplay_Boss_Controller_BossAssistantViewMediator__RenderLicenceCount
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Boss_Controller_BossInstanceController__RefuseInvite(param1_00,param1);
		  return;
		}
		*/

		}
	}
}
