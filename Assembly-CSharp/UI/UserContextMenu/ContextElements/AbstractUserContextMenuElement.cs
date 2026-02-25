using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	public abstract class AbstractUserContextMenuElement
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600092F RID: 2351
		[Token(Token = "0x1700012D")]
		public abstract UserMenuActionDic.Types.Actions ActionId { [Token(Token = "0x600092F")] get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700012E")]
		public string Title
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x5CAC", Offset = "0x5CAC", VA = "0x5CAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x1700012F")]
		public uint Position
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x5CAD", Offset = "0x5CAD", VA = "0x5CAD")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000130")]
		public string IconAssetId
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x5CAE", Offset = "0x5CAE", VA = "0x5CAE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000933 RID: 2355
		[Token(Token = "0x6000933")]
		public abstract bool Validate(IUserMenuContext context);

		// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x5CAF", Offset = "0x5CAF", VA = "0x5CAF", Slot = "6")]
		public virtual void Setup(IUserMenuContext context)
		{
		}

		// Token: 0x06000935 RID: 2357
		[Token(Token = "0x6000935")]
		public abstract void Handle(IUserMenuContext context);

		// Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x5CB0", Offset = "0x5CB0", VA = "0x5CB0")]
		protected AbstractUserContextMenuElement()
		{
		}

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x8")]
		protected string _title;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0xC")]
		protected uint _position;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x10")]
		protected string _iconAssetId;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x14")]
		private UserMenuActionDic _userMenuActionDic;
	}
}
