using System;
using Gameplay.Combat.View.TurnDisplay;
using Gameplay.Duel.Controller;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Requirements;
using UI.Rewards;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085A RID: 2138
	[Token(Token = "0x200085A")]
	public class DuelWindow : ClosableBaseWindow<DuelWindow.DuelWindowArgs>
	{
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E6")]
		public override string WindowId
		{
			[Token(Token = "0x600323A")]
			[Address(RVA = "0x8290", Offset = "0x8290", VA = "0x8290", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E7")]
		public MarshalUserView Opponent
		{
			[Token(Token = "0x600323B")]
			[Address(RVA = "0x8291", Offset = "0x8291", VA = "0x8291")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x0600323C RID: 12860 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E8")]
		public MarshalUserView Player
		{
			[Token(Token = "0x600323C")]
			[Address(RVA = "0x8292", Offset = "0x8292", VA = "0x8292")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009E9")]
		public SkillsComparer SkillsComparer
		{
			[Token(Token = "0x600323D")]
			[Address(RVA = "0x8293", Offset = "0x8293", VA = "0x8293")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600323E RID: 12862 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009EA")]
		public ButtonWithCost ActionButton
		{
			[Token(Token = "0x600323E")]
			[Address(RVA = "0x8294", Offset = "0x8294", VA = "0x8294")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009EB")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x600323F")]
			[Address(RVA = "0x8295", Offset = "0x8295", VA = "0x8295")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009EC")]
		public RequirementsView Requirements
		{
			[Token(Token = "0x6003240")]
			[Address(RVA = "0x8296", Offset = "0x8296", VA = "0x8296")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06003241 RID: 12865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009ED")]
		public TurnClock Timer
		{
			[Token(Token = "0x6003241")]
			[Address(RVA = "0x8297", Offset = "0x8297", VA = "0x8297")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009EE")]
		public GameObject LegendaryView
		{
			[Token(Token = "0x6003242")]
			[Address(RVA = "0x8298", Offset = "0x8298", VA = "0x8298")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003243")]
		[Address(RVA = "0x8299", Offset = "0x8299", VA = "0x8299", Slot = "22")]
		protected override void OnShow(DuelWindow.DuelWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Duel_View_DuelWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57bce == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs__OnClose__);
		    DAT_ram_00a57bce = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs__OnClose__);
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x60) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003244")]
		[Address(RVA = "0x829A", Offset = "0x829A", VA = "0x829A", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		uint Gameplay_Duel_View_DuelWindow__OnClose(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bcf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DuelStates_State__get_CurrentState__);
		    DAT_ram_00a57bcf = '\x01';
		  }
		  return (uint)(*(int *)(*(int *)(param1 + 0x54) + 0x18) != 2);
		}
		*/

		}

		// Token: 0x06003245 RID: 12869 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x6003245")]
		[Address(RVA = "0x829B", Offset = "0x829B", VA = "0x829B", Slot = "17")]
		public override bool CheckForClose()
		{
		/* --- GHIDRA: CheckForClose ---
		void Gameplay_Duel_View_DuelWindow__CheckForClose(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param3;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined8 uVar3;
		  int *param4;
		  
		  if (DAT_ram_00a57bd0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_DuelWindow_DuelWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Duel_Controller_DuelViewMediator_TypeInfo);
		    DAT_ram_00a57bd0 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_DuelWindow_DuelWindowArgs__get_WindowArgs__);
		  param4 = *(int **)(iVar1 + 0x18);
		  uVar3 = CONCAT44(in_register_20000014,*(undefined4 *)(*param4 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))(param4,uVar3);
		  uVar3 = CONCAT44((int)((ulonglong)uVar3 >> 0x20),*(undefined4 *)(*param4 + 0x114));
		  param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))(param4,uVar3);
		  uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_Duel_Controller_DuelViewMediator_TypeInfo);
		  if (DAT_ram_00a57c06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow___ctor__
		              );
		    DAT_ram_00a57c06 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,iVar1,param3,param4,
		             Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow___ctor__
		            );
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x148) * 4))
		                    (param1_00,CONCAT44(uVar2,*(undefined4 *)(*param1_00 + 0x14c)));
		  uVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x14) + 8),0);
		  Gameplay_Duel_Controller_DuelController__PerformIntelligenceResultHandler(uVar2,uVar3,param1_00);
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  *(int **)(param1 + 0x60) = param1_00;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003246")]
		[Address(RVA = "0x829C", Offset = "0x829C", VA = "0x829C")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Duel_View_DuelWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x60) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003247")]
		[Address(RVA = "0x829D", Offset = "0x829D", VA = "0x829D")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Duel_View_DuelWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bd1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs___ctor__);
		    DAT_ram_00a57bd1 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003248 RID: 12872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003248")]
		[Address(RVA = "0x829E", Offset = "0x829E", VA = "0x829E")]
		public DuelWindow()
		{
		}

		// Token: 0x04001B72 RID: 7026
		[Token(Token = "0x4001B72")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Duel/DuelWindow";

		// Token: 0x04001B73 RID: 7027
		[Token(Token = "0x4001B73")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MarshalUserView _player;

		// Token: 0x04001B74 RID: 7028
		[Token(Token = "0x4001B74")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MarshalUserView _opponent;

		// Token: 0x04001B75 RID: 7029
		[Token(Token = "0x4001B75")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SkillsComparer _skillsComparer;

		// Token: 0x04001B76 RID: 7030
		[Token(Token = "0x4001B76")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ButtonWithCost _actionButton;

		// Token: 0x04001B77 RID: 7031
		[Token(Token = "0x4001B77")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04001B78 RID: 7032
		[Token(Token = "0x4001B78")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RequirementsView _reqirements;

		// Token: 0x04001B79 RID: 7033
		[Token(Token = "0x4001B79")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DuelStates _duelStates;

		// Token: 0x04001B7A RID: 7034
		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TurnClock _timer;

		// Token: 0x04001B7B RID: 7035
		[Token(Token = "0x4001B7B")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _legendaryView;

		// Token: 0x04001B7C RID: 7036
		[Token(Token = "0x4001B7C")]
		[FieldOffset(Offset = "0x60")]
		private DuelViewMediator _mediator;

		// Token: 0x0200085B RID: 2139
		[Token(Token = "0x200085B")]
		public class DuelWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003249 RID: 12873 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003249")]
			[Address(RVA = "0x829F", Offset = "0x829F", VA = "0x829F")]
			public DuelWindowArgs()
			{
			}

			// Token: 0x04001B7D RID: 7037
			[Token(Token = "0x4001B7D")]
			[FieldOffset(Offset = "0x18")]
			public DuelController Controller;

			// Token: 0x04001B7E RID: 7038
			[Token(Token = "0x4001B7E")]
			[FieldOffset(Offset = "0x1C")]
			public DuelStates.State DuelState;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LegendaryView ---
		void Gameplay_Duel_View_DuelWindow__get_LegendaryView(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57bcd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs__get_BackButton__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DuelStates_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_DuelStates_State__set_CurrentState__);
		    DAT_ram_00a57bcd = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_DuelWindow_DuelWindowArgs__OnShow__);
		  Gameplay_Duel_View_DuelWindow__CheckForClose(param1,param1);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(param1 + 0x54),*(undefined4 *)(param2 + 0x1c),
		             Method_UI_MonoBehaviourWithStates_DuelStates_State__set_CurrentState__);
		  if (*(int *)(*(int *)(param1 + 0x54) + 0x18) == 2) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x38),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,0,0);
		  }
		  return;
		}
		*/

}
