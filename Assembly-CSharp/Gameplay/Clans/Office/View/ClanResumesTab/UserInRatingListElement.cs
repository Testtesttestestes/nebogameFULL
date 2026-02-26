using System;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanResumesTab
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	public class UserInRatingListElement : SelectableListElement<UserInRatingListElement.UserInRatingListElementArgs>
	{
		// Token: 0x06003DCD RID: 15821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCD")]
		[Address(RVA = "0x8C8C", Offset = "0x8C8C", VA = "0x8C8C", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement__ApplyArgs
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param2 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCE")]
		[Address(RVA = "0x8C8D", Offset = "0x8C8D", VA = "0x8C8D", Slot = "10")]
		protected override void CallElementClickedEvent(UserInRatingListElement.UserInRatingListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f6c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a57f6c = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_UserInRatingListElement_UserInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCF")]
		[Address(RVA = "0x8C8E", Offset = "0x8C8E", VA = "0x8C8E")]
		public UserInRatingListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_UserInRatingListElement___ctor__
		              );
		    DAT_ram_00a57f6d = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_UserInRatingListElement___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected UserView _userView;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameImage _cultIcon;

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected TextMeshProUGUI _nickname;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TextMeshProUGUI _place;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected TextMeshProUGUI _score;

		// Token: 0x02000A31 RID: 2609
		[Token(Token = "0x2000A31")]
		public class UserInRatingListElementArgs : SelectableListElementArgs<UserInRatingListElement>
		{
			// Token: 0x06003DD0 RID: 15824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003DD0")]
			[Address(RVA = "0x8C8F", Offset = "0x8C8F", VA = "0x8C8F")]
			public UserInRatingListElementArgs()
			{
			}

			// Token: 0x0400229D RID: 8861
			[Token(Token = "0x400229D")]
			[FieldOffset(Offset = "0x1C")]
			public UserData UserData;

			// Token: 0x0400229E RID: 8862
			[Token(Token = "0x400229E")]
			[FieldOffset(Offset = "0x20")]
			public ulong Rating;

			// Token: 0x0400229F RID: 8863
			[Token(Token = "0x400229F")]
			[FieldOffset(Offset = "0x28")]
			public int Place;

			// Token: 0x040022A0 RID: 8864
			[Token(Token = "0x40022A0")]
			[FieldOffset(Offset = "0x2C")]
			public bool MyPlayer;
		}
	}
}
