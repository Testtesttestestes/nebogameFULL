using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F8C RID: 3980
	[Token(Token = "0x2000F8C")]
	public static class PortalDicExt
	{
		// Token: 0x06005F7F RID: 24447 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0xABC0", Offset = "0xABC0", VA = "0xABC0")]
		public static string GetMessage(this PortalDic dict, PortalDic.Types.ContentString type)
		{
			return null;
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0xABC1", Offset = "0xABC1", VA = "0xABC1")]
		public static string GetAssetId(this PortalDic dict, PortalDic.Types.ContentResource idx)
		{
			return null;
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F81")]
		[Address(RVA = "0xABC2", Offset = "0xABC2", VA = "0xABC2")]
		public static string GetCurrencyIcon32(this PortalDic dic)
		{
			return null;
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F82")]
		[Address(RVA = "0xABC3", Offset = "0xABC3", VA = "0xABC3")]
		public static string GetCurrencyIcon64(this PortalDic dic)
		{
			return null;
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F83")]
		[Address(RVA = "0x1BE8", Offset = "0x1BE8", VA = "0x1BE8")]
		public static string GetCurrencyIcon60x66(this PortalDic dic)
		{
			return null;
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F84")]
		[Address(RVA = "0xABC4", Offset = "0xABC4", VA = "0xABC4")]
		public static string GetRewardIcon(this PortalDic dic)
		{
			return null;
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F85")]
		[Address(RVA = "0xABC5", Offset = "0xABC5", VA = "0xABC5")]
		public static string GetPopupDecor(this PortalDic dic)
		{
			return null;
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0xABC6", Offset = "0xABC6", VA = "0xABC6")]
		public static PortalDic GetPortalDic(this Dictionaries dict, uint portalId)
		{
			return null;
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0xABC7", Offset = "0xABC7", VA = "0xABC7")]
		public static PortalStageDic GetPortalStageDic(this Dictionaries dict, uint portalStageId, uint portalId)
		{
			return null;
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F88")]
		[Address(RVA = "0xABC8", Offset = "0xABC8", VA = "0xABC8")]
		public static PortalStageDic GetPrevPortalStageDic(this Dictionaries dict, uint portalStageId, uint portalId)
		{
			return null;
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0xABC9", Offset = "0xABC9", VA = "0xABC9")]
		public static PortalStageDic GetPortalStageDic(this Dictionaries dict, uint portalId, int index)
		{
			return null;
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0xABCA", Offset = "0xABCA", VA = "0xABCA")]
		public static List<PortalStageDic> GetPortalStages(this Dictionaries dict, uint portalId)
		{
			return null;
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x1C98", Offset = "0x1C98", VA = "0x1C98")]
		public static int GetPortalStageIndex(this Dictionaries dict, uint portalStageId, uint portalId)
		{
			return 0;
		}
	}
}
