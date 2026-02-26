using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab
{
	// Token: 0x02000A23 RID: 2595
	[Token(Token = "0x2000A23")]
	public class ClanPolicyInfoBox : MonoBehaviour
	{
		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06003D92 RID: 15762 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3C")]
		public ClanWarStatusView WarStatusView
		{
			[Token(Token = "0x6003D92")]
			[Address(RVA = "0x8C51", Offset = "0x8C51", VA = "0x8C51")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D93")]
		[Address(RVA = "0x8C52", Offset = "0x8C52", VA = "0x8C52")]
		public void UpdateData(ClanData data, string honorAssetId)
		{
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D94")]
		[Address(RVA = "0x8C53", Offset = "0x8C53", VA = "0x8C53")]
		public ClanPolicyInfoBox()
		{
		}

		// Token: 0x04002265 RID: 8805
		[Token(Token = "0x4002265")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ClanTitle _title;

		// Token: 0x04002266 RID: 8806
		[Token(Token = "0x4002266")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ClanLeagueBaseInfoView _leagueBaseInfo;

		// Token: 0x04002267 RID: 8807
		[Token(Token = "0x4002267")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClanWarStatusView _warStatusView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WarStatusView ---
		void Gameplay_Clans_Office_View_ClanWarsTab_ClanPoliticsTab_ClanPolicyInfoBox__get_WarStatusView
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Clans_Office_View_ClanTitle__get_Text
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x18),0);
		  Gameplay_Clans_Office_View_ClanLeagueBaseInfoView__Awake
		            (*(undefined4 *)(param1 + 0x14),param2,param3,0);
		  return;
		}
		*/

}
