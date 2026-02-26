using System;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Clans.Office.View.VacanciesTab;
using Gameplay.Rating.Control;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Filters.GenericFilter;
using UI.Elements.RatingElements;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	public class RatingWindow : ClosableBaseWindow<RatingWindow.RatingWindowArgs>
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000625")]
		public override string WindowId
		{
			[Token(Token = "0x60021AF")]
			[Address(RVA = "0x730E", Offset = "0x730E", VA = "0x730E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000626")]
		public TabBar TabBar
		{
			[Token(Token = "0x60021B0")]
			[Address(RVA = "0x730F", Offset = "0x730F", VA = "0x730F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000627")]
		public GenericSubFilterView SubRatings
		{
			[Token(Token = "0x60021B1")]
			[Address(RVA = "0x7310", Offset = "0x7310", VA = "0x7310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000628")]
		public GenericFilterView PeriodFilter
		{
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x7311", Offset = "0x7311", VA = "0x7311")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000629")]
		public DeselectableGenericFilterView ExtraFilter
		{
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x7312", Offset = "0x7312", VA = "0x7312")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700062A")]
		public ClanResumesOSAView UsersOSAView
		{
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x7313", Offset = "0x7313", VA = "0x7313")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700062B")]
		public ClansInRatingsOSAView ClansOSAView
		{
			[Token(Token = "0x60021B5")]
			[Address(RVA = "0x7314", Offset = "0x7314", VA = "0x7314")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700062C")]
		public CultsInRatingOSAView CultsOSAView
		{
			[Token(Token = "0x60021B6")]
			[Address(RVA = "0x7315", Offset = "0x7315", VA = "0x7315")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700062D")]
		public TopLeaders TopLeaders
		{
			[Token(Token = "0x60021B7")]
			[Address(RVA = "0x7316", Offset = "0x7316", VA = "0x7316")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700062E")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x60021B8")]
			[Address(RVA = "0x7317", Offset = "0x7317", VA = "0x7317")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700062F")]
		public RatingsDescription Description
		{
			[Token(Token = "0x60021B9")]
			[Address(RVA = "0x7318", Offset = "0x7318", VA = "0x7318")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000630")]
		public Toggle PeriodFilterToggle
		{
			[Token(Token = "0x60021BA")]
			[Address(RVA = "0x7319", Offset = "0x7319", VA = "0x7319")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000631")]
		public Toggle ExtraFilterToggle
		{
			[Token(Token = "0x60021BB")]
			[Address(RVA = "0x731A", Offset = "0x731A", VA = "0x731A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000632")]
		public Toggle RewardsToggle
		{
			[Token(Token = "0x60021BC")]
			[Address(RVA = "0x731B", Offset = "0x731B", VA = "0x731B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000633")]
		public MyRatingView MyRatingView
		{
			[Token(Token = "0x60021BD")]
			[Address(RVA = "0x731C", Offset = "0x731C", VA = "0x731C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000634")]
		public RatingRewardsView RatingRewards
		{
			[Token(Token = "0x60021BE")]
			[Address(RVA = "0x731D", Offset = "0x731D", VA = "0x731D")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x731E", Offset = "0x731E", VA = "0x731E", Slot = "22")]
		protected override void OnShow(RatingWindow.RatingWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Rating_View_RatingWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58036 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_RatingWindow_RatingWindowArgs__OnClose__);
		    DAT_ram_00a58036 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_RatingWindow_RatingWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x80),0);
		  iVar1 = **(int **)(param1 + 0x84);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x84),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x80);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x80),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x7c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x7c),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x84) = 0;
		  *(undefined8 *)(param1 + 0x7c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x731F", Offset = "0x731F", VA = "0x731F", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Rating_View_RatingWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58037 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_RatingController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Events_RatingEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Control_RatingViewMediator_TypeInfo);
		    DAT_ram_00a58037 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Rating_Events_RatingEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x78) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80e96ae3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e96ae3:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  uVar4 = unnamed_function_1417(Gameplay_Rating_Model_RatingModel_TypeInfo);
		  Gameplay_Rating_Model_RatingModel__get_CultsSubFilters(uVar4,uVar2,uVar2);
		  *(undefined4 *)(param1 + 0x7c) = uVar4;
		  uVar2 = *(undefined4 *)(param1 + 0x78);
		  iVar6 = unnamed_function_1417(Gameplay_Rating_Control_RatingController_TypeInfo);
		  if (DAT_ram_00a58090 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_RatingModel__RatingEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_RatingService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58090 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar6,uVar4,uVar2,Method_MVC_AbstractController_RatingModel__RatingEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_RatingService___);
		  *(undefined4 *)(iVar6 + 0x18) = uVar2;
		  *(int *)(param1 + 0x80) = iVar6;
		  uVar2 = *(undefined4 *)(param1 + 0x7c);
		  uVar4 = *(undefined4 *)(param1 + 0x78);
		  piVar5 = (int *)unnamed_function_1417(Gameplay_Rating_Control_RatingViewMediator_TypeInfo);
		  Gameplay_Rating_Control_RatingViewMediator__Dispose(piVar5,uVar2,uVar4,iVar6,iVar6);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 0x84) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x80),0);
		  return;
		}
		*/

		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x7320", Offset = "0x7320", VA = "0x7320")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Rating_View_RatingWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x80),0);
		  iVar1 = **(int **)(param1 + 0x84);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x84),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x80);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x80),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x7c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x7c),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x84) = 0;
		  *(undefined8 *)(param1 + 0x7c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x7321", Offset = "0x7321", VA = "0x7321")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Rating_View_RatingWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58038 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_RatingWindow_RatingWindowArgs___ctor__);
		    DAT_ram_00a58038 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_RatingWindow_RatingWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x7322", Offset = "0x7322", VA = "0x7322")]
		public RatingWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_RatingWindow___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x18) = 1;
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0400127A RID: 4730
		[Token(Token = "0x400127A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/RatingWindow";

		// Token: 0x0400127B RID: 4731
		[Token(Token = "0x400127B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400127C RID: 4732
		[Token(Token = "0x400127C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400127D RID: 4733
		[Token(Token = "0x400127D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TopLeaders _topLeaders;

		// Token: 0x0400127E RID: 4734
		[Token(Token = "0x400127E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GenericSubFilterView _subRatings;

		// Token: 0x0400127F RID: 4735
		[Token(Token = "0x400127F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GenericFilterView _periodFilter;

		// Token: 0x04001280 RID: 4736
		[Token(Token = "0x4001280")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DeselectableGenericFilterView _extraFilter;

		// Token: 0x04001281 RID: 4737
		[Token(Token = "0x4001281")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RatingsDescription _description;

		// Token: 0x04001282 RID: 4738
		[Token(Token = "0x4001282")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ClanResumesOSAView _usersOSAView;

		// Token: 0x04001283 RID: 4739
		[Token(Token = "0x4001283")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ClansInRatingsOSAView _clansOSAView;

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CultsInRatingOSAView _cultsOSAView;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Toggle _periodFilterToggle;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Toggle _extraFilterToggle;

		// Token: 0x04001287 RID: 4743
		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Toggle _rewardsToggle;

		// Token: 0x04001288 RID: 4744
		[Token(Token = "0x4001288")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MyRatingView _myRatingView;

		// Token: 0x04001289 RID: 4745
		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private RatingRewardsView _ratingRewards;

		// Token: 0x0400128A RID: 4746
		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x78")]
		private RatingEvents _events;

		// Token: 0x0400128B RID: 4747
		[Token(Token = "0x400128B")]
		[FieldOffset(Offset = "0x7C")]
		private RatingModel _model;

		// Token: 0x0400128C RID: 4748
		[Token(Token = "0x400128C")]
		[FieldOffset(Offset = "0x80")]
		private RatingController _controller;

		// Token: 0x0400128D RID: 4749
		[Token(Token = "0x400128D")]
		[FieldOffset(Offset = "0x84")]
		private RatingViewMediator _mediator;

		// Token: 0x02000586 RID: 1414
		[Token(Token = "0x2000586")]
		public class RatingWindowArgs : BaseWindowArgs
		{
			// Token: 0x060021C4 RID: 8644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60021C4")]
			[Address(RVA = "0x7323", Offset = "0x7323", VA = "0x7323")]
			public RatingWindowArgs()
			{
			}

			// Token: 0x0400128E RID: 4750
			[Token(Token = "0x400128E")]
			[FieldOffset(Offset = "0x18")]
			public RatingKindTypeDic.Types.RatingKindType KindType;

			// Token: 0x0400128F RID: 4751
			[Token(Token = "0x400128F")]
			[FieldOffset(Offset = "0x1C")]
			public uint KindId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RatingRewards ---
		void Gameplay_Rating_View_RatingWindow__get_RatingRewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58035 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_RatingWindow_RatingWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CultInRatingsViewsHolder__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInRatingsViewsHolder__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClansInRatingsViewsHolder__Init__
		              );
		    DAT_ram_00a58035 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x58),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInRatingsViewsHolder__Init__
		            );
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x5c),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ClansInRatingsViewsHolder__Init__
		            );
		  Com_TheFallenGames_OSA_Core_OSA_object__object___GetVirtualAbstractNormalizedScrollPosition
		            (*(undefined4 *)(param1 + 0x60),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CultInRatingsViewsHolder__Init__
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_RatingWindow_RatingWindowArgs__OnShow__);
		  Gameplay_Rating_View_RatingWindow__OnClose(param1,param1);
		  return;
		}
		*/

}
