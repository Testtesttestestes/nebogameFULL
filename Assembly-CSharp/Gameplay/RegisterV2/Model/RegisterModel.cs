using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.RegisterV2.Model
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	public class RegisterModel : AbstractModel
	{
		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700061B")]
		public string NickPattern
		{
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x72BB", Offset = "0x72BB", VA = "0x72BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700061C")]
		public List<AprDic> CurrentGenderAprs
		{
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x72BC", Offset = "0x72BC", VA = "0x72BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061D")]
		public bool IsRegisterProcessing
		{
			[Token(Token = "0x600215B")]
			[Address(RVA = "0x72BD", Offset = "0x72BD", VA = "0x72BD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x72BE", Offset = "0x72BE", VA = "0x72BE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215D")]
		[Address(RVA = "0x72BF", Offset = "0x72BF", VA = "0x72BF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215E")]
		[Address(RVA = "0x72C0", Offset = "0x72C0", VA = "0x72C0")]
		public RegisterModel(IGame game, UserData user)
		{
		}

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0xC")]
		public readonly uint PointerId;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider Dict;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x14")]
		public List<CultDic> Cults;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<uint, List<AprDic>> GendersByCults;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x1C")]
		public string CurrentNick;

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> PossibleNicks;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x24")]
		public uint CurrentCult;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x28")]
		public AprDic CurrentApr;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x2C")]
		private string _nickPattern;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x34")]
		public readonly IGame Game;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x38")]
		public readonly IRegistrationProvider RegistrationProvider;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x3C")]
		public readonly IGameResolver GameResolver;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x40")]
		public readonly Regex NickRegex;
	}
}
