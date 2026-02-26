using System;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DD RID: 1501
	[Token(Token = "0x20005DD")]
	public class PortalsRatingController : AbstractController<PortalsRatingModel, PortalsEvents>
	{
		// Token: 0x0600243F RID: 9279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x758E", Offset = "0x758E", VA = "0x758E")]
		public PortalsRatingController(PortalsRatingModel model, PortalsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Portals_Controller_PortalsRatingController___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  float fVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58168 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsRatingController_OnGetUserRating__);
		    DAT_ram_00a58168 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(char *)(iVar2 + 0x1c) == '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    fVar3 = func_ii_7103(*(undefined4 *)(iVar2 + 0x20),0);
		    iVar2 = *param1;
		    if (0.0 < fVar3) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x34);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		        return 0;
		      }
		    }
		    else {
		      uVar1 = 1;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                        (param1,*(undefined4 *)(iVar2 + 0x104));
		      *(undefined1 *)(iVar2 + 0x1c) = 1;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0xc);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      }
		      uVar4 = ServicesNamespace_RatingService__GetAllUsersTdRating(param1[6],0);
		      param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param1,
		                 Method_Gameplay_Portals_Controller_PortalsRatingController_OnGetUserRating__,0);
		      uVar4 = ServicesNamespace_MainService__GetUserStats
		                        (uVar4,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__
		                        );
		      Utils_OpToken_int__object___AddHandlers(param1,uVar4,0);
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x758F", Offset = "0x758F", VA = "0x758F")]
		public bool TryRequestAllUsersRating()
		{
		/* --- GHIDRA: TryRequestAllUsersRating ---
		void Gameplay_Portals_Controller_PortalsRatingController__TryRequestAllUsersRating
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58169 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsRatingController_OnGetAllUsersRating__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetUserPortalRatingAns_TypeInfo);
		    DAT_ram_00a58169 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param2_00 = Protocol_Rating_ProtoGetUserPortalRatingAns_TypeInfo;
		  param1_01 = *(int **)(param2 + 0x20);
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  else if ((Protocol_Rating_ProtoGetUserPortalRatingAns_TypeInfo != *param1_01) ||
		          (*(int **)(param1 + 0x1c) = param1_01, *param1_01 != param2_00)) {
		    System_Activator__CreateInstance(param1_01,param2_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar1 = ServicesNamespace_RatingService__GetUserPortalRating(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsRatingController_OnGetAllUsersRating__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x7590", Offset = "0x7590", VA = "0x7590")]
		private void OnGetUserRating(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetUserRating ---
		void Gameplay_Portals_Controller_PortalsRatingController__OnGetUserRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a5816a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetAllUsersPortalRatingAns_TypeInfo);
		    DAT_ram_00a5816a = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Rating_ProtoGetAllUsersPortalRatingAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Rating_ProtoGetAllUsersPortalRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Portals_Model_PortalsRatingModel__GetPortalRatingMyUser
		            (param1_00,param1[7],param1_01,0,0,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(iVar1 + 0x1c) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x10);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x34);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x7591", Offset = "0x7591", VA = "0x7591")]
		private void OnGetAllUsersRating(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnGetAllUsersRating ---
		void Gameplay_Portals_Controller_PortalsRatingController__OnGetAllUsersRating
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5816b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__Dispose__
		              );
		    DAT_ram_00a5816b = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*(int *)(param1 + 0x18),0);
		    if (*(int *)(param1 + 0x18) != 0) {
		      System_Threading_CancellationTokenSource__Cancel(*(int *)(param1 + 0x18),0);
		    }
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		[FieldOffset(Offset = "0x1C")]
		private ProtoGetUserPortalRatingAns _userRating;
	}
}
