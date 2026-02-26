using System;
using Gameplay.Rating.Events;
using Gameplay.Rating.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Rating.Control
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	public class RatingController : AbstractController<RatingModel, RatingEvents>
	{
		// Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x73BA", Offset = "0x73BA", VA = "0x73BA")]
		public RatingController(RatingModel model, RatingEvents events)
		{
		/* --- GHIDRA: <SetRating>b__6_1 ---
		void Gameplay_Competition_Control_Sections_RatingController___SetRating_b__6_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63afc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo);
		    DAT_ram_00a63afc = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo)
		  ;
		  **(undefined4 **)(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_Sections_RatingController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Competition_Control_Sections_RatingController__ValidateInit(param1,param1);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_Control_RatingController___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58091 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingController_GetUsersRatingResultHandler__);
		    DAT_ram_00a58091 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  if (DAT_ram_00a58051 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____TryGetValue__
		              );
		    DAT_ram_00a58051 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x14),uVar2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs_____TryGetValue__
		                    );
		  if ((iVar1 == 0) ||
		     (iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                        (local_4,uVar3,
		                         Method_System_Collections_Generic_Dictionary_uint__UserInRatingListElement_UserInRatingListElementArgs____ContainsKey__
		                        ), iVar1 == 0)) {
		    uVar2 = ServicesNamespace_RatingService__ServerEventHandler
		                      (param1[6],*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Rating_Control_RatingController_GetUsersRatingResultHandler__,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x73BB", Offset = "0x73BB", VA = "0x73BB")]
		public void RequestUsersRating(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: RequestUsersRating ---
		void Gameplay_Rating_Control_RatingController__RequestUsersRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  int *param1_02;
		  
		  if (DAT_ram_00a58092 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetUsersRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a58092 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Rating_ProtoGetUsersRatingAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Rating_ProtoGetUsersRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_02 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_02 + 100) +
		                 (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Rating_Model_RatingRequestDto_TypeInfo)) {
		      System_Activator__CreateInstance(param1_02,Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Rating_Model_RatingModel__CreateCultSubRatingListElementArgs
		            (param1_00,param1_01,param1_02[3],param1_02[4],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_02,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x73BC", Offset = "0x73BC", VA = "0x73BC")]
		private void GetUsersRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUsersRatingResultHandler ---
		void Gameplay_Rating_Control_RatingController__GetUsersRatingResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58093 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingController_GetClansRatingResultHandler__);
		    DAT_ram_00a58093 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  if (DAT_ram_00a58052 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____TryGetValue__
		              );
		    DAT_ram_00a58052 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x18),uVar2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs_____TryGetValue__
		                    );
		  if ((iVar1 == 0) ||
		     (iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                        (local_4,uVar3,
		                         Method_System_Collections_Generic_Dictionary_uint__ClanInRatingListElement_ClanInRatingListElementArgs____ContainsKey__
		                        ), iVar1 == 0)) {
		    uVar2 = ServicesNamespace_RatingService__RequestCultRating
		                      (param1[6],*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Rating_Control_RatingController_GetClansRatingResultHandler__,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x73BD", Offset = "0x73BD", VA = "0x73BD")]
		public void RequestClansRating(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: RequestClansRating ---
		void Gameplay_Rating_Control_RatingController__RequestClansRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  int *param1_02;
		  
		  if (DAT_ram_00a58094 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetClansRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a58094 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Rating_ProtoGetClansRatingAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Rating_ProtoGetClansRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_02 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_02 + 100) +
		                 (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Rating_Model_RatingRequestDto_TypeInfo)) {
		      System_Activator__CreateInstance(param1_02,Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Rating_Model_RatingModel__ConstructArgs
		            (param1_00,param1_01,param1_02[3],param1_02[4],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_02,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002267")]
		[Address(RVA = "0x73BE", Offset = "0x73BE", VA = "0x73BE")]
		private void GetClansRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetClansRatingResultHandler ---
		void Gameplay_Rating_Control_RatingController__GetClansRatingResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58095 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Rating_Control_RatingController_GetCultsRatingResultHandler__);
		    DAT_ram_00a58095 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined4 *)(param2 + 0x10);
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  if (DAT_ram_00a58053 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____TryGetValue__
		              );
		    DAT_ram_00a58053 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x1c),uVar2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs_____TryGetValue__
		                    );
		  if ((iVar1 == 0) ||
		     (iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                        (local_4,uVar3,
		                         Method_System_Collections_Generic_Dictionary_uint__CultInRatingListElement_CultInRatingListElementArgs____ContainsKey__
		                        ), iVar1 == 0)) {
		    uVar2 = ServicesNamespace_RatingService__RequestUsersRating
		                      (param1[6],*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Rating_Control_RatingController_GetCultsRatingResultHandler__,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    uVar2 = DG_Tweening_TweenParams__SetId
		                      (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002268")]
		[Address(RVA = "0x73BF", Offset = "0x73BF", VA = "0x73BF")]
		public void RequestCultsRating(RatingRequestDto ratingRequest)
		{
		/* --- GHIDRA: RequestCultsRating ---
		void Gameplay_Rating_Control_RatingController__RequestCultsRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  int *param1_02;
		  
		  if (DAT_ram_00a58096 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetCultsRatingAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		    DAT_ram_00a58096 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Rating_ProtoGetCultsRatingAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Rating_ProtoGetCultsRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_02 = *(int **)(param2 + 0xc);
		  if (param1_02 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_02 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_02 + 100) +
		                 (uint)*(byte *)(Gameplay_Rating_Model_RatingRequestDto_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Rating_Model_RatingRequestDto_TypeInfo)) {
		      System_Activator__CreateInstance(param1_02,Gameplay_Rating_Model_RatingRequestDto_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Rating_Model_RatingModel__PopulateClans
		            (param1_00,param1_01,param1_02[3],param1_02[4],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_02,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x73C0", Offset = "0x73C0", VA = "0x73C0")]
		private void GetCultsRatingResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetCultsRatingResultHandler ---
		void Gameplay_Rating_Control_RatingController__GetCultsRatingResultHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58097 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__Dispose__
		              );
		    DAT_ram_00a58097 = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(iVar1 + 0x134));
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_RatingModel__RatingEvents__RatingController__RatingWindow__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040012D5 RID: 4821
		[Token(Token = "0x40012D5")]
		[FieldOffset(Offset = "0x18")]
		private readonly RatingService _ratingService;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Competition_Control_Sections_RatingController__ValidateInit
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63af8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RatingController_HandleGetAllCompetitionRatingService__
		              );
		    DAT_ram_00a63af8 = '\x01';
		  }
		  uVar1 = ServicesNamespace_RatingService__GetCompetitionRatingCounter
		                    (*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Competition_Control_Sections_RatingController_HandleGetAllCompetitionRatingService__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: RequestRating ---
		void Gameplay_Competition_Control_Sections_RatingController__RequestRating
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a63af9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Rating_ProtoGetCompetitionRatingAns_TypeInfo);
		    DAT_ram_00a63af9 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Rating_ProtoGetCompetitionRatingAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Rating_ProtoGetCompetitionRatingAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Competition_Control_Sections_RatingController__HandleGetAllCompetitionRatingService
		            (param1,param1_00[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Competition_Model_OwnerRating__SetValueWhitHistory
		            (*(undefined4 *)(iVar1 + 0x10),param1_00[6],*(undefined8 *)(param1_00 + 4),param1);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: HandleGetAllCompetitionRatingService ---
		void Gameplay_Competition_Control_Sections_RatingController__HandleGetAllCompetitionRatingService
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int iVar3;
		  int param1_01;
		  int param3_00;
		  
		  if (DAT_ram_00a63afa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInCompetitionRating__RatingModel_RatingRecord___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RatingModel_RatingRecord___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserInCompetitionRating___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserInCompetitionRating__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_UserInCompetitionRating__int__RatingModel_RatingRecord__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Competition_Control_Sections_RatingController__SetRating_b__6_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Control_Sections_RatingController___c__SetRating_b__6_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo);
		    DAT_ram_00a63afa = '\x01';
		  }
		  if (*(int *)(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_UserInCompetitionRating__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar1,
		               Method_Gameplay_Competition_Control_Sections_RatingController___c__SetRating_b__6_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Competition_Control_Sections_RatingController___c_TypeInfo + 0x5c) +
		            4) = iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param2,iVar3,Method_System_Linq_Enumerable_Where_UserInCompetitionRating___);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Func_UserInCompetitionRating__int__RatingModel_RatingRecord__TypeInfo
		                        );
		  System_Func_object__int__long___Invoke
		            (param1_00,param1,
		             Method_Gameplay_Competition_Control_Sections_RatingController__SetRating_b__6_1__,0);
		  uVar1 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_UserInCompetitionRating__RatingModel_RatingRecord___
		                    );
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_RatingModel_RatingRecord___);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a63ac2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RatingModel_RatingRecord__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RatingModel_RatingRecord__Clear__);
		    DAT_ram_00a63ac2 = '\x01';
		  }
		  param1_01 = *(int *)(iVar3 + 0x14);
		  param3_00 = *(int *)(param1_01 + 0xc);
		  *(undefined4 *)(param1_01 + 0xc) = 0;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(param1_01 + 8),0,param3_00,0);
		    param1_01 = *(int *)(iVar3 + 0x14);
		  }
		  func_ii_6335(param1_01,uVar1,
		               Method_System_Collections_Generic_List_RatingModel_RatingRecord__AddRange__);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x14) + 0x1c);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: SetRating ---
		int Gameplay_Competition_Control_Sections_RatingController__SetRating
		              (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a63afb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_RatingModel_RatingRecord_TypeInfo);
		    DAT_ram_00a63afb = '\x01';
		  }
		  uVar5 = *(undefined8 *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = *(undefined4 *)(param2 + 0xc);
		  param1_00 = *(int **)(iVar1 + 0xc);
		  iVar1 = *param1_00;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8))
		      {
		        puVar2 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8233dd26;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x8233dd26:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar3,puVar2[1]);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = unnamed_function_1417(Gameplay_Competition_Model_RatingModel_RatingRecord_TypeInfo);
		  *(undefined8 *)(iVar1 + 0x18) = uVar5;
		  *(int *)(iVar1 + 0x10) = param3 + 1;
		  *(undefined4 *)(iVar1 + 0xc) = uVar4;
		  *(undefined4 *)(iVar1 + 8) = uVar3;
		  return iVar1;
		}
		*/

}
