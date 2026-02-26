using System;
using AssetContent;
using Core.Data;
using Gameplay.Inventory.View.Info.InfoBox;
using Gameplay.WorldAxis.ColossusInfo.Controller.ColossusInfo;
using Gameplay.WorldAxis.ColossusInfo.Events;
using Gameplay.WorldAxis.ColossusInfo.Model;
using Gameplay.WorldAxis.Controller;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	public class ColossusInfoWindow : ClosableBaseWindow<ColossusInfoWindow.ColossusInfoWindowArgs>
	{
		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CA")]
		public override string WindowId
		{
			[Token(Token = "0x600125D")]
			[Address(RVA = "0x6457", Offset = "0x6457", VA = "0x6457", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CB")]
		public ColossusRatingTable RatingTable
		{
			[Token(Token = "0x600125E")]
			[Address(RVA = "0x6458", Offset = "0x6458", VA = "0x6458")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CC")]
		public TabBar TabBar
		{
			[Token(Token = "0x600125F")]
			[Address(RVA = "0x6459", Offset = "0x6459", VA = "0x6459")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CD")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x645A", Offset = "0x645A", VA = "0x645A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CE")]
		public ColossusDescription ColossusDescription
		{
			[Token(Token = "0x6001261")]
			[Address(RVA = "0x645B", Offset = "0x645B", VA = "0x645B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002CF")]
		public ColossusTreasuryView TreasuryTab
		{
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x645C", Offset = "0x645C", VA = "0x645C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D0")]
		public GameObject InfoTab
		{
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x645D", Offset = "0x645D", VA = "0x645D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D1")]
		public TitleRowView ClassRow
		{
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x645E", Offset = "0x645E", VA = "0x645E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D2")]
		public TitleRowView PartyRow
		{
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x645F", Offset = "0x645F", VA = "0x645F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D3")]
		public TextMeshProUGUI BattleStatusText
		{
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x6460", Offset = "0x6460", VA = "0x6460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D4")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x6461", Offset = "0x6461", VA = "0x6461")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D5")]
		public Button AttackButton
		{
			[Token(Token = "0x6001268")]
			[Address(RVA = "0x6462", Offset = "0x6462", VA = "0x6462")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D6")]
		public Button JoinSquadButton
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x6463", Offset = "0x6463", VA = "0x6463")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D7")]
		public Button CreateClanButton
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x6464", Offset = "0x6464", VA = "0x6464")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D8")]
		public IndexButtonBasic SquadButton
		{
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x6465", Offset = "0x6465", VA = "0x6465")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002D9")]
		public IndexButtonBasic ClassButton
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x6466", Offset = "0x6466", VA = "0x6466")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x6467", Offset = "0x6467", VA = "0x6467", Slot = "22")]
		protected override void OnShow(ColossusInfoWindow.ColossusInfoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58bca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__OnClose__
		              );
		    DAT_ram_00a58bca = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__OnClose__
		            );
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x84),0);
		  iVar1 = **(int **)(param1 + 0x88);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x88),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x84);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x84),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x7c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x7c),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x84) = 0;
		  *(undefined4 *)(param1 + 0x7c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x6468", Offset = "0x6468", VA = "0x6468", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 param3;
		  int iVar8;
		  
		  if (DAT_ram_00a58bcb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ColossusInfo_Events_ColossusInfoEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58bcb = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80f8469b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f8469b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar7 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		                      );
		  param3 = *(undefined4 *)(iVar7 + 0x1c);
		  iVar7 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		                      );
		  iVar8 = **(int **)(iVar7 + 0x20);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x100) * 4))
		                    (*(int **)(iVar7 + 0x20),*(undefined4 *)(iVar8 + 0x104));
		  uVar5 = unnamed_function_1417(Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel_TypeInfo);
		  Gameplay_WorldAxis_ColossusInfo_Model_ColossusInfoModel__get_IsMyColossus
		            (uVar5,uVar3,param3,uVar4,uVar3);
		  *(undefined4 *)(param1 + 0x7c) = uVar5;
		  iVar7 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		                      );
		  iVar8 = **(int **)(iVar7 + 0x20);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x110) * 4))
		                    (*(int **)(iVar7 + 0x20),*(undefined4 *)(iVar8 + 0x114));
		  iVar7 = unnamed_function_1417(Gameplay_WorldAxis_ColossusInfo_Events_ColossusInfoEvents_TypeInfo);
		  *(undefined4 *)(iVar7 + 0x14) = uVar3;
		  *(int *)(param1 + 0x80) = iVar7;
		  uVar4 = *(undefined4 *)(param1 + 0x7c);
		  uVar3 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoController_TypeInfo
		                    );
		  Gameplay_WorldAxis_ColossusInfo_Controller_ColossusTreasuryController___c__DisplayClass4_0___BuyTreasuryOption_b__0
		            (uVar3,uVar4,iVar7,iVar7);
		  *(undefined4 *)(param1 + 0x84) = uVar3;
		  uVar4 = *(undefined4 *)(param1 + 0x7c);
		  uVar5 = *(undefined4 *)(param1 + 0x80);
		  piVar6 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_WorldAxis_ColossusInfo_Controller_ColossusInfo_ColossusInfoViewMediator_TypeInfo
		                            );
		  if (DAT_ram_00a58c00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow___ctor__
		              );
		    DAT_ram_00a58c00 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar6,uVar4,uVar5,uVar3,
		             Method_MVC_AbstractViewMediator_ColossusInfoModel__ColossusInfoEvents__ColossusInfoController__ColossusInfoWindow___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		            (piVar6,param1,*(undefined4 *)(*piVar6 + 0x164));
		  *(int **)(param1 + 0x88) = piVar6;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x84),0);
		  iVar7 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__get_WindowArgs__
		                      );
		  Gameplay_WorldAxis_Controller_WorldAxisController__GetAvailableDollsResultHandler
		            (*(undefined4 *)(iVar7 + 0x20),0);
		  return;
		}
		*/

		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x6469", Offset = "0x6469", VA = "0x6469")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x84),0);
		  iVar1 = **(int **)(param1 + 0x88);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x88),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x84);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x84),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x7c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x7c),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x84) = 0;
		  *(undefined4 *)(param1 + 0x7c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x646A", Offset = "0x646A", VA = "0x646A")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bcc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs___ctor__
		              );
		    DAT_ram_00a58bcc = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x646B", Offset = "0x646B", VA = "0x646B")]
		public ColossusInfoWindow()
		{
		}

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/WorldAxis/ColossusInfoWindow";

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ColossusRatingTable _ratingTable;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _bigAvatar;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ColossusDescription _colossusDescription;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ColossusTreasuryView _treasuryTab;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _infoTab;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TitleRowView _classRow;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TitleRowView _partyRow;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _battleStatus;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _attackButton;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _joinSquadButton;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _createClanButton;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private IndexButtonBasic _squadButton;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private IndexButtonBasic _classButton;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x7C")]
		private ColossusInfoModel _model;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x80")]
		private ColossusInfoEvents _events;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x84")]
		private ColossusInfoController _controller;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x88")]
		private ColossusInfoViewMediator _mediator;

		// Token: 0x0200031D RID: 797
		[Token(Token = "0x200031D")]
		public enum Tab
		{
			// Token: 0x040009E7 RID: 2535
			[Token(Token = "0x40009E7")]
			RATING,
			// Token: 0x040009E8 RID: 2536
			[Token(Token = "0x40009E8")]
			DESCRIPTION,
			// Token: 0x040009E9 RID: 2537
			[Token(Token = "0x40009E9")]
			TREASURY
		}

		// Token: 0x0200031E RID: 798
		[Token(Token = "0x200031E")]
		public class ColossusInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001272 RID: 4722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x646C", Offset = "0x646C", VA = "0x646C")]
			public ColossusInfoWindowArgs()
			{
			}

			// Token: 0x040009EA RID: 2538
			[Token(Token = "0x40009EA")]
			[FieldOffset(Offset = "0x18")]
			public ColossusInfoWindow.Tab TabToOpen;

			// Token: 0x040009EB RID: 2539
			[Token(Token = "0x40009EB")]
			[FieldOffset(Offset = "0x1C")]
			public ColossusBattleData ColossusBattleData;

			// Token: 0x040009EC RID: 2540
			[Token(Token = "0x40009EC")]
			[FieldOffset(Offset = "0x20")]
			public WorldAxisController WorldAxisController;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ClassButton ---
		void Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow__get_ClassButton
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58bc9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__OnShow__
		              );
		    DAT_ram_00a58bc9 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_ColossusInfoWindow_ColossusInfoWindowArgs__OnShow__
		              );
		  Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow__OnClose(param1,param1);
		  param1_00 = *(undefined4 *)(param1 + 0x40);
		  param2_00 = Core_Extensions_Dict_ColossusDicExt__GetIcon256
		                        (*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

}
