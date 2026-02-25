using System;
using System.Runtime.CompilerServices;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Tournaments;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	[TupleElementNames(new string[]
	{
		"fighter1",
		"fighter2"
	})]
	public class TournamentBattleInfoListElement : BattleInfoListElementBase<TournamentPlayerBattleView, ValueTuple<Fighter, Fighter>>
	{
		// Token: 0x14000135 RID: 309
		// (add) Token: 0x06001C15 RID: 7189 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001C16 RID: 7190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000135")]
		public event Action<UserInfo> WatchButtonClickedEvent
		{
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x6D94", Offset = "0x6D94", VA = "0x6D94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x6D95", Offset = "0x6D95", VA = "0x6D95")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004EF")]
		public TournamentPlayerBattleView Player1
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x6D96", Offset = "0x6D96", VA = "0x6D96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F0")]
		public TournamentPlayerBattleView Player2
		{
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x6D97", Offset = "0x6D97", VA = "0x6D97")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x6D98", Offset = "0x6D98", VA = "0x6D98", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x6D99", Offset = "0x6D99", VA = "0x6D99", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x6D9A", Offset = "0x6D9A", VA = "0x6D9A")]
		private void WatchButtonClickedEventHandler()
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x6D9B", Offset = "0x6D9B", VA = "0x6D9B")]
		public void DetermineAction(TournamentStates state)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x6D9C", Offset = "0x6D9C", VA = "0x6D9C")]
		public void DisableWatchButton()
		{
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x6D9D", Offset = "0x6D9D", VA = "0x6D9D", Slot = "5")]
		public override void Init([TupleElementNames(new string[]
		{
			"fighter1",
			"fighter2"
		})] ValueTuple<Fighter, Fighter> info)
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x6D9E", Offset = "0x6D9E", VA = "0x6D9E", Slot = "4")]
		public override bool TryGetPlayerView(ulong userId, out TournamentPlayerBattleView playerView)
		{
			return default(bool);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x6D9F", Offset = "0x6D9F", VA = "0x6D9F")]
		public TournamentBattleInfoListElement()
		{
		}

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _swordsImage;
	}
}
