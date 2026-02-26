using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	public class RatingsController : AbstractController<RatingsModel, RatingsEvents>
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x6365", Offset = "0x6365", VA = "0x6365")]
		public RatingsController(RatingsModel model, RatingsEvents events, ColossusService service)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_Controller_RatingsController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58b53 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_RatingsController_GetClansRatingsResultHandler__
		              );
		    DAT_ram_00a58b53 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__GetDollSpellsInfo(*(undefined4 *)(param1 + 0x18),0)
		  ;
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_RatingsController_GetClansRatingsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x6366", Offset = "0x6366", VA = "0x6366")]
		public void GetClansRatings()
		{
		/* --- GHIDRA: GetClansRatings ---
		void Gameplay_WorldAxis_Office_Controller_RatingsController__GetClansRatings
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58b54 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetSeasonRatingAns_TypeInfo);
		    DAT_ram_00a58b54 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetSeasonRatingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetSeasonRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Office_Model_RatingsModel__set_MyUserArgs(param1_00,param1_01[3],param1);
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

		// Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x6367", Offset = "0x6367", VA = "0x6367")]
		private void GetClansRatingsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetClansRatingsResultHandler ---
		void Gameplay_WorldAxis_Office_Controller_RatingsController__GetClansRatingsResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58b55 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_Controller_RatingsController_GetHeroesRatingsResultHandler__
		              );
		    DAT_ram_00a58b55 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__GetSeasonRating(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_Office_Controller_RatingsController_GetHeroesRatingsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x6368", Offset = "0x6368", VA = "0x6368")]
		public void GetUsersRatings()
		{
		/* --- GHIDRA: GetUsersRatings ---
		void Gameplay_WorldAxis_Office_Controller_RatingsController__GetUsersRatings
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58b56 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetHeroesRatingAns_TypeInfo);
		    DAT_ram_00a58b56 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Colossus_ProtoGetHeroesRatingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Colossus_ProtoGetHeroesRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_Office_Model_RatingsModel__PopulateClanRatings(param1_00,param1_01[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x6369", Offset = "0x6369", VA = "0x6369")]
		private void GetHeroesRatingsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetHeroesRatingsResultHandler ---
		void Gameplay_WorldAxis_Office_Controller_RatingsController__GetHeroesRatingsResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x636A", Offset = "0x636A", VA = "0x636A", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_Office_Controller_RatingsController__HandleRun
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo);
		    DAT_ram_00a58b57 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_VortexRating_View_GreatPrizesTab_PrizeListElement___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_SeasonRewardsModel__WorldAxisOfficeEvents__WorldAxisOfficeController__SeasonRewardsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
