using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC0 RID: 3008
	[Token(Token = "0x2000BC0")]
	public abstract class BattleInfoListElementBase<TPlayer, YInfo> : MonoBehaviour where TPlayer : PlayerBattleViewBase
	{
		// Token: 0x140001CC RID: 460
		// (add) Token: 0x060049CA RID: 18890 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060049CB RID: 18891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001CC")]
		public event Action<TPlayer> PlayerViewClickedEvent
		{
			[Token(Token = "0x60049CA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60049CB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060049CC RID: 18892
		[Token(Token = "0x60049CC")]
		public abstract bool TryGetPlayerView(ulong userId, out TPlayer playerView);

		// Token: 0x060049CD RID: 18893
		[Token(Token = "0x60049CD")]
		public abstract void Init(YInfo info);

		// Token: 0x060049CE RID: 18894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CE")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060049CF RID: 18895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049CF")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060049D0 RID: 18896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D0")]
		protected virtual void PlayerClickedEventHandler(PlayerBattleViewBase view)
		{
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049D1")]
		protected BattleInfoListElementBase()
		{
		}

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TPlayer _player1;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected TPlayer _player2;
	}
}
