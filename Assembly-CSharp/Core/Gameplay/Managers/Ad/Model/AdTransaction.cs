using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Services;

namespace Core.Gameplay.Managers.Ad.Model
{
	// Token: 0x02001223 RID: 4643
	[Token(Token = "0x2001223")]
	public class AdTransaction
	{
		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06006DF1 RID: 28145 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x17001652")]
		public AdSource Source
		{
			[Token(Token = "0x6006DF1")]
			[Address(RVA = "0xB8A7", Offset = "0xB8A7", VA = "0xB8A7")]
			[CompilerGenerated]
			get
			{
				return AdSource.UnknownSource;
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06006DF2 RID: 28146 RVA: 0x000142F8 File Offset: 0x000124F8
		[Token(Token = "0x17001653")]
		public AdPlacement ADPlacement
		{
			[Token(Token = "0x6006DF2")]
			[Address(RVA = "0xB8A8", Offset = "0xB8A8", VA = "0xB8A8")]
			[CompilerGenerated]
			get
			{
				return AdPlacement.UnknownAdPlacement;
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06006DF3 RID: 28147 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x17001654")]
		public uint OptionId
		{
			[Token(Token = "0x6006DF3")]
			[Address(RVA = "0xB8A9", Offset = "0xB8A9", VA = "0xB8A9")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006DF5 RID: 28149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001655")]
		public CreateAdPlacementTxCmd.Types.Ans Payload
		{
			[Token(Token = "0x6006DF4")]
			[Address(RVA = "0xB8AA", Offset = "0xB8AA", VA = "0xB8AA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006DF5")]
			[Address(RVA = "0xB8AB", Offset = "0xB8AB", VA = "0xB8AB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06006DF6 RID: 28150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001656")]
		[CanBeNull]
		public string TransactionId
		{
			[Token(Token = "0x6006DF6")]
			[Address(RVA = "0xB8AC", Offset = "0xB8AC", VA = "0xB8AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF7")]
		[Address(RVA = "0xB8AD", Offset = "0xB8AD", VA = "0xB8AD")]
		public AdTransaction(AdSource source, AdPlacement adPlacement, uint optionId)
		{
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DF8")]
		[Address(RVA = "0xB8AE", Offset = "0xB8AE", VA = "0xB8AE", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
