using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Core.Dict;
using Gameplay.Inventory.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Utils;

namespace Core.Data
{
	// Token: 0x020010B4 RID: 4276
	[Token(Token = "0x20010B4")]
	public class ArtifactData : ArtikulData
	{
		// Token: 0x14000232 RID: 562
		// (add) Token: 0x06006344 RID: 25412 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006345 RID: 25413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000232")]
		public event Action IsFavoriteChangedEvent
		{
			[Token(Token = "0x6006344")]
			[Address(RVA = "0xAF50", Offset = "0xAF50", VA = "0xAF50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006345")]
			[Address(RVA = "0xAF51", Offset = "0xAF51", VA = "0xAF51")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000233 RID: 563
		// (add) Token: 0x06006346 RID: 25414 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006347 RID: 25415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000233")]
		public event Action IsFreshChangedEvent
		{
			[Token(Token = "0x6006346")]
			[Address(RVA = "0xAF52", Offset = "0xAF52", VA = "0xAF52")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006347")]
			[Address(RVA = "0xAF53", Offset = "0xAF53", VA = "0xAF53")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000234 RID: 564
		// (add) Token: 0x06006348 RID: 25416 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006349 RID: 25417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000234")]
		public event Action IsFreshWatchedChangedEvent
		{
			[Token(Token = "0x6006348")]
			[Address(RVA = "0xAF54", Offset = "0xAF54", VA = "0xAF54")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006349")]
			[Address(RVA = "0xAF55", Offset = "0xAF55", VA = "0xAF55")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000235 RID: 565
		// (add) Token: 0x0600634A RID: 25418 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600634B RID: 25419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000235")]
		public event Action ArtifactInfoChangedEvent
		{
			[Token(Token = "0x600634A")]
			[Address(RVA = "0xAF56", Offset = "0xAF56", VA = "0xAF56")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600634B")]
			[Address(RVA = "0xAF57", Offset = "0xAF57", VA = "0xAF57")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000236 RID: 566
		// (add) Token: 0x0600634C RID: 25420 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600634D RID: 25421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000236")]
		public event Action IsMostPowerfulChangedEvent
		{
			[Token(Token = "0x600634C")]
			[Address(RVA = "0xAF58", Offset = "0xAF58", VA = "0xAF58")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600634D")]
			[Address(RVA = "0xAF59", Offset = "0xAF59", VA = "0xAF59")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000237 RID: 567
		// (add) Token: 0x0600634E RID: 25422 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600634F RID: 25423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000237")]
		public event Action SlotIdChangedEvent
		{
			[Token(Token = "0x600634E")]
			[Address(RVA = "0xAF5A", Offset = "0xAF5A", VA = "0xAF5A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600634F")]
			[Address(RVA = "0xAF5B", Offset = "0xAF5B", VA = "0xAF5B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006351 RID: 25425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013BD")]
		public SkillCollection UserSkills
		{
			[Token(Token = "0x6006350")]
			[Address(RVA = "0xAF5C", Offset = "0xAF5C", VA = "0xAF5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006351")]
			[Address(RVA = "0xAF5D", Offset = "0xAF5D", VA = "0xAF5D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006353 RID: 25427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013BE")]
		public SkillCollection Power
		{
			[Token(Token = "0x6006352")]
			[Address(RVA = "0xAF5E", Offset = "0xAF5E", VA = "0xAF5E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006353")]
			[Address(RVA = "0xAF5F", Offset = "0xAF5F", VA = "0xAF5F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06006354 RID: 25428 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006355 RID: 25429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013BF")]
		public SkillCollection PowerNormalized
		{
			[Token(Token = "0x6006354")]
			[Address(RVA = "0xAF60", Offset = "0xAF60", VA = "0xAF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006355")]
			[Address(RVA = "0xAF61", Offset = "0xAF61", VA = "0xAF61")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x000129C0 File Offset: 0x00010BC0
		// (set) Token: 0x06006357 RID: 25431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C0")]
		public long PowerNormalizedTotal
		{
			[Token(Token = "0x6006356")]
			[Address(RVA = "0xAF62", Offset = "0xAF62", VA = "0xAF62")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6006357")]
			[Address(RVA = "0xAF63", Offset = "0xAF63", VA = "0xAF63")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x000129D8 File Offset: 0x00010BD8
		// (set) Token: 0x06006359 RID: 25433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C1")]
		public bool IsMostPowerful
		{
			[Token(Token = "0x6006358")]
			[Address(RVA = "0xAF64", Offset = "0xAF64", VA = "0xAF64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006359")]
			[Address(RVA = "0x1DA0", Offset = "0x1DA0", VA = "0x1DA0")]
			set
			{
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600635A RID: 25434 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600635B RID: 25435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C2")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600635A")]
			[Address(RVA = "0xAF65", Offset = "0xAF65", VA = "0xAF65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600635B")]
			[Address(RVA = "0xAF66", Offset = "0xAF66", VA = "0xAF66")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600635D RID: 25437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C3")]
		public UserData OwnerUser
		{
			[Token(Token = "0x600635C")]
			[Address(RVA = "0xAF67", Offset = "0xAF67", VA = "0xAF67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600635D")]
			[Address(RVA = "0xAF68", Offset = "0xAF68", VA = "0xAF68")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600635E RID: 25438 RVA: 0x000129F0 File Offset: 0x00010BF0
		// (set) Token: 0x0600635F RID: 25439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C4")]
		public bool IsFavorite
		{
			[Token(Token = "0x600635E")]
			[Address(RVA = "0xAF69", Offset = "0xAF69", VA = "0xAF69")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600635F")]
			[Address(RVA = "0xAF6A", Offset = "0xAF6A", VA = "0xAF6A")]
			set
			{
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x06006360 RID: 25440 RVA: 0x00012A08 File Offset: 0x00010C08
		// (set) Token: 0x06006361 RID: 25441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C5")]
		public int SlotId
		{
			[Token(Token = "0x6006360")]
			[Address(RVA = "0xAF6B", Offset = "0xAF6B", VA = "0xAF6B")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006361")]
			[Address(RVA = "0x216B", Offset = "0x216B", VA = "0x216B")]
			set
			{
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06006362 RID: 25442 RVA: 0x00012A20 File Offset: 0x00010C20
		// (set) Token: 0x06006363 RID: 25443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C6")]
		public bool IsFresh
		{
			[Token(Token = "0x6006362")]
			[Address(RVA = "0xAF6C", Offset = "0xAF6C", VA = "0xAF6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006363")]
			[Address(RVA = "0xAF6D", Offset = "0xAF6D", VA = "0xAF6D")]
			set
			{
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06006364 RID: 25444 RVA: 0x00012A38 File Offset: 0x00010C38
		// (set) Token: 0x06006365 RID: 25445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013C7")]
		public bool IsFreshWatched
		{
			[Token(Token = "0x6006364")]
			[Address(RVA = "0xAF6E", Offset = "0xAF6E", VA = "0xAF6E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006365")]
			[Address(RVA = "0xAF6F", Offset = "0xAF6F", VA = "0xAF6F")]
			set
			{
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06006366 RID: 25446 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013C8")]
		public ArtifactInfo ArtifactInfo
		{
			[Token(Token = "0x6006366")]
			[Address(RVA = "0xAF70", Offset = "0xAF70", VA = "0xAF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006367")]
		[Address(RVA = "0xAF71", Offset = "0xAF71", VA = "0xAF71")]
		public void SetArtifactInfo(ArtifactInfo value, IDictProvider dictProvider)
		{
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x00012A50 File Offset: 0x00010C50
		[Token(Token = "0x170013C9")]
		public ulong ArtifactId
		{
			[Token(Token = "0x6006368")]
			[Address(RVA = "0x1F16", Offset = "0x1F16", VA = "0x1F16")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013CA")]
		public string TitleToLower
		{
			[Token(Token = "0x6006369")]
			[Address(RVA = "0xAF72", Offset = "0xAF72", VA = "0xAF72")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600636A RID: 25450 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x170013CB")]
		public override int CurrentDurability
		{
			[Token(Token = "0x600636A")]
			[Address(RVA = "0xAF73", Offset = "0xAF73", VA = "0xAF73", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x00012A80 File Offset: 0x00010C80
		[Token(Token = "0x170013CC")]
		public override int MaxDurability
		{
			[Token(Token = "0x600636B")]
			[Address(RVA = "0xAF74", Offset = "0xAF74", VA = "0xAF74", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x00012A98 File Offset: 0x00010C98
		[Token(Token = "0x170013CD")]
		public override int StackLimit
		{
			[Token(Token = "0x600636C")]
			[Address(RVA = "0xAF75", Offset = "0xAF75", VA = "0xAF75", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x00012AB0 File Offset: 0x00010CB0
		[Token(Token = "0x170013CE")]
		public int MinLevel
		{
			[Token(Token = "0x600636D")]
			[Address(RVA = "0xAF76", Offset = "0xAF76", VA = "0xAF76")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x0600636E RID: 25454 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[Token(Token = "0x170013CF")]
		public int Cult
		{
			[Token(Token = "0x600636E")]
			[Address(RVA = "0xAF77", Offset = "0xAF77", VA = "0xAF77")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600636F RID: 25455 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[Token(Token = "0x170013D0")]
		public int Rank
		{
			[Token(Token = "0x600636F")]
			[Address(RVA = "0xAF78", Offset = "0xAF78", VA = "0xAF78")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x170013D1")]
		public bool IsRestorable
		{
			[Token(Token = "0x6006370")]
			[Address(RVA = "0xAF79", Offset = "0xAF79", VA = "0xAF79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06006371 RID: 25457 RVA: 0x00012B10 File Offset: 0x00010D10
		[Token(Token = "0x170013D2")]
		public bool IsForgeable
		{
			[Token(Token = "0x6006371")]
			[Address(RVA = "0xAF7A", Offset = "0xAF7A", VA = "0xAF7A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06006372 RID: 25458 RVA: 0x00012B28 File Offset: 0x00010D28
		[Token(Token = "0x170013D3")]
		public bool IsTemporaryWithCriticalLifetime
		{
			[Token(Token = "0x6006372")]
			[Address(RVA = "0xAF7B", Offset = "0xAF7B", VA = "0xAF7B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06006373 RID: 25459 RVA: 0x00012B40 File Offset: 0x00010D40
		[Token(Token = "0x170013D4")]
		public bool IsTemporaryWithExpiredLifetime
		{
			[Token(Token = "0x6006373")]
			[Address(RVA = "0xAF7C", Offset = "0xAF7C", VA = "0xAF7C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06006374 RID: 25460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013D5")]
		public ResourceSet Price
		{
			[Token(Token = "0x6006374")]
			[Address(RVA = "0xAF7D", Offset = "0xAF7D", VA = "0xAF7D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x06006375 RID: 25461 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006376 RID: 25462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013D6")]
		public ResourceSet SellPrice
		{
			[Token(Token = "0x6006375")]
			[Address(RVA = "0x1F13", Offset = "0x1F13", VA = "0x1F13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006376")]
			[Address(RVA = "0xAF7E", Offset = "0xAF7E", VA = "0xAF7E")]
			set
			{
			}
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x00012B58 File Offset: 0x00010D58
		[Token(Token = "0x6006377")]
		[Address(RVA = "0xAF7F", Offset = "0xAF7F", VA = "0xAF7F")]
		private int GetArtSkillValue(ArtSkillsConsts skill)
		{
			return 0;
		}

		// Token: 0x06006378 RID: 25464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006378")]
		[Address(RVA = "0xAF80", Offset = "0xAF80", VA = "0xAF80")]
		protected ArtifactData()
		{
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06006379 RID: 25465 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013D7")]
		public List<ModifierData> ModifierData
		{
			[Token(Token = "0x6006379")]
			[Address(RVA = "0xAF81", Offset = "0xAF81", VA = "0xAF81")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013D8")]
		public List<ModifierData> SpellsModifierData
		{
			[Token(Token = "0x600637A")]
			[Address(RVA = "0xAF82", Offset = "0xAF82", VA = "0xAF82")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600637B RID: 25467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013D9")]
		public List<ModifierData> CommonModifierData
		{
			[Token(Token = "0x600637B")]
			[Address(RVA = "0xAF83", Offset = "0xAF83", VA = "0xAF83")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600637C RID: 25468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637C")]
		[Address(RVA = "0xAF84", Offset = "0xAF84", VA = "0xAF84")]
		private void UpdateModifiers(IDictProvider dictProvider)
		{
		}

		// Token: 0x0600637D RID: 25469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600637D")]
		[Address(RVA = "0xAF85", Offset = "0xAF85", VA = "0xAF85")]
		private void UpdateUserSkills(IDictProvider dictProvider)
		{
		}

		// Token: 0x0600637E RID: 25470 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x600637E")]
		[Address(RVA = "0xAF86", Offset = "0xAF86", VA = "0xAF86")]
		public bool IsGuideTarget(IGuideTarget target)
		{
			return default(bool);
		}

		// Token: 0x0600637F RID: 25471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600637F")]
		[Address(RVA = "0xAF87", Offset = "0xAF87", VA = "0xAF87")]
		public static ArtifactData Create(ArtifactInfo artifactInfo, UserData loggedUser, IDictProvider dictProvider)
		{
			return null;
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006380")]
		[Address(RVA = "0xAF88", Offset = "0xAF88", VA = "0xAF88")]
		public static ArtifactData CreateEmpty(IDictProvider provider)
		{
			return null;
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006381")]
		[Address(RVA = "0xAF89", Offset = "0xAF89", VA = "0xAF89", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x68")]
		private bool _isMostPowerful;

		// Token: 0x04003542 RID: 13634
		[Token(Token = "0x4003542")]
		[FieldOffset(Offset = "0x74")]
		private ArtifactInfo _artifactInfo;

		// Token: 0x04003543 RID: 13635
		[Token(Token = "0x4003543")]
		[FieldOffset(Offset = "0x78")]
		private bool _isFavorite;

		// Token: 0x04003544 RID: 13636
		[Token(Token = "0x4003544")]
		[FieldOffset(Offset = "0x79")]
		private bool _isFresh;

		// Token: 0x04003545 RID: 13637
		[Token(Token = "0x4003545")]
		[FieldOffset(Offset = "0x7A")]
		private bool _isFreshWatched;

		// Token: 0x04003546 RID: 13638
		[Token(Token = "0x4003546")]
		[FieldOffset(Offset = "0x7C")]
		private int _slotId;

		// Token: 0x04003547 RID: 13639
		[Token(Token = "0x4003547")]
		[FieldOffset(Offset = "0x80")]
		public InventorySlotType SlotType;

		// Token: 0x04003548 RID: 13640
		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x84")]
		private string _titleToLower;

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x88")]
		public readonly BackTime LifeDurationTime;

		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		[FieldOffset(Offset = "0x8C")]
		private List<ModifierData> _modifierData;

		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		[FieldOffset(Offset = "0x90")]
		private bool? _isGuideTarget;
	}
}
