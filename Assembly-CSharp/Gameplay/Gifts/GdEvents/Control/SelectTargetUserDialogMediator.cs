using System;
using Core.Data;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.GdEvents.View;
using Gameplay.Gifts.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Gifts.GdEvents.Control
{
	// Token: 0x02000718 RID: 1816
	[Token(Token = "0x2000718")]
	public class SelectTargetUserDialogMediator : AbstractViewMediator<GiftsModel, GiftsEvents, GiftController, SelectTargetUserDialog>
	{
		// Token: 0x06002B71 RID: 11121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B71")]
		[Address(RVA = "0x7C08", Offset = "0x7C08", VA = "0x7C08")]
		public SelectTargetUserDialogMediator(GiftsModel model, GiftsEvents events, GiftController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a24a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftController__SelectTargetUserDialog__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleGiftSentEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleGiftsStatusRequestedEvent__
		              );
		    DAT_ram_00a5a24a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleGiftsStatusRequestedEvent__
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleGiftSentEvent__
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
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleGiftsStatusRequestedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
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
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleGiftSentEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x1700084A RID: 2122
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084A")]
		public override GiftsEvents Events
		{
			[Token(Token = "0x6002B72")]
			[Address(RVA = "0x7C09", Offset = "0x7C09", VA = "0x7C09", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B73")]
		[Address(RVA = "0x7C0A", Offset = "0x7C0A", VA = "0x7C0A")]
		private void HandleGiftSentEvent()
		{
		/* --- GHIDRA: HandleGiftSentEvent ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__HandleGiftSentEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__HandleGiftsStatusRequestedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x7C0B", Offset = "0x7C0B", VA = "0x7C0B")]
		private void HandleGiftsStatusRequestedEvent()
		{
		/* --- GHIDRA: HandleGiftsStatusRequestedEvent ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__HandleGiftsStatusRequestedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined8 uVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  int iVar11;
		  int *piVar12;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a5a24b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftController__SelectTargetUserDialog__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a24b = '\x01';
		  }
		  uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar7);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  iVar2 = *(int *)(iVar2 + 0x88);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      piVar8 = *(int **)(param1[2] + 0x14);
		      iVar9 = *(int *)(iVar2 + iVar3 * 4 + 0x10);
		      uVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar9 + 0x24),0);
		      iVar11 = *piVar8;
		      if (*(ushort *)(iVar11 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_ICollection_ulong__TypeInfo == *piVar12) {
		            puVar5 = (uint *)(piVar12[1] * 8 + iVar11 + 0xe0);
		            goto code_r0x811ed8be;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar11 + 0xb6) != uVar10);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar8,System_Collections_Generic_ICollection_ulong__TypeInfo,4)
		      ;
		code_r0x811ed8be:
		      uVar10 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,uVar7,puVar5[1]);
		      uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar9 + 0x1c),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,uVar10 ^ 1,0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar7);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar3 + 0x74),0);
		  iVar2 = param1[2];
		  iVar3 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar2,iVar2);
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  piVar8 = *(int **)(iVar2 + 0x14);
		  iVar2 = *piVar8;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811ed9b4;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811ed9b4:
		  uVar10 = 1;
		  uVar7 = CONCAT44(uVar1,puVar5[1]);
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,uVar7);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  if (iVar2 != iVar3) {
		    uVar7 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x15c));
		    uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar7);
		    uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar3 = func_ii_8093(uVar6,
		                         Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                        );
		    piVar8 = *(int **)(iVar3 + 0x34);
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (System_Collections_Generic_ICollection_UserData__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		          puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811eda67;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar8,System_Collections_Generic_ICollection_UserData__TypeInfo,0
		                                 );
		code_r0x811eda67:
		    uVar7 = CONCAT44(uVar1,puVar5[1]);
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,uVar7);
		    uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    uVar10 = (uint)(iVar3 == 0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,uVar10,0);
		  iVar9 = *param1;
		  uVar7 = CONCAT44(uVar1,*(undefined4 *)(iVar9 + 0x15c));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))(param1,uVar7);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar3 + 0x70),0);
		  iVar2 = param1[2];
		  iVar3 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar2,iVar9);
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  uVar10 = 0;
		  piVar8 = *(int **)(iVar2 + 0x14);
		  iVar2 = *piVar8;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811edb4f;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811edb4f:
		  uVar7 = CONCAT44(uVar1,puVar5[1]);
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,uVar7);
		  if (iVar3 - iVar2 < 1) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		    return;
		  }
		  uVar10 = 0;
		  uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar7);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  iVar3 = func_ii_8093(uVar6,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  piVar8 = *(int **)(iVar3 + 0x34);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8)) {
		        puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811edc0c;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar10);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,System_Collections_Generic_ICollection_UserData__TypeInfo,0);
		code_r0x811edc0c:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,CONCAT44(uVar1,puVar5[1]));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(0 < iVar3),0);
		  return;
		}
		*/

		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x7C0C", Offset = "0x7C0C", VA = "0x7C0C")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__UpdateView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  int *param1_00;
		  undefined8 local_10;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a24c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftController__SelectTargetUserDialog__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_190);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25316);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8374);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8373);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8379);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8371);
		    DAT_ram_00a5a24c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x58);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_8371,1,0,1,0,0,0,0);
		  iVar7 = param1[2];
		  iVar2 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar7,iVar7);
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  param1_00 = *(int **)(iVar7 + 0x14);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811edd9f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811edd9f:
		  local_8 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  local_8 = iVar2 - local_8;
		  uVar5 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar5 = func_ii_4419(StringLiteral_190,uVar5,0);
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,uVar5,0);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x5c);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8373,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_4 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(param1[2],piVar6);
		  uVar5 = func_ii_4443(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_25316,uVar5,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_10;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar3,iVar2,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x2d0) * 4))
		            (piVar6,uVar3,*(undefined4 *)(*piVar6 + 0x2d4));
		  iVar7 = param1[2];
		  iVar2 = Gameplay_Gifts_Model_GiftsModel__get_GiftsSent(iVar7,iVar7);
		  if (DAT_ram_00a5a224 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a224 = '\x01';
		  }
		  piVar6 = *(int **)(iVar7 + 0x14);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811edf42;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_ICollection_ulong__TypeInfo,0);
		code_r0x811edf42:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  if (iVar7 == iVar2) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar6 = *(int **)(iVar2 + 100);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_8379,1,0,1,0,0,0,0);
		    iVar2 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar3,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  piVar6 = *(int **)(iVar2 + 0x34);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811ee051;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_ICollection_UserData__TypeInfo,0);
		code_r0x811ee051:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    piVar6 = *(int **)(iVar2 + 100);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_8374,1,0,1,0,0,0,0);
		    iVar2 = *piVar6;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar6,uVar3,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x7C0D", Offset = "0x7C0D", VA = "0x7C0D")]
		private void UpdateTexts()
		{
		/* --- GHIDRA: UpdateTexts ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__UpdateTexts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a24d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GiftsModel__GiftsEvents__GiftController__SelectTargetUserDialog__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a24d = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700084B RID: 2123
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084B")]
		public override SelectTargetUserDialog View
		{
			[Token(Token = "0x6002B77")]
			[Address(RVA = "0x7C0E", Offset = "0x7C0E", VA = "0x7C0E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x7C0F", Offset = "0x7C0F", VA = "0x7C0F")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a5a24f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleSelectEvent__
		              );
		    DAT_ram_00a5a24f = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleSelectEvent__
		             ,0);
		  if (DAT_ram_00a5a22d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a5a22d = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x84);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x84,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__HandleGiftsStatusRequestedEvent
		                (param1,iVar2);
		      Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__UpdateView(param1,iVar2);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x7C10", Offset = "0x7C10", VA = "0x7C10")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__SetupView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a5a250 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		              );
		    DAT_ram_00a5a250 = '\x01';
		  }
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  *(int *)(iVar2 + 0xc) = param2;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = func_ii_8093(uVar4,
		                       Method_UI_Windows_BaseWindow_SelectTargetUserDialog_SelectTargetUserDialogArgs__get_WindowArgs__
		                      );
		  uVar4 = *(undefined4 *)(iVar2 + 0x2c);
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  Gameplay_Gifts_Controller_GiftsController__GetGiftStatusResultHandler
		            (uVar3,uVar4,*(undefined4 *)(iVar2 + 0xc),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = *(int *)(*(int *)(iVar2 + 0x88) + 0xc);
		  if (0 < iVar5) {
		    do {
		      iVar7 = *(int *)(*(int *)(iVar2 + 0x88) + iVar6 * 4 + 0x10);
		      if (param2 == *(int *)(iVar7 + 0x24)) {
		        uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar7 + 0x1c),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar3,0,0);
		        return;
		      }
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x7C11", Offset = "0x7C11", VA = "0x7C11")]
		private void HandleSelectEvent(UserData user)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__HandleGiftsStatusRequestedEvent
		            (param1,param1);
		  Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__UpdateView(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a5a24e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleSelectEvent__
		              );
		    DAT_ram_00a5a24e = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = unnamed_function_1417(System_Action_UserData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Gifts_GdEvents_Control_SelectTargetUserDialogMediator_HandleSelectEvent__
		             ,0);
		  if (DAT_ram_00a5a22e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a5a22e = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x84);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x84,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
