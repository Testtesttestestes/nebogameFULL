using System;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.Model;
using Gameplay.Gifts.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using TMPro;

namespace Gameplay.Gifts.Controller
{
	// Token: 0x0200071B RID: 1819
	[Token(Token = "0x200071B")]
	public class GiftsViewMediator : AbstractViewMediator<GiftsModel, GiftsEvents, GiftsController, GiftsView>
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x7C1B", Offset = "0x7C1B", VA = "0x7C1B")]
		public GiftsViewMediator(GiftsModel model, GiftsEvents events, GiftsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_Controller_GiftsViewMediator___ctor(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a258 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__set_View__
		              );
		    DAT_ram_00a5a258 = '\x01';
		  }
		  param1[5] = param2;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1_00,0);
		  if (iVar1 != 0) {
		    Gameplay_Gifts_Controller_GiftsViewMediator__set_Events(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700084C RID: 2124
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084C")]
		public override GiftsView View
		{
			[Token(Token = "0x6002B85")]
			[Address(RVA = "0x7C1C", Offset = "0x7C1C", VA = "0x7C1C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700084D RID: 2125
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084D")]
		public override GiftsEvents Events
		{
			[Token(Token = "0x6002B86")]
			[Address(RVA = "0x7C1D", Offset = "0x7C1D", VA = "0x7C1D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x7C1E", Offset = "0x7C1E", VA = "0x7C1E")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *param2_00;
		  undefined8 uVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a25b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a25b = '\x01';
		  }
		  param1_00 = *(int **)(*(int *)(param1 + 8) + 0x14);
		  uVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x811eeeb2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_ulong__TypeInfo,
		                                   4);
		code_r0x811eeeb2:
		  iVar3 = (**(code **)((ulonglong)*param2_00 * 4))(param1_00,uVar2,param2_00[1]);
		  if ((iVar3 != 0) && (iVar3 = *(int *)(param1 + 0x18), 0 < *(int *)(iVar3 + 0xc))) {
		    param2_00 = (uint *)0x0;
		    do {
		      System_Linq_Enumerable__First_object_
		                (*(undefined4 *)(*(int *)(iVar3 + (int)param2_00 * 4 + 0x10) + 0x1c),0,0);
		      param2_00 = (uint *)((int)param2_00 + 1);
		    } while ((int)param2_00 < *(int *)(iVar3 + 0xc));
		  }
		  Gameplay_Gifts_Controller_GiftsViewMediator__DisableAllSendButtons(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x7C1F", Offset = "0x7C1F", VA = "0x7C1F")]
		private void GiftsStatusRequestedEventHandler()
		{
		/* --- GHIDRA: GiftsStatusRequestedEventHandler ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__GiftsStatusRequestedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a25c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__get_Model__
		              );
		    DAT_ram_00a5a25c = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Gifts_Controller_GiftsController__GetGiftStatusResultHandler
		            (param1_00,*(undefined4 *)(param2 + 0x2c),*(undefined4 *)(param1[2] + 0xc),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x7C20", Offset = "0x7C20", VA = "0x7C20")]
		private void SendGiftEventHandler(GiftView view)
		{
		/* --- GHIDRA: SendGiftEventHandler ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__SendGiftEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  uint *puVar3;
		  uint uVar4;
		  undefined8 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a25d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_View_GiftInfoWindow_GiftInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_View_GiftInfoWindow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12626);
		    DAT_ram_00a5a25d = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Gifts_View_GiftInfoWindow_GiftInfoWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		  piVar2 = (int *)UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12626,param1_00,0,0)
		  ;
		  iVar6 = Gameplay_Gifts_View_GiftInfoWindow_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param1 + 0x1c) = 0;
		code_r0x811ef627:
		    Gameplay_Gifts_Controller_GiftsViewMediator__GiftSentEventHandler
		              (param1,*(undefined4 *)(param2 + 0x2c),piVar2[0xf],piVar2);
		    iVar6 = *(int *)(*(int *)(param1 + 0x1c) + 0x3c);
		    piVar2 = *(int **)(*(int *)(param1 + 8) + 0x14);
		    uVar4 = 0;
		    uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		    iVar7 = *piVar2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar4 * 8 + 4) * 8 + iVar7 + 0xe0);
		          goto code_r0x811ef6cd;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar4);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_ulong__TypeInfo,4);
		code_r0x811ef6cd:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,uVar5,puVar3[1]);
		    System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar6 + 0x1c),uVar4 ^ 1,0);
		    Gameplay_Gifts_Controller_GiftsViewMediator__DisableAllSendButtons(param1,uVar4);
		    return;
		  }
		  uVar4 = (uint)*(byte *)(Gameplay_Gifts_View_GiftInfoWindow_TypeInfo + 0xb8);
		  if ((uVar4 <= *(byte *)(*piVar2 + 0xb8)) &&
		     (*(int *)(*(int *)(*piVar2 + 100) + (uVar4 - 1) * 4) ==
		      Gameplay_Gifts_View_GiftInfoWindow_TypeInfo)) {
		    *(int **)(param1 + 0x1c) = piVar2;
		    if ((uVar4 <= *(byte *)(*piVar2 + 0xb8)) &&
		       (*(int *)(*(int *)(*piVar2 + 100) + (uVar4 - 1) * 4) == iVar6)) goto code_r0x811ef627;
		  }
		  System_Activator__CreateInstance(piVar2,iVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x7C21", Offset = "0x7C21", VA = "0x7C21")]
		private void GiftInfoButtonClickEventHandler(GiftView giftUI)
		{
		/* --- GHIDRA: GiftInfoButtonClickEventHandler ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__GiftInfoButtonClickEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a25e == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a25e = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param2_00 = 0;
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    System_Linq_Enumerable__First_object_
		              (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x3c) + 0x1c),0,0);
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      System_Linq_Enumerable__First_object_
		                (*(undefined4 *)(*(int *)(iVar1 + param2_00 * 4 + 0x10) + 0x1c),0,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  Gameplay_Gifts_Controller_GiftsViewMediator__DisableAllSendButtons(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x7C22", Offset = "0x7C22", VA = "0x7C22")]
		private void GiftSentEventHandler()
		{
		/* --- GHIDRA: GiftSentEventHandler ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__GiftSentEventHandler
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a25f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GiftView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftInfoButtonClickEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_Controller_GiftsViewMediator_SendGiftEventHandler__);
		    DAT_ram_00a5a25f = '\x01';
		  }
		  Gameplay_Gifts_View_GiftView__OnDestroy
		            (param3,param2,*(undefined4 *)(*(int *)(param1 + 8) + 8),param3);
		  uVar1 = unnamed_function_1417(System_Action_GiftView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftInfoButtonClickEventHandler__,0)
		  ;
		  *(undefined4 *)(param3 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_GiftView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Gifts_Controller_GiftsViewMediator_SendGiftEventHandler__,
		             0);
		  *(undefined4 *)(param3 + 0x24) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x7C23", Offset = "0x7C23", VA = "0x7C23")]
		private void InitGiftView(SocialGiftDic gift, GiftView instance)
		{
		/* --- GHIDRA: InitGiftView ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__InitGiftView(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      System_Linq_Enumerable__First_object_
		                (*(undefined4 *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x1c),0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x7C24", Offset = "0x7C24", VA = "0x7C24")]
		private void DisableAllSendButtons()
		{
		/* --- GHIDRA: DisableAllSendButtons ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__DisableAllSendButtons
		               (int *param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined8 uVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  uint uVar9;
		  int iVar10;
		  
		  if (DAT_ram_00a5a260 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a260 = '\x01';
		  }
		  piVar7 = *(int **)(param1[2] + 0x14);
		  uVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1[2] + 0xc),0);
		  iVar10 = *piVar7;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8 + 4) * 8 + iVar10 + 0xe0);
		        goto code_r0x811eefc6;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_ICollection_ulong__TypeInfo,4);
		code_r0x811eefc6:
		  iVar10 = (**(code **)((ulonglong)*puVar1 * 4))(piVar7,uVar6,puVar1[1]);
		  uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar6);
		  uVar8 = *(undefined4 *)(iVar2 + 0x18);
		  if (iVar10 == 0) {
		    uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    uVar4 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                      (*(undefined4 *)(param1[2] + 0xc),0);
		    uVar5 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(param1[2],0);
		    iVar2 = param1[2];
		    iVar10 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar2,iVar2);
		    if (DAT_ram_00a5a224 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		      DAT_ram_00a5a224 = '\x01';
		    }
		    piVar7 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811ef1a7;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811ef1a7:
		    uVar6 = CONCAT44(uVar3,puVar1[1]);
		    iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar7,uVar6);
		    uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    Gameplay_Gifts_Controller_GiftsViewMediator__RefreshAnnotation
		              (puVar1,uVar8,uVar4,uVar5,iVar10 - iVar2,puVar1);
		    iVar10 = param1[7];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar10,0,0);
		    if (iVar2 != 0) {
		      uVar5 = *(undefined4 *)(param1[7] + 0x40);
		      uVar8 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                        (*(undefined4 *)(param1[2] + 0xc),0);
		      uVar4 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(param1[2],iVar10);
		      iVar2 = param1[2];
		      iVar10 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar2,iVar2);
		      if (DAT_ram_00a5a224 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		        DAT_ram_00a5a224 = '\x01';
		      }
		      piVar7 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar7;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		            puVar1 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811ef2b8;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_ICollection_ulong__TypeInfo,0)
		      ;
		code_r0x811ef2b8:
		      iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar7,CONCAT44(uVar3,puVar1[1]));
		      Gameplay_Gifts_Controller_GiftsViewMediator__RefreshAnnotation
		                (puVar1,uVar5,uVar8,uVar4,iVar10 - iVar2,puVar1);
		    }
		  }
		  else {
		    if (DAT_ram_00a5a262 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		      Mono_Security_ASN1__get_Item(&StringLiteral_8372);
		      DAT_ram_00a5a262 = '\x01';
		    }
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8372,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar3,0);
		    iVar10 = param1[7];
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar10 = UnityEngine_TextCore_Text_TextElement__get_textAsset(iVar10,0,0);
		    if (iVar10 != 0) {
		      uVar8 = *(undefined4 *)(param1[7] + 0x40);
		      if (DAT_ram_00a5a262 == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		        Mono_Security_ASN1__get_Item(&StringLiteral_8372);
		        DAT_ram_00a5a262 = '\x01';
		      }
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8372,1,0,1,0,0,0,0);
		      UnityEngine_Component__GetComponentInChildren_object_(uVar8,uVar3,0);
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x7C25", Offset = "0x7C25", VA = "0x7C25")]
		private void RefreshAnnotation()
		{
		/* --- GHIDRA: RefreshAnnotation ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__RefreshAnnotation
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_4 = param4;
		  if (DAT_ram_00a5a261 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8380);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_528);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28594);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8371);
		    Mono_Security_ASN1__get_Item(&StringLiteral_144);
		    DAT_ram_00a5a261 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,7);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8380,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  uVar1 = StringLiteral_144;
		  *(undefined4 *)(param1_00 + 0x18) = param3;
		  *(undefined4 *)(param1_00 + 0x14) = uVar1;
		  *(undefined4 *)(param1_00 + 0x1c) = StringLiteral_528;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8373,1,0,1,0,0,0,0);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = func_ii_4443(&local_4,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_25316,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar1 = Core_GameLocalization__GetTranslation(uVar1,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  *(undefined4 *)(param1_00 + 0x24) = StringLiteral_47;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8371,1,0,1,0,0,0,0);
		  local_8 = param5;
		  uVar2 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28594,uVar1,uVar2,0);
		  *(undefined4 *)(param1_00 + 0x28) = uVar1;
		  uVar1 = System_Single__ToString(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x7C26", Offset = "0x7C26", VA = "0x7C26")]
		private void UpdateAnnotation(TextMeshProUGUI text, string owner, int maxGifts, int giftsLeft)
		{
		/* --- GHIDRA: UpdateAnnotation ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__UpdateAnnotation
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a262 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8372);
		    DAT_ram_00a5a262 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8372,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param2,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x7C27", Offset = "0x7C27", VA = "0x7C27")]
		private void UpdateSentAnnotation(TextMeshProUGUI text)
		{
		}

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x18")]
		private GiftView[] _giftInstances;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x1C")]
		private GiftInfoWindow _infoWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__set_View(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a259 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftSentEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftsStatusRequestedEventHandler__
		              );
		    DAT_ram_00a5a259 = '\x01';
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
		               Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftSentEventHandler__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftsStatusRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
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
		               Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftSentEventHandler__,0);
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_Controller_GiftsViewMediator_GiftsStatusRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1))
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Gifts_Controller_GiftsViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5a25a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftsController__GiftsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_View_GiftView___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GiftView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a25a = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Gifts_View_GiftView___TypeInfo,
		                     *(undefined4 *)(*(int *)(param1[2] + 0x10) + 0xc));
		  param1[6] = iVar1;
		  if (0 < *(int *)(*(int *)(param1[2] + 0x10) + 0xc)) {
		    do {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar3 = *(undefined4 *)(iVar1 + 0x10);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      param2_00 = *(undefined4 *)(iVar1 + 0x14);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = func_ii_6805(uVar3,param2_00,Method_UnityEngine_Object_Instantiate_GiftView___);
		      Gameplay_Gifts_Controller_GiftsViewMediator__GiftSentEventHandler
		                (param1,*(undefined4 *)(iVar5 * 4 + *(int *)(param1[2] + 0x10) + 0x10),iVar1,param1)
		      ;
		      piVar4 = (int *)param1[6];
		      if ((iVar1 != 0) && (iVar2 = func_ii_1082(iVar1,*(undefined4 *)(*piVar4 + 0x20)), iVar2 == 0))
		      {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar4[iVar5 + 4] = iVar1;
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(*(int *)(param1[2] + 0x10) + 0xc));
		  }
		  return;
		}
		*/

}
