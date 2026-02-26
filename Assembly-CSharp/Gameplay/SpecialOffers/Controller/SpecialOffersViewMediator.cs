using System;
using Gameplay.Bank.Model;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Gameplay.SpecialOffers.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	public class SpecialOffersViewMediator : OptionsOfferViewMediatorBase<SpecialOffersModel, SpecialOffersEvents, SpecialOffersController, SpecialOffersWindow>
	{
		// Token: 0x06001EEF RID: 7919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x7056", Offset = "0x7056", VA = "0x7056")]
		public SpecialOffersViewMediator(SpecialOffersModel model, SpecialOffersEvents events, SpecialOffersController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58654 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_SpecialOfferRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_UserTriggersChangedEventHandler__
		              );
		    DAT_ram_00a58654 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_SpecialOfferRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_UserTriggersChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_SpecialOfferRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator_UserTriggersChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700059F RID: 1439
		// (set) Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059F")]
		public override SpecialOffersEvents Events
		{
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x7057", Offset = "0x7057", VA = "0x7057", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x7058", Offset = "0x7058", VA = "0x7058")]
		private void SpecialOfferRequestedEventHandler()
		{
		/* --- GHIDRA: SpecialOfferRequestedEventHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__SpecialOfferRequestedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SpecialOffers_Controller_SpecialOffersController___ctor(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x7059", Offset = "0x7059", VA = "0x7059")]
		private void UserTriggersChangedEventHandler()
		{
		/* --- GHIDRA: UserTriggersChangedEventHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__UserTriggersChangedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58655 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow__BuyOptionSuccessHandler__
		              );
		    DAT_ram_00a58655 = '\x01';
		  }
		  Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_object__object__object__object___BuyOptionErrorHandler
		            (param1,param2,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow__BuyOptionSuccessHandler__
		            );
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SpecialOffers_Controller_SpecialOffersController___ctor(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x705A", Offset = "0x705A", VA = "0x705A", Slot = "22")]
		protected override void BuyOptionSuccessHandler(BankOptionData data)
		{
		/* --- GHIDRA: BuyOptionSuccessHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__BuyOptionSuccessHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_SpecialOffers_Controller_SpecialOffersController___ctor(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x705B", Offset = "0x705B", VA = "0x705B", Slot = "23")]
		protected override void BuyOptionErrorHandler(BankOptionData data)
		{
		/* --- GHIDRA: BuyOptionErrorHandler ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__BuyOptionErrorHandler
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58656 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow__UpdateView__
		              );
		    DAT_ram_00a58656 = '\x01';
		  }
		  Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_object__object__object__object___ToMailButtonClickedEventHandler
		            (param1,
		             Method_Gameplay_SpecialOffers_Controller_OptionsOfferViewMediatorBase_SpecialOffersModel__SpecialOffersEvents__SpecialOffersController__SpecialOffersWindow__UpdateView__
		            );
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  *(undefined1 *)(iVar2 + 0x20) = 1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x18);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0x705C", Offset = "0x705C", VA = "0x705C", Slot = "21")]
		protected override void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__UpdateView
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58657 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2182);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2084);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2085);
		    DAT_ram_00a58657 = '\x01';
		  }
		  Gameplay_Rating_View_UserView__get_UserData
		            (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*param2 + 0x10),0);
		  Gameplay_SmallGames_View_SmallGamesResourceRenderer__SetIndex
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(*param2 + 0xc),param3,param3);
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		  *(undefined4 *)(param1_00 + 0x10) = StringLiteral_2182;
		  *(undefined4 *)(param1_00 + 0x14) = *(undefined4 *)(*param2 + 8);
		  *(undefined4 *)(param1_00 + 0x18) = StringLiteral_2085;
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(*param2 + 0x14);
		  *(undefined4 *)(param1_00 + 0x20) = StringLiteral_2084;
		  uVar1 = System_Single__ToString(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_01,uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_SpecialOffers_Controller_SpecialOffersViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x168) * 4))(param1,*(undefined4 *)(*param1 + 0x16c));
		  return;
		}
		*/

}
