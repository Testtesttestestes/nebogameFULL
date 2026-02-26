using System;
using AssetContent;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations;
using UnityEngine;

namespace Gameplay.Portals.View.RatingTab
{
	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	public class UserInPortalRatingListElement : UserRatingListElement
	{
		// Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x74C2", Offset = "0x74C2", VA = "0x74C2", Slot = "12")]
		protected virtual void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement__Start
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int *param1_00;
		  int *piVar4;
		  int local_4;
		  
		  if (DAT_ram_00a5810c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_602);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1902);
		    DAT_ram_00a5810c = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView___c__DisplayClass31_0___Remove_b__0
		            (param1,0);
		  if (DAT_ram_00a5803a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a5803a = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x28);
		  if ((iVar1 < 1) || (*(int *)(*(int *)(param1 + 0x3c) + 0xc) < iVar1)) {
		    uVar2 = *(undefined4 *)(param1 + 0x38);
		    if (*(char *)(*(int *)(param1 + 0x18) + 0x2c) == '\0') {
		      puVar3 = (undefined4 *)(param1 + 0x40);
		    }
		    else {
		      puVar3 = (undefined4 *)(param1 + 0x44);
		    }
		  }
		  else {
		    puVar3 = (undefined4 *)(iVar1 * 4 + *(int *)(param1 + 0x3c) + 0xc);
		    uVar2 = *(undefined4 *)(param1 + 0x38);
		  }
		  func_ii_7050(uVar2,*puVar3,0);
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (param1_00,
		                 Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement_UserInPortalRatingListElementArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  piVar4 = *(int **)(param1 + 0x48);
		  local_4 = param1_00[0xc];
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar2 = func_ii_4419(StringLiteral_602,uVar2,0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x4c),param1_00[0xd],0);
		  if (*(int *)(*(int *)(param1 + 0x18) + 0x28) - 0x65U < 0xffffff9c) {
		    UnityEngine_Component__GetComponentInChildren_object_
		              (*(undefined4 *)(param1 + 0x30),StringLiteral_1902,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x74C3", Offset = "0x74C3", VA = "0x74C3", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement__ApplyArgs
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement__CallElementClickedEvent
		            (param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x74C4", Offset = "0x74C4", VA = "0x74C4")]
		public UserInPortalRatingListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_View_RatingTab_UserInPortalRatingListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _participant;

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected GameImage _icon;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextToolTip _scoreToolTip;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextToolTip _participantToolTip;

		// Token: 0x020005C6 RID: 1478
		[Token(Token = "0x20005C6")]
		public class UserInPortalRatingListElementArgs : UserInRatingListElement.UserInRatingListElementArgs
		{
			// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x74C5", Offset = "0x74C5", VA = "0x74C5")]
			public UserInPortalRatingListElementArgs()
			{
			}

			// Token: 0x0400137F RID: 4991
			[Token(Token = "0x400137F")]
			[FieldOffset(Offset = "0x30")]
			public uint Participant;

			// Token: 0x04001380 RID: 4992
			[Token(Token = "0x4001380")]
			[FieldOffset(Offset = "0x34")]
			public string IconAssetID;
		}
	}
}
