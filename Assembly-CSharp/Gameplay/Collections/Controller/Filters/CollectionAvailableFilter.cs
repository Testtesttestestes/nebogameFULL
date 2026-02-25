using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Collections.Controller.Filters
{
	// Token: 0x020009EA RID: 2538
	[Token(Token = "0x20009EA")]
	public class CollectionAvailableFilter : ICollectionFilter
	{
		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06003CA4 RID: 15524 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003CA5 RID: 15525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF0")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x6003CA4")]
			[Address(RVA = "0x8B6B", Offset = "0x8B6B", VA = "0x8B6B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003CA5")]
			[Address(RVA = "0x8B6C", Offset = "0x8B6C", VA = "0x8B6C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x8B6D", Offset = "0x8B6D", VA = "0x8B6D")]
		public CollectionAvailableFilter(UserData user, IRequirementValidator requirementValidator)
		{
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x8B6E", Offset = "0x8B6E", VA = "0x8B6E", Slot = "6")]
		public bool Filter(CollectionData collectionData)
		{
			return default(bool);
		}

		// Token: 0x04002181 RID: 8577
		[Token(Token = "0x4002181")]
		[FieldOffset(Offset = "0x8")]
		private readonly UserData _user;

		// Token: 0x04002182 RID: 8578
		[Token(Token = "0x4002182")]
		[FieldOffset(Offset = "0xC")]
		private readonly IRequirementValidator _requirementValidator;
	}
}
