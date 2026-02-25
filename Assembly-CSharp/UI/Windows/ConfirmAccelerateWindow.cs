using System;
using Il2CppDummyDll;
using Protocol.Common;

namespace UI.Windows
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	public static class ConfirmAccelerateWindow
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x6178", Offset = "0x6178", VA = "0x6178")]
		public static BaseWindow Show(ConfirmAccelerateWindow.AccelerateType type, double upgradeTime, double diamondsToTimeRate, double availableDiamonds, Action successCallback)
		{
			return null;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x6179", Offset = "0x6179", VA = "0x6179")]
		public static DialogWindow ShowForClan(ConfirmAccelerateWindow.AccelerateType type, double upgradeTime, double diamondsToTimeRate, ResourceSet clanResources, Action successCallback)
		{
			return null;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x617A", Offset = "0x617A", VA = "0x617A")]
		private static DialogWindow ShowWindow(ConfirmAccelerateWindow.AccelerateType type, double upgradeTime, double diamondsToTimeRate, double availableDiamonds, Action successCallback)
		{
			return null;
		}

		// Token: 0x02000286 RID: 646
		[Token(Token = "0x2000286")]
		public enum AccelerateType
		{
			// Token: 0x040007C1 RID: 1985
			[Token(Token = "0x40007C1")]
			NONE,
			// Token: 0x040007C2 RID: 1986
			[Token(Token = "0x40007C2")]
			ACCELERATE_STUDIES,
			// Token: 0x040007C3 RID: 1987
			[Token(Token = "0x40007C3")]
			ACCELERATE_BUILDING,
			// Token: 0x040007C4 RID: 1988
			[Token(Token = "0x40007C4")]
			ACCELERATE_IMPROVING,
			// Token: 0x040007C5 RID: 1989
			[Token(Token = "0x40007C5")]
			ACCELERATE_PRODUCTION
		}
	}
}
