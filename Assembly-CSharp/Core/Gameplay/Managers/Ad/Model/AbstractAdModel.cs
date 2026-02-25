using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements;
using Core.Gameplay.Managers.Ad.Providers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Services;

namespace Core.Gameplay.Managers.Ad.Model
{
	// Token: 0x02001222 RID: 4642
	[Token(Token = "0x2001222")]
	public abstract class AbstractAdModel : AbstractModel, IOptionValidator, IAdPlacementManagerProvider
	{
		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06006DE2 RID: 28130
		[Token(Token = "0x1700164C")]
		public abstract uint[] SupportedAdProviders { [Token(Token = "0x6006DE2")] get; }

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06006DE3 RID: 28131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700164D")]
		public virtual uint[] SupportedAdPlacements
		{
			[Token(Token = "0x6006DE3")]
			[Address(RVA = "0xB89B", Offset = "0xB89B", VA = "0xB89B", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x00014268 File Offset: 0x00012468
		[Token(Token = "0x1700164E")]
		public bool IsFeatureAvailable
		{
			[Token(Token = "0x6006DE4")]
			[Address(RVA = "0xB89C", Offset = "0xB89C", VA = "0xB89C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06006DE5 RID: 28133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700164F")]
		public Dictionary<uint, IAdPlacementData> Placements
		{
			[Token(Token = "0x6006DE5")]
			[Address(RVA = "0xB89D", Offset = "0xB89D", VA = "0xB89D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06006DE6 RID: 28134 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x17001650")]
		public uint DefaultAdProviderId
		{
			[Token(Token = "0x6006DE6")]
			[Address(RVA = "0xB89E", Offset = "0xB89E", VA = "0xB89E")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DE7")]
		[Address(RVA = "0xB89F", Offset = "0xB89F", VA = "0xB89F")]
		public AbstractAdModel(IGame game, UserData user)
		{
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06006DE8 RID: 28136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006DE9 RID: 28137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001651")]
		public AdTransaction CurrentTransaction
		{
			[Token(Token = "0x6006DE8")]
			[Address(RVA = "0xB8A0", Offset = "0xB8A0", VA = "0xB8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DE9")]
			[Address(RVA = "0xB8A1", Offset = "0xB8A1", VA = "0xB8A1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEA")]
		[Address(RVA = "0xB8A2", Offset = "0xB8A2", VA = "0xB8A2")]
		public void InitPlacements(IEnumerable<uint> placementIds, IAdController adController, AdEvents events)
		{
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DEB")]
		[Address(RVA = "0x2247", Offset = "0x2247", VA = "0x2247")]
		protected AbstractAdPlacementManager CreateAdPlacementManagers(IAdPlacementData placementData, IGame game, IAdController adController, AdEvents adEvents, UserData user)
		{
			return null;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x224E", Offset = "0x224E", VA = "0x224E")]
		public void UpdatePlacementInfo(AdPlacementInfo raw)
		{
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x6006DED")]
		[Address(RVA = "0xB8A3", Offset = "0xB8A3", VA = "0xB8A3")]
		public bool TryGetAdPlacementData(uint adPlacement, out IAdPlacementData data)
		{
			return default(bool);
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x6006DEE")]
		[Address(RVA = "0xB8A4", Offset = "0xB8A4", VA = "0xB8A4", Slot = "7")]
		public bool TryGetAdPlacementManager(uint adPlacement, out AbstractAdPlacementManager manager)
		{
			return default(bool);
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x6006DEF")]
		[Address(RVA = "0xB8A5", Offset = "0xB8A5", VA = "0xB8A5", Slot = "6")]
		private bool IsOptionValid(BankOptionData bankOptionData)
		{
			return default(bool);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF0")]
		[Address(RVA = "0xB8A6", Offset = "0xB8A6", VA = "0xB8A6", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0400397D RID: 14717
		[Token(Token = "0x400397D")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<uint, IAdPlacementData> _placements;

		// Token: 0x0400397E RID: 14718
		[Token(Token = "0x400397E")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<uint, AbstractAdPlacementManager> _placementManagers;

		// Token: 0x0400397F RID: 14719
		[Token(Token = "0x400397F")]
		[FieldOffset(Offset = "0x18")]
		public readonly IGame Game;
	}
}
