using System;
using Gameplay.Competition.Events;
using Gameplay.Competition.Model;
using Gameplay.Competition.View.Sections;
using Gameplay.VortexRating.View.GreatPrizesTab;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Control.Sections
{
	// Token: 0x0200090E RID: 2318
	[Token(Token = "0x200090E")]
	public class RewardsViewMediator : AbstractCozyViewMediator<RewardsModel, RewardsEvents, RewardsController, RewardsView>
	{
		// Token: 0x0600367C RID: 13948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x8689", Offset = "0x8689", VA = "0x8689")]
		public RewardsViewMediator(RewardsView view, RewardsModel model, RewardsEvents events, RewardsController controller)
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABE")]
		private PrizeListElement[] ListElements
		{
			[Token(Token = "0x600367D")]
			[Address(RVA = "0x868A", Offset = "0x868A", VA = "0x868A")]
			get
			{
				return null;
			}
			[Token(Token = "0x600367E")]
			[Address(RVA = "0x868B", Offset = "0x868B", VA = "0x868B")]
			set
			{
			}
		}

		// Token: 0x0600367F RID: 13951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600367F")]
		[Address(RVA = "0x868C", Offset = "0x868C", VA = "0x868C", Slot = "21")]
		protected override void ResetEvents(RewardsEvents events)
		{
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003680")]
		[Address(RVA = "0x868D", Offset = "0x868D", VA = "0x868D", Slot = "22")]
		protected override void SetupEvents(RewardsEvents events)
		{
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003681")]
		[Address(RVA = "0x868E", Offset = "0x868E", VA = "0x868E", Slot = "23")]
		protected override void ResetView(RewardsView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Competition_Control_Sections_RewardsViewMediator__ResetView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63b08 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RewardsModel__RewardsEvents__RewardsController__RewardsView__get_Model__
		              );
		    DAT_ram_00a63b08 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(iVar1 + 0x24);
		  uVar2 = Gameplay_Competition_Model_RewardsModel___ctor(param1[2],param1);
		  uVar2 = Gameplay_VortexRating_View_GreatPrizesTab_GreatPrizesView__get_InVortexButton
		                    (param1_00,uVar2,0,0);
		  Gameplay_Competition_Control_Sections_RewardsViewMediator__get_ListElements(param1,uVar2,param1);
		  Gameplay_Competition_Control_Sections_RewardsViewMediator__PrizeListElementClickedEventHandler
		            (param1,*(undefined4 *)(param1[7] + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003682 RID: 13954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003682")]
		[Address(RVA = "0x868F", Offset = "0x868F", VA = "0x868F", Slot = "24")]
		protected override void SetupView(RewardsView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Competition_Control_Sections_RewardsViewMediator__SetupView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__set_Prize
		            (*(undefined4 *)(param1 + 0x18),0,0);
		  Gameplay_Competition_Control_Sections_RewardsViewMediator__PrizeListElementClickedEventHandler
		            (param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003683 RID: 13955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003683")]
		[Address(RVA = "0x8690", Offset = "0x8690", VA = "0x8690")]
		private void PrizeListElementClickedEventHandler(PrizeListElement element)
		{
		/* --- GHIDRA: PrizeListElementClickedEventHandler ---
		void Gameplay_Competition_Control_Sections_RewardsViewMediator__PrizeListElementClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b09 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a63b09 = '\x01';
		  }
		  Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__set_Prize(param2,1,0);
		  param1[6] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0x18);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x28) + 0x1c);
		  if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar3,0);
		  piVar2 = (int *)func_ii_7307(param1_00,uVar3,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))(piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  return;
		}
		*/

		}

		// Token: 0x06003684 RID: 13956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003684")]
		[Address(RVA = "0x8691", Offset = "0x8691", VA = "0x8691")]
		private void SelectElement(PrizeListElement element)
		{
		/* --- GHIDRA: SelectElement ---
		void Gameplay_Competition_Control_Sections_RewardsViewMediator__SelectElement
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a63b0a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ShopModel__ShopEvents___ctor__);
		    DAT_ram_00a63b0a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_ShopModel__ShopEvents___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[FieldOffset(Offset = "0x18")]
		private PrizeListElement _selectedElement;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x1C")]
		private PrizeListElement[] _listElements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ListElements ---
		void Gameplay_Competition_Control_Sections_RewardsViewMediator__get_ListElements
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a63b07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PrizeListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RewardsViewMediator_PrizeListElementClickedEventHandler__
		              );
		    DAT_ram_00a63b07 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar4 = *(undefined4 *)(iVar3 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_PrizeListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_Competition_Control_Sections_RewardsViewMediator_PrizeListElementClickedEventHandler__
		                 ,0);
		      Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement__add_ElementClickedEvent
		                (uVar4,uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  *(int *)(param1 + 0x1c) = param2;
		  if (0 < *(int *)(param2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar4 = *(undefined4 *)(param2 + iVar1 * 4 + 0x10);
		      uVar2 = unnamed_function_1417(System_Action_PrizeListElement__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar2,param1,
		                 Method_Gameplay_Competition_Control_Sections_RewardsViewMediator_PrizeListElementClickedEventHandler__
		                 ,0);
		      Gameplay_VortexRating_View_GreatPrizesTab_GreatPrizesView___ctor(uVar4,uVar2,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

}
