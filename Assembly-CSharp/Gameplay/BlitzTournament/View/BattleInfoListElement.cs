using System;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BBF RID: 3007
	[Token(Token = "0x2000BBF")]
	public class BattleInfoListElement : BattleInfoListElementBase<PlayerBattleView, BattleInfo>
	{
		// Token: 0x060049C6 RID: 18886 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x9838", Offset = "0x9838", VA = "0x9838", Slot = "4")]
		public override bool TryGetPlayerView(ulong userId, out PlayerBattleView playerView)
		{
			return default(bool);
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x9839", Offset = "0x9839", VA = "0x9839", Slot = "5")]
		public override void Init(BattleInfo battleInfo)
		{
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C8")]
		[Address(RVA = "0x983A", Offset = "0x983A", VA = "0x983A", Slot = "8")]
		protected override void PlayerClickedEventHandler(PlayerBattleViewBase view)
		{
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x983B", Offset = "0x983B", VA = "0x983B")]
		public BattleInfoListElement()
		{
		}
	}
}
