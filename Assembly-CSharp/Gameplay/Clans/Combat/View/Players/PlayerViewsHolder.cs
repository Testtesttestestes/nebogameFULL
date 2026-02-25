using System;
using Com.TheFallenGames.OSA.Core;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Clans.Combat.View.Players
{
	// Token: 0x02000A99 RID: 2713
	[Token(Token = "0x2000A99")]
	public class PlayerViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CDD")]
		public ICombatPLayerView ItemRenderer
		{
			[Token(Token = "0x6004140")]
			[Address(RVA = "0x8FF7", Offset = "0x8FF7", VA = "0x8FF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004142 RID: 16706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDE")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6004141")]
			[Address(RVA = "0x8FF8", Offset = "0x8FF8", VA = "0x8FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004142")]
			[Address(RVA = "0x8FF9", Offset = "0x8FF9", VA = "0x8FF9")]
			set
			{
			}
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004143")]
		[Address(RVA = "0x8FFA", Offset = "0x8FFA", VA = "0x8FFA", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004144")]
		[Address(RVA = "0x8FFB", Offset = "0x8FFB", VA = "0x8FFB", Slot = "11")]
		public override void OnBeforeDestroy()
		{
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004145")]
		[Address(RVA = "0x8FFC", Offset = "0x8FFC", VA = "0x8FFC")]
		public PlayerViewsHolder(IGameAudio gameAudio, Dictionaries dictionaries)
		{
		}

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x14")]
		private IGameAudio _gameAudio;

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x18")]
		private Dictionaries _dictionaries;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[FieldOffset(Offset = "0x1C")]
		private ICombatPLayerView _itemRenderer;
	}
}
