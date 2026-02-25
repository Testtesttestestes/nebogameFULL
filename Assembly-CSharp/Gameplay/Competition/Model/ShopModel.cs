using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Bank.Controller;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008FD RID: 2301
	[Token(Token = "0x20008FD")]
	public class ShopModel : AbstractModel
	{
		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABD")]
		public ReadOnlyCollection<BankOptionData> Options
		{
			[Token(Token = "0x600361D")]
			[Address(RVA = "0x862A", Offset = "0x862A", VA = "0x862A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600361E")]
			[Address(RVA = "0x862B", Offset = "0x862B", VA = "0x862B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x862C", Offset = "0x862C", VA = "0x862C")]
		public ShopModel(CompetitionModel model, BankController bankController, UserData user)
		{
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x862D", Offset = "0x862D", VA = "0x862D")]
		public void SetOptions(IList<BankOptionData> options)
		{
		}

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<BankOptionData> _options;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x10")]
		public readonly BankController BankController;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x14")]
		public readonly CompetitionModel CompetitionModel;
	}
}
