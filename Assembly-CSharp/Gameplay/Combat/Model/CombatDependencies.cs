using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Cache.User;
using Core.Data.User;
using Core.Dict;
using Core.Gameplay.Managers.Prefetch;
using Gameplay.ArtifactDrop.Control;
using Gameplay.Combat.Factories;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Windows;
using Utils;

namespace Gameplay.Combat.Model
{
	// Token: 0x02000991 RID: 2449
	[Token(Token = "0x2000991")]
	public class CombatDependencies : IDisposable
	{
		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6F")]
		[CanBeNull]
		public LocalProps LocalProps
		{
			[Token(Token = "0x6003A65")]
			[Address(RVA = "0x89DB", Offset = "0x89DB", VA = "0x89DB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A66")]
			[Address(RVA = "0x89DC", Offset = "0x89DC", VA = "0x89DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x89DD", Offset = "0x89DD", VA = "0x89DD")]
		public CombatDependencies(ICombat combatWrapper, ICombatPlayerFactory combatPlayerFactory, ICombatSpellDataFactory combatSpellFactory, IUserCache userCache, IDictProvider dictProvider, IGameAudio audio, IUserSettings settings, IGameAssetProvider assetProvider, AbstractPrefetchManager assetsPrefetch, PopupController popupController, IArtifactDrop artifactDrop)
		{
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A68")]
		[Address(RVA = "0x89DE", Offset = "0x89DE", VA = "0x89DE")]
		public CombatDependencies(ICombat combatWrapper, ICombatPlayerFactory combatPlayerFactory, ICombatSpellDataFactory combatSpellFactory, IUserCache userCache, IDictProvider dictProvider, IGameAudio audio, IUserSettings settings, IGameAssetProvider assetProvider, AbstractPrefetchManager assetsPrefetch, PopupController popupController)
		{
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A69")]
		[Address(RVA = "0x89DF", Offset = "0x89DF", VA = "0x89DF", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x8")]
		[NotNull]
		public ICombatPlayerFactory CombatPlayerFactory;

		// Token: 0x04002034 RID: 8244
		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0xC")]
		[NotNull]
		public readonly ICombatSpellDataFactory CombatSpellFactory;

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x10")]
		[NotNull]
		public readonly IUserCache UserCache;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x14")]
		[NotNull]
		public readonly ICombat CombatWrapper;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		[FieldOffset(Offset = "0x18")]
		[NotNull]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002038 RID: 8248
		[Token(Token = "0x4002038")]
		[FieldOffset(Offset = "0x1C")]
		[NotNull]
		public readonly IGameAudio Audio;

		// Token: 0x04002039 RID: 8249
		[Token(Token = "0x4002039")]
		[FieldOffset(Offset = "0x20")]
		[NotNull]
		public readonly IUserSettings Settings;

		// Token: 0x0400203A RID: 8250
		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x24")]
		[NotNull]
		public readonly IGameAssetProvider AssetProvider;

		// Token: 0x0400203B RID: 8251
		[Token(Token = "0x400203B")]
		[FieldOffset(Offset = "0x28")]
		[NotNull]
		public readonly AbstractPrefetchManager AssetsPrefetch;

		// Token: 0x0400203C RID: 8252
		[Token(Token = "0x400203C")]
		[FieldOffset(Offset = "0x2C")]
		[NotNull]
		public readonly PopupController PopupController;

		// Token: 0x0400203D RID: 8253
		[Token(Token = "0x400203D")]
		[FieldOffset(Offset = "0x30")]
		[CanBeNull]
		public readonly IArtifactDrop ArtifactDrop;
	}
}
