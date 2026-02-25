using System;
using System.Runtime.CompilerServices;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game
{
	// Token: 0x020011C9 RID: 4553
	[Token(Token = "0x20011C9")]
	public class DefaultGameLocator : ILocator, IDisposable
	{
		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06006C7B RID: 27771 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C7C RID: 27772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700162A")]
		public IGame Game
		{
			[Token(Token = "0x6006C7B")]
			[Address(RVA = "0xB767", Offset = "0xB767", VA = "0xB767")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C7C")]
			[Address(RVA = "0xB768", Offset = "0xB768", VA = "0xB768")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06006C7D RID: 27773 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006C7E RID: 27774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700162B")]
		public IPathNodeFactoryRepository PathNodeFactoryRepository
		{
			[Token(Token = "0x6006C7D")]
			[Address(RVA = "0xB769", Offset = "0xB769", VA = "0xB769")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006C7E")]
			[Address(RVA = "0xB76A", Offset = "0xB76A", VA = "0xB76A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C7F")]
		[Address(RVA = "0xB76B", Offset = "0xB76B", VA = "0xB76B", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C80")]
		[Address(RVA = "0xB76C", Offset = "0xB76C", VA = "0xB76C")]
		public DefaultGameLocator(IGame game, IPathNodeFactoryRepository repository)
		{
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06006C81 RID: 27777 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162C")]
		public string[] Schemes
		{
			[Token(Token = "0x6006C81")]
			[Address(RVA = "0xB76D", Offset = "0xB76D", VA = "0xB76D", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06006C82 RID: 27778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162D")]
		public string Host
		{
			[Token(Token = "0x6006C82")]
			[Address(RVA = "0xB76E", Offset = "0xB76E", VA = "0xB76E", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C83")]
		[Address(RVA = "0xB76F", Offset = "0xB76F", VA = "0xB76F")]
		private void ApplyCommonArgs(LocatorPayload payload)
		{
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x00014040 File Offset: 0x00012240
		[Token(Token = "0x6006C84")]
		[Address(RVA = "0xB770", Offset = "0xB770", VA = "0xB770", Slot = "6")]
		public bool TryExecute(Uri uri)
		{
			return default(bool);
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C85")]
		[Address(RVA = "0xB771", Offset = "0xB771", VA = "0xB771", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x8")]
		private OpTokenRepository _tokenRepository;
	}
}
