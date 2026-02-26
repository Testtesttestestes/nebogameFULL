using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public class VortexRatingController : AbstractController<VortexRatingModel, VortexRatingEvents>
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158A")]
		[Address(RVA = "0x674C", Offset = "0x674C", VA = "0x674C")]
		public VortexRatingController(VortexRatingModel model, VortexRatingEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_Controller_VortexRatingController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a581e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GetGreatTopResultHandler__
		              );
		    DAT_ram_00a581e3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x10) == 0) {
		    uVar2 = ServicesNamespace_RatingService__GetAllUsersPortalRating(param1[6],0);
		    param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GetGreatTopResultHandler__
		               ,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		    return;
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

		// Token: 0x0600158B RID: 5515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158B")]
		[Address(RVA = "0x674D", Offset = "0x674D", VA = "0x674D")]
		public void GetGreatTop()
		{
		/* --- GHIDRA: GetGreatTop ---
		void Gameplay_VortexRating_Controller_VortexRatingController__GetGreatTop
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a581e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetGreatTopAns_TypeInfo);
		    DAT_ram_00a581e4 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Rating_ProtoGetGreatTopAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Rating_ProtoGetGreatTopAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int **)(iVar1 + 0x10) = param1_00;
		  Gameplay_VortexRating_Model_VortexRatingModel__PopulateGreatTop(iVar1,param1_00[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Gameplay_VortexRating_Controller_VortexRatingController__GreatRatingSetChangedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158C")]
		[Address(RVA = "0x674E", Offset = "0x674E", VA = "0x674E")]
		private void GetGreatTopResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetGreatTopResultHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__GetGreatTopResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a581e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_SetGreatSetIdResultHandler__
		              );
		    DAT_ram_00a581e5 = '\x01';
		  }
		  uVar1 = ServicesNamespace_RatingService__GetGreatTop(*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_VortexRating_Controller_VortexRatingController_SetGreatSetIdResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_4 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158D")]
		[Address(RVA = "0x674F", Offset = "0x674F", VA = "0x674F")]
		public void SetGreatSetId(uint greatSetId)
		{
		/* --- GHIDRA: SetGreatSetId ---
		void Gameplay_VortexRating_Controller_VortexRatingController__SetGreatSetId
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_00 + 0x20) == *(int *)(DAT_ram_00a66958 + 0x20)) {
		    puVar1 = (undefined4 *)func_ii_15774(param1_00);
		    uVar3 = *puVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar3,*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,DAT_ram_00a66958);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158E")]
		[Address(RVA = "0x6750", Offset = "0x6750", VA = "0x6750")]
		private void SetGreatSetIdResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SetGreatSetIdResultHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__SetGreatSetIdResultHandler
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a581e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_VoteGreatRatingResultHandler__
		              );
		    DAT_ram_00a581e6 = '\x01';
		  }
		  uVar1 = ServicesNamespace_RatingService__SetGreatSetId(*(undefined4 *)(param1 + 0x18),param2,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_VortexRating_Controller_VortexRatingController_VoteGreatRatingResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar2 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  DG_Tweening_TweenParams__SetId(uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x6751", Offset = "0x6751", VA = "0x6751")]
		public void VoteGreatRating(ulong userId)
		{
		/* --- GHIDRA: VoteGreatRating ---
		void Gameplay_VortexRating_Controller_VortexRatingController__VoteGreatRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 *puVar3;
		  int iVar4;
		  int *piVar5;
		  undefined8 param2_00;
		  int local_4;
		  
		  if (DAT_ram_00a581e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoVoteGreatRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7403);
		    DAT_ram_00a581e7 = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Rating_ProtoVoteGreatRatingAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Rating_ProtoVoteGreatRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar5[3] < 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    local_4 = piVar5[3];
		    uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_7403,uVar2,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar2,0);
		  }
		  else {
		    piVar5 = *(int **)(param2 + 0xc);
		    if (piVar5 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar5 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		      System_Activator__CreateInstance(piVar5,DAT_ram_00a66968);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar3 = (undefined8 *)func_ii_15774(piVar5);
		    param2_00 = *puVar3;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    iVar4 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(iVar4 + 0x14),param2_00,
		                       Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__get_Item__
		                      );
		    *(int *)(*(int *)(iVar4 + 8) + 0x14) = *(int *)(*(int *)(iVar4 + 8) + 0x14) + 1;
		    *(undefined1 *)(iVar4 + 0x14) = 1;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Google_Protobuf_Collections_RepeatedField_ulong____ctor
		              (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x24),param2_00,
		               Method_Google_Protobuf_Collections_RepeatedField_ulong__Add__);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar4 = *(int *)(iVar4 + 0x18);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),param2_00,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x6752", Offset = "0x6752", VA = "0x6752")]
		private void VoteGreatRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: VoteGreatRatingResultHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__VoteGreatRatingResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_ExitGreatRatingResultHandler__
		              );
		    DAT_ram_00a581e8 = '\x01';
		  }
		  param1_00 = ServicesNamespace_RatingService__VoteGreatRating(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_VortexRating_Controller_VortexRatingController_ExitGreatRatingResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001591")]
		[Address(RVA = "0x6753", Offset = "0x6753", VA = "0x6753")]
		public void ExitGreatRating()
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001592")]
		[Address(RVA = "0x6754", Offset = "0x6754", VA = "0x6754")]
		private void ExitGreatRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ExitGreatRatingResultHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__ExitGreatRatingResultHandler
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_VoteRTRatingResultHandler__
		              );
		    DAT_ram_00a581e9 = '\x01';
		  }
		  param1_00 = ServicesNamespace_RatingService__ExitGreatRating
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_VortexRating_Controller_VortexRatingController_VoteRTRatingResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001593")]
		[Address(RVA = "0x6755", Offset = "0x6755", VA = "0x6755")]
		public void VoteRTRating(ulong userId, bool isLike)
		{
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001594")]
		[Address(RVA = "0x6756", Offset = "0x6756", VA = "0x6756")]
		private void VoteRTRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: VoteRTRatingResultHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__VoteRTRatingResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a581ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GetVoteRTRatingResultHandler__
		              );
		    DAT_ram_00a581ea = '\x01';
		  }
		  param1_00 = ServicesNamespace_RatingService__VoteRTRating
		                        (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_VortexRating_Controller_VortexRatingController_GetVoteRTRatingResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x6757", Offset = "0x6757", VA = "0x6757")]
		public void GetVoteRTRating(RatingPeriods period, bool ownerOnly)
		{
		/* --- GHIDRA: GetVoteRTRating ---
		void Gameplay_VortexRating_Controller_VortexRatingController__GetVoteRTRating
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a581eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetVoteRTRatingAns_TypeInfo);
		    DAT_ram_00a581eb = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x6758", Offset = "0x6758", VA = "0x6758")]
		private void GetVoteRTRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetVoteRTRatingResultHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__GetVoteRTRatingResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_VortexRating_Model_VortexRatingModel__PopulateGreatTop
		            (param1_00,*(undefined4 *)(param2 + 0xc),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x6759", Offset = "0x6759", VA = "0x6759")]
		private void GreatRatingTopChangedEventHandler(ProtoGreatRatingTopChangedEvt evt)
		{
		/* --- GHIDRA: GreatRatingTopChangedEventHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__GreatRatingTopChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  int local_4;
		  
		  if (DAT_ram_00a581ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a581ec = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar5 = *(undefined8 *)(param2 + 0x10);
		  iVar3 = func_ii_7090(*(undefined4 *)(iVar2 + 0x14),uVar5,&local_4,
		                       Method_System_Collections_Generic_Dictionary_ulong__GreatUserData__TryGetValue__
		                      );
		  iVar2 = local_4;
		  if (iVar3 != 0) {
		    *(undefined4 *)(*(int *)(local_4 + 8) + 0x18) = *(undefined4 *)(param2 + 0x18);
		    uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    iVar3 = Core_Extensions_Dict_DictExt__GetDuelUserStateFlags
		                      (*(undefined4 *)(iVar3 + 0xc),*(undefined4 *)(param2 + 0x18),0);
		    uVar4 = *(undefined4 *)(iVar3 + 0x1c);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar4,0);
		    *(undefined4 *)(iVar2 + 0x10) = uVar4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),
		                 *(undefined8 *)(*(int *)(*(int *)(local_4 + 8) + 0xc) + 0x10),
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x675A", Offset = "0x675A", VA = "0x675A")]
		private void GreatRatingSetChangedEventHandler(ProtoGreatRatingSetChangedEvt evt)
		{
		/* --- GHIDRA: GreatRatingSetChangedEventHandler ---
		void Gameplay_VortexRating_Controller_VortexRatingController__GreatRatingSetChangedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a581ed == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingSetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingTopChangedEventHandler__
		              );
		    DAT_ram_00a581ed = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 1;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingSetChangedEventHandler__
		               ,0);
		    ServicesNamespace_RatingService__remove_GreatRatingTopChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingTopChangedEventHandler__
		               ,0);
		    ServicesNamespace_RatingService__remove_TotalRatingChangedEvent(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x675B", Offset = "0x675B", VA = "0x675B")]
		private void SubscribeToEvents()
		{
		/* --- GHIDRA: SubscribeToEvents ---
		void Gameplay_VortexRating_Controller_VortexRatingController__SubscribeToEvents
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a581ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingSetChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingTopChangedEventHandler__
		              );
		    DAT_ram_00a581ee = '\x01';
		  }
		  if (*(char *)(param1 + 0x1c) != '\0') {
		    *(undefined1 *)(param1 + 0x1c) = 0;
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoGreatRatingSetChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingSetChangedEventHandler__
		               ,0);
		    ServicesNamespace_RatingService__add_GreatRatingSetChangedEvent(uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1 + 0x18);
		    uVar1 = unnamed_function_1417(System_Action_ProtoGreatRatingTopChangedEvt__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_VortexRating_Controller_VortexRatingController_GreatRatingTopChangedEventHandler__
		               ,0);
		    ServicesNamespace_RatingService__add_GreatRatingTopChangedEvent(uVar2,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x675C", Offset = "0x675C", VA = "0x675C")]
		private void UnsubscribeFromEvents()
		{
		/* --- GHIDRA: UnsubscribeFromEvents ---
		undefined4
		Gameplay_VortexRating_Controller_VortexRatingController__UnsubscribeFromEvents
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param3_00;
		  int param1_01;
		  int param1_02;
		  uint uVar3;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a581ef == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_17534);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25416);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17533);
		    DAT_ram_00a581ef = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17534,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17533,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  param3_00 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_25416,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_10;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,iVar2,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_02 = *(int *)(param1_00 + 0x24);
		  param1_01 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_01,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_16790,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_01 + 8) = uVar1;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x675D", Offset = "0x675D", VA = "0x675D")]
		public DialogWindow ShowLowLevelWindow(int minLevel)
		{
		/* --- GHIDRA: ShowLowLevelWindow ---
		void Gameplay_VortexRating_Controller_VortexRatingController__ShowLowLevelWindow
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_VortexRating_Controller_VortexRatingController___ctor(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x675E", Offset = "0x675E", VA = "0x675E", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_VortexRating_Controller_VortexRatingController__HandleRun
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_VortexRating_Controller_VortexRatingController__SubscribeToEvents(param1,param1);
		  Gameplay_VortexRating_Controller_VortexRatingController__VoteGreatRatingResultHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x675F", Offset = "0x675F", VA = "0x675F", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_VortexRating_Controller_VortexRatingController__HandleStop
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a581f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_VortexRatingModel__VortexRatingEvents__Dispose__);
		    DAT_ram_00a581f0 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_VortexRatingModel__VortexRatingEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x6760", Offset = "0x6760", VA = "0x6760", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_VortexRating_Controller_VortexRatingController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a581f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator____ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IHideableMediator__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowGreatOnesTab__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowGreatPrizesTab__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowRulesTab__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowVortexTab__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowVoteRewardsTab__
		              );
		    DAT_ram_00a581f1 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_VortexRatingModel__VortexRatingEvents__VortexRatingController__VortexRatingWindow___ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___TypeInfo
		                        );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator____ctor__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowVortexTab__,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,0,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowGreatOnesTab__,
		                0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,1,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowGreatPrizesTab__
		                ,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,2,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowVoteRewardsTab__
		                ,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,3,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_VortexRating_Controller_VortexRatingViewMediator_ShowRulesTab__,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,4,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x18")]
		private RatingService _ratingService;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x1C")]
		private bool _subscribed;
	}
}
