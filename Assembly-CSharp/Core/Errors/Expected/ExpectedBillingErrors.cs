using System;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x02001043 RID: 4163
	[Token(Token = "0x2001043")]
	public class ExpectedBillingErrors : ExpectedDefaultError
	{
		// Token: 0x06006201 RID: 25089 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x6006201")]
		[Address(RVA = "0xAE2C", Offset = "0xAE2C", VA = "0xAE2C", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x6006202")]
		[Address(RVA = "0xAE2D", Offset = "0xAE2D", VA = "0xAE2D")]
		public static Resources GetResourceIdByErrorCode(BillingErrors errorCode)
		{
			return Resources.UnknownResource;
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6006203")]
		[Address(RVA = "0xAE2E", Offset = "0xAE2E", VA = "0xAE2E")]
		public static BillingErrors GetErrorCode(ResourceSet current, ResourceSet required)
		{
			return BillingErrors.AllOkBillingError;
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6006204")]
		[Address(RVA = "0xAE2F", Offset = "0xAE2F", VA = "0xAE2F")]
		public static bool Check(ResourceSet current, ResourceSet total)
		{
			return default(bool);
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006205")]
		[Address(RVA = "0xAE30", Offset = "0xAE30", VA = "0xAE30")]
		public static BaseWindow ShowNotEnoughResourcesWindow(Resources resourceId)
		{
			return null;
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006206")]
		[Address(RVA = "0xAE31", Offset = "0xAE31", VA = "0xAE31")]
		public static DialogWindow ShowUserBannedWindow()
		{
			return null;
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006207")]
		[Address(RVA = "0xAE32", Offset = "0xAE32", VA = "0xAE32")]
		public ExpectedBillingErrors()
		{
		}
	}
}
