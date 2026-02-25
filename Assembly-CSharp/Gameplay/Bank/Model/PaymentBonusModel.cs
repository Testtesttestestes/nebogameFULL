using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Services;
using Utils;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C5D RID: 3165
	[Token(Token = "0x2000C5D")]
	public class PaymentBonusModel : AbstractModel
	{
		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D4B RID: 19787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA7")]
		public BackTime CurrentBackime
		{
			[Token(Token = "0x6004D4A")]
			[Address(RVA = "0x9B83", Offset = "0x9B83", VA = "0x9B83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D4B")]
			[Address(RVA = "0x9B84", Offset = "0x9B84", VA = "0x9B84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D4D RID: 19789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA8")]
		public PaymentBonusesDic CurrentPaymentBonusesDic
		{
			[Token(Token = "0x6004D4C")]
			[Address(RVA = "0x9B85", Offset = "0x9B85", VA = "0x9B85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D4D")]
			[Address(RVA = "0x9B86", Offset = "0x9B86", VA = "0x9B86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D4F RID: 19791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA9")]
		public RepeatedField<RewardInfo> CurrentRewards
		{
			[Token(Token = "0x6004D4E")]
			[Address(RVA = "0x9B87", Offset = "0x9B87", VA = "0x9B87")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D4F")]
			[Address(RVA = "0x9B88", Offset = "0x9B88", VA = "0x9B88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		[Token(Token = "0x17000FAA")]
		public bool IsBonusValid
		{
			[Token(Token = "0x6004D50")]
			[Address(RVA = "0x9B89", Offset = "0x9B89", VA = "0x9B89")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x9B8A", Offset = "0x9B8A", VA = "0x9B8A")]
		public PaymentBonusModel(UserData user)
		{
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x9B8B", Offset = "0x9B8B", VA = "0x9B8B")]
		public void SetCurrentBonus(ProtoGetPaymentBonusAns result)
		{
		}
	}
}
