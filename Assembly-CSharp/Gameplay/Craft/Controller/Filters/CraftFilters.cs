using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Craft;
using UI.Filters;

namespace Gameplay.Craft.Controller.Filters
{
	// Token: 0x020008D0 RID: 2256
	[Token(Token = "0x20008D0")]
	public class CraftFilters
	{
		// Token: 0x06003534 RID: 13620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x855D", Offset = "0x855D", VA = "0x855D")]
		public CraftFilters()
		{
		}

		// Token: 0x020008D1 RID: 2257
		[Token(Token = "0x20008D1")]
		public class CraftTitleFilter : ICraftFilter
		{
			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06003535 RID: 13621 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003536 RID: 13622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A7D")]
			public FilterInfo FilterInfo
			{
				[Token(Token = "0x6003535")]
				[Address(RVA = "0x855E", Offset = "0x855E", VA = "0x855E", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003536")]
				[Address(RVA = "0x855F", Offset = "0x855F", VA = "0x855F", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06003537 RID: 13623 RVA: 0x0000ACC8 File Offset: 0x00008EC8
			[Token(Token = "0x6003537")]
			[Address(RVA = "0x8560", Offset = "0x8560", VA = "0x8560", Slot = "6")]
			public bool Filter(CraftSchemeData craftSchemeData)
			{
				return default(bool);
			}

			// Token: 0x06003538 RID: 13624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003538")]
			[Address(RVA = "0x8561", Offset = "0x8561", VA = "0x8561")]
			public CraftTitleFilter()
			{
			}
		}

		// Token: 0x020008D2 RID: 2258
		[Token(Token = "0x20008D2")]
		public class AvailableFilter : ICraftFilter
		{
			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06003539 RID: 13625 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600353A RID: 13626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A7E")]
			public FilterInfo FilterInfo
			{
				[Token(Token = "0x6003539")]
				[Address(RVA = "0x8562", Offset = "0x8562", VA = "0x8562", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600353A")]
				[Address(RVA = "0x8563", Offset = "0x8563", VA = "0x8563", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600353B RID: 13627 RVA: 0x0000ACE0 File Offset: 0x00008EE0
			[Token(Token = "0x600353B")]
			[Address(RVA = "0x8564", Offset = "0x8564", VA = "0x8564", Slot = "6")]
			public bool Filter(CraftSchemeData craftSchemeData)
			{
				return default(bool);
			}

			// Token: 0x0600353C RID: 13628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600353C")]
			[Address(RVA = "0x8565", Offset = "0x8565", VA = "0x8565")]
			public AvailableFilter()
			{
			}
		}

		// Token: 0x020008D3 RID: 2259
		[Token(Token = "0x20008D3")]
		public class CraftFilter : ICraftFilter
		{
			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x0600353D RID: 13629 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600353E RID: 13630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A7F")]
			public FilterInfo FilterInfo
			{
				[Token(Token = "0x600353D")]
				[Address(RVA = "0x8566", Offset = "0x8566", VA = "0x8566", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600353E")]
				[Address(RVA = "0x8567", Offset = "0x8567", VA = "0x8567", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600353F RID: 13631 RVA: 0x0000ACF8 File Offset: 0x00008EF8
			[Token(Token = "0x600353F")]
			[Address(RVA = "0x8568", Offset = "0x8568", VA = "0x8568", Slot = "6")]
			public bool Filter(CraftSchemeData craftSchemeData)
			{
				return default(bool);
			}

			// Token: 0x06003540 RID: 13632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003540")]
			[Address(RVA = "0x8569", Offset = "0x8569", VA = "0x8569")]
			public CraftFilter()
			{
			}
		}

		// Token: 0x020008D5 RID: 2261
		[Token(Token = "0x20008D5")]
		public class CompletedFilter : ICraftSlotFilter
		{
			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06003544 RID: 13636 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003545 RID: 13637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A80")]
			public FilterInfo FilterInfo
			{
				[Token(Token = "0x6003544")]
				[Address(RVA = "0x856D", Offset = "0x856D", VA = "0x856D", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003545")]
				[Address(RVA = "0x856E", Offset = "0x856E", VA = "0x856E", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06003546 RID: 13638 RVA: 0x0000AD28 File Offset: 0x00008F28
			[Token(Token = "0x6003546")]
			[Address(RVA = "0x856F", Offset = "0x856F", VA = "0x856F", Slot = "6")]
			public bool Filter(UserCraftSlotInfo craftSlotInfo)
			{
				return default(bool);
			}

			// Token: 0x06003547 RID: 13639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003547")]
			[Address(RVA = "0x8570", Offset = "0x8570", VA = "0x8570")]
			public CompletedFilter()
			{
			}
		}
	}
}
