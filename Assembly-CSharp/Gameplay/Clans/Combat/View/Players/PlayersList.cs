using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Combat.Model;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Clans.Combat.View.Players
{
	// Token: 0x02000A9A RID: 2714
	[Token(Token = "0x2000A9A")]
	public class PlayersList : OSA<BaseParamsWithPrefab, PlayerViewsHolder>
	{
		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CDF")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6004146")]
			[Address(RVA = "0x8FFD", Offset = "0x8FFD", VA = "0x8FFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06004147 RID: 16711 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CE0")]
		public Dictionaries Dictionaries
		{
			[Token(Token = "0x6004147")]
			[Address(RVA = "0x8FFE", Offset = "0x8FFE", VA = "0x8FFE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE1")]
		public SimpleDataHelper<CombatPlayer> Data
		{
			[Token(Token = "0x6004148")]
			[Address(RVA = "0x8FFF", Offset = "0x8FFF", VA = "0x8FFF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004149")]
			[Address(RVA = "0x9000", Offset = "0x9000", VA = "0x9000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x9001", Offset = "0x9001", VA = "0x9001")]
		public void Setup(IGameAudio audio, Dictionaries dictionaries)
		{
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x9002", Offset = "0x9002", VA = "0x9002", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x9003", Offset = "0x9003", VA = "0x9003", Slot = "99")]
		protected override PlayerViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x9004", Offset = "0x9004", VA = "0x9004", Slot = "100")]
		protected override void UpdateViewsHolder(PlayerViewsHolder newOrRecycled)
		{
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x9005", Offset = "0x9005", VA = "0x9005", Slot = "73")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414F")]
		[Address(RVA = "0x9006", Offset = "0x9006", VA = "0x9006")]
		public PlayersList()
		{
		}

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0xA0")]
		private IGameAudio _gameAudio;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0xA4")]
		private Dictionaries _dictionaries;
	}
}
