using System;
using Core.Application;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.App
{
	// Token: 0x020011EE RID: 4590
	[Token(Token = "0x20011EE")]
	public class ConnectAppLocator : ILocator, IDisposable
	{
		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162F")]
		public string[] Schemes
		{
			[Token(Token = "0x6006CFF")]
			[Address(RVA = "0xB7E8", Offset = "0xB7E8", VA = "0xB7E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06006D00 RID: 27904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001630")]
		public string Host
		{
			[Token(Token = "0x6006D00")]
			[Address(RVA = "0xB7E9", Offset = "0xB7E9", VA = "0xB7E9", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D01")]
		[Address(RVA = "0xB7EA", Offset = "0xB7EA", VA = "0xB7EA", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D02")]
		[Address(RVA = "0xB7EB", Offset = "0xB7EB", VA = "0xB7EB")]
		public ConnectAppLocator(IApp app)
		{
		}

		// Token: 0x06006D03 RID: 27907 RVA: 0x00014100 File Offset: 0x00012300
		[Token(Token = "0x6006D03")]
		[Address(RVA = "0xB7EC", Offset = "0xB7EC", VA = "0xB7EC", Slot = "6")]
		public bool TryExecute(Uri uri)
		{
			return default(bool);
		}

		// Token: 0x06006D04 RID: 27908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006D04")]
		[Address(RVA = "0xB7ED", Offset = "0xB7ED", VA = "0xB7ED", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x8")]
		private IApp _app;
	}
}
