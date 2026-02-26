using System;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Rating.View
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	public class MyRatingView : MonoBehaviourWithStates<MyRatingView.State>
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000623")]
		public UserInRatingListElement MyUser
		{
			[Token(Token = "0x60021A6")]
			[Address(RVA = "0x7305", Offset = "0x7305", VA = "0x7305")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000624")]
		public ClanInRatingListElement MyClan
		{
			[Token(Token = "0x60021A7")]
			[Address(RVA = "0x7306", Offset = "0x7306", VA = "0x7306")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x7307", Offset = "0x7307", VA = "0x7307")]
		public MyRatingView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Rating_View_MyRatingView___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58031 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1902);
		    DAT_ram_00a58031 = '\x01';
		  }
		  Gameplay_Clans_Office_View_ClanResumesTab_ClanResumesView___c__DisplayClass31_0___Remove_b__0
		            (param1,0);
		  if (*(int *)(*(int *)(param1 + 0x18) + 0x28) - 0x65U < 0xffffff9c) {
		    UnityEngine_Component__GetComponentInChildren_object_
		              (*(undefined4 *)(param1 + 0x30),StringLiteral_1902,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserInRatingListElement _myUser;

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanInRatingListElement _myClan;

		// Token: 0x02000580 RID: 1408
		[Token(Token = "0x2000580")]
		public enum State
		{
			// Token: 0x0400126C RID: 4716
			[Token(Token = "0x400126C")]
			UNKNOWN_STATE,
			// Token: 0x0400126D RID: 4717
			[Token(Token = "0x400126D")]
			USER,
			// Token: 0x0400126E RID: 4718
			[Token(Token = "0x400126E")]
			CLAN,
			// Token: 0x0400126F RID: 4719
			[Token(Token = "0x400126F")]
			NO_CLAN,
			// Token: 0x04001270 RID: 4720
			[Token(Token = "0x4001270")]
			HIDE_ALL
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MyClan ---
		void Gameplay_Rating_View_MyRatingView__get_MyClan(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58030 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_MyRatingView_State___ctor__);
		    DAT_ram_00a58030 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_MyRatingView_State___ctor__);
		  return;
		}
		*/

}
