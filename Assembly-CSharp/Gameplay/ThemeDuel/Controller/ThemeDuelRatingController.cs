using System;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Gameplay.ThemeDuel.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.ThemeDuel.Controller
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	public class ThemeDuelRatingController : AbstractController<ThemeDuelRatingModel, RatingEvents>
	{
		// Token: 0x06001E16 RID: 7702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x6F94", Offset = "0x6F94", VA = "0x6F94")]
		public ThemeDuelRatingController(RatingService service, ThemeDuelRatingModel model, RatingEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingController___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a585e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingController_OnGetUserRating__);
		    DAT_ram_00a585e2 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Gameplay_Rating_Model_RatingModel__GetCults
		                    (uVar1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),0);
		  if (iVar2 == 0) {
		    uVar1 = ServicesNamespace_RatingService__RequestClansRating
		                      (param1[6],*(undefined4 *)(param2 + 0x10),0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingController_OnGetUserRating__,0);
		    uVar1 = ServicesNamespace_MainService__GetUserStats
		                      (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar1 = DG_Tweening_TweenParams__SetId
		                      (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x6F95", Offset = "0x6F95", VA = "0x6F95")]
		public void RequestAllUsersRating(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: RequestAllUsersRating ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingController__RequestAllUsersRating
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  int *param1_01;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a585e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetUserTDRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingController_OnGetAllUsersRating__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns__TypeInfo);
		    DAT_ram_00a585e3 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Rating_Model_RatingRequestDto_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Rating_ProtoGetUserTDRatingAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Rating_ProtoGetUserTDRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = ServicesNamespace_RatingService__GetUserTdRating
		                    (*(undefined4 *)(param1 + 0x18),param1_00[4],0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_ThemeDuel_Controller_ThemeDuelRatingController_OnGetAllUsersRating__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,param1_00,param1_01,
		             Method_System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns___ctor__);
		  local_10 = local_8;
		  uVar2 = func_ii_1081(System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns__TypeInfo,
		                       &local_10);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x6F96", Offset = "0x6F96", VA = "0x6F96")]
		private void OnGetUserRating(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetUserRating ---
		void Gameplay_ThemeDuel_Controller_ThemeDuelRatingController__OnGetUserRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a585e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetAllUsersTDRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns__TypeInfo);
		    DAT_ram_00a585e4 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar1 = *(int **)(param2 + 0xc);
		  if (piVar1 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*piVar1 + 0x20) !=
		      *(int *)(System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns__TypeInfo + 0x20)) {
		    System_Activator__CreateInstance
		              (piVar1,System_ValueTuple_RatingRequestDto__ProtoGetUserTDRatingAns__TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1 = (int *)func_ii_15774(piVar1);
		  iVar2 = piVar1[1];
		  iVar3 = *piVar1;
		  piVar1 = *(int **)(param2 + 0x20);
		  if ((piVar1 != (int *)0x0) && (Protocol_Rating_ProtoGetAllUsersTDRatingAns_TypeInfo != *piVar1)) {
		    System_Activator__CreateInstance(piVar1,Protocol_Rating_ProtoGetAllUsersTDRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_ThemeDuel_Model_ThemeDuelRatingModel__get_UserPeriodFilterDatas
		            (param1_00,iVar2,piVar1,*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(iVar3 + 0x10),
		             param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),iVar3,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x6F97", Offset = "0x6F97", VA = "0x6F97")]
		private void OnGetAllUsersRating(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;
	}
}
