using System;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using UI.Windows;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x0200107E RID: 4222
	[Token(Token = "0x200107E")]
	public class ExpectedClanBillingErrors : ExpectedDefaultError
	{
		// Token: 0x0600628F RID: 25231 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x600628F")]
		[Address(RVA = "0xAEB5", Offset = "0xAEB5", VA = "0xAEB5", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x6006290")]
		[Address(RVA = "0xAEB6", Offset = "0xAEB6", VA = "0xAEB6")]
		public static bool Check(ResourceSet balance, ResourceSet price)
		{
			return default(bool);
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006291")]
		[Address(RVA = "0xAEB7", Offset = "0xAEB7", VA = "0xAEB7")]
		public static DialogWindow ShowNotEnoughResourcesWindow(Money deficientResources)
		{
			return null;
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006292")]
		[Address(RVA = "0xAEB8", Offset = "0xAEB8", VA = "0xAEB8")]
		public ExpectedClanBillingErrors()
		{
		}
	}
}
