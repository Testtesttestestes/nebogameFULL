using System;
using Gameplay.VortexRating.Controller;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.GreatOnesTab;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Gameplay.VortexRating.View.RulesTab;
using Gameplay.VortexRating.View.VortexTab;
using Gameplay.VortexRating.View.VoteRewardsTab;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	public class VortexRatingWindow : ClosableBaseWindow<VortexRatingWindow.VortexWindowArgs>
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036C")]
		public override string WindowId
		{
			[Token(Token = "0x60014F8")]
			[Address(RVA = "0x66BA", Offset = "0x66BA", VA = "0x66BA", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036D")]
		public TabBar TabBarView
		{
			[Token(Token = "0x60014F9")]
			[Address(RVA = "0x66BB", Offset = "0x66BB", VA = "0x66BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036E")]
		public GreatOnesView GreatOnesTab
		{
			[Token(Token = "0x60014FA")]
			[Address(RVA = "0x66BC", Offset = "0x66BC", VA = "0x66BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700036F")]
		public VoteRewardsView VoteRewardsTab
		{
			[Token(Token = "0x60014FB")]
			[Address(RVA = "0x66BD", Offset = "0x66BD", VA = "0x66BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000370")]
		public RulesView RulesTab
		{
			[Token(Token = "0x60014FC")]
			[Address(RVA = "0x66BE", Offset = "0x66BE", VA = "0x66BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000371")]
		public GreatPrizesView GreatPrizesTab
		{
			[Token(Token = "0x60014FD")]
			[Address(RVA = "0x66BF", Offset = "0x66BF", VA = "0x66BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000372")]
		public VortexView VortexTab
		{
			[Token(Token = "0x60014FE")]
			[Address(RVA = "0x66C0", Offset = "0x66C0", VA = "0x66C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000373")]
		public Button InRatingButton
		{
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x66C1", Offset = "0x66C1", VA = "0x66C1")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x66C2", Offset = "0x66C2", VA = "0x66C2", Slot = "22")]
		protected override void OnShow(VortexRatingWindow.VortexWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_VortexRating_View_VortexRatingWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a581a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_VortexRatingWindow_VortexWindowArgs__OnClose__)
		    ;
		    DAT_ram_00a581a6 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_VortexRatingWindow_VortexWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x60),0);
		  iVar1 = **(int **)(param1 + 100);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x60) = 0;
		  *(undefined4 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x66C3", Offset = "0x66C3", VA = "0x66C3", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_VortexRating_View_VortexRatingWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a581a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Controller_VortexRatingController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Events_VortexRatingEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexRating_Model_VortexRatingModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_Controller_VortexRatingViewMediator_TypeInfo);
		    DAT_ram_00a581a7 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80eb1e48;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80eb1e48:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  uVar4 = unnamed_function_1417(Gameplay_VortexRating_Model_VortexRatingModel_TypeInfo);
		  Gameplay_VortexRating_View_GreatOnesTab_GreatUserView___ctor(uVar4,uVar3,uVar3);
		  *(undefined4 *)(param1 + 0x58) = uVar4;
		  uVar3 = unnamed_function_1417(Gameplay_VortexRating_Events_VortexRatingEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x5c) = uVar3;
		  uVar4 = *(undefined4 *)(param1 + 0x58);
		  iVar6 = unnamed_function_1417(Gameplay_VortexRating_Controller_VortexRatingController_TypeInfo);
		  if (DAT_ram_00a581e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_VortexRatingModel__VortexRatingEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_RatingService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a581e2 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar6,uVar4,uVar3,
		             Method_MVC_AbstractController_VortexRatingModel__VortexRatingEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_RatingService___);
		  *(undefined4 *)(iVar6 + 0x18) = uVar3;
		  *(int *)(param1 + 0x60) = iVar6;
		  uVar3 = *(undefined4 *)(param1 + 0x58);
		  uVar4 = *(undefined4 *)(param1 + 0x5c);
		  piVar5 = (int *)unnamed_function_1417
		                            (Gameplay_VortexRating_Controller_VortexRatingViewMediator_TypeInfo);
		  Gameplay_VortexRating_Controller_VortexRatingController__Dispose(piVar5,uVar3,uVar4,iVar6,iVar6);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 100) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x60),0);
		  return;
		}
		*/

		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x66C4", Offset = "0x66C4", VA = "0x66C4")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_VortexRating_View_VortexRatingWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x60),0);
		  iVar1 = **(int **)(param1 + 100);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x60);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x58);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x58),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x60) = 0;
		  *(undefined4 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x66C5", Offset = "0x66C5", VA = "0x66C5")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_VortexRating_View_VortexRatingWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a581a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_VortexRatingWindow_VortexWindowArgs___ctor__);
		    DAT_ram_00a581a8 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_VortexRatingWindow_VortexWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x66C6", Offset = "0x66C6", VA = "0x66C6")]
		public VortexRatingWindow()
		{
		}

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Vortex/VortexRatingWindow";

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GreatOnesView _greatOnesTab;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private VoteRewardsView _voteRewardsTab;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RulesView _rulesTab;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GreatPrizesView _greatPrizesTab;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VortexView _vortexTab;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _inRatingButton;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x58")]
		private VortexRatingModel _model;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x5C")]
		private VortexRatingEvents _events;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x60")]
		private VortexRatingController _controller;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x64")]
		private VortexRatingViewMediator _mediator;

		// Token: 0x02000385 RID: 901
		[Token(Token = "0x2000385")]
		public class VortexWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001505")]
			[Address(RVA = "0x66C7", Offset = "0x66C7", VA = "0x66C7")]
			public VortexWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_InRatingButton ---
		void Gameplay_VortexRating_View_VortexRatingWindow__get_InRatingButton
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a581a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_VortexRatingWindow_VortexWindowArgs__OnShow__);
		    DAT_ram_00a581a5 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_VortexRatingWindow_VortexWindowArgs__OnShow__);
		  Gameplay_VortexRating_View_VortexRatingWindow__OnClose(param1,param1);
		  return;
		}
		*/

}
