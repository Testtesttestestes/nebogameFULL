using System;
using Core.Data;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A3A RID: 2618
	[Token(Token = "0x2000A3A")]
	public class ClanMemberView : MonoBehaviour
	{
		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06003DF2 RID: 15858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C5D")]
		public Button LeftButton
		{
			[Token(Token = "0x6003DF2")]
			[Address(RVA = "0x8CB1", Offset = "0x8CB1", VA = "0x8CB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C5E")]
		public Button RightButton
		{
			[Token(Token = "0x6003DF3")]
			[Address(RVA = "0x8CB2", Offset = "0x8CB2", VA = "0x8CB2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF4")]
		[Address(RVA = "0x8CB3", Offset = "0x8CB3", VA = "0x8CB3")]
		public void UpdateView(UserData user, Dictionaries dict)
		{
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x8CB4", Offset = "0x8CB4", VA = "0x8CB4")]
		public ClanMemberView()
		{
		}

		// Token: 0x040022C6 RID: 8902
		[Token(Token = "0x40022C6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _userNick;

		// Token: 0x040022C7 RID: 8903
		[Token(Token = "0x40022C7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AprViewSmall _aprViewSmall;

		// Token: 0x040022C8 RID: 8904
		[Token(Token = "0x40022C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserRatingsRender _userRatingsRender;

		// Token: 0x040022C9 RID: 8905
		[Token(Token = "0x40022C9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _leftButton;

		// Token: 0x040022CA RID: 8906
		[Token(Token = "0x40022CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _rightButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RightButton ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberView__get_RightButton
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,param2_00,0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(param2 + 0x38),*(undefined4 *)(iVar1 + 0x13c))
		  ;
		  Gameplay_Clans_Office_View_ClansButtonView___ctor(*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  return;
		}
		*/

}
