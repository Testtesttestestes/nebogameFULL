using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	public class TournamentProgressInfoBox : MonoBehaviourWithStates<TournamentProgressInfoBox.State>
	{
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050A")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6001C53")]
			[Address(RVA = "0x6DD2", Offset = "0x6DD2", VA = "0x6DD2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050B")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6001C54")]
			[Address(RVA = "0x6DD3", Offset = "0x6DD3", VA = "0x6DD3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050C")]
		public TextMeshProUGUI Status
		{
			[Token(Token = "0x6001C55")]
			[Address(RVA = "0x6DD4", Offset = "0x6DD4", VA = "0x6DD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050D")]
		public TextMeshProUGUI Annotation
		{
			[Token(Token = "0x6001C56")]
			[Address(RVA = "0x6DD5", Offset = "0x6DD5", VA = "0x6DD5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050E")]
		public TournamentBank Bank
		{
			[Token(Token = "0x6001C57")]
			[Address(RVA = "0x6DD6", Offset = "0x6DD6", VA = "0x6DD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700050F")]
		public MultilineTextList MultilineInfo
		{
			[Token(Token = "0x6001C58")]
			[Address(RVA = "0x6DD7", Offset = "0x6DD7", VA = "0x6DD7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x6DD8", Offset = "0x6DD8", VA = "0x6DD8")]
		public TournamentProgressInfoBox()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Tournaments_View_TournamentProgressInfoBox___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58500 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12674);
		    DAT_ram_00a58500 = '\x01';
		  }
		  return StringLiteral_12674;
		}
		*/

		}

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TournamentBank _bank;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MultilineTextList _textList;

		// Token: 0x020004B0 RID: 1200
		[Token(Token = "0x20004B0")]
		public enum State
		{
			// Token: 0x04000F66 RID: 3942
			[Token(Token = "0x4000F66")]
			NO_TOURNAMENT,
			// Token: 0x04000F67 RID: 3943
			[Token(Token = "0x4000F67")]
			DO_BETS = 2,
			// Token: 0x04000F68 RID: 3944
			[Token(Token = "0x4000F68")]
			BATTLE,
			// Token: 0x04000F69 RID: 3945
			[Token(Token = "0x4000F69")]
			WAITING
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MultilineInfo ---
		void Gameplay_Tournaments_View_TournamentProgressInfoBox__get_MultilineInfo
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584ff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TournamentProgressInfoBox_State___ctor__);
		    DAT_ram_00a584ff = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_TournamentProgressInfoBox_State___ctor__);
		  return;
		}
		*/

}
