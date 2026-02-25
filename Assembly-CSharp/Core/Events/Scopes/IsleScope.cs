using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Events.Scopes
{
	// Token: 0x0200100D RID: 4109
	[Token(Token = "0x200100D")]
	public class IsleScope : AbstractEventBusScope
	{
		// Token: 0x06006156 RID: 24918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006156")]
		[Address(RVA = "0xAD81", Offset = "0xAD81", VA = "0xAD81", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006157")]
		[Address(RVA = "0xAD82", Offset = "0xAD82", VA = "0xAD82")]
		public IsleScope()
		{
		}

		// Token: 0x04003431 RID: 13361
		[Token(Token = "0x4003431")]
		[FieldOffset(Offset = "0x8")]
		public Action<IsleScope.IsleBonusEventArgs> IsleBonusCollectedEvent;

		// Token: 0x04003432 RID: 13362
		[Token(Token = "0x4003432")]
		[FieldOffset(Offset = "0xC")]
		public Action<IsleScope.IsleAnimationButtonClickEventArgs> IsleAnimationButtonClickEvent;

		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		[FieldOffset(Offset = "0x10")]
		public Action<IsleScope.BuildingEventArgs> StartBuildEvent;

		// Token: 0x04003434 RID: 13364
		[Token(Token = "0x4003434")]
		[FieldOffset(Offset = "0x14")]
		public Action<IsleScope.BuildingEventArgs> CancelBuildEvent;

		// Token: 0x04003435 RID: 13365
		[Token(Token = "0x4003435")]
		[FieldOffset(Offset = "0x18")]
		public Action<IsleScope.BuildingEventArgs> AccelerateBuildEvent;

		// Token: 0x0200100E RID: 4110
		[Token(Token = "0x200100E")]
		public class IsleBonusEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001349 RID: 4937
			// (get) Token: 0x06006158 RID: 24920 RVA: 0x00011C40 File Offset: 0x0000FE40
			[Token(Token = "0x17001349")]
			public Resources Resource
			{
				[Token(Token = "0x6006158")]
				[Address(RVA = "0xAD83", Offset = "0xAD83", VA = "0xAD83")]
				[CompilerGenerated]
				get
				{
					return Resources.UnknownResource;
				}
			}

			// Token: 0x1700134A RID: 4938
			// (get) Token: 0x06006159 RID: 24921 RVA: 0x00011C58 File Offset: 0x0000FE58
			[Token(Token = "0x1700134A")]
			public ulong OwnerId
			{
				[Token(Token = "0x6006159")]
				[Address(RVA = "0xAD84", Offset = "0xAD84", VA = "0xAD84")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x0600615A RID: 24922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600615A")]
			[Address(RVA = "0xAD85", Offset = "0xAD85", VA = "0xAD85")]
			public IsleBonusEventArgs(App app, IGame game, Resources resource, ulong ownerId)
			{
			}
		}

		// Token: 0x0200100F RID: 4111
		[Token(Token = "0x200100F")]
		public class IsleAnimationButtonClickEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700134B RID: 4939
			// (get) Token: 0x0600615B RID: 24923 RVA: 0x00011C70 File Offset: 0x0000FE70
			[Token(Token = "0x1700134B")]
			public uint AnimationId
			{
				[Token(Token = "0x600615B")]
				[Address(RVA = "0xAD86", Offset = "0xAD86", VA = "0xAD86")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x0600615C RID: 24924 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600615C")]
			[Address(RVA = "0xAD87", Offset = "0xAD87", VA = "0xAD87")]
			public IsleAnimationButtonClickEventArgs(IApp app, IGame game, uint animationId)
			{
			}
		}

		// Token: 0x02001010 RID: 4112
		[Token(Token = "0x2001010")]
		public class BuildingEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700134C RID: 4940
			// (get) Token: 0x0600615D RID: 24925 RVA: 0x00011C88 File Offset: 0x0000FE88
			[Token(Token = "0x1700134C")]
			public uint BuildingType
			{
				[Token(Token = "0x600615D")]
				[Address(RVA = "0xAD88", Offset = "0xAD88", VA = "0xAD88")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x1700134D RID: 4941
			// (get) Token: 0x0600615E RID: 24926 RVA: 0x00011CA0 File Offset: 0x0000FEA0
			[Token(Token = "0x1700134D")]
			public uint Level
			{
				[Token(Token = "0x600615E")]
				[Address(RVA = "0xAD89", Offset = "0xAD89", VA = "0xAD89")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x1700134E RID: 4942
			// (get) Token: 0x0600615F RID: 24927 RVA: 0x00011CB8 File Offset: 0x0000FEB8
			[Token(Token = "0x1700134E")]
			public ulong OwnerId
			{
				[Token(Token = "0x600615F")]
				[Address(RVA = "0xAD8A", Offset = "0xAD8A", VA = "0xAD8A")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x06006160 RID: 24928 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006160")]
			[Address(RVA = "0xAD8B", Offset = "0xAD8B", VA = "0xAD8B")]
			public BuildingEventArgs(App app, IGame game, uint buildingType, uint level, ulong ownerId)
			{
			}
		}
	}
}
