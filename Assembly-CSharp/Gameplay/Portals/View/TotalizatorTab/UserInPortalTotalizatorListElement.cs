using System;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using Protocol.Portal;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View.TotalizatorTab
{
	// Token: 0x020005BD RID: 1469
	[Token(Token = "0x20005BD")]
	public class UserInPortalTotalizatorListElement : UserInPortalRatingListElement
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x7489", Offset = "0x7489", VA = "0x7489", Slot = "12")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement__Start
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a580f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__OnDestroy__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceLose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceWin__
		              );
		    DAT_ram_00a580f9 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElement_object___DataChangedEventHandler
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__OnDestroy__
		            );
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceWin__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_OnChoiceLose__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x748A", Offset = "0x748A", VA = "0x748A", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  uint param2_00;
		  undefined8 *puVar3;
		  float param2_01;
		  int iVar4;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a580fa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		              );
		    DAT_ram_00a580fa = '\x01';
		  }
		  Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement__Start(param1,&local_40);
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param1_00,
		                 Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = param1_00[0x10];
		  param2_00 = (uint)((char)iVar1 == '\0');
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x58),param2_00,0);
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x60),param2_00,0);
		  iVar4 = param1_00[0xf];
		  puVar3 = (undefined8 *)(param1 + 0x78);
		  if (iVar4 != 1) {
		    puVar3 = (undefined8 *)(param1 + 0x68);
		  }
		  local_28 = puVar3[1];
		  local_30 = *puVar3;
		  iVar2 = **(int **)(param1 + 0x5c);
		  local_10 = local_30;
		  local_8 = local_28;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		            (*(int **)(param1 + 0x5c),&local_30,*(undefined4 *)(iVar2 + 0x17c));
		  puVar3 = (undefined8 *)(param1 + 0x78);
		  if (iVar4 != 2) {
		    puVar3 = (undefined8 *)(param1 + 0x68);
		  }
		  local_38 = puVar3[1];
		  local_40 = *puVar3;
		  iVar4 = **(int **)(param1 + 100);
		  local_20 = local_40;
		  local_18 = local_38;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x178) * 4))
		            (*(int **)(param1 + 100),&local_40,*(undefined4 *)(iVar4 + 0x17c));
		  param2_01 = 0.5;
		  if ((char)iVar1 == '\0') {
		    param2_01 = 1.0;
		  }
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic
		            (*(undefined4 *)(param1 + 0x5c),param2_01,0.0,0);
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic
		            (*(undefined4 *)(param1 + 100),param2_01,0.0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x748B", Offset = "0x748B", VA = "0x748B", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement__ApplyArgs
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  int *param1_00;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a580fb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		              );
		    DAT_ram_00a580fb = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x5c);
		  local_8 = *(undefined8 *)(param1 + 0x70);
		  local_10 = *(undefined8 *)(param1 + 0x68);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		            (*(int **)(param1 + 0x5c),CONCAT44(in_register_20000014,&local_10),
		             *(undefined4 *)(iVar2 + 0x17c));
		  iVar2 = **(int **)(param1 + 100);
		  local_18 = *(undefined8 *)(param1 + 0x80);
		  local_20 = *(undefined8 *)(param1 + 0x78);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		            (*(int **)(param1 + 100),&local_20,*(undefined4 *)(iVar2 + 0x17c));
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param1_00,
		                 Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = param1_00[0xe];
		  if (iVar2 != 0) {
		    uVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,2,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x748C", Offset = "0x748C", VA = "0x748C")]
		private void OnChoiceLose()
		{
		/* --- GHIDRA: OnChoiceLose ---
		void Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement__OnChoiceLose
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  int *param1_00;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a580fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		              );
		    DAT_ram_00a580fc = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x5c);
		  local_8 = *(undefined8 *)(param1 + 0x80);
		  local_10 = *(undefined8 *)(param1 + 0x78);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		            (*(int **)(param1 + 0x5c),CONCAT44(in_register_20000014,&local_10),
		             *(undefined4 *)(iVar2 + 0x17c));
		  iVar2 = **(int **)(param1 + 100);
		  local_18 = *(undefined8 *)(param1 + 0x70);
		  local_20 = *(undefined8 *)(param1 + 0x68);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		            (*(int **)(param1 + 100),&local_20,*(undefined4 *)(iVar2 + 0x17c));
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param1_00,
		                 Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = param1_00[0xe];
		  if (iVar2 != 0) {
		    uVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c),0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x748D", Offset = "0x748D", VA = "0x748D")]
		private void OnChoiceWin()
		{
		/* --- GHIDRA: OnChoiceWin ---
		void Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement__OnChoiceWin
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 *puVar2;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  puVar2 = (undefined8 *)(param1 + 0x78);
		  if (param2 != 1) {
		    puVar2 = (undefined8 *)(param1 + 0x68);
		  }
		  local_28 = puVar2[1];
		  local_30 = *puVar2;
		  iVar1 = **(int **)(param1 + 0x5c);
		  local_10 = local_30;
		  local_8 = local_28;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x5c),&local_30,*(undefined4 *)(iVar1 + 0x17c));
		  puVar2 = (undefined8 *)(param1 + 0x78);
		  if (param2 != 2) {
		    puVar2 = (undefined8 *)(param1 + 0x68);
		  }
		  local_38 = puVar2[1];
		  local_40 = *puVar2;
		  iVar1 = **(int **)(param1 + 100);
		  local_20 = local_40;
		  local_18 = local_38;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 100),&local_40,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x748E", Offset = "0x748E", VA = "0x748E")]
		private void ChangeColor(Bet.Types.State state)
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x748F", Offset = "0x748F", VA = "0x748F")]
		public UserInPortalTotalizatorListElement()
		{
		}

		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _winButton;

		// Token: 0x04001358 RID: 4952
		[Token(Token = "0x4001358")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _winText;

		// Token: 0x04001359 RID: 4953
		[Token(Token = "0x4001359")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _loseButton;

		// Token: 0x0400135A RID: 4954
		[Token(Token = "0x400135A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private TextMeshProUGUI _loseText;

		// Token: 0x0400135B RID: 4955
		[Token(Token = "0x400135B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400135C RID: 4956
		[Token(Token = "0x400135C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x020005BE RID: 1470
		[Token(Token = "0x20005BE")]
		public class UserInPortalTotalizatorListElementArgs : UserInPortalRatingListElement.UserInPortalRatingListElementArgs
		{
			// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x7490", Offset = "0x7490", VA = "0x7490")]
			public UserInPortalTotalizatorListElementArgs()
			{
			}

			// Token: 0x0400135D RID: 4957
			[Token(Token = "0x400135D")]
			[FieldOffset(Offset = "0x38")]
			public Action<ulong, Bet.Types.State> ChoiceHandler;

			// Token: 0x0400135E RID: 4958
			[Token(Token = "0x400135E")]
			[FieldOffset(Offset = "0x3C")]
			public Bet.Types.State Choice;

			// Token: 0x0400135F RID: 4959
			[Token(Token = "0x400135F")]
			[FieldOffset(Offset = "0x40")]
			public bool Locked;
		}
	}
}
