using System;
using System.Collections.Generic;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DE0 RID: 3552
	[Token(Token = "0x2000DE0")]
	public interface IAccountDataDecorator : IAccountData
	{
		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060056B5 RID: 22197
		[Token(Token = "0x170011B1")]
		string Title { [Token(Token = "0x60056B5")] get; }

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x060056B6 RID: 22198
		[Token(Token = "0x170011B2")]
		AccountDic AccountDic { [Token(Token = "0x60056B6")] get; }

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x060056B7 RID: 22199
		// (set) Token: 0x060056B8 RID: 22200
		[Token(Token = "0x170011B3")]
		IAccountData Account { [Token(Token = "0x60056B7")] get; [Token(Token = "0x60056B8")] set; }

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x060056B9 RID: 22201
		[Token(Token = "0x170011B4")]
		List<AccountOptionData> Options { [Token(Token = "0x60056B9")] get; }

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060056BA RID: 22202
		// (set) Token: 0x060056BB RID: 22203
		[Token(Token = "0x170011B5")]
		OptionStickerDic StickerDic { [Token(Token = "0x60056BA")] get; [Token(Token = "0x60056BB")] set; }

		// Token: 0x060056BC RID: 22204
		[Token(Token = "0x60056BC")]
		void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository);

		// Token: 0x060056BD RID: 22205
		[Token(Token = "0x60056BD")]
		bool TryGetNested(out List<IAccountDataDecorator> accounts);
	}
}
