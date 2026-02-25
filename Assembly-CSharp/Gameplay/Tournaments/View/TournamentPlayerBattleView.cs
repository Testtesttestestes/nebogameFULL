using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using Protocol.Tournaments;
using TMPro;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public class TournamentPlayerBattleView : PlayerBattleViewBase, IToolTipDataProvider
	{
		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000507")]
		public Fighter Fighter
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x6DC8", Offset = "0x6DC8", VA = "0x6DC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x6DC9", Offset = "0x6DC9", VA = "0x6DC9")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000508")]
		public UserData UserData
		{
			[Token(Token = "0x6001C4B")]
			[Address(RVA = "0x6DCA", Offset = "0x6DCA", VA = "0x6DCA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C4C")]
			[Address(RVA = "0x6DCB", Offset = "0x6DCB", VA = "0x6DCB")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x17000509")]
		protected override uint _totalHealth
		{
			[Token(Token = "0x6001C4D")]
			[Address(RVA = "0x6DCC", Offset = "0x6DCC", VA = "0x6DCC", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x6DCD", Offset = "0x6DCD", VA = "0x6DCD")]
		public void Init(Fighter fighter)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x6DCE", Offset = "0x6DCE", VA = "0x6DCE")]
		public void SetFighter(Fighter fighter)
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x6DCF", Offset = "0x6DCF", VA = "0x6DCF")]
		public void ShowResultImage(bool win)
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x6DD0", Offset = "0x6DD0", VA = "0x6DD0", Slot = "8")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x6DD1", Offset = "0x6DD1", VA = "0x6DD1")]
		public TournamentPlayerBattleView()
		{
		}

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameObject _resultImage;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _bet;
	}
}
