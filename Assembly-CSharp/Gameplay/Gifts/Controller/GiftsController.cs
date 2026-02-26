using System;
using Core.Data;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using ServicesNamespace;
using Utils;

namespace Gameplay.Gifts.Controller
{
	// Token: 0x0200071A RID: 1818
	[Token(Token = "0x200071A")]
	public class GiftsController : AbstractController<GiftsModel, GiftsEvents>
	{
		// Token: 0x06002B7C RID: 11132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7C")]
		[Address(RVA = "0x7C13", Offset = "0x7C13", VA = "0x7C13")]
		public GiftsController(GiftsModel model, GiftsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_Controller_GiftsController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a252 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_Controller_GiftsController_GetGiftStatusResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a252 = '\x01';
		  }
		  uVar1 = ServicesNamespace_SocialService__get_ServiceId(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Gifts_Controller_GiftsController_GetGiftStatusResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7D")]
		[Address(RVA = "0x7C14", Offset = "0x7C14", VA = "0x7C14")]
		public void GetGiftsStatus()
		{
		/* --- GHIDRA: GetGiftsStatus ---
		void Gameplay_Gifts_Controller_GiftsController__GetGiftsStatus
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a253 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Social_ProtoGetGiftsStatusAns_TypeInfo);
		    DAT_ram_00a5a253 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Social_ProtoGetGiftsStatusAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Social_ProtoGetGiftsStatusAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x14) = param1_00[3];
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

		// Token: 0x06002B7E RID: 11134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7E")]
		[Address(RVA = "0x7C15", Offset = "0x7C15", VA = "0x7C15")]
		private void GetGiftStatusResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetGiftStatusResultHandler ---
		void Gameplay_Gifts_Controller_GiftsController__GetGiftStatusResultHandler
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 param3_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a254 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_Controller_GiftsController_SendGiftResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a5a254 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  param3_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param3,0);
		  uVar1 = ServicesNamespace_SocialService__GetGiftsStatus(uVar1,uVar2,param3_00,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Gifts_Controller_GiftsController_SendGiftResultHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7F")]
		[Address(RVA = "0x7C16", Offset = "0x7C16", VA = "0x7C16")]
		public void SendGift(SocialGiftDic giftInfo, UserData to)
		{
		/* --- GHIDRA: SendGift ---
		void Gameplay_Gifts_Controller_GiftsController__SendGift(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined8 uVar5;
		  int *piVar6;
		  int *param1_01;
		  undefined4 param3_00;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a255 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSendGiftErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_GiftsScope_GiftsEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SocialGiftDic_TypeInfo);
		    DAT_ram_00a5a255 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar6)) {
		    System_Activator__CreateInstance(piVar6,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar6[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedSendGiftErrors__ExpectedBillingErrors___
		                    );
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    piVar6 = *(int **)(iVar2 + 0x14);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0xc),0);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x811ee784;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_ICollection_ulong__TypeInfo,2);
		code_r0x811ee784:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar5,puVar3[1]);
		    uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar5);
		    uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      uVar5 = CONCAT44(uVar1,*(undefined4 *)(iVar2 + 0x14));
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))(*(undefined4 *)(iVar2 + 0x20),uVar5);
		      uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    }
		    piVar6 = *(int **)(param2 + 0xc);
		    if ((piVar6 != (int *)0x0) && (Protocol_Dic_SocialGiftDic_TypeInfo != *piVar6)) {
		      System_Activator__CreateInstance(piVar6,Protocol_Dic_SocialGiftDic_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x80) + 8);
		    if (iVar2 != 0) {
		      uVar5 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		      uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      uVar7 = 0;
		      param1_01 = *(int **)(iVar4 + 0x1c);
		      iVar4 = *param1_01;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0xe0);
		            goto code_r0x811ee87f;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811ee87f:
		      uVar5 = CONCAT44(uVar1,puVar3[1]);
		      param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,uVar5);
		      uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		      param3_00 = *(undefined4 *)(iVar4 + 0x1c);
		      uVar5 = CONCAT44((int)((ulonglong)uVar5 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		      uVar1 = (undefined4)((ulonglong)uVar5 >> 0x20);
		      uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0xc),0);
		      iVar4 = piVar6[3];
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_GiftsScope_GiftsEventArgs_TypeInfo);
		      Core_Events_Scopes_ThemeDuelScope_BattleFinishedArgs__get_WinnerId
		                (param1_00,param2_00,param3_00,uVar5,iVar4,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),CONCAT44(uVar1,param1_00),
		                 *(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B80")]
		[Address(RVA = "0x7C17", Offset = "0x7C17", VA = "0x7C17")]
		private void SendGiftResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SendGiftResultHandler ---
		void Gameplay_Gifts_Controller_GiftsController__SendGiftResultHandler(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
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
		  Gameplay_Gifts_Controller_GiftsController___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B81")]
		[Address(RVA = "0x7C18", Offset = "0x7C18", VA = "0x7C18", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x7C19", Offset = "0x7C19", VA = "0x7C19")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Gifts_Controller_GiftsController__ValidateInit(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a256 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GiftsModel__GiftsEvents__Dispose__);
		    DAT_ram_00a5a256 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_GiftsModel__GiftsEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x7C1A", Offset = "0x7C1A", VA = "0x7C1A", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Gifts_Controller_GiftsController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5a257 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView___ctor__
		              );
		    DAT_ram_00a5a257 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x18")]
		private SocialService _socialService;
	}
}
