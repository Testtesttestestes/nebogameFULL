using System;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Clan.Control;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View;
using Gameplay.Accounts.View.Accounts;
using Gameplay.SmallGames.View.DailyRewards;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Accounts.Clan.View
{
	// Token: 0x02000DEC RID: 3564
	[Token(Token = "0x2000DEC")]
	public class ClanAccountView : AbstractAccountView
	{
		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060056FE RID: 22270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011B9")]
		public OptionBuyButtonItem OptionViewPrefab
		{
			[Token(Token = "0x60056FE")]
			[Address(RVA = "0xA47A", Offset = "0xA47A", VA = "0xA47A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BA")]
		public SimpleIconValue BonusPrefab
		{
			[Token(Token = "0x60056FF")]
			[Address(RVA = "0xA47B", Offset = "0xA47B", VA = "0xA47B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06005700 RID: 22272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BB")]
		public Transform OptionsContainer
		{
			[Token(Token = "0x6005700")]
			[Address(RVA = "0xA47C", Offset = "0xA47C", VA = "0xA47C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BC")]
		public TextMeshProUGUI ActiveAccountStatusField
		{
			[Token(Token = "0x6005701")]
			[Address(RVA = "0xA47D", Offset = "0xA47D", VA = "0xA47D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BD")]
		public Transform Bonuses
		{
			[Token(Token = "0x6005702")]
			[Address(RVA = "0xA47E", Offset = "0xA47E", VA = "0xA47E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BE")]
		public ClanAccountTabView[] Tabs
		{
			[Token(Token = "0x6005703")]
			[Address(RVA = "0xA47F", Offset = "0xA47F", VA = "0xA47F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06005704 RID: 22276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011BF")]
		public TextMeshProUGUI ContentTitle
		{
			[Token(Token = "0x6005704")]
			[Address(RVA = "0xA480", Offset = "0xA480", VA = "0xA480")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000206 RID: 518
		// (add) Token: 0x06005705 RID: 22277 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005706 RID: 22278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000206")]
		public event Action<ClanAccountTabView> TabSelectedEvent
		{
			[Token(Token = "0x6005705")]
			[Address(RVA = "0xA481", Offset = "0xA481", VA = "0xA481")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005706")]
			[Address(RVA = "0xA482", Offset = "0xA482", VA = "0xA482")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005707")]
		[Address(RVA = "0xA483", Offset = "0xA483", VA = "0xA483", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__Dispose
		               (int *param1,int *param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param3_00;
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int param1_02;
		  undefined4 param3_01;
		  undefined4 param4_00;
		  
		  if (DAT_ram_00a588ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Clan_Control_ClanAccountController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccountGroup_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Clan_Model_ClanAccountModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_TypeInfo);
		    DAT_ram_00a588ef = '\x01';
		  }
		  if (param3 != (int *)param1[10]) {
		    param1[10] = (int)param3;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x104));
		  }
		  param3_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0x114));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x104));
		  param3_01 = *(undefined4 *)(iVar1 + 0x24);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x100) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x104));
		  param4_00 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Accounts_Clan_Model_ClanAccountModel_TypeInfo);
		  if (param3 != (int *)0x0) {
		    if (((uint)*(byte *)(*param3 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccountGroup_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param3 + 100) +
		                 (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccountGroup_TypeInfo + 0xb8) * 4
		                + -4) != Gameplay_Accounts_Model_Data_ClanAccountGroup_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param3,Gameplay_Accounts_Model_Data_ClanAccountGroup_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Accounts_Clan_Model_ClanAccountModel__Dispose
		            (param1_00,param3,param3_01,param4_00,param2);
		  iVar1 = unnamed_function_1417(Gameplay_Accounts_Clan_Control_ClanAccountController_TypeInfo);
		  if (DAT_ram_00a588f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanAccountModel__AccountsEvents___ctor__);
		    DAT_ram_00a588f5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar1,param1_00,param3_00,
		             Method_MVC_AbstractController_ClanAccountModel__AccountsEvents___ctor__);
		  *(int **)(iVar1 + 0x18) = param2;
		  param1[0x17] = iVar1;
		  param1_01 = (int *)unnamed_function_1417
		                               (Gameplay_Accounts_Clan_Control_ClanAccountViewMediator_TypeInfo);
		  if (DAT_ram_00a588f8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		    DAT_ram_00a588f8 = '\x01';
		  }
		  param1_02 = unnamed_function_1417(System_Collections_Generic_List_OptionBuyButtonItem__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_02,Method_System_Collections_Generic_List_OptionBuyButtonItem___ctor__);
		  param1_01[6] = param1_02;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_01,param1_00,param3_00,iVar1,
		             Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView___ctor__
		            );
		  param1[0x16] = (int)param1_01;
		  (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x160) * 4))
		            (param1_01,param1,*(undefined4 *)(*param1_01 + 0x164));
		  MVC_AbstractController__Dispose(param1[0x17],0);
		  return;
		}
		*/

		}

		// Token: 0x06005708 RID: 22280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005708")]
		[Address(RVA = "0xA484", Offset = "0xA484", VA = "0xA484", Slot = "7")]
		public override void Init(AccountsController controller, IAccountDataDecorator data)
		{
		/* --- GHIDRA: Init ---
		undefined4
		Gameplay_Accounts_Clan_View_ClanAccountView__Init
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  
		  if (DAT_ram_00a588f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Clan_View_ClanAccountView___c__DisplayClass28_0__AddTab_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Accounts_Clan_View_ClanAccountView___c__DisplayClass28_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a588f0 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Accounts_Clan_View_ClanAccountView___c__DisplayClass28_0_TypeInfo)
		  ;
		  *(int *)(param2_00 + 8) = param1;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x40) + param2 * 4 + 0x10);
		  *(undefined4 *)(param2_00 + 0xc) = uVar1;
		  Gameplay_SmallGames_View_DailyRewards_RewardsTab__set_Selected
		            (uVar1,*(undefined4 *)(param1 + 0x30),*(undefined4 *)(param1 + 0x34),0);
		  param1_01 = *(int *)(param2_00 + 0xc);
		  if (param3 != *(int *)(param1_01 + 100)) {
		    *(int *)(param1_01 + 100) = param3;
		    Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__UpdateStatusText(param1_01,param2_00);
		    param1_01 = *(int *)(param2_00 + 0xc);
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1_01 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param2_00,
		             Method_Gameplay_Accounts_Clan_View_ClanAccountView___c__DisplayClass28_0__AddTab_b__0__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_00,uVar1,0);
		  return *(undefined4 *)(param2_00 + 0xc);
		}
		*/

		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005709")]
		[Address(RVA = "0xA485", Offset = "0xA485", VA = "0xA485")]
		public RewardsTab AddTab(int index, IAccountDataDecorator account)
		{
		/* --- GHIDRA: AddTab ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__AddTab(int param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Accounts_Clan_View_ClanAccountView__SelectTab
		            (param1,*(undefined4 *)(*(int *)(param1 + 0x40) + param2 * 4 + 0x10),param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570A")]
		[Address(RVA = "0xA486", Offset = "0xA486", VA = "0xA486")]
		public void SelectTab(int index)
		{
		/* --- GHIDRA: SelectTab ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__SelectTab
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a588f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a588f1 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,param2,0);
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x54);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		    if (iVar1 != 0) {
		      Gameplay_SmallGames_View_DailyRewards_RewardsTab__get_Selected
		                (*(undefined4 *)(param1 + 0x54),0,0);
		    }
		    *(undefined4 *)(param1 + 0x54) = param2;
		    Gameplay_SmallGames_View_DailyRewards_RewardsTab__get_Selected(param2,1,0);
		    iVar1 = *(int *)(param1 + 0x50);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570B")]
		[Address(RVA = "0xA487", Offset = "0xA487", VA = "0xA487")]
		private void InvokeSelectedEvent(ClanAccountTabView tab)
		{
		/* --- GHIDRA: InvokeSelectedEvent ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__InvokeSelectedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588f2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		    DAT_ram_00a588f2 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600570C RID: 22284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570C")]
		[Address(RVA = "0xA488", Offset = "0xA488", VA = "0xA488", Slot = "8")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_AccountViewStates___ctor__);
		    DAT_ram_00a588a7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_AccountViewStates___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600570D RID: 22285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600570D")]
		[Address(RVA = "0xA489", Offset = "0xA489", VA = "0xA489")]
		public ClanAccountView()
		{
		}

		// Token: 0x04002F0F RID: 12047
		[Token(Token = "0x4002F0F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _contentTitle;

		// Token: 0x04002F10 RID: 12048
		[Token(Token = "0x4002F10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _activeTabsParent;

		// Token: 0x04002F11 RID: 12049
		[Token(Token = "0x4002F11")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RectTransform _inactiveTabsParent;

		// Token: 0x04002F12 RID: 12050
		[Token(Token = "0x4002F12")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _bonuses;

		// Token: 0x04002F13 RID: 12051
		[Token(Token = "0x4002F13")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _activeAccountStatusField;

		// Token: 0x04002F14 RID: 12052
		[Token(Token = "0x4002F14")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClanAccountTabView[] _tabs;

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _optionsContainer;

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleIconValue _bonusPrefab;

		// Token: 0x04002F17 RID: 12055
		[Token(Token = "0x4002F17")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OptionBuyButtonItem _optionViewPrefab;

		// Token: 0x04002F19 RID: 12057
		[Token(Token = "0x4002F19")]
		[FieldOffset(Offset = "0x54")]
		private ClanAccountTabView _selectedTab;

		// Token: 0x04002F1A RID: 12058
		[Token(Token = "0x4002F1A")]
		[FieldOffset(Offset = "0x58")]
		private ClanAccountViewMediator _mediator;

		// Token: 0x04002F1B RID: 12059
		[Token(Token = "0x4002F1B")]
		[FieldOffset(Offset = "0x5C")]
		private ClanAccountController _controller;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ContentTitle ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__get_ContentTitle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a588ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanAccountTabView__TypeInfo);
		    DAT_ram_00a588ed = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ClanAccountTabView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanAccountTabView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
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


		/* --- GHIDRA: add_TabSelectedEvent ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__add_TabSelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a588ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanAccountTabView__TypeInfo);
		    DAT_ram_00a588ee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ClanAccountTabView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanAccountTabView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
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


		/* --- GHIDRA: remove_TabSelectedEvent ---
		void Gameplay_Accounts_Clan_View_ClanAccountView__remove_TabSelectedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x40);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x24) + 0xb4),0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x5c),0);
		  iVar2 = **(int **)(param1 + 0x5c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x5c),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar2 + 0x134));
		  *(undefined4 *)(param1 + 0x28) = 0;
		  *(undefined8 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

}
