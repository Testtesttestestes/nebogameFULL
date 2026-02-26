using System;
using Gameplay.Discounts.Events;
using Gameplay.Discounts.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Discounts.Controller
{
	// Token: 0x020008A5 RID: 2213
	[Token(Token = "0x20008A5")]
	public class DiscountsController : AbstractController<DiscountsModel, DiscountsEvents>
	{
		// Token: 0x060033FB RID: 13307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x8428", Offset = "0x8428", VA = "0x8428")]
		public DiscountsController(DiscountsModel model, DiscountsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_Controller_DiscountsController___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57cc3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_Controller_DiscountsController_HandleDictChanged__);
		    DAT_ram_00a57cc3 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Discounts_Model_DiscountsModel__PopulateDiscounts(uVar1,param1);
		  Gameplay_Discounts_Controller_DiscountsController__HandleDictChanged(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(*(int *)(iVar2 + 0xc) + 0x18);
		  param1_01 = *(undefined4 *)(iVar3 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Discounts_Controller_DiscountsController_HandleDictChanged__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(param1_01,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(iVar3 + 0x14) = param1_00, *param1_00 == iVar2)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,iVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x8429", Offset = "0x8429", VA = "0x8429", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Discounts_Controller_DiscountsController__HandleRun(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar2;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a57cc4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_Controller_DiscountsController_HandleDictChanged__);
		    DAT_ram_00a57cc4 = '\x01';
		  }
		  *(undefined1 *)((int)param1 + 9) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(*(int *)(iVar1 + 0xc) + 0x18);
		  param1_02 = *(undefined4 *)(iVar2 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Discounts_Controller_DiscountsController_HandleDictChanged__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar1 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x14) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_01) &&
		     (*(int **)(iVar2 + 0x14) = param1_01, *param1_01 == iVar1)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_01,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x842A", Offset = "0x842A", VA = "0x842A", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Discounts_Controller_DiscountsController__HandleStop(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Discounts_Model_DiscountsModel__PopulateDiscounts(param1_00,param1);
		  Gameplay_Discounts_Controller_DiscountsController__HandleDictChanged(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x842B", Offset = "0x842B", VA = "0x842B")]
		private void HandleDictChanged()
		{
		/* --- GHIDRA: HandleDictChanged ---
		void Gameplay_Discounts_Controller_DiscountsController__HandleDictChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57cc5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_Controller_DiscountsController_GetDiscountsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57cc5 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__CancelSpecialOffer(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Discounts_Controller_DiscountsController_GetDiscountsResultHandler__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x842C", Offset = "0x842C", VA = "0x842C")]
		public void GetDiscounts()
		{
		/* --- GHIDRA: GetDiscounts ---
		void Gameplay_Discounts_Controller_DiscountsController__GetDiscounts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57cc6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetDiscountsAns_TypeInfo);
		    DAT_ram_00a57cc6 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Services_ProtoGetDiscountsAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Services_ProtoGetDiscountsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Discounts_Model_DiscountsModel___ctor(param1_00,param1_01[3],param1);
		  *(undefined1 *)((int)param1 + 9) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x842D", Offset = "0x842D", VA = "0x842D")]
		private void GetDiscountsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDiscountsResultHandler ---
		void Gameplay_Discounts_Controller_DiscountsController__GetDiscountsResultHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57cc7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow___ctor__
		              );
		    DAT_ram_00a57cc7 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_DiscountsModel__DiscountsEvents__DiscountsController__DiscountsWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04001C4A RID: 7242
		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _service;
	}
}
