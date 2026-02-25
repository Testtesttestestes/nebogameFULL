using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F98 RID: 3992
	[Token(Token = "0x2000F98")]
	public static class ResourceSetExt
	{
		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0xABE0", Offset = "0xABE0", VA = "0xABE0")]
		public static ResourceSet Add(this ResourceSet v1, ResourceSet v2)
		{
			return null;
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0xABE1", Offset = "0xABE1", VA = "0xABE1")]
		public static ResourceSet Sub(this ResourceSet v1, ResourceSet v2)
		{
			return null;
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0xABE2", Offset = "0xABE2", VA = "0xABE2")]
		public static ResourceSet GetDelta(this ResourceSet v1, ResourceSet v2)
		{
			return null;
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0xABE3", Offset = "0xABE3", VA = "0xABE3")]
		public static bool IsZero(this ResourceSet v1)
		{
			return default(bool);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0xABE4", Offset = "0xABE4", VA = "0xABE4")]
		public static bool GreaterOrEqual(this ResourceSet moneyAvailable, ResourceSet moneyRequired)
		{
			return default(bool);
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0xABE5", Offset = "0xABE5", VA = "0xABE5")]
		public static bool Less(this ResourceSet moneyAvailable, ResourceSet moneyRequired)
		{
			return default(bool);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0xABE6", Offset = "0xABE6", VA = "0xABE6")]
		public static List<Resources> GetResourcesIds(this ResourceSet rs, double greaterThresholdValue = 0.0)
		{
			return null;
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0xABE7", Offset = "0xABE7", VA = "0xABE7")]
		public static List<Resources> GetNonZeroResourcesesIds(this ResourceSet rs)
		{
			return null;
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0xABE8", Offset = "0xABE8", VA = "0xABE8")]
		public static double GetValue(this Money money, Resources id)
		{
			return 0.0;
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0xABE9", Offset = "0xABE9", VA = "0xABE9")]
		public static bool HasNewCurrency(this Money money)
		{
			return default(bool);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x1AFB", Offset = "0x1AFB", VA = "0x1AFB")]
		public static double GetValue(this ResourceSet rs, Resources id)
		{
			return 0.0;
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0xABEA", Offset = "0xABEA", VA = "0xABEA")]
		public static double SetValue(this ResourceSet rs, Resources id, double value)
		{
			return 0.0;
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0xABEB", Offset = "0xABEB", VA = "0xABEB")]
		public static ResourceSet Floor(this ResourceSet r)
		{
			return null;
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0xABEC", Offset = "0xABEC", VA = "0xABEC")]
		public static ResourceSet Ceil(this ResourceSet r)
		{
			return null;
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0xABED", Offset = "0xABED", VA = "0xABED")]
		public static ResourceSet Round(this ResourceSet r)
		{
			return null;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0xABEE", Offset = "0xABEE", VA = "0xABEE")]
		public static ResourceSet Multiply(this ResourceSet v1, double multiplier)
		{
			return null;
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0xABEF", Offset = "0xABEF", VA = "0xABEF")]
		public static uint GetQuotient(this ResourceSet r, ResourceSet compared)
		{
			return 0U;
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x6005FB5")]
		[Address(RVA = "0xABF0", Offset = "0xABF0", VA = "0xABF0")]
		public static double GetQuotient(this Money money, Money compared)
		{
			return 0.0;
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0xABF1", Offset = "0xABF1", VA = "0xABF1")]
		public static List<ValueTuple<Money.MoneyType, double>> GetResourcesAsList(this ResourceSet rs)
		{
			return null;
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0xABF2", Offset = "0xABF2", VA = "0xABF2")]
		public static RewardInfo ToRewardInfo(this ResourceSet rs)
		{
			return null;
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0xABF3", Offset = "0xABF3", VA = "0xABF3")]
		public static RewardData ToRewardData(this ResourceSet rs)
		{
			return null;
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0xABF4", Offset = "0xABF4", VA = "0xABF4")]
		public static NullableResourceSet ToNullableResourceSet(this ResourceSet value)
		{
			return null;
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0xABF5", Offset = "0xABF5", VA = "0xABF5")]
		public static string ToLocaleString(this Money money, double externalMoneyValue = double.NaN, [Optional] string externalMoneyName, string separatelocaleKey = "AND", bool numberReduction = false, [Optional] string suffix)
		{
			return null;
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0xABF6", Offset = "0xABF6", VA = "0xABF6")]
		public static string ToLocaleString(this ResourceSet rs, double externalMoneyValue = double.NaN, [Optional] string externalMoneyName, string separateLocaleKey = "AND", bool numberReduction = false, [Optional] string suffix)
		{
			return null;
		}
	}
}
